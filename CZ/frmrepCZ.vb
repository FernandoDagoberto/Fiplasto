Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports CrystalDecisions.Shared

Public Class frmrepCZ
    Inherits MetroFramework.Forms.MetroForm
    Dim crReportDocument1 As rptCZDescartes
    Dim crReportDocument3 As rptM48var

    Dim FieldDef As FieldDefinition

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Crear objetos de parámetros
        Dim myParams As New ParameterFields()
        Dim myParam As New ParameterField()
        Dim myDiscreteValue As New ParameterDiscreteValue()
        Dim myParam2 As New ParameterField()
        Dim myDiscreteValue2 As New ParameterDiscreteValue()
        Dim myParam3 As New ParameterField()
        Dim myDiscreteValue3 As New ParameterDiscreteValue()
        Dim myParam4 As New ParameterField()
        Dim myDiscreteValue4 As New ParameterDiscreteValue()
        Dim myParam5 As New ParameterField()
        Dim myDiscreteValue5 As New ParameterDiscreteValue()
        Dim myParam6 As New ParameterField()
        Dim myDiscreteValue6 As New ParameterDiscreteValue()
        Dim myParam7 As New ParameterField()
        Dim myDiscreteValue7 As New ParameterDiscreteValue()
        Dim myParam8 As New ParameterField()
        Dim myDiscreteValue8 As New ParameterDiscreteValue()

        ' Ajuste el ParameterFieldName al nombre del parámetro
        ' Creada en el Explorador de campos

        myParams.Clear()
        myParam.ParameterFieldName = "FechaD"
        myParam2.ParameterFieldName = "FechaH"
        myParam3.ParameterFieldName = "TurnoD"
        myParam4.ParameterFieldName = "TurnoH"
        myParam5.ParameterFieldName = "LineaD"
        myParam6.ParameterFieldName = "LineaH"
        myParam7.ParameterFieldName = "DefectoD"
        myParam8.ParameterFieldName = "DefectoH"

        ' Agregar primer param
        myDiscreteValue.Value = fechaant
        myParam.CurrentValues.Add(myDiscreteValue)
        ' Agregar segundo param
        myDiscreteValue2.Value = fecha
        myParam2.CurrentValues.Add(myDiscreteValue2)
        ' Agregar tercer param
        myDiscreteValue3.Value = turnoD
        myParam3.CurrentValues.Add(myDiscreteValue3)
        ' Agregar Cuarto param
        myDiscreteValue4.Value = turnoH
        myParam4.CurrentValues.Add(myDiscreteValue4)


        Select Case nivdet
                '******************------------------**********************

            Case "descartes" 'CZ - Registro de descartes

                myDiscreteValue5.Value = lineaD
                myParam5.CurrentValues.Add(myDiscreteValue5)

                myDiscreteValue6.Value = lineaH
                myParam6.CurrentValues.Add(myDiscreteValue6)

                myDiscreteValue7.Value = DefectoD
                myParam7.CurrentValues.Add(myDiscreteValue7)

                myDiscreteValue8.Value = DefectoH
                myParam8.CurrentValues.Add(myDiscreteValue8)

                ' Añadir parametros a la colección 
                myParams.Add(myParam)
                myParams.Add(myParam2)
                myParams.Add(myParam3)
                myParams.Add(myParam4)
                myParams.Add(myParam5)
                myParams.Add(myParam6)
                myParams.Add(myParam7)
                myParams.Add(myParam8)

                ' Asignar la colección params para el visor de informes
                reporte.ParameterFieldInfo = myParams

                'Asigne el informe al visor de informes .
                crReportDocument1 = New rptCZDescartes
                reporte.ReportSource = crReportDocument1

                Me.Text = "CZ - Registro de descartes"

                'ordenamiento

                ' crReportDocument.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

                '******************------------------**********************



            Case "variables" 'Variables


                ' Añadir parametros a la colección 
                myParams.Add(myParam)
                myParams.Add(myParam2)
                myParams.Add(myParam3)

                ' Asignar la colección params para el visor de informes
                reporte.ParameterFieldInfo = myParams

                'Asigne el informe al visor de informes .
                crReportDocument3 = New rptM48var
                reporte.ReportSource = crReportDocument3

                Me.Text = "M48 - Variables del Precalentador"

                'ordenamiento

                ' crReportDocument.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

                '******************------------------**********************





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
        Me.reporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'reporte
        '
        Me.reporte.ActiveViewIndex = -1
        Me.reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reporte.DisplayGroupTree = False
        Me.reporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reporte.Location = New System.Drawing.Point(5, 60)
        Me.reporte.Name = "reporte"
        Me.reporte.SelectionFormula = ""
        Me.reporte.ShowCloseButton = False
        Me.reporte.ShowGroupTreeButton = False
        Me.reporte.ShowRefreshButton = False
        Me.reporte.Size = New System.Drawing.Size(440, 237)
        Me.reporte.TabIndex = 0
        Me.reporte.ViewTimeSelectionFormula = ""
        '
        'frmrepCZ
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(450, 302)
        Me.Controls.Add(Me.reporte)
        Me.Name = "frmrepCZ"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Style = MetroFramework.MetroColorStyle.Brown
        Me.Text = "Reportes Cargador de zorras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reporte.Load

    End Sub
End Class
