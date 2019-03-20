Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class MCrep

    Inherits MetroFramework.Forms.MetroForm
    Dim repo As String
    Dim reporte As New MCReporte



    Private Sub MCrep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call habilitalinea()
        repo = ""
    End Sub


    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click
        sql = Nothing


        If rbcuchillas.Checked = True Or rbhipo.Checked = True Or rblimp.Checked = True Or rbparaf.Checked = True Or rbtelas.Checked = True Or rbvar.Checked = True Or rbensmaq.Checked = True Then

            If chklinea.Checked = False And cblinea.Text = "" Then
                MetroMessageBox.Show(Me, "Favor de seleccionar línea", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbturno.Focus()
                Exit Sub
            Else
                If chklinea.Checked = False Then
                    lineaD = cblinea.Text
                    lineaH = cblinea.Text
                    reporte.LineaD = cblinea.Text
                    reporte.LineaH = cblinea.Text
                Else
                    lineaD = "0"
                    lineaH = "9"
                    reporte.LineaD = "0"
                    reporte.LineaH = "9"
                End If
            End If

        End If

        If chktodos.Checked = False And cbturno.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de seleccionar turno", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbturno.Focus()
            Exit Sub
        End If

        If chktodos.Checked = False Then
            turnoD = cbturno.Text
            turnoH = cbturno.Text
            reporte.TurnoD = cbturno.Text
            reporte.TurnoH = cbturno.Text
        Else
            turnoD = "0"
            turnoH = "9999"
            reporte.TurnoD = "0"
            reporte.TurnoH = "9999"
        End If


        'Para ver en que programa se ve el reporte
        fch = dtdesde.Text
        fechaant = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
        fecha = dthasta.Text & " 21:59:59"

        reporte.FechaD = fechaant
        reporte.FechaH = fecha

        If rbcuchillas.Checked Then
            dt = reporte.RepoCuchillas
            nivdet = "Cuchillas"
        ElseIf rbensmaq.Checked Then
            dt = reporte.RepoEnsayos
            nivdet = "ensmaq"
        ElseIf rbenstq.Checked Then
            dt = reporte.RepoTQ3
            nivdet = "enstq"
        ElseIf rbvar.Checked Then
            dt = reporte.RepoVariables
            nivdet = "varproc"
        ElseIf rbhipo.Checked Then
            dt = reporte.RepoHipo
            nivdet = "hipoclorito"
        ElseIf rblimp.Checked Then
            dt = reporte.RepoLimpVac
            nivdet = "LimpVac"
        ElseIf rbparaf.Checked Then
            dt = reporte.RepoConsumoParafina
            nivdet = "ConsumoParafina"
        ElseIf rbpreparaf.Checked Then
            dt = reporte.RepoParafina
            nivdet = "Parafina"
        ElseIf rbvalv.Checked Then
            dt = reporte.RepoCanerias
            nivdet = "Canerias"
        End If

        If dt.Rows.Count = 0 Then
            MetroMessageBox.Show(Me, "No hay datos con los parámetros seleccionados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        Dim frmMCREPO As New frmREPOViewMC
        frmMCREPO.Show()

    End Sub

    Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodos.CheckedChanged

        If chktodos.Checked = True Then
            cbturno.Enabled = False
        Else
            cbturno.Enabled = True

        End If
    End Sub

    Private Sub chklinea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklinea.CheckedChanged
        If chklinea.Checked = True Then
            cblinea.Enabled = False
        Else
            cblinea.Enabled = True
        End If
    End Sub


    Sub habilitalinea()
        If rbcuchillas.Checked = True Or rbhipo.Checked = True Or rblimp.Checked = True Or rbparaf.Checked = True Or rbtelas.Checked = True Or rbvar.Checked = True Or rbensmaq.Checked = True Then
            plLinea.Visible = True
        Else
            plLinea.Visible = False
        End If
    End Sub


    Private Sub rbcuchillas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcuchillas.CheckedChanged
        Call habilitalinea()
        repo = "Crystal"
    End Sub

    Private Sub rbparaf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbparaf.CheckedChanged
        Call habilitalinea()
        repo = "Crystal"
    End Sub

    Private Sub rbhipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbhipo.CheckedChanged
        Call habilitalinea()
        repo = "Crystal"
    End Sub


    Private Sub rblimp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rblimp.CheckedChanged
        Call habilitalinea()
        repo = "Crystal"
    End Sub

    Private Sub rbvalv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbvalv.CheckedChanged
        Call habilitalinea()
        repo = "Crystal"
    End Sub

    Private Sub rbtelas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtelas.CheckedChanged
        Call habilitalinea()
        repo = "Crystal"
    End Sub


    Private Sub rbpreparaf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbpreparaf.CheckedChanged
        Call habilitalinea()
        repo = "Crystal"
    End Sub


    Private Sub rbenstq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbenstq.CheckedChanged
        Call habilitalinea()
        repo = "RepoView"
    End Sub

    Private Sub rbensmaq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbensmaq.CheckedChanged
        Call habilitalinea()
        repo = "RepoView"
    End Sub


    Private Sub rbvar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbvar.CheckedChanged
        Call habilitalinea()
        repo = "RepoView"
    End Sub

End Class