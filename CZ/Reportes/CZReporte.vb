Imports System.Data.SqlClient

Public Class CZReporte

#Region "Attributes"
    Private _fechaD As DateTime
    Private _fechaH As DateTime
    Private _lineaD As String
    Private _lineaH As String
    Private _turnoD As String
    Private _turnoH As String
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

    Public Property TurnoH As String
        Get
            Return _turnoH
        End Get
        Set(ByVal value As String)
            _turnoH = value
        End Set
    End Property

    Public Property TurnoD As String
        Get
            Return _turnoD
        End Get
        Set(ByVal value As String)
            _turnoD = value
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

    Public Property ReparaD As String
    Public Property ReparaH As String

#End Region

#Region "Consultas"

    Public Function RepoRechazos() As DataTable
        sql = "select * from CZZCARGADAS where CZZCARGADAS_fecha>='" + FechaD + "' and CZZCARGADAS_fecha<='" + FechaH + "' " &
               "And CZZCARGADAS_linea >='" + LineaD + "' and CZZCARGADAS_linea<='" + LineaH + "' " &
               "And CZZCARGADAS_turno >='" + TurnoD + "' and CZZCARGADAS_turno<='" + TurnoH + "' " &
               "and ((czzcargadas_defecto1>= '" + DefectoD + "' and czzcargadas_defecto1<='" + DefectoH + "') " &
               "or (czzcargadas_defecto2>= '" + DefectoD + "' and czzcargadas_defecto2<='" + DefectoH + "') " &
               "or (czzcargadas_defecto3>= '" + DefectoD + "' and czzcargadas_defecto3<='" + DefectoH + "'))" &
               "and czzcargadas_bajaid='0' and czzcargadas_calidad='RECHAZADA' " &
               "order by CZZCARGADAS_fecha"

        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoCtrlDim() As DataTable
        sql = "select * from CZCTRLDIM where czctdi_fecha>='" + FechaD + "' and czctdi_fecha<='" + FechaH + "' " &
               "And czctdi_linea >='" + LineaD + "' and czctdi_linea<='" + LineaH + "' And czctdi_turno >='" + TurnoD + "' and czctdi_turno<='" + TurnoH + "' " &
               "and czctdi_bajaid='0' order by czctdi_fecha"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoEspesores() As DataTable
        sql = "select * from CzEspesores where CzEspes_fecha>='" + FechaD + "' and CzEspes_fecha<='" + FechaH + "' " &
               "And CzEspes_linea >='" + LineaD + "' and CzEspes_linea<='" + LineaH + "' And CzEspes_turno >='" + TurnoD + "' and CzEspes_turno<='" + TurnoH + "' " &
               "and CzEspes_material>='" + MaterialD + "' and CzEspes_material<='" + MaterialH + "' " &
               "And CzEspes_bajaid='0' order by czespes_fecha"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoPromEspesores() As DataTable
        sql = "select * from CZPromEspesores where czespes_fecha>='" + FechaD + "' and czespes_fecha<='" + FechaH + "' " &
               "And czespes_linea >='" + LineaD + "' and  czespes_linea<='" + LineaH + "' And czespes_turno >='" + TurnoD + "' and czespes_turno<='" + TurnoH + "' " &
               "and czespes_material>='" + MaterialD + "' and czespes_material<='" + MaterialH + "' " &
               "order by czespes_fecha"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoReparacion() As DataTable
        sql = "select * from czreparacion where czreparacion_fecha>='" + FechaD + "' and czreparacion_fecha<='" + FechaH + "' " &
               "And czreparacion_turno >='" + TurnoD + "' and czreparacion_turno<='" + TurnoH + "' " &
               "and czreparacion_reparada>='" + ReparaD + "' and czreparacion_reparada<='" + ReparaH + "' and czreparacion_bajaid='0' " &
               "order by czreparacion_fecha"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function RepoRotulador() As DataTable
        sql = "select * from CZROTULADOR where czrot_fecha>='" + FechaD + "' and czrot_fecha<='" + FechaH + "' " &
               "and czrot_linea>='" + LineaD + "' and czrot_linea<='" + LineaH + "' And czrot_turno >='" + TurnoD + "' and czrot_turno<='" + TurnoH + "' and czrot_bajaid='0'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function RepoZorrasConforme() As DataTable
        sql = "select * from CZZCARGADAS where czzcargadas_fecha>='" + FechaD + "' and czzcargadas_fecha<='" + FechaH + "' " &
               "And czzcargadas_linea >='" + LineaD + "' and czzcargadas_linea<='" + LineaH + "' And czzcargadas_turno >='" + TurnoD + "' and czzcargadas_turno<='" + TurnoH + "' " &
               "and czzcargadas_calidad<>'RECHAZADA' and czzcargadas_bajaid='0' " &
               "order by czzcargadas_fecha"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function RepoTblCargados() As DataTable
        sql = "select * from CZZCARGADAS where czzcargadas_fecha>='" + FechaD + "' and czzcargadas_fecha<='" + FechaH + "' " &
               "And czzcargadas_linea >='" + LineaD + "' and czzcargadas_linea<='" + LineaH + "' And czzcargadas_turno >='" + TurnoD + "' and czzcargadas_turno<='" + TurnoH + "' " &
               "and czzcargadas_bajaid='0' " &
               "order by czzcargadas_fecha"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt
    End Function

#End Region


End Class
