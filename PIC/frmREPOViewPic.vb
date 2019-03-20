Imports Microsoft.Reporting.WinForms


Public Class frmREPOViewPic


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.

        InitializeComponent()

        Me.RepoView.RefreshReport()
        Me.RepoView.Reset()

        Dim Reporte1 As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim Reporte2 As New Microsoft.Reporting.WinForms.ReportDataSource

        Me.RepoView.LocalReport.DataSources.Clear()

        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaD", fechaant))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaH", fecha))

        Select Case nivdet

            Case "CtrlCamion" 'Picadora - Control Camion
                Reporte1.Name = "FIPLANEWDataSetTotal_DescargaCamion"
                Reporte1.Value = Me.FIPLANEWDataSetTotal.DescargaCamion

                Me.RepoView.LocalReport.DataSources.Add(Reporte1)

                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptCamAviso.rdlc"

                ' Asignar la colección params para el visor de informes
                RepoView.LocalReport.SetParameters(parametros)


                Me.Text = "PIC - Control Descarga Camiones"

                'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.DescargaCamion' Puede moverla o quitarla según sea necesario.
                Me.DescargaCamionTableAdapter.Fill(Me.FIPLANEWDataSetTotal.DescargaCamion)

                '******************************************************************************

            Case "Rajadora" 'Rajadora
                Reporte2.Name = "FIPLANEWDataSetTotal_MADRAJ"
                Reporte2.Value = Me.FIPLANEWDataSetTotal.MADRAJ

                Me.RepoView.LocalReport.DataSources.Add(Reporte2)

                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptPicRajadora.rdlc"

                ' Asignar la colección params para el visor de informes
                RepoView.LocalReport.SetParameters(parametros)

                Me.Text = "PIC - Rajadora"

                'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.MADRAJ' Puede moverla o quitarla según sea necesario.
                Me.MADRAJTableAdapter.Fill(Me.FIPLANEWDataSetTotal.MADRAJ)


                '******************************************************************************


            Case "ajuste_inventario"

                Reporte2.Name = "DataSet1"
                Reporte2.Value = Me.FIPLANEWDataSetTotal.TRAJINV

                Me.RepoView.LocalReport.DataSources.Add(Reporte2)

                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptAjuInv.rdlc"

                ' Asignar la colección params para el visor de informes
                RepoView.LocalReport.SetParameters(parametros)

                Me.Text = "Ajuste de Inventario"

                'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.TRAJINV' Puede moverla o quitarla según sea necesario.
                Me.TRAJINVTableAdapter.Fill(Me.FIPLANEWDataSetTotal.TRAJINV)



            Case "transfviga"

                Reporte2.Name = "DataSet1"
                Reporte2.Value = Me.FIPLANEWDataSetTotal.MARMV

                Me.RepoView.LocalReport.DataSources.Add(Reporte2)

                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptTransfVig.rdlc"

                ' Asignar la colección params para el visor de informes
                RepoView.LocalReport.SetParameters(parametros)

                Me.Text = "Transferencia a vigas"

                'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.MARMV' Puede moverla o quitarla según sea necesario.
                Me.MARMVTableAdapter.Fill(Me.FIPLANEWDataSetTotal.MARMV)


            Case "efipic"
                Reporte2.Name = "DataSet1"
                Reporte2.Value = Me.FIPLANEWDataSetTotal.MaderaPicada

                Me.RepoView.LocalReport.DataSources.Add(Reporte2)

                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TurnoD", turnoD))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TurnoH", turnoH))

                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptEfiPic.rdlc"



                ' Asignar la colección params para el visor de informes
                RepoView.LocalReport.SetParameters(parametros)

                Me.Text = "Eficiencia del picado Tn/Hora"
                'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.MaderaPicada' Puede moverla o quitarla según sea necesario.
                Me.MaderaPicadaTableAdapter.Fill(Me.FIPLANEWDataSetTotal.MaderaPicada)


            '*******************************************************************************
            Case "realvsobjetivo"
                Reporte2.Name = "DataSet1"
                Reporte2.Value = Me.FIPLANEWDataSetTotal.MaderaPicada

                Me.RepoView.LocalReport.DataSources.Add(Reporte2)

                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TurnoD", turnoD))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TurnoH", turnoH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptRealVsObjetivoPicadora.rdlc"



                ' Asignar la colección params para el visor de informes
                RepoView.LocalReport.SetParameters(parametros)

                Me.Text = "Real vs objetivo"
                'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.MaderaPicada' Puede moverla o quitarla según sea necesario.
                Me.MaderaPicadaTableAdapter.Fill(Me.FIPLANEWDataSetTotal.MaderaPicada)





            '*******************************************************************************


            Case "nivelsilos"
                Reporte2.Name = "DataSet1"
                Reporte2.Value = Me.FIPLANEWDataSetTotal.NivelSiloView

                Me.RepoView.LocalReport.DataSources.Add(Reporte2)

                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptNivSilos.rdlc"

                ' Asignar la colección params para el visor de informes
                RepoView.LocalReport.SetParameters(parametros)

                Me.Text = "Nivel de Silos"

                'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.NivelSiloView' Puede moverla o quitarla según sea necesario.
                Me.NivelSiloViewTableAdapter.Fill(Me.FIPLANEWDataSetTotal.NivelSiloView)


            Case "diario"

                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptParaPicDia.rdlc"
                'Quitamos cualquier datasource que tuviese el informe para cargar el nuestro
                Me.RepoView.LocalReport.DataSources.Clear()
                'Creamos un nuevo ReportDataSource con los datos conseguidos de la BD
                Reporte2.Name = "DataSet1"
                Reporte2.Value = dt
                RepoView.LocalReport.DataSources.Add(Reporte2)

                parametros.Clear()

            Case "IdDescripcion"
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptIdDescripcion.rdlc"

                'Quitamos cualquier datasource que tuviese el informe para cargar el nuestro
                Me.RepoView.LocalReport.DataSources.Clear()
                'Creamos un nuevo ReportDataSource con los datos conseguidos de la BD
                Reporte2.Name = "DataSet1"
                Reporte2.Value = dt
                RepoView.LocalReport.DataSources.Add(Reporte2)

                parametros.Clear()
                parametros.Add(New ReportParameter("Titulo", tituloRepo))
                RepoView.LocalReport.SetParameters(parametros)


            Case "tnpic"
                Reporte2.Name = "DataSet1"
                Reporte2.Value = Me.FIPLANEWDataSetTotal.MaderaPicada
                Me.RepoView.LocalReport.DataSources.Add(Reporte2)

                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TurnoD", turnoD))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TurnoH", turnoH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptTnPic.rdlc"
                ' Asignar la colección params para el visor de informes
                RepoView.LocalReport.SetParameters(parametros)

                Me.Text = "TN de Madera Picada por Día"

                'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.MaderaPicada' Puede moverla o quitarla según sea necesario.
                Me.MaderaPicadaTableAdapter.Fill(Me.FIPLANEWDataSetTotal.MaderaPicada)


            Case "tnpicmens"
                Reporte2.Name = "DataSet1"
                Reporte2.Value = Me.FIPLANEWDataSetTotal.MaderaPicada
                Me.RepoView.LocalReport.DataSources.Add(Reporte2)

                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TurnoD", turnoD))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TurnoH", turnoH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptTnPicMes.rdlc"
                ' Asignar la colección params para el visor de informes
                RepoView.LocalReport.SetParameters(parametros)

                Me.Text = "TN de Madera Picada Mensual"
                'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.MaderaPicada' Puede moverla o quitarla según sea necesario.
                Me.MaderaPicadaTableAdapter.Fill(Me.FIPLANEWDataSetTotal.MaderaPicada)


            Case "STPLTOXVAR"
                Reporte2.Name = "DataSet1"
                Reporte2.Value = Me.FIPLANEWDataSetTotal.StockPlayaTotalxVariedad
                Me.RepoView.LocalReport.DataSources.Add(Reporte2)


                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rtpStockPlayaXVariedad.rdlc"
                ' Asignar la colección params para el visor de informes
                parametros.Clear()

                Me.Text = "Stock playa por variedad"
                'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.StockPlayaTotalxVariedad' Puede moverla o quitarla según sea necesario.
                Me.StockPlayaTotalxVariedadTableAdapter.Fill(Me.FIPLANEWDataSetTotal.StockPlayaTotalxVariedad)

        End Select



        Me.RepoView.RefreshReport()

        RepoView.SetDisplayMode(DisplayMode.PrintLayout)
        RepoView.ZoomMode = ZoomMode.PageWidth


        RepoView.Refresh()
        RepoView.Show()


    End Sub



#End Region


    Private Sub frmREPOViewPic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load











    End Sub
End Class