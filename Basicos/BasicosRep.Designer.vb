Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BasicosRep
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerar = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.gbFechas = New System.Windows.Forms.GroupBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.cbLinea = New MetroFramework.Controls.MetroComboBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.rbdiario = New MetroFramework.Controls.MetroRadioButton()
        Me.rbmens = New MetroFramework.Controls.MetroRadioButton()
        Me.pnlTipoRep = New MetroFramework.Controls.MetroPanel()
        Me.rbDetallado = New MetroFramework.Controls.MetroRadioButton()
        Me.Panel2 = New MetroFramework.Controls.MetroPanel()
        Me.rbNovedades = New MetroFramework.Controls.MetroRadioButton()
        Me.rbParadas = New MetroFramework.Controls.MetroRadioButton()
        Me.rbProducción = New MetroFramework.Controls.MetroRadioButton()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.cbOpcion = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.BarraProgreso = New MetroFramework.Controls.MetroProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbFechas.SuspendLayout()
        Me.pnlTipoRep.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(57, 12)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(80, 23)
        Me.dtpDesde.TabIndex = 0
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(279, 332)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        '
        'gbFechas
        '
        Me.gbFechas.Controls.Add(Me.Label2)
        Me.gbFechas.Controls.Add(Me.cbLinea)
        Me.gbFechas.Controls.Add(Me.Label6)
        Me.gbFechas.Controls.Add(Me.dtpHasta)
        Me.gbFechas.Controls.Add(Me.Label1)
        Me.gbFechas.Controls.Add(Me.dtpDesde)
        Me.gbFechas.ForeColor = Color.Black
        Me.gbFechas.Location = New System.Drawing.Point(240, 144)
        Me.gbFechas.Name = "gbFechas"
        Me.gbFechas.Size = New System.Drawing.Size(152, 112)
        Me.gbFechas.TabIndex = 6
        Me.gbFechas.TabStop = False
        Me.gbFechas.Text = "Fechas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Línea"
        '
        'cbLinea
        '
        Me.cbLinea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbLinea.FormattingEnabled = True
        Me.cbLinea.ItemHeight = 19
        Me.cbLinea.Items.AddRange(New Object() {"1", "2"})
        Me.cbLinea.Location = New System.Drawing.Point(57, 70)
        Me.cbLinea.Name = "cbLinea"
        Me.cbLinea.Size = New System.Drawing.Size(54, 25)
        Me.cbLinea.TabIndex = 8
        Me.cbLinea.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(6, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Hasta"
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(58, 41)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(80, 23)
        Me.dtpHasta.TabIndex = 6
        '
        'rbdiario
        '
        Me.rbdiario.AutoSize = True
        Me.rbdiario.Checked = True
        Me.rbdiario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbdiario.Location = New System.Drawing.Point(3, 3)
        Me.rbdiario.Name = "rbdiario"
        Me.rbdiario.Size = New System.Drawing.Size(54, 15)
        Me.rbdiario.TabIndex = 9
        Me.rbdiario.TabStop = True
        Me.rbdiario.Text = "Diario"
        Me.rbdiario.UseSelectable = True
        '
        'rbmens
        '
        Me.rbmens.AutoSize = True
        Me.rbmens.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbmens.Location = New System.Drawing.Point(3, 27)
        Me.rbmens.Name = "rbmens"
        Me.rbmens.Size = New System.Drawing.Size(68, 15)
        Me.rbmens.TabIndex = 10
        Me.rbmens.TabStop = True
        Me.rbmens.Text = "Mensual"
        Me.rbmens.UseSelectable = True
        '
        'pnlTipoRep
        '
        Me.pnlTipoRep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTipoRep.Controls.Add(Me.rbDetallado)
        Me.pnlTipoRep.Controls.Add(Me.rbdiario)
        Me.pnlTipoRep.Controls.Add(Me.rbmens)
        Me.pnlTipoRep.HorizontalScrollbarBarColor = True
        Me.pnlTipoRep.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlTipoRep.HorizontalScrollbarSize = 10
        Me.pnlTipoRep.Location = New System.Drawing.Point(184, 80)
        Me.pnlTipoRep.Name = "pnlTipoRep"
        Me.pnlTipoRep.Size = New System.Drawing.Size(265, 58)
        Me.pnlTipoRep.TabIndex = 11
        Me.pnlTipoRep.VerticalScrollbarBarColor = True
        Me.pnlTipoRep.VerticalScrollbarHighlightOnWheel = False
        Me.pnlTipoRep.VerticalScrollbarSize = 10
        '
        'rbDetallado
        '
        Me.rbDetallado.AutoSize = True
        Me.rbDetallado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbDetallado.Location = New System.Drawing.Point(126, 4)
        Me.rbDetallado.Name = "rbDetallado"
        Me.rbDetallado.Size = New System.Drawing.Size(73, 15)
        Me.rbDetallado.TabIndex = 11
        Me.rbDetallado.TabStop = True
        Me.rbDetallado.Text = "Detallado"
        Me.rbDetallado.UseSelectable = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.rbNovedades)
        Me.Panel2.Controls.Add(Me.rbParadas)
        Me.Panel2.Controls.Add(Me.rbProducción)
        Me.Panel2.HorizontalScrollbarBarColor = True
        Me.Panel2.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel2.HorizontalScrollbarSize = 10
        Me.Panel2.Location = New System.Drawing.Point(42, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 81)
        Me.Panel2.TabIndex = 12
        Me.Panel2.VerticalScrollbarBarColor = True
        Me.Panel2.VerticalScrollbarHighlightOnWheel = False
        Me.Panel2.VerticalScrollbarSize = 10
        '
        'rbNovedades
        '
        Me.rbNovedades.AutoSize = True
        Me.rbNovedades.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbNovedades.Location = New System.Drawing.Point(3, 49)
        Me.rbNovedades.Name = "rbNovedades"
        Me.rbNovedades.Size = New System.Drawing.Size(82, 15)
        Me.rbNovedades.TabIndex = 11
        Me.rbNovedades.TabStop = True
        Me.rbNovedades.Text = "Novedades"
        Me.rbNovedades.UseSelectable = True
        '
        'rbParadas
        '
        Me.rbParadas.AutoSize = True
        Me.rbParadas.Checked = True
        Me.rbParadas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbParadas.Location = New System.Drawing.Point(3, 3)
        Me.rbParadas.Name = "rbParadas"
        Me.rbParadas.Size = New System.Drawing.Size(64, 15)
        Me.rbParadas.TabIndex = 9
        Me.rbParadas.TabStop = True
        Me.rbParadas.Text = "Paradas"
        Me.rbParadas.UseSelectable = True
        '
        'rbProducción
        '
        Me.rbProducción.AutoSize = True
        Me.rbProducción.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbProducción.Location = New System.Drawing.Point(3, 26)
        Me.rbProducción.Name = "rbProducción"
        Me.rbProducción.Size = New System.Drawing.Size(84, 15)
        Me.rbProducción.TabIndex = 10
        Me.rbProducción.TabStop = True
        Me.rbProducción.Text = "Producción"
        Me.rbProducción.UseSelectable = True
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.cbOpcion)
        Me.gbOpciones.ForeColor = Color.Black
        Me.gbOpciones.Location = New System.Drawing.Point(197, 262)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(238, 48)
        Me.gbOpciones.TabIndex = 10
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "Paradas"
        '
        'cbOpcion
        '
        Me.cbOpcion.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbOpcion.FormattingEnabled = True
        Me.cbOpcion.ItemHeight = 19
        Me.cbOpcion.Items.AddRange(New Object() {"1", "2"})
        Me.cbOpcion.Location = New System.Drawing.Point(6, 19)
        Me.cbOpcion.Name = "cbOpcion"
        Me.cbOpcion.Size = New System.Drawing.Size(226, 25)
        Me.cbOpcion.TabIndex = 8
        Me.cbOpcion.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(227, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Seleccione el tipo de reporte"
        '
        'BarraProgreso
        '
        Me.BarraProgreso.Location = New System.Drawing.Point(197, 316)
        Me.BarraProgreso.Name = "BarraProgreso"
        Me.BarraProgreso.Size = New System.Drawing.Size(238, 10)
        Me.BarraProgreso.Step = 5
        Me.BarraProgreso.TabIndex = 14
        '
        'BasicosRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 362)
        Me.Controls.Add(Me.BarraProgreso)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlTipoRep)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gbFechas)
        Me.Controls.Add(Me.btnGenerar)
        Me.Name = "BasicosRep"
        Me.Resizable = False
        Me.Text = "Informes de Básicos"
        Me.gbFechas.ResumeLayout(False)
        Me.gbFechas.PerformLayout()
        Me.pnlTipoRep.ResumeLayout(False)
        Me.pnlTipoRep.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gbOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGenerar As MetroButton
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents gbFechas As System.Windows.Forms.GroupBox
    Friend WithEvents rbdiario As MetroRadioButton
    Friend WithEvents rbmens As MetroRadioButton
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlTipoRep As MetroPanel
    Friend WithEvents Panel2 As MetroPanel
    Friend WithEvents rbParadas As MetroRadioButton
    Friend WithEvents rbProducción As MetroRadioButton
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents cbLinea As MetroComboBox
    Friend WithEvents rbDetallado As MetroRadioButton
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents cbOpcion As MetroComboBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents BarraProgreso As MetroProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents rbNovedades As MetroRadioButton
End Class
