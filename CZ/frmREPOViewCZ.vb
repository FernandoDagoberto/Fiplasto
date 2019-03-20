Imports Microsoft.Reporting.WinForms


Public Class frmREPOViewCZ


#Region " Windows Form Designer generated code "

    Public Sub New(ByVal parametros As CZReporte)
        MyBase.New()
        'This call is required by the Windows Form Designer.

        InitializeComponent()

        Me.RepoView.RefreshReport()
        Me.RepoView.Reset()

        Dim señalrepo As String


        Dim Reporte1 As New Microsoft.Reporting.WinForms.ReportDataSource   'Cantidad de tableros prensados

        Me.RepoView.LocalReport.DataSources.Clear()

        Dim ListaParam As New List(Of ReportParameter)
        ListaParam.Add(New ReportParameter("FechaD", parametros.FechaD))
        ListaParam.Add(New ReportParameter("FechaH", parametros.FechaH))
        ListaParam.Add(New ReportParameter("TurnoD", parametros.TurnoD))
        ListaParam.Add(New ReportParameter("TurnoH", parametros.TurnoH))

        Select Case nivdet

            Case "tblpren" 'CZ - Cantidad de tableros prensados
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptCZtblpren.rdlc"
                ListaParam.Add(New ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New ReportParameter("LineaH", parametros.LineaH))
                Me.Text = "Cantidad de tableros prensados"
                señalrepo = "dataset"
         '******************************************************************************

            Case "tblacept" 'CZ - Cantidad de tableros aceptados
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptCZtblaceptados.rdlc"
                ListaParam.Add(New ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New ReportParameter("LineaH", parametros.LineaH))
                Me.Text = "Cantidad de tableros Aceptados"
                señalrepo = "dataset"

                '*******************************************************

            Case "rotulador" ' Reporte de limpieza de rotulador
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptCZrotulador.rdlc"
                ListaParam.Add(New ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New ReportParameter("LineaH", parametros.LineaH))
                Me.Text = "Rotulador"
                señalrepo = "dataset"

                '******************************************************************************

            Case "espesor" 'CZ Reporte de espesores
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptCZPromEspesores.rdlc"
                ListaParam.Add(New ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New ReportParameter("LineaH", parametros.LineaH))

                ListaParam.Add(New ReportParameter("EspesorD", parametros.MaterialD))
                ListaParam.Add(New ReportParameter("EspesorH", parametros.MaterialH))

                Me.Text = "Registro de Espesores"
                señalrepo = "dataset"

                '******************************************************************************

            Case "reparar" 'CZ - Reparación zorras
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptCZReparacion.rdlc"
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("ReparaD", parametros.ReparaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("ReparaH", parametros.ReparaH))
                Me.Text = "Estado de parque de zorras"
                señalrepo = "dataset"

                '******************************************************************************

            Case "ctrldim"  'Controles dimensionales
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptCZCtrlDim.rdlc"
                ListaParam.Add(New ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New ReportParameter("LineaH", parametros.LineaH))
                Me.Text = "Controles dimensionales"
                señalrepo = "dataset"

              '******************************************************************************
            Case "tblrech"  'Controles dimensionales
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptCzRech.rdlc"
                ListaParam.Add(New ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New ReportParameter("LineaH", parametros.LineaH))
                ListaParam.Add(New ReportParameter("DefectoD", parametros.DefectoD))
                ListaParam.Add(New ReportParameter("DefectoH", parametros.DefectoH))
                Me.Text = ""
                señalrepo = "dataset"
        End Select



        If señalrepo = "dataset" Then
            'Quitamos cualquier datasource que tuviese el informe para cargar el nuestro
            Me.RepoView.LocalReport.DataSources.Clear()

            Reporte1.Name = "DataSet1"
            Reporte1.Value = dt
            Me.RepoView.LocalReport.DataSources.Add(Reporte1)

            'Asignar la colección params para el visor de informes
            RepoView.LocalReport.SetParameters(ListaParam)

        End If

        Me.RepoView.RefreshReport()
        RepoView.SetDisplayMode(DisplayMode.PrintLayout)
        RepoView.ZoomMode = ZoomMode.PageWidth
        RepoView.Refresh()
        RepoView.Show()





    End Sub



#End Region


    Private Sub frmREPOViewCZ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load









    End Sub
End Class