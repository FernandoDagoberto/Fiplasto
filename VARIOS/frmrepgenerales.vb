Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports CrystalDecisions.Shared

Public Class frmrepgenerales
    Inherits MetroFramework.Forms.MetroForm

    Dim crReportDocument4 As rptParadas
    Dim crReportDocument6 As rptSector
    Dim crReportDocument8 As rptNovedades
    Dim FieldDef As FieldDefinition

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        Select Case nivdet

            Case "paradas" 'listado de paradas
                crReportDocument4 = New rptParadas
                reporte.ReportSource = crReportDocument4

                Me.Text = "Listado de Paradas"

                FieldDef = crReportDocument4.Database.Tables.Item(0).Fields.Item("sector_desc")
                crReportDocument4.DataDefinition.SortFields.Item(0).Field = FieldDef

                ' crReportDocument4.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

            Case "sector" 'Listado de Sectores
                crReportDocument6 = New rptSector
                reporte.ReportSource = crReportDocument6

                Me.Text = "Listado de Sectores"

                
                crReportDocument6.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()


        End Select

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub



    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents reporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.reporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'reporte
        '
        Me.reporte.ActiveViewIndex = -1
        Me.reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reporte.DisplayGroupTree = False
        Me.reporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reporte.Location = New System.Drawing.Point(0, 0)
        Me.reporte.Name = "reporte"
        Me.reporte.SelectionFormula = ""
        Me.reporte.ShowCloseButton = False
        Me.reporte.ShowGroupTreeButton = False
        Me.reporte.ShowRefreshButton = False
        Me.reporte.Size = New System.Drawing.Size(450, 302)
        Me.reporte.TabIndex = 0
        Me.reporte.ViewTimeSelectionFormula = ""
        '
        'frmrepgenerales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(450, 302)
        Me.Controls.Add(Me.reporte)
        Me.Name = "frmrepgenerales"
        Me.StartPosition = FormStartPosition.Manual
        Me.Text = "Reporte generales"
        Me.WindowState = FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reporte.Load

    End Sub
End Class
