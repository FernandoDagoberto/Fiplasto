Imports Microsoft.Reporting.WinForms


Public Class frmREPOViewBiomasa


#Region " Windows Form Designer generated code "

    Public Sub New(ByVal parametros As BioReporte)
        MyBase.New()
        'This call is required by the Windows Form Designer.

        InitializeComponent()

        Me.RepoView.RefreshReport()
        Me.RepoView.Reset()

        Dim señalrepo As String

        Dim Reporte1 As New Microsoft.Reporting.WinForms.ReportDataSource   'Cantidad de Lavado de tejidos doble hilado

        Me.RepoView.LocalReport.DataSources.Clear()

        Dim ListaParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaD", parametros.FechaD))
        ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaH", parametros.FechaH))
        ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("Tipo", parametros.Tipo))


        Select Case nivdet

            Case "DescarteBio" 'Descartes Biomasa
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptDescarteBio.rdlc"
                Me.Text = "Descartes para Biomasa"
                señalrepo = "dataset"

                '******************************************************************************


        End Select


        If señalrepo = "dataset" Then
            'Quitamos cualquier datasource que tuviese el informe para cargar el nuestro
            Me.RepoView.LocalReport.DataSources.Clear()
            Reporte1.Name = "DataSet1"
            Reporte1.Value = parametros.query
            Me.RepoView.LocalReport.DataSources.Add(Reporte1)

            ' Asignar la colección params para el visor de informes
            RepoView.LocalReport.SetParameters(ListaParam)

        End If

        Me.RepoView.RefreshReport()
        RepoView.SetDisplayMode(DisplayMode.PrintLayout)
        RepoView.ZoomMode = ZoomMode.PageWidth
        RepoView.Refresh()
        RepoView.Show()



    End Sub



#End Region


    Private Sub frmREPOViewBiomasa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.BIODESCARTE' Puede moverla o quitarla según sea necesario.
        Me.BIODESCARTETableAdapter.Fill(Me.FIPLANEWDataSetTotal.BIODESCARTE)





    End Sub
End Class