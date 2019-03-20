Imports System.Data.SqlClient

Public Class MCReporte


#Region "Attributes"
    Private _fechaD As DateTime
    Private _fechaH As DateTime
    Private _lineaD As String
    Private _lineaH As String
    Private _turnoD As String
    Private _turnoH As String
#End Region

#Region "Contructors"
    Public Sub New()

    End Sub
#End Region


#Region "Propiedades"
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

#End Region

#Region "Consultas"

    Public Function RepoLimpVac() As DataTable
        sql = "select * from mclimpvacio where limvac_fecha>='" + FechaD + "' and limvac_fecha<='" + FechaH + "' " &
               "And limvac_mc >='" + LineaD + "' and limvac_mc<='" + LineaH + "' And limvac_turno >='" + TurnoD + "' and limvac_turno<='" + TurnoH + "'and limvac_bajaid is null"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoHipo() As DataTable
        sql = "select * from mchipoclorito where hipoc_fecha>='" + FechaD + "' and hipoc_fecha<='" + FechaH + "' " &
               "And hipoc_linea >='" + LineaD + "' and hipoc_linea<='" + LineaH + "' And hipoc_turno >='" + TurnoD + "' and hipoc_turno<='" + TurnoH + "'and hipoc_bajaid is null"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoCuchillas() As DataTable
        sql = "select * from MCCUCHILLA where camcuch_fecha>='" + FechaD + "' and camcuch_fecha<='" + FechaH + "' " &
               "And camcuch_mc >='" + LineaD + "' and camcuch_mc<='" + LineaH + "' And camcuch_turno >='" + TurnoD + "' and camcuch_turno<='" + TurnoH + "'and camcuch_bajaid is null"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoConsumoParafina() As DataTable
        sql = "select * from MCPARAFINAIN where mcparafinain_fecha>='" + FechaD + "' and mcparafinain_fecha<='" + FechaH + "' " &
               "And mcparafinain_mc >='" + LineaD + "' and mcparafinain_mc<='" + LineaH + "' And mcparafinain_turno >='" + TurnoD + "' and mcparafinain_turno<='" + TurnoH + "'and mcparafinain_bajaid is null"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt

    End Function

    Public Function RepoParafina() As DataTable
        sql = "select * from MCPARAFINA where paraf_fecha>='" + FechaD + "' and paraf_fecha<='" + FechaH + "' " &
               "And paraf_turno >='" + TurnoD + "' and paraf_turno<='" + TurnoH + "'and paraf_bajaid is null"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function RepoCanerias() As DataTable
        sql = "select * from MCLIMPCVVAC where mclimpcvvac_fecha>='" + FechaD + "' and mclimpcvvac_fecha<='" + FechaH + "' " &
               "And mclimpcvvac_turno >='" + TurnoD + "' and mclimpcvvac_turno<='" + TurnoH + "'and mclimpcvvac_bajaid is null"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function RepoEnsayos() As DataTable
        sql = "select * from MCENSAYO where ensayo_fecha>='" + FechaD + "' and ensayo_fecha<='" + FechaH + "' " &
               "And ensayo_mc >='" + LineaD + "' and ensayo_mc<='" + LineaH + "' And ensayo_turno >='" + TurnoD + "' and ensayo_turno<='" + TurnoH + "'and ensayo_bajaid='0' " &
               "order by ensayo_fecha"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function RepoTQ3() As DataTable
        sql = "select * from MCENSAYOTQ3 where tq3_fecha>='" + FechaD + "' and tq3_fecha<='" + FechaH + "' " &
               "And tq3_turno >='" + TurnoD + "' and tq3_turno<='" + TurnoH + "'and tq3_bajaid='0' " &
               "order by tq3_fecha"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function RepoVariables() As DataTable
        sql = "select * from MCVARPROC where vdp_fecha>='" + FechaD + "' and vdp_fecha<='" + FechaH + "' " &
               "And vdp_mc >='" + LineaD + "' and vdp_mc<='" + LineaH + "' And vdp_turno >='" + TurnoD + "' and vdp_turno<='" + TurnoH + "'and vdp_bajaid='0' " &
               "order by vdp_fecha"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Return dt
    End Function



#End Region


End Class
