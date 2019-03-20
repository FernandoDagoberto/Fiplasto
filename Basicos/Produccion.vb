Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports MetroFramework

Public Class Produccion

    Inherits MetroFramework.Forms.MetroForm


    Dim TextCol1 As New DataGridTextBoxColumn
    Dim TextCol2 As New DataGridTextBoxColumn
    Dim TextCol3 As New DataGridTextBoxColumn
    Dim TextCol4 As New DataGridTextBoxColumn
    Dim TextCol5 As New DataGridTextBoxColumn
    Dim ms As Integer
    Dim idl As String

    Private Sub Produccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call CargaTurnoAuto()

        Call cargaarea()
        'Call llenamotivo()
        cbsector.Focus()


        Call buscatareas()
        dgtareas.DataSource = dt2




    End Sub

    Private Sub conexion()
        conex("novedades")
    End Sub



    Sub cargaarea()
        conex("area")

        sql1 = "SELECT  AREA.AREA_DESC,PERFIL.PERFIL_CARGO,PERFIL.PERFIL_AREA FROM PERFIL INNER JOIN AREA ON PERFIL.PERFIL_AREA = AREA.AREA_ID INNER JOIN " &
                " USUARIOS ON PERFIL.PERFIL_ID = USUARIOS.user_perfil where Usuarios.user_apenom='" + user + "'"

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        n = dt1.Rows.Count
        If n = 0 Then

            MetroMessageBox.Show(Me, "El usuario no tiene perfil para cargar novedades")
            Me.Close()

        Else

            If dt1.Rows(0).Item("perfil_cargo") = "S" Then

                Dim whe As String
                whe = "where area_relacion ='" + Trim(dt1.Rows(0).Item("perfil_area")) + "'"

                llenacbwhere("area", whe)

                cbsector.DataSource = dt9
                cbsector.DisplayMember = "area_desc"
                cbsector.ValueMember = "area_desc"

            Else

                'Si no es supervisor carga el area del operario

                cbsector.Text = dt1.Rows(0).Item("area_desc")
                cbsector.Enabled = False

            End If

        End If

    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click



    End Sub

    Private Sub buscadatos()
        Call conexion()

        sql1 = "SELECT * from novedades where nov_fecha between '" + Mid(dtfecha.Text, 1, 10) + " 00:00:00 ' and '" + Mid(dtfecha.Text, 1, 10) + " 23:59:59 ' and nov_area='" + Trim(cbsector.Text) + "'"

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        m = dt1.Rows.Count
    End Sub

    Private Sub buscatareas()
        Call conexion()

        sql2 = "SELECT * from tareas where tarea_fchini<='" + dtfecha.Text + "' and tarea_area='" + Trim(cbsector.Text) + "' and tarea_estado is null"

        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)
    End Sub


    'Private Sub guardanovedad()
    '    Call conexion()

    '    If txtobs.Text = "" Or cbgrupo.Text = "" Or cbturno.Text = "" Then
    '        MetroMessageBox.Show(Me,"Faltan completar datos")
    '        txtobs.Focus()
    '        sen1 = 99
    '        Exit Sub
    '    End If

    '    campos = "nov_area,nov_fecha,nov_turno,nov_grupo,nov_motivo,nov_texto,nov_user"

    '    variables = "'" + cbsector.Text + "','" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "', " & _
    '    "'" + cbmotivo.Text + "','" + txtobs.Text + "','" + user + "'"


    '    SQL3 = "INSERT INTO novedades(" + campos + ") VALUES (" + variables + ")"

    '    cmd3 = New SqlCommand(SQL3, cnn)
    '    cmd3.Connection.Open()
    '    cmd3.ExecuteNonQuery()
    '    cmd3.Connection.Close()


    '    If cbmotivo.Text = "Sistema" Then

    '        Call mandamail("SIS")
    '    ElseIf cbmotivo.Text = "Calidad" Then
    '        Call mandamail("CAL")
    '    ElseIf cbmotivo.Text = "Seguridad" Then
    '        Call mandamail("SEG")
    '    ElseIf cbmotivo.Text = "Mantenimiento" Then
    '        Call mandamail("MAN")
    '    Else

    '    End If

    'End Sub

    Private Sub mandamail(ByVal destino As String)

        Dim mail As New System.Net.Mail.MailMessage()
        Dim SMTP As New System.Net.Mail.SmtpClient

        SMTP.Host = "10.10.0.110"

        mail.From = New System.Net.Mail.MailAddress("administrador@fiplasto.com.ar", "Administrador", System.Text.Encoding.UTF8) 'Quien lo envía


        Dim mails As String
        Call conex("usuarios")
        sql = "Select * from usuarios where user_novsec='" + destino + "'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        n = dt.Rows.Count



        If n > 0 Then
            For x = 0 To n - 1

                mails = dt.Rows(x).Item("user_mail")
                mail.To.Add(mails)

            Next
        End If

        mail.Subject = "Novedad SPIF"
        'mail.Body = "El Sector: '" + cbsector.Text + "' ha cargado una nueva novedad de '" + cbmotivo.Text + "'"

        Try
            SMTP.Send(mail)

        Catch ex As System.Net.Mail.SmtpException

        End Try
    End Sub


    Sub bloqueatodo()

        'dtfecha.Enabled = False
        'cbturno.Enabled = False
        'cbgrupo.Enabled = False
        'cbmotivo.Enabled = False
        'txtobs.Enabled = False
        ''dg.Enabled = False
        'btnagregar.Visible = False

    End Sub

    Sub bloquea()
        'cbturno.Enabled = False
        'cbgrupo.Enabled = False
        'cbmotivo.Enabled = False
        'txtobs.Enabled = False
        ''dg.Enabled = False
        'btnagregar.Visible = False

    End Sub


    Sub desbloquea()

        'dtfecha.Enabled = True
        'cbturno.Enabled = True
        'cbgrupo.Enabled = True
        'cbmotivo.Enabled = True
        'txtobs.Enabled = True
        '' dg.Enabled = True
        btnagregar.Visible = True

    End Sub

    Private Sub dtfecha_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtfecha.LocationChanged

    End Sub





    Private Sub eliminalinea()
        'elimina la fila de la grilla
        If dtfecha.Text = Now.Date Then

            sql4 = "delete from novedades where nov_fecha='" + dt1.Rows(deleteline).Item("nov_fecha") + "' and nov_turno='" + dt1.Rows(deleteline).Item("nov_turno") + "' and  " &
            "nov_grupo= '" + dt1.Rows(deleteline).Item("nov_grupo") + "' and nov_area='" + dt1.Rows(deleteline).Item("nov_area") + "'"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call buscadatos()
            dg.DataSource = dt1
            If dt1.Rows.Count <> 0 Then
                'dg.Select(0)
            Else

            End If
        Else
            MetroMessageBox.Show(Me, "No se pueden borrar novedades de días anteriores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub cbsector_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbsector.SelectedIndexChanged

        Call buscadatos()
        dg.DataSource = dt1

        Call buscatareas()
        dgtareas.DataSource = dt2

    End Sub

    Private Sub PintaFilaGrilla()

        line = dt1.Rows.Count

        Dim motivo As String

        For Each fila As DataGridViewRow In dg.Rows

            motivo = fila.Cells(4).Value

            Select Case motivo

                Case "Operativo"
                    fila.DefaultCellStyle.BackColor = Color.SteelBlue
                Case "Seguridad"
                    fila.DefaultCellStyle.BackColor = Color.Red
                    fila.DefaultCellStyle.ForeColor = Color.White
                Case "Calidad"
                    fila.DefaultCellStyle.BackColor = Color.Turquoise
                Case "Mantenimiento"
                    fila.DefaultCellStyle.BackColor = Color.Cornsilk
                Case "Sistema"
                    fila.DefaultCellStyle.BackColor = Color.Beige

            End Select


        Next

    End Sub

    Private Sub dg_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dg.CellFormatting
        Call PintaFilaGrilla()
    End Sub

    Private Sub dg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.Click

        If m = 0 Then
        Else
            deleteline = dg.CurrentCell.RowIndex
        End If

    End Sub


    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp

        If dtfecha.Text = Now.Date Then

            If e.KeyCode = Keys.Delete Then
                ms = MetroMessageBox.Show(Me, "Desea eliminar la novedad seleccionada " + (dt1.Rows(deleteline).Item("nov_fecha")) + "  ?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    Call eliminalinea()
                End If
            End If

        Else

            MetroMessageBox.Show(Me, "No se pueden eliminar novedades de días anteriores")

        End If
    End Sub


    Private Sub dgtareas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgtareas.Click
        lineatarea = dgtareas.CurrentCell.RowIndex
    End Sub

    Private Sub dgtareas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgtareas.DoubleClick

        tareaID = dt2.Rows(lineatarea).Item("tarea_id")
        tareaFecha = dt2.Rows(lineatarea).Item("tarea_fchini")
        tareaArea = dt2.Rows(lineatarea).Item("tarea_area")
        tareaTurno = dt2.Rows(lineatarea).Item("tarea_turno")
        tareaAsunto = dt2.Rows(lineatarea).Item("tarea_asunto")
        tareaDescripcion = dt2.Rows(lineatarea).Item("tarea_desc")

        Dim respTarea As New TareaResp

        respTarea.ShowDialog()

        Call buscatareas()
        dgtareas.DataSource = dt2


    End Sub



    Private Sub dgtareas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgtareas.CellContentClick

    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        If m = 0 Then
        Else

            novFCH = dt1.Rows(deleteline).Item("nov_fecha")
            novAREA = dt1.Rows(deleteline).Item("nov_area")
            novMOTIVO = dt1.Rows(deleteline).Item("nov_motivo")
            novTEXTO = dt1.Rows(deleteline).Item("nov_texto")
            novUSER = dt1.Rows(deleteline).Item("nov_user")

            Dim vernov As New NovedVisual

            vernov.ShowDialog()


        End If
    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        If dtfecha.Text = Now.Date Then
            Call desbloquea()

        Else
            Call bloquea()

        End If

        Call buscadatos()
        dg.DataSource = dt1

        Call buscatareas()
        dgtareas.DataSource = dt2
    End Sub
End Class

