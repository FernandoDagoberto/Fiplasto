Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class M48rep
    Inherits MetroFramework.Forms.MetroForm
    Dim repo As String


    Private Sub M48rep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub


    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click

        If chktodos.Checked = False And cbturno.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de seleccionar turno", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cbturno.Focus()
            Exit Sub
        End If

        If chktodos.Checked = False Then
            'Para reportes de report viewer
            turnoD = cbturno.Text
            turnoH = cbturno.Text

        Else
            'Para reportes de report viewer
            turnoD = "0"
            turnoH = "9999"

        End If


        If chklinea.Checked = False Then
            'Para reportes de report viewer
            lineaD = cblinea.Text
            lineaH = cblinea.Text

        Else
            'Para reportes de report viewer
            lineaD = "0"
            lineaH = "9"
        End If


        fch = dtdesde.Text
        fechaant = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
        fecha = dthasta.Text & " 21:59:59"

        If cbensayos.Checked = True Then
            nivdet = "ensayosM48"
        ElseIf cbctrl.Checked = True Then
            nivdet = "ctrlfibras"
        ElseIf cbbolsas.Checked = True Then
            nivdet = "bolsas"
        ElseIf cbvar.Checked = True Then
            nivdet = "variables"
        End If
        '***************************************
        Dim repo As New frmRepoViewM48
        repo.Show()


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

    Private Sub cbensayos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbensayos.CheckedChanged
        If cbensayos.Checked = True Then
            panel1.Visible = True
        Else
            panel1.Visible = False
        End If

        repo = "RepoView"

    End Sub


End Class