Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework
Imports MetroFramework.Controls

Public Class CZZorrasCargadas
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl, decorativo As String
    Dim defecto1, defecto2, defecto3 As String
    Dim cantidad, marca, cant, cantZorI, cantZorII, cantAux As Integer

    Private Sub CZZorrasCargadas_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Call haydatos()
    End Sub

    Private Sub haydatos()
        'Rutina que controla sí hay datos cargados en los espesores al cerrar el formulario.
        'Call BorraAux()

        If cbdefecto1.Text <> "" Or cbdefecto2.Text <> "" Or cbdefecto3.Text <> "" Then
            ms = MetroMessageBox.Show(Me, "Hay datos cargados de Línea:  '" + cblinea.Text + "' ¿Desea guardarlos para que los use su relevo?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If ms = 1 Then
                Call guardaAux()
            End If
        Else

        End If

    End Sub

    Private Sub guardaAux()

        If chkdeco.Checked = True Then
            decorativo = "S"
        Else
            decorativo = "N"
        End If

        sql6 = "Select * from auxczzcargadas where linea= " + cblinea.Text + ""
        da6 = New SqlDataAdapter(sql6, cnn)
        dt6 = New DataTable
        da6.Fill(dt6)
        n = dt6.Rows.Count

        If n > 0 Then
            ms = MetroMessageBox.Show(Me, "Ya hay datos cargados de Línea: " + cblinea.Text + " en la tabla auxiliar, ¿Desea reemplazarlos?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If msg = 1 Then
                SQL3 = "delete from AUXCZZCARGADAS where linea='" + cblinea.Text + "'"
                cmd3 = New SqlCommand(SQL3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()

                campos = "linea,turno,grupo,zorra,material,cantid, " &
                "decorat,calidad,defecto1,defecto2,defecto3"

                variables = "'" + Trim(cblinea.Text) + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbzorra.Text + "','" + cbmaterial.Text + "','" + Trim(txtcantid.Text) + "', " &
                " '" + decorativo + "','" + cbcalid.Text + "','" + cbdefecto1.Text + "','" + cbdefecto2.Text + "','" + cbdefecto3.Text + "'"

                SQL3 = "INSERT INTO AUXCZZCARGADAS (" + campos + ") VALUES (" + variables + ")"
                cmd3 = New SqlCommand(SQL3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()
            End If
        Else
            campos = "linea,turno,grupo,zorra,material,cantid, " &
            "decorat,calidad,defecto1,defecto2,defecto3"

            variables = "'" + Trim(cblinea.Text) + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbzorra.Text + "','" + cbmaterial.Text + "','" + Trim(txtcantid.Text) + "', " &
            " '" + decorativo + "','" + cbcalid.Text + "','" + cbdefecto1.Text + "','" + cbdefecto2.Text + "','" + cbdefecto3.Text + "'"

            SQL3 = "INSERT INTO AUXCZZCARGADAS (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()


        End If
    End Sub


    Private Sub CZZorrasCargadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call verifica_fecha()
        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto

        Call buscadatos(1)
        Call buscadatos(2)

        Call llenozorras()
        Call llenocalidad()

        pnldefectos.Visible = False

        'Busca sí hay datos temporales
        Call BuscaAux()


    End Sub

    Private Sub BuscaAux()
        Call conexion()
        sql6 = "select top 1 * from AUXCZZCARGADAS"
        da6 = New SqlDataAdapter(sql6, cnn)
        dt6 = New DataTable
        da6.Fill(dt6)
        cantAux = dt6.Rows.Count

        If cantAux = 0 Then

        Else
            linea = dt6.Rows(i).Item("linea")
            ms = MetroMessageBox.Show(Me, "Hay datos guardados de espesores de Línea: '" + linea + "' ¿Desea utilizarlos?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If ms = 1 Then
                cblinea.Text = dt6.Rows(i).Item("linea")
                cbturno.Text = dt6.Rows(i).Item("turno")
                cbgrupo.Text = dt6.Rows(i).Item("grupo")
                cbzorra.Text = dt6.Rows(i).Item("zorra")

                Call llenacbwhere("mcmaterial", "where material_mc='" + cblinea.Text + "'")
                cbmaterial.DataSource = dt9
                cbmaterial.DisplayMember = "material_medmm"
                cbmaterial.ValueMember = "material_medmm"
                cbmaterial.Text = dt6.Rows(i).Item("material")

                txtcantid.Text = dt6.Rows(i).Item("cantid")

                If dt6.Rows(i).Item("decorat") = "S" Then
                    chkdeco.Checked = True
                Else
                    chkdeco.Checked = False
                End If

                cbcalid.Text = dt6.Rows(i).Item("calidad")


                pnldefectos.Visible = True
                cbdefecto1.Enabled = True
                Call llenoDEFECTOS1()
                cbdefecto1.Text = dt6.Rows(i).Item("defecto1")
                chkdef2.Enabled = True

                If dt6.Rows(i).Item("defecto2") = "" Then
                    chkdef2.Checked = False
                Else
                    chkdef2.Enabled = True
                    chkdef2.Checked = True

                    cbdefecto2.Text = dt6.Rows(i).Item("defecto2")
                End If


                If dt6.Rows(i).Item("defecto3") = "" Then
                    chkdef3.Checked = False
                Else
                    chkdef3.Enabled = True
                    chkdef3.Checked = True
                    cbdefecto3.Text = dt6.Rows(i).Item("defecto3")
                End If

            End If

            Call BorraAux(cblinea.Text)

        End If
    End Sub

    Private Sub BorraAux(ByVal linea As String)
        sql4 = "delete from AUXCZZCARGADAS where linea=" + linea + ""
        cmd4 = New SqlCommand(sql4, cnn)
        cmd4.Connection.Open()
        cmd4.ExecuteNonQuery()
        cmd4.Connection.Close()
    End Sub

    Private Sub verifica_fecha()
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            dtfecha.Value = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            dtfecha.Value = FormatDateTime(Now, DateFormat.ShortDate)
        End If
    End Sub

    Private Sub llenozorras()
        Call conex("zorras")
        sql = "SELECT * From ZORRAS where zorras_baja='N' order by zorras_id"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count
        If n = 0 Then
            MetroMessageBox.Show(Me, "No hay zorras dadas de alta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cbzorra.DataSource = dt
            cbzorra.DisplayMember = "zorras_id"
            cbzorra.ValueMember = "zorras_id"
        End If


    End Sub

    Private Sub llenocalidad()
        Call conex("czcalidad")
        sql = "SELECT * From CZCALIDAD order by CZCALIDAD_ID"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count
        If n = 0 Then
            MetroMessageBox.Show(Me, "No hay tipos de calidad dadas de alta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cbcalid.DataSource = dt
            cbcalid.DisplayMember = "czcalidad_desc"
            cbcalid.ValueMember = "czcalidad_id"
        End If


    End Sub

    Private Sub cbmc_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cblinea.SelectionChangeCommitted

        Call llenacbwhere("mcmaterial", "where material_mc='" + cblinea.Text + "'")
        cbmaterial.DataSource = dt9
        cbmaterial.DisplayMember = "material_medmm"
        cbmaterial.ValueMember = "material_medmm"

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        If cblinea.Text = "" Or cbturno.Text = "" Or cbgrupo.Text = "" Or cbzorra.Text = "" Or cbmaterial.Text = "" Or Trim(txtcantid.Text) = "" Or cbcalid.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcantid.Focus()
            Exit Sub
        End If


        If pnldefectos.Visible = True Then
            If cbdefecto1.Text = "" Then
                MetroMessageBox.Show(Me, "Favor de indicar un motivo por el cual fue rechazada la zorra", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbdefecto1.Focus()
                Exit Sub
            End If
        End If

        If chkdeco.Checked = True Then
            decorativo = "S"
        Else
            decorativo = "N"
        End If



        'DEFECTO 1
        If cbcalid.SelectedValue = "RCH" Or cbcalid.SelectedValue = "PRI" Then
            defecto1 = cbdefecto1.Text
        Else
            defecto1 = ""
        End If

        'DEFECTO 2
        If chkdef2.Checked = True Then
            defecto2 = cbdefecto2.Text
        Else
            defecto2 = ""
        End If

        'DEFECTO 3
        If chkdef3.Checked = True Then
            defecto3 = cbdefecto3.Text
        Else
            defecto3 = ""
        End If


        Dim fechaturno As DateTime
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            fechaturno = FormatDateTime(Now.AddDays(1), DateFormat.LongDate)
        Else
            fechaturno = FormatDateTime(Now, DateFormat.LongDate)

        End If

        campos = "czzcargadas_fecha,czzcargadas_linea,czzcargadas_turno,czzcargadas_grupo,czzcargadas_zorra,czzcargadas_material,czzcargadas_cantid,czzcargadas_horasal, " & _
                 "czzcargadas_decorat,czzcargadas_calidad,czzcargadas_defecto1,czzcargadas_defecto2,czzcargadas_defecto3,czzcargadas_fechaturno,czzcargadas_userid,czzcargadas_bajaid"

        variables = "'" + Now + "','" + Trim(cblinea.Text) + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbzorra.Text + "','" + cbmaterial.Text + "','" + Trim(txtcantid.Text) + "','" + dthora.Text + "', " & _
        " '" + decorativo + "','" + cbcalid.Text + "','" + defecto1 + "','" + defecto2 + "','" + defecto3 + "', " & _
        "'" + fechaturno + "','" + user + "','0'"

        SQL3 = "INSERT INTO CZZCARGADAS (" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()

        MetroMessageBox.Show(Me, "Zorra cargada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

        Call verifica_fecha()

        If Trim(cblinea.Text) = "1" Then
            TabControl1.SelectedTab = TabPage1
            buscadatos(1)

        ElseIf Trim(cblinea.Text) = "2" Then
            TabControl1.SelectedTab = TabPage2
            buscadatos(2)
            dglineaII.DataSource = dt2
        End If

        Call limpia()

    End Sub

    Private Sub limpia()

        cblinea.Text = Nothing
        cbzorra.Text = Nothing
        cbmaterial.Text = Nothing
        txtcantid.Text = ""
        chkdeco.Checked = False
        cbcalid.Text = Nothing
        pnldefectos.Visible = False
        cbdefecto1.Text = Nothing

        chkdef2.Checked = False
        chkdef2.Enabled = False
        cbdefecto2.Enabled = False
        cbdefecto2.Text = Nothing

        chkdef3.Checked = False
        chkdef3.Enabled = False
        cbdefecto3.Enabled = False
        cbdefecto3.Text = Nothing

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub


    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged

        Call buscadatos(1)
        Call buscadatos(2)


    End Sub


    Private Sub conexion()
        conex("czzcargadas")
    End Sub
    Private Sub buscadatos(ByVal linea As String)
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " 21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " 22:00:00"

        Call conexion()

        sql1 = "SELECT    czzcargadas_id as ID, czzcargadas_fecha as Fecha,czzcargadas_linea as Linea,czzcargadas_turno as Turno,czzcargadas_grupo as Grupo " &
                 ",czzcargadas_zorra as Zorra,czzcargadas_material as Material,czzcargadas_cantid as Cantidad,czzcargadas_horasal as HSalida,czzcargadas_decorat as Decor " &
                ",czzcargadas_calidad as Calidad,czzcargadas_defecto1 as Defecto1,czzcargadas_defecto2 as Defecto2,czzcargadas_defecto3 as Defecto3 " &
                "from CZZCARGADAS where  CZZCARGADAS_FECHA>='" + fechaant + "' and CZZCARGADAS_FECHA<='" + fch + "' and CZZCARGADAS_linea='" + Trim(Str(linea)) + "' and CZZCARGADAS_bajaid='0' order by CZZCARGADAS_fecha"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        If linea = 1 Then
            dglineaI.DataSource = dt1
        Else
            dglineaII.DataSource = dt1
        End If

    End Sub

    Private Sub DataGrid_click(ByVal grid As MetroGrid)
        If grid.SelectedRows.Count = 1 Then
            line = grid.CurrentRow.Cells("ID").Value
        End If
    End Sub


    Private Sub dglineaI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dglineaI.Click
        DataGrid_click(dglineaI)
    End Sub

    Private Sub DataGrid_KeyUp(ByVal linea As Integer, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            fechaborra = FormatDateTime(Now, DateFormat.ShortDate)
        End If

        If dtfecha.Text = fechaborra Then
            If e.KeyCode = Keys.Delete Then
                ms = MetroMessageBox.Show(Me, "¿Desea eliminar la línea seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    Call eliminalinea(linea)
                End If
            End If
        End If
    End Sub

    Private Sub dglineaI_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dglineaI.KeyUp
        DataGrid_KeyUp(1, e)
    End Sub

    Private Sub eliminalinea(ByVal linea As Integer)
        'elimina la fila de la grilla
        sql4 = "select CZZCARGADAS_userid from CZZCARGADAS where CZZCARGADAS_id='" + Trim(Str(line)) + "' and CZZCARGADAS_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count

        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sql4 = "Update CZZCARGADAS set CZZCARGADAS_BAJAID='" + user + "' where CZZCARGADAS_id='" + Trim(Str(line)) + "'"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call buscadatos(linea)
            If dt1.Rows.Count <> 0 Then
                'dg.Select(0)
            Else

            End If
        End If
    End Sub


    Private Sub dglineaII_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dglineaII.Click
        DataGrid_click(dglineaII)
    End Sub

    Private Sub DataGrid_DoubleClick(ByVal linea As Integer)
        If cant > 0 Then
            If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
            Else
                fechaborra = FormatDateTime(Now, DateFormat.ShortDate)
            End If

            If dtfecha.Text = fechaborra Then
                sql5 = "select CZZCARGADAS_userid from CZZCARGADAS where CZZCARGADAS_id='" + Str(line) + "' and CZZCARGADAS_userid='" + user + "'"
                da5 = New SqlDataAdapter(sql5, cnn)
                dt5 = New DataTable
                da5.Fill(dt5)
                Dim n As Integer
                n = dt5.Rows.Count

                If n = 0 Then
                    MetroMessageBox.Show(Me, "Usted no puede modificar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    Dim im As String
                    im = UCase(InputBox("Cambiar Turno"))

                    If im = "A" Or im = "B" Or im = "C" Or im = "D" Then

                        sql4 = "Update CZZCARGADAS set CZZCARGADAS_GRUPO='" + UCase(im) + "' where CZZCARGADAS_id='" + Str(line) + "'"
                        cmd4 = New SqlCommand(sql4, cnn)
                        cmd4.Connection.Open()
                        cmd4.ExecuteNonQuery()
                        cmd4.Connection.Close()

                        MetroMessageBox.Show(Me, "GRUPO CAMBIADO", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        Call buscadatos(linea)
                        If dt1.Rows.Count <> 0 Then
                            'dg.Select(0)
                        End If


                    Else
                        MetroMessageBox.Show(Me, "GRUPO INCORRECTO", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "No se pueden modificar cargas de días anteriores", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
        End If
    End Sub


    Private Sub dglineaII_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dglineaII.DoubleClick
        DataGrid_DoubleClick(2)
    End Sub

    Private Sub dglineaII_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dglineaII.KeyUp
        DataGrid_KeyUp(1, e)
    End Sub

    Private Sub txtcantid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantid.KeyPress
        'Entero
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cbcalid_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbcalid.SelectionChangeCommitted
        If cbcalid.SelectedValue = "RCH" Or cbcalid.SelectedValue = "PRI" Then
            pnldefectos.Visible = True
            cbdefecto1.Enabled = True
            Call llenoDEFECTOS1()

        Else
            pnldefectos.Visible = False
            cbdefecto1.DataSource = Nothing
            cbdefecto1.Enabled = False
            chkdef2.Checked = False
            chkdef2.Enabled = False
            cbdefecto2.DataSource = Nothing
            cbdefecto2.Enabled = False
            chkdef3.Checked = False
            chkdef3.Enabled = False
            cbdefecto3.DataSource = Nothing
            cbdefecto3.Enabled = False


        End If
    End Sub

    Private Sub llenoDEFECTOS1()
        Call defectos()
        If n = 0 Then
            MetroMessageBox.Show(Me, "No hay defectos cargados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cbdefecto1.DataSource = dt8
            cbdefecto1.DisplayMember = "czdefectos_desc"
            cbdefecto1.ValueMember = "czdefectos_desc"
            cbdefecto1.Focus()
        End If


    End Sub

    Private Sub defectos()
        Call conex("czdefectos")
        sql8 = "SELECT * From CZDEFECTOS order by czdefectos_desc"
        da8 = New SqlDataAdapter(sql8, cnn)
        dt8 = New DataTable
        da8.Fill(dt8)
        n = dt8.Rows.Count
    End Sub

    Private Sub cbdefecto2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbdefecto2.LostFocus
        If cbdefecto2.Text <> "" Then
            chkdef3.Enabled = True
            chkdef3.Focus()
        Else
            chkdef3.Enabled = False


        End If
    End Sub

    Private Sub cbdefecto1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbdefecto1.LostFocus
        If cbdefecto1.Text <> "" Then
            chkdef2.Enabled = True
            chkdef2.Focus()
        Else
            chkdef2.Enabled = False


        End If
    End Sub


    Private Sub chkdef2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdef2.CheckedChanged
        If chkdef2.Checked = True Then
            Call defectos()
            If n = 0 Then
                MetroMessageBox.Show(Me, "No hay defectos cargados", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                cbdefecto2.Enabled = True
                cbdefecto2.DataSource = dt8
                cbdefecto2.DisplayMember = "czdefectos_desc"
                cbdefecto2.ValueMember = "czdefectos_desc"
                cbdefecto2.Focus()
            End If
        Else
            cbdefecto2.DataSource = Nothing
            cbdefecto2.Enabled = False
            chkdef3.Checked = False
            chkdef3.Enabled = False
            cbdefecto3.Enabled = False



        End If
    End Sub

    Private Sub chkdef3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkdef3.CheckedChanged
        If chkdef3.Checked = True Then
            Call defectos()
            If n = 0 Then
                MetroMessageBox.Show(Me, "No hay defectos cargados", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                cbdefecto3.Enabled = True
                cbdefecto3.DataSource = dt8
                cbdefecto3.DisplayMember = "czdefectos_desc"
                cbdefecto3.ValueMember = "czdefectos_desc"
                cbdefecto3.Focus()

            End If
        Else
            cbdefecto3.DataSource = Nothing
            cbdefecto3.Enabled = False

        End If
    End Sub

    Private Sub dglineaI_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dglineaI.DoubleClick
        DataGrid_DoubleClick(1)
    End Sub

End Class