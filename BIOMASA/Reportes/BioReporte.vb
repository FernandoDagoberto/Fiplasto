Imports System.Data.SqlClient

Public Class BioReporte

    Public Property todosLosRegistros As New List(Of BiomasaPeso)
    Public query As IEnumerable(Of BiomasaPeso)

#Region "Attributes"
    Private _fechaD As DateTime
    Private _fechaH As DateTime
    Private _codD As Integer
    Private _codH As Integer
    Private _tipo As String

#End Region

#Region "Contructors"
    Public Sub New()

    End Sub
#End Region


#Region "Propiedades"

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property


    Public Property CodH As Integer
        Get
            Return _codH
        End Get
        Set(ByVal value As Integer)
            _codH = value
        End Set
    End Property

    Public Property CodD As Integer
        Get
            Return _codD
        End Get
        Set(ByVal value As Integer)
            _codD = value
        End Set
    End Property

    Public Property FechaH As DateTime
        Get
            Return _fechaH
        End Get
        Set(ByVal value As DateTime)
            _fechaH = value
        End Set
    End Property

    Public Property FechaD As DateTime
        Get
            Return _fechaD
        End Get
        Set(ByVal value As DateTime)
            _fechaD = value
        End Set
    End Property


#End Region

#Region "Consultas"

    Public Function DescarteBio() As List(Of BiomasaPeso)

        todosLosRegistros.Clear()
        conex("BioPila")

        sql = "select * from BIODESCARTE where FECHAPESADA between ('" + FechaD + "') and ('" + FechaH + "') " &
            "and CODMAD between (" + Str(CodD) + ") and (" + Str(CodH) + ") "
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        For Each filas As DataRow In dt.Rows
            Dim registro = New BiomasaPeso
            registro.Ticket = filas("Ticket")
            registro.Codmad = filas("CodMad")
            registro.TipMad = filas("TipMad")
            registro.FechaPesada = filas("FechaPesada")
            registro.Neto = filas("Neto")

            If filas("FechaPicado") Is DBNull.Value Then
                registro.FechaPicado = Nothing
            Else
                registro.FechaPicado = filas("FechaPicado")
            End If

            If filas("Grupo") Is DBNull.Value Then
                registro.Grupo = Nothing
            Else
                registro.Grupo = filas("Grupo")
            End If

            If filas("Turno") Is DBNull.Value Then
                registro.Turno = Nothing
            Else
                registro.Turno = filas("Turno")
            End If

            todosLosRegistros.Add(registro)
        Next


        Return todosLosRegistros


    End Function



#End Region


End Class
