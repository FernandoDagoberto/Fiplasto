Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlisRep
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerar = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.FechaHasta)
        Me.GroupBox2.Controls.Add(Me.FechaDesde)
        Me.GroupBox2.Controls.Add(Me.btnGenerar)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(5, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 153)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 19)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Desde:"
        '
        'FechaHasta
        '
        Me.FechaHasta.CustomFormat = "dd/MM/yyyy"
        Me.FechaHasta.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaHasta.Location = New System.Drawing.Point(119, 53)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(85, 25)
        Me.FechaHasta.TabIndex = 1
        '
        'FechaDesde
        '
        Me.FechaDesde.CustomFormat = "dd/MM/yyyy"
        Me.FechaDesde.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaDesde.Location = New System.Drawing.Point(119, 27)
        Me.FechaDesde.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(85, 25)
        Me.FechaDesde.TabIndex = 0
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(184, 124)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(71, 23)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseSelectable = True
        '
        'AlisRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(268, 218)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "AlisRep"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Magenta
        Me.Text = "Rep Alistamiento"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents FechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGenerar As MetroButton
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label1 As MetroLabel
End Class
