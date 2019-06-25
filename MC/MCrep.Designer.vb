Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MCrep
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
        Me.rbenstq = New MetroFramework.Controls.MetroRadioButton()
        Me.rbpreparaf = New MetroFramework.Controls.MetroRadioButton()
        Me.rbvalv = New MetroFramework.Controls.MetroRadioButton()
        Me.rbtelas = New MetroFramework.Controls.MetroRadioButton()
        Me.rblimp = New MetroFramework.Controls.MetroRadioButton()
        Me.rbensmaq = New MetroFramework.Controls.MetroRadioButton()
        Me.rbhipo = New MetroFramework.Controls.MetroRadioButton()
        Me.rbvar = New MetroFramework.Controls.MetroRadioButton()
        Me.rbparaf = New MetroFramework.Controls.MetroRadioButton()
        Me.rbcuchillas = New MetroFramework.Controls.MetroRadioButton()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cblinea = New MetroFramework.Controls.MetroComboBox()
        Me.chklinea = New MetroFramework.Controls.MetroCheckBox()
        Me.plLinea = New MetroFramework.Controls.MetroPanel()
        Me.plDH = New MetroFramework.Controls.MetroPanel()
        Me.GroupBox1.SuspendLayout()
        Me.plLinea.SuspendLayout()
        Me.plDH.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbturno
        '
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(103, 63)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(57, 25)
        Me.cbturno.TabIndex = 2
        Me.cbturno.UseSelectable = True
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chktodos.Location = New System.Drawing.Point(102, 94)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(111, 15)
        Me.chktodos.TabIndex = 3
        Me.chktodos.Text = "Todos los turnos"
        Me.chktodos.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(44, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Turno:"
        '
        'dtdesde
        '
        Me.dtdesde.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdesde.Location = New System.Drawing.Point(103, 11)
        Me.dtdesde.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(89, 25)
        Me.dtdesde.TabIndex = 0
        '
        'dthasta
        '
        Me.dthasta.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(103, 37)
        Me.dthasta.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(89, 25)
        Me.dthasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(44, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(44, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Desde:"
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(172, 393)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 3
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbenstq)
        Me.GroupBox1.Controls.Add(Me.rbpreparaf)
        Me.GroupBox1.Controls.Add(Me.rbvalv)
        Me.GroupBox1.Controls.Add(Me.rbtelas)
        Me.GroupBox1.Controls.Add(Me.rblimp)
        Me.GroupBox1.Controls.Add(Me.rbensmaq)
        Me.GroupBox1.Controls.Add(Me.rbhipo)
        Me.GroupBox1.Controls.Add(Me.rbvar)
        Me.GroupBox1.Controls.Add(Me.rbparaf)
        Me.GroupBox1.Controls.Add(Me.rbcuchillas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(45, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de reporte"
        '
        'rbenstq
        '
        Me.rbenstq.AutoSize = True
        Me.rbenstq.Location = New System.Drawing.Point(160, 39)
        Me.rbenstq.Name = "rbenstq"
        Me.rbenstq.Size = New System.Drawing.Size(121, 15)
        Me.rbenstq.TabIndex = 6
        Me.rbenstq.Text = "Ensayos en tanque"
        Me.rbenstq.UseSelectable = True
        '
        'rbpreparaf
        '
        Me.rbpreparaf.AutoSize = True
        Me.rbpreparaf.Location = New System.Drawing.Point(6, 39)
        Me.rbpreparaf.Name = "rbpreparaf"
        Me.rbpreparaf.Size = New System.Drawing.Size(148, 15)
        Me.rbpreparaf.TabIndex = 1
        Me.rbpreparaf.Text = "Preparación de Parafina"
        Me.rbpreparaf.UseSelectable = True
        '
        'rbvalv
        '
        Me.rbvalv.AutoSize = True
        Me.rbvalv.Location = New System.Drawing.Point(160, 85)
        Me.rbvalv.Name = "rbvalv"
        Me.rbvalv.Size = New System.Drawing.Size(171, 15)
        Me.rbvalv.TabIndex = 8
        Me.rbvalv.Text = "Limp. de Cañerias y válvulas"
        Me.rbvalv.UseSelectable = True
        '
        'rbtelas
        '
        Me.rbtelas.AutoSize = True
        Me.rbtelas.Location = New System.Drawing.Point(160, 108)
        Me.rbtelas.Name = "rbtelas"
        Me.rbtelas.Size = New System.Drawing.Size(108, 15)
        Me.rbtelas.TabIndex = 9
        Me.rbtelas.Text = "Cambio de telas"
        Me.rbtelas.UseSelectable = True
        '
        'rblimp
        '
        Me.rblimp.AutoSize = True
        Me.rblimp.Location = New System.Drawing.Point(160, 62)
        Me.rblimp.Name = "rblimp"
        Me.rblimp.Size = New System.Drawing.Size(123, 15)
        Me.rblimp.TabIndex = 7
        Me.rblimp.Text = "Limpieza de Vacios"
        Me.rblimp.UseSelectable = True
        '
        'rbensmaq
        '
        Me.rbensmaq.AutoSize = True
        Me.rbensmaq.Location = New System.Drawing.Point(160, 16)
        Me.rbensmaq.Name = "rbensmaq"
        Me.rbensmaq.Size = New System.Drawing.Size(131, 15)
        Me.rbensmaq.TabIndex = 5
        Me.rbensmaq.Text = "Ensayos en máquina"
        Me.rbensmaq.UseSelectable = True
        '
        'rbhipo
        '
        Me.rbhipo.AutoSize = True
        Me.rbhipo.Location = New System.Drawing.Point(6, 108)
        Me.rbhipo.Name = "rbhipo"
        Me.rbhipo.Size = New System.Drawing.Size(152, 15)
        Me.rbhipo.TabIndex = 4
        Me.rbhipo.Text = "Consumo de hipoclorito"
        Me.rbhipo.UseSelectable = True
        '
        'rbvar
        '
        Me.rbvar.AutoSize = True
        Me.rbvar.Location = New System.Drawing.Point(6, 85)
        Me.rbvar.Name = "rbvar"
        Me.rbvar.Size = New System.Drawing.Size(134, 15)
        Me.rbvar.TabIndex = 3
        Me.rbvar.Text = "Variables del proceso"
        Me.rbvar.UseSelectable = True
        '
        'rbparaf
        '
        Me.rbparaf.AutoSize = True
        Me.rbparaf.Location = New System.Drawing.Point(6, 62)
        Me.rbparaf.Name = "rbparaf"
        Me.rbparaf.Size = New System.Drawing.Size(137, 15)
        Me.rbparaf.TabIndex = 2
        Me.rbparaf.Text = "Consumo de Parafina"
        Me.rbparaf.UseSelectable = True
        '
        'rbcuchillas
        '
        Me.rbcuchillas.AutoSize = True
        Me.rbcuchillas.Checked = True
        Me.rbcuchillas.Location = New System.Drawing.Point(6, 16)
        Me.rbcuchillas.Name = "rbcuchillas"
        Me.rbcuchillas.Size = New System.Drawing.Size(132, 15)
        Me.rbcuchillas.TabIndex = 0
        Me.rbcuchillas.TabStop = True
        Me.rbcuchillas.Text = "Cambio de Cuchillas"
        Me.rbcuchillas.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(4, 11)
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
        Me.cblinea.Location = New System.Drawing.Point(63, 3)
        Me.cblinea.Name = "cblinea"
        Me.cblinea.Size = New System.Drawing.Size(58, 25)
        Me.cblinea.TabIndex = 0
        Me.cblinea.UseSelectable = True
        '
        'chklinea
        '
        Me.chklinea.AutoSize = True
        Me.chklinea.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chklinea.Location = New System.Drawing.Point(63, 30)
        Me.chklinea.Name = "chklinea"
        Me.chklinea.Size = New System.Drawing.Size(105, 15)
        Me.chklinea.TabIndex = 1
        Me.chklinea.Text = "Todas las líneas"
        Me.chklinea.UseSelectable = True
        '
        'plLinea
        '
        Me.plLinea.Controls.Add(Me.cblinea)
        Me.plLinea.Controls.Add(Me.Label4)
        Me.plLinea.Controls.Add(Me.chklinea)
        Me.plLinea.HorizontalScrollbarBarColor = True
        Me.plLinea.HorizontalScrollbarHighlightOnWheel = False
        Me.plLinea.HorizontalScrollbarSize = 10
        Me.plLinea.Location = New System.Drawing.Point(108, 337)
        Me.plLinea.Name = "plLinea"
        Me.plLinea.Size = New System.Drawing.Size(214, 50)
        Me.plLinea.TabIndex = 2
        Me.plLinea.VerticalScrollbarBarColor = True
        Me.plLinea.VerticalScrollbarHighlightOnWheel = False
        Me.plLinea.VerticalScrollbarSize = 10
        Me.plLinea.Visible = False
        '
        'plDH
        '
        Me.plDH.Controls.Add(Me.Label3)
        Me.plDH.Controls.Add(Me.Label2)
        Me.plDH.Controls.Add(Me.dthasta)
        Me.plDH.Controls.Add(Me.dtdesde)
        Me.plDH.Controls.Add(Me.Label1)
        Me.plDH.Controls.Add(Me.chktodos)
        Me.plDH.Controls.Add(Me.cbturno)
        Me.plDH.HorizontalScrollbarBarColor = True
        Me.plDH.HorizontalScrollbarHighlightOnWheel = False
        Me.plDH.HorizontalScrollbarSize = 10
        Me.plDH.Location = New System.Drawing.Point(69, 211)
        Me.plDH.Name = "plDH"
        Me.plDH.Size = New System.Drawing.Size(253, 120)
        Me.plDH.TabIndex = 1
        Me.plDH.VerticalScrollbarBarColor = True
        Me.plDH.VerticalScrollbarHighlightOnWheel = False
        Me.plDH.VerticalScrollbarSize = 10
        '
        'MCrep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(424, 434)
        Me.Controls.Add(Me.plLinea)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.plDH)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MCrep"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reportes de MC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.plLinea.ResumeLayout(False)
        Me.plLinea.PerformLayout()
        Me.plDH.ResumeLayout(False)
        Me.plDH.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents chktodos As MetroCheckBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents dtdesde As MetroDateTime
    Friend WithEvents dthasta As MetroDateTime
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbvar As MetroRadioButton
    Friend WithEvents rbparaf As MetroRadioButton
    Friend WithEvents rbcuchillas As MetroRadioButton
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents cblinea As MetroComboBox
    Friend WithEvents chklinea As MetroCheckBox
    Friend WithEvents plLinea As MetroPanel
    Friend WithEvents rblimp As MetroRadioButton
    Friend WithEvents rbensmaq As MetroRadioButton
    Friend WithEvents rbhipo As MetroRadioButton
    Friend WithEvents rbvalv As MetroRadioButton
    Friend WithEvents rbtelas As MetroRadioButton
    Friend WithEvents plDH As MetroPanel
    Friend WithEvents rbpreparaf As MetroRadioButton
    Friend WithEvents rbenstq As MetroRadioButton
    Friend WithEvents btngenerar As MetroButton
End Class
