Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class CtrlSulfato
    Inherits MetroFramework.Forms.MetroForm
    Dim cantidad As Integer
    Dim maxbolsas As Integer
    Dim suma As Integer
    Dim msgbolsas As String


    Private Sub txtbolsas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbolsas.KeyPress
        'solo acepta numeros ****ver tambien en modulo 1***********************
        SoloNumeros(e)

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        If txtbolsas.Text = "" Then
            MetroMessageBox.Show(Me, "La cantidad de bolsas no puede ser nula", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtbolsas.Focus()
            Exit Sub

            'ElseIf txtbolsas.Text > 8 Then
            '    MetroMessageBox.Show(Me,"Cantidad de bolsas superior a 8")
            '    txtbolsas.Focus()
            '    Exit Sub
        ElseIf txtbolsas.Text = 0 Then
            MetroMessageBox.Show(Me, "Cantidad de bolsas no puede ser 0", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtbolsas.Focus()
            Exit Sub
        End If


        fch = FormatDateTime(Now, DateFormat.ShortDate) & " " & "05:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        fecha = FormatDateTime(Now, DateFormat.ShortDate)


        If cbturno.Text = "22-06" Then
            sql = "select sum(bolsas) as cantidad from CRTLSULFALU where fecha>='" + fechaant + "' and fecha<='" + fch + "' and turno='" + cbturno.Text + "'"
        Else
            sql = "select sum(bolsas)as cantidad from CRTLSULFALU where fecha>='" + fecha & " " & "00:00:00" + "' and fecha<='" + fecha & " " & "23:59:59" + "' and turno='" + cbturno.Text + "'"

        End If


        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        If IsDBNull(dt.Rows(0).Item("cantidad")) Then
            cantidad = 0
        Else
            cantidad = dt.Rows(0).Item("cantidad")
        End If



        limites("limitebolsas")
        maxbolsas = dt8.Rows(0).Item("param_valor")
        suma = cantidad + txtbolsas.Text

        If suma > maxbolsas Then
            msgbolsas = InputBox("Máximo de bolsas por turno: " & maxbolsas & "" + Chr(13) + "" & "Su turno: " & suma & "", "Atención", "Ingrese motivo")
            If msgbolsas = "" Then
                Exit Sub
            Else
                Call guardarbolsas()

            End If

        Else

            msg = MetroMessageBox.Show(Me, "Confirma los siguientes datos: " + Chr(13) + "Fecha: '" + Now + "'" + Chr(13) + "Turno: '" + cbturno.Text + "'" + Chr(13) + "Grupo:'" + cbgrupo.Text + "'" + Chr(13) + "Bolsas: '" + Trim(txtbolsas.Text) + "'", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            If msg = 1 Then

                Call guardarbolsas()

            Else
                txtbolsas.Focus()

            End If

        End If




    End Sub

    Sub guardarbolsas()
        campos = "fecha,turno,grupo,bolsas,motivo,user_id"
        variables = "'" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + txtbolsas.Text + "','" + msgbolsas + "','" + user + "'"

        sql1 = "insert into CRTLSULFALU (" + campos + ") VALUES (" + variables + ")"
        cmd1 = New SqlCommand(sql1, cnn)
        cmd1.Connection.Open()
        cmd1.ExecuteNonQuery()
        cmd1.Connection.Close()

        MetroMessageBox.Show(Me, "", "Control guardado", MessageBoxButtons.OK, MessageBoxIcon.Question)
        txtbolsas.Text = ""
    End Sub
End Class