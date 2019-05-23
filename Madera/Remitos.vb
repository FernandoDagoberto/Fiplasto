Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework

Public Class Remitos
    Inherits MetroFramework.Forms.MetroForm
    Dim sql, sql1, sql2, sql3, sql4, sql5, sqlProv, sqlCampos As String
    Dim da, da1, da5, daProv, daCampos As New SqlDataAdapter
    Dim dtProv, dtCampos As DataTable
    Dim cmd, cmd2, cmd3, cmd4, cmd5 As SqlCommand
    Dim RemitoPI, PMadera, PFlete, PTala, Madera, Bruto, Tara, Neto, Tipo, PMaderaCod, PFleteCod, PTalaCod, CampoCod, MaderaEnPie As String


    Private Sub txtRemito_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemito.KeyUp
        If e.KeyCode = Keys.Enter Then
            If Not IsNumeric(txtRemito.Text) Then
                MetroMessageBox.Show(Me, "Debe ingresar numero", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                Call buscaRemito(txtRemito.Text)

                If RemitoPI > 0 Then
                    MetroMessageBox.Show(Me, "Remito ya cargado, seleccione editar sí desea modificarlo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    limpia()
                    Exit Sub

                Else
                    If n <> 0 Then
                        If PTala = Nothing Then
                            'Bloqueo el campo remito
                            txtRemito.Enabled = False

                            'Habilito el campo Remito Pre Impreso
                            txtRemPI.Enabled = True

                            txtFecha.Text = fecha
                            txtMadera.Text = Madera
                            txtBruto.Text = Bruto
                            txtTara.Text = Tara
                            txtNeto.Text = Neto
                            'Habilito el campo Proveedores
                            pnlProv.Enabled = True

                            'Completar datos de PROVEEDORES - MADERA
                            'Sí el código de madera es 1 (Proveedor Fiplasto)
                            'MADERA PROPIA
                            If PMadera > 1 Then
                                chkMadera.Checked = True
                                Call buscaProv("where codProvMad='" + Str(PMadera) + "'")
                                If n = 0 Then
                                    chkMadera.Checked = False
                                    'chkMadera_CheckedChanged(sender, e)
                                Else
                                    txtCodMad.Text = dtProv.Rows(0).Item("codigo")
                                End If
                            Else
                                chkMadera.Checked = False
                                'chkMadera_CheckedChanged(sender, e)

                            End If

                            'Si detecta proveedor de madera pone lo mismo en tala.
                            If chkMadera.Checked = True Then
                                chkTala.Checked = True
                                txtCodTala.Text = txtCodMad.Text
                            Else
                                chkTala.Checked = False
                                'chkTala_CheckedChanged(sender, e)
                            End If


                            'Completar datos de PROVEEDORES - FLETE
                            If PFlete > 1 Then
                                chkFlete.Checked = True
                                Call buscaProv("where codFlete='" + Trim(Str(PFlete)) + "'")
                                If n = 0 Then
                                    chkFlete.Checked = False
                                    'chkFlete_CheckedChanged(sender, e)
                                Else

                                    txtCodFlete.Text = dtProv.Rows(0).Item("codigo")
                                End If

                            Else
                                chkFlete.Checked = False
                                'chkFlete_CheckedChanged(sender, e)
                            End If

                            txtRemPI.Focus()

                        Else
                            MetroMessageBox.Show(Me, "Remito ya cargado, seleccione editar sí desea modificarlo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            limpia()
                            Exit Sub

                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub buscaRemito(ByVal remito As Integer)

        conex("camion")
        sql = "Select * from Camion where camion_nroremito='" + Trim(remito) + "'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Application.DoEvents()
        n = dt.Rows.Count

        'Si no existe en Camion busco en BioCamion
        If n = 0 Then
            conex("Biocamion")
            sql = "Select * from BioCamion where nroremito='" + Trim(remito) + "'"
            da = New SqlDataAdapter(sql, cnn)
            dt = New DataTable
            da.Fill(dt)
            Application.DoEvents()
            n = dt.Rows.Count

            If n > 0 Then

                remito = dt.Rows(0).Item("nroremito")

                If IsDBNull(dt.Rows(0).Item("fechaegr")) Then
                    MetroMessageBox.Show(Me, "Camión en planta o proceso automático se encuentra tildado" + Chr(13) + "Avisar a sistemas", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Para que el sistema piense que no hay ningún registro y no continué ningún proceso
                    n = 0
                    Exit Sub
                Else
                    fecha = dt.Rows(0).Item("fechaegr")
                End If

                If IsDBNull(dt.Rows(0).Item("remitopi")) Then
                    RemitoPI = 0
                Else
                    RemitoPI = dt.Rows(0).Item("remitopi")
                End If

                Madera = dt.Rows(0).Item("pdesc")
                Bruto = dt.Rows(0).Item("pesobruto")
                Tara = dt.Rows(0).Item("pesotara")
                Neto = dt.Rows(0).Item("pesoneto")
                PMadera = dt.Rows(0).Item("rcod")
                PFlete = Str(dt.Rows(0).Item("tcod"))


                PMaderaCod = Str(dt.Rows(0).Item("transpcod"))
                PTalaCod = Str(dt.Rows(0).Item("talacod"))
                PFleteCod = Str(dt.Rows(0).Item("fletecod"))
                CampoCod = Str(dt.Rows(0).Item("campo"))
                lblMadera.Text = "BIOMASA"


            Else
            End If

        Else

            remito = dt.Rows(0).Item("camion_nroremito")

            If IsDBNull(dt.Rows(0).Item("camion_fechaegr"))  Then
                MetroMessageBox.Show(Me, "Camión en planta o proceso automático se encuentra tildado" + Chr(13) + "Avisar a sistemas", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Para que el sistema piense que no hay ningún registro y no continué ningún proceso
                n = 0
                Exit Sub
            Else
                fecha = dt.Rows(0).Item("camion_fechaegr")
            End If

            If IsDBNull(dt.Rows(0).Item("camion_remitopi")) Then
                RemitoPI = 0
            Else
                RemitoPI = dt.Rows(0).Item("camion_remitopi")
            End If

            Madera = dt.Rows(0).Item("camion_pdesc")
            Bruto = dt.Rows(0).Item("camion_pesobruto")
                Tara = dt.Rows(0).Item("camion_pesotara")
                Neto = dt.Rows(0).Item("camion_pesoneto")
                PMadera = dt.Rows(0).Item("camion_rcod")
                PFlete = dt.Rows(0).Item("camion_tcod")

                PMaderaCod = Str(dt.Rows(0).Item("camion_transpcod"))
                PTalaCod = Str(dt.Rows(0).Item("camion_talacod"))
                PFleteCod = Str(dt.Rows(0).Item("camion_fletecod"))
                CampoCod = Str(dt.Rows(0).Item("camion_campo"))
                lblMadera.Text = "MADERA"

            End If

            Tipo = lblMadera.Text


    End Sub


    Private Sub txtCodMad_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodMad.KeyUp
        If e.KeyCode = Keys.Enter Then
            Try
                Call buscaProv("where codigo='" + txtCodMad.Text + "' ")
                If n > 0 Then
                    cbMadera.Text = dtProv.Rows(0).Item("nombre")
                End If
            Catch ex As Exception

            End Try
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

    Private Sub txtCodTala_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodTala.KeyUp
        If e.KeyCode = Keys.Enter Then
            Try
                Call buscaProv("where codigo='" + txtCodTala.Text + "' ")
                If n > 0 Then
                    cbTala.Text = dtProv.Rows(0).Item("nombre")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtCodFlete_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodFlete.KeyUp
        If e.KeyCode = Keys.Enter Then
            Try
                Call buscaProv("where codigo='" + txtCodFlete.Text + "' ")
                If n > 0 Then
                    cbFlete.Text = dtProv.Rows(0).Item("nombre")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtCodMad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodMad.TextChanged
        Call buscaProv("where codigo='" + txtCodMad.Text + "' ")
        If n > 0 Then
            cbMadera.Text = dtProv.Rows(0).Item("nombre")
        End If
    End Sub

    Private Sub txtCodFlete_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodFlete.TextChanged

        Call buscaProv("where codigo='" + txtCodFlete.Text + "' ")
        If n > 0 Then
            cbFlete.Text = dtProv.Rows(0).Item("nombre")
        End If

    End Sub

    Private Sub txtCodTala_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTala.TextChanged
        Call buscaProv("where codigo='" + txtCodTala.Text + "' ")
        If n > 0 Then
            cbTala.Text = dtProv.Rows(0).Item("nombre")
        End If

    End Sub

    Private Sub cbMadera_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMadera.SelectedIndexChanged
        Call buscaProv("where nombre='" + cbMadera.Text + "' ")
        If n > 0 Then
            txtCodMad.Text = dtProv.Rows(0).Item("codigo")
        End If
    End Sub

    Private Sub cbMadera_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMadera.SelectionChangeCommitted
        Call buscaProv("where nombre='" + cbMadera.Text + "' ")
        If n > 0 Then
            txtCodMad.Text = dtProv.Rows(0).Item("codigo")
        End If
    End Sub

    Private Sub cbTala_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTala.SelectedIndexChanged
        Call buscaProv("where nombre='" + cbTala.Text + "' ")
        If n > 0 Then
            txtCodTala.Text = dtProv.Rows(0).Item("codigo")
        End If
    End Sub

    Private Sub cbTala_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTala.SelectionChangeCommitted
        Call buscaProv("where nombre='" + cbTala.Text + "' ")
        If n > 0 Then
            txtCodTala.Text = dtProv.Rows(0).Item("codigo")
        End If
    End Sub

    Private Sub cbFlete_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFlete.SelectedIndexChanged
        Call buscaProv("where nombre='" + cbFlete.Text + "' ")
        If n > 0 Then
            txtCodFlete.Text = dtProv.Rows(0).Item("codigo")
        End If
    End Sub

    Private Sub cbFlete_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFlete.SelectionChangeCommitted
        Call buscaProv("where nombre='" + cbFlete.Text + "' ")
        If n > 0 Then
            txtCodFlete.Text = dtProv.Rows(0).Item("codigo")
        End If
    End Sub

    Private Sub Remitos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkMadera.Checked = False
        chkTala.Checked = False
        chkFlete.Checked = False
        chkCampo.Checked = False

    End Sub

    Private Sub Opcion(sender As Object, e As EventArgs) Handles BtnNuevo.Click, btnSalir.Click, btnGuardar.Click, btnEditar.Click
        'Busco la opción por el nombre del botón
        Select Case sender.Name

            Case BtnNuevo.Name ' boton nuevo
                Call Nuevo()

            Case btnEditar.Name 'boton editar
                Dim rta As String
                rta = InputBox("Ingrese número de Remito", "Modificar Remito")
                If IsNumeric(rta) Then
                    Call modifica(rta)
                Else
                    MetroMessageBox.Show(Me, "Ingrese número de Remito", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    sen1 = 99
                End If

                'Si tira algún error no habilita los botones
                If sen1 = 99 Then
                    sen1 = 0
                    Exit Sub
                Else
                    btncancel.Visible = True
                    BtnNuevo.Enabled = False
                    btnEditar.Enabled = False
                    btnGuardar.Enabled = True
                    btnGrabar.Enabled = True
                End If

            Case btnGuardar.Name  'boton guardar
                Call guardaNuevo()

                If sen1 = 99 Then
                    sen1 = 0
                    Exit Sub
                End If

                Call limpia()
                Call Nuevo()

            Case btnSalir.Name ' boton salir
                Me.Close()
        End Select
    End Sub

    Private Sub Nuevo()
        sen = "n"
        btncancel.Visible = True
        btnGuardar.Enabled = True 'Guardar
        btnGrabar.Enabled = True           'Botón Guardar
        BtnNuevo.Enabled = False 'Nuevo
        btnEditar.Enabled = False 'Editar

        txtRemito.Enabled = True
        txtRemito.Focus()

    End Sub


    Private Sub limpia()
        txtRemito.Text = Nothing
        txtRemPI.Text = Nothing 'Remito PreImpreso
        txtRemPI.Enabled = False
        txtFecha.Text = Nothing
        txtMadera.Text = Nothing
        txtBruto.Text = Nothing
        txtTara.Text = Nothing
        txtNeto.Text = Nothing
        lblMadera.Text = Nothing
        chkMadera.Checked = False
        chkPie.Checked = False
        chkFlete.Checked = False
        chkTala.Checked = False
        chkCampo.Checked = False
        pnlProv.Enabled = False
        BtnNuevo.Enabled = True 'Nuevo
        btnEditar.Enabled = True 'Editar
        btnGuardar.Enabled = False 'Guardar
        btnGrabar.Enabled = False         'Botón Guardar

    End Sub

    Private Sub modifica(ByVal remito As Integer)
        Call buscaRemito(remito)
        If n = 0 Then
            MetroMessageBox.Show(Me, "Remito inexistente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sen1 = 99
            Exit Sub

        ElseIf Not IsNumeric(PTalaCod) Then
            MetroMessageBox.Show(Me, "Remito aún no cargado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sen1 = 99
            Exit Sub

        Else

            txtRemito.Enabled = False
            txtRemito.Text = remito
            'Para modificar el número preimpreso en caso de no haberlo ingresado
            txtRemPI.Enabled = True
            txtRemPI.Text = RemitoPI
            txtFecha.Text = fecha
            txtMadera.Text = Madera
            txtBruto.Text = Bruto
            txtTara.Text = Tara
            txtNeto.Text = Neto

            lblMadera.Text = Tipo

            pnlProv.Enabled = True



            'Completar datos de PROVEEDORES - MADERA
            'Sí el código de madera es 1 (Proveedor Fiplasto)
            'MADERA PROPIA
            If PMaderaCod > 1 Then
                chkMadera.Checked = True
                Call buscaProv("where codigo='" + Str(PMaderaCod) + "'")
                If n = 0 Then
                    chkMadera.Checked = False
                Else
                    txtCodMad.Text = dtProv.Rows(0).Item("codigo")
                End If

                If MaderaEnPie = "S" Then
                    chkPie.Checked = True
                Else
                    chkPie.Checked = False
                End If

            Else
                chkMadera.Checked = False

            End If


            '***************************CARGO LOS DATOS DE TALA DESDE EL CAMPO CAMION_TALACOD
            'Si detecta proveedor de madera pone lo mismo en tala.
            If PTalaCod > 1 Then
                chkTala.Checked = True
                Call buscaProv("where codigo='" + Str(PTalaCod) + "'")
                If n = 0 Then
                    chkTala.Checked = False
                Else
                    txtCodTala.Text = dtProv.Rows(0).Item("codigo")
                End If

            Else
                chkTala.Checked = False

            End If


            '***************************CARGO LOS DATOS DE FLETE DESDE EL CAMPO CAMION_FLETECOD
            'Completar datos de PROVEEDORES - FLETE
            If PFleteCod > 1 Then
                chkFlete.Checked = True
                Call buscaProv("where codigo='" + Trim(Str(PFleteCod)) + "'")
                If n = 0 Then
                    chkFlete.Checked = False
                Else
                    txtCodFlete.Text = dtProv.Rows(0).Item("codigo")
                End If
            Else
                chkFlete.Checked = False
            End If


            '***************************CARGO LOS DATOS DE CAMPO DESDE EL CAMPO CAMION_CAMPO
            'Completar datos de PROVEEDORES - FLETE
            'dt.Rows(0).Item("camion_fletecod")
            If CampoCod > 0 Then
                chkCampo.Checked = True
                Call buscaCampo("where codigo='" + Trim(CampoCod) + "'")
                If n = 0 Then
                    chkCampo.Checked = False
                Else
                    cbCampo.Text = dtCampos.Rows(0).Item("descripcion")
                End If
            Else
                chkCampo.Checked = False
            End If

        End If
    End Sub


    Private Sub guardaNuevo()
        If String.IsNullOrEmpty(txtRemito.Text) Or String.IsNullOrEmpty(txtRemPI.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar el campo número de Remito o Remito PI", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sen1 = 99
            Exit Sub

        Else
            Dim campo As String
            If chkCampo.Checked = False Then
                campo = 0
            Else
                campo = cbCampo.SelectedValue
            End If


            If chkPie.Checked = True Then
                MaderaEnPie = "S"
            Else
                MaderaEnPie = "N"
            End If

            If lblMadera.Text = "MADERA" Then
                sql2 = "update CAMION set camion_remitopi='" + txtRemPI.Text + "' ,camion_talacod='" + Trim(txtCodTala.Text) + "', camion_transpcod='" + Trim(txtCodMad.Text) + "' " &
                       " ,camion_fletecod='" + Trim(txtCodFlete.Text) + "',camion_campo='" + Trim(campo) + "', camion_enpie='" + Trim(MaderaEnPie) + "'  where camion_nroremito='" + txtRemito.Text + "'"

            ElseIf lblMadera.Text = "BIOMASA" Then
                sql2 = "update BIOCAMION set remitopi='" + txtRemPI.Text + "',talacod='" + Trim(txtCodTala.Text) + "', transpcod='" + Trim(txtCodMad.Text) + "' " &
                   " ,fletecod='" + Trim(txtCodFlete.Text) + "',campo='" + Trim(campo) + "', enpie='" + Trim(MaderaEnPie) + "'  where nroremito='" + txtRemito.Text + "'"

            Else
                MetroMessageBox.Show(Me, "No se puede guardar", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sen1 = 99
                pnlProv.Enabled = False
                Exit Sub
            End If

            cmd2 = New SqlCommand(sql2, cnn)
            cmd2.Connection.Open()
            cmd2.ExecuteNonQuery()
            cmd2.Connection.Close()

            Application.DoEvents()
            pnlProv.Enabled = False

        End If

    End Sub

    Private Sub txtRemito_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemito.TextChanged

    End Sub

    Private Sub chkCampo_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCampo.CheckStateChanged
        If chkCampo.Checked = True Then
            cbCampo.Enabled = True
            Call buscaCampo("order by descripcion")
            cbCampo.DataSource = dtCampos
            cbCampo.DisplayMember = "descripcion"
            cbCampo.ValueMember = "codigo"

        ElseIf chkCampo.Checked = False Then
            cbCampo.DataSource = Nothing
            cbCampo.Enabled = False
        End If
    End Sub

    Private Sub chkMadera_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMadera.CheckStateChanged
        If chkMadera.Checked = True Then
            txtCodMad.Enabled = True
            cbMadera.Enabled = True
            Call buscaProv("order by nombre")
            cbMadera.DataSource = dtProv
            cbMadera.DisplayMember = "nombre"
            chkPie.Enabled = True

        Else
            txtCodMad.Text = ""
            txtCodMad.Enabled = False
            cbMadera.DataSource = Nothing
            cbMadera.Enabled = False
            chkPie.Enabled = False
            chkPie.Checked = False
        End If
    End Sub

    Private Sub chkTala_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTala.CheckStateChanged
        If chkTala.Checked = True Then
            txtCodTala.Enabled = True
            cbTala.Enabled = True
            Call buscaProv("order by nombre")
            cbTala.DataSource = dtProv
            cbTala.DisplayMember = "nombre"

        Else
            txtCodTala.Text = ""
            txtCodTala.Enabled = False
            cbTala.DataSource = Nothing
            cbTala.Enabled = False
        End If
    End Sub

    Private Sub chkFlete_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFlete.CheckStateChanged
        If chkFlete.Checked = True Then
            txtCodFlete.Enabled = True
            cbFlete.Enabled = True
            Call buscaProv("order by nombre")
            cbFlete.DataSource = dtProv
            cbFlete.DisplayMember = "nombre"

        Else
            txtCodFlete.Text = ""
            txtCodFlete.Enabled = False
            cbFlete.DataSource = Nothing
            cbFlete.Enabled = False
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        limpia()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Opcion(btnGuardar, e)
    End Sub
End Class