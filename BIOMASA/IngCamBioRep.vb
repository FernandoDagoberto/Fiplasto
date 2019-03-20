Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class IngCamBioRep

    Inherits MetroFramework.Forms.MetroForm
    Dim repo As String

   


    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click
        If repo = "Crystal" Then
            'un día menos que la fecha desde para luego al buscar en el reporte busque desde las 22:00 del día anterior.
            fch = dtdesde.Text
            fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate)

            'fecha hasta
            fecha = dthasta.Text

            If rbtodos.Checked = True Then
                nivdet = "IngCamion"
            Else
                nivdet = "NcRechazados"
            End If

            '***************************************
            Dim frmpic As New frmreppicadora
            frmpic.Show()

        Else
            fch = dtdesde.Text
            fechaant = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
            fecha = dthasta.Text & " 21:59:59"

            If rbcontrol.Checked = True Then
                nivdet = "CtrlCamion"
            Else
                nivdet = "Rajadora"

            End If

            Dim frmPICREPO As New frmREPOViewPic
            frmPICREPO.Show()


        End If

    End Sub


    Private Sub rbnc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnc.CheckedChanged
        repo = "Crystal"
    End Sub


    Private Sub rbtodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtodos.CheckedChanged
        repo = "Crystal"
    End Sub

    Private Sub rbcontrol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcontrol.CheckedChanged
        repo = "RepoView"
    End Sub

    Private Sub rbrajadora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbrajadora.CheckedChanged
        repo = "RepoView"
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbCamion.Enter
        rbrajadora.Checked = False
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbRajadora.Enter
        rbcontrol.Checked = False
        rbnc.Checked = False
        rbtodos.Checked = False
    End Sub


End Class