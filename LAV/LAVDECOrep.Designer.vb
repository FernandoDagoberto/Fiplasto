Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LAVDECOrep
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
        Me.dtdesde = New System.Windows.Forms.DateTimePicker()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.btngenerar = New MetroFramework.Controls.MetroButton()
        Me.pnlfecha = New MetroFramework.Controls.MetroPanel()
        Me.pnldestino = New MetroFramework.Controls.MetroPanel()
        Me.chktodos = New MetroFramework.Controls.MetroCheckBox()
        Me.cbdeco = New MetroFramework.Controls.MetroComboBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.pnlfecha.SuspendLayout()
        Me.pnldestino.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtdesde
        '
        Me.dtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdesde.Location = New System.Drawing.Point(16, 34)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(89, 20)
        Me.dtdesde.TabIndex = 0
        '
        'dthasta
        '
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(159, 34)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(89, 20)
        Me.dthasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(181, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(36, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Desde:"
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(123, 219)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 2
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseSelectable = True
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
        Me.pnlfecha.Location = New System.Drawing.Point(23, 63)
        Me.pnlfecha.Name = "pnlfecha"
        Me.pnlfecha.Size = New System.Drawing.Size(279, 63)
        Me.pnlfecha.TabIndex = 0
        Me.pnlfecha.VerticalScrollbarBarColor = True
        Me.pnlfecha.VerticalScrollbarHighlightOnWheel = False
        Me.pnlfecha.VerticalScrollbarSize = 10
        '
        'pnldestino
        '
        Me.pnldestino.Controls.Add(Me.chktodos)
        Me.pnldestino.Controls.Add(Me.cbdeco)
        Me.pnldestino.Controls.Add(Me.Label7)
        Me.pnldestino.HorizontalScrollbarBarColor = True
        Me.pnldestino.HorizontalScrollbarHighlightOnWheel = False
        Me.pnldestino.HorizontalScrollbarSize = 10
        Me.pnldestino.Location = New System.Drawing.Point(23, 132)
        Me.pnldestino.Name = "pnldestino"
        Me.pnldestino.Size = New System.Drawing.Size(279, 81)
        Me.pnldestino.TabIndex = 1
        Me.pnldestino.VerticalScrollbarBarColor = True
        Me.pnldestino.VerticalScrollbarHighlightOnWheel = False
        Me.pnldestino.VerticalScrollbarSize = 10
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chktodos.Location = New System.Drawing.Point(111, 54)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(56, 15)
        Me.chktodos.TabIndex = 1
        Me.chktodos.Text = "Todos"
        Me.chktodos.UseSelectable = True
        '
        'cbdeco
        '
        Me.cbdeco.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbdeco.FormattingEnabled = True
        Me.cbdeco.ItemHeight = 19
        Me.cbdeco.Location = New System.Drawing.Point(17, 27)
        Me.cbdeco.Name = "cbdeco"
        Me.cbdeco.Size = New System.Drawing.Size(244, 25)
        Me.cbdeco.Style = MetroFramework.MetroColorStyle.Silver
        Me.cbdeco.TabIndex = 0
        Me.cbdeco.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(103, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Decorativo"
        '
        'LAVDECOrep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 270)
        Me.Controls.Add(Me.pnldestino)
        Me.Controls.Add(Me.pnlfecha)
        Me.Controls.Add(Me.btngenerar)
        Me.Name = "LAVDECOrep"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Reportes  - Decorativos"
        Me.pnlfecha.ResumeLayout(False)
        Me.pnlfecha.PerformLayout()
        Me.pnldestino.ResumeLayout(False)
        Me.pnldestino.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents btngenerar As MetroButton
    Friend WithEvents pnlfecha As MetroPanel
    Friend WithEvents pnldestino As MetroPanel
    Friend WithEvents cbdeco As MetroComboBox
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents chktodos As MetroCheckBox
End Class
