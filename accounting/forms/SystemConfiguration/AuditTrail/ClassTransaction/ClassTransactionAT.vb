Imports System.Windows.Forms
Imports connectionlib.connectionlib
Imports libacctng.myFunctions
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.BandedGrid


Public Class ClassTransactionAT
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
    Public Shared Sub LoadData(ByRef dgHead As GridView, ByVal journal_id As String)
        Dim dg = dgHead.GridControl
        Dim ds As New DataSet("DS")
        Dim dtHead As New DataTable("Head")
        Dim dtDet As New DataTable("Detail")
        createHead(dtHead, journal_id)
        createDet(dtDet)
        ds.Tables.Add(dtHead)
        ds.Tables.Add(dtDet)
        ds.Relations.Add(dtHead.Columns("a_at_id"), dtDet.Columns("a_at_id"))

        Dim sql_head As String = String.Format("CALL TransactionGetAT('1','{0}');", journal_id)
        Dim dt_head As DataTable = Query(sql_head)
        Dim sql_det As String = String.Format("CALL TransactionGetAT('0','{0}');", journal_id)
        Dim dt_det As DataTable = Query(sql_det)
        If dg.DataSource IsNot Nothing Then
            dg.DataSource = Nothing
        End If
        ds.Clear()
        For Each row As DataRow In dt_head.Rows
            ds.Tables("Head").ImportRow(row)
        Next
        For Each row As DataRow In dt_det.Rows
            ds.Tables("Detail").ImportRow(row)
        Next
        dg.DataSource = ds.Tables("Head")
    End Sub
    Public Shared Sub createHead(ByRef dt As DataTable, ByVal journal_id As String)
        dt.Columns.Clear()
        dt.Columns.Add(CreateDataColumn("a_at_id", "System.String", "ID"))
        dt.Columns.Add(CreateDataColumn("a_transmode", "System.String", "Process"))
        dt.Columns.Add(CreateDataColumn("a_at_date_date", "System.String", "Date"))
        dt.Columns.Add(CreateDataColumn("a_at_date_time", "System.String", "Time"))
        dt.Columns.Add(CreateDataColumn("a_username", "System.String", "Username"))
        dt.Columns.Add(CreateDataColumn("a_machine_name", "System.String", "Computer"))
        dt.Columns.Add(CreateDataColumn("a_machine_user", "System.String", "User"))
        Select Case journal_id
            Case "1"
                dt.Columns.Add(CreateDataColumn("a_trans_no", "System.String", "Invoicing No"))
            Case "2"
                dt.Columns.Add(CreateDataColumn("a_trans_no", "System.String", "OR No"))
            Case "3"
                dt.Columns.Add(CreateDataColumn("a_trans_no", "System.String", "Purchase No"))
            Case "4"
                dt.Columns.Add(CreateDataColumn("a_trans_no", "System.String", "Disbursement No"))
            Case "5"
                dt.Columns.Add(CreateDataColumn("a_trans_no", "System.String", "Journal No"))
            Case "6"
                dt.Columns.Add(CreateDataColumn("a_trans_no", "System.String", "Petty Cash No"))
            Case "7"
                dt.Columns.Add(CreateDataColumn("a_trans_no", "System.String", "Debit / Credit No"))
        End Select
        dt.Columns.Add(CreateDataColumn("a_trans_date", "System.DateTime", "Date"))
        dt.Columns.Add(CreateDataColumn("a_book_code", "System.String", "Book"))
        dt.Columns.Add(CreateDataColumn("a_journal_code", "System.String", "Journal"))
        dt.Columns.Add(CreateDataColumn("a_exchange_rate", "System.Decimal", "Exchange Rate"))
        dt.Columns.Add(CreateDataColumn("a_based_rate", "System.Decimal", "Based Rate"))
        dt.Columns.Add(CreateDataColumn("a_amount", "System.Decimal", "Amount"))
        dt.Columns.Add(CreateDataColumn("a_amount_based", "System.Decimal", "Amount Based"))
        dt.Columns.Add(CreateDataColumn("a_description", "System.String", "Particulars"))
        Select Case journal_id
            Case "1"
                dt.Columns.Add(CreateDataColumn("a_general_code", "System.String", "Client"))
                dt.Columns.Add(CreateDataColumn("a_general_name", "System.String", "Client Name"))
                dt.Columns.Add(CreateDataColumn("b_si_no", "System.String", "SI NO"))
                dt.Columns.Add(CreateDataColumn("b_dr_no", "System.String", "DR NO"))
                dt.Columns.Add(CreateDataColumn("b_po_no", "System.String", "PO NO"))
                dt.Columns.Add(CreateDataColumn("b_terms_name", "System.String", "Terms"))
                dt.Columns.Add(CreateDataColumn("b_nodays", "System.Int32", "No of Days"))
                dt.Columns.Add(CreateDataColumn("b_due_date", "System.DateTime", "Due Date"))
            Case "2"
                dt.Columns.Add(CreateDataColumn("a_general_code", "System.String", "Customer"))
                dt.Columns.Add(CreateDataColumn("a_general_name", "System.String", "Customer Name"))
                dt.Columns.Add(CreateDataColumn("b_si_no", "System.String", "SI NO"))
            Case "3"
                dt.Columns.Add(CreateDataColumn("a_general_code", "System.String", "Supplier"))
                dt.Columns.Add(CreateDataColumn("a_general_name", "System.String", "Supplier Name"))
                dt.Columns.Add(CreateDataColumn("b_si_no", "System.String", "SI NO"))
                dt.Columns.Add(CreateDataColumn("b_rr_no", "System.String", "RR NO"))
                dt.Columns.Add(CreateDataColumn("b_po_no", "System.String", "PO NO"))
                dt.Columns.Add(CreateDataColumn("b_terms_name", "System.String", "Terms"))
                dt.Columns.Add(CreateDataColumn("b_nodays", "System.Int32", "No of Days"))
                dt.Columns.Add(CreateDataColumn("b_due_date", "System.DateTime", "Due Date"))
            Case "4"
                dt.Columns.Add(CreateDataColumn("a_general_code", "System.String", "Payee"))
                dt.Columns.Add(CreateDataColumn("a_general_name", "System.String", "Payee Name"))
                dt.Columns.Add(CreateDataColumn("b_si_no", "System.String", "SI NO"))
                dt.Columns.Add(CreateDataColumn("b_rr_no", "System.String", "RR NO"))
            Case "5"
                dt.Columns.Add(CreateDataColumn("a_general_code", "System.String", "Client"))
                dt.Columns.Add(CreateDataColumn("a_general_name", "System.String", "Client Name"))
            Case "6"
                dt.Columns.Add(CreateDataColumn("a_general_code", "System.String", "Customer"))
                dt.Columns.Add(CreateDataColumn("a_general_name", "System.String", "Customer Name"))
                dt.Columns.Add(CreateDataColumn("b_reflenish_date", "System.DateTime", "Reflenish Date"))
                dt.Columns.Add(CreateDataColumn("b_po_no", "System.String", "PO NO"))
                dt.Columns.Add(CreateDataColumn("b_dr_no", "System.String", "DR NO"))
                dt.Columns.Add(CreateDataColumn("b_si_no", "System.String", "SI NO"))
                dt.Columns.Add(CreateDataColumn("b_terms_name", "System.String", "Terms"))
                dt.Columns.Add(CreateDataColumn("b_nodays", "System.Int32", "No of Days"))
                dt.Columns.Add(CreateDataColumn("b_due_date", "System.DateTime", "Due Date"))
            Case "7"
                dt.Columns.Add(CreateDataColumn("a_general_code", "System.String", "Client"))
                dt.Columns.Add(CreateDataColumn("a_general_name", "System.String", "Client Name"))
        End Select
    End Sub
    Public Shared Sub createDet(ByRef dt As DataTable)
        dt.Columns.Clear()
        dt.Columns.Add(CreateDataColumn("a_at_id", "System.String", "ID"))
        dt.Columns.Add(CreateDataColumn("transmode", "System.String", "Process"))
        dt.Columns.Add(CreateDataColumn("username", "System.String", "Username"))
        dt.Columns.Add(CreateDataColumn("machine_name", "System.String", "Computer"))
        dt.Columns.Add(CreateDataColumn("machine_user", "System.String", "User"))
        dt.Columns.Add(CreateDataColumn("account_code", "System.String", "Account"))
        dt.Columns.Add(CreateDataColumn("account_name", "System.String", "Account Name"))
        dt.Columns.Add(CreateDataColumn("project_code", "System.String", "Project"))
        dt.Columns.Add(CreateDataColumn("department_code", "System.String", "Deapartment"))
        dt.Columns.Add(CreateDataColumn("allocation_code", "System.String", "Allocation"))
        dt.Columns.Add(CreateDataColumn("currency_name", "System.String", "Currency"))
        dt.Columns.Add(CreateDataColumn("exchange_rate", "System.Decimal", "Exchange Rate"))
        dt.Columns.Add(CreateDataColumn("based_rate", "System.Decimal", "Based Rate"))
        dt.Columns.Add(CreateDataColumn("debit", "System.Decimal", "Debit"))
        dt.Columns.Add(CreateDataColumn("credit", "System.Decimal", "Credit"))
        dt.Columns.Add(CreateDataColumn("debit_based", "System.Decimal", "Debit Based"))
        dt.Columns.Add(CreateDataColumn("credit_based", "System.Decimal", "Credit Based"))
        dt.Columns.Add(CreateDataColumn("general_code", "System.String", "General"))
        dt.Columns.Add(CreateDataColumn("general_name", "System.String", "General Name"))
        dt.Columns.Add(CreateDataColumn("ref_trans_no", "System.String", "DN Ref"))
        dt.Columns.Add(CreateDataColumn("line_remarks", "System.String", "Line Remarks"))
    End Sub
End Class
