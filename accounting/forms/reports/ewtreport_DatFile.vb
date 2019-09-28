Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.XtraReports.UI
Public Class ewtreport_DatFile
    Dim ds As New finalewtset
    Dim Month As String
    Private Sub ewtreport_DatFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMonth.DataSource = main.listMonth
        cmbMonth.DisplayMember = "name"
        cmbMonth.ValueMember = "id"
    End Sub
    Private Shared Sub AddText(ByVal fs As FileStream, ByVal value As String)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(value)
        fs.Write(info, 0, info.Length)
    End Sub
    Private Sub saveAs_Click(sender As Object, e As EventArgs) Handles saveAs.Click
        Try
            If cmbMonth.SelectedValue > 9 Then
                Month = String.Format("{0}", cmbMonth.SelectedValue)
            Else
                Month = String.Format("0{0}", cmbMonth.SelectedValue)
            End If
            '  Dim sql As String = String.Format("SELECT  a.trans_id,a.trans_no,a.trans_date 
            ' ,c.offset_type,c.ewt_id,c.amount,c.tax_amount,c.amount_based,c.tax_amount_based 
            ' ,c.fs_ewt_id,REPLACE(e.ewt_code,' ','')ewt_code,removeSpecialChar(e.ewt_name)ewt_name,e.tax_rate 
            ' ,c.general_id,removeSpecialChar(f.general_code)general_code,removeSpecialChar(f.general_name)general_name,'' AS rdo_code 
            ' ,c.currency_id,g.currency_code,g.currency_name 
            ' ,b.project_id,removeSpecialChar(h.project_code)project_code,removeSpecialChar(h.project_name)project_name
            ' ,b.department_id,i.department_code,i.department_name 
            ' ,d.offset_type AS ref_offset_type,d.amount AS ref_amount,d.tax_amount AS ref_tax_amount,d.amount_based AS ref_amount_based,d.tax_amount_based AS ref_tax_amount_based 
            ' ,d.trans_no AS dn_ref
            ' FROM {1}.trans_header a 
            ' LEFT JOIN {1}.trans_jbooks b ON b.trans_id = a.trans_id 
            ' LEFT JOIN {1}.trans_ewt c ON c.jbooks_id = b.jbooks_id 
            ' LEFT JOIN (
            '     SELECT a.offset_type,a.ref_ewt_id AS ewt_id,SUM(a.amount) AS amount,SUM(a.tax_amount) AS tax_amount,SUM(a.amount_based) AS amount_based,SUM(a.tax_amount_based) AS tax_amount_based,c.trans_no 
            '     FROM {1}.trans_ewt a 
            '     LEFT JOIN {1}.trans_jbooks b ON b.jbooks_id = a.jbooks_id 
            '     LEFT JOIN {1}.trans_header c ON c.trans_id = b.trans_id 
            '     GROUP BY a.ref_ewt_id,a.offset_type 
            ' ) d ON d.ewt_id = c.ewt_id 
            ' LEFT JOIN {0}.lib_acc_ewt e ON e.ewt_id = c.fs_ewt_id 
            ' left JOIN {0}.lib_erp_general f ON f.general_id = c.general_id 
            ' LEFT JOIN {0}.lib_erp_currency g ON g.currency_id = c.currency_id 
            ' LEFT JOIN {0}.lib_erp_project h ON h.project_id = b.project_id 
            ' LEFT JOIN {0}.lib_erp_department i ON i.department_id = b.department_id 
            ' LEFT JOIN {0}.lib_erp_chart j ON j.account_id = b.account_id
            'where DATE_FORMAT(a.trans_date ,'%m-%Y')='{2}-{3}' AND IFNULL(c.ewt_id,'') <> '' AND IFNULL(c.offset_type,0) = 0  ", _serverDBFS, _serverDBMain, Month, txt_year.Text)
            '  sql += String.Format(" and e.ewt_code <> '' AND c.amount > 0 and f.general_name <> ''")
            Dim sql As String = String.Format("SELECT
	                                        a.trans_no,
	                                        a.trans_date,
	                                        c.tax_rate,
	                                        SUM(c.amount_based) AS amount_based,
	                                        SUM(c.tax_amount_based) AS tax_amount_based,
	                                        IF(IFNULL(d.general_name_bir,'')='',removeSpecialChar(d.general_name),d.general_name_bir) AS general_name,
	                                        d.tin,
	                                        d.address1 AS address,
	                                        d.Date,
	                                        '' AS rdo_code,
	                                        g.ewt_code,
	                                        g.ewt_name,
	                                        e.project_name,
	                                        f.department_name,
	                                        c.ewt_id
                                        FROM
	                                        {4}.trans_header a
                                        LEFT JOIN {4}.trans_jbooks b ON b.trans_id = a.trans_id
                                        LEFT JOIN {4}.trans_ewt c ON c.jbooks_id = b.jbooks_id
                                        LEFT JOIN {0}.lib_erp_general d ON d.general_id = c.general_id
                                        LEFT JOIN {0}.lib_erp_project e ON e.project_id = b.project_id
                                        LEFT JOIN {0}.lib_erp_department f ON f.department_id = b.department_id
                                        LEFT JOIN {0}.lib_acc_ewt g ON g.ewt_id = c.fs_ewt_id
                                        LEFT JOIN {0}.lib_erp_chart h ON h.account_id = b.account_id
                                        WHERE
	                                        h.validation = 4
                                        AND DATE_FORMAT(a.trans_date, '%m-%Y') = '{2}-{3}'
                                        AND IFNULL(c.ref_ewt_id, '') = ''
                                        AND IFNULL(c.ewt_id, '') <> ''
                                        AND d.general_name <> ''
                                        GROUP BY
	                                        c.general_id", _serverDBFS, _serverDBMain, Month, txt_year.Text, _serverDBMain)
            Dim sql_company As String = String.Format("SELECT removeSpecialChar(b.company_name)company_name,removeSpecialChar(b.address1) AS address,b.tin,c.currency_name,b.rdo_code " &
                                                  "FROM {1}.sys_default a " &
                                                  "LEFT JOIN {0}.lib_erp_company b ON b.company_id = a.company_id " &
                                                  "LEFT JOIN {0}.lib_erp_currency c ON c.currency_id = a.currency_id", _serverDBFS, _serverDBMain)
            Dim dt_balance As DataTable = FsQuery(sql)
            Dim dt_company As DataTable = FsQuery(sql_company)

            If dt_balance.Rows.Count = 0 Then
                MsgBox("No Records to Print.")
                Exit Sub
            End If
            ds.Tables("Accounts").Clear()
            ds.Tables("Company").Clear()

            For Each row As DataRow In dt_balance.Rows
                ds.Tables("Accounts").ImportRow(row)
            Next
            For Each row As DataRow In dt_company.Rows
                ds.Tables("Company").ImportRow(row)
            Next
            If folderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim fileName As String = String.Format("{0}{1}{2}1601E.dat", ds.Tables("Company").Rows(0).Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9), Month, txt_year.Text.PadLeft(4, "0"))
                Dim path As String = folderBrowser.SelectedPath & "\" & fileName
                If File.Exists(path) Then
                    Dim delete = MsgBox("File Already Exist. Want to replace with the new one?", MsgBoxStyle.YesNo, "1601E")
                    If delete = MsgBoxResult.No Then
                        Exit Sub
                    End If
                    File.Delete(fileName)
                End If
                Dim fs As FileStream = File.Create(path)
                Dim rdo_code_length As Integer = If(ds.Tables("Company").Rows(0).Item("tin").ToString.Replace("-", "").Replace(" ", "").Substring(9).Length > 3, 4, 3)

                Dim HMAP = String.Format("HMAP,H1601E,{0},{1},""{2}"",{3}/{4},{5}",
                                          ds.Tables("Company").Rows(0).Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9),
                                          ds.Tables("Company").Rows(0).Item("tin").ToString.Replace("-", "").Substring(9, rdo_code_length).PadLeft(4, "0"),
                                          ds.Tables("Company").Rows(0).Item("company_name"),
                                         Month, txt_year.Text.PadLeft(4, "0"),
                                          ds.Tables("Company").Rows(0).Item("rdo_code"))
                Dim DMAP As String = ""
                    Dim ctr As Integer = 1
                    Dim total_tax_rate As Decimal = 0
                Dim total_amount_based As Decimal = 0
                ' Dim tax_amount As Decimal = 0
                AddText(fs, HMAP)
                For Each dr As DataRow In ds.Tables("Accounts").Rows
                    Dim tax_rate As Double = dr.Item("tax_rate")
                    Dim amount_based As Double = dr.Item("amount_based")
                    Dim tax_amount As Double = dr.Item("tax_amount_based")
                    DMAP = String.Format("DMAP,D1601E,{0},{1},{2},""{3}"",,,,{4}/{5},{6},,{7},{8},{9}",
                                         ctr,
                                         dr.Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9),
                                         dr.Item("tin").ToString.Replace("-", "").PadLeft(14, "0").Substring(9, 4).PadLeft(4, "0"),
                                         dr.Item("general_name"),
                                         Month,
                                         txt_year.Text.PadLeft(4, "0"),
                                        Replace(dr.Item("ewt_code"), " ", ""),
                                         Format(tax_rate, "##0.00"),
                                          Format(amount_based, "##0.00"),
                                          Format(tax_amount, "##0.00"))
                    AddText(fs, Environment.NewLine & DMAP)
                    total_tax_rate += ifNull(CDec(ifNull(dr.Item("tax_amount_based"), 0)), 0)
                    total_amount_based += ifNull(dr.Item("amount_based"), 0)

                    ctr += 1
                Next
                Dim CMAP As String = String.Format("CMAP,C1601E,{0},{1},{2}/{3},{4},{5}",
                                                   ds.Tables("Company").Rows(0).Item("tin").ToString.Replace("-", "").PadLeft(9, "0").Substring(0, 9),
                                                   ds.Tables("Company").Rows(0).Item("tin").ToString.Replace("-", "").Substring(9, rdo_code_length).PadLeft(4, "0"),
                                                   Month, txt_year.Text.PadLeft(4, "0"),
                                                   Format(total_amount_based, "##0.00"),
                                                  Format(total_tax_rate, "##0.00"))
                AddText(fs, Environment.NewLine & CMAP)
                    fs.Close()

                MsgBox("Saved!", vbInformation + vbOKOnly)
                End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class