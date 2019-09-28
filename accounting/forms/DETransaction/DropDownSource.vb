Imports connectionlib.connectionlib
Public Class DropDownSource
    Public Shared Function GetQueryString(ByVal strCategory As String) As String
        Dim returnValue As String = ""
        Select Case strCategory
            Case "SelectClient"
                returnValue = String.Format("SELECT a.general_id,a.general_code,a.general_name " &
                    "FROM lib_erp_general a " &
                    "ORDER BY a.category_id ASC,a.general_code " &
                    "")
            Case "SelectSupplier"
                returnValue = String.Format("SELECT a.general_id,a.general_code,a.general_name " &
                    "FROM lib_erp_general a " &
                    "ORDER BY a.category_id DESC,a.general_code " &
                    "")
            Case "SelectGeneralLibrary"
                returnValue = String.Format("SELECT a.general_id,a.general_code,a.general_name " &
                    "FROM lib_erp_general a " &
                    "ORDER BY a.general_code " &
                    "")
        End Select
        Return returnValue
    End Function
    Public Shared Function GetDropDownDataTable(ByVal strCategory As String, Optional isMainDB As Boolean = False) As DataTable
        Dim returnDT As DataTable = Nothing
        Dim sql As String = GetQueryString(strCategory)
        If sql <> "" Then
            If Not isMainDB Then
                returnDT = FsQuery(sql)
            Else
                returnDT = Query(sql)
            End If
        End If
        Return returnDT
    End Function
End Class
