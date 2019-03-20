Imports System.Data.SqlClient
Imports MetroFramework.Controls
Imports MetroFramework

Public Class ProdClasificadora

    Dim ID As Integer = 0
    Dim fila1 As MetroTextBox()
    Dim codProd1, msg As Integer

    Private Sub ProdClasificadora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cargo los vectores para controlar las filas de Clasificación en Clasificadora
        fila1 = New MetroTextBox() {txtpri1, txtpp1, txtrec1, txtEstand1, txtSeg1, txtInd1}

        Call buscadatos()

        'Creo un vector con todos los campos de Clasificación en Clasificadora
        Dim campos_de_texto As MetroTextBox() = New MetroTextBox() {txtAClasificar, txtpri1, txtpp1, txtrec1, txtEstand1, txtSeg1, txtInd1}

        'Recorro el vector y a cada campo lo agrego al Evento TextChanged_ClasificacionClasificadora
        For x = 0 To campos_de_texto.Count - 1
            AddHandler campos_de_texto(x).TextChanged, AddressOf TextChanged_ClasificionClasificadora
        Next

        'Cargo los combos
        CargoProducto(cbProd1)

        'Hago el lostFocus para que me bloquee todos los textBox
        cbProd1_LostFocus(sender, e)

    End Sub

    Sub ADfila1(ByVal opcion As Integer)
        '1 activa '0 desactiva
        For x = 0 To fila1.Count - 1
            If opcion = 1 Then
                fila1(x).Enabled = True
            ElseIf opcion = 0 Then
                fila1(x).Enabled = False
                fila1(x).Text = 0
            End If
        Next
    End Sub

    Sub CargoProducto(ByVal combo As ComboBox)
        Call Consulta_Producto("")

        If n <> 0 Then
            combo.DataSource = dt5
            combo.DisplayMember = "descripcion"
            combo.ValueMember = "codigo"
        End If

        combo.SelectedItem = Nothing

    End Sub

    Sub Consulta_Producto(ByVal where As String)
        conex("AliProductos")
        sql5 = "SELECT * From Alistamiento where codigo like '%" + where + "%' order by codigo"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        n = dt5.Rows.Count
    End Sub

    Private Sub cbProd1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbProd1.KeyUp
        If e.KeyCode = Keys.Delete Then
            cbProd1.Text = Nothing
        End If
    End Sub

    Private Sub cbProd1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProd1.LostFocus
        If cbProd1.Text = Nothing Then
            'desactivo fila1
            ADfila1(0)
        Else
            Consulta_Producto(cbProd1.SelectedValue)
            txtDisponible.Text = dt5.Rows(0).Item("A_Clasificar")
            'Activo fila1
            ADfila1(1)
            txtpri1.Focus()
        End If
    End Sub

    Private Sub TextChanged_ClasificionClasificadora(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Si en el textBox que estoy posicionado no queda escrito nada le pone un 0.
        If Me.ActiveControl.Text = "" Then
            Me.ActiveControl.Text = 0
        End If

        txtResto.Text = Int(txtAClasificar.Text) - (Int(txtpri1.Text) + Int(txtpp1.Text) + Int(txtrec1.Text) + Int(txtEstand1.Text) + Int(txtSeg1.Text) + Int(txtInd1.Text))

        If txtResto.Text < 0 Then
            Me.ActiveControl.Focus()
            MetroMessageBox.Show(Me, "La cantidad total clasificada es mayor a la cantidad a clasificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If String.IsNullOrEmpty(cbLinea.Text) Or String.IsNullOrEmpty(cbTurno.Text) Or String.IsNullOrEmpty(cbGrupo.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar todos los campos de la cabecera", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbTurno.Focus()
            Exit Sub
        End If

        If txtResto.Text <> 0 Then
            Me.ActiveControl.Focus()
            MetroMessageBox.Show(Me, "Aún quedan " & txtResto.Text & " placas por clasificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Completo las variables de los códigos de producto
        If String.IsNullOrEmpty(cbProd1.Text) Then
            codProd1 = 0
        Else
            codProd1 = cbProd1.SelectedValue
        End If


        If ID = 0 Then
            campos = "fecha, maquina,linea,turno,grupo,prod1,cc1,pri1,pp1,rec1,estand1,seg1,ind1,aclasif1,userid"
            variables = "'" + dtfecha.Text + "','Clasificadora','" + cbLinea.Text + "','" + cbTurno.Text + "','" + cbGrupo.Text + "', " &
            "'" + Str(codProd1) + "','" + txtAClasificar.Text + "','" + txtpri1.Text + "','" + txtpp1.Text + "','" + txtrec1.Text + "','" + txtEstand1.Text + "','" + txtSeg1.Text + "','" + txtInd1.Text + "','" + txtResto.Text + "', " &
            "'" + user + "'"

            SQL3 = "INSERT INTO ALIPRODUCCION (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()
            MetroMessageBox.Show(Me, "Registro guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            SQL3 = "UPDATE ALIPRODUCCION set fecha='" + dtfecha.Text + "', linea='" + cbLinea.Text + "',turno='" + cbTurno.Text + "',grupo='" + cbGrupo.Text + "', " &
                "prod1='" + Str(codProd1) + "',pri1='" + txtpri1.Text + "',pp1='" + txtpp1.Text + "',rec1='" + txtrec1.Text + "',estand1='" + txtEstand1.Text + "',seg1='" + txtSeg1.Text + "'," &
                "ind1='" + txtInd1.Text + "',aclasif1='" + txtResto.Text + "' " &
                "WHERE codigo=" + Str(ID) + ""

            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()
            MetroMessageBox.Show(Me, "Registro actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
        'Actualizo el datagrid
        Call buscadatos()
        'Limpio todos los campos para cargar nuevo registro
        Call limpiar()

    End Sub

    Private Sub presionar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrec1.KeyPress, txtpri1.KeyPress, txtSeg1.KeyPress, txtpp1.KeyPress, txtInd1.KeyPress, txtEstand1.KeyPress
        'Entero
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub conexion()
        conex("AliProduccion")
    End Sub

    Private Sub buscadatos()

        'TODO:   esta línea de código carga datos en la tabla 'DSAlistamiento.AliProduccion' Puede moverla o quitarla según sea necesario.
        Me.AliProduccionTableAdapter.Fill(Me.DSAlistamiento.AliProduccion, dtBuscar.Text, "Clasificadora")

    End Sub

    Private Sub dgGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGrilla.CellClick
        If dgGrilla.SelectedRows.Count = 1 Then
            line = dgGrilla.CurrentRow.Cells("codigo").Value
        Else

            MetroMessageBox.Show(Me, "Aún no ha seleccionado nada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub editar()
        Call limpiar()

        sql = "select * from ALIPRODUCCION where codigo='" + Str(line) + "'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        Dim n As Integer
        n = dt.Rows.Count
        If n > 0 Then
            ID = dt.Rows(0).Item("codigo")
            dtfecha.Text = dt.Rows(0).Item("fecha")
            cbTurno.Text = dt.Rows(0).Item("turno")
            cbLinea.Text = dt.Rows(0).Item("linea")
            cbGrupo.Text = dt.Rows(0).Item("grupo")

            cbProd1.SelectedValue = dt.Rows(0).Item("Prod1")
            txtAClasificar.Text = dt.Rows(0).Item("cc1")
            txtpri1.Text = dt.Rows(0).Item("pri1")
            txtpp1.Text = dt.Rows(0).Item("pp1")
            txtrec1.Text = dt.Rows(0).Item("rec1")
            txtEstand1.Text = dt.Rows(0).Item("estand1")
            txtSeg1.Text = dt.Rows(0).Item("seg1")
            txtInd1.Text = dt.Rows(0).Item("ind1")
            txtResto.Text = dt.Rows(0).Item("aclasif1")

        Else
            MetroMessageBox.Show(Me, "Aún no ha seleccionado nada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub dgGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGrilla.CellDoubleClick
        Call editar()
    End Sub

    Sub limpiar()

        ID = 0
        dtfecha.Text = Now
        cbProd1.Text = Nothing

        For x = 0 To fila1.Count - 1
            'Limpiar los campos de texto
            fila1(x).Text = 0
        Next

        txtResto.Text = 0
        txtAClasificar.Text = 0
        txtDisponible.Text = ""


    End Sub

    Private Sub dtBuscar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtBuscar.ValueChanged
        Call buscadatos()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call limpiar()
    End Sub

    Private Sub dgGrilla_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgGrilla.KeyUp
        If line > 0 Then
            If e.KeyCode = Keys.Delete Then
                msg = MetroMessageBox.Show(Me, "¿Desea eliminar la línea seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If msg = 1 Then
                    Call EliminaLinea()
                End If
            End If
        Else
        End If
    End Sub

    Private Sub EliminaLinea()

        conex("aliproduccion")
        'elimina la fila de la grilla
        sql4 = "Delete from AliProduccion where codigo='" + Str(line) + "'"

        Try
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()
            MetroMessageBox.Show(Me, "Registro eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
            'Actualizo el datagrid
            Call buscadatos()
            'Limpio todos los campos para cargar nuevo registro
            Call limpiar()

        Catch
            MetroMessageBox.Show(Me, "No se pudo borrar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class