Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework

Public Class HsProdParRep
    Inherits MetroFramework.Forms.MetroForm

    Dim fch As Date

    Private Sub HsProdParRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargaarea()
        chktodos.Checked = True

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


    Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodos.CheckedChanged
        If chktodos.Checked = True Then
            cbarea.DataSource = Nothing
            cbarea.Enabled = False
        Else
            Call cargaarea()
            cbarea.Enabled = True
        End If
    End Sub

    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click
        fch = dtdesde.Text
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate)
        fecha = dthasta.Text
        area = cbarea.Text

        If chktodos.Checked = True Then
            area = "all"
        Else
            area = cbarea.Text
        End If

        nivdet = "hsprod"

        '***************************************
        Dim frmtnpicmens As New frmreppicadora
        frmtnpicmens.Show()
    End Sub
End Class