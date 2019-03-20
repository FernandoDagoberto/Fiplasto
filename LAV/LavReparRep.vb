Public Class LavReparRep
    Inherits MetroFramework.Forms.MetroForm
    Dim fch, fchant As Date
    Dim reporte As New LavReporte

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        fch = dtdesde.Text

        '------------------------------------

        reporte.FechaD = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
        reporte.FechaH = dthasta.Text & " 21:59:59"

        dt = reporte.RepoReparaciones
        nivdet = "REPARACIONES"


        ''***************************************
        Dim fr As New frmREPOViewLav(reporte)
        fr.Show()



    End Sub

End Class