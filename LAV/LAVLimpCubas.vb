Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class LAVLimpCubas
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String
    Dim cantidad, MaxCtrl As Integer
    Dim cantIng, cantEgr, cantDes, cantnuevos, cantbaja As String
    Dim cuba1, cuba2 As String



    Private Sub LAVLimpCubas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call verifica_fecha()

        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto
        cbgrupo.Focus()
    End Sub

    Private Sub verifica_fecha()
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            dtfecha.Value = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            dtfecha.Value = FormatDateTime(Now, DateFormat.ShortDate)
        End If
    End Sub


    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        'chequeo turno y grupo
        If String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar los campos Turno y Grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        If chk1.Checked = False And chk2.Checked = False Then
            MetroMessageBox.Show(Me, "Debe seleccionar al menos una cuba", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If chk1.Checked = True Then
            cuba1 = "S"
        End If

        If chk2.Checked = True Then
            cuba2 = "S"
        End If

        campos = "lavLimpCuba_fecha, lavLimpCuba_turno, lavLimpCuba_grupo, lavLimpCuba_cuba1, lavLimpCuba_cuba2, lavLimpCuba_userid, lavLimpCuba_bajaid,lavLimpCuba_bajafch"
        variables = "'" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cuba1 + "', " &
        "'" + cuba2 + "','" + user + "','0',''"

        SQL3 = "INSERT INTO lavLimpCuba (" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()
        MetroMessageBox.Show(Me, "Registro guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

        Call verifica_fecha()

        chk1.Checked = False
        chk2.Checked = False
        cuba1 = ""
        cuba2 = ""

        Call buscadatos()



    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub


    Private Sub conexion()
        conex("LAVADERO")
    End Sub

    Private Sub buscadatos()
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()


        sql1 = "SELECT lavlimpcuba_id as ID, lavlimpcuba_fecha as Fecha,lavlimpcuba_turno as Turno,lavlimpcuba_grupo as Grupo, " &
                "lavlimpcuba_cuba1 as Cuba1,lavlimpcuba_cuba2 as Cuba2 from lavLimpCuba " &
                "where  lavLimpCuba_FECHA>='" + fechaant + "' and lavLimpCuba_FECHA<='" + fch + "' and lavLimpCuba_bajaid='0' order by lavLimpCuba_fecha"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        dgIng.DataSource = dt1
        dgIng.Columns("ID").Visible = False

    End Sub

    Private Sub eliminalinea()

        'elimina la fila de la grilla
        sql4 = "select lavLimpCuba_userid from lavLimpCuba where lavLimpCuba_id='" + Trim(line) + "' and lavLimpCuba_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count


        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            sql4 = "update lavLimpCuba set lavLimpCuba_bajaid='" + user + "', lavLimpCuba_bajafch='" + Now + "' where  lavLimpCuba_id='" + Trim(line) + "' "
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call buscadatos()
            If dt1.Rows.Count <> 0 Then
                'dg.Select(0)
            End If
        End If

    End Sub

    Private Sub dgIng_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgIng.Click
        If dgIng.SelectedRows.Count = 1 Then
            line = dgIng.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dgIng_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgIng.KeyUp
        If sender.SelectedRows.Count = 1 Then
            If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
            Else
                fechaborra = FormatDateTime(Now, DateFormat.ShortDate)

            End If

            If dtfecha.Text = fechaborra Then
                If e.KeyCode = Keys.Delete Then
                    ms = MetroMessageBox.Show(Me, "¿Desea eliminar la línea seleccionada?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    If ms = 1 Then
                        Call eliminalinea()
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "No se pueden eliminar cargas de días anteriores", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos()
    End Sub


End Class