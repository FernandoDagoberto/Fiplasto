Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Deployment.Application
Public Class Login

    Private Sub btnno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnno.Click
        Me.Close()
        End
    End Sub

    Private Sub btnsi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsi.Click
        Call aceptar()
    End Sub
    Private Sub buscauser()
        conex("usuario")
        sql1 = "SELECT * From usuarios where user_id='" + txtusua.Text + "' and user_pass='" + txtpass.Text + "' "
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        n = dt1.Rows.Count
        If n = 0 Then
            s = 1
        Else
            s = 2
        End If
    End Sub
    Private Sub aceptar()
        If txtusua.Text.Length > 7 Then
            If txtusua.Text.Substring(0, 7) = "prueba\" Then
                BDSelection = "P"
                txtusua.Text = txtusua.Text.Substring(7)
            End If
        End If

        Call buscauser()
        If s = 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Usuario o Contraseña Inexistente", "Error de logueo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusua.Text = ""
            txtpass.Text = ""
            txtusua.Focus()
        Else
            'si da OK
            perfil = dt1.Rows(0).Item("user_perfil")
            user = dt1.Rows(0).Item("user_apenom")
            Login.ActiveForm.Close()
            datosini()
        End If

    End Sub

    Private Sub txtpass_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyUp
        If e.KeyCode = Keys.Enter Then
            Call aceptar()
        End If
    End Sub






End Class