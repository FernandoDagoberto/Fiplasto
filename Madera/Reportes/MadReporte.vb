Imports System.Data.SqlClient

Public Class MadReporte


#Region "Attributes"
    Private _fechaD As DateTime
    Private _fechaH As DateTime
    Private _maderaD As Integer
    Private _maderaH As Integer
    Private _campoD As String
    Private _campoH As String
    Private _PropioD As String
    Private _PropioH As String
    Private _proveedorD As Integer
    Private _proveedorH As Integer
#End Region

#Region "Contructors"
    Public Sub New()

    End Sub
#End Region


#Region "Propiedades"
    Public Property PropioH As String
        Get
            Return _PropioH
        End Get
        Set(ByVal value As String)
            _PropioH = value
        End Set
    End Property

    Public Property PropioD As String
        Get
            Return _PropioD
        End Get
        Set(ByVal value As String)
            _PropioD = value
        End Set
    End Property

    Public Property CampoH As String
        Get
            Return _campoH
        End Get
        Set(ByVal value As String)
            _campoH = value
        End Set
    End Property

    Public Property CampoD As String
        Get
            Return _campoD
        End Get
        Set(ByVal value As String)
            _campoD = value
        End Set
    End Property

    Public Property MaderaH As Integer
        Get
            Return _maderaH
        End Get
        Set(ByVal value As Integer)
            _maderaH = value
        End Set
    End Property

    Public Property MaderaD As Integer
        Get
            Return _maderaD
        End Get
        Set(ByVal value As Integer)
            _maderaD = value
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

    Public Property ProveedorH As Integer
        Get
            Return _proveedorH
        End Get
        Set(ByVal value As Integer)
            _proveedorH = value
        End Set
    End Property
    Public Property ProveedorD As Integer
        Get
            Return _proveedorD
        End Get
        Set(ByVal value As Integer)
            _proveedorD = value
        End Set
    End Property


#End Region

#Region "Consultas"

    Public Function RepoCampos() As DataTable
        sql = "select * from MaderaView where fechaEgreso>='" + FechaD + "' And fechaEgreso<='" + FechaH + "' " &
               "And camion_pcod >=" + Trim(MaderaD) + " and camion_pcod<=" + Trim(MaderaH) + " " &
               "And codcam between ('" + CampoD + "') and ('" + CampoH + "') " &
               "and propio between ('" + PropioD + "') and ('" + PropioH + "') " &
               "and codcam>0 "

        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoMadTerceros() As DataTable
        sql = "select * from MaderaView where fechaEgreso>='" + FechaD + "' And fechaEgreso<='" + FechaH + "' " &
               "And camion_pcod >=" + Trim(MaderaD) + " and camion_pcod<=" + Trim(MaderaH) + " " &
               "And camion_transpcod between ('" + Trim(Str(ProveedorD)) + "') and ('" + Trim(Str(ProveedorH)) + "') " &
               "and camion_transpcod>0 "

        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function


    Public Function RepoServicios() As DataTable
        sql = "select * from MaderaViewServicios where fechaEgreso>='" + FechaD + "' And fechaEgreso<='" + FechaH + "' " &
               "And camion_pcod >=" + Trim(MaderaD) + " and camion_pcod<=" + Trim(MaderaH) + " " &
               "And camion_fletecod between ('" + Trim(Str(ProveedorD)) + "') and ('" + Trim(Str(ProveedorH)) + "') "
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoIngresoMad() As DataTable
        sql = "select * from MaderaView where fechaEgreso>='" + FechaD + "' And fechaEgreso<='" + FechaH + "' " &
               "And camion_pcod >=" + Trim(MaderaD) + " and camion_pcod<=" + Trim(MaderaH) + " " &
               "And camion_transpcod between ('" + Trim(Str(ProveedorD)) + "') and ('" + Trim(Str(ProveedorH)) + "') "
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function






#End Region


End Class
