Imports Microsoft.Reporting.WinForms


Public Class frmREPOViewMC


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.

        InitializeComponent()

        Me.RepoView.RefreshReport()
        Me.RepoView.Reset()

        Dim Reporte1 As New Microsoft.Reporting.WinForms.ReportDataSource

        Dim señalrepo As String

        Me.RepoView.LocalReport.DataSources.Clear()

        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaD", fechaant))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaH", fecha))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TurnoD", turnoD))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("TurnoH", turnoH))


        Select Case nivdet

            Case "ensmaq" 'MC - Ensayos en máquina
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptMCEnsMaq.rdlc"
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", lineaD))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", lineaH))
                Me.Text = "MC - Ensayos"
                señalrepo = "dataset"
           '******************************************************************************

            Case "enstq" 'MC - Ensayos en tanque
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptMCEnsTQ.rdlc"
                Me.Text = "MC - Ensayos en tanque"
                señalrepo = "dataset"


                '*******************************************************

            Case "varproc" 'MC - Variables del proceso
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptMCVarProc.rdlc"
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", lineaD))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", lineaH))
                Me.Text = "MC - Variables del Proceso"
                señalrepo = "dataset"
            '******************************************************************************
            Case "Cuchillas"
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptMcCuchillas.rdlc"
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", lineaD))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", lineaH))
                Me.Text = "Cambio de Cuchillas"
                señalrepo = "dataset"
            '******************************************************************************

            Case "hipoclorito"
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptMcHipo.rdlc"
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", lineaD))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", lineaH))
                Me.Text = "Hipoclorito"
                señalrepo = "dataset"
            '******************************************************************************
            Case "LimpVac"
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptMcLimpVac.rdlc"
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", lineaD))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", lineaH))
                Me.Text = "Limpieza de Vacios"
                señalrepo = "dataset"

            Case "ConsumoParafina"
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptMCParafCon.rdlc"
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", lineaD))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", lineaH))
                Me.Text = "Consumo de Parafina"
                señalrepo = "dataset"

            Case "Parafina"
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptMCParafina.rdlc"
                Me.Text = "Preparación de Parafina"
                señalrepo = "dataset"

            Case "Canerias"
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptMCVacVal.rdlc"
                Me.Text = ""
                señalrepo = "dataset"

            Case "Telas"
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptMCTelas.rdlc"
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", lineaD))
                parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", lineaH))
                Me.Text = "Cambio de Telas"
                señalrepo = "dataset"




        End Select

        If señalrepo = "dataset" Then
            'Quitamos cualquier datasource que tuviese el informe para cargar el nuestro
            Me.RepoView.LocalReport.DataSources.Clear()

            Reporte1.Name = "DataSet1"
            Reporte1.Value = dt
            Me.RepoView.LocalReport.DataSources.Add(Reporte1)

            ' Asignar la colección params para el visor de informes
            RepoView.LocalReport.SetParameters(parametros)

        End If

        Me.RepoView.RefreshReport()
        RepoView.SetDisplayMode(DisplayMode.PrintLayout)
        RepoView.ZoomMode = ZoomMode.PageWidth
        RepoView.Refresh()
        RepoView.Show()



    End Sub



#End Region


    Private Sub frmREPOViewMC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




    End Sub
End Class