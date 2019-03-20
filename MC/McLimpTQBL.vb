Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class McLimpTQBL
    Inherits MetroFramework.Forms.MetroForm

    Dim ms As Integer
    Dim idl As String
    Dim cantidad As Integer



    Private Sub McLimpTQBL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        If cbturno.Text = "" Or cbgrupo.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            campos = "mctqbl_fecha,mctqbl_turno,mctqbl_grupo,mctqbl_userid"
            variables = "'" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + user + "'"

            SQL3 = "INSERT INTO MCTQBL (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            MetroMessageBox.Show(Me, "Limpieza de Tanque cargada", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

            Call limpia()
            Call verifica_fecha()
            Call buscadatos()
        End If
    End Sub

    Private Sub limpia()
        cbgrupo.Text = Nothing
        cbturno.Text = Nothing
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub conexion()
        conex("mctqbl")
    End Sub

    Private Sub buscadatos()
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql1 = "SELECT mctqbl_id as ID, mctqbl_fecha as Fecha,mctqbl_turno as Turno,mctqbl_grupo as Grupo,mctqbl_userid as UserID,mctqbl_bajaid as BajaID 
                from mctqbl 
               where  mctqbl_fecha>='" + fechaant + "' and mctqbl_fecha<='" + fch + "' and mctqbl_bajaid is null 
               order by mctqbl_fecha"

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        dg.DataSource = dt1
        ocultarColumnas()

    End Sub

    Private Sub ocultarColumnas()
        dg.Columns("ID").Visible = False
        dg.Columns("UserID").Visible = False
        dg.Columns("BajaId").Visible = False
    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos()
    End Sub

    Private Sub dg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.Click
        If dg.SelectedRows.Count = 1 Then
            line = dg.CurrentRow.Cells("ID").Value
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
        sql4 = "select mctqbl_userid from mctqbl where mctqbl_id='" + Str(line) + "' and mctqbl_userid='" + user + "' "
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count


        If n = 0 Then
            MetroMessageBox.Show(Me,"Usted no puede borrar registros cargados por otros usuarios", MsgBoxStyle.Information)
        Else
            sql4 = "update mctqbl set mctqbl_bajaid='" + user + "' where mctqbl_id='" + Str(line) + "' "
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