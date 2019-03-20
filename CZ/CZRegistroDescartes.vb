Imports System.Data.SqlClient
Imports MetroFramework
Imports MetroFramework.Controls

Public Class CZRegistroDescartes
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl, decorativo As String
    Dim defecto1, defecto2, defecto3 As String
    Dim LineaI, LineaII As String
    Dim cantidad, marca, cant, CantidadDescarte As Integer

    Private Sub CZRegistroDescartes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call verifica_fecha()

        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto
        'Busca datos Linea I
        Call buscadatos(1)
        Call buscadatos(2)

        Call LlenoGrupo(cbgrupo1)
        Call LlenoGrupo(cbgrupo2)

    End Sub


    Private Sub verifica_fecha()
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            dtfecha.Value = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            dtfecha.Value = FormatDateTime(Now, DateFormat.ShortDate)
        End If
    End Sub

    Private Sub buscadatos(ByVal linea As String)
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql1 = "SELECT CZREGDESCARTES.czregdes_id as ID, CZREGDESCARTES.czregdes_fecha as Fecha, CZREGDESCARTES.czregdes_linea as Linea, CZREGDESCARTES.czregdes_turno as Turno, CZREGDESCARTES.czregdes_grupo as Grupo, " &
                "CZDESCARTEI.CZDESCI_DESC as Descripcion, CZREGDESCARTES.czregdes_cantidad as Cantidad FROM CZREGDESCARTES " &
                "INNER JOIN CZDESCARTEH ON CZREGDESCARTES.czregdes_iddefectoH = CZDESCARTEH.CZDESCH_ID INNER JOIN " &
                "CZDESCARTEI ON CZREGDESCARTES.czregdes_iddefectoI = CZDESCARTEI.CZDESCI_ID AND CZDESCARTEH.CZDESCH_ID = CZDESCARTEI.CZDESCH_ID " &
                "where  CZREGDES_FECHA>='" + fechaant + "' and CZREGDES_FECHA<='" + fch + "' and CZREGDES_LINEA= '" + linea + "' and CZREGDES_TURNO='" + cbturno.Text + "' and CZREGDES_BAJAID='0' order by CZREGDES_fecha"

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        If linea = 1 Then
            dgLineaI.DataSource = dt1
        Else
            dgLineaII.DataSource = dt1
        End If
    End Sub

    Private Sub LlenoGrupo(ByVal combo As ComboBox)
        Call conex("CZDESCARTEH")
        sql = "SELECT * From CZDESCARTEH where CZDESCH_BAJA='N' order by CZDESCH_id"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

        If n = 0 Then
        Else
            combo.DataSource = dt
            combo.DisplayMember = "CZDESCH_DESC"
            combo.ValueMember = "CZDESCH_ID"
        End If

    End Sub

    Private Sub llenoItem(ByVal grupo As Integer)
        Call conex("zorras")
        sql = "SELECT * From CZDESCARTEI where CZDESCH_ID='" + Trim(Str(grupo)) + "' AND CZDESCI_BAJA='N'order by CZDESCI_ID"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count
    End Sub

    Private Sub Guardar(ByVal button As String, ByVal linea As Integer)

        If String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar Turno y grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbturno.Focus()
            Exit Sub
        End If


        If button = "Linea1" Then
            If String.IsNullOrEmpty(cbgrupo1.Text) And String.IsNullOrEmpty(cbitm1.Text) And String.IsNullOrEmpty(txtcant1.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar Grupo,Item y Cantidad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtcant1.Focus()
                Exit Sub
            End If
        Else
            If String.IsNullOrEmpty(cbgrupo2.Text) And String.IsNullOrEmpty(cbitm2.Text) And String.IsNullOrEmpty(txtcant2.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar Grupo,Item y Cantidad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtcant2.Focus()
                Exit Sub
            End If
        End If

        If linea = 1 Then
            DefectoH = Trim(Str(cbgrupo1.SelectedValue))
            DefectoD = Trim(Str(cbitm1.SelectedValue))
            CantidadDescarte = txtcant1.Text
        Else
            DefectoH = Trim(Str(cbgrupo2.SelectedValue))
            DefectoD = Trim(Str(cbitm2.SelectedValue))
            CantidadDescarte = txtcant2.Text
        End If

        SQL3 = "select * from CZREGDESCARTES " &
                "where  CZREGDES_FECHA>='" + fechaant + "' and CZREGDES_FECHA<='" + fch + "' " &
                "and CZREGDES_LINEA= '" + Trim(Str(linea)) + "' and CZREGDES_TURNO='" + cbturno.Text + "' " &
                "and CZREGDES_iddefectoH='" + DefectoH + "' and CZREGDES_iddefectoI='" + DefectoD + "' " &
                "and CZREGDES_BAJAID='0'"
        da3 = New SqlDataAdapter(SQL3, cnn)
        dt3 = New DataTable
        da3.Fill(dt3)
        n = dt3.Rows.Count

        Dim fechaturno As DateTime
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            fechaturno = FormatDateTime(Now.AddDays(1), DateFormat.LongDate)
        Else
            fechaturno = FormatDateTime(Now, DateFormat.LongDate)

        End If

        If n = 0 Then
            campos = "CZREGDES_fecha, CZREGDES_linea, CZREGDES_turno, CZREGDES_grupo, CZREGDES_iddefectoH,CZREGDES_iddefectoI, " &
                     "CZREGDES_cantidad, CZREGDES_userid, CZREGDES_bajaid, CZREGDES_bajafch,CZREGDES_fechaturno"

            variables = "'" + Now + "','" + Trim(Str(linea)) + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + DefectoH + "', " &
            "'" + DefectoD + "', '" + Str(CantidadDescarte) + "','" + user + "','0','','" + fechaturno + "'"

            SQL3 = "INSERT INTO CZREGDESCARTES (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

        Else
            Dim cantidad As Integer
            cantidad = dt3.Rows(0).Item("CZREGDES_CANTIDAD")
            cantidad = cantidad + CantidadDescarte

            SQL3 = "Update CZREGDESCARTES set czregdes_cantidad='" + Trim(Str(cantidad)) + "'  " &
                    "where  CZREGDES_id='" + Trim(Str(dt3.Rows(0).Item("czregdes_id"))) + "'"
            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

        End If



        Call verifica_fecha()

        buscadatos(linea)
        limpia(linea)

        If linea = 1 Then
            TabControl1.SelectedTab = TabPage1
            cbgrupo1.Focus()

        Else
            TabControl1.SelectedTab = TabPage2
            cbgrupo2.Focus()
        End If


    End Sub

    Private Sub limpia(ByVal linea As Integer)
        If linea = 1 Then
            cbgrupo1.Text = Nothing
            cbitm1.Text = Nothing
            txtcant1.Text = Nothing
        Else
            cbgrupo2.Text = Nothing
            cbitm2.Text = Nothing
            txtcant2.Text = Nothing
        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub conexion()
        conex("CZREGDESCARTES")
    End Sub

    Private Sub DataGrid_click(ByVal grid As MetroGrid)
        If grid.SelectedRows.Count = 1 Then
            line = grid.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dgLineaI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLineaI.Click
        DataGrid_click(dgLineaI)
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

    Private Sub dgLineaI_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgLineaI.KeyUp
        DataGrid_KeyUp(1, e)
    End Sub

    Private Sub eliminalinea(ByVal linea As Integer)
        'elimina la fila de la grilla
        sql4 = "select CZREGDES_userid from CZREGDESCARTES where CZREGDES_id='" + Str(line) + "' and CZREGDES_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count

        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sql4 = "Update CZREGDESCARTES set CZREGDES_BAJAID='" + user + "',CZREGDES_BAJAFCH='" + Now + "' where CZREGDES_id='" + Str(line) + "'"
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

    Private Sub dgLineaII_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLineaII.Click
        DataGrid_click(dgLineaII)
    End Sub

    Private Sub DataGrid_DoubleClick(ByVal linea As Integer)
        If cant > 0 Then
            If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
            Else
                fechaborra = FormatDateTime(Now, DateFormat.ShortDate)
            End If

            If dtfecha.Text = fechaborra Then
                sql5 = "select czregdes_userid from CZREGDESCARTES where czregdes_id='" + Str(line) + "' and czregdes_userid='" + user + "'"
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

                        sql4 = "update CZREGDESCARTES set czregdes_GRUPO='" + im + "' where  czregdes_id='" + Str(line) + "'"
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


    Private Sub dgLineaII_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLineaII.DoubleClick
        DataGrid_DoubleClick(2)
    End Sub

    Private Sub dgLineaII_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgLineaII.KeyUp
        DataGrid_KeyUp(2, e)
    End Sub

    Private Sub limpiaLII()
        cbgrupo2.Text = Nothing
        cbitm2.Text = Nothing
        txtcant2.Text = ""
    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            fechaborra = FormatDateTime(Now, DateFormat.ShortDate)
        End If

        If dtfecha.Value <> fechaborra Then
            btnguardarLI.Visible = False
            btnGuargarLII.Visible = False
        Else
            btnguardarLI.Visible = True
            btnGuargarLII.Visible = True
        End If

        Call buscadatos(1)
        Call buscadatos(2)

    End Sub

    Private Sub cbgrupo1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbgrupo1.SelectionChangeCommitted
        Call llenoItem(cbgrupo1.SelectedValue)
        If n = 0 Then

        Else
            cbitm1.DataSource = dt
            cbitm1.DisplayMember = "czdesci_desc"
            cbitm1.ValueMember = "czdesci_id"

        End If
    End Sub

    Private Sub btnguardarLI_Click(sender As Object, e As EventArgs) Handles btnguardarLI.Click
        Guardar("Linea1", 1)
    End Sub

    Private Sub cbgrupo2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbgrupo2.SelectionChangeCommitted
        Call llenoItem(cbgrupo2.SelectedValue)
        If n = 0 Then

        Else
            cbitm2.DataSource = dt
            cbitm2.DisplayMember = "czdesci_desc"
            cbitm2.ValueMember = "czdesci_id"
        End If
    End Sub

    Private Sub Enteros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcant1.KeyPress, txtcant2.KeyPress
        'Solo acepta valores Enteros
        SoloNumeros(e)
    End Sub

    Private Sub cbturno_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbturno.SelectionChangeCommitted
        Call buscadatos(1)
        Call buscadatos(2)
    End Sub

    Private Sub dgLineaI_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLineaI.DoubleClick
        DataGrid_DoubleClick(1)
    End Sub

    Private Sub btnGuargarLII_Click(sender As Object, e As EventArgs)
        Guardar("Linea2", 2)
    End Sub

End Class