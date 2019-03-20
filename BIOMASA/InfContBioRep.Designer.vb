Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InfContBioRep
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
        Me.gbdia = New System.Windows.Forms.GroupBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.gbdia.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtfecha
        '
        Me.dtfecha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(77, 34)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(80, 23)
        Me.dtfecha.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 137)
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
        Me.Label1.Location = New System.Drawing.Point(26, 35)
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
        Me.gbdia.ForeColor = Color.Black
        Me.gbdia.Location = New System.Drawing.Point(27, 12)
        Me.gbdia.Name = "gbdia"
        Me.gbdia.Size = New System.Drawing.Size(211, 101)
        Me.gbdia.TabIndex = 6
        Me.gbdia.TabStop = False
        Me.gbdia.Text = "Diario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(26, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Hasta"
        '
        'dthasta
        '
        Me.dthasta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(77, 60)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(80, 23)
        Me.dthasta.TabIndex = 6
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(27, 121)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(210, 10)
        Me.ProgressBar1.TabIndex = 7
        '
        'InfContBioRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 177)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.gbdia)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InfContBioRep"
        Me.Text = "Informe de producción - Biomasa"
        Me.gbdia.ResumeLayout(False)
        Me.gbdia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As MetroButton
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents gbdia As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
