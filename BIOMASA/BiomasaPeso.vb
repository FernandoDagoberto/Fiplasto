Public Class BiomasaPeso

    Private _ticket As String
    Private _fechaPesada As DateTime
    Private _codMad As String
    Private _tipMad As String
    Private _neto As Double
    Private _fechaPicado As String
    Private _turno As String
    Private _grupo As String

    Public Property GRUPO() As String
        Get
            Return _grupo
        End Get
        Set(ByVal value As String)
            _grupo = value
        End Set
    End Property

    Public Property TURNO() As String
        Get
            Return _turno
        End Get
        Set(ByVal value As String)
            _turno = value
        End Set
    End Property

    Public Property FECHAPICADO() As String
        Get
            Return _fechaPicado
        End Get
        Set(ByVal value As String)
            _fechaPicado = value
        End Set
    End Property

    Public Property NETO() As Double
        Get
            Return _neto
        End Get
        Set(ByVal value As Double)
            _neto = value
        End Set
    End Property

    Public Property TIPMAD() As String
        Get
            Return _tipMad
        End Get
        Set(ByVal value As String)
            _tipMad = value
        End Set
    End Property

    Public Property CODMAD() As String
        Get
            Return _codMad
        End Get
        Set(ByVal value As String)
            _codMad = value
        End Set
    End Property

    Public Property FECHAPESADA() As DateTime
        Get
            Return _fechaPesada
        End Get
        Set(ByVal value As DateTime)
            _fechaPesada = value
        End Set
    End Property

    Public Property TICKET() As String
        Get
            Return _ticket
        End Get
        Set(ByVal value As String)
            _ticket = value
        End Set
    End Property

#Region "Constructor"
    Public Sub New()

    End Sub
#End Region



End Class
