Imports Microsoft.Reporting.WinForms

Public Class frmRepoBasicos

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal informe As String, ByVal parametros As cRepo)
        MyBase.New()
        'This call is required by the Windows Form Designer.

        InitializeComponent()

        Me.RepoViewBas.RefreshReport()
        Me.RepoViewBas.Reset()

        'Instancia de origenes de datos
        Dim Origen1 As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim Origen2 As New Microsoft.Reporting.WinForms.ReportDataSource

        Me.RepoViewBas.LocalReport.DataSources.Clear()

        Dim ListaParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaD", parametros.FechaD))
        ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaH", parametros.FechaH))
        ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
        ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))

        Select Case informe

            Case "ParadaMensual"
                Origen1.Name = "PRODUCCIONDataSet_ParadasBasicos"
                Origen1.Value = Me.PRODUCCIONDataSet.ParadasBasicos

                Me.RepoViewBas.LocalReport.DataSources.Add(Origen1)

                RepoViewBas.LocalReport.ReportEmbeddedResource = "SPIF.rptParadasBasicos.rdlc"
                ' Asignar la colección params para el visor de informes
                RepoViewBas.LocalReport.SetParameters(ListaParam)
                Me.Text = "Reporte de Paradas Mensual"
                'TODO: esta línea de código carga datos en la tabla 'PRODUCCIONDataSet.ParadasBasicos' Puede moverla o quitarla según sea necesario.
                Me.ParadasBasicosTableAdapter.Fill(Me.PRODUCCIONDataSet.ParadasBasicos)


            Case "ParadaDiario"
                Origen1.Name = "PRODUCCIONDataSet_ParadasBasicos"
                Origen1.Value = Me.PRODUCCIONDataSet.ParadasBasicos

                Me.RepoViewBas.LocalReport.DataSources.Add(Origen1)

                RepoViewBas.LocalReport.ReportEmbeddedResource = "SPIF.rptParadasDiario.rdlc"

                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Reporte", informe))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("ParadaD", parametros.ParadaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("ParadaH", parametros.ParadaH))


                ' Asignar la colección params para el visor de informes
                RepoViewBas.LocalReport.SetParameters(ListaParam)
                Me.Text = "Reporte de Paradas Diario"

                'TODO: esta línea de código carga datos en la tabla 'PRODUCCIONDataSet.ParadasBasicos' Puede moverla o quitarla según sea necesario.
                Me.ParadasBasicosTableAdapter.Fill(Me.PRODUCCIONDataSet.ParadasBasicos)

            Case "Detallado"
                Origen1.Name = "PRODUCCIONDataSet_ParadasBasicos"
                Origen1.Value = Me.PRODUCCIONDataSet.ParadasBasicos

                Me.RepoViewBas.LocalReport.DataSources.Add(Origen1)

                RepoViewBas.LocalReport.ReportEmbeddedResource = "SPIF.rptParadasDiario.rdlc"
                ' Asignar la colección params para el visor de informes

                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Reporte", informe))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("ParadaD", parametros.ParadaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("ParadaH", parametros.ParadaH))


                RepoViewBas.LocalReport.SetParameters(ListaParam)
                Me.Text = "Reporte de Paradas Detallado"

                'TODO: esta línea de código carga datos en la tabla 'PRODUCCIONDataSet.ParadasBasicos' Puede moverla o quitarla según sea necesario.
                Me.ParadasBasicosTableAdapter.Fill(Me.PRODUCCIONDataSet.ParadasBasicos)

            Case "Produccion"

                'Quitamos cualquier datasource que tuviese el informe para cargar el nuestro
                Me.RepoViewBas.LocalReport.DataSources.Clear()
                'Creamos un nuevo ReportDataSource con los datos conseguidos de la BD
                Origen1.Name = "PRODUCCIONDataSet_InformeProduccion"
                Origen1.Value = TablaInforme
                Origen2.Name = "PRODUCCIONDataSet_InformeProduccionAcumulado"
                Origen2.Value = TablaInforme

                RepoViewBas.LocalReport.ReportEmbeddedResource = "SPIF.rptProduccion.rdlc"

                RepoViewBas.LocalReport.DataSources.Add(Origen1)
                RepoViewBas.LocalReport.DataSources.Add(Origen2)


                ListaParam.Clear()


                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaD", parametros.FechaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaH", parametros.FechaH))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaIniMes", parametros.FechaIniMes))
                RepoViewBas.LocalReport.SetParameters(ListaParam)


            Case "Novedades"

                'Quitamos cualquier datasource que tuviese el informe para cargar el nuestro
                Me.RepoViewBas.LocalReport.DataSources.Clear()
                'Creamos un nuevo ReportDataSource con los datos conseguidos de la BD
                Origen1.Name = "PRODUCCIONDataSet_InformeProduccion"
                Origen1.Value = TablaInforme
                RepoViewBas.LocalReport.ReportEmbeddedResource = "SPIF.rptNovedadesBas.rdlc"

                RepoViewBas.LocalReport.DataSources.Add(Origen1)
                ListaParam.Clear()

                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaD", parametros.FechaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaH", parametros.FechaH))
                RepoViewBas.LocalReport.SetParameters(ListaParam)



        End Select


        Me.RepoViewBas.RefreshReport()
        RepoViewBas.SetDisplayMode(DisplayMode.PrintLayout)
        RepoViewBas.ZoomMode = ZoomMode.PageWidth
        RepoViewBas.Refresh()
        RepoViewBas.Show()




    End Sub





#End Region

    Private Sub frmRepoBasicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       






    End Sub
End Class