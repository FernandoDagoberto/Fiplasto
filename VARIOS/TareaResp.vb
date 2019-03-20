Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Public Class TareaResp

    Inherits MetroFramework.Forms.MetroForm

    Dim realizado As String

    Private Sub TareaResp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Reducir el ancho
        Me.Width = 410

        lbltareaid.Text = tareaID
        lbltareafch.Text = tareaFecha

        If tareaFecha < FormatDateTime(Now, DateFormat.ShortDate) Then
            lbltareafch.ForeColor = Color.Red
        End If

        lbltareaarea.Text = tareaArea
        lbltareaturno.Text = tareaTurno
        lbltareaasunto.Text = tareaAsunto
        lbltareadesc.Text = tareaDescripcion


    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If rbsi.Checked = True Then
            realizado = "S"

        ElseIf rbno.Checked = True Then
            realizado = "N"
        End If
        sql = "update tareas set tarea_estado='" + realizado + "' , tarea_fchestado='" + Now + "' , tarea_obs='" + txtobs.Text + "', tarea_userid='" + user + "'  " &
        "where tarea_id='" + lbltareaid.Text + "' and tarea_fchini='" + lbltareafch.Text + "'  and tarea_area='" + lbltareaarea.Text + "'"
        cmd1 = New SqlCommand(sql, cnn)
        cmd1.Connection.Open()
        cmd1.ExecuteNonQuery()
        cmd1.Connection.Close()


        Me.Close()


    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnResponder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResponder.Click
        Me.Width = 769
        btnResponder.Enabled = False
    End Sub
End Class