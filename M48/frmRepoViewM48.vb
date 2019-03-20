Imports Microsoft.Reporting.WinForms

Public Class frmRepoViewM48

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
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TurnoD", turnoD))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TurnoH", turnoH))

        Select Case nivdet


            Case "bolsas"
                Reporte2.Name = "DataSet1"
                Reporte2.Value = Me.FIPLANEWDataSetTotal.CRTLSULFALU

                Me.RepoView.LocalReport.DataSources.Add(Reporte2)

                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptM48Bolsas.rdlc"

                ' Asignar la colección params para el visor de informes
                RepoView.LocalReport.SetParameters(parametros)

                Me.Text = ""
                'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.CRTLSULFALU' Puede moverla o quitarla según sea necesario.
                Me.CRTLSULFALUTableAdapter.Fill(Me.FIPLANEWDataSetTotal.CRTLSULFALU)


            '*******************************************************************************

            Case "ensayosM48" ' Reporte de ensayos del M48
                'REPORTE 
                Reporte2.Name = "FIPLANEWDataSetTotal_CRTLSULFENS"
                Reporte2.Value = Me.FIPLANEWDataSetTotal.CRTLSULFENS

                Me.RepoView.LocalReport.DataSources.Add(Reporte2)

                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", lineaD))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", lineaH))

                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.Rptm48ensayo.rdlc"

                ' Asignar la colección params para el visor de informes
                RepoView.LocalReport.SetParameters(parametros)
                Me.Text = "M48 - Control Solución Sulfato Aluminio Ensayos"
                'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.CRTLSULFENS' Puede moverla o quitarla según sea necesario.
                Me.CRTLSULFENSTableAdapter.Fill(Me.FIPLANEWDataSetTotal.CRTLSULFENS)

                '******************************************************************************



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





            '*******************************************************************************


            Case "nivelsilos"
                Reporte2.Name = "DataSet1"
                Reporte2.Value = Me.FIPLANEWDataSetTotal.NivelSiloView

                Me.RepoView.LocalReport.DataSources.Add(Reporte2)

                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptNivSilos.rdlc"

                ' Asignar la colección params para el visor de informes
                RepoView.LocalReport.SetParameters(parametros)

                Me.Text = "Nivel de Silos"




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



            Case "STPLTOXVAR"
                Reporte2.Name = "DataSet1"
                Reporte2.Value = Me.FIPLANEWDataSetTotal.StockPlayaTotalxVariedad
                Me.RepoView.LocalReport.DataSources.Add(Reporte2)


                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rtpStockPlayaXVariedad.rdlc"
                ' Asignar la colección params para el visor de informes
                parametros.Clear()

                Me.Text = "Stock playa por variedad"


        End Select



        Me.RepoView.RefreshReport()

        RepoView.SetDisplayMode(DisplayMode.PrintLayout)
        RepoView.ZoomMode = ZoomMode.PageWidth


        RepoView.Refresh()
        RepoView.Show()


    End Sub




#End Region



    Private Sub frmRepoViewM48_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.RepoView.RefreshReport()
    End Sub
End Class