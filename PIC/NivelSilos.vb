Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class NivelSilos
    Inherits MetroFramework.Forms.MetroForm
    Dim nivel1 As String
    Dim nivel2 As String
    Dim nivel3 As String
    Dim entsal As String 'ENTradaSALida

    Private Sub NivelSilos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call llenaSilo1()
        Call llenaSilo2()
        Call llenaSilo3()


        nivel1 = cbsilo1.SelectedValue
        nivel2 = cbsilo2.SelectedValue
        nivel3 = cbsilo3.SelectedValue
        nivel(nivel1, pbsilo1)
        nivel(nivel2, pbsilo2)
        nivel(nivel3, pbsilo3)



    End Sub


    Sub llenaSilo1()
        conex("fiplanew")
        sql1 = "SELECT * From NIVELSILO"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        cbsilo1.DataSource = dt1
        cbsilo1.DisplayMember = "nivelsilo_DESC"
        cbsilo1.ValueMember = "nivelsilo_id"

    End Sub

    Sub llenaSilo2()
        sql2 = "SELECT * From NIVELSILO"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)

        cbsilo2.DataSource = dt2
        cbsilo2.DisplayMember = "nivelsilo_DESC"
        cbsilo2.ValueMember = "nivelsilo_id"
    End Sub

    Sub llenaSilo3()
        SQL3 = "SELECT * From NIVELSILO"
        da3 = New SqlDataAdapter(SQL3, cnn)
        dt3 = New DataTable
        da3.Fill(dt3)

        cbsilo3.DataSource = dt3
        cbsilo3.DisplayMember = "nivelsilo_DESC"
        cbsilo3.ValueMember = "nivelsilo_id"
    End Sub

    Private Sub cbsilo1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbsilo1.SelectionChangeCommitted
        nivel1 = cbsilo1.SelectedValue

        'llamar a Función nivel
        nivel(nivel1, pbsilo1)


    End Sub

    Private Sub cbsilo2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbsilo2.SelectionChangeCommitted

        nivel2 = cbsilo2.SelectedValue

        'Llamar a Función Nivel
        nivel(nivel2, pbsilo2)

    End Sub


    Private Sub cbsilo3_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbsilo3.SelectionChangeCommitted
        nivel3 = cbsilo3.SelectedValue

        'Llamar a Función Nivel
        nivel(nivel3, pbsilo3)

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncargar.Click

        If cbgrupo.Text = "" Or cbturno.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de ingresar Turno y Grupo")
            cbturno.Focus()
            Exit Sub


        Else

            Call guardar()



        End If

    End Sub


    Sub guardar()

        sql = "select * from silos where silos_fecha between '" + FormatDateTime(Now, DateFormat.ShortDate) + " 00:00:00' and '" + FormatDateTime(Now, DateFormat.ShortDate) + " 23:59:59' and silos_entsal='S' and silos_turno='" + cbturno.Text + "' "
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count
        If n = 0 Then
            campos = "SILOS_FECHA,SILOS_ENTSAL,SILOS_TURNO,SILOS_GRUPO,SILOS_SILO1,SILOS_SILO2,SILOS_SILO3,SILOS_USERID"
            variables = "'" + Now + "','S','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbsilo1.Text + "','" + cbsilo2.Text + "','" + cbsilo3.Text + "','" + user + "'"

            sql4 = "insert into SILOS (" + campos + ")values (" + variables + ")"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()
            MetroMessageBox.Show(Me, "Nivel de Silos cargado correctamente")
            Call limpiar()

        Else
            MetroMessageBox.Show(Me, "Ya esta cargado el Nivel de Silos de este Turno y Grupo")

        End If

    End Sub

    Sub limpiar()
        cbturno.Text = Nothing
        cbgrupo.Text = Nothing
    End Sub


    Private Sub cbsilo1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbsilo1.SelectedIndexChanged

    End Sub
End Class