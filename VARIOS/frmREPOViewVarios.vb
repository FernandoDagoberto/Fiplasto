Imports Microsoft.Reporting.WinForms


Public Class frmREPOViewVarios


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.

        InitializeComponent()

        Me.RepoView.RefreshReport()
        Me.RepoView.Reset()

        Dim Reporte1 As New Microsoft.Reporting.WinForms.ReportDataSource   'Novedades
       



        Me.RepoView.LocalReport.DataSources.Clear()

        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaD", fechaant))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaH", fecha))


        Select Case nivdet

            Case "Novedades" 'Novedades
                Reporte1.Name = "FIPLANEWDataSetTotal_NOVEDADES"
                Reporte1.Value = Me.FIPLANEWDataSetTotal.NOVEDADES

                Me.RepoView.LocalReport.DataSources.Add(Reporte1)

                'Uso lineaD y H para los sectores para no definir más variables
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("SectorD", lineaD))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("SectorH", lineaH))

                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptNovedades.rdlc"

                ' Asignar la colección params para el visor de informes
                RepoView.LocalReport.SetParameters(parametros)

                Me.Text = "Novedades"

                'TODO: esta línea de código carga datos en la tabla 'FIPLANEWDataSetTotal.NOVEDADES' Puede moverla o quitarla según sea necesario.
                Me.NOVEDADESTableAdapter.Fill(Me.FIPLANEWDataSetTotal.NOVEDADES)
                Me.RepoView.RefreshReport()

                RepoView.SetDisplayMode(DisplayMode.PrintLayout)
                RepoView.ZoomMode = ZoomMode.PageWidth

                RepoView.Refresh()
                RepoView.Show()

                '******************************************************************************


        End Select
    End Sub



#End Region


    Private Sub frmREPOViewVarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        





    End Sub
End Class