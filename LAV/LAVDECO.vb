Imports System.Data.SqlClient
Imports MetroFramework

Public Class LAVDECO
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String
    Dim cantidad, MaxCtrl As Integer
    Dim movimiento As Char
    Dim cantIng, cantEgr, cantSeg, cantLav, cantArm, cantnuevos, cantbaja, abertura As String

    Private Sub LAVDECO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call verifica_fecha()
        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto
        Call CargaDeco()
        cbgrupo.Focus()
    End Sub

    Private Sub verifica_fecha()
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            dtfecha.Value = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            dtfecha.Value = FormatDateTime(Now, DateFormat.ShortDate)
        End If


    End Sub

    Private Sub CargaDeco()
        Call llenacbwhere("decorativo", "where deco_baja='N' order by deco_desc")

        cbdeco.DataSource = dt9
        cbdeco.DisplayMember = "deco_desc"
        cbdeco.ValueMember = "deco_desc"

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        'chequeo turno y grupo
        If String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar los campos Turno y Grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If String.IsNullOrEmpty(cbdeco.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar tipo de decorativo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbdeco.Focus()
            Exit Sub
        End If

        'chequeo línea 1 (24 aberturas), línea 2 (30)

        If rbIng.Checked = True Or rbEgr.Checked = True Then
            If String.IsNullOrEmpty(txtabertura.Text) Or String.IsNullOrEmpty(cblinea.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtabertura.Focus()
                txtabertura.SelectAll()
                Exit Sub
            End If


            If cblinea.Text = "1" And (txtabertura.Text < 1 Or txtabertura.Text > 24) Then
                MetroMessageBox.Show(Me, "Línea 1 posee 24 aberturas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtabertura.Focus()
                txtabertura.SelectAll()
                Exit Sub
            ElseIf cblinea.Text = "2" And (txtabertura.Text < 1 Or txtabertura.Text > 30) Then
                MetroMessageBox.Show(Me, "Línea 2 posee 30 aberturas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtabertura.Focus()
                txtabertura.SelectAll()
                Exit Sub
            End If
        End If


        If rbArm.Checked Or rbSeg.Checked Or rbLav.Checked Then
            linea = ""
            abertura = ""

        Else
            linea = cblinea.Text
            abertura = txtabertura.Text
        End If


        campos = "LAVDECO_fecha, LAVDECO_ingegr, LAVDECO_linea, LAVDECO_turno, LAVDECO_grupo, LAVDECO_deco, LAVDECO_abertura, LAVDECO_userid, LAVDECO_bajaid,LAVDECO_bajafch"
        variables = "'" + Now + "','" + movimiento + "','" + Trim(linea) + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbdeco.Text + "', " &
            "'" + Trim(abertura) + "','" + user + "','0',''"

        SQL3 = "INSERT INTO LAVDECO (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()
            MetroMessageBox.Show(Me, "Registro guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

        Call verifica_fecha()
        cblinea.Text = ""
        cbdeco.Text = Nothing
        txtabertura.Text = ""

        buscadatos(movimiento)


    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub conexion()
        conex("LAVADERO")
    End Sub

    Private Sub buscadatos(ByVal ingegr As String)
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql1 = "SELECT lavdeco_id as ID,lavdeco_fecha as Fecha,lavdeco_ingegr as Mov,lavdeco_linea as Linea,lavdeco_turno as Turno,lavdeco_grupo as Grupo " &
                ",lavdeco_deco as Decorativo,lavdeco_abertura as Abertura from LAVDECO where  LAVDECO_INGEGR='" + ingegr + "' and LAVDECO_FECHA>='" + fechaant + "' and LAVDECO_FECHA<='" + fch + "' and LAVDECO_bajaid='0' order by LAVDECO_fecha"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        Select Case ingegr
            Case "I"
                dgIng.DataSource = dt1
                dgIng.Columns("ID").Visible = False
            Case "E"
                dgEgr.DataSource = dt1
                dgEgr.Columns("ID").Visible = False
            Case "R"
                dgSeg.DataSource = dt1
                dgSeg.Columns("ID").Visible = False
            Case "L"
                dgLav.DataSource = dt1
                dgLav.Columns("ID").Visible = False
            Case "A"
                dgArm.DataSource = dt1
                dgArm.Columns("ID").Visible = False
        End Select
    End Sub

    Private Sub eliminalinea(ByVal solapa As String)

        'elimina la fila de la grilla
        sql4 = "select LAVDECO_userid from LAVDECO where LAVDECO_id='" + Trim(line) + "' and LAVDECO_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
            dt4 = New DataTable
            da4.Fill(dt4)
            Dim n As Integer
            n = dt4.Rows.Count


        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            sql4 = "update LAVDECO set LAVDECO_bajaid='" + user + "', LAVDECO_bajafch='" + Now + "' where LAVDECO_id='" + Trim(line) + "'"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call buscadatos(movimiento)
            If dt1.Rows.Count <> 0 Then
                'dg.Select(0)
            Else

            End If
        End If

    End Sub

    Private Sub DataGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgIng.Click, dgEgr.Click, dgLav.Click, dgSeg.Click, dgArm.Click
        If sender.SelectedRows.Count = 1 Then
            line = sender.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        buscadatos("I")
        buscadatos("E")
        buscadatos("R")
        buscadatos("L")
        buscadatos("A")


    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged


        If TabControl1.SelectedIndex = 0 Then
            'Ingreso
            rbIng.Checked = True

        ElseIf TabControl1.SelectedIndex = 1 Then
            'Egreso
            rbEgr.Checked = True

        ElseIf TabControl1.SelectedIndex = 2 Then
            'Repara
            rbSeg.Checked = True


        ElseIf TabControl1.SelectedIndex = 3 Then
            'Lavado
            rbLav.Checked = True


        ElseIf TabControl1.SelectedIndex = 4 Then
            'Armado
            rbArm.Checked = True


        End If
    End Sub

    Private Sub txtabertura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtabertura.KeyPress
        'Entero
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub radioButtons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIng.CheckedChanged, rbEgr.CheckedChanged, rbArm.CheckedChanged, rbSeg.CheckedChanged, rbLav.CheckedChanged
        If rbIng.Checked Or rbEgr.Checked Then
            pnlLinea.Visible = True
            pnlAbertura.Visible = True
            txtabertura.Text = Nothing
        ElseIf rbSeg.Checked Or rbLav.Checked Or rbArm.Checked Then
            pnlLinea.Visible = False
            pnlAbertura.Visible = False
            txtabertura.Text = Nothing
        End If

        Select Case sender.name
            Case "rbIng"
                TabControl1.SelectedTab = tpIng
                movimiento = "I"
            Case "rbEgr"
                TabControl1.SelectedTab = tpEgr
                movimiento = "E"
            Case "rbSeg"
                TabControl1.SelectedTab = tpSeg
                movimiento = "R"
            Case "rbLav"
                TabControl1.SelectedTab = tpLav
                movimiento = "L"
            Case "rbArm"
                TabControl1.SelectedTab = tpArm
                movimiento = "A"
        End Select
    End Sub

    Private Sub dataGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgIng.KeyUp, dgArm.KeyUp, dgSeg.KeyUp, dgLav.KeyUp, dgArm.KeyUp
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
                        Call eliminalinea(movimiento)
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "No se pueden eliminar cargas de días anteriores", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub
End Class