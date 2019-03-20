Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HsProdParRep
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
        Me.lblhasta = New MetroFramework.Controls.MetroLabel()
        Me.lbldesde = New MetroFramework.Controls.MetroLabel()
        Me.dthasta = New MetroFramework.Controls.MetroDateTime()
        Me.dtdesde = New MetroFramework.Controls.MetroDateTime()
        Me.btngenerar = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.cbarea = New MetroFramework.Controls.MetroComboBox()
        Me.chktodos = New MetroFramework.Controls.MetroCheckBox()
        Me.SuspendLayout()
        '
        'lblhasta
        '
        Me.lblhasta.AutoSize = True
        Me.lblhasta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblhasta.Location = New System.Drawing.Point(28, 164)
        Me.lblhasta.Name = "lblhasta"
        Me.lblhasta.Size = New System.Drawing.Size(41, 19)
        Me.lblhasta.TabIndex = 5
        Me.lblhasta.Text = "Hasta"
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldesde.Location = New System.Drawing.Point(28, 138)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(45, 19)
        Me.lbldesde.TabIndex = 4
        Me.lbldesde.Text = "Desde"
        '
        'dthasta
        '
        Me.dthasta.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(101, 158)
        Me.dthasta.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(92, 25)
        Me.dthasta.TabIndex = 3
        '
        'dtdesde
        '
        Me.dtdesde.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdesde.Location = New System.Drawing.Point(101, 128)
        Me.dtdesde.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(92, 25)
        Me.dtdesde.TabIndex = 2
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(97, 213)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 4
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(28, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Área"
        '
        'cbarea
        '
        Me.cbarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbarea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbarea.FormattingEnabled = True
        Me.cbarea.ItemHeight = 19
        Me.cbarea.Location = New System.Drawing.Point(101, 76)
        Me.cbarea.Name = "cbarea"
        Me.cbarea.Size = New System.Drawing.Size(140, 25)
        Me.cbarea.TabIndex = 0
        Me.cbarea.UseSelectable = True
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chktodos.Location = New System.Drawing.Point(101, 107)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(103, 15)
        Me.chktodos.TabIndex = 1
        Me.chktodos.Text = "Todos las áreas"
        Me.chktodos.UseSelectable = True
        '
        'HsProdParRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 255)
        Me.Controls.Add(Me.chktodos)
        Me.Controls.Add(Me.cbarea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblhasta)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.lbldesde)
        Me.Controls.Add(Me.dthasta)
        Me.Controls.Add(Me.dtdesde)
        Me.Name = "HsProdParRep"
        Me.Resizable = False
        Me.Text = "Horas de Producción"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblhasta As MetroLabel
    Friend WithEvents lbldesde As MetroLabel
    Friend WithEvents dthasta As MetroDateTime
    Friend WithEvents dtdesde As MetroDateTime
    Friend WithEvents btngenerar As MetroButton
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents cbarea As MetroComboBox
    Friend WithEvents chktodos As MetroCheckBox
End Class
