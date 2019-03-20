Public Class LAVSODArep

    Inherits MetroFramework.Forms.MetroForm
    Dim repo As String
    Dim reporte As New LavReporte


    Private Sub LAVSODArep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub


    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click


        If chklinea.Checked = False Then
            'Para reportes de report viewer
            reporte.LineaD = cblinea.Text
            reporte.LineaH = cblinea.Text

        Else
            'Para reportes de report viewer
            reporte.LineaD = "0"
            reporte.LineaH = "9"
        End If
        fch = dtdesde.Text
        '------------------------------------
        reporte.FechaD = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
        reporte.FechaH = dthasta.Text & " 21:59:59"

        If rbSoda.Checked = True Then
            dt = reporte.RepoConsumoSodaCaustica
            nivdet = "SODASoda"
        ElseIf rbTemp.Checked = True Then
            dt = reporte.RepoTemperatura
            nivdet = "SODATemp"
        ElseIf rbLimp.Checked = True Then
            dt = reporte.RepoLimpCubas
            nivdet = "LimpCuba"
        End If

        Dim fr As New frmREPOViewLav(reporte)
        fr.Show()



        repo = ""


    End Sub


    Private Sub chklinea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklinea.CheckedChanged
        If chklinea.Checked = True Then
            cblinea.Enabled = False
        Else
            cblinea.Enabled = True
        End If


    End Sub


    Private Sub rbSoda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSoda.CheckedChanged

        If rbSoda.Checked = True Then
            pnlfecha.Visible = True
            pnllinea.Visible = True
        End If

    End Sub

    Private Sub rbTemp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTemp.CheckedChanged
        If rbTemp.Checked = True Then
            pnlfecha.Visible = True
            pnllinea.Visible = True
        End If
    End Sub

    Private Sub rbLimp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLimp.CheckedChanged
        If rbLimp.Checked = True Then
            pnlfecha.Visible = True
            pnllinea.Visible = False
        End If
    End Sub
End Class