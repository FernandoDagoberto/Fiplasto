Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework.Controls
Imports MetroFramework

Public Class MenuConf



    Dim campos_de_texto As MetroTextBox()
    Dim line, ms As String
    Dim producto As New abmProductos


    Private Sub MenuConf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.MENU' Puede moverla o quitarla según sea necesario.
        Me.MENUTableAdapter.Fill(Me.FIPLANEWDataSetTotal.MENU)


        'Creo un vector con todos los campos de texto
        campos_de_texto = New MetroTextBox() {txtcod, txtDescrp}

        Call buscadatos()


    End Sub


    Private Sub buscadatos()
        conex("menu")
        sql = "SELECT * From Menu"
        producto.consulta(sql)
        DGVMenu.DataSource = dt


    End Sub

    Private Sub limpiar()
        For x = 0 To campos_de_texto.Count - 1
            'Limpiar los campos de texto
            campos_de_texto(x).Text = ""
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




    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Select Case ToolStrip1.Items.IndexOf(e.ClickedItem)
            Case 0 ' boton nuevo
                sen = "n"
                btncancel.Visible = True
                ToolStrip1.Items(0).Enabled = False 'Nuevo
                ToolStrip1.Items(1).Enabled = False 'Editar
                ToolStrip1.Items(2).Enabled = False 'Borrar
                ToolStrip1.Items(3).Enabled = True  'Guardar
                Call habilita()


            Case 1 'boton editar
                sen = "m"
                btncancel.Visible = True
                ToolStrip1.Items(0).Enabled = False 'Nuevo
                ToolStrip1.Items(1).Enabled = False 'Editar
                ToolStrip1.Items(2).Enabled = False 'Borrar
                ToolStrip1.Items(3).Enabled = True  'Guardar
                Call habilita()
                Call editar()
                Call buscadatos()

            Case 2 ' boton borrar
                ms = MetroMessageBox.Show(Me, "Desea eliminar el código: " + line + " ?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    Call eliminalinea()
                    btncancel.Visible = False
                End If

            Case 3 'boton guardar
                Call guardanuevo()
                Call limpiar()

                Call buscadatos()
                DGVMenu.DataSource = dt
                If ToolStrip1.Items(0).Enabled = False Then ToolStrip1.Items(0).Enabled = True
                If ToolStrip1.Items(1).Enabled = False Then ToolStrip1.Items(1).Enabled = True
                If ToolStrip1.Items(2).Enabled = False Then ToolStrip1.Items(2).Enabled = True
                ToolStrip1.Items(3).Enabled = False
                btncancel.Visible = False

            Case 4 ' boton salir
                Me.Close()
        End Select



    End Sub


    Private Sub editar()

        Call limpiar()

        sql = "select * from Menu where menu_cod='" + Trim(line) + "'"
        producto.consulta(sql)
        Dim n As Integer
        n = dt.Rows.Count
        If n > 0 Then
            txtcod.Text = dt.Rows(0).Item("menu_cod")
            txtDescrp.Text = dt.Rows(0).Item("menu_desc")


            'Bloqueo el campo código
            txtcod.Enabled = False

        Else

            MessageBox.Show("Aún no ha seleccionado nada")
        End If

    End Sub


    Private Sub eliminalinea()
        'elimina la fila de la grilla

        If line <> "" Then
            sql4 = "delete from Menu where menu_cod='" + Trim(line) + "' "
            'Eliminar linea
            producto.operaciones(DGVMenu, sql4)

            Call buscadatos()
            If dt.Rows.Count <> 0 Then

            Else
                ToolStrip1.Items(0).Enabled = False 'Nuevo
                ToolStrip1.Items(1).Enabled = False 'Editar
            End If
        Else
        End If

    End Sub


    Private Sub guardanuevo()
        btncancel.Visible = False
        conex("Menu")

        'Recorro los campos de texto para comprobar que todos estén completos.
        For x = 0 To campos_de_texto.Count - 1
            If campos_de_texto(x).Text = "" Then
                MetroMessageBox.Show(Me, "Favor de completar campo: '" + campos_de_texto(x).Tag.ToString + "'")
                campos_de_texto(x).Focus()
                Exit Sub
            End If
        Next



        If sen = "n" Then

            '/// Controla que no exista el producto
            sql = "Select * from Menu where menu_cod='" + txtcod.Text + "'"
            producto.consulta(sql)
            If dt.Rows.Count <> 0 Then
                MetroMessageBox.Show(Me, "Este código ya existe ", MsgBoxStyle.Critical)
                Exit Sub
            End If

            campos = "menu_cod,menu_desc"
            variables = "'" + Trim(txtcod.Text) + "','" + Trim(txtDescrp.Text) + "'"
            SQL3 = "INSERT INTO Menu (" + campos + ") VALUES (" + variables + ")"
            producto.operaciones(DGVMenu, SQL3)

        Else
            sql2 = "update Menu set menu_desc= '" + Trim(txtDescrp.Text) + "' where menu_cod='" + Trim(txtcod.Text) + "' "
            producto.operaciones(DGVMenu, sql2)
        End If

        Call deshabilita()

    End Sub




    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Call limpiar()
        ToolStrip1.Items(0).Enabled = True  'Nuevo
        ToolStrip1.Items(1).Enabled = True  'Editar
        ToolStrip1.Items(2).Enabled = True  'Borrar
        ToolStrip1.Items(3).Enabled = False 'Guardar
        Call deshabilita()
        btncancel.Visible = False
    End Sub



    Private Sub DGVMenu_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVMenu.CellClick
        If DGVMenu.SelectedRows.Count = 1 Then

            line = DGVMenu.CurrentRow.Cells(0).Value

        Else

            MessageBox.Show("Aún no ha seleccionado nada")
        End If
    End Sub

    Private Sub DGVMenu_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVMenu.CellDoubleClick
        'Presiono por código el botón editar. Entonces el código se dirige a ToolStrip1_ItemClicked
        ToolStrip1.Items(1).PerformClick()

    End Sub

    Private Sub DGVMenu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVMenu.KeyUp
        line = DGVMenu.CurrentRow.Cells(0).Value
        If line <> "" Then
            If e.KeyCode = Keys.Delete Then
                msg = MetroMessageBox.Show(Me, "Desea eliminar el código: " + line + " ?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If msg = 1 Then
                    Call eliminalinea()
                End If
            End If
        Else
        End If
    End Sub


End Class