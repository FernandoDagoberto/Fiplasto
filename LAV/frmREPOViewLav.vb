Imports Microsoft.Reporting.WinForms


Public Class frmREPOViewLav


#Region " Windows Form Designer generated code "

    Public Sub New(ByVal parametros As LavReporte)
        MyBase.New()
        'This call is required by the Windows Form Designer.

        InitializeComponent()

        Me.RepoView.RefreshReport()
        Me.RepoView.Reset()

        Dim señalrepo As String

        Dim Reporte1 As New Microsoft.Reporting.WinForms.ReportDataSource   'Cantidad de Lavado de tejidos doble hilado
        Dim Reporte2 As New Microsoft.Reporting.WinForms.ReportDataSource   'Lav - Colocación de tejidos nuevos
        Dim reporte3 As New Microsoft.Reporting.WinForms.ReportDataSource   'Lav - Tejidos Dados de baja
        Dim reporte4 As New Microsoft.Reporting.WinForms.ReportDataSource   'Lav - Tejidos Segregados para reparacion
        Dim reporte5 As New Microsoft.Reporting.WinForms.ReportDataSource   'Lav - Cambio de tejidos
        Dim reporte6 As New Microsoft.Reporting.WinForms.ReportDataSource   'Chapas de transporte INGRESO
        Dim reporte7 As New Microsoft.Reporting.WinForms.ReportDataSource   'Chapas de transporte EGRESO
        Dim reporte8 As New Microsoft.Reporting.WinForms.ReportDataSource   'CUBREPLACAS INGRESO
        Dim reporte9 As New Microsoft.Reporting.WinForms.ReportDataSource   'CUBREPLACAS EGRESO
        Dim reporte10 As New Microsoft.Reporting.WinForms.ReportDataSource  'DECORATIVOS
        Dim reporte11 As New Microsoft.Reporting.WinForms.ReportDataSource  'INOXIDABLES INGRESO
        Dim reporte12 As New Microsoft.Reporting.WinForms.ReportDataSource  'INOXIDABLES EGRESO
        Dim reporte13 As New Microsoft.Reporting.WinForms.ReportDataSource  'Consumo soda cáustica
        Dim reporte14 As New Microsoft.Reporting.WinForms.ReportDataSource  'Temperatura y concentración soda cáustica
        Dim reporte15 As New Microsoft.Reporting.WinForms.ReportDataSource  'Limpieza de cubas
        Dim reporte16 As New Microsoft.Reporting.WinForms.ReportDataSource  'LAVADERO GENERAL
        Dim reporte17 As New Microsoft.Reporting.WinForms.ReportDataSource  'CUBREPLACAS SEGUIMIENTO DE VIDA
        Dim reporte18 As New Microsoft.Reporting.WinForms.ReportDataSource  'CHAPAS DE TRANSPORTE SEGUIMIENTO DE VIDA
        Dim reporte19 As New Microsoft.Reporting.WinForms.ReportDataSource  'INOXIDABLES SEGUIMIENTO DE VIDA
        Dim reporte20 As New Microsoft.Reporting.WinForms.ReportDataSource  'Tejidos doble hilado SEGUIMIENTO DE VIDA
        Dim reporte21 As New Microsoft.Reporting.WinForms.ReportDataSource  'LAVADERO REPARACIONES



        Me.RepoView.LocalReport.DataSources.Clear()

        Dim ListaParam As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaD", parametros.FechaD))
        ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaH", parametros.FechaH))


        Select Case nivdet

            Case "TDHLavado" 'Cantidad de Lavado de tejidos doble hilado
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVTDHL.rdlc"
                Me.Text = "Cantidad de Tejidos Doble Hilado Lavados"
                señalrepo = "dataset"

                '******************************************************************************

            Case "TDHNuevos" 'Lav - Colocación de tejidos nuevos
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVTDHN.rdlc"
                Me.Text = "Colocación de tejidos nuevos"
                señalrepo = "dataset"

                '*******************************************************

            Case "TDHBaja" 'Lav - Tejidos Dados de baja
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVTDHB.rdlc"
                Me.Text = "Tejidos Dados de baja"
                señalrepo = "dataset"
                '******************************************************************************

            Case "TDHSegr" 'Lav - Tejidos Segregados para reparacion
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("RazonD", parametros.RazonD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("RazonH", parametros.RazonH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVTDHR.rdlc"
                Me.Text = "Tejidos Segregados para reparacion"
                señalrepo = "dataset"
                '******************************************************************************

            Case "TDHCambio" 'Lav - Cambio de tejidos
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVTDHC.rdlc"
                Me.Text = "Cambio de tejidos"
                señalrepo = "dataset"
                '******************************************************************************
                'REPORTES DE CHAPAS DE TRANSPORTE


            Case "CHTRIng"  'Chapas de transporte INGRESO
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVCHTRI.rdlc"
                Me.Text = "Ingreso Chapas de Transporte"
                señalrepo = "dataset"

                '******************************************************************************



            Case "CHTREgr"  'Chapas de transporte Egreso
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("RazonD", parametros.RazonD))


                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVCHTRE.rdlc"
                Me.Text = "Egreso Chapas de Transporte"
                señalrepo = "dataset"

                '******************************************************************************

            Case "CCPIng"  'CUBREPLACAS INGRESO
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVCCPI.rdlc"
                Me.Text = "Ingreso de Cubreplacas a prensa"
                señalrepo = "dataset"
                '******************************************************************************


            Case "CCPEgr"  'CUBREPLACAS EGRESO
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVCCPE.rdlc"
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("RazonD", parametros.RazonD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("RazonH", parametros.RazonH))
                Me.Text = "Egreso de Cubreplacas de prensa"
                señalrepo = "dataset"

                '******************************************************************************

            Case "LAVDECO"  'DECORATIVOS
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVDECO.rdlc"
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("RazonD", parametros.RazonD))
                Me.Text = "DECORATIVOS"
                señalrepo = "dataset"
                '******************************************************************************


            Case "INOXIng"  'INOXIDABLES INGRESO A PRENSA
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVINOXI.rdlc"
                Me.Text = "Ingreso Inoxidables a Prensa"
                señalrepo = "dataset"

                '******************************************************************************


            Case "INOXEgr"  'INOXIDABLES EGRESO DE PRENSA
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New ReportParameter("LineaH", parametros.LineaH))
                ListaParam.Add(New ReportParameter("RazonD", parametros.RazonD))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVINOXE.rdlc"
                Me.Text = "Egreso Inoxidables de Prensa"
                señalrepo = "dataset"
                                '******************************************************************************

            Case "SODASoda"  'Consumo soda cáustica
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVSODAS.rdlc"
                Me.Text = "Consumo soda cáustica"
                señalrepo = "dataset"
                '******************************************************************************

            Case "SODATemp"  'Temperatura y concentración cubas
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVSODATYC.rdlc"
                Me.Text = "Temperatura y concentración"
                señalrepo = "dataset"
                '******************************************************************************

            Case "LimpCuba"  'Limpieza de cubas
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVLIMPCUBA.rdlc"
                Me.Text = "Limpieza de cubas"
                señalrepo = "dataset"

                '******************************************************************************

            Case "LAVGRAL"
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLavGral.rdlc"
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("TurnoD", parametros.TurnoD))
                Me.Text = "Reporte de tareas realizadas por Turno"
                señalrepo = "dataset"
                '******************************************************************************



            Case "CCPVida"  'CUBREPLACAS SEGUIMIENTO DE VIDA
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVCCPVida.rdlc"
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                Me.Text = "Cubreplacas Seguimiento de vida"
                señalrepo = "dataset"
                '******************************************************************************


            Case "CHTRVida"  'CHAPAS DE TRANSPORTE SEGUIMIENTO DE VIDA
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVCHTRVida.rdlc"
                Me.Text = "CHAPAS DE TRANSPORTE Seguimiento de vida"
                señalrepo = "dataset"


                '******************************************************************************

            Case "INOXVida"  'INOXIDABLES SEGUIMIENTO DE VIDA
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New ReportParameter("LineaH", parametros.LineaH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVINOXVida.rdlc"
                Me.Text = "CHAPAS INOXIDABLES Seguimiento de vida"
                señalrepo = "dataset"
                '******************************************************************************

            Case "TDHVida"  'Tejido doble hilado SEGUIMIENTO DE VIDA
                'Aquí le indicamos qué informe usar
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaD", parametros.LineaD))
                ListaParam.Add(New Microsoft.Reporting.WinForms.ReportParameter("LineaH", parametros.LineaH))
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLAVTDHVida.rdlc"
                Me.Text = "TEJIDO DOBLE HILADO Seguimiento de vida"
                señalrepo = "dataset"
                '******************************************************************************


            Case "REPARACIONES"  'LAVADERO REPARACIONES
                'Aquí le indicamos qué informe usar
                RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLavReparac.rdlc"
                Me.Text = "INFORME DE REPARACIONES"
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
            RepoView.LocalReport.SetParameters(ListaParam)

        End If

        Me.RepoView.RefreshReport()
        RepoView.SetDisplayMode(DisplayMode.PrintLayout)
        RepoView.ZoomMode = ZoomMode.PageWidth
        RepoView.Refresh()
        RepoView.Show()



    End Sub



#End Region


    Private Sub frmREPOViewLav_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        




    End Sub
End Class