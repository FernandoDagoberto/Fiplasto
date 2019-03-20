Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EfiPicRep
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
        Me.btngenerar = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.gbdia = New MetroFramework.Controls.MetroPanel()
        Me.rbobjvsreal = New MetroFramework.Controls.MetroRadioButton()
        Me.rbeficiencia = New MetroFramework.Controls.MetroRadioButton()
        Me.chktodos = New MetroFramework.Controls.MetroCheckBox()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.dthasta = New MetroFramework.Controls.MetroDateTime()
        Me.gbdia.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtfecha
        '
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(90, 53)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(90, 25)
        Me.dtfecha.TabIndex = 2
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(96, 278)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 0
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(26, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbdia
        '
        Me.gbdia.Controls.Add(Me.rbobjvsreal)
        Me.gbdia.Controls.Add(Me.rbeficiencia)
        Me.gbdia.Controls.Add(Me.chktodos)
        Me.gbdia.Controls.Add(Me.cbturno)
        Me.gbdia.Controls.Add(Me.Label2)
        Me.gbdia.Controls.Add(Me.Label6)
        Me.gbdia.Controls.Add(Me.dthasta)
        Me.gbdia.Controls.Add(Me.Label1)
        Me.gbdia.Controls.Add(Me.dtfecha)
        Me.gbdia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbdia.HorizontalScrollbarBarColor = True
        Me.gbdia.HorizontalScrollbarHighlightOnWheel = False
        Me.gbdia.HorizontalScrollbarSize = 10
        Me.gbdia.Location = New System.Drawing.Point(23, 63)
        Me.gbdia.Name = "gbdia"
        Me.gbdia.Size = New System.Drawing.Size(224, 195)
        Me.gbdia.TabIndex = 6
        Me.gbdia.Text = "Diario"
        Me.gbdia.VerticalScrollbarBarColor = True
        Me.gbdia.VerticalScrollbarHighlightOnWheel = False
        Me.gbdia.VerticalScrollbarSize = 10
        '
        'rbobjvsreal
        '
        Me.rbobjvsreal.AutoSize = True
        Me.rbobjvsreal.Location = New System.Drawing.Point(102, 19)
        Me.rbobjvsreal.Name = "rbobjvsreal"
        Me.rbobjvsreal.Size = New System.Drawing.Size(107, 15)
        Me.rbobjvsreal.TabIndex = 1
        Me.rbobjvsreal.TabStop = True
        Me.rbobjvsreal.Text = "Objetivo vs Real"
        Me.rbobjvsreal.UseSelectable = True
        '
        'rbeficiencia
        '
        Me.rbeficiencia.AutoSize = True
        Me.rbeficiencia.Checked = True
        Me.rbeficiencia.Location = New System.Drawing.Point(16, 19)
        Me.rbeficiencia.Name = "rbeficiencia"
        Me.rbeficiencia.Size = New System.Drawing.Size(73, 15)
        Me.rbeficiencia.TabIndex = 0
        Me.rbeficiencia.TabStop = True
        Me.rbeficiencia.Text = "Eficiencia"
        Me.rbeficiencia.UseSelectable = True
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.Checked = True
        Me.chktodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chktodos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chktodos.Location = New System.Drawing.Point(69, 160)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(111, 15)
        Me.chktodos.TabIndex = 5
        Me.chktodos.Text = "Todos los turnos"
        Me.chktodos.UseSelectable = True
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(90, 111)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(90, 25)
        Me.cbturno.TabIndex = 4
        Me.cbturno.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(26, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Turno"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(26, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Hasta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dthasta
        '
        Me.dthasta.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(90, 82)
        Me.dthasta.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(90, 25)
        Me.dthasta.TabIndex = 3
        '
        'EfiPicRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 313)
        Me.Controls.Add(Me.gbdia)
        Me.Controls.Add(Me.btngenerar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EfiPicRep"
        Me.Resizable = False
        Me.Text = "Eficiencia Picadora"
        Me.gbdia.ResumeLayout(False)
        Me.gbdia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents btngenerar As MetroButton
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents gbdia As MetroPanel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents dthasta As MetroDateTime
    Friend WithEvents chktodos As MetroCheckBox
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents rbobjvsreal As MetroRadioButton
    Friend WithEvents rbeficiencia As MetroRadioButton
End Class
