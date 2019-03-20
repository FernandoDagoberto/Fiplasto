Imports MetroFramework.Controls
Imports MetroFramework

Public Class ABMProdAlis
    Dim campos_de_texto As MetroTextBox()
    Dim line, ms As Integer
    Dim producto As New abmProductos

    Private Sub ABMProdAlis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt.Reset()
        'Creo un vector con todos los campos de texto
        campos_de_texto = New MetroTextBox() {txtcod, txtDescrp, txtAncho, txtLargo, txtEspesor, txtFactor}
        Call buscadatos()

    End Sub

    Private Sub buscadatos()
        conex("AliProductos")
        sql = "SELECT codigo as Codigo,descripcion as Descripcion,ancho as Ancho,largo as Largo,espesor as Espesor,factor as Factor From AliProductos"
        producto.consulta(sql)
        dg.DataSource = dt

    End Sub

    Private Sub limpiar()
        For x = 0 To campos_de_texto.Count - 1
            'Limpiar los campos de texto
            campos_de_texto(x).Text = Nothing
        Next
    End Sub

    Private Sub habilita()
        For x = 0 To campos_de_texto.Count - 1
            'Habilitar los campos de texto
            campos_de_texto(x).Enabled = True
        Next
    End Sub

    Private Sub deshabilita()
        For x = 0 To campos_de_texto.Count - 1
            'Inhabilitar los campos de texto
            campos_de_texto(x).Enabled = False
        Next
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
                txtcod.Focus()

            Case btnEditar.Name 'boton editar
                sen = "m"
                btncancel.Visible = True
                BtnNuevo.Enabled = False
                btnBorrar.Enabled = False
                btnGuardar.Enabled = True
                Call habilita()
                Call editar()

            Case btnBorrar.Name ' boton borrar

                ms = MetroMessageBox.Show(Me, "Desea eliminar el código: " + Str(line) + " ?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    Call eliminalinea()
                    btncancel.Visible = False
                End If

            Case btnGuardar.Name 'boton guardar
                Call guardanuevo()
                Call limpiar()
                Call buscadatos()
                If BtnNuevo.Enabled = False Then BtnNuevo.Enabled = True
                If btnEditar.Enabled = False Then btnEditar.Enabled = True
                If btnBorrar.Enabled = False Then btnBorrar.Enabled = True
                btnGuardar.Enabled = False
                btncancel.Visible = False
               
            Case btnSalir.Name ' boton salir
                Me.Close()
        End Select
    End Sub

    Private Sub editar()

        Call limpiar()

        If dg.SelectedRows.Count = 1 Then
            txtcod.Text = dg.CurrentRow.Cells("Codigo").Value
            txtDescrp.Text = dg.CurrentRow.Cells("Descripcion").Value
            txtAncho.Text = dg.CurrentRow.Cells("Ancho").Value
            txtLargo.Text = dg.CurrentRow.Cells("Largo").Value
            txtEspesor.Text = dg.CurrentRow.Cells("Espesor").Value
            txtFactor.Text = dg.CurrentRow.Cells("Factor").Value

            'Bloqueo el campo código
            txtcod.Enabled = False
        Else
        End If




        'sql = "select * from AliProductos where codigo='" + Trim(Str(line)) + "'"
        'producto.consulta(sql)
        'Dim n As Integer
        'n = dt.Rows.Count
        'If n > 0 Then
        '    txtcod.Text = dt.Rows(0).Item("codigo")
        '    txtDescrp.Text = dt.Rows(0).Item("descripcion")
        '    txtAncho.Text = dt.Rows(0).Item("ancho")
        '    txtLargo.Text = dt.Rows(0).Item("largo")
        '    txtEspesor.Text = dt.Rows(0).Item("espesor")
        '    txtFactor.Text = dt.Rows(0).Item("factor")
        '    'Bloqueo el campo código
        '    txtcod.Enabled = False


        'Else

        '    MetroMessageBox.Show(Me, "Aún no ha seleccionado nada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

    End Sub

    Private Sub eliminalinea()
        'elimina la fila de la grilla

        If Str(line) <> "" Then
            sql4 = "delete from AliProductos where codigo='" + Trim(Str(line)) + "' "
            'Eliminar linea
            producto.operaciones(dg, sql4)

            Call buscadatos()
            If dt.Rows.Count <> 0 Then
                dg.Select()
            Else
                btnEditar.Enabled = False
                btnBorrar.Enabled = False
            End If
        Else
        End If

    End Sub

    Private Sub guardanuevo()
        btncancel.Visible = False
        conex("aliProductos")

        'Recorro los campos de texto para comprobar que todos estén completos.
        For x = 0 To campos_de_texto.Count - 1
            If String.IsNullOrEmpty(campos_de_texto(x).Text) Then
                MetroMessageBox.Show(Me, "Favor de completar campo: '" + campos_de_texto(x).Tag.ToString + "'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                campos_de_texto(x).Focus()
                Exit Sub
            End If
        Next

        If n = 0 Or sen <> "n" Then
            If sen = "n" Then

                '/// Controla que no exista el producto
                sql = "Select * from AliProductos where codigo='" + txtcod.Text + "'"
                producto.consulta(sql)
                If dt.Rows.Count <> 0 Then
                    MetroMessageBox.Show(Me, "Este código ya existe ", MessageBoxIcon.Error)
                    Exit Sub
                End If

                campos = "codigo,descripcion,ancho,largo,espesor,factor"
                variables = "'" + Trim(txtcod.Text) + "','" + Trim(txtDescrp.Text) + "','" + txtAncho.Text + "','" + txtLargo.Text + "','" + txtEspesor.Text + "','" + txtFactor.Text + "'"
                SQL3 = "INSERT INTO AliProductos (" + campos + ") VALUES (" + variables + ")"
                producto.operaciones(dg, SQL3)

            Else
                sql2 = "update aliProductos set descripcion= '" + Trim(txtDescrp.Text) + "', ancho='" + txtAncho.Text + "', largo='" + txtLargo.Text + "', espesor='" + txtEspesor.Text + "',factor='" + txtFactor.Text + "' where codigo='" + Trim(txtcod.Text) + "' "
                producto.operaciones(dg, sql2)
            End If

            Call deshabilita()
        Else
            MetroMessageBox.Show(Me, "Ese código ya existe", MessageBoxIcon.Error)
            txtcod.Focus()
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Call limpiar()
        BtnNuevo.Enabled = True
        btnEditar.Enabled = True
        btnBorrar.Enabled = True
        btnGuardar.Enabled = False
        Call deshabilita()
        btncancel.Visible = False
    End Sub

    Private Sub dg_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellClick
        If dg.SelectedRows.Count = 1 Then
            line = dg.CurrentRow.Cells("Codigo").Value
        End If
    End Sub

    Private Sub dg_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellDoubleClick
        'Presiono por código el botón editar. Entonces el código se dirige a ToolStrip1_ItemClicked
        Opcion(btnEditar, e)

    End Sub

    Private Sub txtLargo_Validated(sender As Object, e As EventArgs) Handles txtLargo.Validated
        txtFactor.Text = Math.Round(CDbl(txtLargo.Text * txtAncho.Text), 3)

    End Sub

    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If e.KeyCode = Keys.Delete Then
            Opcion(btnBorrar, e)
        End If
    End Sub
End Class