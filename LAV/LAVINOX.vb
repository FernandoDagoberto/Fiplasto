Imports System.Data.SqlClient
Imports MetroFramework

Public Class LAVINOX
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String
    Dim movimiento As Char
    Dim cantidad, MaxCtrl, linedgI, linedgII As Integer
    Dim cantIng, cantEgr, cantSeg, cantLav, cantArm, cantnuevos, cantbaja As String
    Dim dtLineaI, dtLineaII As DataTable


    Private Sub LAVINOX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        verifica_fecha()
        CargaTurnoAuto()
        cbturno.Text = TurnoAuto
        InoxEnLinea()
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

        'chequeo linea,placa y abertura
        If String.IsNullOrEmpty(cblinea.Text) Or String.IsNullOrEmpty(cbInox.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cblinea.Focus()
            Exit Sub
        End If

        'chequeo línea 1 (24 aberturas), línea 2 (30)

        If rbIng.Checked = True Then
            If String.IsNullOrEmpty(txtabertura.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar campo Abertura", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        If rbEgr.Checked Then
            If String.IsNullOrEmpty(cbabertura.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar campo Abertura", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbabertura.Focus()

                Exit Sub
            End If
        End If


        Try
            '*****************Ingreso DE INOXIDABLES A PRENSA****************
            If rbIng.Checked = True Then
                'Controla que la abertura o el inoxidable no estén cargados
                sql = "select * from LAVENLINEA where lavenlinea_linea='" + cblinea.Text + "' " &
            "and (lavenlinea_abertura='" + txtabertura.Text + "' or lavenlinea_numero='" + cbInox.Text + "')  and lavenlinea_opcion='INOX'"
                da = New SqlDataAdapter(sql, cnn)
                dt = New DataTable
                da.Fill(dt)
                n = dt.Rows.Count
                If n > 0 Then
                    MetroMessageBox.Show(Me, "La abertura: " + Trim(Str(dt.Rows(0).Item("lavenlinea_abertura"))) + "  tiene el inoxidable Nº: " + Trim(Str(dt.Rows(0).Item("lavenlinea_numero"))) + "  ingresado en línea: '" + dt.Rows(0).Item("lavenlinea_linea") + "'", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtabertura.Focus()
                    Exit Sub
                End If

                'Guardo el nuevo Ingreso en la tabla temporal LAVENLINEA
                campos = "lavenlinea_linea, lavenlinea_numero,lavenlinea_abertura,lavenlinea_opcion"
                variables = "'" + cblinea.Text + "','" + cbInox.Text + "','" + txtabertura.Text + "','INOX'"
                SQL3 = "INSERT INTO LAVENLINEA (" + campos + ") VALUES (" + variables + ")"
                cmd3 = New SqlCommand(SQL3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()


                campos = "LAVINOX_fecha, LAVINOX_ingegr, LAVINOX_linea, LAVINOX_turno, LAVINOX_grupo, LAVINOX_ninox, LAVINOX_abertura, LAVINOX_userid, LAVINOX_bajaid,LAVINOX_bajafch"
                variables = "'" + Now + "','" + movimiento + "','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbInox.Text + "', " &
            "'" + txtabertura.Text + "','" + user + "','0',''"

                '*****************EGRESO DE INOXIDABLES DE PRENSA****************
            ElseIf rbEgr.Checked = True Then

                campos = "LAVINOX_fecha, LAVINOX_ingegr, LAVINOX_linea, LAVINOX_turno, LAVINOX_grupo, LAVINOX_ninox, LAVINOX_abertura, LAVINOX_razon, LAVINOX_userid, LAVINOX_bajaid,LAVINOX_bajafch"
                variables = "'" + Now + "','" + movimiento + "','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbInox.Text + "', " &
            "'" + cbabertura.Text + "','" + cbrazon.Text + "','" + user + "','0',''"

                'Elimino la Chapa de la tabla temporal LAVENLINEA
                SQL3 = "delete from LAVENLINEA where lavenlinea_linea='" + cblinea.Text + "' and lavenlinea_numero='" + cbInox.Text + "' " &
            "and lavenlinea_abertura='" + cbabertura.Text + "' and lavenlinea_opcion='INOX'"
                cmd3 = New SqlCommand(SQL3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()

                '*****************SEGREGADO DE INOXIDABLES PARA REPARACIÓN****************
            ElseIf rbSeg.Checked = True Then

                campos = "LAVINOX_fecha, LAVINOX_ingegr, LAVINOX_linea, LAVINOX_turno, LAVINOX_grupo, LAVINOX_ninox, LAVINOX_razon, LAVINOX_userid, LAVINOX_bajaid,LAVINOX_bajafch"
                variables = "'" + Now + "','" + movimiento + "','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbInox.Text + "', " &
            "'" + cbrazon.Text + "','" + user + "','0',''"


                '*****************LAVADO DE INOXIDABLES ****************
            ElseIf rbLav.Checked = True Then

                campos = "LAVINOX_fecha, LAVINOX_ingegr, LAVINOX_linea, LAVINOX_turno, LAVINOX_grupo, LAVINOX_ninox, LAVINOX_userid, LAVINOX_bajaid,LAVINOX_bajafch"
                variables = "'" + Now + "','" + movimiento + "','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbInox.Text + "', " &
            "'" + user + "','0',''"


            ElseIf rbArm.Checked = True Then

                Dim fino, grueso As String

                If chkfino.Checked = True Then
                    fino = "S"
                End If

                If chkgrueso.Checked = True Then
                    grueso = "S"
                End If

                campos = "LAVINOX_fecha, LAVINOX_ingegr, LAVINOX_linea, LAVINOX_turno, LAVINOX_grupo, LAVINOX_ninox,LAVINOX_fino,LAVINOX_grueso, LAVINOX_userid, LAVINOX_bajaid,LAVINOX_bajafch"
                variables = "'" + Now + "','" + movimiento + "','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbInox.Text + "', " &
            "'" + fino + "','" + grueso + "','" + user + "','0',''"

            End If



            'GUARDO LOS DATOS
            SQL3 = "INSERT INTO LAVINOX (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()
            MetroMessageBox.Show(Me, "Registro guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

            Call verifica_fecha()

            cblinea.Text = ""
            cbInox.DataSource = Nothing
            chkfino.Checked = False
            chkgrueso.Checked = False
            Call buscadatos(movimiento)

            InoxEnLinea()


        Catch ex As Exception
            MetroMessageBox.Show(Me, "No se pudieron gurdar los datos " & Chr(13) & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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

        sql1 = "SELECT lavinox_id as ID, lavinox_fecha as Fecha,lavinox_ingegr as Mov,lavinox_linea as Linea,lavinox_turno as Turno,lavinox_grupo as Grupo " &
                ",lavinox_ninox as NInox,lavinox_abertura as Abertura,lavinox_razon as Razon,lavinox_fino as Fino,lavinox_grueso as Grueso from LAVINOX " &
                " where  LAVINOX_INGEGR='" + ingegr + "' and LAVINOX_FECHA>='" + fechaant + "' and LAVINOX_FECHA<='" + fch + "' and LAVINOX_bajaid='0' order by LAVINOX_fecha"
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
        If solapa = "I" Then
            sql4 = "Select * from LAVENLINEA where lavenlinea_linea='" + dgIng.CurrentRow.Cells("Linea").Value + "' " &
          "and lavenlinea_numero='" + trim(dgIng.CurrentRow.Cells("NInox").Value) + "' " &
          "and lavenlinea_abertura= '" + trim(dgIng.CurrentRow.Cells("Abertura").Value) + "' and lavenlinea_opcion='INOX'"
            da4 = New SqlDataAdapter(sql4, cnn)
            dt4 = New DataTable
            da4.Fill(dt4)
            Dim n As Integer
            n = dt4.Rows.Count
            If n = 0 Then
                MetroMessageBox.Show(Me, "Este Inoxidable tiene un movimiento de egreso. Debe eliminar el egreso antes de borrar este movimiento", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'elimina la fila de la grilla
            sql4 = "select LAVINOX_userid from LAVINOX where LAVINOX_id='" + Trim(line) + "' and LAVINOX_userid='" + user + "'"
            da4 = New SqlDataAdapter(sql4, cnn)
            dt4 = New DataTable
            da4.Fill(dt4)
            n = dt4.Rows.Count

            If n = 0 Then
                MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql4 = "update LAVINOX set LAVINOX_bajaid='" + user + "', LAVINOX_bajafch='" + Now + "' where LAVINOX_id='" + Trim(line) + "'"
                cmd4 = New SqlCommand(sql4, cnn)
                cmd4.Connection.Open()
                cmd4.ExecuteNonQuery()
                cmd4.Connection.Close()

                'Elimino la fila de la tabla temporal LAVENLINEA así no aparece como opción en el egreso
                sql4 = "delete from LAVENLINEA where lavenlinea_linea='" + dgIng.CurrentRow.Cells("Linea").Value + "' " &
                "and lavenlinea_numero='" + trim(dgIng.CurrentRow.Cells("NInox").Value) + "' " &
                "and lavenlinea_abertura= '" + trim(dgIng.CurrentRow.Cells("Abertura").Value) + "' and lavenlinea_opcion='INOX'"
                cmd4 = New SqlCommand(sql4, cnn)
                cmd4.Connection.Open()
                cmd4.ExecuteNonQuery()
                cmd4.Connection.Close()

            End If

        ElseIf solapa = "E" Then

            'elimina la fila de la grilla
            sql4 = "select LAVINOX_userid from LAVINOX where LAVINOX_id='" + Trim(line) + "' and LAVINOX_userid='" + user + "'"
            da4 = New SqlDataAdapter(sql4, cnn)
            dt4 = New DataTable
            da4.Fill(dt4)
            Dim n As Integer
            n = dt4.Rows.Count
            If n = 0 Then
                MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Inserto la fila eliminada en la tabla temporal LAVENLINEA así vuelve a aparecer como opción en el egreso
                sql1 = "INSERT INTO LAVENLINEA (lavenlinea_linea,lavenlinea_numero,lavenlinea_abertura,lavenlinea_opcion) " &
                "Values ('" + dgEgr.CurrentRow.Cells("Linea").Value + "', " &
                "'" + Trim(dgEgr.CurrentRow.Cells("NInox").Value) + "', " &
                "'" + Trim(dgEgr.CurrentRow.Cells("Abertura").Value) + "' ,'INOX')"
                cmd1 = New SqlCommand(sql1, cnn)
                cmd1.Connection.Open()
                cmd1.ExecuteNonQuery()
                cmd1.Connection.Close()

                sql4 = "update LAVINOX set LAVINOX_bajaid='" + user + "', LAVINOX_bajafch='" + Now + "' where LAVINOX_id='" + Trim(line) + "'"
                cmd4 = New SqlCommand(sql4, cnn)
                cmd4.Connection.Open()
                cmd4.ExecuteNonQuery()
                cmd4.Connection.Close()
            End If

        Else
            'elimina la fila de la grilla
            sql4 = "select LAVINOX_userid from LAVINOX where LAVINOX_id='" + Trim(line) + "' and LAVINOX_userid='" + user + "'"
            da4 = New SqlDataAdapter(sql4, cnn)
            dt4 = New DataTable
            da4.Fill(dt4)
            Dim n As Integer
            n = dt4.Rows.Count

            If n = 0 Then
                MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql4 = "update LAVINOX set LAVINOX_bajaid='" + user + "', LAVINOX_bajafch='" + Now + "' where LAVINOX_id='" + Trim(line) + "'"
                cmd4 = New SqlCommand(sql4, cnn)
                cmd4.Connection.Open()
                cmd4.ExecuteNonQuery()
                cmd4.Connection.Close()
            End If

        End If


        buscadatos(movimiento)
        InoxEnLinea()

    End Sub

    Private Sub llenaRazEgr()
        cbrazon.Refresh()
        Call conex("lavrazondest")
        sql = "SELECT * From LAVRAZONDEST where lavrd_cod='INOXEGR' and lavrd_combo='R' order by lavrd_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        cbrazon.DataSource = dt
        cbrazon.DisplayMember = "lavrd_desc"
        cbrazon.ValueMember = "lavrd_desc"

    End Sub

    Private Sub radioButtons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIng.CheckedChanged, rbEgr.CheckedChanged, rbArm.CheckedChanged, rbSeg.CheckedChanged, rbLav.CheckedChanged
        pnlInox.Visible = True
        cbInox.DataSource = Nothing
        txtabertura.Text = Nothing
        chkfino.Checked = False
        chkgrueso.Checked = False

        If rbIng.Checked Then
            pnlAbertura.Visible = True
            txtabertura.Visible = True
            cbabertura.Visible = False
            pnlrazon.Visible = False
            pnlCambio.Visible = False

        ElseIf rbEgr.Checked Then
            pnlAbertura.Visible = True
            txtabertura.Visible = False
            cbabertura.Visible = True
            pnlrazon.Visible = True
            pnlCambio.Visible = False
            Call llenaRazEgr()
        ElseIf rbSeg.Checked Then
            pnlAbertura.Visible = False
            pnlrazon.Visible = True
            pnlCambio.Visible = False
            Call llenaRazSeg()

        ElseIf rbLav.Checked Then
            pnlAbertura.Visible = False
            pnlrazon.Visible = False
            pnlCambio.Visible = False

        ElseIf rbArm.Checked Then
            pnlAbertura.Visible = False
            pnlrazon.Visible = False
            pnlCambio.Visible = True

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

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos("I")
        Call buscadatos("E")
        Call buscadatos("R")
        Call buscadatos("L")
        Call buscadatos("A")

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

    Private Sub DataGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgIng.Click, dgEgr.Click, dgLav.Click, dgSeg.Click, dgArm.Click
        If sender.SelectedRows.Count = 1 Then
            line = sender.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dataGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgIng.KeyUp, dgEgr.KeyUp, dgSeg.KeyUp, dgLav.KeyUp, dgArm.KeyUp
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

    Private Sub txtabertura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtabertura.KeyPress
        'Entero
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cblinea_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cblinea.SelectionChangeCommitted
        If rbEgr.Checked = True Then
            Call llenonum(cblinea.Text)
        Else
            Call llenoItem(cblinea.Text)
            If n = 0 Then
            Else
                cbInox.DataSource = dt
                cbInox.DisplayMember = "lavmainox_inox"
                cbInox.ValueMember = "lavmainox_inox"
            End If
        End If
    End Sub

    Private Sub llenonum(ByVal linea As Integer)
        Call conex("LAVENLINEA")
        sql = "SELECT * From LAVENLINEA where LAVENLINEA_LINEA='" + Trim(Str(linea)) + "' and LAVENLINEA_OPCION='INOX' order by LAVENLINEA_NUMERO"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

        If n = 0 Then
            cbInox.DataSource = Nothing
            cbabertura.DataSource = Nothing
        Else
            cbInox.DataSource = dt
            cbInox.DisplayMember = "lavenlinea_numero"
            cbInox.ValueMember = "lavenlinea_numero"

            cbabertura.DataSource = dt
            cbabertura.DisplayMember = "lavenlinea_abertura"
            cbabertura.ValueMember = "lavenlinea_abertura"

        End If

    End Sub

    Private Sub llenoItem(ByVal linea As Integer)
        Call conex("LAVMAINOX")
        sql = "SELECT * From LAVMAINOX where LAVMAINOX_LINEA='" + Trim(Str(linea)) + "' order by LAVMAINOX_INOX"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

    End Sub

    Private Sub llenaRazSeg()
        cbrazon.Refresh()
        Call conex("lavrazondest")
        sql = "SELECT * From LAVRAZONDEST where lavrd_cod='INOXSEG' and lavrd_combo='R' order by lavrd_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        cbrazon.DataSource = dt
        cbrazon.DisplayMember = "lavrd_desc"
        cbrazon.ValueMember = "lavrd_desc"

    End Sub

    Public Function llenoInoxEnLinea(ByVal linea As Integer) As DataTable
        Call conex("LAVMAINOX")
        sql22 = "SELECT lavenlinea_linea as Linea, lavenlinea_abertura as Abertura,lavenlinea_numero as NInox From LAVENLINEA where LAVENLINEA_LINEA='" + Trim(Str(linea)) + "' and LAVENLINEA_OPCION='INOX' order by LAVENLINEA_ABERTURA "
        da22 = New SqlDataAdapter(sql22, cnn)
        dt22 = New DataTable
        da22.Fill(dt22)
        If dt22.Rows.Count > 0 Then
            Return dt22
        Else
            Return Nothing
        End If


    End Function

    Sub InoxEnLinea()
        'Muestra en los datagrid de la derecha todos los inoxidables que se encuentran en la línea

        dtLineaI = llenoInoxEnLinea(1)
        If dtLineaI IsNot Nothing Then
            dgLineaI.DataSource = dtLineaI
            dgLineaI.Columns("Linea").Visible = False
        Else
            dgLineaI.DataSource = Nothing
        End If


        dtLineaII = llenoInoxEnLinea(2)
        If dtLineaII IsNot Nothing Then
            dgLineaII.DataSource = dtLineaII
            dgLineaII.Columns("Linea").Visible = False
        Else
            dgLineaII.DataSource = Nothing
        End If

    End Sub

    Private Sub cbInox_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbInox.SelectionChangeCommitted
        If rbEgr.Checked = True Then
            Call conex("LAVENLINEA")
            sql = "SELECT * From LAVENLINEA where LAVENLINEA_LINEA='" + cblinea.Text + "' and  lavenlinea_numero='" + cbInox.Text + "' and LAVENLINEA_OPCION='INOX' order by LAVENLINEA_NUMERO"
            da = New SqlDataAdapter(sql, cnn)
            dt = New DataTable
            da.Fill(dt)
            n = dt.Rows.Count

            If n = 0 Then
                cbInox.DataSource = Nothing
                cbabertura.DataSource = Nothing
            Else
                cbabertura.DataSource = dt
                cbabertura.DisplayMember = "lavenlinea_abertura"
                cbabertura.ValueMember = "lavenlinea_abertura"
            End If
        End If
    End Sub

    Private Sub cbabertura_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbabertura.SelectionChangeCommitted
        If rbEgr.Checked = True Then
            Call conex("LAVENLINEA")
            sql = "SELECT * From LAVENLINEA where LAVENLINEA_LINEA='" + cblinea.Text + "' and  lavenlinea_abertura='" + cbabertura.Text + "' and LAVENLINEA_OPCION='INOX' order by LAVENLINEA_NUMERO"
            da = New SqlDataAdapter(sql, cnn)
            dt = New DataTable
            da.Fill(dt)
            n = dt.Rows.Count

            If n = 0 Then
                cbInox.DataSource = Nothing
                cbabertura.DataSource = Nothing
            Else
                cbInox.DataSource = dt
                cbInox.DisplayMember = "lavenlinea_numero"
                cbInox.ValueMember = "lavenlinea_numero"

            End If
        End If
    End Sub

    Private Sub dgLineaI_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLineaI.CellClick
        If dgLineaI.SelectedRows.Count = 1 Then
            linedgI = dgLineaI.CurrentRow.Cells("Abertura").Value
        End If
    End Sub

    Private Sub dgLineaI_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLineaI.CellDoubleClick
        'Para completar los datos con la selección de la grilla
        'Linea 1
        Egreso(1)
    End Sub

    Sub Egreso(ByVal linea As Integer)
        If linea = 1 Then
            If dgLineaI.SelectedRows.Count = 1 Then
                rbEgr.Checked = True
                cblinea.Text = dgLineaI.CurrentRow.Cells("Linea").Value
                cblinea_SelectionChangeCommitted(Nothing, Nothing)
                cbabertura.Text = linedgI
            End If

        ElseIf linea = 2 Then
            If dgLineaII.SelectedRows.Count = 1 Then
                rbEgr.Checked = True
                cblinea.Text = dgLineaII.CurrentRow.Cells("Linea").Value
                cblinea_SelectionChangeCommitted(Nothing, Nothing)
                cbabertura.Text = linedgII
            End If

        End If

    End Sub

    Private Sub dgLineaII_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLineaII.CellClick
        If dgLineaII.SelectedRows.Count = 1 Then
            linedgII = dgLineaII.CurrentRow.Cells("Abertura").Value
        End If
    End Sub

    Private Sub dgLineaII_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLineaII.CellDoubleClick
        'Para completar los datos con la selección de la grilla
        'Linea 2
        Egreso(2)
    End Sub

End Class