Public Class cRepo

#Region "Atributtes"
    Private _fechaD As DateTime
    Private _fechaH As DateTime
    Private _fechaIniMes As DateTime
    Private _lineaD As Integer
    Private _lineaH As Integer
    Private _paradaD As String
    Private _paradaH As String


#End Region

#Region "Constructor"
    Public Sub New()

    End Sub
#End Region

#Region "Properties"
    Public Property FechaIniMes() As DateTime
        Get
            Return _fechaIniMes
        End Get
        Set(ByVal value As DateTime)
            _fechaIniMes = value
        End Set
    End Property


    Public Property LineaH() As String
        Get
            Return _lineaH
        End Get
        Set(ByVal value As String)
            _lineaH = value
        End Set
    End Property

    Public Property LineaD() As String
        Get
            Return _lineaD
        End Get
        Set(ByVal value As String)
            _lineaD = value
        End Set
    End Property

    Public Property FechaH() As DateTime
        Get
            Return _fechaH
        End Get
        Set(ByVal value As DateTime)
            _fechaH = value
        End Set
    End Property

    Public Property FechaD() As DateTime
        Get
            Return _fechaD
        End Get
        Set(ByVal value As DateTime)
            _fechaD = value
        End Set
    End Property

    Public Property ParadaD() As String
        Get
            Return _paradaD
        End Get
        Set(ByVal value As String)
            _paradaD = value
        End Set
    End Property

    Public Property ParadaH() As String
        Get
            Return _paradaH
        End Get
        Set(ByVal value As String)
            _paradaH = value
        End Set
    End Property

#End Region

End Class
