Imports System.Globalization
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class Tareas
    Inherits MetroFramework.Forms.MetroForm

    Dim x As Integer
    Dim dsemana As String
    Dim fchtarea As String
    Dim frecuencia As String

    Private Sub Tareas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fchtarea = ""
        lbldia.Text = Format(dtp.Value, "dddd")
        Call buscamax()
        txtid.Text = ultnro

        'muestra el usuario que está en el sistema
        txtemi.Text = user
        Call cargaarea()

    End Sub



    Private Sub rbdiario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdiario.CheckedChanged
        If rbdiario.Checked = True Then
            lbldd.Text = "días"
        End If
    End Sub

    Private Sub rbsemanal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbsemanal.CheckedChanged
        If rbsemanal.Checked = True Then
            lbldd.Text = "semanas"
        End If
    End Sub

    Private Sub rbmensual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbmensual.CheckedChanged
        If rbmensual.Checked = True Then
            lbldd.Text = "meses"
        End If
    End Sub

    Private Sub rbanual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbanual.CheckedChanged
        If rbanual.Checked = True Then
            lbldd.Text = "años"
        End If
    End Sub

    Private Sub buscadia(ByVal diasemana As Integer)
        If diasemana = 1 Then dsemana = "Domingo"
    End Sub

    Private Sub dtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp.ValueChanged
        lbldia.Text = Format(dtp.Value, "dddd")
    End Sub

    Private Sub btncargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncargar.Click
        If txtdesc.Text = "" Or txttarea.Text = "" Or cbturno.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de completar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttarea.Focus()

        Else
            fchtarea = ""
            Dim dd As Date
            dd = dtp.Value
            '/////////////////////////////////////////////////////////////////////////////////////////////////////
            If rbdiario.Checked = True Then  '####### Diario #######
                If rbdias.Checked = True Then
                    For Me.x = 1 To CInt(txtrepeticiones.Text) + 1
                        If fchtarea = "" Then
                            fchtarea = Format(dtp.Value, "dd/MM/yyyy")
                        Else
                            fchtarea = Format(dd.AddDays(CInt(txtdias.Text)), "dd/MM/yyyy")
                            dd = dd.AddDays(CInt(txtdias.Text))
                        End If

                        Call GuardaTarea()

                    Next

                    frecuencia = "D"
                    Call GuardaFrecuencia()


                End If
            End If
            '////////////////////////////////////////////////////////////////////////////////////////////////////
            If rbsemanal.Checked = True Then  '####### Semanal #######
                If rbdias.Checked = True Then
                    If txtrepeticiones.Text = "" Then txtrepeticiones.Text = "0"
                    For Me.x = 1 To CInt(txtrepeticiones.Text) + 1
                        If fchtarea = "" Then
                            fchtarea = Format(dtp.Value, "dd/MM/yyyy")
                        Else
                            If txtdias.Text = "" Then txtdias.Text = "0"
                            fchtarea = Format(dd.AddDays(7 * CInt(txtdias.Text)), "dd/MM/yyyy")
                            dd = dd.AddDays(7 * CInt(txtdias.Text))
                        End If

                        Call GuardaTarea()

                    Next


                    frecuencia = "S"
                    Call GuardaFrecuencia()



                End If
                Dim ci As CultureInfo = CultureInfo.InvariantCulture
                ' Segun el día de la semana
                Dim ds As DayOfWeek = ci.Calendar.GetDayOfWeek(dtp.Value)
                dsemana = Format(dtp.Value, "dddd")

            End If
            '////////////////////////////////////////////////////////////////////////////////////////////////////
            If rbmensual.Checked = True Then  '####### Mensual #######
                If rbdias.Checked = True Then
                    For Me.x = 1 To CInt(txtrepeticiones.Text) + 1
                        If fchtarea = "" Then
                            fchtarea = Format(dtp.Value, "dd/MM/yyyy")
                        Else
                            fchtarea = Format(dd.AddMonths(CInt(txtdias.Text)), "dd/MM/yyyy")
                            dd = dd.AddMonths(CInt(txtdias.Text))
                        End If

                        Call GuardaTarea()
                    Next


                    frecuencia = "M"
                    Call GuardaFrecuencia()

                End If
            End If
            '////////////////////////////////////////////////////////////////////////////////////////////////////
            If rbanual.Checked = True Then  '####### Anual #######
                If rbdias.Checked = True Then
                    For Me.x = 1 To CInt(txtrepeticiones.Text) + 1
                        If fchtarea = "" Then
                            fchtarea = Format(dtp.Value, "dd/MM/yyyy")
                        Else
                            fchtarea = Format(dd.AddYears(CInt(txtdias.Text)), "dd/MM/yyyy")
                            dd = dd.AddYears(CInt(txtdias.Text))
                        End If

                        Call GuardaTarea()

                    Next

                    frecuencia = "A"
                    Call GuardaFrecuencia()

                End If
            End If
            '////////////////////////////////////////////////////////////////////////////////////////////////////

            MetroMessageBox.Show(Me, "Tarea creada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Call buscamax()
            txtid.Text = ultnro
            txttarea.Text = ""
            txtdesc.Text = ""

        End If
    End Sub

    Private Sub conexion()
        conex("novedades")
    End Sub

    Private Sub cargaarea()
        conex("area")

        sql1 = "SELECT  AREA.AREA_DESC,PERFIL.PERFIL_CARGO,PERFIL.PERFIL_AREA FROM PERFIL INNER JOIN AREA ON PERFIL.PERFIL_AREA = AREA.AREA_ID INNER JOIN " & _
                " USUARIOS ON PERFIL.PERFIL_ID = USUARIOS.user_perfil where Usuarios.user_apenom='" + user + "'"

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        n = dt1.Rows.Count
        If n = 0 Then

            MetroMessageBox.Show(Me, "El usuario no tiene perfil para cargar Tareas", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()

        Else

            If dt1.Rows(0).Item("perfil_cargo") = "S" Then

                Dim whe As String
                whe = "where area_relacion ='" + Trim(dt1.Rows(0).Item("perfil_area")) + "'"

                llenacbwhere("area", whe)

                cbarea.DataSource = dt9
                cbarea.DisplayMember = "area_desc"
                cbarea.ValueMember = "area_desc"


            Else

                'Si no es supervisor carga el area del operario

                cbarea.Text = dt1.Rows(0).Item("area_desc")
                cbarea.Enabled = False



            End If

        End If

    End Sub

    Private Sub buscamax()
        conex("tareas")
        sql2 = "SELECT max(tarea_id)as ult From tareas ;"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)

        If IsDBNull(dt2.Rows(0).Item("ult")) Then
            ultnro = "1"
        Else
            ultnro = dt2.Rows(0).Item("ult") + 1
        End If
    End Sub

    Sub GuardaTarea()

        campos = "tarea_id,tarea_fchcre,tarea_emisor,tarea_fchini,tarea_fchfin,tarea_area,tarea_turno,tarea_asunto,tarea_desc"
        variables = "'" + ultnro + "','" + Now + "','" + Trim(txtemi.Text) + "','" + fchtarea + "','', " & _
        "'" + cbarea.Text + "','" + cbturno.Text + "','" + txttarea.Text + "','" + txtdesc.Text + "'"
        SQL3 = "INSERT INTO TAREAS (" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()


    End Sub

    Sub GuardaFrecuencia()

        campos = "tarea_id,frecu_id,frecu_cada,frecu_repe"
        variables = "'" + ultnro + "','" + frecuencia + "','" + txtdias.Text + "','" + txtrepeticiones.Text + "'"
        sql4 = "INSERT INTO TAREA_FRECU (" + campos + ") VALUES (" + variables + ")"
        cmd4 = New SqlCommand(sql4, cnn)
        cmd4.Connection.Open()
        cmd4.ExecuteNonQuery()
        cmd4.Connection.Close()



    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()

    End Sub
End Class
