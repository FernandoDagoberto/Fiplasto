Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class Novedadesrep

    Inherits MetroFramework.Forms.MetroForm

    Private Sub Novedadesrep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call cargaarea()
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
                chktodos.Visible = False


            End If

        End If

    End Sub




    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click


        'fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate)
        'fecha = dthasta.Text





        'If chktodos.Checked = True Then
        '    sector = "all"
        'Else
        '    sector = cbsector.Text
        'End If

        'nivdet = "novedades"
        ''***************************************
        'Dim frmnov As New frmrepgenerales
        'frmnov.Show()

        If chktodos.Checked = True Then
            lineaD = "A"
            lineaH = "Z"
        Else
            lineaD = cbsector.Text
            lineaH = cbsector.Text
        End If

        fch = dtdesde.Text
        fechaant = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
        fecha = dthasta.Text & " 21:59:59"

        nivdet = "Novedades"
        Dim frmnove As New frmREPOViewVarios
        frmnove.Show()




    End Sub

    Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodos.CheckedChanged

        If chktodos.Checked = True Then
            cbsector.Enabled = False
        Else
            cbsector.Enabled = True

        End If
    End Sub
End Class