Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class Paradas

    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String

    Private Sub ParadaPicadora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call cargaarea()
        Call llenacausa()
        Call llenamotivo()
        Call llenasector()
        Call llenareparo()
        sen = "n"
        'Formato de Hora HH:mm
        dthi.Format = DateTimePickerFormat.Custom
        dthi.CustomFormat = "HH:mm"
        dthf.Format = DateTimePickerFormat.Custom
        dthf.CustomFormat = "HH:mm"

        Call buscadatos()
    End Sub

    Sub llenacausa()
        llenacb("CAUSA")
        cbcausa.DataSource = dt7
        cbcausa.DisplayMember = "causa_desc"
        cbcausa.ValueMember = "causa_id"
    End Sub

    Sub llenamotivo()
        llenacb("MOTIVO")
        cbmotivo.DataSource = dt7
        cbmotivo.DisplayMember = "motivo_desc"
        cbmotivo.ValueMember = "motivo_id"
    End Sub

    Sub llenasector()
        sql9 = "SELECT DISTINCT sector.SECTOR_ID,SECTOR.SECTOR_DESC FROM AREA INNER JOIN " &
            "SECTOR ON AREA.AREA_ID =SECTOR.AREA_ID INNER JOIN PARADAS ON SECTOR.SECTOR_ID = PARADAS.SECTOR_ID " &
            "WHERE AREA.AREA_DESC = '" + txtarea.Text + "'"
        da9 = New SqlDataAdapter(sql9, cnn)
        dt9 = New DataTable
        da9.Fill(dt9)

        cbsec.DataSource = dt9
        cbsec.DisplayMember = "SECTOR_DESC"
        cbsec.ValueMember = "SECTOR_ID"
        txtsec.Text = cbsec.SelectedValue
    End Sub

    Sub llenaparada()
        conex("PARADAS")
        sql1 = "SELECT * From PARADAS where sector_id='" + txtsec.Text + "'"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        n = dt1.Rows.Count
        If n <> 0 Then
            cbparada.DataSource = dt1
            cbparada.DisplayMember = "paradas_desc"
            cbparada.ValueMember = "paradas_id"
        Else
            MetroMessageBox.Show(Me, "No existen paradas cargadas para este sector", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub cbsec_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbsec.SelectionChangeCommitted
        txtsec.Text = cbsec.SelectedValue
        Call llenaparada()
        txtparada.Text = cbparada.SelectedValue
    End Sub

    Private Sub cbparada_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbparada.SelectionChangeCommitted
        txtparada.Text = cbparada.SelectedValue
    End Sub

    Sub llenareparo()
        llenacb("reparo")
        cbreparo.DataSource = dt7
        cbreparo.DisplayMember = "reparo_desc"
        cbreparo.ValueMember = "reparo_id"
    End Sub

    Private Sub conexion()
        conex("paradasmaq")
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        Call guardaparada()
        If sen1 = 99 Then
            sen1 = 0
            Exit Sub
        End If
        Call buscadatos()
        Call limpiacampo()
        btnagregar.Text = "Agregar"
        btncancelar.Visible = False
        Call desbloquea()
        sen = "n"
    End Sub

    Private Sub buscadatos()
        Call conexion()


        sql1 = "SELECT Paradamaq.id as ID, dbo.PARADAMAQ.area as Area,dbo.PARADAMAQ.linea as Linea,dbo.PARADAMAQ.Fecha as Fecha, dbo.PARADAMAQ.turno as Turno, dbo.PARADAMAQ.grupo as Grupo, dbo.PARADAMAQ.tiempo1 as TInicial, dbo.PARADAMAQ.tiempo2 as TFinal, " &
        "dbo.PARADAMAQ.tiempo as Tiempo,dbo.CAUSA.CAUSA_DESC as Causa, dbo.MOTIVO.MOTIVO_DESC as Motivo, dbo.PARADAMAQ.eq_cod as EqCod, dbo.PARADAMAQ.eq_desc as EqDescr, dbo.PARADAS.PARADAS_DESC as Parada, " &
        "dbo.PARADAMAQ.parada as CodParada, dbo.PARADAMAQ.observacion as Observacion, dbo.REPARO.REPARO_DESC as Reparo FROM dbo.PARADAMAQ INNER JOIN dbo.CAUSA ON dbo.PARADAMAQ.causa = dbo.CAUSA.CAUSA_ID INNER JOIN " &
        "dbo.MOTIVO ON dbo.PARADAMAQ.motivo_id = dbo.MOTIVO.MOTIVO_ID INNER JOIN dbo.PARADAS ON dbo.PARADAMAQ.parada = dbo.PARADAS.PARADAS_ID INNER JOIN " &
        "dbo.REPARO ON dbo.PARADAMAQ.reparo = dbo.REPARO.REPARO_ID where dbo.PARADAMAQ.fecha='" + dtfecha.Text + "' and PARADAMAQ.area='" + txtarea.Text + "'"

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        dg.DataSource = dt1
        ocultarColumnas()

    End Sub

    Private Sub ocultarColumnas()
        dg.Columns("ID").Visible = False
        dg.Columns("Area").Visible = False
        dg.Columns("Tiempo").Visible = False
        dg.Columns("Causa").Visible = False
        dg.Columns("Motivo").Visible = False
        dg.Columns("EqCod").Visible = False
        dg.Columns("CodParada").Visible = False
        dg.Columns("Reparo").Visible = False
    End Sub


    Private Sub limpiacampo()
        txtobs.Text = Nothing
        txttotal.Text = Nothing
        cbparada.DataSource = Nothing
        cbparada.Text = Nothing
        txtparada.Text = Nothing
        Call llenacausa()
        Call llenamotivo()
        Call llenasector()
        Call llenareparo()
        dthi.Refresh()
        dthf.Refresh()
    End Sub

    Private Sub guardaparada()
        Call conexion()

        If String.IsNullOrEmpty(txtobs.Text) Or String.IsNullOrEmpty(txttotal.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Or String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(txtparada.Text) Then
            MetroMessageBox.Show(Me, "Faltan completar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtobs.Focus()
            sen1 = 99
            Exit Sub
        End If

        'Si se tiene en cuenta la línea
        If cblinea.Visible = True Then
            lineaprod = cblinea.Text
        Else
            lineaprod = 0
        End If

        campos = "area, linea, fecha, turno, grupo, tiempo1, tiempo2, tiempo, causa, motivo_id, eq_cod, eq_desc, parada, observacion, reparo, user_alta, fch_alta"

        variables = "'" + txtarea.Text + "','" + Str(lineaprod) + "','" + dtfecha.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "', '" + dthi.Text + "','" + dthf.Text + "', " &
        "'" + txttotal.Text + "','" + cbcausa.SelectedValue + "','" + cbmotivo.SelectedValue + "','" + txtsec.Text + "', " &
        "'" + cbsec.Text + "','" + txtparada.Text + "','" + txtobs.Text + "','" + cbreparo.SelectedValue + "', " &
        "'" + user + "','" + Now + "'"

        If sen = "n" Then
            SQL3 = "INSERT INTO paradamaq(" + campos + ") VALUES (" + variables + ")"
        Else
            SQL3 = "UPDATE paradamaq SET tiempo2='" + dthf.Text + "',tiempo='" + txttotal.Text + "',causa='" + cbcausa.SelectedValue + "', " &
            "motivo_id='" + cbmotivo.SelectedValue + "', eq_cod='" + txtsec.Text + "', eq_desc='" + cbsec.Text + "', " &
            "parada='" + txtparada.Text + "', observacion='" + txtobs.Text + "',reparo='" + cbreparo.SelectedValue + "', " &
            "user_mod='" + user + "',fch_mod='" + Now + "' " &
           "where fecha='" + dtfecha.Text + "' and turno='" + cbturno.Text + "' and grupo='" + cbgrupo.Text + "' and tiempo1='" + dthi.Text + "'"
        End If
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()
    End Sub

    Sub calculatiempo()
        Dim f1 As DateTime
        Dim f2 As DateTime
        Dim minutos As Integer
        Dim total As Integer

        f1 = dthi.Value
        f2 = dthf.Value

        minutos = DateDiff(DateInterval.Minute, f1, f2)
        total = minutos
        If total < 0 Then
            txttotal.Text = (24 * 60) + total
        Else
            txttotal.Text = total
        End If
    End Sub


    Private Sub dthf_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dthf.LostFocus
        Call calculatiempo()
    End Sub

    Private Sub dg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.Click
        If dg.SelectedRows.Count = 1 Then
            line = dg.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        If dtfecha.Text = Now.Date Then
            sen = "m"
            If sen = "m" Or sen = "n" Then
                Call editalinea()
                Call bloquea()
            End If
        Else
            MetroMessageBox.Show(Me, "No se pueden modificar paradas de días anteriores", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Sub editalinea()
        If cblinea.Visible = True Then
            cblinea.Text = dg.CurrentRow.Cells("Linea").Value
        End If

        txtarea.Text = dg.CurrentRow.Cells("Area").Value
        dtfecha.Value = dg.CurrentRow.Cells("Fecha").Value
        cbturno.Text = dg.CurrentRow.Cells("Turno").Value
        cbgrupo.Text = dg.CurrentRow.Cells("Grupo").Value

        dthi.Text = FormatDateTime(dg.CurrentRow.Cells("TInicial").Value, DateFormat.ShortTime)
        dthf.Text = FormatDateTime(dg.CurrentRow.Cells("TFinal").Value, DateFormat.ShortTime)

        txttotal.Text = dg.CurrentRow.Cells("Tiempo").Value
        cbcausa.Text = dg.CurrentRow.Cells("Causa").Value
        cbmotivo.Text = dg.CurrentRow.Cells("Motivo").Value
        txtsec.Text = dg.CurrentRow.Cells("EqCod").Value
        cbsec.Text = dg.CurrentRow.Cells("EqDescr").Value
        txtparada.Text = dg.CurrentRow.Cells("CodParada").Value
        cbparada.Text = dg.CurrentRow.Cells("Parada").Value
        txtobs.Text = dg.CurrentRow.Cells("Observacion").Value
        cbreparo.Text = dg.CurrentRow.Cells("Reparo").Value
        btnagregar.Text = "Actualizar"
        btncancelar.Visible = True
    End Sub

    Sub bloquea()
        dtfecha.Enabled = False
        cbturno.Enabled = False
        cbgrupo.Enabled = False
        dthi.Enabled = False
    End Sub

    Sub desbloquea()

        dtfecha.Enabled = True
        cbturno.Enabled = True
        cbgrupo.Enabled = True
        dthi.Enabled = True
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Call limpiacampo()
        Call desbloquea()
        btncancelar.Visible = False
        btnagregar.Text = "Agregar"

    End Sub

    Private Sub dtfecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtfecha.LostFocus
        Call buscadatos()
    End Sub

    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            If dtfecha.Text = Now.Date Then
                ms = MetroMessageBox.Show(Me, "¿Desea eliminar la causa la parada seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    Call eliminalinea()
                End If
            Else
                MetroMessageBox.Show(Me, "No se pueden eliminar paradas de días anteriores", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub eliminalinea()
        'elimina la fila de la grilla

        sql4 = "delete from paradamaq where id='" + Trim(line) + "'"
        cmd4 = New SqlCommand(sql4, cnn)
        cmd4.Connection.Open()
        cmd4.ExecuteNonQuery()
        cmd4.Connection.Close()
        Call buscadatos()
        If dt1.Rows.Count <> 0 Then
            dg.Select()
        End If

    End Sub

    Sub cargaarea()
        conex("area")

        sql1 = "SELECT  area.area_id,AREA.AREA_DESC FROM PERFIL INNER JOIN AREA ON PERFIL.PERFIL_AREA = AREA.AREA_ID INNER JOIN " &
                "USUARIOS ON PERFIL.PERFIL_ID = USUARIOS.user_perfil where Usuarios.user_apenom='" + user + "'"

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        n = dt1.Rows.Count
        If n = 0 Then
            MetroMessageBox.Show(Me, "El usuario no tiene perfil para cargar novedades", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        Else
            txtarea.Text = dt1.Rows(0).Item("area_desc")
            If txtarea.Text = "MC" Then
                lbllinea.Visible = True
                cblinea.Visible = True
            End If
        End If

    End Sub

End Class