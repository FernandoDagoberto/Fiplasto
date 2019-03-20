Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class LAVREPARACION
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String
    Dim cantidad, MaxCtrl As Integer
    Dim averia As String
    Dim averia1, averia2 As String

    Private Sub LAVREPARACION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call buscadatos()

        Call buscaMotivo()
        chkmot.DataSource = dt2
        chkmot.DisplayMember = "lavmotrep_desc"
        chkmot.ValueMember = "lavmotrep_id"

        gbInox.Enabled = False

    End Sub

    Private Sub conexion()
        conex("LAVTDH")
    End Sub

    Private Sub buscadatos()
        Call conexion()

        sql1 = "SELECT lavtdh_id as ID,lavtdh_fecha as Fecha,lavtdh_ntejido as Tejido,lavtdh_razon as Razon from LAVTDH " &
            "where lavtdh_ingegr='R'  and (lavtdh_reparado is null or lavtdh_reparado='N')"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)


        cant = dt1.Rows.Count
        If cant <> 0 Then
            'dg.Select(0)
        End If

        SQL3 = "SELECT lavinox_id as ID,lavinox_fecha as Fecha,lavinox_ninox as NInox,lavinox_razon as Razon from LAVINOX " &
             "where lavinox_ingegr ='R' and (lavinox_reparado is null or lavinox_reparado='N')"
        da3 = New SqlDataAdapter(SQL3, cnn)
        dt3 = New DataTable
        da3.Fill(dt3)
        cantidad = dt3.Rows.Count
        If cantidad <> 0 Then
            'dg.Select(0)
        End If

        dg.DataSource = dt1
        dgInox.DataSource = dt3


    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick

        If dg.SelectedRows.Count = 1 Then
            line = dg.CurrentRow.Cells("ID").Value
            ms = MetroMessageBox.Show(Me, "¿Desea confirmar la reparación?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If ms = 1 Then
                Call confirmaReparacion()
            End If

        End If

    End Sub

    Private Sub confirmaReparacion()
        sql4 = "update LAVTDH set LAVTDH_reparado='S',LAVTDH_fchrep='" + Now + "' where LAVTDH_id='" + Trim(line) + "'"
        cmd4 = New SqlCommand(sql4, cnn)
        cmd4.Connection.Open()
        cmd4.ExecuteNonQuery()
        cmd4.Connection.Close()

        Call buscadatos()
        If dt1.Rows.Count <> 0 Then
            'dg.Select(0)
        Else

        End If
    End Sub

    Private Sub buscaMotivo()
        Call conexion()

        sql2 = "select * from LAVMOTREP order by LAVMOTREP_DESC"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)

    End Sub

    Private Sub dgInox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgInox.DoubleClick
        If dgInox.SelectedRows.Count = 1 Then
            line = dgInox.CurrentRow.Cells("ID").Value
            MetroMessageBox.Show(Me,"Indicar reparaciones realizadas")
            gbInox.Enabled = True
            chkmot.Focus()
        End If
    End Sub

    Private Sub chkmot_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkmot.SelectedValueChanged
        Call buscaChek()
    End Sub

    Private Sub buscaChek()
        Dim i As Integer
        Dim s As String
        Dim max As Integer

        s = "Checked Items:" & ControlChars.CrLf
        For i = 0 To (chkmot.Items.Count - 1)
            If chkmot.GetItemChecked(i) = True Then
                If max = 2 Then
                    MetroMessageBox.Show(Me, "Ya seleccionó dos opciones", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    id1 = chkmot.SelectedIndex
                    chkmot.SetItemChecked(id1, False)
                Else
                    s = (i).ToString
                    averia = dt2.Rows(s).Item("lavmotrep_id")
                    max = max + 1
                End If
            End If
        Next
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim i As Integer
        Dim s As String
        s = "Checked Items:" & ControlChars.CrLf
        For i = 0 To (chkmot.Items.Count - 1)
            If chkmot.GetItemChecked(i) = True Then
                s = (i).ToString

                If averia1 = "" Then
                    averia1 = dt2.Rows(s).Item("lavmotrep_id")
                    chkmot.SetItemChecked(i, False)
                Else
                    averia2 = dt2.Rows(s).Item("lavmotrep_id")
                    chkmot.SetItemChecked(i, False)
                End If
            End If
        Next

        If averia1 = "" Then
            MetroMessageBox.Show(Me, "Favor de seleccionar reparaciones realizadas", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            ms = MetroMessageBox.Show(Me, "¿Desea confirmar la reparación?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If ms = 1 Then
                sql4 = "update LAVINOX set LAVINOX_reparado='S',LAVINOX_fchrep='" + Now + "',LAVINOX_mot1='" + averia1 + "',LAVINOX_mot2='" + averia2 + "' where LAVINOX_id='" + Trim(line) + "'"
                cmd4 = New SqlCommand(sql4, cnn)
                cmd4.Connection.Open()
                cmd4.ExecuteNonQuery()
                cmd4.Connection.Close()

                averia1 = ""
                averia2 = ""

                gbInox.Enabled = False
                Call buscadatos()

            Else
                averia1 = ""
                averia2 = ""

                gbInox.Enabled = False
                Call buscadatos()
            End If

        End If

    End Sub

End Class