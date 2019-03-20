Imports System.Data.SqlClient
Imports MetroFramework

Public Class LAVCHTR
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String
    Dim cantidad, MaxCtrl, linedgI, linedgII As Integer
    Dim cantIng, cantEgr, cantDes, cantnuevos, cantbaja As String
    Dim dtLineaI, dtLineaII As DataTable

    Private Sub LAVCHTR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call verifica_fecha()

        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto

        ChtrEnLinea()

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

        '*****************Ingreso DE CHAPAS DE TRANSPORTE****************
        If rbIng.Checked = True Then
            If String.IsNullOrEmpty(cblinea.Text) Or String.IsNullOrEmpty(txtchapa.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else

                sql = "select * from LAVENLINEA where lavenlinea_numero='" + txtchapa.Text + "' " &
                "and lavenlinea_opcion='CHTR'"
                da = New SqlDataAdapter(sql, cnn)
                dt = New DataTable
                da.Fill(dt)
                n = dt.Rows.Count
                If n > 0 Then
                    MetroMessageBox.Show(Me, "Este número de chapa ya se encuentra en Línea", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtchapa.Focus()
                    Exit Sub
                End If

                campos = "lavchtr_fecha,lavchtr_ingegr,LAVCHTR_linea,LAVCHTR_turno,LAVCHTR_grupo,LAVCHTR_nchapa,LAVCHTR_userid,LAVCHTR_bajaid,LAVCHTR_bajafch"
                variables = "'" + Now + "','I','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + txtchapa.Text + "', " &
                "'" + user + "','0',''"

                SQL3 = "INSERT INTO LAVCHTR (" + campos + ") VALUES (" + variables + ")"
                cmd3 = New SqlCommand(SQL3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()
                MetroMessageBox.Show(Me, "Registro guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtchapa.Focus()

                'Guardo el nuevo Ingreso en la tabla temporal LAVENLINEA
                campos = "lavenlinea_linea, lavenlinea_numero,lavenlinea_opcion"
                variables = "'" + cblinea.Text + "','" + txtchapa.Text + "','CHTR'"
                SQL3 = "INSERT INTO LAVENLINEA (" + campos + ") VALUES (" + variables + ")"
                cmd3 = New SqlCommand(SQL3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()

                Call verifica_fecha()

                cblinea.Text = ""
                txtchapa.Text = ""

                Call buscadatos("I")

            End If

            '*****************EGRESO DE CHAPAS DE TRANSPORTE****************
        ElseIf rbEgr.Checked = True Then

            If String.IsNullOrEmpty(cblinea.Text) Or String.IsNullOrEmpty(cbchapa.Text) Or String.IsNullOrEmpty(cbrazon.Text) Or String.IsNullOrEmpty(cbdestino.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                campos = "lavchtr_fecha,lavchtr_ingegr,LAVCHTR_linea,LAVCHTR_turno,LAVCHTR_grupo,LAVCHTR_nchapa,LAVCHTR_razon,LAVCHTR_destino,LAVCHTR_userid,LAVCHTR_bajaid,LAVCHTR_bajafch"
                variables = "'" + Now + "','E','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbchapa.Text + "', " &
                "'" + cbrazon.Text + "','" + cbdestino.Text + "','" + user + "','0',''"

                SQL3 = "INSERT INTO LAVCHTR (" + campos + ") VALUES (" + variables + ")"
                cmd3 = New SqlCommand(SQL3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()
                MetroMessageBox.Show(Me, "Registro guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

                'Elimino la Chapa de la tabla temporal LAVENLINEA
                SQL3 = "delete from LAVENLINEA where lavenlinea_linea='" + cblinea.Text + "' and lavenlinea_numero='" + cbchapa.Text + "' " &
                "and lavenlinea_opcion='CHTR'"
                cmd3 = New SqlCommand(SQL3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()

                Call llenonum(cblinea.Text)

                Call verifica_fecha()

                cblinea.Text = ""
                txtchapa.Text = ""

                Call buscadatos("E")

            End If


            '*****************DESABOLLADO DE CHAPAS****************
        ElseIf rbDes.Checked = True Then

            If String.IsNullOrEmpty(cblinea.Text) Or String.IsNullOrEmpty(txtchapa.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                campos = "LAVCHTR_fecha,lavchtr_ingegr,LAVCHTR_linea,LAVCHTR_turno,LAVCHTR_grupo,LAVCHTR_nchapa,LAVCHTR_userid,LAVCHTR_bajaid,LAVCHTR_bajafch"
                variables = "'" + Now + "','D','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + txtchapa.Text + "', " &
                "'" + user + "','0',''"

                SQL3 = "INSERT INTO LAVCHTR (" + campos + ") VALUES (" + variables + ")"
                cmd3 = New SqlCommand(SQL3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()
                MetroMessageBox.Show(Me, "Registro guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

                Call verifica_fecha()

                cblinea.Text = Nothing
                txtchapa.Text = Nothing

                Call buscadatos("D")

            End If

        End If

        ChtrEnLinea()

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
        sql1 = "SELECT lavchtr_id as ID, lavchtr_fecha as Fecha,lavchtr_ingegr as IngEgr,lavchtr_linea as Linea,lavchtr_turno as Turno,lavchtr_grupo as Grupo " &
                ",lavchtr_nchapa as NChapa,lavchtr_razon as Razon,lavchtr_destino as Destino from LAVCHTR  " &
                "where  LAVCHTR_INGEGR='" + ingegr + "' and LAVCHTR_FECHA>='" + fechaant + "' and LAVCHTR_FECHA<='" + fch + "' and LAVCHTR_bajaid='0' order by LAVCHTR_fecha"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        If ingegr = "I" Then
            dgIng.DataSource = dt1
            dgIng.Columns("ID").Visible = False
        ElseIf ingegr = "E" Then
            dgEgr.DataSource = dt1
            dgEgr.Columns("ID").Visible = False
        Else
            dgDesab.DataSource = dt1
            dgDesab.Columns("ID").Visible = False
        End If

    End Sub

    Private Sub eliminalinea(ByVal solapa As String)

        If solapa = "Ingreso" Then

            sql4 = "Select * from LAVENLINEA where lavenlinea_linea='" + dgIng.CurrentRow.Cells("Linea").Value + "' " &
                "and lavenlinea_numero='" + Trim(Str(dgIng.CurrentRow.Cells("NChapa").Value)) + "' " &
                "and lavenlinea_opcion='CHTR'"
            da4 = New SqlDataAdapter(sql4, cnn)
            dt4 = New DataTable
            da4.Fill(dt4)
            Dim n As Integer
            n = dt4.Rows.Count
            If n = 0 Then
                MetroMessageBox.Show(Me, "Está chapa de transporte tiene un movimiento de egreso. Debe eliminar el egreso antes de borrar este movimiento", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'elimina la fila de la grilla
            sql4 = "select LAVCHTR_userid from LAVCHTR where LAVCHTR_id='" + Trim(line) + "' and LAVCHTR_userid='" + user + "'"
            da4 = New SqlDataAdapter(sql4, cnn)
            dt4 = New DataTable
            da4.Fill(dt4)

            n = dt4.Rows.Count
            If n = 0 Then
                MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql4 = "update LAVCHTR Set LAVCHTR_bajaid='" + user + "', LAVCHTR_bajafch='" + Now + "' where LAVCHTR_id='" + Trim(line) + "'"
                cmd4 = New SqlCommand(sql4, cnn)
                cmd4.Connection.Open()
                cmd4.ExecuteNonQuery()
                cmd4.Connection.Close()

                'Elimino la fila de la tabla temporal LAVENLINEA así no aparece como opción en el egreso
                sql4 = "delete from LAVENLINEA where lavenlinea_linea='" + dgIng.CurrentRow.Cells("Linea").Value + "' " &
                "and lavenlinea_numero='" + Trim(Str(dgIng.CurrentRow.Cells("NChapa").Value)) + "' " &
                "and lavenlinea_opcion='CHTR'"
                cmd4 = New SqlCommand(sql4, cnn)
                cmd4.Connection.Open()
                cmd4.ExecuteNonQuery()
                cmd4.Connection.Close()

                Call buscadatos("I")
                If dt1.Rows.Count <> 0 Then
                    'dg.Select(0)
                Else

                End If
            End If


        ElseIf solapa = "Egreso" Then

            'elimina la fila de la grilla
            sql4 = "select LAVCHTR_userid from LAVCHTR where LAVCHTR_id='" + Trim(line) + "' and LAVCHTR_userid='" + user + "'"
            da4 = New SqlDataAdapter(sql4, cnn)
            dt4 = New DataTable
            da4.Fill(dt4)
            Dim n As Integer
            n = dt4.Rows.Count

            If n = 0 Then
                MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                'Inserto la fila eliminada en la tabla temporal LAVENLINEA así vuelve a aparecer como opción en el egreso

                sql1 = "INSERT INTO LAVENLINEA (lavenlinea_linea,lavenlinea_numero,lavenlinea_opcion) " &
                "Values ('" + dgEgr.CurrentRow.Cells("Linea").Value + "', " &
                "'" + Trim(Str(dgEgr.CurrentRow.Cells("NChapa").Value)) + "','CHTR')"
                cmd1 = New SqlCommand(sql1, cnn)
                cmd1.Connection.Open()
                cmd1.ExecuteNonQuery()
                cmd1.Connection.Close()

                sql4 = "update LAVCHTR set LAVCHTR_bajaid='" + user + "', LAVCHTR_bajafch='" + Now + "' where LAVCHTR_id='" + Trim(line) + "'"
                cmd4 = New SqlCommand(sql4, cnn)
                cmd4.Connection.Open()
                cmd4.ExecuteNonQuery()
                cmd4.Connection.Close()

                Call buscadatos("E")
                If dt1.Rows.Count <> 0 Then
                    'dg.Select(0)
                Else

                End If
            End If



        ElseIf solapa = "Desabollado" Then

            'elimina la fila de la grilla
            sql4 = "select LAVCHTR_userid from LAVCHTR where LAVCHTR_id='" + Trim(line) + "' and LAVCHTR_userid='" + user + "'"
            da4 = New SqlDataAdapter(sql4, cnn)
            dt4 = New DataTable
            da4.Fill(dt4)
            Dim n As Integer
            n = dt4.Rows.Count
            If n = 0 Then
                MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else


                sql4 = "update LAVCHTR set LAVCHTR_bajaid='" + user + "', LAVCHTR_bajafch='" + Now + "' where LAVCHTR_id='" + Trim(line) + "'"
                cmd4 = New SqlCommand(sql4, cnn)
                cmd4.Connection.Open()
                cmd4.ExecuteNonQuery()
                cmd4.Connection.Close()

                Call buscadatos("D")
                If dt5.Rows.Count <> 0 Then
                    'dg.Select(0)
                Else

                End If
            End If

        End If

        ChtrEnLinea()

    End Sub

    Private Sub dgIng_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgIng.Click
        If dgIng.SelectedRows.Count = 1 Then
            line = dgIng.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dgIng_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgIng.KeyUp
        If dgIng.SelectedRows.Count = 1 Then

            If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
            Else
                fechaborra = FormatDateTime(Now, DateFormat.ShortDate)
            End If

            If dtfecha.Text = fechaborra Then
                If e.KeyCode = Keys.Delete Then
                    ms = MetroMessageBox.Show(Me, "¿Desea eliminar la línea seleccionada?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    If ms = 1 Then
                        Call eliminalinea("Ingreso")
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "No se pueden eliminar cargas de días anteriores", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub


    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Entero
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txttejido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchapa.KeyPress
        'Entero
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub rbIng_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIng.CheckedChanged
        If rbIng.Checked = True Then
            pnlchapa.Visible = True
            txtchapa.Visible = True
            cbchapa.Visible = False
            pnlrazon.Visible = False
            pnldestino.Visible = False
            TabControl1.SelectedTab = tpIng
        End If
    End Sub

    Private Sub rbEgr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEgr.CheckedChanged
        If rbEgr.Checked = True Then
            pnlchapa.Visible = True
            txtchapa.Visible = False
            cbchapa.Visible = True

            pnlrazon.Visible = True
            pnldestino.Visible = True

            Call llenaRazEgr()
            Call llenaDestEgr()

            TabControl1.SelectedTab = tpEgr
        End If
    End Sub

    Private Sub llenaRazEgr()
        cbrazon.Refresh()
        Call conex("lavrazondest")
        sql = "SELECT * From LAVRAZONDEST where lavrd_cod='CHTREGR' and lavrd_combo='R' order by lavrd_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        cbrazon.DataSource = dt
        cbrazon.DisplayMember = "lavrd_desc"
        cbrazon.ValueMember = "lavrd_desc"

    End Sub

    Private Sub llenaDestEgr()
        cbdestino.Refresh()
        Call conex("lavrazondest")
        sql = "SELECT * From LAVRAZONDEST where lavrd_cod='CHTREGR' and lavrd_combo='D' order by lavrd_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        cbdestino.DataSource = dt
        cbdestino.DisplayMember = "lavrd_desc"
        cbdestino.ValueMember = "lavrd_desc"

    End Sub

    Private Sub rbDesabollado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDes.CheckedChanged
        If rbDes.Checked = True Then
            pnlchapa.Visible = True
            txtchapa.Visible = True
            cbchapa.Visible = False

            pnldestino.Visible = False
            pnlrazon.Visible = False

            TabControl1.SelectedTab = tpDes
        End If
    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos("I") 'Ingreso
        Call buscadatos("E") 'Egreso
        Call buscadatos("D") 'Desabollado


    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            'Ingreso
            rbIng.Checked = True

        ElseIf TabControl1.SelectedIndex = 1 Then
            'Egresoción
            rbEgr.Checked = True

        ElseIf TabControl1.SelectedIndex = 2 Then
            'Desabollado
            rbDes.Checked = True
        End If
    End Sub

    Private Sub dgEgreso_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgEgr.Click
        If dgEgr.SelectedRows.Count = 1 Then
            line = dgEgr.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dgEgreso_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgEgr.KeyUp
        If dgEgr.SelectedRows.Count = 1 Then

            If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
            Else
                fechaborra = FormatDateTime(Now, DateFormat.ShortDate)
            End If

            If dtfecha.Text = fechaborra Then
                If e.KeyCode = Keys.Delete Then
                    ms = MetroMessageBox.Show(Me, "¿Desea eliminar la línea seleccionada?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    If ms = 1 Then
                        Call eliminalinea("Egreso")
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "No se pueden eliminar cargas de días anteriores", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub dgDesab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDesab.Click
        If dgDesab.SelectedRows.Count = 1 Then
            line = dgDesab.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dgDesabollado_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDesab.KeyUp
        If dgEgr.SelectedRows.Count = 1 Then

            If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
            Else
                fechaborra = FormatDateTime(Now, DateFormat.ShortDate)
            End If

            If dtfecha.Text = fechaborra Then
                If e.KeyCode = Keys.Delete Then
                    ms = MetroMessageBox.Show(Me, "¿Desea eliminar la línea seleccionada?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    If ms = 1 Then
                        Call eliminalinea("Desabollado")
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "No se pueden eliminar cargas de días anteriores", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub cblinea_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cblinea.SelectionChangeCommitted
        If rbEgr.Checked = True Then
            Call llenonum(cblinea.Text)
        End If
    End Sub

    Private Sub cbrazon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbrazon.SelectedIndexChanged

    End Sub

    Private Sub llenonum(ByVal linea As Integer)
        Call conex("LAVENLINEA")
        sql = "SELECT * From LAVENLINEA where LAVENLINEA_LINEA='" + Trim(Str(linea)) + "' and LAVENLINEA_OPCION='CHTR' order by LAVENLINEA_NUMERO"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

        If n = 0 Then
            cbchapa.DataSource = Nothing
        Else
            cbchapa.DataSource = dt
            cbchapa.DisplayMember = "lavenlinea_numero"
            cbchapa.ValueMember = "lavenlinea_numero"
        End If
    End Sub

    Public Function llenoChtrEnLinea(ByVal linea As Integer) As DataTable
        Call conex("LAVENLINEA")
        sql22 = "SELECT lavenlinea_linea as Linea, lavenlinea_numero as Numero From LAVENLINEA where LAVENLINEA_LINEA='" + Trim(Str(linea)) + "' and LAVENLINEA_OPCION='CHTR' order by LAVENLINEA_numero "
        da22 = New SqlDataAdapter(sql22, cnn)
        dt22 = New DataTable
        da22.Fill(dt22)
        If dt22.Rows.Count > 0 Then
            Return dt22
        Else
            Return Nothing
        End If


    End Function

    Sub ChtrEnLinea()
        'Muestra en los datagrid de la derecha todos los inoxidables que se encuentran en la línea

        dtLineaI = llenoChtrEnLinea(1)
        dgLineaI.DataSource = dtLineaI
        dgLineaI.Columns("Linea").Visible = False

        dtLineaII = llenoChtrEnLinea(2)
        dgLineaII.DataSource = dtLineaII
        dgLineaII.Columns("Linea").Visible = False
    End Sub

    Private Sub dgLineaI_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLineaI.CellClick

        If dgLineaI.SelectedRows.Count = 1 Then
            linedgI = dgLineaI.CurrentRow.Cells("Numero").Value
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
                cbchapa.Text = linedgI
            End If

        ElseIf linea = 2 Then
            If dgLineaII.SelectedRows.Count = 1 Then
                rbEgr.Checked = True
                cblinea.Text = dgLineaII.CurrentRow.Cells("Linea").Value
                cblinea_SelectionChangeCommitted(Nothing, Nothing)
                cbchapa.Text = linedgII
            End If

        End If

    End Sub

    Private Sub dgLineaII_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLineaII.CellClick
        If dgLineaII.SelectedRows.Count = 1 Then
            linedgII = dgLineaII.CurrentRow.Cells("Numero").Value
        End If
    End Sub

    Private Sub dgLineaII_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLineaII.CellDoubleClick
        'Para completar los datos con la selección de la grilla
        'Linea 2
        Egreso(2)
    End Sub
End Class