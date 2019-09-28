Partial Class accountanalysis_set
    Partial Public Class CompanyDataTable
        Private Sub CompanyDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.addressColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
