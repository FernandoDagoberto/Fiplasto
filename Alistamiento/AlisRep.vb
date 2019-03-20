Public Class AlisRep

    '----------TODO DE ACÁ PARA ABAJO ES PARA PROBAR EL REPORTE----------------
    Dim PrimerDiaMes As Date

    'para saber el ultimo dia del mes  anterior
    Function PrimerDiaDelMes(ByVal dtmFecha As Date) As Date
        PrimerDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha), 1)
    End Function



    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        fch = FechaDesde.Text   'FechaDesde
        fch1 = FechaHasta.Text  'FechaHasta

        fchPrimerDia = PrimerDiaDelMes(FechaHasta.Text)

        Dim reporte As New frmRepoAlist
        reporte.Show()
    End Sub
End Class