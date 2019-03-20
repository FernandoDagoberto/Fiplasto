Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework

Public Class Proveedores
    Inherits MetroFramework.Forms.MetroForm
    Dim sql, sql1, sql2, sql3, sql4, sql5 As String
    Dim da, da1, da5 As New SqlDataAdapter
    Dim cmd, cmd2, cmd3, cmd4, cmd5 As SqlCommand
    Dim ms As Integer

    Private Sub chkProvMad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProvMad.CheckedChanged

        If chkProvMad.Checked = True Then
            'Traer datos de la tabla Clientes de Galil para completar el combo Proveedor de Madera
            Try
                conexA("camion")
                sql = "SELECT * From CLIENTES order by nombre"
                daA = New OleDbDataAdapter(sql, cnnA)
                dt = New DataTable
                daA.Fill(dt)
                n = dt.Rows.Count

                If n > 0 Then
                    cbProvMad.DataSource = dt
                    cbProvMad.DisplayMember = "nombre"
                    cbProvMad.ValueMember = "codigo"
                End If


            Catch
                MetroMessageBox.Show(Me, "No se pudo conectar con la base de Portería. Reintente nuevamente", "", MessageBoxButtons.OK)
                Exit Sub
            End Try

        Else
            cbProvMad.DataSource = Nothing
            lblProvMad.Text = 0
        End If

    End Sub

    Private Sub chkFlete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFlete.CheckedChanged
        If chkFlete.Checked = True Then

            'Traer datos de la tabla Transportes de Galil para completar el combo Flete
            Try
                sql1 = "select * from TRANSPORTES order by nombre"
                daA = New OleDbDataAdapter(sql1, cnnA)
                dt = New DataTable
                daA.Fill(dt)
                n = dt.Rows.Count
                If n > 0 Then
                    cbFlete.DataSource = dt
                    cbFlete.DisplayMember = "nombre"
                    cbFlete.ValueMember = "codigo"
                End If
            Catch
                MetroMessageBox.Show(Me, "No se pudo conectar con la base de Portería. Reintente nuevamente", "", MessageBoxButtons.OK)
                Exit Sub
            End Try

        Else
            cbFlete.DataSource = Nothing
            lblFlete.Text = 0
        End If
    End Sub

    Private Sub cbProvMad_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProvMad.SelectionChangeCommitted
        lblProvMad.Text = cbProvMad.SelectedValue
    End Sub

    Private Sub cbFlete_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFlete.SelectionChangeCommitted
        lblFlete.Text = cbFlete.SelectedValue
    End Sub

    Private Sub Opcion(sender As Object, e As EventArgs) Handles BtnNuevo.Click, btnSalir.Click, btnGuardar.Click, btnEditar.Click
        'Busco la opción por el nombre del botón
        Select Case sender.Name

            Case BtnNuevo.Name ' boton nuevo
                sen = "n"
                btncancel.Visible = True
                btnGuardar.Enabled = True
                btnEditar.Enabled = False
                Call Habilita()
                'Buscar el último número de proveedor
                Call buscamax()
                If IsDBNull(dt1.Rows(0).Item("ult")) Then
                    ultnro = "1"
                Else
                    ultnro = dt1.Rows(0).Item("ult") + 1
                End If
                txtCod.Text = ultnro

            Case btnEditar.Name 'boton editar
                sen = "m"
                btncancel.Visible = True
                BtnNuevo.Enabled = False
                btnGuardar.Enabled = True
                Call Habilita()
                Call modifica()

            Case btnGuardar.Name 'boton guardar
                Call guardaNuevo()
                Call limpia()
                Call buscaDatos()
                If BtnNuevo.Enabled = False Then BtnNuevo.Enabled = True
                If btnEditar.Enabled = False Then btnEditar.Enabled = True
                btnGuardar.Enabled = False
                btncancel.Visible = False
                dg.Select()

            Case btnSalir.Name ' boton salir
                Me.Close()
        End Select
    End Sub

    Private Sub Habilita()
        pnlDatos.Enabled = True
    End Sub

    Private Sub limpia()
        txtCod.Text = Nothing
        txtNombre.Text = Nothing
        chkProvMad.Checked = False
        chkFlete.Checked = False
        pnlDatos.Enabled = False
    End Sub

    Private Sub buscaDatos()
        conex("proveedores")
        sql2 = "select * from PROVEEDORES where nombre like '%" + txtBuscar.Text + "%' order by codigo"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)

        dg.DataSource = dt2


    End Sub

    Private Sub buscamax()
        conex("proveedores")
        sql1 = "SELECT max(codigo)as ult From proveedores;"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

    End Sub

    Private Sub modifica()
        If dg.SelectedRows.Count = 1 Then
            pnlDatos.Enabled = True
            txtCod.Text = dg.CurrentRow.Cells("codigo").Value
            txtNombre.Text = dg.CurrentRow.Cells("nombre").Value

            If dg.CurrentRow.Cells("codProvMad").Value = 0 Then
                chkProvMad.Checked = False
            Else
                chkProvMad.Checked = True
                cbProvMad.Text = Trim(dg.CurrentRow.Cells("descripProv").Value)
            End If

            If dg.CurrentRow.Cells("codFlete").Value = 0 Then
                chkFlete.Checked = False
            Else
                chkFlete.Checked = True
                cbFlete.Text = Trim(dg.CurrentRow.Cells("descripFlete").Value)
            End If
            txtNombre.Focus()
        Else
            pnlDatos.Enabled = False
        End If

    End Sub

    Private Sub guardaNuevo()
        If txtNombre.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de completar el campo Descripción", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Focus()
            Exit Sub

        Else
            btncancel.Visible = False
            conex("proveedores")
            sql5 = "SELECT * From Proveedores where nombre='" + Trim(txtNombre.Text) + "';"
            da5 = New SqlDataAdapter(sql5, cnn)
            dt5 = New DataTable
            da5.Fill(dt5)
            n = dt5.Rows.Count
            If n = 0 Or sen <> "n" Then
                If sen = "n" Then

                    '/// Controla que ya no exista la pila

                    campos = "codigo,nombre,codProvMad,descripProv,codFlete,descripFlete"
                    variables = "" + (txtCod.Text) + ",'" + Trim(txtNombre.Text) + "'," + Str(lblProvMad.Text) + ",'" + Trim(cbProvMad.Text) + "'," + Str(lblFlete.Text) + ",'" + Trim(cbFlete.Text) + "'"
                    sql3 = "INSERT INTO PROVEEDORES (" + campos + ") VALUES (" + variables + ")"
                    cmd3 = New SqlCommand(sql3, cnn)
                    cmd3.Connection.Open()
                    cmd3.ExecuteNonQuery()
                    cmd3.Connection.Close()


                Else
                    sql2 = "update Proveedores set nombre='" + Trim(txtNombre.Text) + "', codProvMad='" + Str(cbProvMad.SelectedValue) + "',descripProv='" + cbProvMad.Text + "',codFlete='" + Str(cbFlete.SelectedValue) + "',descripFlete='" + cbFlete.Text + "' where codigo='" + Trim(txtCod.Text) + "' "
                    cmd2 = New SqlCommand(sql2, cnn)
                    cmd2.Connection.Open()
                    cmd2.ExecuteNonQuery()
                    cmd2.Connection.Close()
                End If
                Application.DoEvents()
                pnlDatos.Enabled = False


            Else
                MetroMessageBox.Show(Me, "Ese nombre ya existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCod.Focus()
            End If
        End If

    End Sub

    Private Sub Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call buscaDatos()
    End Sub


    Private Sub cbProvMad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Call buscaDatos()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call limpia()
        BtnNuevo.Enabled = True
        btnEditar.Enabled = True
        btnGuardar.Enabled = False
        pnlDatos.Enabled = False
        btncancel.Visible = False
    End Sub

    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click
        Call limpia()
        If dg.SelectedRows.Count = 1 Then
            line = dg.CurrentRow.Cells("codigo").Value
        End If
    End Sub

    Private Sub dg_DoubleClick(sender As Object, e As EventArgs) Handles dg.DoubleClick
        Opcion(btnEditar, e)
    End Sub

End Class