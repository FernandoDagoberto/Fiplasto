Imports System.Data.SqlClient

Public Class abmProductos

    Public Sub New()

    End Sub

    ':::Creamos el procedimiento para la consulta y le indicamos que debe pedir 2 parametros para
    ':::ejecutarse correctamente (Tabla, Sql)
    Sub consulta(ByVal Sql As String)

        Dim DA As New SqlDataAdapter
        dt.Clear()

        ':::Instruccion Try para capturar errores
        Try
            ':::Creamos el objeto DataAdapter y le pasamos los dos parametros (Instruccion, conexión)
            DA = New SqlDataAdapter(Sql, cnn)
            ':::Pasamos la informacion del DataAdapter al DataTable mediante la propiedad Fill
            DA.Fill(dt)

        Catch ex As Exception
            MsgBox("No se logro realizar la consulta por: " & ex.Message, MsgBoxStyle.Critical, "Tutorial CRUD")
        End Try

    End Sub


    ':::Creamos el procedimiento para Agregar, Actualizar y Eliminar ademas le indicamos que debe pedir
    ':::2 parametros para ejecutarse correctamente (Tabla, Sql)
    Sub operaciones(ByVal Tabla As DataGridView, ByVal Sql As String)
        ':::Abrimos la conexion
        cnn.Open()
        ':::Instruccion Try para capturar errores
        Try
            ':::Creamos nuestro objeto de tipo Command que almacenara nuestras instrucciones
            ':::Necesita 2 parametros (Instruccion, conexion)
            Dim cmd As New SqlCommand(Sql, cnn)
            ':::Ejecutamos la instruccion mediante la propiedad ExecuteNonQuery del command
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se logro realizar la operación por: " & ex.Message, MsgBoxStyle.Critical, "Tutorial CRUD")
        End Try
        ':::Cerramos la conexion
        cnn.Close()

    End Sub


End Class
