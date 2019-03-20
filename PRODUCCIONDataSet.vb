

Partial Public Class PRODUCCIONDataSet
    Partial Class InformeProduccionDataTable

        Private Sub InformeProduccionDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DecorativoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class ParadasBasicosDataTable

        Private Sub ParadasBasicosDataTable_ParadasBasicosRowChanging(ByVal sender As System.Object, ByVal e As ParadasBasicosRowChangeEvent) Handles Me.ParadasBasicosRowChanging

        End Sub

    End Class

    Partial Class InformeProduccionDiarioDataTable



      

    End Class

End Class

Namespace PRODUCCIONDataSetTableAdapters
    
    Partial Public Class ParadasBasicosTableAdapter
    End Class
End Namespace
