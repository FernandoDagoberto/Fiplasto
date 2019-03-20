Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Public Class NovedVisual
    Inherits MetroFramework.Forms.MetroForm

    Dim realizado As String
    Dim ms As Integer

    Private Sub NovVisual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        lblfch.Text = novFCH

        If novFCH < FormatDateTime(Now, DateFormat.ShortDate) Then
            lblfch.ForeColor = Color.Red
        End If

        lblarea.Text = novAREA
        lblmotivo.Text = novMOTIVO
        lblusuario.Text = novUSER
        lbltexto.Text = novTEXTO


    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvisto.Click
        Me.Close()
    End Sub

End Class