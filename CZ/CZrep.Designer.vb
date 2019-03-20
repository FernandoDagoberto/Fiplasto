Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CZrep
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
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.chktodos = New MetroFramework.Controls.MetroCheckBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.dtdesde = New MetroFramework.Controls.MetroDateTime()
        Me.dthasta = New MetroFramework.Controls.MetroDateTime()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.btngenerar = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbCtrlDim = New MetroFramework.Controls.MetroRadioButton()
        Me.rbreparacion = New MetroFramework.Controls.MetroRadioButton()
        Me.rbespesores = New MetroFramework.Controls.MetroRadioButton()
        Me.rbdescartes = New MetroFramework.Controls.MetroRadioButton()
        Me.rbrechazos = New MetroFramework.Controls.MetroRadioButton()
        Me.rbtblpren = New MetroFramework.Controls.MetroRadioButton()
        Me.rbaceptaciones = New MetroFramework.Controls.MetroRadioButton()
        Me.rbrotulador = New MetroFramework.Controls.MetroRadioButton()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cblinea = New MetroFramework.Controls.MetroComboBox()
        Me.chklinea = New MetroFramework.Controls.MetroCheckBox()
        Me.pnllinea = New MetroFramework.Controls.MetroPanel()
        Me.pnlmotivo = New MetroFramework.Controls.MetroPanel()
        Me.cbmotivo = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.chkmotivos = New MetroFramework.Controls.MetroCheckBox()
        Me.pnlgrupo = New MetroFramework.Controls.MetroPanel()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.chkgrupo = New MetroFramework.Controls.MetroCheckBox()
        Me.pnlfecha = New MetroFramework.Controls.MetroPanel()
        Me.pnlturno = New MetroFramework.Controls.MetroPanel()
        Me.pnlespesor = New MetroFramework.Controls.MetroPanel()
        Me.cbespesor = New MetroFramework.Controls.MetroComboBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.chkespesor = New MetroFramework.Controls.MetroCheckBox()
        Me.pnlreparar = New MetroFramework.Controls.MetroPanel()
        Me.chkreparada = New MetroFramework.Controls.MetroCheckBox()
        Me.chkpreparar = New MetroFramework.Controls.MetroCheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.pnllinea.SuspendLayout()
        Me.pnlmotivo.SuspendLayout()
        Me.pnlgrupo.SuspendLayout()
        Me.pnlfecha.SuspendLayout()
        Me.pnlturno.SuspendLayout()
        Me.pnlespesor.SuspendLayout()
        Me.pnlreparar.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbturno
        '
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(16, 21)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(63, 25)
        Me.cbturno.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbturno.TabIndex = 0
        Me.cbturno.UseSelectable = True
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chktodos.Location = New System.Drawing.Point(16, 47)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(111, 15)
        Me.chktodos.Style = MetroFramework.MetroColorStyle.Brown
        Me.chktodos.TabIndex = 1
        Me.chktodos.Text = "Todos los turnos"
        Me.chktodos.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Turno:"
        '
        'dtdesde
        '
        Me.dtdesde.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdesde.Location = New System.Drawing.Point(16, 28)
        Me.dtdesde.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(89, 25)
        Me.dtdesde.Style = MetroFramework.MetroColorStyle.Brown
        Me.dtdesde.TabIndex = 0
        '
        'dthasta
        '
        Me.dthasta.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(160, 28)
        Me.dthasta.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(88, 25)
        Me.dthasta.Style = MetroFramework.MetroColorStyle.Brown
        Me.dthasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(183, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(31, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Desde:"
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(292, 412)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 8
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbCtrlDim)
        Me.GroupBox1.Controls.Add(Me.rbreparacion)
        Me.GroupBox1.Controls.Add(Me.rbespesores)
        Me.GroupBox1.Controls.Add(Me.rbdescartes)
        Me.GroupBox1.Controls.Add(Me.rbrechazos)
        Me.GroupBox1.Controls.Add(Me.rbtblpren)
        Me.GroupBox1.Controls.Add(Me.rbaceptaciones)
        Me.GroupBox1.Controls.Add(Me.rbrotulador)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de reporte"
        '
        'rbCtrlDim
        '
        Me.rbCtrlDim.AutoSize = True
        Me.rbCtrlDim.Location = New System.Drawing.Point(11, 177)
        Me.rbCtrlDim.Name = "rbCtrlDim"
        Me.rbCtrlDim.Size = New System.Drawing.Size(154, 15)
        Me.rbCtrlDim.Style = MetroFramework.MetroColorStyle.Brown
        Me.rbCtrlDim.TabIndex = 7
        Me.rbCtrlDim.Text = "Controles Dimensionales"
        Me.rbCtrlDim.UseSelectable = True
        '
        'rbreparacion
        '
        Me.rbreparacion.AutoSize = True
        Me.rbreparacion.Location = New System.Drawing.Point(11, 154)
        Me.rbreparacion.Name = "rbreparacion"
        Me.rbreparacion.Size = New System.Drawing.Size(116, 15)
        Me.rbreparacion.Style = MetroFramework.MetroColorStyle.Brown
        Me.rbreparacion.TabIndex = 6
        Me.rbreparacion.Text = "Reparación zorras"
        Me.rbreparacion.UseSelectable = True
        '
        'rbespesores
        '
        Me.rbespesores.AutoSize = True
        Me.rbespesores.Location = New System.Drawing.Point(11, 131)
        Me.rbespesores.Name = "rbespesores"
        Me.rbespesores.Size = New System.Drawing.Size(136, 15)
        Me.rbespesores.Style = MetroFramework.MetroColorStyle.Brown
        Me.rbespesores.TabIndex = 5
        Me.rbespesores.Text = "Registro de Espesores"
        Me.rbespesores.UseSelectable = True
        '
        'rbdescartes
        '
        Me.rbdescartes.AutoSize = True
        Me.rbdescartes.Location = New System.Drawing.Point(11, 108)
        Me.rbdescartes.Name = "rbdescartes"
        Me.rbdescartes.Size = New System.Drawing.Size(135, 15)
        Me.rbdescartes.Style = MetroFramework.MetroColorStyle.Brown
        Me.rbdescartes.TabIndex = 4
        Me.rbdescartes.Text = "Registro de Descartes"
        Me.rbdescartes.UseSelectable = True
        '
        'rbrechazos
        '
        Me.rbrechazos.AutoSize = True
        Me.rbrechazos.Location = New System.Drawing.Point(11, 62)
        Me.rbrechazos.Name = "rbrechazos"
        Me.rbrechazos.Size = New System.Drawing.Size(72, 15)
        Me.rbrechazos.Style = MetroFramework.MetroColorStyle.Brown
        Me.rbrechazos.TabIndex = 2
        Me.rbrechazos.Text = "Rechazos"
        Me.rbrechazos.UseSelectable = True
        '
        'rbtblpren
        '
        Me.rbtblpren.AutoSize = True
        Me.rbtblpren.Location = New System.Drawing.Point(11, 16)
        Me.rbtblpren.Name = "rbtblpren"
        Me.rbtblpren.Size = New System.Drawing.Size(121, 15)
        Me.rbtblpren.Style = MetroFramework.MetroColorStyle.Brown
        Me.rbtblpren.TabIndex = 0
        Me.rbtblpren.Text = "Tableros Cargados"
        Me.rbtblpren.UseSelectable = True
        '
        'rbaceptaciones
        '
        Me.rbaceptaciones.AutoSize = True
        Me.rbaceptaciones.Location = New System.Drawing.Point(11, 39)
        Me.rbaceptaciones.Name = "rbaceptaciones"
        Me.rbaceptaciones.Size = New System.Drawing.Size(127, 15)
        Me.rbaceptaciones.Style = MetroFramework.MetroColorStyle.Brown
        Me.rbaceptaciones.TabIndex = 1
        Me.rbaceptaciones.Text = "Tableros Aceptados"
        Me.rbaceptaciones.UseSelectable = True
        '
        'rbrotulador
        '
        Me.rbrotulador.AutoSize = True
        Me.rbrotulador.Checked = True
        Me.rbrotulador.Location = New System.Drawing.Point(11, 85)
        Me.rbrotulador.Name = "rbrotulador"
        Me.rbrotulador.Size = New System.Drawing.Size(124, 15)
        Me.rbrotulador.Style = MetroFramework.MetroColorStyle.Brown
        Me.rbrotulador.TabIndex = 3
        Me.rbrotulador.TabStop = True
        Me.rbrotulador.Text = "Reposición de tinta"
        Me.rbrotulador.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(13, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Línea:"
        '
        'cblinea
        '
        Me.cblinea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cblinea.FormattingEnabled = True
        Me.cblinea.ItemHeight = 19
        Me.cblinea.Items.AddRange(New Object() {"1", "2"})
        Me.cblinea.Location = New System.Drawing.Point(16, 27)
        Me.cblinea.Name = "cblinea"
        Me.cblinea.Size = New System.Drawing.Size(63, 25)
        Me.cblinea.Style = MetroFramework.MetroColorStyle.Brown
        Me.cblinea.TabIndex = 0
        Me.cblinea.UseSelectable = True
        '
        'chklinea
        '
        Me.chklinea.AutoSize = True
        Me.chklinea.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chklinea.Location = New System.Drawing.Point(16, 54)
        Me.chklinea.Name = "chklinea"
        Me.chklinea.Size = New System.Drawing.Size(105, 15)
        Me.chklinea.Style = MetroFramework.MetroColorStyle.Brown
        Me.chklinea.TabIndex = 1
        Me.chklinea.Text = "Todas las líneas"
        Me.chklinea.UseSelectable = True
        '
        'pnllinea
        '
        Me.pnllinea.Controls.Add(Me.cblinea)
        Me.pnllinea.Controls.Add(Me.Label4)
        Me.pnllinea.Controls.Add(Me.chklinea)
        Me.pnllinea.HorizontalScrollbarBarColor = True
        Me.pnllinea.HorizontalScrollbarHighlightOnWheel = False
        Me.pnllinea.HorizontalScrollbarSize = 10
        Me.pnllinea.Location = New System.Drawing.Point(232, 134)
        Me.pnllinea.Name = "pnllinea"
        Me.pnllinea.Size = New System.Drawing.Size(130, 81)
        Me.pnllinea.TabIndex = 2
        Me.pnllinea.VerticalScrollbarBarColor = True
        Me.pnllinea.VerticalScrollbarHighlightOnWheel = False
        Me.pnllinea.VerticalScrollbarSize = 10
        '
        'pnlmotivo
        '
        Me.pnlmotivo.Controls.Add(Me.cbmotivo)
        Me.pnlmotivo.Controls.Add(Me.Label5)
        Me.pnlmotivo.Controls.Add(Me.chkmotivos)
        Me.pnlmotivo.HorizontalScrollbarBarColor = True
        Me.pnlmotivo.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlmotivo.HorizontalScrollbarSize = 10
        Me.pnlmotivo.Location = New System.Drawing.Point(232, 324)
        Me.pnlmotivo.Name = "pnlmotivo"
        Me.pnlmotivo.Size = New System.Drawing.Size(214, 77)
        Me.pnlmotivo.TabIndex = 7
        Me.pnlmotivo.VerticalScrollbarBarColor = True
        Me.pnlmotivo.VerticalScrollbarHighlightOnWheel = False
        Me.pnlmotivo.VerticalScrollbarSize = 10
        Me.pnlmotivo.Visible = False
        '
        'cbmotivo
        '
        Me.cbmotivo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmotivo.FormattingEnabled = True
        Me.cbmotivo.ItemHeight = 19
        Me.cbmotivo.Items.AddRange(New Object() {"1", "2"})
        Me.cbmotivo.Location = New System.Drawing.Point(16, 30)
        Me.cbmotivo.Name = "cbmotivo"
        Me.cbmotivo.Size = New System.Drawing.Size(180, 25)
        Me.cbmotivo.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbmotivo.TabIndex = 0
        Me.cbmotivo.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(13, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Motivo:"
        '
        'chkmotivos
        '
        Me.chkmotivos.AutoSize = True
        Me.chkmotivos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkmotivos.Location = New System.Drawing.Point(16, 57)
        Me.chkmotivos.Name = "chkmotivos"
        Me.chkmotivos.Size = New System.Drawing.Size(119, 15)
        Me.chkmotivos.Style = MetroFramework.MetroColorStyle.Brown
        Me.chkmotivos.TabIndex = 11
        Me.chkmotivos.Text = "Todas los motivos"
        Me.chkmotivos.UseSelectable = True
        '
        'pnlgrupo
        '
        Me.pnlgrupo.Controls.Add(Me.cbgrupo)
        Me.pnlgrupo.Controls.Add(Me.Label6)
        Me.pnlgrupo.Controls.Add(Me.chkgrupo)
        Me.pnlgrupo.HorizontalScrollbarBarColor = True
        Me.pnlgrupo.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlgrupo.HorizontalScrollbarSize = 10
        Me.pnlgrupo.Location = New System.Drawing.Point(368, 221)
        Me.pnlgrupo.Name = "pnlgrupo"
        Me.pnlgrupo.Size = New System.Drawing.Size(143, 67)
        Me.pnlgrupo.TabIndex = 5
        Me.pnlgrupo.VerticalScrollbarBarColor = True
        Me.pnlgrupo.VerticalScrollbarHighlightOnWheel = False
        Me.pnlgrupo.VerticalScrollbarSize = 10
        Me.pnlgrupo.Visible = False
        '
        'cbgrupo
        '
        Me.cbgrupo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbgrupo.FormattingEnabled = True
        Me.cbgrupo.ItemHeight = 19
        Me.cbgrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbgrupo.Location = New System.Drawing.Point(16, 21)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(54, 25)
        Me.cbgrupo.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbgrupo.TabIndex = 0
        Me.cbgrupo.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(16, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Grupo:"
        '
        'chkgrupo
        '
        Me.chkgrupo.AutoSize = True
        Me.chkgrupo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkgrupo.Location = New System.Drawing.Point(16, 47)
        Me.chkgrupo.Name = "chkgrupo"
        Me.chkgrupo.Size = New System.Drawing.Size(114, 15)
        Me.chkgrupo.Style = MetroFramework.MetroColorStyle.Brown
        Me.chkgrupo.TabIndex = 1
        Me.chkgrupo.Text = "Todos los grupos"
        Me.chkgrupo.UseSelectable = True
        '
        'pnlfecha
        '
        Me.pnlfecha.Controls.Add(Me.dthasta)
        Me.pnlfecha.Controls.Add(Me.dtdesde)
        Me.pnlfecha.Controls.Add(Me.Label2)
        Me.pnlfecha.Controls.Add(Me.Label3)
        Me.pnlfecha.HorizontalScrollbarBarColor = True
        Me.pnlfecha.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlfecha.HorizontalScrollbarSize = 10
        Me.pnlfecha.Location = New System.Drawing.Point(232, 65)
        Me.pnlfecha.Name = "pnlfecha"
        Me.pnlfecha.Size = New System.Drawing.Size(279, 63)
        Me.pnlfecha.TabIndex = 1
        Me.pnlfecha.VerticalScrollbarBarColor = True
        Me.pnlfecha.VerticalScrollbarHighlightOnWheel = False
        Me.pnlfecha.VerticalScrollbarSize = 10
        '
        'pnlturno
        '
        Me.pnlturno.Controls.Add(Me.chktodos)
        Me.pnlturno.Controls.Add(Me.cbturno)
        Me.pnlturno.Controls.Add(Me.Label1)
        Me.pnlturno.HorizontalScrollbarBarColor = True
        Me.pnlturno.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlturno.HorizontalScrollbarSize = 10
        Me.pnlturno.Location = New System.Drawing.Point(232, 221)
        Me.pnlturno.Name = "pnlturno"
        Me.pnlturno.Size = New System.Drawing.Size(130, 67)
        Me.pnlturno.TabIndex = 4
        Me.pnlturno.VerticalScrollbarBarColor = True
        Me.pnlturno.VerticalScrollbarHighlightOnWheel = False
        Me.pnlturno.VerticalScrollbarSize = 10
        '
        'pnlespesor
        '
        Me.pnlespesor.Controls.Add(Me.cbespesor)
        Me.pnlespesor.Controls.Add(Me.Label7)
        Me.pnlespesor.Controls.Add(Me.chkespesor)
        Me.pnlespesor.HorizontalScrollbarBarColor = True
        Me.pnlespesor.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlespesor.HorizontalScrollbarSize = 10
        Me.pnlespesor.Location = New System.Drawing.Point(368, 134)
        Me.pnlespesor.Name = "pnlespesor"
        Me.pnlespesor.Size = New System.Drawing.Size(143, 81)
        Me.pnlespesor.TabIndex = 3
        Me.pnlespesor.VerticalScrollbarBarColor = True
        Me.pnlespesor.VerticalScrollbarHighlightOnWheel = False
        Me.pnlespesor.VerticalScrollbarSize = 10
        '
        'cbespesor
        '
        Me.cbespesor.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbespesor.FormattingEnabled = True
        Me.cbespesor.ItemHeight = 19
        Me.cbespesor.Items.AddRange(New Object() {"1", "2"})
        Me.cbespesor.Location = New System.Drawing.Point(16, 27)
        Me.cbespesor.Name = "cbespesor"
        Me.cbespesor.Size = New System.Drawing.Size(75, 25)
        Me.cbespesor.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbespesor.TabIndex = 0
        Me.cbespesor.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(13, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Espesor:"
        '
        'chkespesor
        '
        Me.chkespesor.AutoSize = True
        Me.chkespesor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkespesor.Location = New System.Drawing.Point(16, 54)
        Me.chkespesor.Name = "chkespesor"
        Me.chkespesor.Size = New System.Drawing.Size(56, 15)
        Me.chkespesor.Style = MetroFramework.MetroColorStyle.Brown
        Me.chkespesor.TabIndex = 1
        Me.chkespesor.Text = "Todos"
        Me.chkespesor.UseSelectable = True
        '
        'pnlreparar
        '
        Me.pnlreparar.Controls.Add(Me.chkreparada)
        Me.pnlreparar.Controls.Add(Me.chkpreparar)
        Me.pnlreparar.HorizontalScrollbarBarColor = True
        Me.pnlreparar.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlreparar.HorizontalScrollbarSize = 10
        Me.pnlreparar.Location = New System.Drawing.Point(232, 294)
        Me.pnlreparar.Name = "pnlreparar"
        Me.pnlreparar.Size = New System.Drawing.Size(279, 27)
        Me.pnlreparar.TabIndex = 6
        Me.pnlreparar.VerticalScrollbarBarColor = True
        Me.pnlreparar.VerticalScrollbarHighlightOnWheel = False
        Me.pnlreparar.VerticalScrollbarSize = 10
        Me.pnlreparar.Visible = False
        '
        'chkreparada
        '
        Me.chkreparada.AutoSize = True
        Me.chkreparada.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkreparada.Location = New System.Drawing.Point(136, 7)
        Me.chkreparada.Name = "chkreparada"
        Me.chkreparada.Size = New System.Drawing.Size(77, 15)
        Me.chkreparada.Style = MetroFramework.MetroColorStyle.Brown
        Me.chkreparada.TabIndex = 1
        Me.chkreparada.Text = "Reparadas"
        Me.chkreparada.UseSelectable = True
        '
        'chkpreparar
        '
        Me.chkpreparar.AutoSize = True
        Me.chkpreparar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkpreparar.Location = New System.Drawing.Point(16, 7)
        Me.chkpreparar.Name = "chkpreparar"
        Me.chkpreparar.Size = New System.Drawing.Size(89, 15)
        Me.chkpreparar.Style = MetroFramework.MetroColorStyle.Brown
        Me.chkpreparar.TabIndex = 0
        Me.chkpreparar.Text = "Para Reparar"
        Me.chkpreparar.UseSelectable = True
        '
        'CZrep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 458)
        Me.Controls.Add(Me.pnlreparar)
        Me.Controls.Add(Me.pnlespesor)
        Me.Controls.Add(Me.pnlturno)
        Me.Controls.Add(Me.pnlfecha)
        Me.Controls.Add(Me.pnlgrupo)
        Me.Controls.Add(Me.pnlmotivo)
        Me.Controls.Add(Me.pnllinea)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btngenerar)
        Me.Name = "CZrep"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Brown
        Me.Text = "Reportes de Cargador de Zorras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnllinea.ResumeLayout(False)
        Me.pnllinea.PerformLayout()
        Me.pnlmotivo.ResumeLayout(False)
        Me.pnlmotivo.PerformLayout()
        Me.pnlgrupo.ResumeLayout(False)
        Me.pnlgrupo.PerformLayout()
        Me.pnlfecha.ResumeLayout(False)
        Me.pnlfecha.PerformLayout()
        Me.pnlturno.ResumeLayout(False)
        Me.pnlturno.PerformLayout()
        Me.pnlespesor.ResumeLayout(False)
        Me.pnlespesor.PerformLayout()
        Me.pnlreparar.ResumeLayout(False)
        Me.pnlreparar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents chktodos As MetroCheckBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents dtdesde As MetroDateTime
    Friend WithEvents dthasta As MetroDateTime
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents btngenerar As MetroButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtblpren As MetroRadioButton
    Friend WithEvents rbaceptaciones As MetroRadioButton
    Friend WithEvents rbrotulador As MetroRadioButton
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents cblinea As MetroComboBox
    Friend WithEvents chklinea As MetroCheckBox
    Friend WithEvents pnllinea As MetroPanel
    Friend WithEvents rbrechazos As MetroRadioButton
    Friend WithEvents pnlmotivo As MetroPanel
    Friend WithEvents cbmotivo As MetroComboBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents chkmotivos As MetroCheckBox
    Friend WithEvents rbdescartes As MetroRadioButton
    Friend WithEvents pnlgrupo As MetroPanel
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents chkgrupo As MetroCheckBox
    Friend WithEvents pnlfecha As MetroPanel
    Friend WithEvents pnlturno As MetroPanel
    Friend WithEvents rbespesores As MetroRadioButton
    Friend WithEvents pnlespesor As MetroPanel
    Friend WithEvents cbespesor As MetroComboBox
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents chkespesor As MetroCheckBox
    Friend WithEvents rbreparacion As MetroRadioButton
    Friend WithEvents rbCtrlDim As MetroRadioButton
    Friend WithEvents pnlreparar As MetroPanel
    Friend WithEvents chkreparada As MetroCheckBox
    Friend WithEvents chkpreparar As MetroCheckBox
End Class
