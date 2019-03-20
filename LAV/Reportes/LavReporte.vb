Imports System.Data.SqlClient

Public Class LavReporte

#Region "Attributes"
    Private _fechaD As DateTime
    Private _fechaH As DateTime
    Private _lineaD As String
    Private _lineaH As String
    Private _razonD As String
    Private _razonH As String
    Private _movimiento As Char 'Ingreso - Egreso
    Private _turnoD As String

    Private _defectoD As String
    Private _defectoH As String
    Private _materialD As String
    Private _materialH As String

#End Region

#Region "Contructors"
    Public Sub New()

    End Sub
#End Region


#Region "Propiedades"
    Public Property TurnoD As String
        Get
            Return _turnoD
        End Get
        Set(ByVal value As String)
            _turnoD = value
        End Set
    End Property


    Public Property Movimiento As Char
        Get
            Return _movimiento
        End Get
        Set(ByVal value As Char)
            _movimiento = value
        End Set
    End Property


    Public Property MaterialH As String
        Get
            Return _materialH
        End Get
        Set(ByVal value As String)
            _materialH = value
        End Set
    End Property

    Public Property MaterialD As String
        Get
            Return _materialD
        End Get
        Set(ByVal value As String)
            _materialD = value
        End Set
    End Property

    Public Property RazonH As String
        Get
            Return _razonH
        End Get
        Set(ByVal value As String)
            _razonH = value
        End Set
    End Property

    Public Property RazonD As String
        Get
            Return _razonD
        End Get
        Set(ByVal value As String)
            _razonD = value
        End Set
    End Property

    Public Property LineaH As String
        Get
            Return _lineaH
        End Get
        Set(ByVal value As String)
            _lineaH = value
        End Set
    End Property

    Public Property LineaD As String
        Get
            Return _lineaD
        End Get
        Set(ByVal value As String)
            _lineaD = value
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

    Public Property DefectoH As String
        Get
            Return _defectoH
        End Get
        Set(ByVal value As String)
            _defectoH = value
        End Set
    End Property

    Public Property DefectoD As String
        Get
            Return _defectoD
        End Get
        Set(ByVal value As String)
            _defectoD = value
        End Set
    End Property


#End Region

#Region "Consultas"

#Region "CubrePlacas"
    Public Function RepoCubrePlacasEgreso() As DataTable
        sql = "select * from LAVCCP where lavccp_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
            "and lavccp_linea between ('" + LineaD + "') and ('" + LineaH + "') " &
            "and lavccp_razon between ('" + RazonD + "') and ('" + RazonH + "') " &
            "and lavccp_ingegr='E' and  lavccp_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoCubrePlacasIngreso() As DataTable
        sql = "select * from LAVCCP where lavccp_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
            "and lavccp_linea between ('" + LineaD + "') and ('" + LineaH + "') " &
            "and lavccp_ingegr='I' and  lavccp_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoCubrePlacasVida() As DataTable
        sql = "select * from LAVCCP where lavccp_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
            "and lavccp_linea between ('" + LineaD + "') and ('" + LineaH + "') " &
            "and  lavccp_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function
#End Region

#Region "Chapas de transporte"
    Public Function RepoCHTREgreso() As DataTable
        sql = "select * from LAVCHTR where LAVCHTR_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
            "and LAVCHTR_linea between ('" + LineaD + "') and ('" + LineaH + "') " &
            "and LAVCHTR_destino between ('" + RazonD + "') and ('" + RazonH + "') " &
            "and LAVCHTR_ingegr='E' and  LAVCHTR_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoCHTRIngreso() As DataTable
        sql = "select * from LAVCHTR where LAVCHTR_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
            "and LAVCHTR_linea between ('" + LineaD + "') and ('" + LineaH + "') " &
            "and LAVCHTR_ingegr='I' and  LAVCHTR_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoCHTRVida() As DataTable
        sql = "select * from LAVCHTR where LAVCHTR_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
            "and LAVCHTR_linea between ('" + LineaD + "') and ('" + LineaH + "') " &
            "and  LAVCHTR_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function
#End Region

#Region "Decorativos"
    Public Function RepoDecorativo() As DataTable
        sql = "select * from LAVDECO where LAVDECO_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
           "and LAVDECO_deco between ('" + RazonD + "') and ('" + RazonH + "') " &
            "and  LAVdeco_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

#End Region

#Region "General"
    Public Function RepoGeneral() As DataTable
        sql = "select * from RepLavGral where fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
           "and Turno='" + TurnoD + "'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

#End Region

#Region "Inoxidables"
    Public Function RepoInoxEgreso() As DataTable
        sql = "select * from LAVINOX where LAVINOX_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
            "and LAVINOX_linea between ('" + LineaD + "') and ('" + LineaH + "') " &
            "and LAVINOX_razon between ('" + RazonD + "') and ('" + RazonH + "') " &
            "and LAVINOX_ingegr='E' and  LAVINOX_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoInoxIngreso() As DataTable
        sql = "select * from LAVINOX where LAVINOX_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
            "and LAVINOX_linea between ('" + LineaD + "') and ('" + LineaH + "') " &
            "and LAVINOX_ingegr='I' and  LAVINOX_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoInoxVida() As DataTable
        sql = "select * from LAVINOX where LAVINOX_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
            "and LAVINOX_linea between ('" + LineaD + "') and ('" + LineaH + "') " &
            "and  LAVINOX_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function
#End Region

#Region "Reparaciones"
    Public Function RepoReparaciones() As DataTable
        sql = "select * from RepLavRepaView  where FCHREP between ('" + FechaD + "') and ('" + FechaH + "') "
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

#End Region

#Region "Consumos"
    Public Function RepoConsumoSodaCaustica() As DataTable
        sql = "select * from LAVSODA  where LAVSODA_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
            "and LAVSODA_cuba between ('" + LineaD + "')and ('" + LineaH + "')" &
            "and lavsoda_bajaid='0' and lavsoda_lt>0"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoTemperatura() As DataTable
        sql = "select * from LAVSODA  where LAVSODA_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
            "and LAVSODA_cuba between ('" + LineaD + "')and ('" + LineaH + "')" &
            "and lavsoda_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoLimpCubas() As DataTable
        sql = "select * from LAVLIMPCUBA  where LAVLIMPCUBA_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
           "and LAVLIMPCUBA_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

#End Region

#Region "TDH"
    Public Function RepoTDH() As DataTable
        sql = "select * from LAVTDH where LAVTDH_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
              "and LAVTDH_linea between ('" + LineaD + "')and   ('" + LineaH + "') " &
              "and LAVTDH_ingegr='" + Movimiento + "' and  LAVTDH_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function RepoTDHConRazon() As DataTable
        sql = "select * from LAVTDH where LAVTDH_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
              "and LAVTDH_linea between ('" + LineaD + "')and   ('" + LineaH + "') " &
              "and LAVTDH_razon between ('" + RazonD + "')and   ('" + RazonH + "') " &
              "and LAVTDH_ingegr='" + Movimiento + "' and  LAVTDH_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function RepoTDHVida() As DataTable
        sql = "select * from LAVTDH where LAVTDH_fecha between ('" + FechaD + "') and ('" + FechaH + "') " &
              "and LAVTDH_linea between ('" + LineaD + "')and   ('" + LineaH + "') " &
              "and LAVTDH_ingegr in ('N','B') and  LAVTDH_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt
    End Function

#End Region

#End Region


End Class
