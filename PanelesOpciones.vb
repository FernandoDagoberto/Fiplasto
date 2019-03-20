Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class PanelesOpciones

    Dim menu1 As String
    Dim max As Integer


    Private Sub PanelesOpciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Reportes()
        Call selecciones()

    End Sub

    Private Sub Reportes()
        conex("menup")
        sql1 = "select * from paneles order by id"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        n1 = dt1.Rows.Count
        If n1 <> 0 Then
            chklb.DataSource = dt1
            chklb.DisplayMember = "titulo"
            chklb.ValueMember = "id"
        Else

        End If

    End Sub

    Private Sub conexion()
        conex("paneles")
    End Sub





    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Call eliminar()

        Dim i As Integer
        Dim s As String
        s = "Checked Items:" & ControlChars.CrLf
        For i = 0 To (chklb.Items.Count - 1)
            If chklb.GetItemChecked(i) = True Then

                s = (i).ToString
                menu1 = dt1.Rows(s).Item("id")

                Call grabar()
            End If
        Next


        Me.Close()


    End Sub

    Sub eliminar()
        'elimina todas las opciones del perfil para permitir cargar las nuevas

        sql4 = "delete from panel_usu where user_id='" + user + "'"
        cmd4 = New SqlCommand(sql4, cnn)
        cmd4.Connection.Open()
        cmd4.ExecuteNonQuery()
        cmd4.Connection.Close()

    End Sub

    Sub grabar()
        conex("panel_usu")
        campos = "user_id,panel_id"
        variables = "'" + user + "','" + menu1 + "'"


        SQL3 = "INSERT INTO panel_usu(" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()
    End Sub



    Sub selecciones()
        conex("panel_usu")
        sql2 = "SELECT * From panel_usu where user_id='" + user + "'"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)
        n = dt2.Rows.Count

        If n <> 0 Then

            For x = 0 To n - 1
                Dim perfil As String
                perfil = (dt2.Rows(x).Item("panel_id"))

                For z = 0 To n1 - 1

                    Dim menu As String
                    menu = dt1.Rows(z).Item("id")
                    If menu = perfil Then

                        chklb.SetItemChecked(z, True)

                    End If

                Next

            Next

        End If

    End Sub



    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub chklb_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chklb.SelectedValueChanged
        max = 0
        For i = 0 To (chklb.Items.Count - 1)
            If chklb.GetItemChecked(i) = True Then

                If max = 4 Then
                    MetroMessageBox.Show(Me, "Ya seleccionó cuatro opciones")

                    id1 = chklb.SelectedIndex
                    chklb.SetItemChecked(id1, False)

                Else
                    max = max + 1

                End If
            End If
        Next
    End Sub
End Class