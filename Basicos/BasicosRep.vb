Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports MetroFramework

Public Class BasicosRep
    Inherits MetroFramework.Forms.MetroForm
    'FechaDíaAnterior,FechaInicioMes,FechaHasta
    Dim fchDA, fchIM, fchH As Date
    Dim repo As New cRepo
    Dim datosInforme As New cProduccion
    Dim stepBarra, valorBarra As Double

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        If String.IsNullOrEmpty(cbLinea.Text) Then
            repo.LineaD = 1
            repo.LineaH = 2
        Else
            repo.LineaD = cbLinea.Text
            repo.LineaH = cbLinea.Text
        End If


        If String.IsNullOrEmpty(cbOpcion.Text) Then
            repo.ParadaD = "0"
            repo.ParadaH = "ZZZZ"
        Else
            repo.ParadaD = cbOpcion.Text
            repo.ParadaH = cbOpcion.Text
        End If


        '---------------------

        If rbProducción.Checked Then
            If Not informeProduccion() Then
            Else
                nivdet = "Produccion"
            End If

        ElseIf rbNovedades.Checked Then
            If Not informeNovedades() Then
            Else
                nivdet = "Novedades"
            End If

        Else

            If rbdiario.Checked = True Then

                repo.FechaD = dtpDesde.Value.Date
                repo.FechaH = dtpHasta.Value.Date

                nivdet = "ParadaDiario"

            ElseIf rbmens.Checked = True Then

                repo.FechaD = dtpDesde.Value.Date
                repo.FechaH = dtpHasta.Value.Date

                nivdet = "ParadaMensual"

            ElseIf rbDetallado.Checked = True Then

                repo.FechaD = dtpDesde.Value.Date
                repo.FechaH = dtpHasta.Value.Date

                nivdet = "Detallado"
            End If
        End If

        '***************************************
        'Al formulario de reportes le paso la opción para el select case y la clase repo que son para los parametros del reporte.
        Dim repoBasicos As New frmRepoBasicos(nivdet, repo)
        repoBasicos.Show()

    End Sub



    Function informeProduccion() As Boolean
        Try
            Dim dataset As New PRODUCCIONDataSet
            Dim nuevaFila As DataRow

            TablaInforme = dataset.Tables("InformeProduccion")

            'Día anterior de la fecha Hasta a partir de las 22 hs
            fchDA = FormatDateTime(dtpHasta.Value.Date.AddDays(-1), DateFormat.ShortDate) & " 22:00:00"
            repo.FechaD = fchDA

            'Primer día del mes de acuerdo a la fecha Desde
            fchIM = UltimoDiaDelMesAnt(dtpDesde.Value.Date) & " 22:00:00"
            repo.FechaIniMes = fchIM

            'Fecha Hasta a las 21:59:59
            fchH = FormatDateTime(dtpHasta.Text, DateFormat.ShortDate) & " 21:59:59"
            repo.FechaH = fchH

            Dim dsPrensadas As New PRODUCCIONDataSetTableAdapters.prensadasTableAdapter
            Dim dtPrensadas As New PRODUCCIONDataSet.prensadasDataTable
            dsPrensadas.Fill(dtPrensadas, fchIM, fchH)

            stepBarra = CalculaStep(dtPrensadas.Rows.Count)

            For Each fila As DataRow In dtPrensadas.Rows

                Dim fechaturno As DateTime
                fch = fila.Item("fecha")
                If Format(fch, "HH:mm:ss") >= "22:00:00" Then
                    fechaturno = FormatDateTime(fch.AddDays(1), DateFormat.LongDate)
                Else
                    fechaturno = FormatDateTime(fch, DateFormat.LongDate)

                End If

                conex("czregdescartes")
                cnn.Open()
                sql = "Select sum(czregdes_cantidad) as Merma from CZREGDESCARTES " &
                " where czregdes_fechaturno ='" + fechaturno + "' " &
                "and czregdes_linea=" + Str(fila.Item("linea")) + ""
                da = New SqlDataAdapter(sql, cnn)
                dt = New DataTable
                da.Fill(dt)

                cnn.Close()

                With datosInforme
                    .Fecha = fila.Item("Fecha")
                    .Linea = fila.Item("linea")
                    .Prensada = fila.Item("prensada")
                    .Producto = fila.Item("producto")
                    .Factor = fila.Item("factor")
                    .Aberturas = fila.Item("aberturas")
                    .Decorativo = fila.Item("decorativo")
                    If String.IsNullOrEmpty(dt.Rows(0).Item("Merma").ToString) Then
                        .Merma = 0
                    Else
                        .Merma = dt.Rows(0).Item("Merma")
                    End If
                End With

                nuevaFila = TablaInforme.NewRow
                nuevaFila.Item("Fecha") = datosInforme.Fecha
                nuevaFila.Item("Linea") = datosInforme.Linea
                nuevaFila.Item("Prensada") = datosInforme.Prensada
                nuevaFila.Item("Producto") = datosInforme.Producto
                nuevaFila.Item("Factor") = datosInforme.Factor
                nuevaFila.Item("Aberturas") = datosInforme.Aberturas
                nuevaFila.Item("Decorativo") = datosInforme.Decorativo
                nuevaFila.Item("Merma") = datosInforme.Merma

                TablaInforme.Rows.Add(nuevaFila)

                valorBarra = valorBarra + stepBarra

                If valorBarra > 98 Then
                Else
                    BarraProgreso.Value = valorBarra

                End If

            Next

            valorBarra = 0
            BarraProgreso.Value = valorBarra

            Return True

        Catch ex As MySqlException
            MetroMessageBox.Show(Me, "No se ha podido conectar al servidor")
            Return False
        End Try

    End Function


    Function informeNovedades() As Boolean
        Try
            Dim dataset As New PRODUCCIONDataSet
            Dim nuevaFila As DataRow

            TablaInforme = dataset.Tables("InformeProduccion")

            'Día anterior de la fecha Desde a partir de las 22 hs
            fchDA = FormatDateTime(dtpDesde.Value.Date.AddDays(-1), DateFormat.ShortDate) & " 22:00:00"
            repo.FechaD = fchDA

            'Fecha Hasta a las 21:59:59
            fchH = FormatDateTime(dtpHasta.Text, DateFormat.ShortDate) & " 21:59:59"
            repo.FechaH = fchH

            ConectMySql()
            cnnMySql.Open()


            Dim query As String = "SELECT linea,producto.prd_descrp as PRODUCTO,aberturas,decorativo,TIMESTAMP(fecha,hora) AS FECHA " &
                                  " FROM novedades inner join producto on producto.ID=novedades.producto " &
            "where TIMESTAMP(fecha,hora)>='" + Format(repo.FechaD, "yyyy-MM-dd HH:mm:ss") + "' " &
            "and TIMESTAMP(fecha,hora)<='" + Format(repo.FechaH, "yyyy-MM-dd HH:mm:ss") + "'"
            Dim MySqlDA As MySqlDataAdapter
            Dim conjuntoDeDatos As New DataSet
            Dim MySqlDT As New DataTable

            MySqlDA = New MySqlDataAdapter(query, cnnMySql)
            MySqlDA.Fill(conjuntoDeDatos, "Novedades")

            stepBarra = CalculaStep(conjuntoDeDatos.Tables(0).Rows.Count)

            'Recorro el MYSQLDataAdapter y voy guardando en una tabla
            For Each fila As DataRow In conjuntoDeDatos.Tables(0).Rows
                With datosInforme
                    .Fecha = fila.Item("Fecha")
                    .Linea = fila.Item("linea")
                    .Producto = fila.Item("producto")
                    .Aberturas = fila.Item("aberturas")
                    .Decorativo = fila.Item("decorativo")
                End With

                nuevaFila = TablaInforme.NewRow
                nuevaFila.Item("Fecha") = datosInforme.Fecha
                nuevaFila.Item("Linea") = datosInforme.Linea
                nuevaFila.Item("Prensada") = datosInforme.Prensada
                nuevaFila.Item("Producto") = datosInforme.Producto
                nuevaFila.Item("Factor") = datosInforme.Factor
                nuevaFila.Item("Aberturas") = datosInforme.Aberturas
                nuevaFila.Item("Decorativo") = datosInforme.Decorativo
                nuevaFila.Item("Merma") = datosInforme.Merma

                TablaInforme.Rows.Add(nuevaFila)

                valorBarra = valorBarra + stepBarra

                If valorBarra > 98 Then
                Else
                    BarraProgreso.Value = valorBarra

                End If

            Next

            cnnMySql.Close()

            valorBarra = 0
            BarraProgreso.Value = valorBarra

            Return True

        Catch ex As MySqlException
            MetroMessageBox.Show(Me, "No se ha podido conectar al servidor")
            cnnMySql.Close()
            Return False
        End Try

    End Function

    'para saber el primer dia del mes 
    Function UltimoDiaDelMesAnt(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMesAnt = DateSerial(Year(dtmFecha), Month(dtmFecha), 0)
    End Function

    'para saber el ultimo dia del mes 
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function



    Private Sub rbmens_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbmens.CheckedChanged
        If rbmens.Checked = True Then

            gbFechas.Visible = True
        End If
    End Sub


    Private Sub opcion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbParadas.CheckedChanged, rbProducción.CheckedChanged, rbNovedades.CheckedChanged
        cbOpcion.DataSource = Nothing
        cbOpcion.Text = ""

        'Si selecciono Paradas, habilito todas las opciones
        If rbParadas.Checked Then
            pnlTipoRep.Enabled = True
        Else
            pnlTipoRep.Enabled = False
        End If



    End Sub

    Private Sub CargaCombo(ByVal tabla As String, ByVal combo As ComboBox, ByVal campo_a_mostrar As String)
        Call conexProduccion("combo")
        sql7 = "SELECT distinct(" + campo_a_mostrar + ") From " & tabla & " order by " + campo_a_mostrar + ""
        da7 = New SqlDataAdapter(sql7, cnnProduccion)
        dt7 = New DataTable
        da7.Fill(dt7)
        n = dt7.Rows.Count

        If n = 0 Then

        Else
            combo.DataSource = dt7
            combo.DisplayMember = campo_a_mostrar
            combo.ValueMember = campo_a_mostrar
        End If

    End Sub

    Private Sub cbOpcion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbOpcion.Click
        If rbParadas.Checked And String.IsNullOrEmpty(cbOpcion.Text) Then
            CargaCombo("COD_PARADA", cbOpcion, "descripcion")

        ElseIf rbProducción.Checked And String.IsNullOrEmpty(cbOpcion.Text) Then
            ConectMySql()
            cnnMySql.Open()
            Dim query As String = "SELECT prd_descrp " & _
                                       " FROM producto"
            Dim MySqlDA As MySqlDataAdapter
            Dim conjuntoDeDatos As New DataSet
            Dim MySqlDT As New DataTable

            MySqlDA = New MySqlDataAdapter(query, cnnMySql)
            MySqlDA.Fill(conjuntoDeDatos, "Novedades")

            cbOpcion.DataSource = conjuntoDeDatos.Tables(0)
            cbOpcion.DisplayMember = "prd_descrp"

        ElseIf rbNovedades.Checked Then
            cbOpcion.Text = ""

        End If
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim prod As New Produccion
        prod.Show()
    End Sub

    Private Function CalculaStep(ByVal filas As Integer) As Double
        stepBarra = 100 / filas

        Return stepBarra


    End Function


    Private Sub cbOpcion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOpcion.SelectedIndexChanged

    End Sub
End Class