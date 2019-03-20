Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient



Public Class EfiPicRep
    Inherits MetroFramework.Forms.MetroForm
    Dim fch As Date


    'para saber el ultimo dia del mes  anterior
    Function UltimoDiaDelMesAnt(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMesAnt = DateSerial(Year(dtmFecha), Month(dtmFecha), 0)
    End Function

    'para saber el ultimo dia del mes 
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function

    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click

        'un día menos que la fecha desde para luego al buscar en el reporte busque desde las 22:00 del día anterior.
        fch = dtfecha.Text
        fechaant = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
        'fecha hasta --- se pone hasta las 22 en lugar de 21:59 para que en el reporte realvsobjetivo funcione el datediff
        fecha = dthasta.Text & " 22:00:00"

        If chktodos.Checked = True Then
            turnoD = 0
            turnoH = 9999
        Else
            turnoD = cbturno.Text
            turnoH = cbturno.Text
        End If


        If rbeficiencia.Checked = True Then
            nivdet = "efipic"
        Else
            nivdet = "realvsobjetivo"
        End If

        '***************************************
        Dim frmRepo As New frmREPOViewPic
        frmRepo.Show()



    End Sub

    Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodos.CheckedChanged
        If chktodos.Checked = True Then
            cbturno.Text = Nothing
            cbturno.Enabled = False

        Else
            cbturno.Enabled = True

        End If
    End Sub
End Class