Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class LAVCCP
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String
    Dim cantidad, MaxCtrl, linedgI, linedgII As Integer
    Dim cantDes, cantnuevos, cantbaja As String
    Dim dtLineaI, dtLineaII As DataTable

    Private Sub LAVCCP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call verifica_fecha()

        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto

        CcpEnLinea()

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
        '*****************Ingreso DE CUBREPLACAS A PRENSA****************
        If rbIng.Checked = True Then

            'chequeo linea,placa y abertura
            If String.IsNullOrEmpty(cblinea.Text) Or String.IsNullOrEmpty(txtplaca.Text) Or String.IsNullOrEmpty(txtabertura.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtplaca.Focus()
                Exit Sub
            End If

            'chequeo línea 1 (24 aberturas), línea 2 (30)
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

            sql = "select * from LAVENLINEA where lavenlinea_numero='" + txtplaca.Text + "' " &
              "and lavenlinea_opcion='CCP'"
            da = New SqlDataAdapter(sql, cnn)
            dt = New DataTable
            da.Fill(dt)
            n = dt.Rows.Count
            If n > 0 Then
                MetroMessageBox.Show(Me, "Este número de chapa ya se encuentra en Línea", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtplaca.Focus()
                Exit Sub
            End If
            sql = "select * from LAVENLINEA where lavenlinea_linea='" + cblinea.Text + "' " &
            "and lavenlinea_abertura='" + txtabertura.Text + "'and lavenlinea_opcion='CCP'"
            da = New SqlDataAdapter(sql, cnn)
            dt = New DataTable
            da.Fill(dt)
            n = dt.Rows.Count
            If n > 0 Then
                MetroMessageBox.Show(Me, "La abertura: " + Trim(Str(dt.Rows(0).Item("lavenlinea_abertura"))) + "  tiene el cubreplacas Nº: " + Trim(Str(dt.Rows(0).Item("lavenlinea_numero"))) + "  ingresado en línea: '" + dt.Rows(0).Item("lavenlinea_linea") + "'", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtplaca.Focus()
                Exit Sub
            End If
            campos = "lavccp_fecha, lavccp_ingegr, lavccp_linea, lavccp_turno, lavccp_grupo, lavccp_nplaca, lavccp_abertura, lavccp_userid, lavccp_bajaid,lavccp_bajafch"
            variables = "'" + Now + "','I','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + txtplaca.Text + "', " &
            "'" + txtabertura.Text + "','" + user + "','0',''"

            SQL3 = "INSERT INTO LAVCCP (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()
            MetroMessageBox.Show(Me, "Registro guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

            'Guardo el nuevo Ingreso en la tabla temporal LAVENLINEA
            campos = "lavenlinea_linea, lavenlinea_numero,lavenlinea_abertura,lavenlinea_opcion"
            variables = "'" + cblinea.Text + "','" + txtplaca.Text + "','" + txtabertura.Text + "','CCP'"
            SQL3 = "INSERT INTO LAVENLINEA (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()


            Call verifica_fecha()

            cblinea.Text = ""
            txtplaca.Text = ""
            txtabertura.Text = ""

            Call buscadatos("I")



            '*****************EGRESO DE CUBREPLACA DE PRENSA****************
        ElseIf rbEgr.Checked = True Then
            'chequeo linea,placa y abertura
            If String.IsNullOrEmpty(cblinea.Text) Or String.IsNullOrEmpty(cbplaca.Text) Or String.IsNullOrEmpty(cbabertura.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtplaca.Focus()
                Exit Sub
            End If

            campos = "lavccp_fecha, lavccp_ingegr, lavccp_linea, lavccp_turno, lavccp_grupo, lavccp_nplaca, lavccp_abertura, lavccp_razon, lavccp_userid, lavccp_bajaid,lavccp_bajafch"
            variables = "'" + Now + "','E','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbplaca.Text + "', " &
            "'" + cbabertura.Text + "','" + cbrazon.Text + "','" + user + "','0',''"

            SQL3 = "INSERT INTO LAVCCP (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()
            MetroMessageBox.Show(Me, "Registro guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

            'Elimino la Chapa de la tabla temporal LAVENLINEA
            SQL3 = "delete from LAVENLINEA where lavenlinea_linea='" + cblinea.Text + "' and lavenlinea_numero='" + cbplaca.Text + "' " &
            "and lavenlinea_abertura='" + cbabertura.Text + "' and lavenlinea_opcion='CCP'"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            Call llenonum(cblinea.Text)

            Call verifica_fecha()

            cblinea.Text = ""
            txtplaca.Text = ""
            txtabertura.Text = ""

            Call buscadatos("E")


        End If

        CcpEnLinea()

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

        sql1 = "SELECT lavccp_id as ID, lavccp_fecha as Fecha,lavccp_ingegr as IngEgr,lavccp_linea as Linea,lavccp_turno as Turno,lavccp_grupo as Grupo, " &
        "lavccp_nplaca as NPlaca,lavccp_abertura as Abertura,lavccp_razon as Razon " &
        "from LAVCCP where  LAVCCP_INGEGR='" + ingegr + "' and LAVCCP_FECHA>='" + fechaant + "' and LAVCCP_FECHA<='" + fch + "' and LAVCCP_bajaid='0' order by LAVCCP_fecha"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        If ingegr = "I" Then
            dgIng.DataSource = dt1
            dgIng.Columns("ID").Visible = False
        Else
            dgEgr.DataSource = dt1
            dgEgr.Columns("ID").Visible = False
        End If


    End Sub

    Private Sub eliminalinea(ByVal solapa As String)

        If solapa = "Ingreso" Then
            sql4 = "Select * from LAVENLINEA where lavenlinea_linea='" + dgIng.CurrentRow.Cells("Linea").Value + "' " &
            "and lavenlinea_numero='" + Trim(Str(dgIng.CurrentRow.Cells("NPlaca").Value)) + "' " &
            "and lavenlinea_abertura= '" + Trim(Str(dgIng.CurrentRow.Cells("Abertura").Value)) + "' and lavenlinea_opcion='CCP'"
            da4 = New SqlDataAdapter(sql4, cnn)
            dt4 = New DataTable
            da4.Fill(dt4)
            Dim n As Integer
            n = dt4.Rows.Count
            If n = 0 Then
                MetroMessageBox.Show(Me, "Este cubreplaca tiene un movimiento de egreso. Debe eliminar el egreso antes de borrar este movimiento", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'elimina la fila de la grilla
            sql4 = "select LAVCCP_userid from LAVCCP where LAVCCP_id='" + Trim(line) + "' and lavccp_userid='" + user + "'"
            da4 = New SqlDataAdapter(sql4, cnn)
            dt4 = New DataTable
            da4.Fill(dt4)

            n = dt4.Rows.Count
            If n = 0 Then
                MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                sql4 = "update LAVCCP set LAVCCP_bajaid='" + user + "', LAVCCP_bajafch='" + Now + "' where LAVCCP_id='" + trim(line) + "'"
                cmd4 = New SqlCommand(sql4, cnn)
                cmd4.Connection.Open()
                cmd4.ExecuteNonQuery()
                cmd4.Connection.Close()

                'Elimino la fila de la tabla temporal LAVENLINEA así no aparece como opción en el egreso
                sql4 = "delete from LAVENLINEA where lavenlinea_linea='" + dgIng.CurrentRow.Cells("Linea").Value + "' " &
                "and lavenlinea_numero='" + Trim(Str(dgIng.CurrentRow.Cells("NPlaca").Value)) + "' " &
                "and lavenlinea_abertura= '" + Trim(Str(dgIng.CurrentRow.Cells("Abertura").Value)) + "' and lavenlinea_opcion='CCP'"
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
            sql4 = "select LAVCCP_userid from LAVCCP where LAVCCP_id='" + Trim(line) + "' and lavccp_userid='" + user + "'"
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
                "'" + Trim(dgEgr.CurrentRow.Cells("NPlaca").Value) + "', " &
                "'" + Trim(dgEgr.CurrentRow.Cells("Abertura").Value) + "' ,'CCP')"
                cmd1 = New SqlCommand(sql1, cnn)
                cmd1.Connection.Open()
                cmd1.ExecuteNonQuery()
                cmd1.Connection.Close()

                sql4 = "update LAVCCP set LAVCCP_bajaid='" + user + "', LAVCCP_bajafch='" + Now + "' where LAVCCP_id='" + trim(line) + "'"
                cmd4 = New SqlCommand(sql4, cnn)
                cmd4.Connection.Open()
                cmd4.ExecuteNonQuery()
                cmd4.Connection.Close()

                Call buscadatos("E")
                If dt1.Rows.Count <> 0 Then
                    'dg.Select(0)
                End If
            End If

        End If

        CcpEnLinea()

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


    Private Sub txtplaca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtplaca.KeyPress
        'Entero
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub rbIng_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIng.CheckedChanged

        If rbIng.Checked = True Then
            pnlplaca.Visible = True

            txtplaca.Visible = True
            txtabertura.Visible = True
            cbplaca.Visible = False
            cbabertura.Visible = False

            pnlabertura.Visible = True
            pnlrazon.Visible = False
            TabControl1.SelectedTab = tpIng

            txtplaca.Text = ""
            txtabertura.Text = ""

        End If

    End Sub

    Private Sub rbEgr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEgr.CheckedChanged
        If rbEgr.Checked = True Then
            pnlplaca.Visible = True
            txtplaca.Visible = False
            txtabertura.Visible = False
            cbplaca.Visible = True
            cbabertura.Visible = True


            pnlabertura.Visible = True
            pnlrazon.Visible = True

            txtplaca.Text = ""
            txtabertura.Text = ""

            Call llenaRazEgr()

            TabControl1.SelectedTab = tpEgr

        End If
    End Sub

    Private Sub llenaRazEgr()
        cbrazon.Refresh()
        Call conex("lavrazondest")
        sql = "SELECT * From LAVRAZONDEST where lavrd_cod='CCEGR' and lavrd_combo='R' order by lavrd_desc"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        cbrazon.DataSource = dt
        cbrazon.DisplayMember = "lavrd_desc"
        cbrazon.ValueMember = "lavrd_desc"

    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos("I")
        Call buscadatos("E")
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        If TabControl1.SelectedIndex = 0 Then
            'Ingreso
            rbIng.Checked = True

        ElseIf TabControl1.SelectedIndex = 1 Then
            'Egresoción
            rbEgr.Checked = True

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
        End If
    End Sub

    Private Sub llenonum(ByVal linea As Integer)
        Call conex("LAVENLINEA")
        sql = "SELECT * From LAVENLINEA where LAVENLINEA_LINEA='" + Trim(Str(linea)) + "' and LAVENLINEA_OPCION='CCP' order by LAVENLINEA_NUMERO"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

        If n = 0 Then
            cbplaca.DataSource = Nothing
            cbabertura.DataSource = Nothing
        Else
            cbplaca.DataSource = dt
            cbplaca.DisplayMember = "lavenlinea_numero"
            cbplaca.ValueMember = "lavenlinea_numero"

            cbabertura.DataSource = dt
            cbabertura.DisplayMember = "lavenlinea_abertura"
            cbabertura.ValueMember = "lavenlinea_abertura"

        End If

    End Sub

    Private Sub cbplaca_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbplaca.SelectionChangeCommitted
        Call conex("LAVENLINEA")
        sql = "SELECT * From LAVENLINEA where LAVENLINEA_LINEA='" + cblinea.Text + "' and  lavenlinea_numero='" + cbplaca.Text + "' and LAVENLINEA_OPCION='CCP' order by LAVENLINEA_NUMERO"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

        If n = 0 Then
            cbplaca.DataSource = Nothing
            cbabertura.DataSource = Nothing
        Else
            cbabertura.DataSource = dt
            cbabertura.DisplayMember = "lavenlinea_abertura"
            cbabertura.ValueMember = "lavenlinea_abertura"

        End If
    End Sub



    Private Sub cbabertura_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbabertura.SelectionChangeCommitted
        Call conex("LAVENLINEA")
        sql = "SELECT * From LAVENLINEA where LAVENLINEA_LINEA='" + cblinea.Text + "' and  lavenlinea_abertura='" + cbabertura.Text + "' and LAVENLINEA_OPCION='CCP' order by LAVENLINEA_NUMERO"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

        If n = 0 Then
            cbplaca.DataSource = Nothing
            cbabertura.DataSource = Nothing
        Else
            cbplaca.DataSource = dt
            cbplaca.DisplayMember = "lavenlinea_numero"
            cbplaca.ValueMember = "lavenlinea_numero"

        End If
    End Sub

    Public Function llenoCcpEnLinea(ByVal linea As Integer) As DataTable
        Call conex("LAVENLINEA")
        sql22 = "SELECT lavenlinea_linea as Linea,lavenlinea_abertura as Abertura, lavenlinea_numero as Numero From LAVENLINEA " & _
        " where LAVENLINEA_LINEA='" + Trim(Str(linea)) + "' and LAVENLINEA_OPCION='CCP' order by LAVENLINEA_ABERTURA "
        da22 = New SqlDataAdapter(sql22, cnn)
        dt22 = New DataTable
        da22.Fill(dt22)
        If dt22.Rows.Count > 0 Then
            Return dt22
        Else
            Return Nothing
        End If


    End Function


    Sub CcpEnLinea()
        'Muestra en los datagrid de la derecha todos los inoxidables que se encuentran en la línea

        dtLineaI = llenoCcpEnLinea(1)
        dgLineaI.DataSource = dtLineaI
        dgLineaI.Columns("Linea").Visible = False

        dtLineaII = llenoCcpEnLinea(2)
        dgLineaII.DataSource = dtLineaII
        dgLineaII.Columns("Linea").Visible = False
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

    Private Sub dgEgr_BackgroundImageLayoutChanged(sender As Object, e As EventArgs) Handles dgEgr.BackgroundImageLayoutChanged

    End Sub

    Private Sub dgIng_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgIng.CellValidated

    End Sub
End Class
