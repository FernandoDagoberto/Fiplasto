Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework

Public Class LAVSoda
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String
    Dim cantidad, MaxCtrl As Integer
    Dim cantIng, cantEgr, cantDes, cantnuevos, cantbaja As String
    Dim cuba As Integer

    Private Sub LAVSoda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call verifica_fecha()
        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto
        cbgrupo.Focus()
    End Sub

    Private Sub verifica_fecha()
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            dtfecha.Value = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            dtfecha.Value = FormatDateTime(Now, DateFormat.ShortDate)
        End If
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        'chequeo turno y grupo
        If String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar los campos Turno y Grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        If chksoda.Checked = False And chkconce.Checked = False And chktemp.Checked = False Then
            MetroMessageBox.Show(Me, "Debe seleccionar al menos un registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If rbcuba1.Checked Then
            cuba = "1"
        ElseIf rbcuba2.Checked Then
            cuba = "2"
        End If

        If chksoda.Checked = True And String.IsNullOrEmpty(txtsoda.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar litros de soda agregados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtsoda.Focus()
            Exit Sub
        End If

        If chkconce.Checked = True And String.IsNullOrEmpty(txtconce.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar campo concentración", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtconce.Focus()
            Exit Sub
        End If


        If chktemp.Checked = True And String.IsNullOrEmpty(txttemp.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar campo temperatura", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txttemp.Focus()
            Exit Sub
        End If

        campos = "lavsoda_fecha, lavsoda_turno, lavsoda_grupo, lavsoda_cuba, lavsoda_lt, lavsoda_conce, lavsoda_temp, lavsoda_userid, lavsoda_bajaid, lavsoda_bajafch"
        variables = "'" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + Trim(Str(cuba)) + "', " &
        "'" + txtsoda.Text + "','" + txtconce.Text + "','" + txttemp.Text + "','" + user + "','0',''"

        SQL3 = "INSERT INTO LAVSODA (" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()
        MetroMessageBox.Show(Me, "Registro guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

        Call verifica_fecha()
        Call limpia()

        Call buscadatos()



    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub limpia()
        chksoda.Checked = False
        chkconce.Checked = False
        chktemp.Checked = False
    End Sub

    Private Sub conexion()
        conex("LAVADERO")
    End Sub

    Private Sub buscadatos()
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql1 = "SELECT lavsoda_id as ID, lavsoda_fecha as Fecha,lavsoda_turno as Turno,lavsoda_grupo as Grupo,lavsoda_cuba as Cuba " &
                ",lavsoda_lt as LT,lavsoda_conce as Conc,lavsoda_temp as Temp from LAVSODA " &
                " where  LAVSODA_FECHA>='" + fechaant + "' and LAVSODA_FECHA<='" + fch + "' and LAVSODA_bajaid='0' order by LAVSODA_fecha"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        dgIng.DataSource = dt1
        dgIng.Columns("ID").Visible = False

    End Sub

    Private Sub eliminalinea()

        'elimina la fila de la grilla
        sql4 = "select LAVSODA_userid from LAVSODA where LAVSODA_id='" + Trim(line) + "' and LAVSODA_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count
        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            sql4 = "update LAVSODA set LAVSODA_bajaid='" + user + "', LAVSODA_bajafch='" + Now + "' where  LAVSODA_id='" + Trim(line) + "' "
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call buscadatos()

        End If




    End Sub

    Private Sub dgIng_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgIng.Click
        If dgIng.SelectedRows.Count = 1 Then
            line = dgIng.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dgIng_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgIng.KeyUp
        If dgIng.SelectedRows.Count = 1 Then
            If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
            Else
                fechaborra = FormatDateTime(Now, DateFormat.ShortDate)

            End If

            If dtfecha.Text = fechaborra Then
                If e.KeyCode = Keys.Delete Then
                    ms = MetroMessageBox.Show(Me, "¿Desea eliminar la línea seleccionada?", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    If ms = 1 Then
                        Call eliminalinea()
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "No se pueden eliminar cargas de días anteriores", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos()

    End Sub


    Private Sub chksoda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksoda.CheckedChanged
        If chksoda.Checked = True Then
            txtsoda.Enabled = True
        Else
            txtsoda.Text = ""
            txtsoda.Enabled = False
        End If

    End Sub

    Private Sub chkconce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkconce.CheckedChanged
        If chkconce.Checked = True Then
            txtconce.Enabled = True
        Else
            txtconce.Text = ""
            txtconce.Enabled = False
        End If
    End Sub

    Private Sub chktemp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktemp.CheckedChanged
        If chktemp.Checked = True Then
            txttemp.Enabled = True
        Else
            txttemp.Text = ""
            txttemp.Enabled = False
        End If
    End Sub

    Private Sub rbcuba2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcuba2.CheckedChanged
        If rbcuba2.Checked = True Then
            Call limpia()
        End If
    End Sub

    Private Sub rbcuba1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcuba1.CheckedChanged
        If rbcuba1.Checked = True Then
            Call limpia()
        End If
    End Sub
End Class