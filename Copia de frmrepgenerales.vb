Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports CrystalDecisions.Shared

Public Class frmrepgenerales
    Inherits System.Windows.Forms.Form
    Dim crReportDocument As rptArea
    Dim crReportDocument1 As rptCausa
    Dim crReportDocument2 As rptMaquinas
    Dim crReportDocument3 As rptMotivo
    Dim crReportDocument4 As rptParadas
    Dim crReportDocument5 As rptReparo
    Dim crReportDocument6 As rptSector
    Dim crReportDocument7 As rptTipMad
    Dim FieldDef As FieldDefinition

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        Select Case nivdet

            Case "area" 'Listado de Áreas

                'Asigne el informe al visor de informes .
                crReportDocument = New rptArea
                reporte.ReportSource = crReportDocument

                Me.Text = "Listado de Áreas"

                'ordenamiento
                FieldDef = crReportDocument.Database.Tables.Item(0).Fields.Item("area_id")
                crReportDocument.DataDefinition.SortFields.Item(0).Field = FieldDef

                crReportDocument.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

            Case "causa" 'Listado de causas

                crReportDocument1 = New rptCausa
                reporte.ReportSource = crReportDocument1

                Me.Text = "Listado de Causas"

                FieldDef = crReportDocument1.Database.Tables.Item(0).Fields.Item("causa_id")
                crReportDocument1.DataDefinition.SortFields.Item(0).Field = FieldDef

                crReportDocument1.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()



            Case "maquinas" 'Listado de máquinas

                crReportDocument2 = New rptMaquinas
                reporte.ReportSource = crReportDocument2

                Me.Text = "Listado de Máquinas"

                FieldDef = crReportDocument2.Database.Tables.Item(0).Fields.Item("maquinas_id")
                crReportDocument2.DataDefinition.SortFields.Item(0).Field = FieldDef

                crReportDocument2.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

            Case "motivo" 'listado de motivos
                crReportDocument3 = New rptMotivo
                reporte.ReportSource = crReportDocument3

                Me.Text = "Listado de Motivos"

                FieldDef = crReportDocument3.Database.Tables.Item(0).Fields.Item("motivo_id")
                crReportDocument3.DataDefinition.SortFields.Item(0).Field = FieldDef

                crReportDocument3.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

            Case "paradas" 'listado de paradas
                crReportDocument4 = New rptParadas
                reporte.ReportSource = crReportDocument4

                Me.Text = "Listado de Paradas"

                FieldDef = crReportDocument4.Database.Tables.Item(0).Fields.Item("sector_desc")
                crReportDocument4.DataDefinition.SortFields.Item(0).Field = FieldDef

                crReportDocument4.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

            Case "reparo" 'Reparo - Listado
                crReportDocument5 = New rptReparo
                reporte.ReportSource = crReportDocument5

                Me.Text = "Reparo - Listado"

                FieldDef = crReportDocument5.Database.Tables.Item(0).Fields.Item("reparo_id")
                crReportDocument5.DataDefinition.SortFields.Item(0).Field = FieldDef

                crReportDocument5.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

            Case "sector" 'Listado de Sectores
                crReportDocument6 = New rptSector
                reporte.ReportSource = crReportDocument6

                Me.Text = "Listado de Sectores"

                
                crReportDocument6.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

            Case "tipmad" 'Listado de Tipos de Madera
                crReportDocument7 = New rptTipMad
                reporte.ReportSource = crReportDocument7

                Me.Text = "Listado de Tipos de Madera"

                FieldDef = crReportDocument7.Database.Tables.Item(0).Fields.Item("tipmad_id")
                crReportDocument7.DataDefinition.SortFields.Item(0).Field = FieldDef

                crReportDocument7.DataSourceConnections.Item(0).SetLogon(usersql, pass)
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
        'frmsocios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(450, 302)
        Me.Controls.Add(Me.reporte)
        Me.Name = "frmsocios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Reporte Socios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reporte.Load

    End Sub
End Class
