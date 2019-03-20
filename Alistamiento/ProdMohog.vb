Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework.Controls
Imports MetroFramework

Public Class ProdMohog

    Dim ID As Integer = 0
    Dim fila1, fila2, fila3 As MetroTextBox()
    Dim codProd1, codProd2, codProd3, msg As Integer


    Private Sub ProdMohog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cargo los vectores para controlar las filas de Clasificación Sierra
        fila1 = New MetroTextBox() {txtpri1, txtpp1, txtrec1, txtEstand1, txtSeg1, txtInd1, txtcc1}
        fila2 = New MetroTextBox() {txtPri2, txtPP2, txtRec2, txtEstand2, txtSeg2, txtInd2, txtcc2}
        fila3 = New MetroTextBox() {txtPri3, txtPP3, txtRec3, txtEstand3, txtSeg3, txtInd3, txtcc3}

        Call buscadatos()
        ' dtGrilla.DataSource = dt1

        'Creo un vector con todos los campos de Clasificación Sierra
        Dim campos_de_texto As MetroTextBox() = New MetroTextBox() {txtcc1, txtpri1, txtpp1, txtrec1, txtEstand1, txtSeg1, txtInd1, txtcc2, txtPri2, txtPP2, txtRec2, txtEstand2, txtSeg2, txtInd2, txtcc3, txtPri3, txtPP3, txtRec3, txtEstand3, txtSeg3, txtInd3}

        'Recorro el vector y a cada campo lo agrego al Evento TextChanged_ClasificacionSierra
        For x = 0 To campos_de_texto.Count - 1
            AddHandler campos_de_texto(x).TextChanged, AddressOf TextChanged_ClasificionSierra
        Next

        'Cargo los combos
        CargoProducto(cbProd1)
        CargoProducto(cbProd2)
        CargoProducto(cbProd3)

        'Lleno combo Pies
        llenacb("AliPies")
        cbpie.DataSource = dt7
        cbpie.DisplayMember = "pies"


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

    Sub ADfila2(ByVal opcion As Integer)
        '1 activa '0 desactiva


        For x = 0 To fila2.Count - 1
            If opcion = 1 Then
                fila2(x).Enabled = True
            ElseIf opcion = 0 Then
                fila2(x).Enabled = False
                fila2(x).Text = 0
            End If
        Next
    End Sub

    Sub ADfila3(ByVal opcion As Integer)
        '1 activa '0 desactiva

        For x = 0 To fila3.Count - 1
            If opcion = 1 Then
                fila3(x).Enabled = True
            ElseIf opcion = 0 Then
                fila3(x).Enabled = False
                fila3(x).Text = 0
            End If
        Next
    End Sub

    Sub CargoProducto(ByVal combo As ComboBox)
        conex("AliProductos")
        sql5 = "SELECT  * From AliProductos order by descripcion"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        n = dt5.Rows.Count

        If n <> 0 Then
            combo.DataSource = dt5
            combo.DisplayMember = "descripcion"
            combo.ValueMember = "codigo"
        Else

        End If

        combo.SelectedItem = Nothing

    End Sub

    Private Sub cbProd1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbProd1.KeyUp
        If e.KeyCode = Keys.Delete Then
            cbProd1.DataSource = Nothing
        End If
    End Sub

    Private Sub cbProd1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProd1.LostFocus
        If cbProd1.Text = Nothing Then
            'desactivo fila1
            ADfila1(0)
            ADfila2(0)
            ADfila3(0)
        Else
            'Activo fila1
            ADfila1(1)
            txtcc1.Focus()
        End If
    End Sub

    Private Sub cbProd2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProd2.Click
        If txtcc1.Text <> 0 Then
            cbProd2.Enabled = True
        Else
            cbProd2.Enabled = False
            cbProd3.Enabled = False
        End If

    End Sub

    Private Sub cbProd2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbProd2.KeyUp
        If e.KeyCode = Keys.Delete Then
            cbProd2.SelectedItem = Nothing
        End If
    End Sub


    Private Sub cbProd2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProd2.LostFocus
        If cbProd2.Text = Nothing Then
            'desactivo fila2
            ADfila2(0)
            ADfila3(0)
        Else
            'Activo fila2
            ADfila2(1)
            txtcc2.Focus()
        End If
    End Sub

    Private Sub cbProd3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProd3.Click
        If txtcc2.Text <> 0 Then
            cbProd3.Enabled = True
        Else
            cbProd3.Enabled = False
        End If
    End Sub

    Private Sub cbProd3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbProd3.KeyUp
        If e.KeyCode = Keys.Delete Then
            cbProd3.SelectedItem = Nothing
        End If
    End Sub

    Private Sub cbProd3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProd3.LostFocus
        If cbProd3.Text = Nothing Then
            'desactivo fila3
            ADfila3(0)
        Else
            'Activo fila3
            ADfila3(1)
            txtcc3.Focus()
        End If
    End Sub


    Private Sub TextChanged_ClasificionSierra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Si en el textBox que estoy posicionado no queda escrito nada le pone un 0.
        If Me.ActiveControl.Text = "" Then
            Me.ActiveControl.Text = 0
        End If


        'Si es 0 el valor de Cantidad Cortada del producto1 no habilita para cargar el producto3
        If txtcc1.Text = 0 Then
            cbProd2.SelectedItem = Nothing
            cbProd2.Enabled = False
        Else
            cbProd2.Enabled = True

        End If

        'Si es 0 el valor de Cantidad Cortada del producto2 no habilita para cargar el producto3
        If txtcc2.Text = 0 Then
            cbProd3.SelectedItem = Nothing
            cbProd3.Enabled = False
        Else
            cbProd3.Enabled = True
        End If


        txtCla1.Text = txtcc1.Text - txtpri1.Text - txtpp1.Text - txtrec1.Text - txtEstand1.Text - txtSeg1.Text - txtInd1.Text
        txtCla2.Text = txtcc2.Text - txtPri2.Text - txtPP2.Text - txtRec2.Text - txtEstand2.Text - txtSeg2.Text - txtInd2.Text
        txtCla3.Text = txtcc3.Text - txtPri3.Text - txtPP3.Text - txtRec3.Text - txtEstand3.Text - txtSeg3.Text - txtInd3.Text

        If txtCla1.Text < 0 Then
            Me.ActiveControl.Focus()
            MetroMessageBox.Show(Me, "La cantidad total clasificada es mayor a la cantidad cortada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        If txtCla2.Text < 0 Then
            Me.ActiveControl.Focus()
            MetroMessageBox.Show(Me, "La cantidad total clasificada es mayor a la cantidad cortada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
        If txtCla3.Text < 0 Then
            Me.ActiveControl.Focus()
            Me.SelectNextControl(Me.ActiveControl, False, True, True, True)

        End If



    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If String.IsNullOrEmpty(cbpie.Text) Or String.IsNullOrEmpty(txtPlacas.Text) Or String.IsNullOrEmpty(cbLinea.Text) Or String.IsNullOrEmpty(cbTurno.Text) Or String.IsNullOrEmpty(cbGrupo.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar todos los turnos de la cabecera", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbTurno.Focus()
            Exit Sub
        End If

        'Completo las variables de los códigos de producto
        If String.IsNullOrEmpty(cbProd1.Text) Then
            codProd1 = 0
        Else
            codProd1 = cbProd1.SelectedValue
        End If

        If String.IsNullOrEmpty(cbProd2.Text) Then
            codProd2 = 0
        Else
            codProd2 = cbProd2.SelectedValue
        End If

        If String.IsNullOrEmpty(cbProd3.Text) Then
            codProd3 = 0
        Else
            codProd3 = cbProd3.SelectedValue
        End If


        'Controlo que cada producto en caso de ser seleccionado tenga completo el campo Cantidad Cortada
        If codProd1 <> 0 And txtcc1.Text > 0 Then
        Else
            MetroMessageBox.Show(Me, "Favor de ingresar la cantidad cortada del primer producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcc1.Focus()
            Exit Sub
        End If


        If (codProd2 <> 0 And txtcc2.Text > 0) Or (codProd2 = 0 And txtcc2.Text = 0) Then
        Else
            MetroMessageBox.Show(Me, "Favor de ingresar la cantidad cortada del segundo producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcc2.Focus()
            Exit Sub
        End If


        If (codProd3 <> 0 And txtcc3.Text = 0) Or (codProd3 = 0 And txtcc3.Text = 0) Then
        Else
            MetroMessageBox.Show(Me, "Favor de ingresar la cantidad cortada del tercer producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcc3.Focus()
            Exit Sub
        End If

        If ID = 0 Then

            'VER EL ERROR QUE NO PUEDO GUARDAR SI ELIJO UNO O DOS MATERIALES

            campos = "fecha, maquina,linea,turno,grupo,pies,placas,prod1,cc1,pri1,pp1,rec1,estand1,seg1,ind1,aclasif1,prod2,cc2,pri2,pp2,rec2,estand2,seg2,ind2,aclasif2,prod3,cc3,pri3,pp3,rec3,estand3,seg3,ind3,aclasif3,userid"
            variables = "'" + dtfecha.Text + "','Sierra Mohog','" + cbLinea.Text + "','" + cbTurno.Text + "','" + cbGrupo.Text + "','" + cbpie.Text + "', " &
            "'" + txtPlacas.Text + "','" + Str(codProd1) + "','" + txtcc1.Text + "','" + txtpri1.Text + "','" + txtpp1.Text + "','" + txtrec1.Text + "','" + txtEstand1.Text + "','" + txtSeg1.Text + "','" + txtInd1.Text + "','" + txtCla1.Text + "', " &
            "'" + Str(codProd2) + "','" + txtcc2.Text + "','" + txtPri2.Text + "','" + txtPP2.Text + "','" + txtRec2.Text + "','" + txtEstand2.Text + "','" + txtSeg2.Text + "','" + txtInd2.Text + "','" + txtCla2.Text + "', " &
            "'" + Str(codProd3) + " ','" + txtcc3.Text + "','" + txtPri3.Text + "','" + txtPP3.Text + "','" + txtRec3.Text + "','" + txtEstand3.Text + "','" + txtSeg3.Text + "','" + txtInd3.Text + "','" + txtCla3.Text + "','" + user + "'"



            SQL3 = "INSERT INTO ALIPRODUCCION (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()
            MetroMessageBox.Show(Me, "Registro guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else

            SQL3 = "UPDATE ALIPRODUCCION set fecha='" + dtfecha.Text + "', linea='" + cbLinea.Text + "',turno='" + cbTurno.Text + "',grupo='" + cbGrupo.Text + "', " &
                "pies='" + cbpie.Text + "',placas='" + Str(txtPlacas.Text) + "',prod1='" + Str(codProd1) + "',cc1='" + txtcc1.Text + "', " &
                "pri1='" + txtpri1.Text + "',pp1='" + txtpp1.Text + "',rec1='" + txtrec1.Text + "',estand1='" + txtEstand1.Text + "',seg1='" + txtSeg1.Text + "'," &
                "ind1='" + txtInd1.Text + "',aclasif1='" + txtCla1.Text + "',prod2='" + Str(codProd2) + "',cc2='" + txtcc2.Text + "',pri2='" + txtPri2.Text + "'," &
                "pp2='" + txtPP2.Text + "',rec2='" + txtRec2.Text + "',estand2='" + txtEstand2.Text + "',seg2='" + txtSeg2.Text + "',ind2='" + txtInd2.Text + "',aclasif2='" + txtCla2.Text + "'," &
                "prod3='" + Str(codProd3) + "',cc3='" + txtcc3.Text + "',pri3='" + txtPri3.Text + "',pp3='" + txtPP3.Text + "',rec3='" + txtRec3.Text + "',estand3='" + txtEstand3.Text + "'," &
                "seg3='" + txtSeg3.Text + "',ind3='" + txtInd3.Text + "',aclasif3='" + txtCla3.Text + "' " &
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

    Private Sub presionar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrec1.KeyPress, txtpri1.KeyPress, txtSeg3.KeyPress, txtSeg2.KeyPress, txtSeg1.KeyPress, txtRec3.KeyPress, txtRec2.KeyPress, txtPri3.KeyPress, txtPri2.KeyPress, txtPP3.KeyPress, txtPP2.KeyPress, txtpp1.KeyPress, txtInd3.KeyPress, txtInd2.KeyPress, txtInd1.KeyPress, txtcc3.KeyPress, txtcc2.KeyPress, txtcc1.KeyPress, txtEstand3.KeyPress, txtEstand2.KeyPress, txtEstand1.KeyPress
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
        'TODO: esta línea de código carga datos en la tabla 'DSAlistamiento.AliProduccion' Puede moverla o quitarla según sea necesario.
        Me.AliProduccionTableAdapter.Fill(Me.DSAlistamiento.AliProduccion, dtBuscar.Text, "Sierra Mohog")
    End Sub

    Private Sub dtGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGrilla.CellClick
        If dgGrilla.SelectedRows.Count = 1 Then

            line = dgGrilla.CurrentRow.Cells(0).Value

        Else

            MetroMessageBox.Show(Me, "Aún no ha seleccionado nada")
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
            cbpie.Text = dt.Rows(0).Item("pies")
            txtPlacas.Text = dt.Rows(0).Item("placas")

            cbProd1.SelectedValue = dt.Rows(0).Item("Prod1")
            txtcc1.Text = dt.Rows(0).Item("cc1")
            txtpri1.Text = dt.Rows(0).Item("pri1")
            txtpp1.Text = dt.Rows(0).Item("pp1")
            txtrec1.Text = dt.Rows(0).Item("rec1")
            txtEstand1.Text = dt.Rows(0).Item("estand1")
            txtSeg1.Text = dt.Rows(0).Item("seg1")
            txtInd1.Text = dt.Rows(0).Item("ind1")
            txtCla1.Text = dt.Rows(0).Item("aclasif1")

            If dt.Rows(0).Item("cc2") > 0 Then
                cbProd2.SelectedValue = dt.Rows(0).Item("prod2")
                txtcc2.Text = dt.Rows(0).Item("cc2")
                txtPri2.Text = dt.Rows(0).Item("pri2")
                txtPP2.Text = dt.Rows(0).Item("pp2")
                txtRec2.Text = dt.Rows(0).Item("rec2")
                txtEstand2.Text = dt.Rows(0).Item("estand2")
                txtSeg2.Text = dt.Rows(0).Item("seg2")
                txtInd2.Text = dt.Rows(0).Item("ind2")
                txtCla2.Text = dt.Rows(0).Item("aclasif2")
            End If


            If dt.Rows(0).Item("cc3") > 0 Then
                cbProd3.SelectedValue = dt.Rows(0).Item("prod3")
                txtcc3.Text = dt.Rows(0).Item("cc3")
                txtPri3.Text = dt.Rows(0).Item("pri3")
                txtPP3.Text = dt.Rows(0).Item("pp3")
                txtRec3.Text = dt.Rows(0).Item("rec3")
                txtEstand3.Text = dt.Rows(0).Item("estand3")
                txtSeg3.Text = dt.Rows(0).Item("seg3")
                txtInd3.Text = dt.Rows(0).Item("ind3")
                txtCla3.Text = dt.Rows(0).Item("aclasif3")
            End If

        Else

            MetroMessageBox.Show(Me, "Aún no ha seleccionado nada")
        End If
    End Sub

    Private Sub dtGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGrilla.CellDoubleClick
        Call editar()
    End Sub

    Sub limpiar()

        ID = 0
        dtfecha.Text = Now
        txtPlacas.Text = Nothing

        For x = 0 To fila1.Count - 1
            'Limpiar los campos de texto
            fila1(x).Text = 0
            fila2(x).Text = 0
            fila3(x).Text = 0
        Next

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
            MetroMessageBox.Show(Me, "Registro eliminado", MessageBoxIcon.Question)
            'Actualizo el datagrid
            Call buscadatos()
            'Limpio todos los campos para cargar nuevo registro
            Call limpiar()

        Catch
            MetroMessageBox.Show(Me, "No se pudo borrar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class