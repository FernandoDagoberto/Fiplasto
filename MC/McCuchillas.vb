Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class McCuchillas
    Inherits MetroFramework.Forms.MetroForm

    Dim ms As Integer
    Dim idl As String
    Dim cantidad As Integer
    Dim lineaDG As DateTime

    Private Sub McCuchillas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call verifica_fecha()
        Call buscadatos()


        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto



    End Sub

    Private Sub verifica_fecha()

        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            dtfecha.Value = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            dtfecha.Value = FormatDateTime(Now, DateFormat.ShortDate)

        End If

    End Sub

    Private Sub conexion()
        conex("mcparafina")
    End Sub

    Private Sub buscadatos()
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql1 = "SELECT camcuch_id as ID,camcuch_mc as Linea,camcuch_fecha as Fecha,camcuch_turno as Turno,camcuch_grupo as Grupo, 
                camcuch_lplaya as LPlaya,camcuch_lrio as LRio,camcuch_trans as Transversal,
                camcuch_userid as UserId,camcuch_bajaid as BajaId FROM MCCUCHILLA 
                where camcuch_fecha>='" + fechaant + "' and camcuch_fecha<='" + fch + "' and camcuch_bajaid is null 
                order by camcuch_fecha"

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


    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If String.IsNullOrEmpty(cbmc.Text) Or String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar MC, Turno y Grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If chkplaya.Checked = False And chkrio.Checked = False And chktransversal.Checked = False Then
            MetroMessageBox.Show(Me, "Favor de seleccionar lado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End If


        If chkplaya.Checked = True And cbplaya.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de seleccionar la razón del cambio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbplaya.Focus()
        ElseIf chkrio.Checked = True And cbrio.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de seleccionar la razón del cambio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbrio.Focus()
        ElseIf chktransversal.Checked = True And cbtrans.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de seleccionar la razón del cambio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbtrans.Focus()
        Else

            Dim playa As String
            If chkplaya.Checked = True Then
                playa = "'" + cbplaya.Text + "'"
            Else
                playa = "null"
            End If


            Dim rio As String
            If chkrio.Checked = True Then
                rio = "'" + cbrio.Text + "'"
            Else
                rio = "null"
            End If

            Dim transversal As String
            If chktransversal.Checked = True Then
                transversal = "'" + cbtrans.Text + "'"
            Else
                transversal = "null"
            End If

            campos = "camcuch_mc,camcuch_fecha,camcuch_turno,camcuch_grupo,camcuch_lplaya,camcuch_lrio,camcuch_trans,camcuch_userid"

            variables = "'" + cbmc.Text + "','" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "'," + playa + " , " &
            "" + rio + "," + transversal + ",'" + user + "'"
            SQL3 = "INSERT INTO MCCUCHILLA (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            MetroMessageBox.Show(Me, "Cambio de Cuchilla Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

            Call verifica_fecha()
            Call buscadatos()
            Call limpia()

        End If

    End Sub

    Private Sub limpia()

        chkplaya.Checked = False
        chkrio.Checked = False
        chktransversal.Checked = False

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub


    Private Sub chkplaya_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkplaya.CheckedChanged
        If chkplaya.Checked = True Then
            lblplaya.Visible = True
            cbplaya.Visible = True
        Else
            lblplaya.Visible = False
            cbplaya.Text = Nothing
            cbplaya.Visible = False
        End If
    End Sub

    Private Sub chkrio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkrio.CheckedChanged
        If chkrio.Checked = True Then
            lblrio.Visible = True
            cbrio.Visible = True
        Else
            lblrio.Visible = False
            cbrio.Text = Nothing
            cbrio.Visible = False
        End If
    End Sub

    Private Sub chktransversal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktransversal.CheckedChanged
        If chktransversal.Checked = True Then
            lbltrans.Visible = True
            cbtrans.Visible = True
        Else
            lbltrans.Visible = False
            cbtrans.Text = Nothing
            cbtrans.Visible = False
        End If

    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged

        Call buscadatos()
        dg.DataSource = dt1
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
        End If
    End Sub

    Private Sub eliminalinea()
        'elimina la fila de la grilla
        sql4 = "select camcuch_userid from mccuchilla where camcuch_id='" + Str(line) + "' and camcuch_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count


        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            sql4 = "update mccuchilla set camcuch_bajaid='" + user + "' where camcuch_id='" + Str(line) + "'"
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