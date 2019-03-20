Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework

Public Class McEnsayos
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String
    Dim cantidad, marca, cant, cantEns As Integer

    Private Sub McEnsayos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto

        Call verifica_fecha()

        Call buscadatosTQ3()
        Call buscadatosEnsayos()

        If chkgrupo2.Checked = True Then
            panelGrupo2.Enabled = True
        Else
            panelGrupo2.Enabled = False
        End If


        If chkgrupo1.Checked = True Then
            PanelGrupo1.Enabled = True
        Else
            PanelGrupo1.Enabled = False
        End If

    End Sub


    Private Sub verifica_fecha()

        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            dtfecha.Value = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            dtfecha.Value = FormatDateTime(Now, DateFormat.ShortDate)

        End If

    End Sub


    Private Sub cbmc_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbmc.SelectionChangeCommitted

        Call llenacbwhere("mcmaterial", "where material_mc='" + cbmc.Text + "'")
        cbmaterial.DataSource = dt9
        cbmaterial.DisplayMember = "material_medmm"
        cbmaterial.ValueMember = "material_medmm"

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        If chkgrupo1.Checked = True Then

            If String.IsNullOrEmpty(cbmc.Text) Or String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Or String.IsNullOrEmpty(cbmaterial.Text) Or Trim(String.IsNullOrEmpty(txtcpseco.Text)) Or Trim(String.IsNullOrEmpty(txtcpconc.Text)) Or Trim(String.IsNullOrEmpty(txtsdseco.Text)) Or Trim(String.IsNullOrEmpty(txtsdtiempo.Text)) Or Trim(String.IsNullOrEmpty(txtsdsd.Text)) Or Trim(String.IsNullOrEmpty(txtshhhumedo.Text)) Or Trim(String.IsNullOrEmpty(txtshhseco.Text)) Or Trim(String.IsNullOrEmpty(txtshhsequedad.Text)) Then
                MetroMessageBox.Show(Me, "Favor de completar todos los campos de ensayo en máquina", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtcpseco.Focus()
                Exit Sub
            End If

        ElseIf chkgrupo2.Checked = True Then

            If String.IsNullOrEmpty(txtcptqseco.Text) Or String.IsNullOrEmpty(txtcptqconc.Text) Or String.IsNullOrEmpty(txtsdtqseco.Text) Or String.IsNullOrEmpty(txtsdtqtiempo.Text) Or String.IsNullOrEmpty(txtsdtqsd.Text) Or String.IsNullOrEmpty(txtensayo.Text) Then
                MetroMessageBox.Show(Me, "Completar todos los datos de ensayo en tanque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtcptqseco.Focus()
                Exit Sub
            End If

        End If

        If chkgrupo1.Checked = True Then
            campos = "ensayo_mc,ensayo_fecha,ensayo_turno,ensayo_grupo,ensayo_material,ensayo_cppseco,ensayo_cpconcentracion, " &
                     "ensayo_sdpseco,ensayo_sdtiempo,ensayo_sdsd,ensayo_shhumedo,ensayo_shhpseco,ensayo_shhsequedad,ensayo_userid,ensayo_bajaid"

            variables = "'" + Trim(cbmc.Text) + "','" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbmaterial.Text + "','" + Trim(txtcpseco.Text) + "','" + Trim(txtcpconc.Text) + "', " &
            "'" + Trim(txtsdseco.Text) + "','" + Trim(txtsdtiempo.Text) + "','" + Trim(txtsdsd.Text) + "','" + Trim(txtshhhumedo.Text) + "','" + Trim(txtshhseco.Text) + "', " &
            "'" + Trim(txtshhsequedad.Text) + "','" + user + "','0'"

            SQL3 = "INSERT INTO MCENSAYO (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            MetroMessageBox.Show(Me, "Ensayo de MC: " + cbmc.Text + " , Turno: " + cbturno.Text + " cargado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Call verifica_fecha()

            Call buscadatosEnsayos()

            Call limpia()

        End If

        If chkgrupo2.Checked = True Then
            campos = "tq3_fecha,tq3_turno,tq3_grupo,tq3_cppseco,tq3_cpconcentracion, " &
                     "tq3_sdpseco,tq3_sdtiempo,tq3_sdsd,tq3_ensayohora,tq3_ensayotiempo,tq3_userid,tq3_bajaid"

            variables = "'" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + Trim(txtcptqseco.Text) + "','" + Trim(txtcptqconc.Text) + "', " &
            "'" + Trim(txtsdtqseco.Text) + "','" + Trim(txtsdtqtiempo.Text) + "','" + Trim(txtsdtqsd.Text) + "','" + dtensayo.Text + "','" + Trim(txtensayo.Text) + "', " &
            "'" + user + "','0'"

            SQL3 = "INSERT INTO MCENSAYOTQ3 (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            MetroMessageBox.Show(Me, "Grupo 2 cargado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Call verifica_fecha()
            Call buscadatosTQ3()
            Call limpiaTQ3()

        End If

    End Sub

    Private Sub limpia()

        'Concentración Pulpa
        txtcpseco.Text = ""
        txtcpconc.Text = ""
        'Segundos Drenaje
        txtsdseco.Text = ""
        txtsdtiempo.Text = ""
        txtsdsd.Text = ""
        'Sequedad Hoja Húmeda
        txtshhhumedo.Text = ""
        txtshhseco.Text = ""
        txtshhsequedad.Text = ""
        chkgrupo1.Checked = False

    End Sub

    Private Sub limpiaTQ3()
        'Concentración Pulpa TQ3
        txtcptqseco.Text = ""
        txtcptqconc.Text = ""
        'Segundos drenaje TQ3
        txtsdtqseco.Text = ""
        txtsdtqtiempo.Text = ""
        txtsdtqsd.Text = ""
        'Ensayo en blanco Segundos Drenaje
        txtensayo.Text = ""

        chkgrupo2.Checked = False

    End Sub


    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub


    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged

        Call buscadatosEnsayos()

        Call buscadatosTQ3()

    End Sub


    Private Sub conexion()
        conex("mcensayo")
    End Sub

    Private Sub buscadatosEnsayos()
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql1 = "SELECT ensayo_id as ID, ensayo_fecha as Fecha,ensayo_mc as Linea,ensayo_turno as Turno,ensayo_grupo as Grupo
                ,ensayo_material as Material,ensayo_cppseco as CppSeco,ensayo_cpconcentracion as CpConcentracion
                ,ensayo_sdpseco as SdpSeco,ensayo_sdtiempo as SdTiempo,ensayo_sdsd as SdSd,ensayo_shhumedo as SdHumedo
                ,ensayo_shhpseco as ShhpSeco,ensayo_shhsequedad as ShhSequedad,ensayo_userid as UserID,ensayo_bajaid as BajaID 
                from MCENSAYO 
                where  ensayo_fecha>='" + fechaant + "' and ensayo_fecha<='" + fch + "' and ensayo_bajaid='0' 
                order by ensayo_fecha"

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        cantEns = dt1.Rows.Count

        dgEnsayos.DataSource = dt1

        ocultarColumnas(dgEnsayos)

    End Sub


    Private Sub buscadatosTQ3()
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql2 = "SELECT tq3_id as ID, tq3_fecha as Fecha,tq3_turno as Turno,tq3_grupo as Grupo,tq3_cppseco as CppSeco,tq3_cpconcentracion as CpConcentración,
                tq3_sdpseco as SdpSeco,tq3_sdtiempo as SdTiempo,tq3_sdsd as SdSd,tq3_ensayohora as Hora,tq3_ensayotiempo as Tiempo,
                tq3_userid as UserID,tq3_bajaid as BajaID 
                from mcensayoTQ3 
                where  tq3_fecha>='" + fechaant + "' and tq3_fecha<='" + fch + "' and tq3_bajaid='0'
                order by tq3_fecha"

        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)
        cant = dt2.Rows.Count

        dgtq3.DataSource = dt2

        ocultarColumnas(dgtq3)


    End Sub

    Private Sub ocultarColumnas(ByVal datagrid As DataGridView)
        If datagrid.Name = dgtq3.Name.ToString Then

            dgtq3.Columns("ID").Visible = False
            dgtq3.Columns("UserID").Visible = False
            dgtq3.Columns("BajaID").Visible = False

        ElseIf datagrid.Name = dgEnsayos.Name.ToString Then
            dgEnsayos.Columns("ID").Visible = False
            dgEnsayos.Columns("UserID").Visible = False
            dgEnsayos.Columns("BajaID").Visible = False

        End If
    End Sub


    Private Sub chkgrupo2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkgrupo2.CheckedChanged
        If chkgrupo2.Checked = True Then

            If String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar turno y grupo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                chkgrupo2.Checked = False
                panelGrupo2.Enabled = False
                cbturno.Focus()

            Else
                If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                    fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
                Else
                    fechaborra = FormatDateTime(Now, DateFormat.ShortDate)

                End If


                fch = FormatDateTime(fechaborra, DateFormat.ShortDate) & " " & "05:59:59"
                fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

                fecha = FormatDateTime(Now, DateFormat.ShortDate)


                If cbturno.Text = "22-06" Then
                    sql = "select count(tq3_turno) as cantidad from MCENSAYOTQ3 where tq3_fecha>='" + fechaant + "' and tq3_fecha<='" + fch + "' and tq3_turno='" + cbturno.Text + "' and tq3_bajaid='0'"
                Else
                    sql = "select count(tq3_turno)as cantidad from MCENSAYOTQ3 where tq3_fecha>='" + fecha & " " & "00:00:00" + "' and tq3_fecha<='" + fecha & " " & "23:59:59" + "' and tq3_turno='" + cbturno.Text + "' and tq3_bajaid='0'"

                End If

                da = New SqlDataAdapter(sql, cnn)
                dt = New DataTable
                da.Fill(dt)
                If IsDBNull(dt.Rows(0).Item("cantidad")) Then
                    cantidad = 0
                Else
                    cantidad = dt.Rows(0).Item("cantidad")
                End If

                If cantidad >= 20 Then
                    MetroMessageBox.Show(Me, "Su turno: " + cbturno.Text + " ya realizo la carga de ensayos en tanque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    chkgrupo2.Checked = False

                Else
                    encabezado.Enabled = False
                    panelGrupo2.Enabled = True
                End If
            End If

        Else
            If chkgrupo1.Checked = True Then
                encabezado.Enabled = False
                panelGrupo2.Enabled = False

            Else

                encabezado.Enabled = True
                cbgrupo.Enabled = True
                cbturno.Enabled = True
                panelGrupo2.Enabled = False
            End If
        End If

    End Sub


    Private Sub chkgrupo1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkgrupo1.CheckedChanged

        If chkgrupo1.Checked = True Then

            If cbturno.Text <> "" And cbgrupo.Text <> "" And marca <> 1 Then

                marca = 1
                chkgrupo1.Checked = False

            ElseIf String.IsNullOrEmpty(cbmc.Text) Or String.IsNullOrEmpty(cbmaterial.Text) Or String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar todos los campos del encabezado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                chkgrupo1.Checked = False
                PanelGrupo1.Enabled = False
                cbturno.Focus()

            Else
                If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                    fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
                Else
                    fechaborra = FormatDateTime(Now, DateFormat.ShortDate)

                End If


                fch = FormatDateTime(fechaborra, DateFormat.ShortDate) & " " & "05:59:59"
                fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

                fecha = FormatDateTime(Now, DateFormat.ShortDate)


                If cbturno.Text = "22-06" Then
                    sql = "select count(ensayo_mc) as cantidad from MCENSAYO where ensayo_fecha>='" + fechaant + "' and ensayo_fecha<='" + fch + "' and ensayo_turno='" + cbturno.Text + "' and ensayo_mc='" + cbmc.Text + "' and ensayo_bajaid='0'"
                Else
                    sql = "select count(ensayo_mc)as cantidad from MCENSAYO where ensayo_fecha>='" + fecha & " " & "00:00:00" + "' and ensayo_fecha<='" + fecha & " " & "23:59:59" + "' and ensayo_turno='" + cbturno.Text + "' and ensayo_mc='" + cbmc.Text + "' and ensayo_bajaid='0'"

                End If

                da = New SqlDataAdapter(sql, cnn)
                dt = New DataTable
                da.Fill(dt)
                If IsDBNull(dt.Rows(0).Item("cantidad")) Then
                    cantidad = 0
                Else
                    cantidad = dt.Rows(0).Item("cantidad")
                End If

                If cantidad >= 20 Then
                    MetroMessageBox.Show(Me, "Carga de su turno a MC: " + cbmc.Text + " ya realizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Call limpia()
                    chkgrupo1.Checked = False

                Else

                    encabezado.Enabled = False
                    PanelGrupo1.Enabled = True
                End If
            End If

        Else

            If chkgrupo2.Checked = True And marca = 1 Then

                PanelGrupo1.Enabled = False
                encabezado.Enabled = True
                cbturno.Enabled = False
                cbgrupo.Enabled = False
                cbmc.Focus()

            ElseIf chkgrupo2.Checked = True And marca <> 1 Then

                encabezado.Enabled = False
                PanelGrupo1.Enabled = False
            Else

                encabezado.Enabled = True
                cbturno.Enabled = True
                cbgrupo.Enabled = True
                PanelGrupo1.Enabled = False
            End If
        End If
    End Sub


    Private Sub dgtq3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgtq3.Click
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            fechaborra = FormatDateTime(Now, DateFormat.ShortDate)

        End If


        If dtfecha.Text = fechaborra Then

            If cant = 0 Then
            Else
                lineaTQ3 = dgtq3.CurrentRow.Cells("ID").Value

            End If

        Else

        End If
    End Sub

    Private Sub dgtq3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgtq3.KeyUp
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            fechaborra = FormatDateTime(Now, DateFormat.ShortDate)

        End If


        If dtfecha.Text = fechaborra Then

            If e.KeyCode = Keys.Delete Then

                ms = MetroMessageBox.Show(Me, "¿Desea eliminar el ensayo seleccionado?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    Call eliminalineaTQ3()
                End If
            End If

        Else
            MetroMessageBox.Show(Me, "No se pueden eliminar cargas de días anteriores", "Aviso", MessageBoxButtons.OK)

        End If
    End Sub



    Private Sub dgEnsayos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgEnsayos.Click
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            fechaborra = FormatDateTime(Now, DateFormat.ShortDate)

        End If


        If dtfecha.Text = fechaborra Then

            If cantEns = 0 Then
            Else
                lineaEnsayo = dgEnsayos.CurrentRow.Cells("ID").Value
            End If

        Else

        End If
    End Sub

    Private Sub dgEnsayos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgEnsayos.KeyUp
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            fechaborra = FormatDateTime(Now, DateFormat.ShortDate)

        End If


        If dtfecha.Text = fechaborra Then

            If e.KeyCode = Keys.Delete Then
                ms = MetroMessageBox.Show(Me, "Desea eliminar el ensayo seleccionado?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    Call eliminalineaEnsayo()
                End If
            End If

        Else
            MetroMessageBox.Show(Me, "No se pueden eliminar ensayos de días anteriores", "Aviso", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub eliminalineaEnsayo()
        'elimina la fila de la grilla
        sql4 = "select ensayo_userid from MCENSAYO where ensayo_id='" + Str(lineaEnsayo) + "' and ensayo_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count


        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sql4 = "Update MCENSAYO set ensayo_bajaid='" + user + "' where ensayo_id='" + Str(lineaEnsayo) + "'"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call buscadatosEnsayos()
            If dt1.Rows.Count <> 0 Then
                'dg.Select(0)
            Else

            End If
        End If
    End Sub

    Private Sub eliminalineaTQ3()
        'elimina la fila de la grilla
        sql4 = "select tq3_userid from MCENSAYOTQ3 where tq3_id='" + Str(lineaTQ3) + "'  and tq3_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count


        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sql4 = "Update MCENSAYOTQ3 set tq3_bajaid='" + user + "' where tq3_id='" + Str(lineaTQ3) + "'"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call buscadatosTQ3()

            If dt1.Rows.Count <> 0 Then
                'dg.Select(0)
            Else

            End If
        End If

    End Sub


    Private Sub Enteros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcpseco.KeyPress, txtsdseco.KeyPress, txtsdtiempo.KeyPress, txtshhhumedo.KeyPress, txtshhseco.KeyPress, txtcptqseco.KeyPress, txtsdtqseco.KeyPress, txtsdtqtiempo.KeyPress
        'Solo acepta valores Enteros
        SoloNumeros(e)
    End Sub

    Private Sub Decimales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcpconc.KeyPress, txtsdsd.KeyPress, txtshhsequedad.KeyPress, txtcptqconc.KeyPress, txtsdtqsd.KeyPress, txtensayo.KeyPress
        Try
            SoloDecimal(Me.ActiveControl, e)
        Catch ex As Exception

        End Try  'Solo acepta valores decimales

    End Sub


    Private Sub txtshhseco_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtshhseco.LostFocus
        If txtshhseco.Text = 0 And txtshhhumedo.Text = 0 Then
            txtshhsequedad.Text = 0
        Else
            txtshhsequedad.Text = System.Math.Round((txtshhseco.Text / txtshhhumedo.Text) * 100, 2)
        End If
    End Sub


    Private Sub txtcptqseco_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcptqseco.LostFocus
        txtcptqconc.Text = txtcptqseco.Text / 50
    End Sub

    Private Sub txtcpseco_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcpseco.LostFocus
        txtcpconc.Text = txtcpseco.Text / 100
    End Sub


End Class