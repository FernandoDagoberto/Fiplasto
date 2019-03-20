Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class TRMADBIO
    Inherits MetroFramework.Forms.MetroForm

    Dim stockde As Double
    Dim stocka As Double
    Dim cantidad As Double

    'Para saber desde donde a donde es la transferencia
    Dim transferencia As String
    Dim factor As Integer
    Dim origen As Char



    Private Sub TRMADBIO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Madera a Biomasa
        transferencia = "MaB"
        factor = 1
        origen = "M"

        Call buscadatos()
        Call llenaD()
    End Sub

    Sub buscadatos()
        'Buscar pilas con stock en la playa de madera
        sql = "SELECT * From pila inner join stpila on ltrim(pila_id)=ltrim(stpila_pila) where stpila_stock>0 " 'and pila_id<>90
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
            cbde.DisplayMember = "pila_id"
            cbde.SelectedValue = "pila_id"
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

        Try
            Call buscaSTKTIP(cbde.Text, "MADERA")

            stockde = dt2.Rows(0).Item("stpila_stock") / 1000
            lbltnd.Text = stockde & " TN " & Chr(13) & dt2.Rows(0).Item("pila_tipo")


            'Lleno todas las pilas de BIOMASA
            Call llenaTodoA()

        Catch
        End Try


    End Sub


    Private Sub cbde_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbde.SelectionChangeCommitted

        Call buscaSTKTIP(cbde.Text, "MADERA")
        stockde = dt2.Rows(0).Item("stpila_stock") / 1000
        lbltnd.Text = stockde & " TN " & Chr(13) & dt2.Rows(0).Item("pila_tipo")

        'Lleno todas las pilas de BIOMASA
        Call llenaTodoA()
    End Sub

    Sub buscaSTKTIP(ByVal nropila As String, ByVal tipo As String)

        Try

            If tipo = "MADERA" Then

                'busca el stock de la pila, consulta sirve para los dos combos
                sql2 = "select * from pila inner join stpila on ltrim(pila_id)=ltrim(stpila_pila) where pila_id='" + nropila + "'"
                da2 = New SqlDataAdapter(sql2, cnn)
                dt2 = New DataTable
                da2.Fill(dt2)
                n = dt2.Rows.Count



            ElseIf tipo = "BIO" Then

                'busca el stock de la pila, consulta sirve para los dos combos
                sql2 = "select * from BioPila inner join BioStock on ltrim(id)=ltrim(pila) where id='" + nropila + "'"
                da2 = New SqlDataAdapter(sql2, cnn)
                dt2 = New DataTable
                da2.Fill(dt2)
                n = dt2.Rows.Count
            End If

            If n = 0 Then
                cba.DataSource = Nothing
                cba.Text = ""
            End If

        Catch
        End Try

    End Sub

    Private Sub cba_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cba.SelectedIndexChanged

        Try
            Call buscaSTKTIP(cba.Text, "BIO")
            If n = 0 Then
                cba.DataSource = Nothing
                cba.Text = ""
                lbltna.Text = ""
            Else
                stocka = dt2.Rows(0).Item("stock") / 1000
                lbltna.Text = stocka & " TN " & Chr(13) & dt2.Rows(0).Item("tipo")
            End If
        Catch
        End Try

    End Sub

    Private Sub cba_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cba.SelectionChangeCommitted
        Call buscaSTKTIP(cba.Text, "BIO")
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
            MetroMessageBox.Show(Me, "La cantidad supera el stock de la pila desde", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcant.Focus()
        Else

            'Pasar tn a kg para guardar en la tabla stpila  y multiplicar por el factor
            cantidad = (txtcant.Text * 1000) * factor

            'Resto la cantidad de la pila desde
            SQL3 = "update stpila set stpila_stock= '" + Trim(Str(Int((stockde * 1000 - cantidad)))) + "' where stpila_pila='" + cbde.Text + "'"
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
            campos = "depila,cant,apila,fch,usuario,origen"
            variables = "'" + cbde.Text + "','" & (txtcant.Text * factor) & "','" + cba.Text + "','" + Now + "','" + user + "','" + origen + "'"
            sql4 = "INSERT INTO TRMADBIO(" + campos + ") VALUES (" + variables + ")"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            MetroMessageBox.Show(Me, "Transferencia realizada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question)


            'actualizar el stock en los label
            Call buscaSTKTIP(cbde.Text, "MADERA")
            stockde = dt2.Rows(0).Item("stpila_stock") / 1000
            lbltnd.Text = stockde & " TN " & Chr(13) & dt2.Rows(0).Item("pila_tipo")

            Call buscaSTKTIP(cba.Text, "BIO")
            stocka = dt2.Rows(0).Item("stock") / 1000
            lbltna.Text = stocka & " TN " & Chr(13) & dt2.Rows(0).Item("tipo")

            txtcant.Text = ""

        End If
    End Sub

    Private Sub txtcant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcant.KeyPress
        ' Validamos si la tecla pulsada es numerica (1,2,3,4,5,6,7,8,9,0) o punto
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False 'Permite entrar caracteres
        Else
            e.Handled = True 'No permite escrbir
        End If
    End Sub


    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim bm As Bitmap = PictureBox1.Image
        bm.RotateFlip(RotateFlipType.Rotate180FlipY)
        Me.PictureBox1.Image = bm

        If transferencia = "MaB" Then   'Madera a Biomasa
            transferencia = "BaM" 'Biomasa a Madera
            lblA.Text = "A pila:"
            lblB.Text = "De pila:"
            factor = -1
            origen = "B"

        Else
            transferencia = "MaB" 'Madera a Biomasa
            lblA.Text = "De pila:"
            lblB.Text = "A pila:"
            factor = 1
            origen = "M"
        End If
    End Sub
End Class