Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class CtrlFibras
    Inherits MetroFramework.Forms.MetroForm
    Dim cantidad As Integer
    Dim maxbolsas As Integer
    Dim suma As Integer
    Dim ms As Integer
    Dim idl As String
    Dim cant As Integer
    Dim lineaDG As DateTime


    Private Sub CtrlFibras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call buscadatos()

        dg.DataSource = dt1

        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto

        Call llenamotivocvf()
    End Sub
    Private Sub conexion()
        conex("mcparafina")
    End Sub

    Private Sub buscadatos()
        Call conexion()

        sql1 = "select fecha,turno,grupo,maquina,motivocvf_desc as motivo,user_id as Usuario from crtlvisfib inner join motivocvf on crtlvisfib.control=motivocvf.motivocvf_id where  (CONVERT(varchar(10), fecha, 103) ='" + Mid(dtfecha.Text, 1, 10) + "') and baja_id='0' order by fecha"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        cant = dt1.Rows.Count
    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos()
        dg.DataSource = dt1
    End Sub


    Private Sub dg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.Click
        If dg.SelectedRows.Count = 1 Then
            lineaDG = dg.CurrentRow.Cells("fecha").Value
        End If

    End Sub


    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If cant > 0 Then
            If dtfecha.Text = Now.Date Then
                If e.KeyCode = Keys.Delete Then
                    ms = MetroMessageBox.Show(Me, "¿Desea eliminar la línea seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    If ms = 1 Then
                        Call eliminalinea()
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "No se pueden eliminar cargas de días anteriores", "Aviso", MessageBoxButtons.OK)

            End If
        Else
        End If
    End Sub

    Private Sub eliminalinea()
        'elimina la fila de la grilla
        sql4 = "select user_id from crtlvisfib where  fecha='" + dt1.Rows(line).Item("fecha") + "' and turno='" + dt1.Rows(line).Item("turno") + "' and user_id='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count

        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sql4 = "update crtlvisfib set baja_id='" + user + "' where  fecha='" + dt1.Rows(line).Item("fecha") + "' and turno='" + dt1.Rows(line).Item("turno") + "' and user_id='" + user + "'"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()
            Call buscadatos()
            dg.DataSource = dt1
            If dt1.Rows.Count <> 0 Then
                dg.Select()
            Else

            End If
        End If

    End Sub




    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        If cbgrupo.Text = "" Or cbturno.Text = "" Or cbmaquina.Text = "" Or cbcontrol.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbturno.Focus()
            Exit Sub

        Else

            fch = FormatDateTime(Now, DateFormat.ShortDate) & " " & "05:59:59"
            fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

            fecha = FormatDateTime(Now, DateFormat.ShortDate)


            If cbturno.Text = "22-06" Then
                sql = "select count(maquina) as cantidad from CRTLVISFIB where fecha>='" + fechaant + "' and fecha<='" + fch + "' and turno='" + cbturno.Text + "' and maquina='" + cbmaquina.Text + "'"
            Else
                sql = "select count(maquina)as cantidad from CRTLVISFIB where fecha>='" + fecha & " " & "00:00:00" + "' and fecha<='" + fecha & " " & "23:59:59" + "' and turno='" + cbturno.Text + "' and maquina='" + cbmaquina.Text + "'"

            End If


            da = New SqlDataAdapter(sql, cnn)
            dt = New DataTable
            da.Fill(dt)
            If IsDBNull(dt.Rows(0).Item("cantidad")) Then
                cantidad = 0
            Else
                cantidad = dt.Rows(0).Item("cantidad")
            End If


            If cantidad = 2 Then
                MetroMessageBox.Show(Me, "Su turno: " & cbturno.Text & " ya no puede cargar más controles por el día de hoy.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()

            Else

                msg = MetroMessageBox.Show(Me, "Confirma los siguientes datos: " + Chr(13) + "Fecha: '" + Now + "'" + Chr(13) + "Turno: '" + cbturno.Text + "'" + Chr(13) + "Grupo:'" + cbgrupo.Text + "'" + Chr(13) + "Máquina: '" + cbmaquina.Text + "'" + Chr(13) + "Control: '" + cbcontrol.Text + "'", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

                If msg = 1 Then

                    campos = "fecha,turno,grupo,maquina,control,user_id,baja_id"
                    variables = "'" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbmaquina.Text + "','" + cbcontrol.SelectedValue + "','" + user + "','0'"

                    sql1 = "insert into CRTLVISFIB (" + campos + ") VALUES (" + variables + ")"
                    cmd1 = New SqlCommand(sql1, cnn)
                    cmd1.Connection.Open()
                    cmd1.ExecuteNonQuery()
                    cmd1.Connection.Close()

                    MetroMessageBox.Show(Me, "Control guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

                    Call buscadatos()
                    dg.DataSource = dt1

                Else
                    cbturno.Focus()

                End If
            End If
        End If

    End Sub

    Sub llenamotivocvf()
        llenacb("motivocvf")
        cbcontrol.DataSource = dt7
        cbcontrol.DisplayMember = "motivocvf_desc"
        cbcontrol.ValueMember = "motivocvf_id"

    End Sub


End Class