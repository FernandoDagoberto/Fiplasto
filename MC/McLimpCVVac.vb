Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class McLimpCVVac
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String
    Dim cantidad As Integer

    Private Sub McLimpCVVac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        If String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar turno y grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf chk2.Checked = False And chk3.Checked = False And chk4.Checked = False And chk5.Checked = False Then
            MetroMessageBox.Show(Me, "Seleccione vacío", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim vac2, vac3, vac4, vac5 As String

            If chk2.Checked = True Then
                vac2 = "'S'"
            Else
                vac2 = "null"
            End If

            If chk3.Checked = True Then
                vac3 = "'S'"
            Else
                vac3 = "null"
            End If

            If chk4.Checked = True Then
                vac4 = "'S'"
            Else
                vac4 = "null"
            End If

            If chk5.Checked = True Then
                vac5 = "'S'"
            Else
                vac5 = "null"
            End If

            campos = "MCLIMPCVVAC_fecha,MCLIMPCVVAC_mc,MCLIMPCVVAC_turno,MCLIMPCVVAC_grupo,MCLIMPCVVAC_vacio2,MCLIMPCVVAC_vacio3,MCLIMPCVVAC_vacio4,MCLIMPCVVAC_vacio5,MCLIMPCVVAC_userid"
            variables = "'" + Now + "','" + txtmc.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "'," + Trim(vac2) + "," + Trim(vac3) + "," + Trim(vac4) + "," + Trim(vac5) + ",'" + user + "'"

            SQL3 = "INSERT INTO MCLIMPCVVAC (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            MetroMessageBox.Show(Me, "Limpieza cargada", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

            Call limpia()
            Call verifica_fecha()
            Call buscadatos()


        End If

    End Sub

    Private Sub limpia()
        chk2.Checked = False
        chk3.Checked = False
        chk4.Checked = False
        chk5.Checked = False

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub conexion()
        conex("MCLIMPCVVAC")
    End Sub

    Private Sub buscadatos()
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql1 = "select * from MCLIMPCVVAC where  MCLIMPCVVAC_fecha>='" + fechaant + "' and MCLIMPCVVAC_fecha<='" + fch + "' and MCLIMPCVVAC_bajaid is null order by MCLIMPCVVAC_fecha"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        dg.DataSource = dt1

    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged

        Call buscadatos()

    End Sub

    Private Sub dg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.Click
        If dg.SelectedRows.Count = 1 Then
            line = dg.CurrentRow.Cells("MCLIMPCVVAC_id").Value
        End If
    End Sub


    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
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
        Else
            MetroMessageBox.Show(Me, "No se pueden eliminar datos de días anteriores", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub eliminalinea()
        'elimina la fila de la grilla

        sql4 = "select MCLIMPCVVAC_userid from MCLIMPCVVAC  where MCLIMPCVVAC_id='" + Str(line) + "'  and MCLIMPCVVAC_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count


        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sql4 = "update MCLIMPCVVAC set MCLIMPCVVAC_bajaid='" + user + "' where MCLIMPCVVAC_id='" + Str(line) + "' "
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


End Class