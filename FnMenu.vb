Imports System.Data.SqlClient
Public Class Fnmenu

    Dim cmd As New SqlCommand

    Public Function FnMostrar() As DataTable
        Try
            sql = "select * from menu"
            da = New SqlDataAdapter(sql, cnn)
            dt = New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


End Class