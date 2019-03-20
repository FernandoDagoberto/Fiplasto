Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AjTrRep
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.dthasta = New MetroFramework.Controls.MetroDateTime()
        Me.rbaj = New MetroFramework.Controls.MetroRadioButton()
        Me.rbtr = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtfecha
        '
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(79, 6)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(104, 29)
        Me.dtfecha.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(105, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Generar"
        Me.Button1.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(13, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Hasta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dthasta
        '
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(79, 41)
        Me.dthasta.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(104, 29)
        Me.dthasta.TabIndex = 1
        '
        'rbaj
        '
        Me.rbaj.AutoSize = True
        Me.rbaj.Checked = True
        Me.rbaj.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbaj.Location = New System.Drawing.Point(8, 24)
        Me.rbaj.Name = "rbaj"
        Me.rbaj.Size = New System.Drawing.Size(128, 15)
        Me.rbaj.TabIndex = 0
        Me.rbaj.TabStop = True
        Me.rbaj.Text = "Ajuste de Inventario"
        Me.rbaj.UseSelectable = True
        '
        'rbtr
        '
        Me.rbtr.AutoSize = True
        Me.rbtr.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbtr.Location = New System.Drawing.Point(142, 24)
        Me.rbtr.Name = "rbtr"
        Me.rbtr.Size = New System.Drawing.Size(133, 15)
        Me.rbtr.TabIndex = 1
        Me.rbtr.Text = "Transferencia a vigas"
        Me.rbtr.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.Label6)
        Me.MetroPanel1.Controls.Add(Me.dthasta)
        Me.MetroPanel1.Controls.Add(Me.Label1)
        Me.MetroPanel1.Controls.Add(Me.dtfecha)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(25, 64)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(231, 83)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'AjTrRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 195)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.rbtr)
        Me.Controls.Add(Me.rbaj)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeBox = False
        Me.Name = "AjTrRep"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents Button1 As MetroButton
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents dthasta As MetroDateTime
    Friend WithEvents rbaj As MetroRadioButton
    Friend WithEvents rbtr As MetroRadioButton
    Friend WithEvents MetroPanel1 As MetroPanel
End Class
