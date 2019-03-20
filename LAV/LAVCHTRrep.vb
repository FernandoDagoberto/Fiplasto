Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class LAVCHTRrep

    Inherits MetroFramework.Forms.MetroForm
    Dim reporte As New LavReporte


    Private Sub LAVCHTRrep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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
        If chkdestino.Checked = False Then
            'Para reportes de report viewer
            reporte.RazonD = cbdestino.Text
            reporte.RazonH = cbdestino.Text

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
            dt = reporte.RepoCHTRIngreso()
            nivdet = "CHTRIng"
        ElseIf rbEgreso.Checked = True Then
            dt = reporte.RepoCHTREgreso
            nivdet = "CHTREgr"
        ElseIf rbsegui.Checked = True Then
            dt = reporte.RepoCHTRVida
            nivdet = "CHTRVida"

        End If


        Dim fr As New frmREPOViewLav(reporte)
        fr.Show()



        'repo = ""


    End Sub


    Private Sub chklinea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklinea.CheckedChanged
        If chklinea.Checked = True Then
            cblinea.Enabled = False
        Else
            cblinea.Enabled = True
        End If


    End Sub

    Private Sub llenaRazon()
        cbdestino.Refresh()
        Call conex("lavrazondest")
        sql = "SELECT * From LAVRAZONDEST where lavrd_cod='TDHSEG' and lavrd_combo='R' order by lavrd_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        cbdestino.DataSource = dt
        cbdestino.DisplayMember = "lavrd_desc"
        cbdestino.ValueMember = "lavrd_desc"

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
        cbdestino.Refresh()
        Call conex("lavrazondest")
        sql = "SELECT * From LAVRAZONDEST where lavrd_cod='CHTREGR' and lavrd_combo='D' order by lavrd_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        cbdestino.DataSource = dt
        cbdestino.DisplayMember = "lavrd_desc"
        cbdestino.ValueMember = "lavrd_desc"

    End Sub


    Private Sub chkrazon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdestino.CheckedChanged
        If chkdestino.Checked = True Then
            cbdestino.Enabled = False
            cbdestino.Text = Nothing
        Else
            cbdestino.Enabled = True

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

    Private Sub rbsegui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbsegui.CheckedChanged
        If rbsegui.Checked = True Then
            pnlfecha.Visible = True
            pnllinea.Visible = True
            pnldestino.Visible = False

        End If
    End Sub
End Class