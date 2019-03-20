Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class AjusteBio
    Inherits MetroFramework.Forms.MetroForm

    Dim stockde As Double
    Dim stocka As Double
    Dim cantidad As Double


    Private Sub AjusteBio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call buscadatos()
        Call llenaD()
    End Sub

    Sub buscadatos()
        'Buscar pilas con stock
        sql = "SELECT * From BioPila inner join BioStock on ltrim(id)=ltrim(pila) where stock>0 " 'and pila_id<>90
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

    End Sub

    Sub llenaD()
        'llena combo Desde

        If n = 0 Then
            'Response.Write("<p>No hay registros.</p>")
        Else
            cbde.DataSource = dt
            cbde.DisplayMember = "id"
            cbde.SelectedValue = "id"
        End If
    End Sub


    Sub llenaA()
        'llena combo destino de acuerdo a la pila que se seleccionó en desde
        sql1 = "select * from BioPila inner join BioStock on ltrim(id)=ltrim(pila) where tipo='" + dt2.Rows(0).Item("tipo") + "' and id<> '" + cbde.Text + "' "
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        n = dt1.Rows.Count
        If n = 0 Then
            cba.DataSource = Nothing
            cba.Text = ""
            lbltna.Text = ""
        Else
            cba.DataSource = dt1
            cba.DisplayMember = "id"
            cba.ValueMember = "id"


        End If

    End Sub

    Sub llenaTodoA()
        'llena combo destino con todas las pilas sin tener en cuenta la variedad
        sql1 = "select * from BioPila inner join BioStock on ltrim(id)=ltrim(pila) where id<> '" + cbde.Text + "' "
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        n = dt1.Rows.Count
        If n = 0 Then
            cba.DataSource = Nothing
            cba.Text = ""
            lbltna.Text = ""
        Else
            cba.DataSource = dt1
            cba.DisplayMember = "id"
            cba.ValueMember = "id"


        End If

    End Sub



    Private Sub cbde_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbde.SelectedIndexChanged
        Call buscaSTKTIP(cbde.Text)

        stockde = dt2.Rows(0).Item("stock") / 1000
        lbltnd.Text = stockde & " TN " & Chr(13) & dt2.Rows(0).Item("tipo")

        If chktodas.Checked = True Then

            Call llenaTodoA()

        Else

            Call llenaA()

        End If
    End Sub


    Private Sub cbde_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbde.SelectionChangeCommitted

        Call buscaSTKTIP(cbde.Text)
        stockde = dt2.Rows(0).Item("stock") / 1000
        lbltnd.Text = stockde & " TN " & Chr(13) & dt2.Rows(0).Item("tipo")

        Call llenaA()
    End Sub

    Sub buscaSTKTIP(ByVal nropila As String)

        'busca el stock de la pila, consulta sirve para los dos combos
        sql2 = "select * from BioPila inner join BioStock on ltrim(id)=ltrim(pila) where id='" + nropila + "'"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)
        n = dt2.Rows.Count

        If n = 0 Then
            cba.DataSource = Nothing
            cba.Text = ""
        End If

    End Sub

    Private Sub cba_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cba.SelectedIndexChanged
        Call buscaSTKTIP(cba.Text)
        If n = 0 Then
            cba.DataSource = Nothing
            cba.Text = ""
            lbltna.Text = ""
        Else
            stocka = dt2.Rows(0).Item("stock") / 1000
            lbltna.Text = stocka & " TN " & Chr(13) & dt2.Rows(0).Item("tipo")
        End If
    End Sub

    Private Sub cba_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cba.SelectionChangeCommitted
        Call buscaSTKTIP(cba.Text)
        If n = 0 Then
            cba.DataSource = Nothing
            cba.Text = ""
            lbltna.Text = ""
        Else
            stocka = dt2.Rows(0).Item("stock") / 1000
            lbltna.Text = stocka & " TN " & Chr(13) & dt2.Rows(0).Item("tipo")
        End If
    End Sub

    Private Sub btncargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncargar.Click
        If txtcant.Text = "" Then
            MetroMessageBox.Show(Me, "Ingrese cantidad", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcant.Focus()
        ElseIf txtcant.Text > stockde Then
            MetroMessageBox.Show(Me, "La cantidad supera el stock de la pila desde", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcant.Focus()
        Else

            'Pasar tn a kg para guardar en la tabla stpila
            cantidad = txtcant.Text * 1000

            'resto la cantidad de la pila desde
            SQL3 = "update BioStock set stock= '" + Trim(Str(Int((stockde * 1000 - cantidad)))) + "' where pila='" + cbde.Text + "'"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            'sumo la cantidad a la pila destino
            SQL3 = "update BioStock set stock= '" + Trim(Str(Int((stocka * 1000 + cantidad)))) + "' where pila='" + cba.Text + "'"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()


            'Insertar movimiento en BIOTRAJINV
            campos = "depila,cant,apila,fch,usuario"
            variables = "'" + cbde.Text + "','" + txtcant.Text + "','" + cba.Text + "','" + Now + "','" + user + "'"
            sql4 = "INSERT INTO BIOTRAJINV(" + campos + ") VALUES (" + variables + ")"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            MetroMessageBox.Show(Me, "Transferencia realizada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question)


            'actualizar el stock en los label
            Call buscaSTKTIP(cbde.Text)
            stockde = dt2.Rows(0).Item("stock") / 1000
            lbltnd.Text = stockde & " TN " & Chr(13) & dt2.Rows(0).Item("tipo")

            Call buscaSTKTIP(cba.Text)
            stocka = dt2.Rows(0).Item("stock") / 1000
            lbltna.Text = stocka & " TN " & Chr(13) & dt2.Rows(0).Item("tipo")

            txtcant.Text = ""

        End If
    End Sub

    Private Sub txtcant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcant.KeyPress
        'Validamos si la tecla pulsada es numerica (1,2,3,4,5,6,7,8,9,0) o punto
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False 'Permite entrar caracteres
        Else
            e.Handled = True 'No permite escrbir
        End If
    End Sub


    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub txtcant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcant.TextChanged

    End Sub
End Class