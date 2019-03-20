Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient



Public Class TareasRep

    Inherits MetroFramework.Forms.MetroForm
    Dim fch As Date

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        fch = dtfecha.Text
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate)

        fecha = dthasta.Text

        If chktodos.Checked = True Then
            sector = "all"
        Else
            sector = cbsector.Text
        End If

        If rbsi.Checked = True Then
            estado = "S"
        ElseIf rbno.Checked = True Then
            estado = "N"
        ElseIf rbsr.Checked = True Then
            estado = "R"
        ElseIf rball.Checked = True Then
            estado = "all"
        End If

        nivdet = "tareas"

        ''***************************************
        Dim frmtnpic As New frmreppicadora
        frmtnpic.Show()



    End Sub

    'para saber el ultimo dia del mes  anterior
    Function UltimoDiaDelMesAnt(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMesAnt = DateSerial(Year(dtmFecha), Month(dtmFecha), 0)
    End Function

    'para saber el ultimo dia del mes 
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function

    Private Sub TareasRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargaarea()
    End Sub

    Sub cargaarea()
        conex("area")

        sql1 = "SELECT  AREA.AREA_DESC,PERFIL.PERFIL_CARGO,PERFIL.PERFIL_AREA FROM PERFIL INNER JOIN AREA ON PERFIL.PERFIL_AREA = AREA.AREA_ID INNER JOIN " & _
                " USUARIOS ON PERFIL.PERFIL_ID = USUARIOS.user_perfil where Usuarios.user_apenom='" + user + "'"

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        n = dt1.Rows.Count
        If n = 0 Then

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
    

   
    Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodos.CheckedChanged
        If chktodos.Checked = True Then
            cbsector.Enabled = False
        Else
            cbsector.Enabled = True

        End If
    End Sub
End Class