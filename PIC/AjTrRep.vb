Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient



Public Class AjTrRep
    Inherits MetroFramework.Forms.MetroForm

    Dim fch As Date

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        fch = dtfecha.Text
        fechaant = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
        fecha = dthasta.Text & " 21:59:59"

        If rbaj.Checked = True Then
            nivdet = "ajuste_inventario"
        Else
            nivdet = "transfviga"
        End If

        ''***************************************
        Dim frmAjuInv As New frmREPOViewPic
        frmAjuInv.Show()

    End Sub

    'para saber el ultimo dia del mes  anterior
    Function UltimoDiaDelMesAnt(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMesAnt = DateSerial(Year(dtmFecha), Month(dtmFecha), 0)
    End Function

    'para saber el ultimo dia del mes 
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function

End Class