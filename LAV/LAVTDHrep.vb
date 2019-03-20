Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class LAVTDHrep

    Inherits MetroFramework.Forms.MetroForm
    Dim repo As String
    Dim reporte As New LavReporte

    Private Sub LAVTDHrep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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



        'Para cuando se usa razón
        If chkrazon.Checked = False Then
            'Para reportes de report viewer
            reporte.RazonD = cbrazon.Text
            reporte.RazonH = cbrazon.Text

        Else
            'Para reportes de report viewer
            reporte.RazonD = ""
            reporte.RazonH = "ZZZZZZ"
        End If

        fch = dtdesde.Text
        '------------------------------------
        reporte.FechaD = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
        reporte.FechaH = dthasta.Text & " 21:59:59"

        If rblav.Checked = True Then
            reporte.Movimiento = "L"
            dt = reporte.RepoTDH
            nivdet = "TDHLavado"
        ElseIf rbSeg.Checked = True Then
            reporte.Movimiento = "R"
            dt = reporte.RepoTDHConRazon
            nivdet = "TDHSegr"
        ElseIf rbcam.Checked = True Then
            reporte.Movimiento = "C"
            dt = reporte.RepoTDH
            nivdet = "TDHCambio"
        ElseIf rbnuevo.Checked = True Then
            reporte.Movimiento = "N"
            dt = reporte.RepoTDH
            nivdet = "TDHNuevos"
        ElseIf rbbaja.Checked = True Then
            reporte.Movimiento = "B"
            dt = reporte.RepoTDH
            nivdet = "TDHBaja"
        ElseIf rbSegui.Checked = True Then
            dt = reporte.RepoTDHVida
            nivdet = "TDHVida"


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

    Private Sub llenaRazon()
        cbrazon.Refresh()
        Call conex("lavrazondest")
        sql = "SELECT * From LAVRAZONDEST where lavrd_cod='TDHSEG' and lavrd_combo='R' order by lavrd_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        cbrazon.DataSource = dt
        cbrazon.DisplayMember = "lavrd_desc"
        cbrazon.ValueMember = "lavrd_desc"

    End Sub

    Private Sub radioButtons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rblav.CheckedChanged, rbSeg.CheckedChanged, rbcam.CheckedChanged, rbnuevo.CheckedChanged, rbbaja.CheckedChanged, rbSegui.CheckedChanged
        pnlfecha.Visible = True
        pnllinea.Visible = True
        pnlrazon.Visible = False
        chkrazon.Checked = True

        If rbSeg.Checked = True Then
            pnlrazon.Visible = True
            Call llenaRazon()
        End If

    End Sub

    Private Sub chkrazon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkrazon.CheckedChanged
        If chkrazon.Checked = True Then
            cbrazon.Enabled = False
            cbrazon.Text = Nothing
        Else
            cbrazon.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        sql = "select * from czregdescartes"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

        If n = 0 Then

            For x = 0 To n - 1
                Dim fechaturno As DateTime
                If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                    fechaturno = FormatDateTime(Now.AddDays(1), DateFormat.LongDate)
                Else
                    fechaturno = FormatDateTime(Now, DateFormat.LongDate)

                End If
            Next
        End If

    End Sub


End Class