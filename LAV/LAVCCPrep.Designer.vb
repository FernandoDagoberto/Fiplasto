﻿Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LAVCCPrep
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
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.btngenerar = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSegui = New MetroFramework.Controls.MetroRadioButton()
        Me.rbIng = New MetroFramework.Controls.MetroRadioButton()
        Me.rbEgreso = New MetroFramework.Controls.MetroRadioButton()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cblinea = New MetroFramework.Controls.MetroComboBox()
        Me.chklinea = New MetroFramework.Controls.MetroCheckBox()
        Me.pnllinea = New MetroFramework.Controls.MetroPanel()
        Me.pnlfecha = New MetroFramework.Controls.MetroPanel()
        Me.pnldestino = New MetroFramework.Controls.MetroPanel()
        Me.cbrazon = New MetroFramework.Controls.MetroComboBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.chkrazon = New MetroFramework.Controls.MetroCheckBox()
        Me.BProgreso = New MetroFramework.Controls.MetroProgressBar()
        Me.GroupBox1.SuspendLayout()
        Me.pnllinea.SuspendLayout()
        Me.pnlfecha.SuspendLayout()
        Me.pnldestino.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtdesde
        '
        Me.dtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdesde.Location = New System.Drawing.Point(16, 34)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(89, 20)
        Me.dtdesde.TabIndex = 0
        '
        'dthasta
        '
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(164, 34)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(89, 20)
        Me.dthasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(183, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(31, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Desde:"
        '
        'btngenerar
        '
        Me.btngenerar.ForeColor = System.Drawing.Color.Black
        Me.btngenerar.Location = New System.Drawing.Point(335, 234)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 4
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbSegui)
        Me.GroupBox1.Controls.Add(Me.rbIng)
        Me.GroupBox1.Controls.Add(Me.rbEgreso)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(13, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de reporte"
        '
        'rbSegui
        '
        Me.rbSegui.AutoSize = True
        Me.rbSegui.Location = New System.Drawing.Point(6, 62)
        Me.rbSegui.Name = "rbSegui"
        Me.rbSegui.Size = New System.Drawing.Size(131, 15)
        Me.rbSegui.TabIndex = 2
        Me.rbSegui.Text = "Seguimiento de vida"
        Me.rbSegui.UseSelectable = True
        '
        'rbIng
        '
        Me.rbIng.AutoSize = True
        Me.rbIng.Checked = True
        Me.rbIng.Location = New System.Drawing.Point(6, 16)
        Me.rbIng.Name = "rbIng"
        Me.rbIng.Size = New System.Drawing.Size(62, 15)
        Me.rbIng.TabIndex = 0
        Me.rbIng.TabStop = True
        Me.rbIng.Text = "Ingreso"
        Me.rbIng.UseSelectable = True
        '
        'rbEgreso
        '
        Me.rbEgreso.AutoSize = True
        Me.rbEgreso.Location = New System.Drawing.Point(6, 39)
        Me.rbEgreso.Name = "rbEgreso"
        Me.rbEgreso.Size = New System.Drawing.Size(58, 15)
        Me.rbEgreso.TabIndex = 1
        Me.rbEgreso.Text = "Egreso"
        Me.rbEgreso.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(16, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Línea:"
        '
        'cblinea
        '
        Me.cblinea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cblinea.FormattingEnabled = True
        Me.cblinea.ItemHeight = 19
        Me.cblinea.Items.AddRange(New Object() {"1", "2"})
        Me.cblinea.Location = New System.Drawing.Point(16, 27)
        Me.cblinea.Name = "cblinea"
        Me.cblinea.Size = New System.Drawing.Size(87, 25)
        Me.cblinea.TabIndex = 0
        Me.cblinea.UseSelectable = True
        '
        'chklinea
        '
        Me.chklinea.AutoSize = True
        Me.chklinea.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chklinea.Location = New System.Drawing.Point(16, 54)
        Me.chklinea.Name = "chklinea"
        Me.chklinea.Size = New System.Drawing.Size(105, 15)
        Me.chklinea.TabIndex = 1
        Me.chklinea.Text = "Todas las líneas"
        Me.chklinea.UseSelectable = True
        '
        'pnllinea
        '
        Me.pnllinea.Controls.Add(Me.cblinea)
        Me.pnllinea.Controls.Add(Me.Label4)
        Me.pnllinea.Controls.Add(Me.chklinea)
        Me.pnllinea.ForeColor = System.Drawing.Color.Black
        Me.pnllinea.HorizontalScrollbarBarColor = True
        Me.pnllinea.HorizontalScrollbarHighlightOnWheel = False
        Me.pnllinea.HorizontalScrollbarSize = 10
        Me.pnllinea.Location = New System.Drawing.Point(233, 129)
        Me.pnllinea.Name = "pnllinea"
        Me.pnllinea.Size = New System.Drawing.Size(130, 81)
        Me.pnllinea.TabIndex = 2
        Me.pnllinea.VerticalScrollbarBarColor = True
        Me.pnllinea.VerticalScrollbarHighlightOnWheel = False
        Me.pnllinea.VerticalScrollbarSize = 10
        '
        'pnlfecha
        '
        Me.pnlfecha.Controls.Add(Me.dthasta)
        Me.pnlfecha.Controls.Add(Me.dtdesde)
        Me.pnlfecha.Controls.Add(Me.Label2)
        Me.pnlfecha.Controls.Add(Me.Label3)
        Me.pnlfecha.ForeColor = System.Drawing.Color.Black
        Me.pnlfecha.HorizontalScrollbarBarColor = True
        Me.pnlfecha.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlfecha.HorizontalScrollbarSize = 10
        Me.pnlfecha.Location = New System.Drawing.Point(233, 60)
        Me.pnlfecha.Name = "pnlfecha"
        Me.pnlfecha.Size = New System.Drawing.Size(279, 63)
        Me.pnlfecha.TabIndex = 1
        Me.pnlfecha.VerticalScrollbarBarColor = True
        Me.pnlfecha.VerticalScrollbarHighlightOnWheel = False
        Me.pnlfecha.VerticalScrollbarSize = 10
        '
        'pnldestino
        '
        Me.pnldestino.Controls.Add(Me.cbrazon)
        Me.pnldestino.Controls.Add(Me.Label7)
        Me.pnldestino.Controls.Add(Me.chkrazon)
        Me.pnldestino.ForeColor = System.Drawing.Color.Black
        Me.pnldestino.HorizontalScrollbarBarColor = True
        Me.pnldestino.HorizontalScrollbarHighlightOnWheel = False
        Me.pnldestino.HorizontalScrollbarSize = 10
        Me.pnldestino.Location = New System.Drawing.Point(369, 129)
        Me.pnldestino.Name = "pnldestino"
        Me.pnldestino.Size = New System.Drawing.Size(143, 81)
        Me.pnldestino.TabIndex = 3
        Me.pnldestino.VerticalScrollbarBarColor = True
        Me.pnldestino.VerticalScrollbarHighlightOnWheel = False
        Me.pnldestino.VerticalScrollbarSize = 10
        '
        'cbrazon
        '
        Me.cbrazon.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbrazon.FormattingEnabled = True
        Me.cbrazon.ItemHeight = 19
        Me.cbrazon.Items.AddRange(New Object() {"1", "2"})
        Me.cbrazon.Location = New System.Drawing.Point(16, 27)
        Me.cbrazon.Name = "cbrazon"
        Me.cbrazon.Size = New System.Drawing.Size(101, 25)
        Me.cbrazon.TabIndex = 0
        Me.cbrazon.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(16, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Razón:"
        '
        'chkrazon
        '
        Me.chkrazon.AutoSize = True
        Me.chkrazon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkrazon.Location = New System.Drawing.Point(16, 54)
        Me.chkrazon.Name = "chkrazon"
        Me.chkrazon.Size = New System.Drawing.Size(56, 15)
        Me.chkrazon.TabIndex = 1
        Me.chkrazon.Text = "Todos"
        Me.chkrazon.UseSelectable = True
        '
        'BProgreso
        '
        Me.BProgreso.Location = New System.Drawing.Point(264, 217)
        Me.BProgreso.Name = "BProgreso"
        Me.BProgreso.Size = New System.Drawing.Size(222, 11)
        Me.BProgreso.TabIndex = 5
        '
        'LAVCCPrep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 266)
        Me.Controls.Add(Me.BProgreso)
        Me.Controls.Add(Me.pnldestino)
        Me.Controls.Add(Me.pnlfecha)
        Me.Controls.Add(Me.pnllinea)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btngenerar)
        Me.Name = "LAVCCPrep"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Reportes - Cambio de CubrePlacas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnllinea.ResumeLayout(False)
        Me.pnllinea.PerformLayout()
        Me.pnlfecha.ResumeLayout(False)
        Me.pnlfecha.PerformLayout()
        Me.pnldestino.ResumeLayout(False)
        Me.pnldestino.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents btngenerar As MetroButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbIng As MetroRadioButton
    Friend WithEvents rbEgreso As MetroRadioButton
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents cblinea As MetroComboBox
    Friend WithEvents chklinea As MetroCheckBox
    Friend WithEvents pnllinea As MetroPanel
    Friend WithEvents pnlfecha As MetroPanel
    Friend WithEvents pnldestino As MetroPanel
    Friend WithEvents cbrazon As MetroComboBox
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents chkrazon As MetroCheckBox
    Friend WithEvents rbSegui As MetroRadioButton
    Friend WithEvents BProgreso As MetroProgressBar
End Class
