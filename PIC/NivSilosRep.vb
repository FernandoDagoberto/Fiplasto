Public Class NivSilosRep

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'un día menos que la fecha desde para luego al buscar en el reporte busque desde las 22:00 del día anterior.
        fechaant = dtfecha.Text & " 00:00:00"
        'fecha hasta
        fecha = dtfecha.Text & " 23:59:59"

        nivdet = "nivelsilos"

        Dim repo As New frmREPOViewPic
        repo.Show()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

End Class
