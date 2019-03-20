Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LAVSODArep
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
        Me.rbLimp = New MetroFramework.Controls.MetroRadioButton()
        Me.rbSoda = New MetroFramework.Controls.MetroRadioButton()
        Me.rbTemp = New MetroFramework.Controls.MetroRadioButton()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cblinea = New MetroFramework.Controls.MetroComboBox()
        Me.chklinea = New MetroFramework.Controls.MetroCheckBox()
        Me.pnllinea = New MetroFramework.Controls.MetroPanel()
        Me.pnlfecha = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1.SuspendLayout()
        Me.pnllinea.SuspendLayout()
        Me.pnlfecha.SuspendLayout()
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
        Me.btngenerar.Location = New System.Drawing.Point(337, 255)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 3
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbLimp)
        Me.GroupBox1.Controls.Add(Me.rbSoda)
        Me.GroupBox1.Controls.Add(Me.rbTemp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(23, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de reporte"
        '
        'rbLimp
        '
        Me.rbLimp.AutoSize = True
        Me.rbLimp.Location = New System.Drawing.Point(6, 62)
        Me.rbLimp.Name = "rbLimp"
        Me.rbLimp.Size = New System.Drawing.Size(120, 15)
        Me.rbLimp.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbLimp.TabIndex = 2
        Me.rbLimp.Text = "Limpieza de cubas"
        Me.rbLimp.UseSelectable = True
        '
        'rbSoda
        '
        Me.rbSoda.AutoSize = True
        Me.rbSoda.Checked = True
        Me.rbSoda.Location = New System.Drawing.Point(6, 16)
        Me.rbSoda.Name = "rbSoda"
        Me.rbSoda.Size = New System.Drawing.Size(149, 15)
        Me.rbSoda.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbSoda.TabIndex = 0
        Me.rbSoda.TabStop = True
        Me.rbSoda.Text = "Consumo soda cáustica"
        Me.rbSoda.UseSelectable = True
        '
        'rbTemp
        '
        Me.rbTemp.AutoSize = True
        Me.rbTemp.Location = New System.Drawing.Point(6, 39)
        Me.rbTemp.Name = "rbTemp"
        Me.rbTemp.Size = New System.Drawing.Size(179, 15)
        Me.rbTemp.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbTemp.TabIndex = 1
        Me.rbTemp.Text = "Temperatura y concentración"
        Me.rbTemp.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(13, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Cuba:"
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
        Me.chklinea.Size = New System.Drawing.Size(106, 15)
        Me.chklinea.Style = MetroFramework.MetroColorStyle.Orange
        Me.chklinea.TabIndex = 1
        Me.chklinea.Text = "Todas las cubas"
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
        Me.pnllinea.Location = New System.Drawing.Point(237, 168)
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
        Me.pnlfecha.Location = New System.Drawing.Point(237, 73)
        Me.pnlfecha.Name = "pnlfecha"
        Me.pnlfecha.Size = New System.Drawing.Size(279, 63)
        Me.pnlfecha.TabIndex = 1
        Me.pnlfecha.VerticalScrollbarBarColor = True
        Me.pnlfecha.VerticalScrollbarHighlightOnWheel = False
        Me.pnlfecha.VerticalScrollbarSize = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroLabel1.Location = New System.Drawing.Point(53, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(464, 25)
        Me.MetroLabel1.TabIndex = 11
        Me.MetroLabel1.Text = "Reportes - Preparación de soda cáustica y limpieza cubas"
        '
        'LAVSODArep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 311)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.pnlfecha)
        Me.Controls.Add(Me.pnllinea)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btngenerar)
        Me.DisplayHeader = False
        Me.Name = "LAVSODArep"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Reportes - Preparación de soda cáustica y limpieza cubas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnllinea.ResumeLayout(False)
        Me.pnllinea.PerformLayout()
        Me.pnlfecha.ResumeLayout(False)
        Me.pnlfecha.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents btngenerar As MetroButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbSoda As MetroRadioButton
    Friend WithEvents rbTemp As MetroRadioButton
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents cblinea As MetroComboBox
    Friend WithEvents chklinea As MetroCheckBox
    Friend WithEvents pnllinea As MetroPanel
    Friend WithEvents pnlfecha As MetroPanel
    Friend WithEvents rbLimp As MetroRadioButton
    Friend WithEvents MetroLabel1 As MetroLabel
End Class
