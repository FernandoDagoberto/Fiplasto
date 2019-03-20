Imports System.Data.SqlClient
Imports MetroFramework

Public Class TranfsMadVig
    Inherits MetroFramework.Forms.MetroForm

    Dim total As Double
    Dim stocka As Double
    Dim cantidad As Double


    Private Sub TransfMadVig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call llenaviga()

    End Sub

    Sub llenaviga()
        'llena combo destino de acuerdo a la pila que se seleccionó en desde
        sql1 = "select * from pila inner join stpila on ltrim(pila_id)=ltrim(stpila_pila) where pila_tipo='Vigas'"
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
            cba.DisplayMember = "pila_id"
            cba.ValueMember = "pila_id"


        End If

    End Sub


    Private Sub buscamax()
        conex("marmv")
        sql2 = "SELECT max(marmv_nroremito)as ult From MARMV where marmv_ingegr='V'"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)
    End Sub

    Private Sub btncargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncargar.Click
        If txtcant.Text = "" Or cbgrupo.Text = "" Or cbturno.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de completar todos los datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcant.Focus()
        Else

            msg = MetroMessageBox.Show(Me, "Desea realizar la siguiente tranferencia: " + Chr(13) + "Turno: '" + cbturno.Text + "'" + Chr(13) + "Grupo:'" + cbgrupo.Text + "'" + Chr(13) + "Pila: '" + Trim(cba.Text) + "'" + Chr(13) + "TN: '" + Str(txtcant.Text) + "'", "Confirmación de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If msg = 1 Then

                Call buscamax()
                If IsDBNull(dt2.Rows(0).Item("ult")) Then
                    ultnro = "1"
                Else
                    ultnro = dt2.Rows(0).Item("ult") + 1
                End If


                'Pasar tn a kg para guardar en la tabla stpila
                cantidad = txtcant.Text * 1000

                'Stock actual de la pila de vigas
                stocka = dt1.Rows(0).Item("stpila_stock")

                total = stocka + cantidad

                'Actualizo el stock de la pila de vigas
                SQL3 = "update stpila set stpila_stock= '" + Trim(Str(total)) + "' where stpila_pila='" + cba.Text + "'"
                cmd3 = New SqlCommand(SQL3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()

                'Insertar movimiento negativo en MARMV
                campos = "marmv_ingegr,marmv_nroremito,marmv_conforme,marmv_destino,marmv_tipmad,marmv_pila,marmv_neto,marmv_fecha,marmv_turno,marmv_grupo,marmv_userid"
                variables = "'V','" + ultnro + "','S','C','4','" + cba.Text + "','" + Str(-cantidad) + "','" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + user + "'"
                sql4 = "INSERT INTO MARMV (" + campos + ") VALUES (" + variables + ")"
                cmd4 = New SqlCommand(sql4, cnn)
                cmd4.Connection.Open()
                cmd4.ExecuteNonQuery()
                cmd4.Connection.Close()

                MetroMessageBox.Show(Me, "Transferencia realizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtcant.Text = ""


            Else
                txtcant.Focus()

            End If


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

End Class