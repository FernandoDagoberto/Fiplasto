Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParadasPicRep
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
        Me.rbmensual = New System.Windows.Forms.RadioButton()
        Me.rbequipo = New System.Windows.Forms.RadioButton()
        Me.rbdiario = New System.Windows.Forms.RadioButton()
        Me.lblmes = New MetroFramework.Controls.MetroLabel()
        Me.dtmes = New System.Windows.Forms.DateTimePicker()
        Me.chktodos = New System.Windows.Forms.CheckBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.cbequipo = New MetroFramework.Controls.MetroComboBox()
        Me.lblhasta = New MetroFramework.Controls.MetroLabel()
        Me.lbldesde = New MetroFramework.Controls.MetroLabel()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.dtdesde = New System.Windows.Forms.DateTimePicker()
        Me.btngenerar = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.cbarea = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbmensual)
        Me.GroupBox2.Controls.Add(Me.rbequipo)
        Me.GroupBox2.Controls.Add(Me.rbdiario)
        Me.GroupBox2.Controls.Add(Me.lblmes)
        Me.GroupBox2.Controls.Add(Me.dtmes)
        Me.GroupBox2.Controls.Add(Me.chktodos)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cbequipo)
        Me.GroupBox2.Controls.Add(Me.lblhasta)
        Me.GroupBox2.Controls.Add(Me.lbldesde)
        Me.GroupBox2.Controls.Add(Me.dthasta)
        Me.GroupBox2.Controls.Add(Me.dtdesde)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 189)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'rbmensual
        '
        Me.rbmensual.AutoSize = True
        Me.rbmensual.ForeColor = Color.Black
        Me.rbmensual.Location = New System.Drawing.Point(238, 16)
        Me.rbmensual.Name = "rbmensual"
        Me.rbmensual.Size = New System.Drawing.Size(65, 17)
        Me.rbmensual.TabIndex = 2
        Me.rbmensual.Text = "Mensual"
        Me.rbmensual.UseVisualStyleBackColor = True
        '
        'rbequipo
        '
        Me.rbequipo.AutoSize = True
        Me.rbequipo.ForeColor = Color.Black
        Me.rbequipo.Location = New System.Drawing.Point(124, 16)
        Me.rbequipo.Name = "rbequipo"
        Me.rbequipo.Size = New System.Drawing.Size(81, 17)
        Me.rbequipo.TabIndex = 1
        Me.rbequipo.Text = "Por equipos"
        Me.rbequipo.UseVisualStyleBackColor = True
        '
        'rbdiario
        '
        Me.rbdiario.AutoSize = True
        Me.rbdiario.Checked = True
        Me.rbdiario.ForeColor = Color.Black
        Me.rbdiario.Location = New System.Drawing.Point(38, 16)
        Me.rbdiario.Name = "rbdiario"
        Me.rbdiario.Size = New System.Drawing.Size(52, 17)
        Me.rbdiario.TabIndex = 0
        Me.rbdiario.TabStop = True
        Me.rbdiario.Text = "Diario"
        Me.rbdiario.UseVisualStyleBackColor = True
        '
        'lblmes
        '
        Me.lblmes.AutoSize = True
        Me.lblmes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblmes.Location = New System.Drawing.Point(17, 83)
        Me.lblmes.Name = "lblmes"
        Me.lblmes.Size = New System.Drawing.Size(33, 19)
        Me.lblmes.TabIndex = 9
        Me.lblmes.Text = "Mes"
        Me.lblmes.Visible = False
        '
        'dtmes
        '
        Me.dtmes.CustomFormat = "MM/yyyy"
        Me.dtmes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmes.Location = New System.Drawing.Point(73, 77)
        Me.dtmes.Name = "dtmes"
        Me.dtmes.Size = New System.Drawing.Size(84, 20)
        Me.dtmes.TabIndex = 4
        Me.dtmes.Visible = False
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.ForeColor = Color.Black
        Me.chktodos.Location = New System.Drawing.Point(71, 148)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(112, 17)
        Me.chktodos.TabIndex = 7
        Me.chktodos.Text = "Todos los equipos"
        Me.chktodos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(17, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Equipo"
        '
        'cbequipo
        '
        Me.cbequipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbequipo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbequipo.FormattingEnabled = True
        Me.cbequipo.ItemHeight = 19
        Me.cbequipo.Location = New System.Drawing.Point(71, 110)
        Me.cbequipo.Name = "cbequipo"
        Me.cbequipo.Size = New System.Drawing.Size(209, 25)
        Me.cbequipo.TabIndex = 6
        Me.cbequipo.UseSelectable = True
        '
        'lblhasta
        '
        Me.lblhasta.AutoSize = True
        Me.lblhasta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblhasta.Location = New System.Drawing.Point(191, 53)
        Me.lblhasta.Name = "lblhasta"
        Me.lblhasta.Size = New System.Drawing.Size(41, 19)
        Me.lblhasta.TabIndex = 5
        Me.lblhasta.Text = "Hasta"
        Me.lblhasta.Visible = False
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldesde.Location = New System.Drawing.Point(17, 53)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(45, 19)
        Me.lbldesde.TabIndex = 4
        Me.lbldesde.Text = "Desde"
        '
        'dthasta
        '
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(238, 52)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(83, 20)
        Me.dthasta.TabIndex = 5
        Me.dthasta.Visible = False
        '
        'dtdesde
        '
        Me.dtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdesde.Location = New System.Drawing.Point(71, 52)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(84, 20)
        Me.dtdesde.TabIndex = 3
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(154, 282)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 2
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(81, 68)
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
        Me.cbarea.Location = New System.Drawing.Point(135, 60)
        Me.cbarea.Name = "cbarea"
        Me.cbarea.Size = New System.Drawing.Size(121, 25)
        Me.cbarea.TabIndex = 0
        Me.cbarea.UseSelectable = True
        '
        'ParadasPicRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 327)
        Me.Controls.Add(Me.cbarea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ParadasPicRep"
        Me.Text = "Reporte de Paradas de Picadora"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblmes As MetroLabel
    Friend WithEvents dtmes As System.Windows.Forms.DateTimePicker
    Friend WithEvents chktodos As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents cbequipo As MetroComboBox
    Friend WithEvents lblhasta As MetroLabel
    Friend WithEvents lbldesde As MetroLabel
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btngenerar As MetroButton
    Friend WithEvents rbmensual As System.Windows.Forms.RadioButton
    Friend WithEvents rbequipo As System.Windows.Forms.RadioButton
    Friend WithEvents rbdiario As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents cbarea As MetroComboBox
End Class
