Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class M48rep
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
        Me.cbvar = New MetroFramework.Controls.MetroRadioButton()
        Me.cbensayos = New MetroFramework.Controls.MetroRadioButton()
        Me.cbbolsas = New MetroFramework.Controls.MetroRadioButton()
        Me.cbctrl = New MetroFramework.Controls.MetroRadioButton()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cblinea = New MetroFramework.Controls.MetroComboBox()
        Me.chklinea = New MetroFramework.Controls.MetroCheckBox()
        Me.panel1 = New MetroFramework.Controls.MetroPanel()
        Me.GroupBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbturno
        '
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(168, 228)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(69, 25)
        Me.cbturno.TabIndex = 3
        Me.cbturno.UseSelectable = True
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chktodos.Location = New System.Drawing.Point(168, 255)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(111, 15)
        Me.chktodos.TabIndex = 4
        Me.chktodos.Text = "Todos los turnos"
        Me.chktodos.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(89, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Turno:"
        '
        'dtdesde
        '
        Me.dtdesde.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdesde.Location = New System.Drawing.Point(148, 162)
        Me.dtdesde.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(89, 25)
        Me.dtdesde.TabIndex = 1
        '
        'dthasta
        '
        Me.dthasta.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(148, 197)
        Me.dthasta.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(89, 25)
        Me.dthasta.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(89, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(89, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Desde:"
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(118, 354)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 6
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbvar)
        Me.GroupBox1.Controls.Add(Me.cbensayos)
        Me.GroupBox1.Controls.Add(Me.cbbolsas)
        Me.GroupBox1.Controls.Add(Me.cbctrl)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(30, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de reporte"
        '
        'cbvar
        '
        Me.cbvar.AutoSize = True
        Me.cbvar.Location = New System.Drawing.Point(6, 39)
        Me.cbvar.Name = "cbvar"
        Me.cbvar.Size = New System.Drawing.Size(70, 15)
        Me.cbvar.TabIndex = 1
        Me.cbvar.Text = "Variables"
        Me.cbvar.UseSelectable = True
        '
        'cbensayos
        '
        Me.cbensayos.AutoSize = True
        Me.cbensayos.Location = New System.Drawing.Point(170, 39)
        Me.cbensayos.Name = "cbensayos"
        Me.cbensayos.Size = New System.Drawing.Size(65, 15)
        Me.cbensayos.TabIndex = 3
        Me.cbensayos.Text = "Ensayos"
        Me.cbensayos.UseSelectable = True
        '
        'cbbolsas
        '
        Me.cbbolsas.AutoSize = True
        Me.cbbolsas.Location = New System.Drawing.Point(170, 16)
        Me.cbbolsas.Name = "cbbolsas"
        Me.cbbolsas.Size = New System.Drawing.Size(56, 15)
        Me.cbbolsas.TabIndex = 2
        Me.cbbolsas.Text = "Bolsas"
        Me.cbbolsas.UseSelectable = True
        '
        'cbctrl
        '
        Me.cbctrl.AutoSize = True
        Me.cbctrl.Checked = True
        Me.cbctrl.Location = New System.Drawing.Point(6, 16)
        Me.cbctrl.Name = "cbctrl"
        Me.cbctrl.Size = New System.Drawing.Size(126, 15)
        Me.cbctrl.TabIndex = 0
        Me.cbctrl.TabStop = True
        Me.cbctrl.Text = "Ctrl Visual de Fibras"
        Me.cbctrl.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 9)
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
        Me.cblinea.Location = New System.Drawing.Point(89, 3)
        Me.cblinea.Name = "cblinea"
        Me.cblinea.Size = New System.Drawing.Size(69, 25)
        Me.cblinea.TabIndex = 0
        Me.cblinea.UseSelectable = True
        '
        'chklinea
        '
        Me.chklinea.AutoSize = True
        Me.chklinea.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chklinea.Location = New System.Drawing.Point(89, 32)
        Me.chklinea.Name = "chklinea"
        Me.chklinea.Size = New System.Drawing.Size(105, 15)
        Me.chklinea.TabIndex = 1
        Me.chklinea.Text = "Todas las líneas"
        Me.chklinea.UseSelectable = True
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.cblinea)
        Me.panel1.Controls.Add(Me.Label4)
        Me.panel1.Controls.Add(Me.chklinea)
        Me.panel1.HorizontalScrollbarBarColor = True
        Me.panel1.HorizontalScrollbarHighlightOnWheel = False
        Me.panel1.HorizontalScrollbarSize = 10
        Me.panel1.Location = New System.Drawing.Point(79, 276)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(218, 50)
        Me.panel1.TabIndex = 5
        Me.panel1.VerticalScrollbarBarColor = True
        Me.panel1.VerticalScrollbarHighlightOnWheel = False
        Me.panel1.VerticalScrollbarSize = 10
        Me.panel1.Visible = False
        '
        'M48rep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 400)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dthasta)
        Me.Controls.Add(Me.dtdesde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chktodos)
        Me.Controls.Add(Me.cbturno)
        Me.Name = "M48rep"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Reportes de M48"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents cbensayos As MetroRadioButton
    Friend WithEvents cbbolsas As MetroRadioButton
    Friend WithEvents cbctrl As MetroRadioButton
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents cblinea As MetroComboBox
    Friend WithEvents chklinea As MetroCheckBox
    Friend WithEvents panel1 As MetroPanel
    Friend WithEvents cbvar As MetroRadioButton
End Class
