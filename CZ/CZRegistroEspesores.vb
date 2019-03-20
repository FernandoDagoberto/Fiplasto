Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework
Imports MetroFramework.Controls

Public Class CZRegistroEspesores
    Inherits MetroFramework.Forms.MetroForm
    Dim ms As Integer
    Dim idl, decorativo As String
    Dim prom As Double
    Dim i As Integer
    Dim defecto1, defecto2, defecto3 As String
    Dim LineaI, LineaII As String
    Dim cantidad, marca, cant, cantLI, cantLII, cantAux As Integer
    Dim camposTextoI, camposTextoII As MetroTextBox()

    Private Sub CZRegistroEspesores_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Call haydatos()
    End Sub

    Private Sub haydatos()
        'Rutina que controla sí hay datos cargados en los espesores al cerrar el formulario.
        Call BorraAux()

        'linea I
        If Trim(txtinf11.Text) <> "" Or Trim(txtinf12.Text) <> "" Or Trim(txtinf13.Text) <> "" Or Trim(txtmed11.Text) <> "" Or Trim(txtmed12.Text) <> "" Or Trim(txtmed13.Text) <> "" Or Trim(txtsup11.Text) <> "" Or Trim(txtsup12.Text) <> "" Or Trim(txtsup13.Text) <> "" Then
            ms = MetroMessageBox.Show(Me, "Hay datos cargados de Línea I ¿Desea guardarlos para que los use su relevo?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If ms = 1 Then
                Call guardaAuxLI()
            End If
        Else

        End If

        'linea II
        If Trim(txtinf21.Text) <> "" Or Trim(txtinf22.Text) <> "" Or Trim(txtinf23.Text) <> "" Or Trim(txtmed21.Text) <> "" Or Trim(txtmed22.Text) <> "" Or Trim(txtmed23.Text) <> "" Or Trim(txtsup21.Text) <> "" Or Trim(txtsup22.Text) <> "" Or Trim(txtsup23.Text) <> "" Then
            ms = MetroMessageBox.Show(Me, "Hay datos cargados de Línea II ¿Desea guardarlos para que los use su relevo?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If ms = 1 Then
                Call guardaAuxLII()
            End If
        Else

        End If
    End Sub

    Private Sub guardaAuxLI()
        campos = "czaux_fecha, czaux_linea, czaux_turno, czaux_grupo, czaux_material,czaux_zorra, czaux_inf1, czaux_inf2, czaux_inf3, czaux_med1, " &
                       "czaux_med2, czaux_med3, czaux_sup1, czaux_sup2, czaux_sup3"


        variables = "'" + Now + "','" + lblL1.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbmatl1.Text + "','" + cbzorra1.Text + "', " &
        "'" + Trim(txtinf11.Text) + "', '" + Trim(txtinf12.Text) + "','" + Trim(txtinf13.Text) + "', " &
        "'" + Trim(txtmed11.Text) + "','" + Trim(txtmed12.Text) + "','" + Trim(txtmed13.Text) + "', " &
        "'" + Trim(txtsup11.Text) + "','" + Trim(txtsup12.Text) + "','" + Trim(txtsup13.Text) + "'"

        SQL3 = "INSERT INTO AUXCZESPESOR (" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()

    End Sub

    Private Sub guardaAuxLII()
        campos = "czaux_fecha, czaux_linea, czaux_turno, czaux_grupo, czaux_material,czaux_zorra, czaux_inf1, czaux_inf2, czaux_inf3, czaux_med1, " &
                       "czaux_med2, czaux_med3, czaux_sup1, czaux_sup2, czaux_sup3"


        variables = "'" + Now + "','" + lblL2.Text + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbmatl2.Text + "','" + cbzorra2.Text + "', " &
        "'" + Trim(txtinf21.Text) + "', '" + Trim(txtinf22.Text) + "','" + Trim(txtinf23.Text) + "', " &
        "'" + Trim(txtmed21.Text) + "','" + Trim(txtmed22.Text) + "','" + Trim(txtmed23.Text) + "', " &
        "'" + Trim(txtsup21.Text) + "','" + Trim(txtsup22.Text) + "','" + Trim(txtsup23.Text) + "'"

        SQL3 = "INSERT INTO AUXCZESPESOR (" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()

    End Sub

    Private Sub CZRegistroEspesores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call verifica_fecha()

        Call CargaTurnoAuto()
        cbturno.Text = TurnoAuto

        'Busca datos Linea I
        Call buscadatos(1)
        Call buscadatos(2)

        Call TipoMaterial(cbmatl1, 1)
        'para que muestre seleccionado 3.2
        cbmatl1.Text = dt9.Rows(1).Item("material_medmm")

        Call TipoMaterial(cbmatl2, 2)
        'para que muestre seleccionado 3.2
        cbmatl2.Text = dt9.Rows(1).Item("material_medmm")

        Call zorra(cbzorra1)
        Call zorra(cbzorra2)

        'Busca sí hay datos temporales
        Call BuscaAux()

        camposTextoI = New MetroTextBox() {txtinf11, txtinf12, txtinf13, txtmed11, txtmed12, txtmed13, txtsup11, txtsup12, txtsup13}
        camposTextoII = New MetroTextBox() {txtinf21, txtinf22, txtinf23, txtmed21, txtmed22, txtmed23, txtsup21, txtsup22, txtsup23}
    End Sub

    Private Sub buscadatos(ByVal linea As String)
        fch = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"
        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"

        Call conexion()

        sql1 = "SELECT czespes_id as ID, czespes_fecha as Fecha,czespes_linea as Linea,czespes_turno as Turno,czespes_grupo as Grupo,czespes_material as Material " &
                ",czespes_zorra as Zorra,czespes_inf1 as Inf1,czespes_inf2 as Inf2,czespes_inf3 as Inf3,czespes_med1 as Med1,czespes_med2 as Med2,czespes_med3 as Med3 " &
                ",czespes_sup1 as Sup1,czespes_sup2 as Sup2,czespes_sup3 as Sup3 from CZESPESORES " &
                "where  CZESPES_FECHA>='" + fechaant + "' and CZESPES_FECHA<='" + fch + "' and CZESPES_LINEA= '" + linea + "' and CZESPES_bajaid='0' order by CZESPES_fecha"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        If linea = 1 Then
            dgLineaI.DataSource = dt1
        Else
            dgLineaII.DataSource = dt1
        End If

    End Sub

    Private Sub BuscaAux()
        Call conexion()
        sql9 = "select * from AUXCZESPESOR"
        da9 = New SqlDataAdapter(sql9, cnn)
        dt9 = New DataTable
        da9.Fill(dt9)
        cantAux = dt9.Rows.Count

        If cantAux = 0 Then

        Else
            For i = 0 To cantAux - 1
                linea = dt9.Rows(i).Item("czaux_linea")

                ms = MetroMessageBox.Show(Me, "Hay datos guardados de espesores de Línea: '" + linea + "' ¿Desea utilizarlos?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    cbturno.Text = dt9.Rows(i).Item("czaux_turno")
                    cbgrupo.Text = dt9.Rows(i).Item("czaux_grupo")

                    If linea = "1" Then
                        Call CargoDatosAuxLI()
                    Else
                        Call CargoDatosAuxLII()
                    End If

                End If
            Next


            Call BorraAux()

        End If


    End Sub

    Private Sub CargoDatosAuxLI()

        cbmatl1.Text = dt9.Rows(i).Item("czaux_material")
        cbzorra1.Text = dt9.Rows(i).Item("czaux_zorra")

        If dt9.Rows(i).Item("czaux_inf1") = 0 Then
            txtinf11.Text = ""
        Else
            txtinf11.Text = dt9.Rows(i).Item("czaux_inf1")
        End If

        If dt9.Rows(i).Item("czaux_inf2") = 0 Then
            txtinf12.Text = ""
        Else
            txtinf12.Text = dt9.Rows(i).Item("czaux_inf2")
        End If

        If dt9.Rows(i).Item("czaux_inf3") = 0 Then
            txtinf13.Text = ""
        Else
            txtinf13.Text = dt9.Rows(i).Item("czaux_inf3")
        End If

        If dt9.Rows(i).Item("czaux_med1") = 0 Then
            txtmed11.Text = ""
        Else
            txtmed11.Text = dt9.Rows(i).Item("czaux_med1")
        End If

        If dt9.Rows(i).Item("czaux_med2") = 0 Then
            txtmed12.Text = ""
        Else
            txtmed12.Text = dt9.Rows(i).Item("czaux_med2")
        End If


        If dt9.Rows(i).Item("czaux_med3") = 0 Then
            txtmed13.Text = ""
        Else
            txtmed13.Text = dt9.Rows(i).Item("czaux_med3")
        End If

        If dt9.Rows(i).Item("czaux_sup1") = 0 Then
            txtsup11.Text = ""
        Else
            txtsup11.Text = dt9.Rows(i).Item("czaux_sup1")
        End If

        If dt9.Rows(i).Item("czaux_sup2") = 0 Then
            txtsup12.Text = ""
        Else
            txtsup12.Text = dt9.Rows(i).Item("czaux_sup2")
        End If

        If dt9.Rows(i).Item("czaux_sup3") = 0 Then
            txtsup13.Text = ""
        Else
            txtsup13.Text = dt9.Rows(i).Item("czaux_sup3")
        End If


    End Sub

    Private Sub CargoDatosAuxLII()

        cbmatl2.Text = dt9.Rows(i).Item("czaux_material")
        cbzorra2.Text = dt9.Rows(i).Item("czaux_zorra")

        If dt9.Rows(i).Item("czaux_inf1") = 0 Then
            txtinf21.Text = ""
        Else
            txtinf21.Text = dt9.Rows(i).Item("czaux_inf1")
        End If

        If dt9.Rows(i).Item("czaux_inf2") = 0 Then
            txtinf22.Text = ""
        Else
            txtinf22.Text = dt9.Rows(i).Item("czaux_inf2")
        End If

        If dt9.Rows(i).Item("czaux_inf3") = 0 Then
            txtinf23.Text = ""
        Else
            txtinf23.Text = dt9.Rows(i).Item("czaux_inf3")
        End If

        If dt9.Rows(i).Item("czaux_med1") = 0 Then
            txtmed21.Text = ""
        Else
            txtmed21.Text = dt9.Rows(i).Item("czaux_med1")
        End If

        If dt9.Rows(i).Item("czaux_med2") = 0 Then
            txtmed22.Text = ""
        Else
            txtmed22.Text = dt9.Rows(i).Item("czaux_med2")
        End If


        If dt9.Rows(i).Item("czaux_med3") = 0 Then
            txtmed23.Text = ""
        Else
            txtmed23.Text = dt9.Rows(i).Item("czaux_med3")
        End If

        If dt9.Rows(i).Item("czaux_sup1") = 0 Then
            txtsup21.Text = ""
        Else
            txtsup21.Text = dt9.Rows(i).Item("czaux_sup1")
        End If

        If dt9.Rows(i).Item("czaux_sup2") = 0 Then
            txtsup22.Text = ""
        Else
            txtsup22.Text = dt9.Rows(i).Item("czaux_sup2")
        End If

        If dt9.Rows(i).Item("czaux_sup3") = 0 Then
            txtsup23.Text = ""
        Else
            txtsup23.Text = dt9.Rows(i).Item("czaux_sup3")
        End If

    End Sub

    Private Sub BorraAux()
        sql4 = "delete AUXCZESPESOR"
        cmd4 = New SqlCommand(sql4, cnn)
        cmd4.Connection.Open()
        cmd4.ExecuteNonQuery()
        cmd4.Connection.Close()
    End Sub

    Private Sub verifica_fecha()
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            dtfecha.Value = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            dtfecha.Value = FormatDateTime(Now, DateFormat.ShortDate)
        End If
    End Sub

    Private Sub TipoMaterial(ByVal combo As MetroComboBox, ByVal linea As Integer)
        Call llenacbwhere("mcmaterial", "where material_mc='" + Trim(Str(linea)) + "'")
        combo.DataSource = dt9
        combo.DisplayMember = "material_medmm"
        combo.ValueMember = "material_medmm"

    End Sub

    Private Sub llenozorras()
        Call conex("zorras")
        sql = "SELECT * From ZORRAS where zorras_baja='N' order by zorras_id"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

    End Sub

    Private Sub zorra(ByVal combo As MetroComboBox)
        Call llenozorras()
        If n = 0 Then
            MetroMessageBox.Show(Me, "No hay zorras dadas de alta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            combo.DataSource = dt
            combo.DisplayMember = "zorras_id"
            combo.ValueMember = "zorras_id"

        End If
    End Sub

    Private Sub Guardar(ByVal button As String, ByVal linea As Integer)

        If String.IsNullOrEmpty(cbturno.Text) Or String.IsNullOrEmpty(cbgrupo.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar Turno y grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbturno.Focus()
            Exit Sub
        End If


        If button = "Linea1" Then
            If String.IsNullOrEmpty(cbzorra1.Text) Or String.IsNullOrEmpty(cbmatl1.Text) Or
                (Trim(txtinf11.Text) = "" Or Trim(txtinf12.Text) = "" Or Trim(txtinf13.Text) = "" Or
                Trim(txtmed11.Text) = "" Or Trim(txtmed12.Text) = "" Or Trim(txtmed13.Text) = "" Or
                Trim(txtsup11.Text) = "" Or Trim(txtsup12.Text) = "" Or Trim(txtsup13.Text) = "") Then

                MetroMessageBox.Show(Me, "Favor de completar todos los campos de espesores", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else
            If String.IsNullOrEmpty(cbzorra2.Text) Or String.IsNullOrEmpty(cbmatl2.Text) Or
                (Trim(txtinf21.Text) = "" Or Trim(txtinf22.Text) = "" Or Trim(txtinf23.Text) = "" Or
                Trim(txtmed21.Text) = "" Or Trim(txtmed22.Text) = "" Or Trim(txtmed23.Text) = "" Or
                Trim(txtsup21.Text) = "" Or Trim(txtsup22.Text) = "" Or Trim(txtsup23.Text) = "") Then

                MetroMessageBox.Show(Me, "Favor de completar todos los campos de espesores", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        campos = "czespes_fecha, czespes_linea, czespes_turno, czespes_grupo, czespes_material,czespes_zorra, czespes_inf1, czespes_inf2, czespes_inf3, czespes_med1, " &
                "czespes_med2, czespes_med3, czespes_sup1, czespes_sup2, czespes_sup3, czespes_userid, czespes_bajaid, czespes_bajafch"


        If linea = 1 Then
            variables = "'" + Now + "','" + Trim(Str(linea)) + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbmatl1.Text + "','" + cbzorra1.Text + "', " &
                "'" + Trim(txtinf11.Text) + "', '" + Trim(txtinf12.Text) + "','" + Trim(txtinf13.Text) + "', " &
                "'" + Trim(txtmed11.Text) + "','" + Trim(txtmed12.Text) + "','" + Trim(txtmed13.Text) + "', " &
                "'" + Trim(txtsup11.Text) + "','" + Trim(txtsup12.Text) + "','" + Trim(txtsup13.Text) + "', " &
                "'" + user + "','0',''"
        Else
            variables = "'" + Now + "','" + Trim(Str(linea)) + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + cbmatl2.Text + "','" + cbzorra2.Text + "', " &
                 "'" + Trim(txtinf21.Text) + "', '" + Trim(txtinf22.Text) + "','" + Trim(txtinf23.Text) + "', " &
                "'" + Trim(txtmed21.Text) + "','" + Trim(txtmed22.Text) + "','" + Trim(txtmed23.Text) + "', " &
                "'" + Trim(txtsup21.Text) + "','" + Trim(txtsup22.Text) + "','" + Trim(txtsup23.Text) + "', " &
                "'" + user + "','0',''"
        End If

        SQL3 = "INSERT INTO CZESPESORES (" + campos + ") VALUES (" + variables + ")"
        cmd3 = New SqlCommand(SQL3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()

        Call verifica_fecha()
        buscadatos(linea)
        limpia(linea)

        If linea = 1 Then
            TabControl1.SelectedTab = TabPage1
            cbzorra1.Focus()
        Else
            TabControl1.SelectedTab = TabPage2
            cbzorra2.Focus()
        End If

        '****

    End Sub

    Private Sub limpia(ByVal linea As Integer)
        If linea = 1 Then
            cbzorra1.Text = Nothing
            For x = 0 To camposTextoI.Count - 1
                camposTextoI(x).Text = Nothing
            Next
        Else
            cbzorra2.Text = Nothing
            For x = 0 To camposTextoII.Count - 1
                camposTextoII(x).Text = Nothing
            Next
        End If

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub conexion()
        conex("czzcargadas")
    End Sub

    Private Sub DataGrid_click(ByVal grid As MetroGrid)
        If grid.SelectedRows.Count = 1 Then
            line = grid.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub dgLineaI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLineaI.Click
        DataGrid_click(dgLineaI)
    End Sub

    Private Sub DataGrid_KeyUp(ByVal linea As Integer, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            fechaborra = FormatDateTime(Now, DateFormat.ShortDate)
        End If

        If dtfecha.Text = fechaborra Then
            If e.KeyCode = Keys.Delete Then
                ms = MetroMessageBox.Show(Me, "¿Desea eliminar la línea seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    Call eliminalinea(linea)
                End If
            End If
        End If
    End Sub

    Private Sub dgLineaI_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgLineaI.KeyUp
        DataGrid_KeyUp(1, e)
    End Sub

    Private Sub eliminalinea(ByVal linea As Integer)
        'elimina la fila de la grilla
        sql4 = "select CZESPES_userid from CZESPESORES where CZESPES_id='" + Str(line) + "' and CZESPES_userid='" + user + "'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        Dim n As Integer
        n = dt4.Rows.Count

        If n = 0 Then
            MetroMessageBox.Show(Me, "Usted no puede borrar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sql4 = "Update CZESPESORES set CZESPES_BAJAID='" + user + "',CZESPES_BAJAFCH='" + Now + "' where CZESPES_id='" + Str(line) + "'"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call buscadatos(linea)
            If dt1.Rows.Count <> 0 Then
                'dg.Select(0)
            Else

            End If
        End If
    End Sub

    Private Sub dgLineaII_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLineaII.Click
        DataGrid_click(dgLineaII)
    End Sub

    Private Sub DataGrid_DoubleClick(ByVal linea As Integer)
        If cant > 0 Then
            If Format(Now, "HH:mm:ss") >= "22:00:00" Then
                fechaborra = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
            Else
                fechaborra = FormatDateTime(Now, DateFormat.ShortDate)
            End If

            If dtfecha.Text = fechaborra Then
                sql5 = "select CZESPES_userid from CZESPESORES where CZESPES_id='" + Str(line) + "' and CZESPES_userid='" + user + "'"
                da5 = New SqlDataAdapter(sql5, cnn)
                dt5 = New DataTable
                da5.Fill(dt5)
                Dim n As Integer
                n = dt5.Rows.Count

                If n = 0 Then
                    MetroMessageBox.Show(Me, "Usted no puede modificar registros cargados por otros usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    Dim im As String
                    im = UCase(InputBox("Cambiar Turno"))

                    If im = "A" Or im = "B" Or im = "C" Or im = "D" Then

                        sql4 = "Update CZESPESORES set CZESPES_GRUPO='" + im + "' where CZESPES_id='" + Str(line) + "'"
                        cmd4 = New SqlCommand(sql4, cnn)
                        cmd4.Connection.Open()
                        cmd4.ExecuteNonQuery()
                        cmd4.Connection.Close()

                        MetroMessageBox.Show(Me, "GRUPO CAMBIADO", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        Call buscadatos(linea)
                        If dt1.Rows.Count <> 0 Then
                            'dg.Select(0)
                        End If


                    Else
                        MetroMessageBox.Show(Me, "GRUPO INCORRECTO", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MetroMessageBox.Show(Me, "No se pueden modificar cargas de días anteriores", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
        End If
    End Sub

    Private Sub dgLineaII_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLineaII.DoubleClick
        DataGrid_DoubleClick(2)
    End Sub

    Private Sub dgLineaII_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgLineaII.KeyUp
        DataGrid_KeyUp(2, e)
    End Sub

    Private Sub Decimales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsup23.KeyPress, txtsup22.KeyPress, txtsup21.KeyPress, txtsup13.KeyPress, txtsup12.KeyPress, txtsup11.KeyPress, txtmed23.KeyPress, txtmed22.KeyPress, txtmed21.KeyPress, txtmed13.KeyPress, txtmed12.KeyPress, txtmed11.KeyPress, txtinf23.KeyPress, txtinf22.KeyPress, txtinf21.KeyPress, txtinf13.KeyPress, txtinf12.KeyPress, txtinf11.KeyPress
        Try
            SoloDecimal(Me.ActiveControl, e)
        Catch ex As Exception

        End Try  'Solo acepta valores decimales

    End Sub

    Private Sub btnGuargarLII_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuargarLII.Click
        Guardar("Linea2", 2)
    End Sub

    Private Sub dtfecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtfecha.ValueChanged
        Call buscadatos(1)
        Call buscadatos(2)
    End Sub

    Function promedio(ByVal val1 As String, ByVal val2 As String, ByVal val3 As String)
        cant = 0
        If val1 = "" Then
            val1 = 0
        Else
            cant = cant + 1

        End If
        If val2 = "" Then
            val2 = 0
        Else
            cant = cant + 1
        End If
        If val3 = "" Then
            val3 = 0
        Else
            cant = cant + 1
        End If

        prom = FormatNumber((CDbl(val1) + CDbl(val2) + CDbl(val3)) / cant, 2)

    End Function

    Private Sub txtInferiorLineaI_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtinf11.Validated, txtinf12.Validated, txtinf13.Validated
        If Not String.IsNullOrEmpty(sender.name) Then
            If CDbl(sender.text) > 10 Then
                MetroMessageBox.Show(Me, "Valor ingresado demasiado grande", "Aviso", MessageBoxButtons.OK)
                sender.focus()
                Exit Sub
            Else
                Call promedio(txtinf11.Text, txtinf12.Text, txtinf13.Text)
                lblpi1.Text = prom
            End If
        End If
    End Sub

    Private Sub txtMediaLineaI_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmed11.Validated, txtmed12.Validated, txtmed13.Validated
        If Not String.IsNullOrEmpty(sender.name) Then
            If CDbl(sender.text) > 10 Then
                MetroMessageBox.Show(Me, "Valor ingresado demasiado grande", "Aviso", MessageBoxButtons.OK)
                sender.focus()
                Exit Sub
            Else
                Call promedio(txtmed12.Text, txtmed12.Text, txtmed13.Text)
                lblpm1.Text = prom
            End If
        End If
    End Sub

    Private Sub txtSuperiorLineaI_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsup11.Validated, txtsup12.Validated, txtsup13.Validated
        If Not String.IsNullOrEmpty(sender.name) Then
            If CDbl(sender.text) > 10 Then
                MetroMessageBox.Show(Me, "Valor ingresado demasiado grande", "Aviso", MessageBoxButtons.OK)
                sender.focus()
                Exit Sub
            Else
                Call promedio(txtsup12.Text, txtsup12.Text, txtsup13.Text)
                lblps1.Text = prom
            End If
        End If
    End Sub

    Private Sub txtInferiorLineaII_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtinf21.Validated, txtinf22.Validated, txtinf23.Validated
        If Not String.IsNullOrEmpty(sender.name) Then
            If CDbl(sender.text) > 10 Then
                MetroMessageBox.Show(Me, "Valor ingresado demasiado grande", "Aviso", MessageBoxButtons.OK)
                sender.focus()
                Exit Sub
            Else
                Call promedio(txtinf21.Text, txtinf22.Text, txtinf23.Text)
                lblpi2.Text = prom
            End If
        End If
    End Sub

    Private Sub txtMediaLineaII_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmed21.Validated, txtmed22.Validated, txtmed23.Validated
        If Not String.IsNullOrEmpty(sender.name) Then
            If CDbl(sender.text) > 10 Then
                MetroMessageBox.Show(Me, "Valor ingresado demasiado grande", "Aviso", MessageBoxButtons.OK)
                sender.focus()
                Exit Sub
            Else
                Call promedio(txtmed21.Text, txtmed22.Text, txtmed23.Text)
                lblpm2.Text = prom
            End If
        End If
    End Sub

    Private Sub txtSuperiorLineaII_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsup21.Validated, txtsup22.Validated, txtsup23.Validated
        If Not String.IsNullOrEmpty(sender.name) Then
            If CDbl(sender.text) > 10 Then
                MetroMessageBox.Show(Me, "Valor ingresado demasiado grande", "Aviso", MessageBoxButtons.OK)
                sender.focus()
                Exit Sub
            Else
                Call promedio(txtsup21.Text, txtsup22.Text, txtsup23.Text)
                lblps2.Text = prom
            End If
        End If
    End Sub

    Private Sub btnguardarLI_Click(sender As Object, e As EventArgs) Handles btnguardarLI.Click
        Guardar("Linea1", 1)
    End Sub

    Private Sub Reporte(ByVal linea As Integer, ByVal material As MetroComboBox)
        turnoD = cbturno.Text
        turnoH = cbturno.Text
        lineaD = linea
        lineaH = linea

        If String.IsNullOrEmpty(material.Text) Then
            MetroMessageBox.Show(Me, "No seleccionó material", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            material.Focus()
            Exit Sub
        Else
            'Para reportes de report viewer
            EspesorD = material.Text
            EspesorH = material.Text
        End If

        If Format(Now, "HH:mm:ss") >= "22:00:00" Then
            fch = FormatDateTime(Now.AddDays(1), DateFormat.ShortDate)
        Else
            fch = FormatDateTime(Now, DateFormat.ShortDate)

        End If

        fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " " & "22:00:00"
        fecha = FormatDateTime(dtfecha.Value, DateFormat.ShortDate) & " " & "21:59:59"

        nivdet = "espesor"

        'Dim fr As New frmREPOViewCZ()
        'fr.Show()
    End Sub

    Private Sub btnRepL2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepL2.Click
        Reporte(2, cbmatl2)
    End Sub

    Private Sub btnRepL1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepL1.Click
        Reporte(1, cbmatl1)
    End Sub

    Private Sub dgLineaI_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLineaI.DoubleClick
        DataGrid_DoubleClick(1)
    End Sub

End Class