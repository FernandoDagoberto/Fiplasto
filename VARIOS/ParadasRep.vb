Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework

Public Class ParadasPicRep
    Inherits MetroFramework.Forms.MetroForm
    Dim fch As Date

    Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodos.CheckedChanged
        If chktodos.Checked = True Then
            cbequipo.DataSource = Nothing
            cbequipo.Enabled = False
        Else
            Call llenaequipo()
            cbequipo.Enabled = True
        End If
    End Sub

    Private Sub ParadasPicRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargaarea()
        chktodos.Checked = True

    End Sub

    Sub llenaequipo()

        sql4 = "select sector_desc,sector_id from sector inner join area on sector.area_id=area.area_id where area.area_desc='" + cbarea.Text + "'"

        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)

        cbequipo.DataSource = dt4
        cbequipo.DisplayMember = "sector_desc"
        cbequipo.ValueMember = "sector_id"

    End Sub



    Private Sub rbequipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbequipo.CheckedChanged
        If rbequipo.Checked = True Then

            lbldesde.Visible = True
            dtdesde.Visible = True
            chktodos.Checked = True
            cbequipo.DataSource = Nothing

            lblhasta.Visible = True
            dthasta.Visible = True
            lblmes.Visible = False
            dtmes.Visible = False
        End If
    End Sub

    Private Sub rbmensual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbmensual.CheckedChanged
        If rbmensual.Checked = True Then

            lbldesde.Visible = False
            dtdesde.Visible = False
            chktodos.Checked = True
            cbequipo.DataSource = Nothing

            lblhasta.Visible = False
            dthasta.Visible = False
            lblmes.Visible = True
            dtmes.Visible = True
        End If
    End Sub

    Private Sub rbdiario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdiario.CheckedChanged
        If rbdiario.Checked = True Then

            lbldesde.Visible = True
            dtdesde.Visible = True
            chktodos.Checked = True
            cbequipo.DataSource = Nothing

            lblhasta.Visible = False
            dthasta.Visible = False
            lblmes.Visible = False
            dtmes.Visible = False
        End If
    End Sub

    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click


        fch = dtdesde.Text
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " 22:00:00"
        fecha = dtdesde.Text & " 21:59:59"
        area = cbarea.Text

        If chktodos.Checked = True Then
            equipo = "all"
        Else
            equipo = cbequipo.Text
        End If



        sql = "SELECT     PARADAMAQ.area, PARADAMAQ.linea, PARADAMAQ.Fecha, PARADAMAQ.turno, PARADAMAQ.grupo, PARADAMAQ.tiempo1, PARADAMAQ.tiempo2, PARADAMAQ.tiempo, 
                      PARADAMAQ.causa, PARADAMAQ.motivo_id, PARADAMAQ.eq_cod, PARADAMAQ.eq_desc, PARADAMAQ.parada, PARADAS.PARADAS_DESC, PARADAMAQ.observacion, 
                      PARADAMAQ.reparo, PARADAMAQ.user_alta, PARADAMAQ.fch_alta, PARADAMAQ.user_mod, PARADAMAQ.fch_mod, PARADAMAQ.orden, PARADAMAQ.orden1
                      FROM         PARADAMAQ INNER JOIN
                      PARADAS ON PARADAS.PARADAS_ID = PARADAMAQ.parada
                        where
                        paradamaq.area='" + area + "' and
                        PARADAMAQ.Fecha>='" + fechaant + "' and PARADAMAQ.Fecha<='" + fecha + "' and
                        PARADAMAQ.eq_desc='" + equipo + "'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)



        If rbdiario.Checked = True Then

            nivdet = "diario"
            '***************************************
            Dim frmparpic As New frmreppicadora
            frmparpic.Show()


            Dim repo As New frmREPOViewPic
            repo.Show()



        ElseIf rbequipo.Checked = True Then

            'Código cuando seleccionan por equipo
            fecha = dthasta.Text
            nivdet = "PorEquipo"
            '***************************************
            Dim frmparpic As New frmreppicadora
            frmparpic.Show()


        Else
            'Código Reporte Mensual

            fechaant = UltimoDiaDelMesAnt(dtmes.Value)
            fecha = UltimoDiaDelMes(dtmes.Value)

            nivdet = "ParadaMensual"

            '***************************************
            Dim frmtnpicmens As New frmreppicadora
            frmtnpicmens.Show()

        End If
    End Sub

    'para saber el ultimo día de mes anterior
    Function UltimoDiaDelMesAnt(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMesAnt = DateSerial(Year(dtmFecha), Month(dtmFecha), 0)
    End Function

    'para saber el ultimo dia del mes 
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function

    Sub cargaarea()
        conex("area")

        sql2 = "SELECT  AREA.AREA_DESC,PERFIL.PERFIL_CARGO,PERFIL.PERFIL_AREA FROM PERFIL INNER JOIN AREA ON PERFIL.PERFIL_AREA = AREA.AREA_ID INNER JOIN " &
                " USUARIOS ON PERFIL.PERFIL_ID = USUARIOS.user_perfil where Usuarios.user_apenom='" + user + "'"

        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)
        n = dt2.Rows.Count
        If n = 0 Then

            MetroMessageBox.Show(Me, "El usuario no tiene perfil para cargar novedades")
            Me.Close()

        Else

            If dt2.Rows(0).Item("perfil_cargo") = "S" Then

                Dim whe As String
                whe = "where area_relacion ='" + Trim(dt2.Rows(0).Item("perfil_area")) + "'"

                llenacbwhere("area", whe)

                cbarea.DataSource = dt9
                cbarea.DisplayMember = "area_desc"
                cbarea.ValueMember = "area_desc"


            Else

                'Si no es supervisor carga el area del operario

                cbarea.Text = dt2.Rows(0).Item("area_desc")
                cbarea.Enabled = False



            End If

        End If

    End Sub




    Private Sub cbarea_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        If chktodos.Checked = True Then
            cbequipo.DataSource = Nothing
            cbequipo.Enabled = False
        Else
            Call llenaequipo()
            cbequipo.Enabled = True
        End If
    End Sub

End Class