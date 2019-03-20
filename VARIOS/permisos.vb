Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class permisos

    Dim MNU As String
    Dim mnuresta As String
    Dim y As String
    Dim h As String
    Dim menu1 As String

    Private Sub permisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call llenamenu()
        Call llenaperfil()
        Call selecciones()
    End Sub
    Sub llenamenu()
        conex("menup")
        sql1 = "SELECT * From MENU order by menu_desc"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
        n1 = dt1.Rows.Count
        If n1 <> 0 Then
            lbmenu.DataSource = dt1
            lbmenu.DisplayMember = "menu_desc"
            lbmenu.ValueMember = "menu_cod"
        Else

        End If
    End Sub
    Sub llenaperfil()
        llenacb("Perfil")
        cbperfil.DataSource = dt7
        cbperfil.DisplayMember = "perfil_desc"
        cbperfil.ValueMember = "perfil_id"

    End Sub






    Private Sub cbperfil_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbperfil.SelectionChangeCommitted
        lblperfil.Text = cbperfil.SelectedValue
        For z = 0 To n1 - 1

            Dim menu As String
            menu = dt1.Rows(z).Item("menu_cod")
            lbmenu.SetItemChecked(z, False)


        Next

        'Para ver las opciones que tiene el perfil
        Call selecciones()

    End Sub

    Sub selecciones()
        conex("menup")
        sql2 = "SELECT * From MNUPerfil where MNUPerfil_id='" + Trim(cbperfil.SelectedValue) + "'"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)
        n = dt2.Rows.Count

        If n <> 0 Then

            For x = 0 To n - 1
                Dim perfil As String
                perfil = (dt2.Rows(x).Item("mnuperfil_menu"))

                For z = 0 To n1 - 1

                    Dim menu As String
                    menu = dt1.Rows(z).Item("menu_cod")
                    If menu = perfil Then

                        lbmenu.SetItemChecked(z, True)

                    End If
                Next
            Next
        End If
    End Sub


    Private Sub cmdactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdactualizar.Click
        Call eliminar()

        Dim i As Integer
        Dim s As String
        s = "Checked Items:" & ControlChars.CrLf
        For i = 0 To (lbmenu.Items.Count - 1)
            If lbmenu.GetItemChecked(i) = True Then
                s = (i).ToString
                menu1 = dt1.Rows(s).Item("menu_cod")

                Call grabar()
            End If
        Next
        MetroMessageBox.Show(Me, "Permisos actualizados al perfil: " & cbperfil.Text, "Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Question)

    End Sub


    Sub eliminar()
        'elimina todas las opciones del perfil para permitir cargar las nuevas
        sql4 = "delete from mnuperfil where mnuperfil_id='" + cbperfil.SelectedValue + "'"
        cmd4 = New SqlCommand(sql4, cnn)
        cmd4.Connection.Open()
        cmd4.ExecuteNonQuery()
        cmd4.Connection.Close()

    End Sub


    Sub grabar()
        conex("mnuperfil")
        campos = "mnuperfil_id,mnuperfil_menu"
        variables = "'" + Trim(cbperfil.SelectedValue) + "','" + menu1 + "'"

        SQL3 = "INSERT INTO mnuperfil(" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()




    End Sub

End Class