Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InfContMadRep
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
        Me.gbdia = New MetroFramework.Controls.MetroPanel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.ProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.gbdia.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtfecha
        '
        Me.dtfecha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(88, 19)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(4, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(91, 25)
        Me.dtfecha.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(107, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Generar"
        Me.Button1.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        '
        'gbdia
        '
        Me.gbdia.Controls.Add(Me.Label6)
        Me.gbdia.Controls.Add(Me.dthasta)
        Me.gbdia.Controls.Add(Me.Label1)
        Me.gbdia.Controls.Add(Me.dtfecha)
        Me.gbdia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbdia.HorizontalScrollbarBarColor = True
        Me.gbdia.HorizontalScrollbarHighlightOnWheel = False
        Me.gbdia.HorizontalScrollbarSize = 10
        Me.gbdia.Location = New System.Drawing.Point(38, 63)
        Me.gbdia.Name = "gbdia"
        Me.gbdia.Size = New System.Drawing.Size(211, 101)
        Me.gbdia.TabIndex = 0
        Me.gbdia.Text = "Diario"
        Me.gbdia.VerticalScrollbarBarColor = True
        Me.gbdia.VerticalScrollbarHighlightOnWheel = False
        Me.gbdia.VerticalScrollbarSize = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(26, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Hasta"
        '
        'dthasta
        '
        Me.dthasta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(88, 51)
        Me.dthasta.MinimumSize = New System.Drawing.Size(4, 25)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(91, 25)
        Me.dthasta.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(38, 171)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(210, 10)
        Me.ProgressBar1.TabIndex = 7
        '
        'InfContMadRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 234)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.gbdia)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InfContMadRep"
        Me.Resizable = False
        Me.Text = "Informe de producción"
        Me.gbdia.ResumeLayout(False)
        Me.gbdia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents Button1 As MetroButton
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents gbdia As MetroPanel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents dthasta As DateTimePicker
    Friend WithEvents ProgressBar1 As MetroProgressBar
End Class
