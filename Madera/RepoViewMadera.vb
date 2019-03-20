Imports Microsoft.Reporting.WinForms

Public Class RepoViewMadera




#Region " Windows Form Designer generated code "
    Public Sub New(ByVal parametros As MadReporte)
        MyBase.New()
        'This call is required by the Windows Form Designer.

        InitializeComponent()

        Me.RepoView.RefreshReport()
        Me.RepoView.Reset()

        Dim señalrepo As String
        Dim Reporte1 As New Microsoft.Reporting.WinForms.ReportDataSource


        Me.RepoView.LocalReport.DataSources.Clear()

        Dim listaparam As New List(Of ReportParameter)
        listaparam.Add(New ReportParameter("FechaD", parametros.FechaD))
        listaparam.Add(New ReportParameter("FechaH", parametros.FechaH))
        listaparam.Add(New ReportParameter("Tipo", tipo))





        Select Case nivdet

            Case "IngMad"
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptIngMad.rdlc"
                Me.Text = "Listado de Ingresos de Madera"
                señalrepo = "dataset"

                '******************************************************************************

            Case "InfCampos" 'Informe de campos
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptInfCampos.rdlc"
                Me.Text = "Informe de campos"
                señalrepo = "dataset"

                '*******************************************************

            Case "InfServicios" ' Informe de Servicios
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptInfServicios.rdlc"
                Me.Text = "Informe de Servicios"
                señalrepo = "dataset"
                  '******************************************************************************

            Case "Terceros" 'Madera de Terceros
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptInfMadTerceros.rdlc"
                Me.Text = "Informe Madera de Terceros"
                señalrepo = "dataset"

                '******************************************************************************

        End Select


        If señalrepo = "dataset" Then
            'Quitamos cualquier datasource que tuviese el informe para cargar el nuestro
            Me.RepoView.LocalReport.DataSources.Clear()

            Reporte1.Name = "DataSet1"
            Reporte1.Value = dt
            Me.RepoView.LocalReport.DataSources.Add(Reporte1)

            ' Asignar la colección params para el visor de informes
            RepoView.LocalReport.SetParameters(listaparam)

        End If

        Me.RepoView.RefreshReport()
        RepoView.SetDisplayMode(DisplayMode.PrintLayout)
        RepoView.ZoomMode = ZoomMode.PageWidth
        RepoView.Refresh()
        RepoView.Show()



    End Sub

    Private Sub RepoViewMadera_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub





#End Region





End Class