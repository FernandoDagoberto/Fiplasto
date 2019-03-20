Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework

Public Class McTelas
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String
    Dim cantidad As Integer

    Private Sub McTelas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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


    Private Sub cbmc_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbmc.SelectionChangeCommitted

        Call llenacbwhere("mctelas", "where telas_mc='" + cbmc.Text + "'")
        cbtela.DataSource = dt9
        cbtela.DisplayMember = "telas_tela"
        cbtela.ValueMember = "telas_tela"



    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        If String.IsNullOrEmpty(cbmc.Text) Or String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Or String.IsNullOrEmpty(cbtela.Text) Or String.IsNullOrEmpty(cbrazon.Text) Or String.IsNullOrEmpty(txtndetela.Text) Or String.IsNullOrEmpty(txtprov.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            campos = "camtela_mc,camtela_fecha,camtela_turno,camtela_grupo,camtela_tela,camtela_razon,camtela_prov,camtela_ndetela,camtela_userid"
            variables = "'" + cbmc.Text + "','" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbtela.Text + "','" + cbrazon.Text + "','" + txtprov.Text + "','" + txtndetela.Text + "','" + user + "'"

            SQL3 = "INSERT INTO MCCAMTELAS (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()
            MetroMessageBox.Show(Me, "Cambio de telas guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

            Call verifica_fecha()
            Call buscadatos()
            Call limpiar()
        End If

    End Sub

    Private Sub limpiar()
        txtprov.Text = Nothing
        txtndetela.Text = Nothing

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos()
    End Sub

    Private Sub conexion()
        conex("mccamtelas")
    End Sub

    Private Sub buscadatos()

        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql1 = "SELECT camtela_id as ID, camtela_fecha as Fecha,camtela_mc as Linea,camtela_turno as Turno,camtela_grupo as Grupo
                 ,camtela_tela as Tela,camtela_razon as Razon,camtela_prov as Prov,camtela_ndetela as NºTela
                ,camtela_userid as UserID,camtela_bajaid as BajaID 
                from MCCAMTELAS 
                where camtela_fecha>='" + fechaant + "' and camtela_fecha<='" + fch + "' and camtela_bajaid is null 
                order by camtela_fecha"

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        cantidad = dt1.Rows.Count

        dg.DataSource = dt1
        ocultarColumnas()
    End Sub

    Private Sub ocultarColumnas()
        dg.Columns("ID").Visible = False
        dg.Columns("UserID").Visible = False
        dg.Columns("BajaId").Visible = False
    End Sub

    Private Sub eliminalinea()
        'elimina la fila de la grilla
        sql4 = "select camtela_userid from mccamtelas where camtela_id='" + Str(line) + "' and camtela_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count


        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sql4 = "update mccamtelas set camtela_bajaid='" + user + "' where camtela_id='" + Str(line) + "'"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call buscadatos()
            dg.DataSource = dt1
            If dt1.Rows.Count <> 0 Then
                'dg.Select(0)
            Else

            End If
        End If

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
End Class