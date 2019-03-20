Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class LAVDECOrep

    Inherits MetroFramework.Forms.MetroForm
    Dim reporte As New LavReporte


    Private Sub LAVDECOrep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call llenaDeco()

    End Sub


    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click

        'Para cuando se usa decorativo (se pasan variables como RAZON D/H pero en el reporte en realidad se busca el decorativo)
        If chktodos.Checked = False Then
            'Para reportes de report viewer
            reporte.RazonD = cbdeco.Text
            reporte.RazonH = cbdeco.Text

        Else
            'Para reportes de report viewer
            reporte.RazonD = "A"
            reporte.RazonH = "ZZZZZZ"
        End If


        fch = dtdesde.Text
        '------------------------------------
        reporte.FechaD = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
        reporte.FechaH = dthasta.Text & " 21:59:59"

        dt = reporte.RepoDecorativo
        nivdet = "LAVDECO"
        Dim fr As New frmREPOViewLav(reporte)
        fr.Show()


    End Sub

    Private Sub llenaDeco()
        cbdeco.Refresh()
        Call conex("decorativo")
        sql = "SELECT * From decorativo where deco_baja='N' order by deco_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        cbdeco.DataSource = dt
        cbdeco.DisplayMember = "deco_desc"
        cbdeco.ValueMember = "deco_desc"

    End Sub


    Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chktodos.Checked = True Then
            cbdeco.Enabled = False
            cbdeco.Text = Nothing
        Else
            cbdeco.Enabled = True

        End If
    End Sub



End Class