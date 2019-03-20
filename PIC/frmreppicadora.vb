Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports CrystalDecisions.Shared

Public Class frmreppicadora
    Inherits MetroFramework.Forms.MetroForm

    'Paradas Picadora
    Dim crReportDocument4 As rptParaPicDia
    Dim crReportDocument5 As rptParaPicEquipos
    Dim crReportDocument6 As rptparamens

    'Reporte Contaduria Informe de producción
    Dim crReportDocument7 As rptInfContMad


    'Informe de tareas
    Dim crReportDocument11 As rpttareas

    'Informe de Ingreso de camiones
    Dim crReportDocument12 As rptingcam

    'Picadora objetivo vs real


    'Informe de Camiones No Conformes y Rechazados
    Dim crReportDocument14 As rptCamRech

    'Informe de Horas de Producción
    Dim crReportDocument15 As rpteficParArea


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
        myParam.ParameterFieldName = "fechaD"
        myParam2.ParameterFieldName = "fechaH"
        myParam3.ParameterFieldName = "turno"
        myParam4.ParameterFieldName = "area"

        ' Agregar primer param
        myDiscreteValue.Value = fechaant
        myParam.CurrentValues.Add(myDiscreteValue)
        ' Agregar segundo param
        myDiscreteValue2.Value = fecha
        myParam2.CurrentValues.Add(myDiscreteValue2)
        ' Agregar tercer param
        myDiscreteValue3.Value = turno
        myParam3.CurrentValues.Add(myDiscreteValue3)
        ' Agregar cuarto param
        myDiscreteValue4.Value = area
        myParam4.CurrentValues.Add(myDiscreteValue4)



        Select Case nivdet

            Case "diario" 'Paradas Picadora Diario
                'Reporte id 4

                myParam3.ParameterFieldName = "equipo"


                ' Agregar tercer param
                myDiscreteValue3.Value = equipo
                myParam3.CurrentValues.Add(myDiscreteValue3)



                ' Añadir parametros a la colección 
                myParams.Add(myParam)
                myParams.Add(myParam2)
                myParams.Add(myParam3)
                myParams.Add(myParam4)

                ' Asignar la colección params para el visor de informes
                reporte.ParameterFieldInfo = myParams

                'Asigne el informe al visor de informes .
                crReportDocument4 = New rptParaPicDia
                reporte.ReportSource = crReportDocument4

                Me.Text = "Parada Picadora Diario"

                'ordenamiento

                '  crReportDocument4.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

                '******************------------------**********************

            Case "PorEquipo" 'Paradas Picadora Por Equipos
                'Reporte id 5

                myParam3.ParameterFieldName = "equipo"

                ' Agregar primer param
                myDiscreteValue3.Value = equipo
                myParam3.CurrentValues.Add(myDiscreteValue3)

                ' Añadir parametros a la colección 
                myParams.Add(myParam)
                myParams.Add(myParam2)
                myParams.Add(myParam3)
                myParams.Add(myParam4)


                ' Asignar la colección params para el visor de informes
                reporte.ParameterFieldInfo = myParams

                'Asigne el informe al visor de informes .
                crReportDocument5 = New rptParaPicEquipos
                reporte.ReportSource = crReportDocument5

                Me.Text = "Parada Picadora Por Equipos"

                'ordenamiento

                'crReportDocument5.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

                '******************------------------**********************

            Case "ParadaMensual" 'Paradas Picadora Mensual
                'Reporte id 6

                myParam3.ParameterFieldName = "equipo"

                ' Agregar primer param
                myDiscreteValue3.Value = equipo
                myParam3.CurrentValues.Add(myDiscreteValue3)

                ' Añadir parametros a la colección 
                myParams.Add(myParam)
                myParams.Add(myParam2)
                myParams.Add(myParam3)
                myParams.Add(myParam4)


                ' Asignar la colección params para el visor de informes
                reporte.ParameterFieldInfo = myParams

                'Asigne el informe al visor de informes .
                crReportDocument6 = New rptparamens
                reporte.ReportSource = crReportDocument6

                Me.Text = "Parada Picadora Mensual"


                'crReportDocument6.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

                '******************------------------**********************

            Case "infcont" 'Informe Contaduría Producción Madera
                'Reporte id 7

                myParam3.ParameterFieldName = "usuario"

                ' Agregar primer param
                myDiscreteValue3.Value = user
                myParam3.CurrentValues.Add(myDiscreteValue3)

                ' Añadir parametros a la colección 
                myParams.Add(myParam)
                myParams.Add(myParam2)
                myParams.Add(myParam3)

                ' Asignar la colección params para el visor de informes
                reporte.ParameterFieldInfo = myParams

                'Asigne el informe al visor de informes .
                crReportDocument7 = New rptInfContMad
                reporte.ReportSource = crReportDocument7

                Me.Text = "Informe de Producción - Madera"

                'crReportDocument7.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

                '******************------------------**********************


            Case "tareas" 'Informe de tareas
                'Reporte id 11

                myParam3.ParameterFieldName = "sector"
                myParam4.ParameterFieldName = "estado"

                ' Agregar tercer param
                myDiscreteValue3.Value = sector
                myParam3.CurrentValues.Add(myDiscreteValue3)
                ' Agregar cuarto param
                myDiscreteValue4.Value = estado
                myParam4.CurrentValues.Add(myDiscreteValue4)

                ' Añadir parametros a la colección 
                myParams.Add(myParam)
                myParams.Add(myParam2)
                myParams.Add(myParam3)
                myParams.Add(myParam4)

                ' Asignar la colección params para el visor de informes
                reporte.ParameterFieldInfo = myParams

                'Asigne el informe al visor de informes .
                crReportDocument11 = New rpttareas
                reporte.ReportSource = crReportDocument11

                Me.Text = "Informe de tareas"

                'ordenamiento

                'crReportDocument11.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

                '******************------------------**********************

            Case "IngCamion" 'Informe de Ingreso de Camiones
                'Reporte id 12


                ' Añadir parametros a la colección 
                myParams.Add(myParam)
                myParams.Add(myParam2)

                ' Asignar la colección params para el visor de informes
                reporte.ParameterFieldInfo = myParams

                'Asigne el informe al visor de informes .
                crReportDocument12 = New rptingcam
                reporte.ReportSource = crReportDocument12

                Me.Text = "Informe de Ingreso de Camiones"

                'ordenamiento

                'crReportDocument12.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

                '******************------------------**********************

            Case "NcRechazados" 'Informe de Ingreso de Camiones
                'Reporte id 14


                ' Añadir parametros a la colección 
                myParams.Add(myParam)
                myParams.Add(myParam2)

                ' Asignar la colección params para el visor de informes
                reporte.ParameterFieldInfo = myParams

                'Asigne el informe al visor de informes .
                crReportDocument14 = New rptCamRech
                reporte.ReportSource = crReportDocument14

                Me.Text = "Informe de Camiones No Conformes y/o Rechazados"

                'ordenamiento

                'crReportDocument12.DataSourceConnections.Item(0).SetLogon(usersql, pass)
                reporte.Refresh()
                reporte.Show()

                '******************------------------**********************

            Case "hsprod" 'Informe de Horas de Producción vs Paradas
                'Reporte id 15


                ' Añadir parametros a la colección 
                myParams.Add(myParam)
                myParams.Add(myParam2)
                myParams.Add(myParam4)

                ' Asignar la colección params para el visor de informes
                reporte.ParameterFieldInfo = myParams

                'Asigne el informe al visor de informes .
                crReportDocument15 = New rpteficParArea
                reporte.ReportSource = crReportDocument15

                Me.Text = "Informe de Horas de Producción vs Paradas"

                'ordenamiento

                'crReportDocument12.DataSourceConnections.Item(0).SetLogon(usersql, pass)
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
        'frmreppicadora
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(450, 302)
        Me.Controls.Add(Me.reporte)
        Me.Name = "frmreppicadora"
        Me.StartPosition = FormStartPosition.Manual
        Me.Text = "Reporte Picadora"
        Me.WindowState = FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reporte.Load

    End Sub
End Class
