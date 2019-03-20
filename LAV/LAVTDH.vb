Imports System.Data.SqlClient
Imports MetroFramework

Public Class LAVTDH
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim movimiento As Char
    Dim cantidad, MaxCtrl As Integer

    Private Sub LAVTDH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call verifica_fecha()

        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto
        rblavado.Checked = True
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
        If String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Or String.IsNullOrEmpty(cblinea.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar los campos Turno, Grupo y Linea", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        '*****************LAVADO DE TEJIDOS****************
        If rblavado.Checked = True Then
            If String.IsNullOrEmpty(txtcantidad.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar cantidad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                campos = "LAVTDH_fecha,LAVTDH_ingegr,LAVTDH_linea,LAVTDH_turno,LAVTDH_grupo,LAVTDH_cantidad,LAVTDH_userid,LAVTDH_bajaid,LAVTDH_bajafch"
                variables = "'" + Now + "','L','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + txtcantidad.Text + "', " &
                "'" + user + "','0',''"


            End If

            '*****************SEGREGADO DE TEJIDOS PARA REPARACION****************
        ElseIf rbrepara.Checked = True Then

            If String.IsNullOrEmpty(txttejido.Text) Or String.IsNullOrEmpty(cbrazon.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar tejido y razón", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                campos = "LAVTDH_fecha,LAVTDH_ingegr,LAVTDH_linea,LAVTDH_turno,LAVTDH_grupo,LAVTDH_ntejido,LAVTDH_razon,LAVTDH_userid,LAVTDH_bajaid,LAVTDH_bajafch"
                variables = "'" + Now + "','R','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + txttejido.Text + "', " &
                "'" + cbrazon.Text + "','" + user + "','0',''"

            End If


            '*****************CAMBIO DE TEJIDOS****************
        ElseIf rbcambio.Checked = True Then

            If String.IsNullOrEmpty(txtcantidad.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar cantidad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                campos = "LAVTDH_fecha,LAVTDH_ingegr,LAVTDH_linea,LAVTDH_turno,LAVTDH_grupo,LAVTDH_cantidad,LAVTDH_userid,LAVTDH_bajaid,LAVTDH_bajafch"
                variables = "'" + Now + "','C','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + txtcantidad.Text + "', " &
                "'" + user + "','0',''"


            End If


            '*****************COLOCACIÓN DE TEJIDOS Nuevo****************
        ElseIf rbnuevos.Checked = True Then

            If String.IsNullOrEmpty(txttejido.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar tejido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                campos = "LAVTDH_fecha,LAVTDH_ingegr,LAVTDH_linea,LAVTDH_turno,LAVTDH_grupo,LAVTDH_ntejido,LAVTDH_userid,LAVTDH_bajaid,LAVTDH_bajafch"
                variables = "'" + Now + "','N','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + txttejido.Text + "', " &
                "'" + user + "','0',''"


            End If


            '*****************TEJIDOS DADOS DE BAJA****************
        ElseIf rbbaja.Checked = True Then

            If String.IsNullOrEmpty(txttejido.Text) Or String.IsNullOrEmpty(cbrazon.Text) Or String.IsNullOrEmpty(cbdestino.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                campos = "LAVTDH_fecha,LAVTDH_ingegr,LAVTDH_linea,LAVTDH_turno,LAVTDH_grupo,LAVTDH_ntejido,LAVTDH_razon,LAVTDH_destino,LAVTDH_userid,LAVTDH_bajaid,LAVTDH_bajafch"
                variables = "'" + Now + "','B','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + txttejido.Text + "', " &
                "'" + cbrazon.Text + "','" + cbdestino.Text + "','" + user + "','0',''"

            End If
        End If

        'GUARDAR
        SQL3 = "INSERT INTO LAVTDH (" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()
        MetroMessageBox.Show(Me, "Registro guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

        Call verifica_fecha()

        cblinea.Text = Nothing
        txtcantidad.Text = Nothing
        txttejido.Text = Nothing
        cbrazon.Text = Nothing
        cbdestino.Text = Nothing

        Call buscadatos(movimiento)

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

        sql1 = "SELECT lavthd_id as ID, lavtdh_fecha as Fecha,lavtdh_ingegr as Mov,lavtdh_linea as Linea,lavtdh_turno as Turno,lavtdh_grupo as Grupo " &
                ",lavtdh_cantidad as Cantidad,lavtdh_ntejido as NTejido,lavtdh_razon as Razon,lavtdh_destino as Destino  from LAVTDH  " &
            "where  LAVTDH_INGEGR='" + ingegr + "' and LAVTDH_FECHA>='" + fechaant + "' and LAVTDH_FECHA<='" + fch + "' and LAVTDH_bajaid='0' order by LAVTDH_fecha"
        da1 = New SqlDataAdapter(sql1, cnn)
            dt1 = New DataTable
        da1.Fill(dt1)

        Select Case ingegr
            Case "L"
                dgLav.DataSource = dt1
                dgLav.Columns("ID").Visible = False
            Case "R"
                dgRepara.DataSource = dt1
                dgRepara.Columns("ID").Visible = False
            Case "C"
                dgCambio.DataSource = dt1
                dgCambio.Columns("ID").Visible = False
            Case "N"
                dgNuevo.DataSource = dt1
                dgNuevo.Columns("ID").Visible = False
            Case "B"
                dgBaja.DataSource = dt1
                dgBaja.Columns("ID").Visible = False
        End Select


    End Sub

    Private Sub eliminalinea(ByVal solapa As String)
        'elimina la fila de la grilla
        sql4 = "select LAVTDH_userid from LAVTDH where LAVTDH_id='" + Trim(line) + "' and LAVTDH_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count

        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            sql4 = "update LAVTDH set LAVTDH_bajaid='" + user + "', LAVTDH_bajafch='" + Now + "' where LAVTDH_id='" + Trim(line) + "'"
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

    Private Sub DataGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLav.Click, dgRepara.Click, dgCambio.Click, dgNuevo.Click, dgBaja.Click
        If sender.SelectedRows.Count = 1 Then
            line = sender.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dataGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgLav.KeyUp, dgRepara.KeyUp, dgCambio.KeyUp, dgNuevo.KeyUp, dgBaja.KeyUp
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

    Private Sub Enteros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress, txttejido.KeyPress
        'Entero
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub radioButtons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcambio.CheckedChanged, rbrepara.CheckedChanged, rblavado.CheckedChanged, rbnuevos.CheckedChanged, rbbaja.CheckedChanged
        pnlcant.Visible = False
        pnltejido.Visible = True
        pnldestino.Visible = False
        pnlrazon.Visible = False

        If rbcambio.Checked Or rblavado.Checked Then
            pnlcant.Visible = True
            pnltejido.Visible = False
            pnltejido.Visible = False

        ElseIf rbrepara.Checked Then
            pnlrazon.Visible = True
            Call llenaRazSeg()
        ElseIf rbbaja.Checked Then
            pnlrazon.Visible = True
            pnldestino.Visible = True
            Call llenaRazBaja()
            Call llenaDestBaja()

        End If

        Select Case sender.name
            Case "rblavado"
                TabControl1.SelectedTab = tplavado
                movimiento = "L"
            Case "rbrepara"
                TabControl1.SelectedTab = tprepara
                movimiento = "R"
            Case "rbcambio"
                TabControl1.SelectedTab = tpcambio
                movimiento = "C"
            Case "rbnuevos"
                TabControl1.SelectedTab = tpnuevo
                movimiento = "N"
            Case "rbbaja"
                TabControl1.SelectedTab = tpbaja
                movimiento = "B"
        End Select
    End Sub

    Private Sub llenaRazSeg()
        cbrazon.Refresh()
        Call conex("lavrazondest")
        sql = "SELECT * From LAVRAZONDEST where lavrd_cod='TDHSEG' and lavrd_combo='R' order by lavrd_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        cbrazon.DataSource = dt
        cbrazon.DisplayMember = "lavrd_desc"
        cbrazon.ValueMember = "lavrd_desc"

    End Sub

    Private Sub llenaRazBaja()
        cbrazon.Refresh()
        Call conex("lavrazondest")
        sql = "SELECT * From LAVRAZONDEST where lavrd_cod='TDHBAJA' and lavrd_combo='R' order by lavrd_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        cbrazon.DataSource = dt
        cbrazon.DisplayMember = "lavrd_desc"
        cbrazon.ValueMember = "lavrd_desc"

    End Sub

    Private Sub llenaDestBaja()
        cbdestino.Refresh()
        Call conex("lavrazondest")
        sql = "SELECT * From LAVRAZONDEST where lavrd_cod='TDHBAJA' and lavrd_combo='D' order by lavrd_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        cbdestino.DataSource = dt
        cbdestino.DisplayMember = "lavrd_desc"
        cbdestino.ValueMember = "lavrd_desc"

    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos("L")
        Call buscadatos("R")
        Call buscadatos("C")
        Call buscadatos("N")
        Call buscadatos("B")
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            'Lavado
            rblavado.Checked = True
        ElseIf TabControl1.SelectedIndex = 1 Then
            'Reparación
            rbrepara.Checked = True
        ElseIf TabControl1.SelectedIndex = 2 Then
            'Cambio
            rbcambio.Checked = True
        ElseIf TabControl1.SelectedIndex = 3 Then
            'Nuevo
            rbnuevos.Checked = True
        ElseIf TabControl1.SelectedIndex = 4 Then
            'Baja
            rbbaja.Checked = True
        End If
    End Sub

End Class