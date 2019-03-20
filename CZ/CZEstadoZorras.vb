Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class CZEstadoZorras
    Inherits MetroFramework.Forms.MetroForm

    Dim ms As Integer
    Dim cantidad, MaxCtrl As Integer
    Dim averia As String
    Dim averia1, averia2 As String

    Private Sub CZEstadoZorras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto

        Call buscadatos()

        Call buscaaverias()
        chklb.DataSource = dt2
        chklb.DisplayMember = "czaverias_desc"
        chklb.ValueMember = "czaverias_id"
        Call zorra2()

    End Sub


    Private Sub buscaaverias()
        Call conexion()

        sql2 = "select * from CZAVERIAS order by CZAVERIAS_DESC"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)

    End Sub

    Private Sub llenozorras()
        Call conex("zorras")
        sql = "SELECT * From ZORRAS where zorras_baja='N' order by zorras_id"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

    End Sub


    Private Sub zorra2()
        Call llenozorras()
        If n = 0 Then
            MetroMessageBox.Show(Me, "No hay zorras dadas de alta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            cbzorra2.DataSource = dt
            cbzorra2.DisplayMember = "zorras_id"
            cbzorra2.ValueMember = "zorras_id"
        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub conexion()
        conex("czreparacion")
    End Sub

    Private Sub buscadatos()
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql1 = "SELECT czreparacion_id as ID, czreparacion_fecha as Fecha, czreparacion_turno as Turno,czreparacion_grupo as Grupo, czreparacion_zorra as Zorra,CZAVERIAS_1.CZAVERIAS_DESC as Averia1, " &
        "(SELECT CZAVERIAS_DESC FROM CZAVERIAS WHERE (CZAVERIAS_ID = czreparacion_averia2)) AS Averia2, " &
        "czreparacion_reparada as Reparada, czreparacion_userid as UserID, czreparacion_bajaid as BajaID " &
        "FROM CZAVERIAS AS CZAVERIAS_1 INNER JOIN CZREPARACION ON CZAVERIAS_1.CZAVERIAS_ID = czreparacion_averia1 " &
        "where  CZREPARACION_REPARADA='N' and czreparacion_fecha>='" + fechaant + "' and czreparacion_fecha<='" + fch + "' " &
        "and czreparacion_bajaid='0' ORDER BY CZREPARACION_FECHA"
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
    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos()
    End Sub

    Private Sub eliminalinea()
        'elimina la fila de la grilla
        sql4 = "select CZREPARACION_userid from CZREPARACION where czreparacion_id='" + Str(line) + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count

        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


            sql4 = "update CZREPARACION set CZREPARACION_bajaid='" + user + "' where CZREPARACION_id='" + Str(line) + "'"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call buscadatos()
            If dt1.Rows.Count <> 0 Then
                'dg.Select(0)
            Else

            End If
        End If


    End Sub

    Private Sub dg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.Click
        If dtfecha.Text = Now.Date And dg.SelectedRows.Count = 1 Then
            line = dg.CurrentRow.Cells("ID").Value
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
                sql5 = "select CZREPARACION_userid from CZREPARACION where czreparacion_id='" + Str(line) + "' and CZREPARACION_userid='" + user + "'"
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

                        sql4 = "update CZREPARACION set CZREPARACION_GRUPO='" + im + "' where CZREPARACION_id='" + Str(line) + "'"
                        cmd4 = New SqlCommand(sql4, cnn)
                        cmd4.Connection.Open()
                        cmd4.ExecuteNonQuery()
                        cmd4.Connection.Close()

                        MetroMessageBox.Show(Me, "GRUPO CAMBIADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question)

                        Call buscadatos()
                        If dt1.Rows.Count <> 0 Then
                            'dg.Select(0)
                        End If
                    Else
                        MetroMessageBox.Show(Me, "GRUPO INCORRECTO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "No se pueden modificar cargas de días anteriores", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
        End If
    End Sub

    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If cant > 0 Then

            If dtfecha.Text = Now.Date Then
                If e.KeyCode = Keys.Delete Then
                    ms = MetroMessageBox.Show(Me, "¿Desea eliminar la línea seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    If ms = 1 Then
                        Call eliminalinea()
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "No se pueden eliminar cargas de días anteriores", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        Else
        End If
    End Sub

    Private Sub chklb_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chklb.KeyUp
        If e.KeyCode = Keys.Space Then
            id1 = chklb.SelectedIndex
            chklb.SetItemChecked(id1, False)
        End If
    End Sub

    Private Sub chklb_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chklb.SelectedValueChanged
        Call buscaChek()
    End Sub

    Private Sub buscaChek()
        Dim i As Integer
        Dim s As String
        Dim max As Integer


        s = "Checked Items:" & ControlChars.CrLf
        For i = 0 To (chklb.Items.Count - 1)
            If chklb.GetItemChecked(i) = True Then

                If max = 2 Then
                    MetroMessageBox.Show(Me, "Ya seleccionó dos opciones", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    id1 = chklb.SelectedIndex

                    chklb.SetItemChecked(id1, False)

                Else

                    s = (i).ToString
                    averia = dt2.Rows(s).Item("czaverias_desc")

                    max = max + 1

                End If
            End If
        Next
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        If String.IsNullOrEmpty(cbgrupo.Text) Then
            MetroMessageBox.Show(Me, "Favor de seleccionar grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbgrupo.Focus()
            Exit Sub

        End If

        Dim i As Integer
        Dim s As String
        s = "Checked Items:" & ControlChars.CrLf
        For i = 0 To (chklb.Items.Count - 1)
            If chklb.GetItemChecked(i) = True Then
                s = (i).ToString

                If averia1 = "" Then
                    averia1 = dt2.Rows(s).Item("czaverias_id")

                    chklb.SetItemChecked(i, False)

                Else
                    averia2 = dt2.Rows(s).Item("czaverias_id")

                    chklb.SetItemChecked(i, False)
                End If
            End If
        Next

        If averia1 = "" Then
            MetroMessageBox.Show(Me, "Favor de seleccionar averia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        Else
            Call grabar()
            averia1 = ""
            averia2 = ""
            chklb.ClearSelected()

            Call buscadatos()
            dg.DataSource = dt1
        End If


    End Sub

    Sub grabar()
        conex("czreparacion")
        campos = "czreparacion_fecha,czreparacion_turno,czreparacion_grupo,czreparacion_zorra,czreparacion_averia1,czreparacion_averia2,CZREPARACION_reparada,CZREPARACION_userid,CZREPARACION_bajaid"
        variables = "'" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbzorra2.Text + "','" + averia1 + "','" + averia2 + "','N','" + user + "','0'"

        SQL3 = "INSERT INTO CZREPARACION(" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()
    End Sub



End Class