Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient



Public Class MaderaRep
    Inherits MetroFramework.Forms.MetroForm
    Dim fch As Date
    Dim sqlProv, sqlCampos, sqlMadera As String
    Dim daProv, daCampos, daMadera As New SqlDataAdapter
    Dim dtProv, dtCampos, dtMadera As DataTable
    Dim reporte As New MadReporte


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        fch = dtfecha.Text
        reporte.FechaD = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
        reporte.FechaH = dthasta.Text & " 21:59:59"

        'Si está chequeado madera busco maderas no biomasa (<152)
        If rbMadera.Checked = True Then
            tipo = "Madera"
            'Sí están chequeados todos
            If chkMadera.Checked = True Then
                reporte.MaderaD = 12
                reporte.MaderaH = 26
            Else
                reporte.MaderaD = cbMadera.SelectedValue
                reporte.MaderaH = cbMadera.SelectedValue

            End If

        ElseIf rbBiomasa.Checked = True Then
            tipo = "Biomasa"
            If chkMadera.Checked = True Then
                reporte.MaderaD = 151
                reporte.MaderaH = 200

            Else
                reporte.MaderaD = cbMadera.SelectedValue
                reporte.MaderaH = cbMadera.SelectedValue
            End If
        End If


        'PROVEEDORES
        If chKProv.Checked = True Then
            reporte.ProveedorD = 0
            reporte.ProveedorH = 99999
        Else
            reporte.ProveedorD = txtProv.Text
            reporte.ProveedorH = txtProv.Text
        End If

        'CAMPOS
        If chkCampos.Checked = True Then
            reporte.CampoD = "0"
            reporte.CampoH = "99999"
        Else
            reporte.CampoD = cbCampos.SelectedValue
            reporte.CampoH = cbCampos.SelectedValue
        End If


        If chkCampos.Checked = True Then
            reporte.CampoD = "0"
            reporte.CampoH = "99999"
            reporte.PropioD = "N"
            reporte.PropioH = "S"

        ElseIf chkCampos.Checked = False And chkPropios.Checked = False Then
            reporte.CampoD = cbCampos.SelectedValue
            reporte.CampoH = cbCampos.SelectedValue
            reporte.PropioD = "N"
            reporte.PropioH = "S"

        ElseIf chkPropios.Checked = True Then
            reporte.CampoD = "0"
            reporte.CampoH = "99999"
            'Si es campos propio
            reporte.PropioD = "S"
            reporte.PropioH = "S"

        End If


        If rbIngMadera.Checked = True Then
            dt = reporte.RepoIngresoMad
            nivdet = "IngMad"
        ElseIf rbInfCampos.Checked = True Then
            dt = reporte.RepoCampos
            nivdet = "InfCampos"
        ElseIf rbInfServicios.Checked = True Then
            dt = reporte.RepoServicios
            nivdet = "InfServicios"
        ElseIf rbTerceros.Checked = True Then
            dt = reporte.RepoMadTerceros
            nivdet = "Terceros"

        End If

        '***************************************
        Dim frmMadera As New RepoViewMadera(reporte)
        frmMadera.Show()



    End Sub

    'para saber el primer dia del mes 
    Function UltimoDiaDelMesAnt(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMesAnt = DateSerial(Year(dtmFecha), Month(dtmFecha), 0)
    End Function

    'para saber el ultimo dia del mes 
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function

   
    Private Sub rbTerceros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MaderaRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chKProv.Checked = True
        chkMadera.Checked = True
        chkCampos.Checked = True
        Call Inicio()
        Tipo_Reporte(sender, e)
    End Sub


    Private Sub Inicio()

        If chKProv.Checked = True Then
            txtProv.Enabled = False
            cbProv.Enabled = False
            cbProv.DataSource = Nothing
        End If

        If chkMadera.Checked = True Then
            cbMadera.Enabled = False
            cbMadera.DataSource = Nothing
        End If

        If chkCampos.Checked = True Then
            cbCampos.Enabled = False
            cbCampos.DataSource = Nothing
        End If

    End Sub



    Private Sub Tipo_Reporte(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTerceros.CheckedChanged, rbIngMadera.CheckedChanged, rbInfServicios.CheckedChanged, rbInfCampos.CheckedChanged

        If rbIngMadera.Checked = True Then
            gbProveedor.Enabled = True
            gbMadera.Enabled = True
            gbCampos.Enabled = False

        ElseIf rbInfServicios.Checked = True Then
            gbProveedor.Enabled = True
            gbMadera.Enabled = False
            gbCampos.Enabled = False

        ElseIf rbTerceros.Checked = True Then
            gbProveedor.Enabled = True
            gbMadera.Enabled = True
            gbCampos.Enabled = False

        ElseIf rbInfCampos.Checked = True Then
            gbProveedor.Enabled = False
            gbMadera.Enabled = False
            gbCampos.Enabled = True


        End If



    End Sub

    Private Sub cbProv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProv.SelectedIndexChanged
        Call buscaProv("where nombre='" + cbProv.Text + "' ")
        If n > 0 Then
            txtProv.Text = dtProv.Rows(0).Item("codigo")
        End If
    End Sub

    Private Sub cbProv_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProv.SelectionChangeCommitted
        Call buscaProv("where nombre='" + cbProv.Text + "' ")
        If n > 0 Then
            txtProv.Text = dtProv.Rows(0).Item("codigo")
        End If
    End Sub

    Private Sub buscaProv(ByVal buscar As String)
        conex("Proveedores")
        sqlProv = "Select * from PROVEEDORES " + buscar + ""
        daProv = New SqlDataAdapter(sqlProv, cnn)
        dtProv = New DataTable
        daProv.Fill(dtProv)
        Application.DoEvents()
        n = dtProv.Rows.Count

    End Sub

    Private Sub buscaCampo(ByVal buscar As String)
        conex("campos")
        sqlCampos = "Select * from Campos " + buscar + ""
        daCampos = New SqlDataAdapter(sqlCampos, cnn)
        dtCampos = New DataTable
        daCampos.Fill(dtCampos)
        Application.DoEvents()
        n = dtCampos.Rows.Count

    End Sub

    Private Sub buscaMad(ByVal buscar As String)
        conex("MaderaView")
        sqlMadera = "Select DISTINCT camion_pcod, camion_pdesc from MaderaView " + buscar + ""
        daMadera = New SqlDataAdapter(sqlMadera, cnn)
        dtMadera = New DataTable
        daMadera.Fill(dtMadera)
        Application.DoEvents()
        n = dtMadera.Rows.Count

    End Sub




    Private Sub txtProv_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProv.TextChanged
        Call buscaProv("where codigo='" + txtProv.Text + "' ")
        If n > 0 Then
            cbProv.Text = dtProv.Rows(0).Item("nombre")
        End If
    End Sub

    Private Sub chKProv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chKProv.CheckedChanged
        'Proveedor de Madera
        If chKProv.Checked = False Then
            txtProv.Enabled = True
            cbProv.Enabled = True
            Call buscaProv("order by nombre")
            cbProv.DataSource = dtProv
            cbProv.DisplayMember = "nombre"

        ElseIf chKProv.Checked = True Then
            txtProv.Text = ""
            txtProv.Enabled = False
            cbProv.DataSource = Nothing
            cbProv.Enabled = False
        End If

    End Sub

    Private Sub chkMadera_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMadera.CheckedChanged
        'TIPO DE MADERA
        If chkMadera.Checked = False Then
            cbMadera.Enabled = True

            If rbMadera.Checked = True Then
                Call buscaMad("INNER JOIN TIPMAD ON MaderaView.camion_pcod = TIPMAD.TIPMAD_CODBALANZA")
                cbMadera.DataSource = dtMadera
                cbMadera.DisplayMember = "camion_pdesc"
                cbMadera.ValueMember = "camion_pcod"
            ElseIf rbBiomasa.Checked = True Then
                Call buscaMad("where camion_pcod>150")
                cbMadera.DataSource = dtMadera
                cbMadera.DisplayMember = "camion_pdesc"
                cbMadera.ValueMember = "camion_pcod"

            End If

        ElseIf chkMadera.Checked = True Then
            cbMadera.DataSource = Nothing
            cbMadera.Enabled = False
        End If
    End Sub

  

   
    Private Sub CamposCHK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCampos.CheckedChanged, chkPropios.CheckedChanged
        'CAMPOS

        If chkCampos.Checked = True Then
            cbCampos.DataSource = Nothing
            cbCampos.Enabled = False
            chkPropios.Checked = False
            chkPropios.Enabled = False

        ElseIf chkCampos.Checked = False And chkPropios.Checked = False Then
            cbCampos.Enabled = True
            Call buscaCampo("order by descripcion")
            cbCampos.DataSource = dtCampos
            cbCampos.DisplayMember = "descripcion"
            cbCampos.ValueMember = "codigo"
            chkPropios.Enabled = True
        ElseIf chkPropios.Checked = True Then
            cbCampos.DataSource = Nothing
            cbCampos.Enabled = False

        End If
    End Sub
End Class