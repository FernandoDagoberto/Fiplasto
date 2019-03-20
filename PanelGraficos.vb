Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class PanelGraficos

    Dim sql1 As String
    Dim tabla1 As String
    Dim x1 As String
    Dim y1 As String
    'Creo las siguientes variables para poder ser usadas con el botón Imprimir
    Dim ListaImprimir As New List(Of Chart)
    Dim grafImp As New Chart()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Borramos los controles de los paneles para que puedan ser cargados nuevamente con Chart
        Panel0.Controls.Clear()
        Panel1.Controls.Clear()
        Panel2.Controls.Clear()
        Panel3.Controls.Clear()

        'Creamos una lista de Chart
        Dim graficos As New List(Of Chart)
        graficos.Clear()


        'Busco en la tabla Paneles todos los reportes que existen
        conex("paneles")
        sql = "SELECT * From Paneles inner join panel_usu on panel_id=id where user_id='" + user + "' "
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

        'Recorro c/registro de la tabla para ir completando los graficos.  '4 paneles 
        For x = 0 To n - 1
            Try
                'Día anterior de la fecha Desde a partir de las 22 hs
                fch = dtDesde.Text
                fechaant = FormatDateTime(fch.AddDays(-1), DateFormat.ShortDate) & " 22:00:00"
                fchhasta = dtHasta.Text & " 21:59:59" 'Fecha Hasta


                Dim tabla As String = dt.Rows(x).Item("tabla")

                'Consulta SQL del campo sql de la tabla paneles
                sql1 = dt.Rows(x).Item("sql")

                Dim ds As New DataSet
                'Le paso parametros a la consulta sql
                Dim ocmd As New SqlCommand(sql1, cnn)
                ocmd.Parameters.Clear()
                ocmd.Parameters.AddWithValue("@desde", fechaant)
                ocmd.Parameters.AddWithValue("@hasta", fchhasta)
                cnn.Open()
                ocmd.ExecuteNonQuery()
                cnn.Close()

                Dim oData As New SqlDataAdapter(ocmd)
                oData.Fill(ds, tabla)

                'Creo un nuevo gráfico por cada registro de X
                Dim graf As New Chart()
                graf.Name = "nombre" & x
                graf.BackColor = Color.Gray
                graf.BackGradientStyle = GradientStyle.TopBottom

                'AddHandler graf.Click, AddressOf Imprimir
                graficos.Add(graf)

                graficos(x).DataSource = ds.Tables(tabla)

                'Creamos variables de las distintas partes del Chart
                Dim Series1 As Series = graficos(x).Series.Add("Series1")
                Dim Area_de_Grafico As ChartArea = graficos(x).ChartAreas.Add("ChartArea1")
                Dim Titulo As Title = graficos(x).Titles.Add("Titulo1")
                Dim leyenda As Legend = graficos(x).Legends.Add("MisLeyendas")

                '-------

                With Series1

                    .Palette = ChartColorPalette.EarthTones
                    .BackGradientStyle = GradientStyle.TopBottom
                    .BorderColor = Color.Black
                    .LabelForeColor = Color.Black 'Pintamos el color de la etiqueta
                    .IsValueShownAsLabel = True 'Visualizamos las etiquetas
                    .Font = New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
                    .ChartType = DataVisualization.Charting.SeriesChartType.Column 'Ahora asignamos el tipo de gráfico que queremos.

                    'Rellenamos el gráfico con los datos escogidos
                    .XValueMember = dt.Rows(x).Item("x1")
                    .YValueMembers = dt.Rows(x).Item("y1")


                End With

                '------------Titulo del gráfico

                With Titulo
                    .Text = dt.Rows(x).Item("titulo") & "   D: " & fechaant & " - H: " & fchhasta  'Agrego título al gráfico desde la BD
                    .Alignment = ContentAlignment.MiddleCenter    'Centramos el título del gráfico
                    .Font = New Font("Arial", 10, FontStyle.Bold)    'Fuente, tamaño y estilo del título
                    .ForeColor = Color.Azure
                End With

                With Area_de_Grafico

                    '--------------Eje X--------
                    .AxisX.Title = dt.Rows(x).Item("descX") 'Agrego descripción el eje X al gráfico desde la BD
                    .AxisX.TitleFont = New Font("Arial", 8, FontStyle.Bold) 'Fuente del titulo
                    .AxisX.TitleForeColor = Color.Black    'Color de letra del título
                    .AxisX.TitleAlignment = StringAlignment.Center  'Alineación Título
                    .AxisX.IsMarginVisible = True
                    .AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount
                    .AxisX.LabelStyle.Font = New Font("Arial", 6, FontStyle.Regular)
                    '--------------Eje Y--------
                    .AxisY.Title = dt.Rows(x).Item("descY") 'Agrego descripción el eje Y al gráfico desde la BD
                    .AxisY.TitleFont = New Font("Arial", 8, FontStyle.Bold) 'Fuente del titulo
                    .AxisY.TitleForeColor = Color.Black    'Color de letra del título
                    .AxisY.TitleAlignment = StringAlignment.Center 'Alineación Título
                    .AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount

                    '.Area3DStyle.Enable3D = True
                    '.Area3DStyle.Rotation = 2 ' 20
                    '.Area3DStyle.PointDepth = 75
                    '.Area3DStyle.PointGapDepth = 45

                End With

                graficos(x).Dock = DockStyle.Fill

                'Muestro los graficos en cada panel y además agrego cada gráfico al listado para imprimir

                Select Case x
                    Case 0
                        Panel0.Controls.Add(graficos(x))
                        ListaImprimir.Add(graficos(x))
                    Case 1
                        Panel1.Controls.Add(graficos(x))
                        ListaImprimir.Add(graficos(x))
                    Case 2
                        Panel2.Controls.Add(graficos(x))
                        ListaImprimir.Add(graficos(x))
                    Case 3
                        Panel3.Controls.Add(graficos(x))
                        ListaImprimir.Add(graficos(x))
                End Select

            Catch ex As Exception

            End Try

        Next

    End Sub


    Private Sub lblOpciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOpciones.Click
        Dim opciones As New PanelesOpciones
        opciones.ShowDialog()
    End Sub

    Private Sub Imprimir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Recorro listaimprimir para ver cuantos reportes existen en el formulario para que sean impresos
        For x = 0 To ListaImprimir.Count - 1
            'Instrucción para ir imprimiendo los chart (true muestra opciones - false no)
            ListaImprimir(x).Printing.Print(True)
        Next

        'Borro todos los nombres de los gráficos de listaImprimir
        ListaImprimir.Clear()

    End Sub


    Private Sub PanelGraficos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Borro todos los nombres de los gráficos de listaImprimir
        For x = 0 To n - 3
            ListaImprimir(x).Name = ""
        Next
    End Sub

End Class