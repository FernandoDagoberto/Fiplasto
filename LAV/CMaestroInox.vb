Imports System.Data.SqlClient

Public Class CMaestroInox

    Private _linea As Integer
    Private _inox, _userid, _bajaid As String
    Private _bajafch As Date

    Public Sub New()

    End Sub

    Public Sub New(ByVal linea As Integer, ByVal inox As String, ByVal userid As String, ByVal bajaid As String, ByVal bajafch As Date)
        Me.Linea = linea
        Me.Inox = inox
        Me.UserId = userid
        Me.BajaId = bajaid
        Me.BajaFch = bajafch

    End Sub


    Public Property Linea() As Integer
        Get
            Return _linea
        End Get
        Set(ByVal value As Integer)
            _linea = value
        End Set
    End Property

    Public Property Inox() As String
        Get
            Return _inox
        End Get
        Set(ByVal value As String)
            _inox = value
        End Set
    End Property

    Public Property UserId() As String
        Get
            Return _userid
        End Get
        Set(ByVal value As String)
            _userid = value
        End Set
    End Property

    Public Property BajaId() As String
        Get
            Return _bajaid
        End Get
        Set(ByVal value As String)
            _bajaid = value
        End Set
    End Property

    Public Property BajaFch() As Date
        Get
            Return _bajafch
        End Get
        Set(ByVal value As Date)
            _bajafch = value
        End Set
    End Property

    Public Function Mostrar(ByVal dts As CMaestroInox) As DataTable
        Try
            conex("lavmainox")

            sql1 = "select lavmainox_linea as linea,lavmainox_inox as Inox, lavmainox_userid as Usuario, " & _
                    "lavmainox_bajaid as BajaId, lavmainox_bajafch as BajaFch " & _
                    "from lavmainox " & _
                    "where lavmainox_inox like '%" + dts.Inox + "%'  order by lavmainox_linea,lavmainox_inox"
            cnn.Open()
            cmd1 = New SqlCommand(sql1)
            cmd1.CommandType = CommandType.Text
            cmd1.Connection = cnn

            If cmd1.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd1)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Agregar(ByVal dts As CMaestroInox) As Boolean
        Try
            conex("lavmainox")
            campos = "lavmainox_linea,lavmainox_inox,lavmainox_userid"
            variables = "'" + Trim(Str(dts.Linea)) + "','" + Trim(Str(dts.Inox)) + "','" + dts.UserId + "'"
            cnn.Open()
            sql1 = "INSERT INTO LavMaInox (" + campos + ") VALUES (" + variables + ")"
            cmd1 = New SqlCommand(sql1)
            cmd1.CommandType = CommandType.Text
            cmd1.Connection = cnn

            If cmd1.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
            cnn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Modificar(ByVal dts As CMaestroInox) As Boolean
        Try
            conex("lavmainox")
            cnn.Open()
            sql1 = "Update lavmainox set lavmainox_linea='" + Trim(Str(dts.Linea)) + "', lavmainox_userid='" + dts.UserId + "', " & _
            "lavmainox_bajaid='" + dts.BajaId + "' where lavmainox_inox='" + dts.Inox.ToString + "' "
            cmd1 = New SqlCommand(sql1)
            cmd1.CommandType = CommandType.Text
            cmd1.Connection = cnn

            If cmd1.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
            cnn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            cnn.Close()
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal dts As CMaestroInox) As Boolean
        Try
            conex("lavmainox")
            cnn.Open()
            sql1 = "delete from lavmainox where lavmainox_inox='" + dts.Inox + "' "
            cmd1 = New SqlCommand(sql1)
            cmd1.CommandType = CommandType.Text
            cmd1.Connection = cnn

            If cmd1.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cnn.Close()
            Return False
        End Try
    End Function
End Class
