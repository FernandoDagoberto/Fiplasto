Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class LAVGralrep

    Inherits MetroFramework.Forms.MetroForm
    Dim repo As String
    Dim reporte As New LavReporte


    Private Sub LAVGralrep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click

        reporte.TurnoD = cbturno.Text

        fch = dtdesde.Text
        '------------------------------------


        reporte.FechaD = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
        reporte.FechaH = dthasta.Text & " 21:59:59"

        dt = reporte.repoGeneral
        nivdet = "LAVGRAL"


        Dim fr As New frmREPOViewLav(reporte)
        fr.Show()



        repo = ""


    End Sub


End Class