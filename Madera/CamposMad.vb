Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework

Public Class CamposMad
    Inherits MetroFramework.Forms.MetroForm
    Dim sql, sql1, sql2, sql3, sql4, sql5 As String
    Dim da, da1, da5 As New SqlDataAdapter
    Dim cmd, cmd2, cmd3, cmd4, cmd5 As SqlCommand
    Dim ms As Integer
    Dim propio As String

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
        chkPropio.Checked = False
        pnlDatos.Enabled = False
    End Sub

    Private Sub buscaDatos()
        conex("campos")
        sql2 = "select * from CAMPOS where descripcion like '%" + txtBuscar.Text + "%' order by codigo"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)

        dg.DataSource = dt2

    End Sub

    Private Sub buscamax()
        conex("campos")
        sql1 = "SELECT max(codigo)as ult From campos;"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

    End Sub

    Private Sub modifica()
        If dg.SelectedRows.Count = 1 Then
            pnlDatos.Enabled = True
            txtCod.Text = dg.CurrentRow.Cells("codigo").Value
            txtNombre.Text = dg.CurrentRow.Cells("descripcion").Value
            If dg.CurrentRow.Cells("propio").Value = "S" Then
                chkPropio.Checked = True
            Else
                chkPropio.Checked = False
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

            If chkPropio.Checked = True Then
                propio = "S"
            Else
                propio = "N"
            End If


            btncancel.Visible = False
            conex("campos")
            sql5 = "SELECT * From CAMPOS where DESCRIPCION='" + Trim(txtNombre.Text) + "';"
            da5 = New SqlDataAdapter(sql5, cnn)
            dt5 = New DataTable
            da5.Fill(dt5)
            n = dt5.Rows.Count
            If n = 0 Or sen <> "n" Then
                If sen = "n" Then

                    '/// Controla que ya no exista la pila

                    campos = "descripcion,propio"
                    variables = "'" + Trim(txtNombre.Text) + "','" + propio + "'"
                    sql3 = "INSERT INTO CAMPOS(" + campos + ") VALUES (" + variables + ")"
                    cmd3 = New SqlCommand(sql3, cnn)
                    cmd3.Connection.Open()
                    cmd3.ExecuteNonQuery()
                    cmd3.Connection.Close()


                Else
                    sql2 = "update CAMPOS set DESCRIPCION='" + Trim(txtNombre.Text) + "',PROPIO='" + propio + "' where codigo='" + Trim(txtCod.Text) + "' "
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