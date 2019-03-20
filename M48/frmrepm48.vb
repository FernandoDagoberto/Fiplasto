Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports CrystalDecisions.Shared

Public Class frmrepm48
    Inherits MetroFramework.Forms.MetroForm
    Dim crReportDocument As rptM48ctrlfibras

    Dim crReportDocument3 As rptM48var

    'Dim crReportDocument7 As rptTipMad
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

        
        ' Ajuste el ParameterFieldName al nombre del parámetro
        ' Creada en el Explorador de campos

        myParams.Clear()
        myParam.ParameterFieldName = "FechaD"
        myParam2.ParameterFieldName = "FechaH"
        myParam3.ParameterFieldName = "Turno"
        myParam4.ParameterFieldName = "Linea"


        ' Agregar primer param
        myDiscreteValue.Value = fechaant
        myParam.CurrentValues.Add(myDiscreteValue)
        ' Agregar segundo param
        myDiscreteValue2.Value = fecha
        myParam2.CurrentValues.Add(myDiscreteValue2)
        ' Agregar tercer param
        myDiscreteValue3.Value = turno
        myParam3.CurrentValues.Add(myDiscreteValue3)


        Select Case nivdet

            Case "ctrlfibras" 'Control Visual de Fibras


                ' Añadir parametros a la colección 
                myParams.Add(myParam)
                myParams.Add(myParam2)
                myParams.Add(myParam3)

                ' Asignar la colección params para el visor de informes
                reporte.ParameterFieldInfo = myParams

                'Asigne el informe al visor de informes .
                crReportDocument = New rptM48ctrlfibras
                reporte.ReportSource = crReportDocument

                Me.Text = "M48 - Ctrl Visual de Fibras"

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
        'frmrepm48
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(450, 302)
        Me.Controls.Add(Me.reporte)
        Me.Name = "frmrepm48"
        Me.StartPosition = FormStartPosition.Manual
        Me.Text = "Reportes M48"
        Me.WindowState = FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reporte.Load

    End Sub
End Class
