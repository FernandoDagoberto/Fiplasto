Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class CZrep

    Inherits MetroFramework.Forms.MetroForm
    Dim repo As String
    Dim reporte As New CZReporte


    Private Sub CZrep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
  

    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click
        If chktodos.Checked = False Then
            'Para reportes de report viewer
            reporte.TurnoD = cbturno.Text
            reporte.TurnoH = cbturno.Text

        Else
            'Para reportes de report viewer
            reporte.TurnoD = "0"
            reporte.TurnoH = "9999"

        End If


        If chklinea.Checked = False Then
            'Para reportes de report viewer
            reporte.LineaD = cblinea.Text
            reporte.LineaH = cblinea.Text

        Else
            'Para reportes de report viewer
            reporte.LineaD = "0"
            reporte.LineaH = "9"
        End If

        If chkmotivos.Checked = False Then
            'Para reportes de report viewer
            reporte.DefectoD = cbmotivo.Text
            reporte.DefectoH = cbmotivo.Text

        Else
            'Para reportes de report viewer
            reporte.DefectoD = "A"
            reporte.DefectoH = "ZZZZ"
        End If


        If rbdescartes.Checked = True Then

            'PARA CUANDO SE USA GRUPO
            If chkgrupo.Checked = False Then
                'Para reportes de report viewer
                reporte.TurnoD = cbgrupo.Text
                reporte.TurnoH = cbgrupo.Text
            Else
                'Para reportes de report viewer
                reporte.TurnoD = "A"
                reporte.TurnoH = "ZZZZZ"

            End If
        Else
        End If
        Dim b As Integer = 1


        'Para cuando se usa espesor
        If chkespesor.Checked = False Then
            'Para reportes de report viewer
            reporte.MaterialD = cbespesor.Text
            reporte.MaterialH = cbespesor.Text

        Else
            'Para reportes de report viewer
            reporte.MaterialD = "0"
            reporte.MaterialH = "9"
        End If



        'Para ver zorras reparadas o para reparación
        If chkpreparar.Checked = True And chkreparada.Checked = False Then
            'Ver solo para reparar
            ReparaD = "N"
            ReparaH = "N"
        ElseIf chkpreparar.Checked = False And chkreparada.Checked = True Then
            'Ver solo reparadas
            ReparaD = "S"
            ReparaH = "S"
        Else
            'Ver todas
            ReparaD = "N"
            ReparaH = "S"
        End If

        fch = dtdesde.Text

        '------------------------------------
        If repo = "Crystal" Then

            fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.GeneralDate) & " 22:00:00"
            fecha = dthasta.Text & " 21:59:59"
            lineaD = reporte.LineaD
            lineaH = reporte.LineaH
            turnoD = reporte.TurnoD
            turnoH = reporte.TurnoH
            DefectoD = reporte.DefectoD
            DefectoH = reporte.DefectoH



            Dim frmCZ As New frmrepCZ
            frmCZ.Show()

        Else
            reporte.FechaD = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
            reporte.FechaH = dthasta.Text & " 21:59:59"

            If rbaceptaciones.Checked Then
                dt = reporte.RepoZorrasConforme

            ElseIf rbCtrlDim.Checked Then
                dt = reporte.RepoCtrlDim

            ElseIf rbespesores.Checked Then
                dt = reporte.RepoPromEspesores

            ElseIf rbrechazos.Checked Then
                dt = reporte.RepoRechazos

            ElseIf rbreparacion.Checked Then
                dt = reporte.RepoReparacion

            ElseIf rbrotulador.Checked Then
                dt = reporte.RepoRotulador

            ElseIf rbtblpren.Checked Then
                dt = reporte.RepoTblCargados

            End If


            Dim fr As New frmREPOViewCZ(reporte)
            fr.Show()



        End If



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


    Private Sub llenamotivo()
        Call conex("czdefectos")
        sql = "SELECT * From CZDEFECTOS order by czdefectos_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

        If n = 0 Then

        Else
            cbmotivo.DataSource = dt
            cbmotivo.DisplayMember = "czdefectos_desc"
            cbmotivo.ValueMember = "czdefectos_desc"
        End If

    End Sub

    Private Sub llenamotivoDescartes()
        Call conex("CZDESCARTEI")
        sql = "SELECT * FROM CZDESCARTEI where CZDESCI_BAJA='N' order by CZDESCI_DESC"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

        If n = 0 Then

        Else
            cbmotivo.DataSource = dt
            cbmotivo.DisplayMember = "CZDESCI_DESC"
            cbmotivo.ValueMember = "CZDESCI_DESC"
        End If

    End Sub

    Private Sub rb_Cambio(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbaceptaciones.CheckedChanged, rbCtrlDim.CheckedChanged, rbtblpren.CheckedChanged, rbrechazos.CheckedChanged, rbrotulador.CheckedChanged, rbdescartes.CheckedChanged, rbespesores.CheckedChanged, rbreparacion.CheckedChanged
        repo = Nothing

        'Metodo común para todos los RadioButton
        If rbtblpren.Checked = True Then
            Call rbOpComunes()
            nivdet = "tblpren"

        ElseIf rbaceptaciones.Checked = True Then
            Call rbOpComunes()
            nivdet = "tblacept"

        ElseIf rbrechazos.Checked = True Then
            Call rbOpComunes()
            pnlmotivo.Visible = True
            Call llenamotivo()
            nivdet = "tblrech"


        ElseIf rbrotulador.Checked = True Then
            Call rbOpComunes()
            nivdet = "rotulador"

        ElseIf rbdescartes.Checked = True Then

            Call rbOpComunes()
            pnlturno.Visible = False
            pnlgrupo.Visible = True
            pnlmotivo.Visible = True
            Call llenamotivoDescartes()
            repo = "Crystal"
            nivdet = "descartes"

        ElseIf rbespesores.Checked = True Then

            Call rbOpComunes()
            pnlespesor.Visible = True
            Call cargaespesores()
            repo = "RepoView"
            nivdet = "espesor"

        ElseIf rbreparacion.Checked = True Then

            Call rbOpComunes()
            pnllinea.Visible = False
            pnlreparar.Visible = True
            repo = "RepoView"
            nivdet = "reparar"

        ElseIf rbCtrlDim.Checked = True Then

            Call rbOpComunes()
            repo = "RepoView"
            nivdet = "ctrldim"

        End If

    End Sub

    Private Sub rbOpComunes()
        pnlturno.Visible = True
        pnllinea.Visible = True
        pnlgrupo.Visible = False
        pnlmotivo.Visible = False
        pnlespesor.Visible = False
        pnlreparar.Visible = False
    End Sub




    Private Sub chkmotivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmotivos.CheckedChanged
        If chkmotivos.Checked = True Then
            cbmotivo.Enabled = False
            cbmotivo.Text = Nothing
        Else
            cbmotivo.Enabled = True



        End If

    End Sub


    Private Sub chkgrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkgrupo.CheckedChanged
        If chkgrupo.Checked = True Then
            cbgrupo.Enabled = False
        Else
            cbgrupo.Enabled = True

        End If
    End Sub



    Private Sub cargaespesores()
        Call conex("czdefectos")
        sql = "SELECT * From MCMATERIAL where material_mc='2' order by material_medmm"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

        If n = 0 Then

        Else
            cbespesor.DataSource = dt
            cbespesor.DisplayMember = "material_medmm"
            cbespesor.ValueMember = "material_medmm"
        End If
    End Sub

    Private Sub chkespesor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkespesor.CheckedChanged
        If chkespesor.Checked = True Then
            cbespesor.Enabled = False
            cbespesor.Text = Nothing
        Else
            cbespesor.Enabled = True

        End If
    End Sub


End Class