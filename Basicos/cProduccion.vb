Public Class cProduccion

#Region "Atributtes"

    Private _fecha As DateTime
    Private _linea As Integer
    Private _producto As String
    Private _prensada As Integer
    Private _factor As Double
    Private _aberturas As Integer
    Private _decorativo As Integer
    Private _merma As Integer

#End Region

#Region "Constructor"
    Public Sub New()

    End Sub
#End Region

#Region "Properties"
    Public Property Merma() As Integer
        Get
            Return _merma
        End Get
        Set(ByVal value As Integer)
            _merma = value
        End Set
    End Property

    Public Property Decorativo() As Integer
        Get
            Return _decorativo
        End Get
        Set(ByVal value As Integer)
            _decorativo = value
        End Set
    End Property

    Public Property Aberturas() As Integer
        Get
            Return _aberturas
        End Get
        Set(ByVal value As Integer)
            _aberturas = value
        End Set
    End Property

    Public Property Factor() As Double
        Get
            Return _factor
        End Get
        Set(ByVal value As Double)
            _factor = value
        End Set
    End Property

    Public Property Prensada() As Integer
        Get
            Return _prensada
        End Get
        Set(ByVal value As Integer)
            _prensada = value
        End Set
    End Property

    Public Property Producto() As String
        Get
            Return _producto
        End Get
        Set(ByVal value As String)
            _producto = value
        End Set
    End Property

    Public Property Linea() As Integer
        Get
            Return _linea
        End Get
        Set(ByVal value As Integer)
            _linea = value
        End Set
    End Property

    Public Property Fecha() As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As DateTime)
            _fecha = value
        End Set
    End Property


#End Region

End Class
