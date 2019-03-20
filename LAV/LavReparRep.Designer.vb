Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LavReparRep
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
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.gbdia = New System.Windows.Forms.GroupBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.gbdia.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtdesde
        '
        Me.dtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdesde.Location = New System.Drawing.Point(77, 28)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(80, 20)
        Me.dtdesde.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(119, 164)
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
        Me.Label1.Location = New System.Drawing.Point(22, 28)
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
        Me.gbdia.Controls.Add(Me.dtdesde)
        Me.gbdia.ForeColor = Color.Black
        Me.gbdia.Location = New System.Drawing.Point(50, 57)
        Me.gbdia.Name = "gbdia"
        Me.gbdia.Size = New System.Drawing.Size(211, 101)
        Me.gbdia.TabIndex = 0
        Me.gbdia.TabStop = False
        Me.gbdia.Text = "Fechas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(22, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Hasta"
        '
        'dthasta
        '
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(77, 54)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(80, 20)
        Me.dthasta.TabIndex = 1
        '
        'LavReparRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 193)
        Me.Controls.Add(Me.gbdia)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LavReparRep"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Informe de Reparaciones"
        Me.gbdia.ResumeLayout(False)
        Me.gbdia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As MetroButton
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents gbdia As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
End Class
