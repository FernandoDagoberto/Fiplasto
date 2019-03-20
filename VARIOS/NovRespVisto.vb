Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class NovRespVisto

    Inherits MetroFramework.Forms.MetroForm

    Dim realizado As String
    Dim ms As Integer

    Private Sub NovRespVisto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblfch.Text = novFCH

        If novFCH < FormatDateTime(Now, DateFormat.ShortDate) Then
            lblfch.ForeColor = Color.Red
        End If

        lblarea.Text = novAREA
        lblmotivo.Text = novMOTIVO
        lblusuario.Text = novUSER
        lbltexto.Text = novTEXTO
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvisto.Click
        ms = MetroMessageBox.Show(Me, "Usted:  '" + user + "' está dando visto a esta novedad. ¿Está de acuerdo?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If ms = 1 Then
            sql = "update novedades set nov_visto='S' , nov_vistofch='" + Now + "' , nov_vistouser='" + user + "'  " &
            "where nov_fecha='" + lblfch.Text + "' and nov_motivo='" + lblmotivo.Text + "'  and nov_area='" + lblarea.Text + "' " &
            "and nov_user='" + lblusuario.Text + "'"
            cmd1 = New SqlCommand(sql, cnn)
            cmd1.Connection.Open()
            cmd1.ExecuteNonQuery()
            cmd1.Connection.Close()
        Else
        End If
        Me.Close()


    End Sub

End Class