Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework

Public Class MadePicRep
    Inherits MetroFramework.Forms.MetroForm
    Dim fch As Date

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If rbdiario.Checked = True Then

            If chktodos.Checked = False And cbturno.Text = "" Then
                MetroMessageBox.Show(Me, "Favor de seleccionar turno", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbturno.Focus()
                Exit Sub
            End If

            If chktodos.Checked = False Then
                turnoD = cbturno.Text
                turnoH = cbturno.Text
            Else
                turnoD = 0
                turnoH = 9999
            End If


            fch = dtfecha.Text
            fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " 22:00:00"
            fecha = dthasta.Text & " 21:59:59"

            nivdet = "tnpic"

            '***************************************


        ElseIf rbmens.Checked = True Then

            If chktodosmens.Checked = False And cbturnomens.Text = "" Then
                MetroMessageBox.Show(Me, "Favor de seleccionar turno", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbturnomens.Focus()
                Exit Sub
            End If

            If chktodosmens.Checked = False Then
                turnoD = cbturnomens.Text
                turnoH = cbturnomens.Text
            Else
                turnoD = 0
                turnoH = 9999
            End If

            fechaant = UltimoDiaDelMesAnt(dtfechamens.Value)
            fecha = UltimoDiaDelMes(dtfechamens.Value)

            nivdet = "tnpicmens"

            '***************************************
        End If


        Dim frmrepo As New frmREPOViewPic
        frmrepo.Show()

    End Sub

    'para saber el primer dia del mes 
    Function UltimoDiaDelMesAnt(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMesAnt = DateSerial(Year(dtmFecha), Month(dtmFecha), 0)
    End Function

    'para saber el ultimo dia del mes 
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function




    Private Sub chktodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodos.CheckedChanged
        If chktodos.Checked = True Then
            turno = "all"
            cbturno.Text = Nothing
            cbturno.Enabled = False

        Else
            cbturno.Enabled = True

        End If
    End Sub

    Private Sub rbdiario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdiario.CheckedChanged
        If rbdiario.Checked = True Then
            gbdia.Visible = True
            gbmens.Visible = False
        End If
    End Sub

    Private Sub rbmens_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbmens.CheckedChanged
        If rbmens.Checked = True Then
            gbmens.Visible = True
            gbdia.Visible = False
        End If
    End Sub

    Private Sub chktodosmens_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodosmens.CheckedChanged
        If chktodosmens.Checked = True Then
            turno = "all"
            cbturnomens.Text = Nothing
            cbturnomens.Enabled = False

        Else
            cbturnomens.Enabled = True

        End If
    End Sub
End Class