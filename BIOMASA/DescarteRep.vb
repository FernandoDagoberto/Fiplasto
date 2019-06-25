Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Imports System.Collections

Public Class DescarteRep
    Inherits MetroFramework.Forms.MetroForm
    Dim repo As String
    Dim reporte As New BioReporte
    Public Property Registros As New List(Of BiomasaPeso)



    Private Sub DescarteRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaTiposDescarte()
    End Sub

    Private Sub CargaTiposDescarte()
        Try
            Call conex("biodescarte")
            sql7 = "SELECT distinct(TIPMAD),CODMAD From BIODESCARTE"
            da7 = New SqlDataAdapter(sql7, cnn)
            dt7 = New DataTable
            da7.Fill(dt7)
            n = dt7.Rows.Count
            If n = 0 Then
                cbDescarte.DataSource = Nothing
            Else
                cbDescarte.DataSource = dt7
                cbDescarte.DisplayMember = "TIPMAD"
                cbDescarte.ValueMember = "CODMAD"
            End If
        Catch e As Exception
            MetroMessageBox.Show(Me, e.Message)
        End Try

    End Sub

    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click
        fch = dtdesde.Text
        reporte.FechaD = FormatDateTime(fch.AddDays(-1) & " 22:00:00", DateFormat.GeneralDate)
        reporte.FechaH = dthasta.Text & " 21:59:59"

        If chkTodos.Checked Then
            reporte.CodD = 0
            reporte.CodH = 999
            reporte.Tipo = "Todos"
        Else
            reporte.CodD = cbDescarte.SelectedValue
            reporte.CodH = cbDescarte.SelectedValue
            reporte.Tipo = cbDescarte.Text
        End If

        Registros = reporte.DescarteBio


        If chkTriturado.Checked And chkSinTriturar.Checked Then
            reporte.query = (From reg In Registros
                             Select reg)


        ElseIf chkTriturado.Checked And Not chkSinTriturar.Checked Then
            reporte.query = From reg In Registros()
                            Where reg.FECHAPICADO IsNot Nothing
                            Select reg
        Else
            reporte.query = From reg In Registros.AsEnumerable()
                            Where reg.FECHAPICADO Is Nothing
                            Select reg

        End If



        nivdet = "DescarteBio"

        Dim frmPICREPO As New frmREPOViewBiomasa(reporte)
        frmPICREPO.Show()


    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        If chkTodos.Checked = True Then
            cbDescarte.Enabled = False
        Else
            cbDescarte.Enabled = True
        End If

    End Sub
End Class