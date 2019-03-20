Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class LAVCCPrep

    Inherits MetroFramework.Forms.MetroForm
    Dim repo As String
    Dim reporte As New LavReporte
    Dim valor As Double


    Private Sub LAVCCPrep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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



        'Para cuando se usa destino (se pasan variables como RAZON D/H pero en el reporte en realidad se busca el destino)
        If chkrazon.Checked = False Then
            'Para reportes de report viewer
            reporte.RazonD = cbrazon.Text
            reporte.RazonH = cbrazon.Text

        Else
            'Para reportes de report viewer
            reporte.RazonD = "A"
            reporte.RazonH = "ZZZZZZ"
        End If

        fch = dtdesde.Text


        '------------------------------------
        reporte.FechaD = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
        reporte.FechaH = dthasta.Text & " 21:59:59"

        If rbIng.Checked = True Then
            dt = reporte.RepoCubrePlacasIngreso
            nivdet = "CCPIng"
        ElseIf rbEgreso.Checked = True Then
            dt = reporte.RepoCubrePlacasEgreso
            nivdet = "CCPEgr"
        ElseIf rbSegui.Checked = True Then
            dt = reporte.RepoCubrePlacasVida
            nivdet = "CCPVida"
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim fr As New frmREPOViewLav(reporte)
        fr.Show()
        Me.Cursor = Cursors.Default

        repo = ""


    End Sub


    Private Sub chklinea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklinea.CheckedChanged
        If chklinea.Checked = True Then
            cblinea.Enabled = False
        Else
            cblinea.Enabled = True
        End If


    End Sub

    Private Sub rbIng_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIng.CheckedChanged
        If rbIng.Checked = True Then
            pnlfecha.Visible = True
            pnllinea.Visible = True
            pnldestino.Visible = False

        End If


    End Sub

    Private Sub rbEgreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEgreso.CheckedChanged
        If rbEgreso.Checked = True Then

            pnlfecha.Visible = True
            pnllinea.Visible = True
            pnldestino.Visible = True
            Call llenaDestEgr()

        End If


    End Sub

    Private Sub llenaDestEgr()
        cbrazon.Refresh()
        Call conex("lavrazondest")
        sql = "SELECT * From LAVRAZONDEST where lavrd_cod='CCEGR' and lavrd_combo='R' order by lavrd_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        cbrazon.DataSource = dt
        cbrazon.DisplayMember = "lavrd_desc"
        cbrazon.ValueMember = "lavrd_desc"

    End Sub


    Private Sub chkrazon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkrazon.CheckedChanged
        If chkrazon.Checked = True Then
            cbrazon.Enabled = False
            cbrazon.Text = Nothing
        Else
            cbrazon.Enabled = True

        End If
    End Sub


    
    Private Sub rbSegui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSegui.CheckedChanged
        If rbSegui.Checked = True Then
            pnlfecha.Visible = True
            pnllinea.Visible = True
            pnldestino.Visible = False

        End If
    End Sub
End Class