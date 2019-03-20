Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LAVTDHrep
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
        Me.rbbaja = New MetroFramework.Controls.MetroRadioButton()
        Me.rbcam = New MetroFramework.Controls.MetroRadioButton()
        Me.rblav = New MetroFramework.Controls.MetroRadioButton()
        Me.rbSeg = New MetroFramework.Controls.MetroRadioButton()
        Me.rbnuevo = New MetroFramework.Controls.MetroRadioButton()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cblinea = New MetroFramework.Controls.MetroComboBox()
        Me.chklinea = New MetroFramework.Controls.MetroCheckBox()
        Me.pnllinea = New MetroFramework.Controls.MetroPanel()
        Me.pnlfecha = New MetroFramework.Controls.MetroPanel()
        Me.pnlrazon = New MetroFramework.Controls.MetroPanel()
        Me.cbrazon = New MetroFramework.Controls.MetroComboBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.chkrazon = New MetroFramework.Controls.MetroCheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.pnllinea.SuspendLayout()
        Me.pnlfecha.SuspendLayout()
        Me.pnlrazon.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtdesde
        '
        Me.dtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdesde.Location = New System.Drawing.Point(16, 28)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(89, 20)
        Me.dtdesde.TabIndex = 0
        '
        'dthasta
        '
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(160, 28)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(89, 20)
        Me.dthasta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(183, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(30, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Desde:"
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(388, 223)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 4
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbSegui)
        Me.GroupBox1.Controls.Add(Me.rbbaja)
        Me.GroupBox1.Controls.Add(Me.rbcam)
        Me.GroupBox1.Controls.Add(Me.rblav)
        Me.GroupBox1.Controls.Add(Me.rbSeg)
        Me.GroupBox1.Controls.Add(Me.rbnuevo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de reporte"
        '
        'rbSegui
        '
        Me.rbSegui.AutoSize = True
        Me.rbSegui.Location = New System.Drawing.Point(7, 131)
        Me.rbSegui.Name = "rbSegui"
        Me.rbSegui.Size = New System.Drawing.Size(131, 15)
        Me.rbSegui.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbSegui.TabIndex = 5
        Me.rbSegui.Text = "Seguimiento de vida"
        Me.rbSegui.UseSelectable = True
        '
        'rbbaja
        '
        Me.rbbaja.AutoSize = True
        Me.rbbaja.Location = New System.Drawing.Point(7, 108)
        Me.rbbaja.Name = "rbbaja"
        Me.rbbaja.Size = New System.Drawing.Size(45, 15)
        Me.rbbaja.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbbaja.TabIndex = 4
        Me.rbbaja.Text = "Baja"
        Me.rbbaja.UseSelectable = True
        '
        'rbcam
        '
        Me.rbcam.AutoSize = True
        Me.rbcam.Location = New System.Drawing.Point(6, 62)
        Me.rbcam.Name = "rbcam"
        Me.rbcam.Size = New System.Drawing.Size(65, 15)
        Me.rbcam.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbcam.TabIndex = 2
        Me.rbcam.Text = "Cambio"
        Me.rbcam.UseSelectable = True
        '
        'rblav
        '
        Me.rblav.AutoSize = True
        Me.rblav.Location = New System.Drawing.Point(6, 16)
        Me.rblav.Name = "rblav"
        Me.rblav.Size = New System.Drawing.Size(61, 15)
        Me.rblav.Style = MetroFramework.MetroColorStyle.Orange
        Me.rblav.TabIndex = 0
        Me.rblav.Text = "Lavado"
        Me.rblav.UseSelectable = True
        '
        'rbSeg
        '
        Me.rbSeg.AutoSize = True
        Me.rbSeg.Location = New System.Drawing.Point(6, 39)
        Me.rbSeg.Name = "rbSeg"
        Me.rbSeg.Size = New System.Drawing.Size(79, 15)
        Me.rbSeg.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbSeg.TabIndex = 1
        Me.rbSeg.Text = "Segregado"
        Me.rbSeg.UseSelectable = True
        '
        'rbnuevo
        '
        Me.rbnuevo.AutoSize = True
        Me.rbnuevo.Checked = True
        Me.rbnuevo.Location = New System.Drawing.Point(6, 85)
        Me.rbnuevo.Name = "rbnuevo"
        Me.rbnuevo.Size = New System.Drawing.Size(63, 15)
        Me.rbnuevo.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbnuevo.TabIndex = 3
        Me.rbnuevo.TabStop = True
        Me.rbnuevo.Text = "Nuevos"
        Me.rbnuevo.UseSelectable = True
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
        Me.cblinea.Size = New System.Drawing.Size(52, 25)
        Me.cblinea.Style = MetroFramework.MetroColorStyle.Orange
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
        Me.chklinea.Style = MetroFramework.MetroColorStyle.Orange
        Me.chklinea.TabIndex = 1
        Me.chklinea.Text = "Todas las líneas"
        Me.chklinea.UseSelectable = True
        '
        'pnllinea
        '
        Me.pnllinea.Controls.Add(Me.cblinea)
        Me.pnllinea.Controls.Add(Me.Label4)
        Me.pnllinea.Controls.Add(Me.chklinea)
        Me.pnllinea.HorizontalScrollbarBarColor = True
        Me.pnllinea.HorizontalScrollbarHighlightOnWheel = False
        Me.pnllinea.HorizontalScrollbarSize = 10
        Me.pnllinea.Location = New System.Drawing.Point(193, 136)
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
        Me.pnlfecha.HorizontalScrollbarBarColor = True
        Me.pnlfecha.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlfecha.HorizontalScrollbarSize = 10
        Me.pnlfecha.Location = New System.Drawing.Point(193, 67)
        Me.pnlfecha.Name = "pnlfecha"
        Me.pnlfecha.Size = New System.Drawing.Size(279, 63)
        Me.pnlfecha.TabIndex = 1
        Me.pnlfecha.VerticalScrollbarBarColor = True
        Me.pnlfecha.VerticalScrollbarHighlightOnWheel = False
        Me.pnlfecha.VerticalScrollbarSize = 10
        '
        'pnlrazon
        '
        Me.pnlrazon.Controls.Add(Me.cbrazon)
        Me.pnlrazon.Controls.Add(Me.Label7)
        Me.pnlrazon.Controls.Add(Me.chkrazon)
        Me.pnlrazon.HorizontalScrollbarBarColor = True
        Me.pnlrazon.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlrazon.HorizontalScrollbarSize = 10
        Me.pnlrazon.Location = New System.Drawing.Point(329, 136)
        Me.pnlrazon.Name = "pnlrazon"
        Me.pnlrazon.Size = New System.Drawing.Size(143, 81)
        Me.pnlrazon.TabIndex = 3
        Me.pnlrazon.VerticalScrollbarBarColor = True
        Me.pnlrazon.VerticalScrollbarHighlightOnWheel = False
        Me.pnlrazon.VerticalScrollbarSize = 10
        '
        'cbrazon
        '
        Me.cbrazon.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbrazon.FormattingEnabled = True
        Me.cbrazon.ItemHeight = 19
        Me.cbrazon.Items.AddRange(New Object() {"1", "2"})
        Me.cbrazon.Location = New System.Drawing.Point(16, 27)
        Me.cbrazon.Name = "cbrazon"
        Me.cbrazon.Size = New System.Drawing.Size(124, 25)
        Me.cbrazon.Style = MetroFramework.MetroColorStyle.Orange
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
        Me.chkrazon.Style = MetroFramework.MetroColorStyle.Orange
        Me.chkrazon.TabIndex = 1
        Me.chkrazon.Text = "Todos"
        Me.chkrazon.UseSelectable = True
        '
        'LAVTDHrep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 267)
        Me.Controls.Add(Me.pnlrazon)
        Me.Controls.Add(Me.pnlfecha)
        Me.Controls.Add(Me.pnllinea)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btngenerar)
        Me.Name = "LAVTDHrep"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Reportes - Tejidos Doble Hilado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnllinea.ResumeLayout(False)
        Me.pnllinea.PerformLayout()
        Me.pnlfecha.ResumeLayout(False)
        Me.pnlfecha.PerformLayout()
        Me.pnlrazon.ResumeLayout(False)
        Me.pnlrazon.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents btngenerar As MetroButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rblav As MetroRadioButton
    Friend WithEvents rbSeg As MetroRadioButton
    Friend WithEvents rbnuevo As MetroRadioButton
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents cblinea As MetroComboBox
    Friend WithEvents chklinea As MetroCheckBox
    Friend WithEvents pnllinea As MetroPanel
    Friend WithEvents rbcam As MetroRadioButton
    Friend WithEvents rbbaja As MetroRadioButton
    Friend WithEvents pnlfecha As MetroPanel
    Friend WithEvents pnlrazon As MetroPanel
    Friend WithEvents cbrazon As MetroComboBox
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents chkrazon As MetroCheckBox
    Friend WithEvents rbSegui As MetroRadioButton
End Class
