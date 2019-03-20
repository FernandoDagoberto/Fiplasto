Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework

Public Class password
    Inherits MetroFramework.Forms.MetroForm

    Dim clave As String

    Private Sub password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call buscauser()
        btncambiar.Enabled = False
    End Sub

    Sub buscauser()
        sql = "select * from usuarios where user_apenom='" + user + "'"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        lblusu.Text = dt.Rows(0).Item("user_id")
        clave = dt.Rows(0).Item("user_pass")

    End Sub



    Private Sub btncambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncambiar.Click

        If String.IsNullOrEmpty(txtnc.Text) And String.IsNullOrEmpty(txtrc.Text) Then
            MetroMessageBox.Show(Me, "No se permiten contraseñas vacias", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtnc.Focus()

        Else
            sql1 = "select * from usuarios where user_id='" + lblusu.Text + "' and user_pass='" + txtca.Text + "'"
            da1 = New SqlDataAdapter(sql1, cnn)
            dt1 = New DataTable
            da1.Fill(dt1)
            n = dt1.Rows.Count

            If n = 0 Then
                MetroMessageBox.Show(Me, "Contraseña anterior incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtca.Text = Nothing
                txtca.Focus()

            Else
                sql2 = "update usuarios set user_pass='" + txtnc.Text + "' where user_id='" + lblusu.Text + "'"
                cmd2 = New SqlCommand(sql2, cnn)
                cmd2.Connection.Open()
                cmd2.ExecuteNonQuery()
                cmd2.Connection.Close()
                MetroMessageBox.Show(Me, "Contraseña cambiada correctamente" + Chr(13) + "Reingrese al sistema", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Me.Close()
                MenuPrincipal.Close()
            End If
        End If
    End Sub

    Private Sub txtrc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrc.LostFocus
        If txtnc.Text = txtrc.Text Then
            btncambiar.Enabled = True

        Else
            MetroMessageBox.Show(Me, "No coinciden las nuevas contraseñas, repita la operación", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtnc.Text = Nothing
            txtrc.Text = Nothing
            txtnc.Focus()

            btncambiar.Enabled = False
        End If

    End Sub


End Class