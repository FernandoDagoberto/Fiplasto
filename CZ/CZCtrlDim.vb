Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class CZCtrlDim
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String
    Dim cantidad, MaxCtrl As Integer



    Private Sub CZCtrlDim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call verifica_fecha()
        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto
        Call buscadatos()
        cblinea.Focus()
    End Sub

    Private Sub verifica_fecha()
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            dtfecha.Value = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            dtfecha.Value = FormatDateTime(Now, DateFormat.ShortDate)
        End If
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If chksolo.Checked Then
            If String.IsNullOrEmpty(cblinea.Text) Or String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Or String.IsNullOrEmpty(txtancho.Text) Or String.IsNullOrEmpty(txtlargo.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Call guardar()
                MetroMessageBox.Show(Me, "Control guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Call verifica_fecha()
                Call limpia()
                Call buscadatos()
            End If

        Else
            If String.IsNullOrEmpty(cblinea.Text) Or String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Or String.IsNullOrEmpty(txtancho.Text) Or String.IsNullOrEmpty(txtescu.Text) Or String.IsNullOrEmpty(txtlargo.Text) Or String.IsNullOrEmpty(txtrect.Text) Then
                MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Call verifica_fecha()

                fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
                fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"
                sql = "select count(CZCTDI_linea) as cantidad from CZCTRLDIM where CZCTDI_fecha>='" + fechaant + "' and CZCTDI_fecha<='" + fch + "' and CZCTDI_turno='" + cbturno.Text + "' and CZCTDI_LINEA='" + cblinea.Text + "' and CZCTDI_bajaid='0'"
                da = New SqlDataAdapter(sql, cnn)
                dt = New DataTable
                da.Fill(dt)

                If IsDBNull(dt.Rows(0).Item("cantidad")) Then
                    cantidad = 0
                Else
                    cantidad = dt.Rows(0).Item("cantidad")
                End If

                limites("CZCtrlDimxTurno")
                MaxCtrl = dt8.Rows(0).Item("param_valor")

                If cantidad >= MaxCtrl Then
                    MetroMessageBox.Show(Me, "Este turno ya tiene cargado todos los controles permitidos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call limpia()
                Else
                    Call guardar()

                    MetroMessageBox.Show(Me, "Control guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Call verifica_fecha()
                    Call limpia()
                    Call buscadatos()
                End If
            End If
        End If
    End Sub

    Private Sub guardar()

        campos = "CZCTDI_fecha,CZCTDI_linea,CZCTDI_turno,CZCTDI_grupo,CZCTDI_rectitud,CZCTDI_largo,CZCTDI_ancho,CZCTDI_escuadria,CZCTDI_userid,CZCTDI_bajaid,CZCTDI_bajafch"

        variables = "'" + Now + "','" + cblinea.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + Str(txtrect.Text) + "', " &
        "'" + Str(txtlargo.Text) + "','" + Str(txtancho.Text) + "','" + Str(txtescu.Text) + "','" + user + "','0',''"

        SQL3 = "INSERT INTO CZCTRLDIM (" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()
    End Sub

    Private Sub limpia()

        txtancho.Text = Nothing
        txtescu.Text = Nothing
        txtlargo.Text = Nothing
        txtrect.Text = Nothing
        chksolo.Checked = False

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub conexion()
        conex("czctrldim")
    End Sub

    Private Sub buscadatos()
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql1 = "SELECT czctdi_id as ID, czctdi_fecha as Fecha,czctdi_linea as Linea,czctdi_turno as Turno,czctdi_grupo as Grupo
                 ,czctdi_rectitud as Rectitud,czctdi_largo as Largo,czctdi_ancho as Ancho
            ,czctdi_escuadria as Escuadria,czctdi_userid as UserID,czctdi_bajaid as BajaID,czctdi_bajafch as BajaFch
            from CZCTRLDIM where  CZCTDI_FECHA>='" + fechaant + "' and CZCTDI_FECHA<='" + fch + "' and CZCTDI_bajaid='0' order by CZCTDI_fecha"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        cant = dt1.Rows.Count

        dg.DataSource = dt1
        ocultarColumnas()

    End Sub

    Private Sub ocultarColumnas()
        dg.Columns("ID").Visible = False
        dg.Columns("UserID").Visible = False
        dg.Columns("BajaId").Visible = False
        dg.Columns("BajaFch").Visible = False
    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos()
    End Sub

    Private Sub eliminalinea()
        'elimina la fila de la grilla
        sql4 = "select CZCTDI_userid from CZCTRLDIM where CZCTDI_id='" + Str(line) + "' and  CZCTDI_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count

        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sql4 = "update CZCTRLDIM set CZCTDI_bajaid='" + user + "', CZCTDI_bajafch='" + Now + "' where CZCTDI_id='" + Str(line) + "'"
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

    Private Sub Enteros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrect.KeyPress, txtescu.KeyPress, txtlargo.KeyPress, txtancho.KeyPress
        'Solo acepta valores Enteros
        SoloNumeros(e)
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

    Private Sub chksolo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolo.CheckedChanged
        If chksolo.Checked = True Then
            txtescu.Enabled = False
            txtrect.Enabled = False
            txtescu.Text = 0
            txtrect.Text = 0
        Else
            txtescu.Enabled = True
            txtrect.Enabled = True

        End If
    End Sub


    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        If cant > 0 Then
            If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
            Else
                fechaborra = FormatDateTime(Now, DateFormat.ShortDate)
            End If

            If dtfecha.Text = fechaborra Then
                sql5 = "select CZCTDI_userid from CZCTRLDIM where CZCTDI_id='" + Str(line) + "' and CZCTDI_userid='" + user + "'"
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

                        sql4 = "update CZCTRLDIM set CZCTDI_GRUPO='" + im + "' where  CZCTDI_id='" + Str(line) + "'"
                        cmd4 = New SqlCommand(sql4, cnn)
                        cmd4.Connection.Open()
                        cmd4.ExecuteNonQuery()
                        cmd4.Connection.Close()

                        MetroMessageBox.Show(Me, "GRUPO CAMBIADO", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        Call buscadatos()
                        dg.DataSource = dt1
                        If dt1.Rows.Count <> 0 Then
                            'dg.Select(0)
                        Else

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
End Class