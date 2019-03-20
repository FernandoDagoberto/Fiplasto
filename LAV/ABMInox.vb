Imports MetroFramework

Public Class ABMInox
    Dim inox As New CMaestroInox
    Dim ms As Integer
    Dim dtInox As DataTable
    Dim linea As String

    Private Sub ABMInox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call buscadatos()
        btnGuardar.Enabled = False
        If dt.Rows.Count <> 0 Then
            dg.Select()
        Else
            btnEditar.Enabled = False
            btnBorrar.Enabled = False
        End If
    End Sub

    Private Sub Opcion(sender As Object, e As EventArgs) Handles BtnNuevo.Click, btnSalir.Click, btnGuardar.Click, btnEditar.Click, btnBorrar.Click
        'Busco la opción por el nombre del botón
        Select Case sender.Name

            Case BtnNuevo.Name ' boton nuevo
                sen = "n"
                btncancel.Visible = True
                btnGuardar.Enabled = True
                btnEditar.Enabled = False
                btnBorrar.Enabled = False
                Call habilita()


            Case btnEditar.Name 'boton editar
                sen = "m"
                btncancel.Visible = True
                BtnNuevo.Enabled = False
                btnBorrar.Enabled = False
                btnGuardar.Enabled = True
                Call habilitamod()
                Call modifica()

            Case btnBorrar.Name ' boton borrar

                ms = MetroMessageBox.Show(Me, "Desea eliminar el inoxidable: " + Str(linea) + " ?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    Call eliminalinea()
                    btncancel.Visible = False
                End If

            Case btnGuardar.Name 'boton guardar
                Call guardanuevo()
                Call limpia()
                Call buscadatos()
                Call bloquea()
                If BtnNuevo.Enabled = False Then BtnNuevo.Enabled = True
                If btnEditar.Enabled = False Then btnEditar.Enabled = True
                If btnBorrar.Enabled = False Then btnBorrar.Enabled = True
                btnGuardar.Enabled = False
                btncancel.Visible = False
                dg.Select()

            Case btnSalir.Name ' boton salir
                Me.Close()
        End Select
    End Sub

    Private Sub modifica()
        If dg.SelectedRows.Count = 1 Then
            cblinea.Text = dg.CurrentRow.Cells("Linea").Value
            txtdesc.Text = dg.CurrentRow.Cells("Inox").Value

            If IsDBNull(dg.CurrentRow.Cells("BajaId").Value) Or dg.CurrentRow.Cells("BajaId").Value Is "" Then
                chkbaja.Checked = False
            Else
                chkbaja.Checked = True
            End If
            sen = "M"
        Else
            sen = "N"
        End If

    End Sub

    Private Sub habilita()
        gbDatos.Enabled = True
        cblinea.Focus()
    End Sub

    Private Sub dgv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.Click
        Call limpia()
        Call bloquea()
        If dg.SelectedRows.Count = 1 Then
            linea = dg.CurrentRow.Cells("Inox").Value
        End If
    End Sub

    Private Sub deshabilita()
        gbDatos.Enabled = False

    End Sub

    Private Sub habilitamod()
        gbDatos.Enabled = True
    End Sub

    Private Sub limpia()
        cblinea.Text = Nothing
        txtdesc.Clear()
        chkbaja.Checked = False
    End Sub

    Private Sub buscadatos()
        inox.Inox = txtdesc.Text
        dtInox = inox.Mostrar(inox)
        dg.DataSource = dtInox
        dg.Columns("Usuario").Visible = False
        dg.Columns("BajaFch").Visible = False
    End Sub

    Private Sub bloquea()
        gbDatos.Enabled = False
    End Sub

    Private Sub dgv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Opcion(btnEditar, e)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Call limpia()
        BtnNuevo.Enabled = True
        btnEditar.Enabled = True
        btnBorrar.Enabled = True
        btnGuardar.Enabled = False
        Call bloquea()
        btncancel.Visible = False
    End Sub

    Private Sub guardanuevo()
        btncancel.Visible = False
        inox.Linea = Trim(cblinea.Text)
        inox.Inox = txtdesc.Text
        inox.UserId = user

        conex("lavmainox")
        dt5 = inox.Mostrar(inox)
        n = dt5.Rows.Count
        If n = 1 And sen = "N" Then
            'Ya existe el registro
            MetroMessageBox.Show(Me, "El inoxidable ya existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtdesc.Focus()
            Exit Sub
        Else
            If sen = "N" Then
                If inox.Agregar(inox) Then
                    MetroMessageBox.Show(Me, "Datos insertados correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    limpia()
                    Call buscadatos()


                End If
            ElseIf sen = "M" Then
                If inox.Modificar(inox) Then
                    MetroMessageBox.Show(Me, "Datos modificados correctamente", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    limpia()
                    Call buscadatos()
                    sen = "N"
                End If
            End If

            Call bloquea()


        End If
    End Sub

    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If e.KeyCode = Keys.Delete Then
            Opcion(btnBorrar, e)
        End If
    End Sub

    Private Sub eliminalinea()
        Try
            'da de baja la fila de la grilla
            inox.Inox = linea
            If inox.Eliminar(inox) Then
                MetroMessageBox.Show(Me, "Datos eliminados correctamente", "Eliminar datos", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Call buscadatos()
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, "No se pudo dar de baja el inoxidable", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub chkbaja_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbaja.CheckStateChanged
        If chkbaja.Checked Then
            inox.BajaId = user
            inox.BajaFch = Now
        Else
            inox.BajaId = Nothing
            inox.BajaFch = Nothing

        End If
    End Sub

    Private Sub chkbaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbaja.CheckedChanged

    End Sub
End Class