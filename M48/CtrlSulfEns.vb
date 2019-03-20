Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class CtrlSulfEns
    Inherits MetroFramework.Forms.MetroForm
    Dim cantidad As Integer
    Dim maxbolsas As Integer
    Dim suma As Integer



    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        If txtcaudal.Text = "" Or txtconc.Text = "" Or cbgrupo.Text = "" Or cbturno.Text = "" Or cblinea.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbturno.Focus()
            Exit Sub
        Else


            fch = FormatDateTime(Now, DateFormat.ShortDate) & " " & "05:59:59"
            fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

            fecha = FormatDateTime(Now, DateFormat.ShortDate)

            If cbturno.Text = "22-06" Then
                sql = "select count(caudal) as cantidad from CRTLSULFENS where fecha>='" + fechaant + "' and fecha<='" + fch + "' and turno='" + cbturno.Text + "' and linea='" + cblinea.Text + "'"
            Else
                sql = "select count(caudal)as cantidad from CRTLSULFENS where fecha>='" + fecha & " " & "00:00:00" + "' and fecha<='" + fecha & " " & "23:59:59" + "' and turno='" + cbturno.Text + "' and linea='" + cblinea.Text + "'"

            End If



            da = New SqlDataAdapter(sql, cnn)
            dt = New DataTable
            da.Fill(dt)
            If IsDBNull(dt.Rows(0).Item("cantidad")) Then
                cantidad = 0
            Else
                cantidad = dt.Rows(0).Item("cantidad")
            End If



            If cantidad = 1 Then
                MetroMessageBox.Show(Me, "Ya está cargado el ensayo del día de Línea: " & cblinea.Text & "en el turno: " & cbturno.Text & "", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            Else
                msg = MetroMessageBox.Show(Me, "Confirma los siguientes datos:  " + Chr(13) + "Fecha: '" + Now + "'" + Chr(13) + "Turno: '" + cbturno.Text + "'" + Chr(13) + "Grupo:'" + cbgrupo.Text + "'" + Chr(13) + "Línea: '" + cblinea.Text + "'" + Chr(13) + "Caudal: '" + Str(txtcaudal.Text) + "'" + Chr(13) + "Concentración: '" + Str(txtconc.Text) + "'", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If msg = 1 Then
                    campos = "fecha,turno,grupo,linea,caudal,concentracion,user_id"
                    variables = "'" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cblinea.Text + "','" + Str(txtcaudal.Text) + "','" + Str(txtconc.Text) + "','" + user + "'"

                    sql1 = "insert into CRTLSULFENS(" + campos + ") VALUES (" + variables + ")"
                    cmd1 = New SqlCommand(sql1, cnn)
                    cmd1.Connection.Open()
                    cmd1.ExecuteNonQuery()
                    cmd1.Connection.Close()

                    MetroMessageBox.Show(Me, "", "Control guardado", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    txtcaudal.Text = ""
                    txtconc.Text = ""

                Else
                    txtcaudal.Focus()

                End If

            End If


        End If

    End Sub

    Private Sub txtcaudal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcaudal.KeyPress
        'Validamos si la tecla pulsada es numerica (1,2,3,4,5,6,7,8,9,0) o punto
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False 'Permite entrar caracteres
        Else
            e.Handled = True 'No permite escrbir
        End If
    End Sub



    Private Sub txtconc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtconc.KeyPress
        'Validamos si la tecla pulsada es numerica (1,2,3,4,5,6,7,8,9,0) o punto
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False 'Permite entrar caracteres
        Else
            e.Handled = True 'No permite escrbir
        End If
    End Sub

End Class