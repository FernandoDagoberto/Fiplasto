Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MadePicRep
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
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.chktodos = New MetroFramework.Controls.MetroCheckBox()
        Me.gbdia = New MetroFramework.Controls.MetroPanel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.dthasta = New MetroFramework.Controls.MetroDateTime()
        Me.gbmens = New MetroFramework.Controls.MetroPanel()
        Me.chktodosmens = New MetroFramework.Controls.MetroCheckBox()
        Me.cbturnomens = New MetroFramework.Controls.MetroComboBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.dtfechamens = New MetroFramework.Controls.MetroDateTime()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.rbdiario = New MetroFramework.Controls.MetroRadioButton()
        Me.rbmens = New MetroFramework.Controls.MetroRadioButton()
        Me.gbdia.SuspendLayout()
        Me.gbmens.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtfecha
        '
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(77, 6)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(98, 25)
        Me.dtfecha.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(194, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Generar"
        Me.Button1.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(26, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(26, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Turno"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(77, 68)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(84, 25)
        Me.cbturno.TabIndex = 2
        Me.cbturno.UseSelectable = True
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chktodos.Location = New System.Drawing.Point(77, 99)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(111, 15)
        Me.chktodos.TabIndex = 3
        Me.chktodos.Text = "Todos los turnos"
        Me.chktodos.UseSelectable = True
        '
        'gbdia
        '
        Me.gbdia.Controls.Add(Me.Label6)
        Me.gbdia.Controls.Add(Me.dthasta)
        Me.gbdia.Controls.Add(Me.chktodos)
        Me.gbdia.Controls.Add(Me.cbturno)
        Me.gbdia.Controls.Add(Me.Label2)
        Me.gbdia.Controls.Add(Me.Label1)
        Me.gbdia.Controls.Add(Me.dtfecha)
        Me.gbdia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbdia.HorizontalScrollbarBarColor = True
        Me.gbdia.HorizontalScrollbarHighlightOnWheel = False
        Me.gbdia.HorizontalScrollbarSize = 10
        Me.gbdia.Location = New System.Drawing.Point(16, 126)
        Me.gbdia.Name = "gbdia"
        Me.gbdia.Size = New System.Drawing.Size(220, 126)
        Me.gbdia.TabIndex = 2
        Me.gbdia.Text = "Diario"
        Me.gbdia.VerticalScrollbarBarColor = True
        Me.gbdia.VerticalScrollbarHighlightOnWheel = False
        Me.gbdia.VerticalScrollbarSize = 10
        Me.gbdia.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(26, 43)
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
        Me.dthasta.Location = New System.Drawing.Point(77, 37)
        Me.dthasta.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(98, 25)
        Me.dthasta.TabIndex = 1
        '
        'gbmens
        '
        Me.gbmens.Controls.Add(Me.chktodosmens)
        Me.gbmens.Controls.Add(Me.cbturnomens)
        Me.gbmens.Controls.Add(Me.Label3)
        Me.gbmens.Controls.Add(Me.Label4)
        Me.gbmens.Controls.Add(Me.dtfechamens)
        Me.gbmens.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbmens.HorizontalScrollbarBarColor = True
        Me.gbmens.HorizontalScrollbarHighlightOnWheel = False
        Me.gbmens.HorizontalScrollbarSize = 10
        Me.gbmens.Location = New System.Drawing.Point(251, 126)
        Me.gbmens.Name = "gbmens"
        Me.gbmens.Size = New System.Drawing.Size(203, 107)
        Me.gbmens.TabIndex = 3
        Me.gbmens.Text = "Mensual"
        Me.gbmens.VerticalScrollbarBarColor = True
        Me.gbmens.VerticalScrollbarHighlightOnWheel = False
        Me.gbmens.VerticalScrollbarSize = 10
        Me.gbmens.Visible = False
        '
        'chktodosmens
        '
        Me.chktodosmens.AutoSize = True
        Me.chktodosmens.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chktodosmens.Location = New System.Drawing.Point(76, 74)
        Me.chktodosmens.Name = "chktodosmens"
        Me.chktodosmens.Size = New System.Drawing.Size(111, 15)
        Me.chktodosmens.TabIndex = 2
        Me.chktodosmens.Text = "Todos los turnos"
        Me.chktodosmens.UseSelectable = True
        '
        'cbturnomens
        '
        Me.cbturnomens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturnomens.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturnomens.FormattingEnabled = True
        Me.cbturnomens.ItemHeight = 19
        Me.cbturnomens.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturnomens.Location = New System.Drawing.Point(76, 37)
        Me.cbturnomens.Name = "cbturnomens"
        Me.cbturnomens.Size = New System.Drawing.Size(90, 25)
        Me.cbturnomens.TabIndex = 1
        Me.cbturnomens.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Turno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha"
        '
        'dtfechamens
        '
        Me.dtfechamens.CustomFormat = "MM/yyyy"
        Me.dtfechamens.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfechamens.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechamens.Location = New System.Drawing.Point(76, 6)
        Me.dtfechamens.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfechamens.Name = "dtfechamens"
        Me.dtfechamens.Size = New System.Drawing.Size(90, 25)
        Me.dtfechamens.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(135, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Seleccione el tipo de reporte"
        '
        'rbdiario
        '
        Me.rbdiario.AutoSize = True
        Me.rbdiario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbdiario.Location = New System.Drawing.Point(137, 91)
        Me.rbdiario.Name = "rbdiario"
        Me.rbdiario.Size = New System.Drawing.Size(54, 15)
        Me.rbdiario.TabIndex = 0
        Me.rbdiario.TabStop = True
        Me.rbdiario.Text = "Diario"
        Me.rbdiario.UseSelectable = True
        '
        'rbmens
        '
        Me.rbmens.AutoSize = True
        Me.rbmens.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbmens.Location = New System.Drawing.Point(263, 91)
        Me.rbmens.Name = "rbmens"
        Me.rbmens.Size = New System.Drawing.Size(68, 15)
        Me.rbmens.TabIndex = 1
        Me.rbmens.TabStop = True
        Me.rbmens.Text = "Mensual"
        Me.rbmens.UseSelectable = True
        '
        'MadePicRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 297)
        Me.Controls.Add(Me.rbmens)
        Me.Controls.Add(Me.rbdiario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gbmens)
        Me.Controls.Add(Me.gbdia)
        Me.Controls.Add(Me.Button1)
        Me.Name = "MadePicRep"
        Me.Resizable = False
        Me.Text = "Madera Picada"
        Me.gbdia.ResumeLayout(False)
        Me.gbdia.PerformLayout()
        Me.gbmens.ResumeLayout(False)
        Me.gbmens.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents Button1 As MetroButton
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents chktodos As MetroCheckBox
    Friend WithEvents gbdia As MetroPanel
    Friend WithEvents gbmens As MetroPanel
    Friend WithEvents chktodosmens As MetroCheckBox
    Friend WithEvents cbturnomens As MetroComboBox
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents dtfechamens As MetroDateTime
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents rbdiario As MetroRadioButton
    Friend WithEvents rbmens As MetroRadioButton
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents dthasta As MetroDateTime
End Class
