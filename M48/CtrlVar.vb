Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class CtrlVar
    Inherits MetroFramework.Forms.MetroForm

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        If txtaltura.Text = "" Or txttiempo.Text = "" Or txtprevap.Text = "" Or cbgrupo.Text = "" Or cbturno.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            'Se eliminó control de frecuencia (cualquier cosa copiar el diseño de CtrlSulfEns)
            msg = MetroMessageBox.Show(Me, "Confirma los siguientes datos: " + Chr(13) + "Fecha: '" + Now + "'" + Chr(13) + "Turno: '" + cbturno.Text + "'" + Chr(13) + "Grupo:'" + cbgrupo.Text + "'" + Chr(13) + "Altura: '" + Str(txtaltura.Text) + "'" + Chr(13) + "Tiempo: '" + Str(txttiempo.Text) + "'" + Chr(13) + "Presión Vapor: '" + Str(txtprevap.Text) + "'", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            If msg = 1 Then

                campos = "fecha,turno,grupo,altura,tiempo,presvapor,user_id"
                variables = "'" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + Str(txtaltura.Text) + "','" + Str(txttiempo.Text) + "','" + Str(txtprevap.Text) + "','" + user + "'"

                sql1 = "insert into CRTLVAR(" + campos + ") VALUES (" + variables + ")"
                cmd1 = New SqlCommand(sql1, cnn)
                cmd1.Connection.Open()
                cmd1.ExecuteNonQuery()
                cmd1.Connection.Close()

                MetroMessageBox.Show(Me, "", "Control guardado", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtaltura.Text = ""
                txttiempo.Text = ""
                txtprevap.Text = ""

            Else
                txtaltura.Focus()

            End If

        End If


        'End If

    End Sub

    Private Sub txtaltura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaltura.KeyPress
        'Validamos si la tecla pulsada es numerica (1,2,3,4,5,6,7,8,9,0) o punto
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False 'Permite entrar caracteres
        Else
            e.Handled = True 'No permite escrbir
        End If
    End Sub


    Private Sub txtprevap_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprevap.KeyPress
        'Validamos si la tecla pulsada es numerica (1,2,3,4,5,6,7,8,9,0) o punto
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False 'Permite entrar caracteres
        Else
            e.Handled = True 'No permite escrbir
        End If
    End Sub


    Private Sub txttiempo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttiempo.KeyPress
        'Validamos si la tecla pulsada es numerica (1,2,3,4,5,6,7,8,9,0) o punto
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False 'Permite entrar caracteres
        Else
            e.Handled = True 'No permite escrbir
        End If
    End Sub

End Class