Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class NovedadesVisto

    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String

    Private Sub NovedadesVisto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargaarea()
        Call llenamotivo()

        'SENNOV se completa en el MenuPrincipal subrutina (NovSinLeer)
        If SenNov = "SINLEER" Then

            chktodos.Checked = True
            dtfecha.Text = "01/12/2016"
            dthasta.Text = Now
            cbmotivo.Text = motivo
        End If

        Call buscadatos()
    End Sub

    Private Sub conexion()
        conex("novedades")
    End Sub

    Private Sub llenamotivo()

        Call conex("motivonov")
        sql2 = "SELECT * From motivonov"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)

        cbmotivo.DataSource = dt2
        cbmotivo.DisplayMember = "motivonov_desc"
        cbmotivo.ValueMember = "motivonov_desc"


    End Sub

    Sub cargaarea()
        conex("area")
        sql1 = "SELECT  AREA.AREA_DESC FROM AREA"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        n = dt1.Rows.Count
        If n = 0 Then
            Me.Close()
        Else
            llenacb("area")
            cbsector.DataSource = dt7
            cbsector.DisplayMember = "area_desc"
            cbsector.ValueMember = "area_desc"
        End If
    End Sub

    Private Sub buscadatos()

        Call conexion()

        If chktodos.Checked = True Then
            sql1 = "SELECT  nov_id as ID,nov_area as Area,nov_fecha as Fecha, nov_turno as Turno,nov_grupo as Grupo, nov_motivo as Motivo , nov_texto as Texto,nov_user as Usuario from novedades where nov_fecha between '" + Mid(dtfecha.Text, 1, 10) + " 00:00:00 ' and '" + Mid(dthasta.Text, 1, 10) + " 23:59:59 ' and nov_motivo='" + Trim(cbmotivo.Text) + "' and nov_visto is null"
        Else
            sql1 = "SELECT  nov_id as ID,nov_area as Area,nov_fecha as Fecha, nov_turno as Turno,nov_grupo as Grupo, nov_motivo as Motivo , nov_texto as Texto,nov_user as Usuario from novedades where nov_fecha between '" + Mid(dtfecha.Text, 1, 10) + " 00:00:00 ' and '" + Mid(dthasta.Text, 1, 10) + " 23:59:59 ' and nov_motivo='" + Trim(cbmotivo.Text) + "' and nov_area='" + Trim(cbsector.Text) + "' and nov_visto is null"

        End If

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        m = dt1.Rows.Count

        dg.DataSource = dt1

    End Sub


    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click
        Call buscadatos()
    End Sub

    Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodos.CheckedChanged
        If chktodos.Checked = True Then
            cbsector.Enabled = False
        Else
            cbsector.Enabled = True
        End If
    End Sub

    Private Sub dg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.Click
        If m >= 0 Then
            lineanovedad = dg.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        If m = 0 Then
        Else

            novFCH = dg.CurrentRow.Cells("Fecha").Value
            novAREA = dg.CurrentRow.Cells("Area").Value
            novMOTIVO = dg.CurrentRow.Cells("Motivo").Value
            novTEXTO = dg.CurrentRow.Cells("Texto").Value
            novUSER = dg.CurrentRow.Cells("Usuario").Value

            Dim respnov As New NovRespVisto
            respnov.ShowDialog()

            Call buscadatos()
        End If
    End Sub

End Class

