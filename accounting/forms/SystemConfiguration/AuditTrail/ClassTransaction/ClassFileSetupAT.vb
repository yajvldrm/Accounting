Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.BandedGrid

Public Class ClassFileSetupAT
    Public Shared Sub InitializeDet(ByRef dg As GridView)
        dg.Columns.Clear()
        dg.Columns.Add(GCNewColumn("a_at_id", "a_at_id_jbooks", "AT_ID", False))
        dg.Columns.Add(GCNewColumn("line_remarks", "line_remarks", "Line Remarks"))
        dg.Columns.Add(GCNewColumn("currency_name", "currency_name", "Currency"))
        dg.Columns.Add(GCNewColumn("exchange_rate", "exchange_rate", "Exchange Rate", , "N2", FormatType.Numeric, "0.00"))
        dg.Columns.Add(GCNewColumn("based_rate", "based_rate", "Based Rate", , "N2", FormatType.Numeric, "0.00"))
        dg.Columns.Add(GCNewColumn("account_code", "account_code", "Account"))
        dg.Columns.Add(GCNewColumn("account_name", "account_name", "Account Name"))
        dg.Columns.Add(GCNewColumn("project_code", "project_code", "Project"))
        dg.Columns.Add(GCNewColumn("department_code", "department_code", "Department"))
        dg.Columns.Add(GCNewColumn("allocation_code", "allocation_code", "Allocation"))
        dg.Columns.Add(GCNewColumn("debit", "debit", "Debit", , "N2", FormatType.Numeric, "0.00"))
        dg.Columns.Add(GCNewColumn("credit", "credit", "Credit", , "N2", FormatType.Numeric, "0.00"))
        dg.Columns.Add(GCNewColumn("debit_based", "debit_based", "Debit Based", , "N2", FormatType.Numeric, "0.00"))
        dg.Columns.Add(GCNewColumn("credit_based", "credit_based", "Credit Based", , "N2", FormatType.Numeric, "0.00"))
        dg.Columns.Add(GCNewColumn("general_code", "general_code", "Gen. Ref."))
        dg.Columns.Add(GCNewColumn("general_name", "general_name", "Gen. Ref. Name"))
        dg.Columns.Add(GCNewColumn("trans_no", "trans_no", "D.N. Ref"))
        dg.Columns.Add(GCNewColumn("OrderBy", "OrderBy", "Order By", False))
    End Sub
    Public Shared Function LoadData(ByRef dgHead As GridView, ByVal tableName As String) As DataSet
        Dim dg = dgHead.GridControl
        Dim ds As New DataSet("DS")
        Dim dtHead As New DataTable("Head")
        Dim dtDet As New DataTable("Detail")
        Dim dtSub As New DataTable("Sub")
        Dim hasDet As Boolean = False
        Dim hasSub As Boolean = False

        createHead(dtHead, tableName)
        ds.Tables.Add(dtHead)
        Select Case tableName
            Case "allocation"
                hasDet = True
            Case "chart"
                hasDet = True
            Case "general"
                hasDet = True
                hasSub = True
        End Select

        If hasDet Then
            createDet(dtDet, tableName)
            ds.Tables.Add(dtDet)
            ds.Relations.Add(dtHead.Columns("at_id"), dtDet.Columns("at_id"))
        End If

        If hasSub Then
            createSub(dtSub, tableName)
            ds.Tables.Add(dtSub)
            ds.Relations.Add(dtHead.Columns("at_id"), dtSub.Columns("at_id"))
        End If

        Dim sql_head As String = String.Format("CALL FileSetupGetHeader('{0}');", tableName)
        Dim dt_head As DataTable = FsQuery(sql_head)

        ds.Clear()

        For Each row As DataRow In dt_head.Rows
            ds.Tables("Head").ImportRow(row)
        Next

        If hasDet Then
            If tableName = "general" Then
                tableName = tableName & "_ewt"
            End If
            Dim sql_det As String = String.Format("CALL FileSetupGetDetail('{0}');", tableName)
            Dim dt_det As DataTable = FsQuery(sql_det)
            For Each row As DataRow In dt_det.Rows
                ds.Tables("Detail").ImportRow(row)
            Next
        End If

        If hasSub Then
            If tableName = "general" Then
                tableName = tableName & "_final_tax"
            End If
            Dim sql_sub As String = String.Format("CALL FileSetupGetDetail('{0}');", tableName)
            Dim dt_sub As DataTable = FsQuery(sql_sub)
            For Each row As DataRow In dt_sub.Rows
                ds.Tables("Sub").ImportRow(row)
            Next
        End If
        Return ds
    End Function
    Public Shared Sub loadDataToGrid(ByRef dg As GridControl, ByVal ds As DataSet)
        If dg.DataSource IsNot Nothing Then
            dg.DataSource = Nothing
        End If
        dg.DataSource = ds.Tables("Head")
    End Sub
    Public Shared Sub createHead(ByRef dt As DataTable, ByVal TableName As String)
        dt.Columns.Clear()
        dt.Columns.Add(CreateDataColumn("at_id", "System.String", "ID"))
        dt.Columns.Add(CreateDataColumn("transmode", "System.String", "Process"))
        dt.Columns.Add(CreateDataColumn("at_date_date", "System.String", "Date"))
        dt.Columns.Add(CreateDataColumn("at_date_time", "System.String", "Time"))
        dt.Columns.Add(CreateDataColumn("username", "System.String", "Username"))
        dt.Columns.Add(CreateDataColumn("machine_name", "System.String", "Computer"))
        dt.Columns.Add(CreateDataColumn("machine_user", "System.String", "User"))
        Select Case TableName
            Case "allocation"
                dt.Columns.Add(CreateDataColumn("allocation_code", "System.String", "Allocation"))
                dt.Columns.Add(CreateDataColumn("allocation_name", "System.String", "Allocation Name"))
            Case "chart"
                dt.Columns.Add(CreateDataColumn("account_code", "System.String", "Account"))
                dt.Columns.Add(CreateDataColumn("account_name", "System.String", "Account Name"))
                dt.Columns.Add(CreateDataColumn("chart_class_name", "System.String", "Class"))
                dt.Columns.Add(CreateDataColumn("validation", "System.String", "Validation"))
                dt.Columns.Add(CreateDataColumn("description", "System.String", "Dscription"))
            Case "general"
                dt.Columns.Add(CreateDataColumn("general_code", "System.String", "General"))
                dt.Columns.Add(CreateDataColumn("general_name", "System.String", "General Name"))
                dt.Columns.Add(CreateDataColumn("category_name", "System.String", "Category"))
                dt.Columns.Add(CreateDataColumn("date", "System.DateTime", "Date"))
                dt.Columns.Add(CreateDataColumn("address1", "System.String", "Address 1"))
                dt.Columns.Add(CreateDataColumn("address2", "System.String", "Address 2"))
                dt.Columns.Add(CreateDataColumn("address3", "System.String", "Address 3"))
                dt.Columns.Add(CreateDataColumn("address4", "System.String", "Address 4"))
                dt.Columns.Add(CreateDataColumn("attention", "System.String", "Attention"))
                dt.Columns.Add(CreateDataColumn("contact_person", "System.String", "Contact Person"))
                dt.Columns.Add(CreateDataColumn("tel_no", "System.String", "Tel No"))
                dt.Columns.Add(CreateDataColumn("fax_no", "System.String", "Fax No"))
                dt.Columns.Add(CreateDataColumn("cell_no", "System.String", "Cell No"))
                dt.Columns.Add(CreateDataColumn("tin", "System.String", "TIN"))
                dt.Columns.Add(CreateDataColumn("email_add", "System.String", "Email"))
                dt.Columns.Add(CreateDataColumn("website", "System.String", "Website"))
                dt.Columns.Add(CreateDataColumn("terms_name", "System.String", "Terms"))
                dt.Columns.Add(CreateDataColumn("credit_amt", "System.String", "Credit Amount"))
                dt.Columns.Add(CreateDataColumn("nodays", "System.String", "No of Days"))
                dt.Columns.Add(CreateDataColumn("remarks", "System.String", "Remarks"))
                dt.Columns.Add(CreateDataColumn("status", "System.String", "Status"))
                dt.Columns.Add(CreateDataColumn("industry_name", "System.String", "Industry"))
                dt.Columns.Add(CreateDataColumn("rdo_code", "System.String", "RDO"))
        End Select
    End Sub
    Public Shared Sub createDet(ByRef dt As DataTable, ByVal TableName As String)
        dt.Columns.Clear()
        dt.Columns.Add(CreateDataColumn("at_id", "System.String", "ID"))
        dt.Columns.Add(CreateDataColumn("transmode", "System.String", "Process"))
        dt.Columns.Add(CreateDataColumn("username", "System.String", "Username"))
        dt.Columns.Add(CreateDataColumn("machine_name", "System.String", "Computer"))
        dt.Columns.Add(CreateDataColumn("machine_user", "System.String", "User"))
        Select Case TableName
            Case "allocation"
                dt.Columns.Add(CreateDataColumn("account_code", "System.String", "Account"))
                dt.Columns.Add(CreateDataColumn("account_name", "System.String", "Account Name"))
            Case "chart"
                dt.Columns.Add(CreateDataColumn("chart_group_code", "System.String", "Chart Group"))
                dt.Columns.Add(CreateDataColumn("chart_group_name", "System.String", "Chart Group Name"))
            Case "general"
                dt.Columns.Add(CreateDataColumn("ewt_code", "System.String", "EWT"))
                dt.Columns.Add(CreateDataColumn("ewt_name", "System.String", "EWT Name"))
                dt.Columns.Add(CreateDataColumn("tax_rate", "System.Decimal", "Rate"))
        End Select
    End Sub
    Public Shared Sub createSub(ByRef dt As DataTable, ByVal TableName As String)
        dt.Columns.Clear()
        dt.Columns.Add(CreateDataColumn("at_id", "System.String", "ID"))
        dt.Columns.Add(CreateDataColumn("transmode", "System.String", "Process"))
        dt.Columns.Add(CreateDataColumn("username", "System.String", "Username"))
        dt.Columns.Add(CreateDataColumn("machine_name", "System.String", "Computer"))
        dt.Columns.Add(CreateDataColumn("machine_user", "System.String", "User"))
        Select Case TableName
            Case "general"
                dt.Columns.Add(CreateDataColumn("final_tax_code", "System.String", "Final Tax"))
                dt.Columns.Add(CreateDataColumn("final_tax_name", "System.String", "Final Tax Name"))
                dt.Columns.Add(CreateDataColumn("final_tax_rate", "System.Decimal", "Rate"))
        End Select
    End Sub
End Class
