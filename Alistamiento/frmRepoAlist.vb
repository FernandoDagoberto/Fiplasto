Imports Microsoft.Reporting.WinForms

Public Class frmRepoAlist

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.

        InitializeComponent()

        Me.RepoViewAlis.RefreshReport()
        Me.RepoViewAlis.Reset()

        'Instancia de origenes de datos
        Dim Origen1 As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim Origen2 As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim Origen3 As New Microsoft.Reporting.WinForms.ReportDataSource
        Dim Origen4 As New Microsoft.Reporting.WinForms.ReportDataSource

        Me.RepoViewAlis.LocalReport.DataSources.Clear()

        Dim parametros As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaD", fch))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("FechaH", fch1))
        parametros.Add(New Microsoft.Reporting.WinForms.ReportParameter("InicioMes", fchPrimerDia))


        Origen1.Name = "DSAlistamiento_AliSierraMohog"
        Origen1.Value = Me.DSAlistamiento.AliSierraMohog
        Origen2.Name = "DSAlistamiento_AliProduccion"
        Origen2.Value = Me.DSAlistamiento.AliProduccion
        Origen3.Name = "DSAlistamiento_AliProduccionMensual"
        Origen3.Value = Me.DSAlistamiento.AliProduccionMensual
        Origen4.Name = "DSAlistamiento_AliAcumMensual"
        Origen4.Value = Me.DSAlistamiento.AliSierraMohog



        Me.RepoViewAlis.LocalReport.DataSources.Add(Origen1)
        Me.RepoViewAlis.LocalReport.DataSources.Add(Origen2)
        Me.RepoViewAlis.LocalReport.DataSources.Add(Origen3)
        Me.RepoViewAlis.LocalReport.DataSources.Add(Origen4)


        RepoViewAlis.LocalReport.ReportEmbeddedResource = "SPIF.rptAlistamiento.rdlc"

        ' Asignar la colección params para el visor de informes
        RepoViewAlis.LocalReport.SetParameters(parametros)


        Me.Text = "Alistamiento"

        'TODO: esta línea de código carga datos en la tabla 'DSAlistamiento.AliSierraMohog' Puede moverla o quitarla según sea necesario.
        Me.AliSierraMohogTableAdapter.Fill(Me.DSAlistamiento.AliSierraMohog)
        'TODO: esta línea de código carga datos en la tabla 'DSAlistamiento.AliProduccion' Puede moverla o quitarla según sea necesario.
        Me.AliProduccionTableAdapter.Fill(Me.DSAlistamiento.AliProduccion, fch1, "Sierra Mohog")
        'TODO: esta línea de código carga datos en la tabla 'DSAlistamiento.AliProduccionMensual' Puede moverla o quitarla según sea necesario.
        Me.AliProduccionMensualTableAdapter.FillMensual(Me.DSAlistamiento.AliProduccionMensual, fchPrimerDia, fch1, "Sierra Mohog")



        Me.RepoViewAlis.RefreshReport()


        RepoViewAlis.SetDisplayMode(DisplayMode.PrintLayout)
        RepoViewAlis.ZoomMode = ZoomMode.PageWidth


        RepoViewAlis.Refresh()
        RepoViewAlis.Show()




    End Sub


#End Region

    Private Sub frmRepoAlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class