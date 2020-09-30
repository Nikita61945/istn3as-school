Partial Class group31DataSet
    Partial Public Class tblLearnerDataTable
        Private Sub tblLearnerDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.POneNoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace group31DataSetTableAdapters

    Partial Public Class DataTable1TableAdapter
    End Class
End Namespace
