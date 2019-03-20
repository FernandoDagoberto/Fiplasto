Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TareasRep
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
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.rbno = New MetroFramework.Controls.MetroRadioButton()
        Me.rbsi = New MetroFramework.Controls.MetroRadioButton()
        Me.rbsr = New MetroFramework.Controls.MetroRadioButton()
        Me.rball = New MetroFramework.Controls.MetroRadioButton()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.chktodos = New MetroFramework.Controls.MetroCheckBox()
        Me.cbsector = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'dtfecha
        '
        Me.dtfecha.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(90, 57)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(91, 25)
        Me.dtfecha.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Generar"
        Me.Button1.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(42, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(42, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Hasta"
        '
        'dthasta
        '
        Me.dthasta.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(90, 88)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(91, 25)
        Me.dthasta.TabIndex = 1
        '
        'rbno
        '
        Me.rbno.AutoSize = True
        Me.rbno.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbno.Location = New System.Drawing.Point(50, 199)
        Me.rbno.Name = "rbno"
        Me.rbno.Size = New System.Drawing.Size(101, 15)
        Me.rbno.TabIndex = 5
        Me.rbno.Text = "No terminadas"
        Me.rbno.UseSelectable = True
        '
        'rbsi
        '
        Me.rbsi.AutoSize = True
        Me.rbsi.Checked = True
        Me.rbsi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbsi.Location = New System.Drawing.Point(50, 176)
        Me.rbsi.Name = "rbsi"
        Me.rbsi.Size = New System.Drawing.Size(85, 15)
        Me.rbsi.TabIndex = 4
        Me.rbsi.TabStop = True
        Me.rbsi.Text = "Terminadas"
        Me.rbsi.UseSelectable = True
        '
        'rbsr
        '
        Me.rbsr.AutoSize = True
        Me.rbsr.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbsr.Location = New System.Drawing.Point(50, 222)
        Me.rbsr.Name = "rbsr"
        Me.rbsr.Size = New System.Drawing.Size(92, 15)
        Me.rbsr.TabIndex = 6
        Me.rbsr.Text = "Sin respuesta"
        Me.rbsr.UseSelectable = True
        '
        'rball
        '
        Me.rball.AutoSize = True
        Me.rball.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rball.Location = New System.Drawing.Point(50, 245)
        Me.rball.Name = "rball"
        Me.rball.Size = New System.Drawing.Size(55, 15)
        Me.rball.TabIndex = 7
        Me.rball.Text = "Todas"
        Me.rball.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(42, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Área:"
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chktodos.Location = New System.Drawing.Point(90, 150)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(102, 15)
        Me.chktodos.TabIndex = 3
        Me.chktodos.Text = "Todas las áreas"
        Me.chktodos.UseSelectable = True
        '
        'cbsector
        '
        Me.cbsector.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbsector.FormattingEnabled = True
        Me.cbsector.ItemHeight = 19
        Me.cbsector.Location = New System.Drawing.Point(90, 119)
        Me.cbsector.Name = "cbsector"
        Me.cbsector.Size = New System.Drawing.Size(121, 25)
        Me.cbsector.TabIndex = 2
        Me.cbsector.UseSelectable = True
        '
        'TareasRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 342)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbsector)
        Me.Controls.Add(Me.dthasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chktodos)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rball)
        Me.Controls.Add(Me.rbsr)
        Me.Controls.Add(Me.rbsi)
        Me.Controls.Add(Me.rbno)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TareasRep"
        Me.Resizable = False
        Me.Text = "Informe de Tareas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As MetroButton
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbno As MetroRadioButton
    Friend WithEvents rbsi As MetroRadioButton
    Friend WithEvents rbsr As MetroRadioButton
    Friend WithEvents rball As MetroRadioButton
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents chktodos As MetroCheckBox
    Friend WithEvents cbsector As MetroComboBox
End Class
