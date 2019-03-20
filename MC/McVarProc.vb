Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework

Public Class McVarProc
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl As String
    Dim cantidad As Integer

    Private Sub McVarProc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto

        Call verifica_fecha()
        Call buscadatos()
    End Sub

    Private Sub verifica_fecha()
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            dtfecha.Value = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            dtfecha.Value = FormatDateTime(Now, DateFormat.ShortDate)
        End If
    End Sub

    Private Sub cbmc_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbmc.SelectionChangeCommitted
        Call llenacbwhere("mcmaterial", "where material_mc='" + cbmc.Text + "'")
        cbmaterial.DataSource = dt9
        cbmaterial.DisplayMember = "material_medmm"
        cbmaterial.ValueMember = "material_medmm"
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        If cbmaterial.Text = "" Or cbturno.Text = "" Or cbgrupo.Text = "" Or cbmaterial.Text = "" Or Trim(txtvel.Text) = "" Or Trim(txtantiesp.Text) = "" Or Trim(txtlargohh.Text) = "" Or Trim(txtanchohh.Text) = "" Or Trim(txttempulpa.Text) = "" Or Trim(txtcauefl.Text) = "" Or Trim(txt1a2.Text) = "" Or Trim(txt2a3.Text) = "" Or Trim(txttqbl.Text) = "" Then
            MetroMessageBox.Show(Me, "Favor de completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
            Else
                fechaborra = FormatDateTime(Now, DateFormat.ShortDate)
            End If

            fch = FormatDateTime(fechaborra, DateFormat.ShortDate) & " " & "05:59:59"
            fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

            fecha = FormatDateTime(Now, DateFormat.ShortDate)

            If cbturno.Text = "22-06" Then
                sql = "select count(vdp_mc) as cantidad from MCVARPROC where vdp_fecha>='" + fechaant + "' and vdp_fecha<='" + fch + "' and vdp_turno='" + cbturno.Text + "' and vdp_mc='" + cbmc.Text + "' and vdp_bajaid='0'"
            Else
                sql = "select count(vdp_mc)as cantidad from MCVARPROC where vdp_fecha>='" + fecha & " " & "00:00:00" + "' and vdp_fecha<='" + fecha & " " & "23:59:59" + "' and vdp_turno='" + cbturno.Text + "' and vdp_mc='" + cbmc.Text + "' and vdp_bajaid='0'"

            End If

            da = New SqlDataAdapter(sql, cnn)
            dt = New DataTable
            da.Fill(dt)
            If IsDBNull(dt.Rows(0).Item("cantidad")) Then
                cantidad = 0
            Else
                cantidad = dt.Rows(0).Item("cantidad")
            End If

            If cantidad >= 3 Then
                MetroMessageBox.Show(Me, "Ya realizó las 3 cargas permitidas a sú turno", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Call limpia()
            Else
                campos = "vdp_mc,vdp_fecha,vdp_turno,vdp_grupo,vdp_material,vdp_veloc,vdp_antiespum,vdp_largohh,vdp_anchohh,vdp_tempulpa, " &
                            "vdp_cauaeflu,vdp_concentq1a2,vdp_concentq2a3,vdp_temptab,vdp_userid,vdp_bajaid"
                variables = "'" + cbmc.Text + "','" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbmaterial.Text + "','" + Trim(txtvel.Text) + "','" + Trim(txtantiesp.Text) + "', " &
                "'" + Trim(txtlargohh.Text) + "','" + Trim(txtanchohh.Text) + "','" + Trim(txttempulpa.Text) + "','" + Trim(txtcauefl.Text) + "','" + Trim(txt1a2.Text) + "', " &
                "'" + Trim(txt2a3.Text) + "','" + Trim(txttqbl.Text) + "','" + user + "','0'"

                SQL3 = "INSERT INTO MCVARPROC (" + campos + ") VALUES (" + variables + ")"
                cmd3 = New SqlCommand(SQL3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()
                MetroMessageBox.Show(Me, "Variables correctamente guardadas", "", MessageBoxButtons.OK, MessageBoxIcon.Question)

                Call verifica_fecha()
                Call buscadatos()
                Call limpia()

            End If
        End If
    End Sub

    Private Sub limpia()

        txtvel.Text = ""
        txtantiesp.Text = ""
        txtlargohh.Text = ""
        txtanchohh.Text = ""
        txttempulpa.Text = ""
        txtcauefl.Text = ""
        txt1a2.Text = ""
        txt2a3.Text = ""
        txttqbl.Text = ""

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Decimales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvel.KeyPress, txtantiesp.KeyPress, txtlargohh.KeyPress, txtanchohh.KeyPress, txttempulpa.KeyPress, txtcauefl.KeyPress, txt1a2.KeyPress, txt2a3.KeyPress, txttqbl.KeyPress
        Try
            SoloDecimal(Me.ActiveControl, e)
        Catch ex As Exception

        End Try  'Solo acepta valores decimales

    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos()
    End Sub

    Private Sub conexion()
        conex("mcvarproc")
    End Sub

    Private Sub buscadatos()
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql1 = "SELECT vdp_id as ID, vdp_mc as Linea,vdp_fecha as Fecha,vdp_turno as Turno,vdp_grupo as Grupo
                ,vdp_material as Material,vdp_veloc as Velocidad,vdp_antiespum as AntiEspim,vdp_largohh as LargoHH
                ,vdp_anchohh as AnchoHH,vdp_tempulpa as TempPulpa,vdp_cauaeflu as CauAEflu,vdp_concentq1a2 as ConcenTq1a2
                ,vdp_concentq2a3 as ConcenTq2a3,vdp_temptab as TempTab,vdp_userid as UserID,vdp_bajaid as BajaID 
                from mcvarproc 
                where vdp_FECHA>='" + fechaant + "' and vdp_FECHA<='" + fch + "' and vdp_bajaid='0' 
                order by vdp_fecha"

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        dg.DataSource = dt1
        ocultarColumnas()
    End Sub

    Private Sub ocultarColumnas()
        dg.Columns("ID").Visible = False
        dg.Columns("UserID").Visible = False
        dg.Columns("BajaId").Visible = False
    End Sub

    Private Sub dg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.Click
        If dg.SelectedRows.Count = 1 Then
            line = dg.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            fechaborra = FormatDateTime(Now, DateFormat.ShortDate)

        End If

        If dtfecha.Text = fechaborra Then
            If e.KeyCode = Keys.Delete Then
                ms = MetroMessageBox.Show(Me, "¿Desea eliminar la línea seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    Call eliminalinea()
                End If
            End If
        Else
            MetroMessageBox.Show(Me, "No se pueden eliminar datos de días anteriores", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub eliminalinea()
        'elimina la fila de la grilla
        sql4 = "select vdp_userid from mcvarproc where vdp_id='" + Str(line) + "' and vdp_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count


        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sql4 = "update mcvarproc set vdp_bajaid='" + user + "' where vdp_id='" + Str(line) + "'"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()
            Call buscadatos()
            dg.DataSource = dt1
            If dt1.Rows.Count <> 0 Then
                dg.Select()
            Else

            End If
        End If


    End Sub

End Class