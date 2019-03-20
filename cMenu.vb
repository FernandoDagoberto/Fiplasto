Imports System.Data.SqlClient

Public Class cMenu
    Dim _nombreTreeview As String
    Dim _nombreFormulario As String


    Public Sub New()

    End Sub


    Public Sub New(ByVal nombreTV As String, nombreForm As String)

        Me.NombreTreeview = nombreTV
        NombreFormulario = nombreForm

    End Sub



    Public Property NombreTreeview As String
        Get
            Return _nombreTreeview
        End Get
        Set(value As String)
            _nombreTreeview = value
        End Set
    End Property

    Public Property NombreFormulario As String
        Get
            Return _nombreFormulario
        End Get
        Set(value As String)
            _nombreFormulario = value
        End Set
    End Property
End Class
