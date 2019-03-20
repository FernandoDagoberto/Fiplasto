Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Novedadesrep
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
        Me.cbsector = New MetroFramework.Controls.MetroComboBox()
        Me.chktodos = New MetroFramework.Controls.MetroCheckBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.dtdesde = New System.Windows.Forms.DateTimePicker()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.btngenerar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'cbsector
        '
        Me.cbsector.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbsector.FormattingEnabled = True
        Me.cbsector.ItemHeight = 19
        Me.cbsector.Location = New System.Drawing.Point(118, 123)
        Me.cbsector.Name = "cbsector"
        Me.cbsector.Size = New System.Drawing.Size(135, 25)
        Me.cbsector.TabIndex = 2
        Me.cbsector.UseSelectable = True
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chktodos.Location = New System.Drawing.Point(118, 158)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(120, 15)
        Me.chktodos.TabIndex = 3
        Me.chktodos.Text = "Todos los sectores"
        Me.chktodos.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(44, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sector:"
        '
        'dtdesde
        '
        Me.dtdesde.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdesde.Location = New System.Drawing.Point(118, 71)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(89, 22)
        Me.dtdesde.TabIndex = 0
        '
        'dthasta
        '
        Me.dthasta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(118, 97)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(89, 22)
        Me.dthasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(44, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(44, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Desde:"
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(118, 197)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 4
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseSelectable = True
        '
        'Novedadesrep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 243)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dthasta)
        Me.Controls.Add(Me.dtdesde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chktodos)
        Me.Controls.Add(Me.cbsector)
        Me.Name = "Novedadesrep"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.Text = "Reporte de Novedades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbsector As MetroComboBox
    Friend WithEvents chktodos As MetroCheckBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents dtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents btngenerar As MetroButton
End Class
