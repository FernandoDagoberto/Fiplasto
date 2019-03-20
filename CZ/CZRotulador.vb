Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework

Public Class CZRotulador
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl, reposicion, limpieza As String
    Dim cantidad, marca As Integer

    Private Sub CZRotulador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto

        Call verifica_fecha()
        Call buscadatos()


    End Sub

    Private Sub verifica_fecha()
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            dtfecha.Value = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            dtfecha.Value = FormatDateTime(Now, DateFormat.ShortDate)
        End If
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        If String.IsNullOrEmpty(cblinea.Text) Or String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Or (chklimp.Checked = False And chkrepo.Checked = False) Then
            MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If chklimp.Checked = True Then
            limpieza = "S"
        Else
            limpieza = "N"
        End If

        If chkrepo.Checked = True Then
            reposicion = "S"
        Else
            reposicion = "N"
        End If

        campos = "czrot_fecha,czrot_linea,czrot_turno,czrot_grupo,czrot_limp,czrot_repos,czrot_userid,czrot_bajaid,czrot_bajafch"

        variables = "'" + Now + "','" + Trim(cblinea.Text) + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + limpieza + "','" + reposicion + "', " &
        "'" + user + "','0',''"

        SQL3 = "INSERT INTO CZROTULADOR (" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()

        MetroMessageBox.Show(Me, "Control guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

        Call verifica_fecha()
        Call buscadatos()
        Call limpia()

    End Sub

    Private Sub limpia()
        cblinea.Text = Nothing
        chklimp.Checked = False
        chkrepo.Checked = False

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos()
    End Sub

    Private Sub conexion()
        conex("czrotulador")
    End Sub

    Private Sub buscadatos()

        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql1 = "SELECT czrot_id as ID, czrot_fecha as Fecha,czrot_linea as Linea,czrot_turno as Turno,czrot_grupo as Grupo,
                czrot_limp as Limpieza,czrot_repos as Reposicion 
                from CZROTULADOR 
                where CZROT_FECHA>='" + fechaant + "' and CZROT_FECHA<='" + fch + "' and CZROT_bajaid='0' order by CZROT_fecha"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        cant = dt1.Rows.Count

        dg.DataSource = dt1
    End Sub

    Private Sub dgcarga_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.Click
        If dg.SelectedRows.Count = 1 Then
            line = dg.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dgcarga_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            fechaborra = FormatDateTime(Now, DateFormat.ShortDate)

        End If

        If dtfecha.Text = fechaborra Then
            If e.KeyCode = Keys.Delete Then
                ms = MetroMessageBox.Show(Me, "¿Desea eliminar la línea seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    Call eliminalinea()
                End If
            End If
        End If
    End Sub

    Private Sub eliminalinea()
        'elimina la fila de la grilla
        sql4 = "select CZROT_userid from CZROTULADOR where CZROT_id='" + Str(line) + "' and  CZROT_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count

        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sql4 = "Update CZROTULADOR set CZROT_BAJAID='" + user + "' where CZROT_id='" + Str(line) + "'"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()
            Call buscadatos()
            If dt1.Rows.Count <> 0 Then
                dg.Select()
            Else

            End If
        End If
    End Sub

    Private Sub dgcarga_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        If cant > 0 Then
            If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
            Else
                fechaborra = FormatDateTime(Now, DateFormat.ShortDate)
            End If

            If dtfecha.Text = fechaborra Then
                sql5 = "select CZROT_userid from CZROTULADOR where CZROT_id='" + Trim(Str(line)) + "' and CZROT_userid='" + user + "'"
                da5 = New SqlDataAdapter(sql5, cnn)
                dt5 = New DataTable
                da5.Fill(dt5)
                Dim n As Integer
                n = dt5.Rows.Count

                If n = 0 Then
                    MetroMessageBox.Show(Me, "Usted no puede modificar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim im As String
                    im = UCase(InputBox("Cambiar Turno"))

                    If im = "A" Or im = "B" Or im = "C" Or im = "D" Then

                        sql4 = "Update CZROTULADOR set CZROT_GRUPO='" + im + "' where CZROT_id='" + Str(line) + "'"
                        cmd4 = New SqlCommand(sql4, cnn)
                        cmd4.Connection.Open()
                        cmd4.ExecuteNonQuery()
                        cmd4.Connection.Close()

                        MetroMessageBox.Show(Me, "GRUPO CAMBIADO", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        Call buscadatos()
                        If dt1.Rows.Count <> 0 Then
                            'dg.Select(0)
                        End If
                    Else
                        MetroMessageBox.Show(Me, "GRUPO INCORRECTO", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "No se pueden modificar cargas de días anteriores", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
        End If
    End Sub

End Class