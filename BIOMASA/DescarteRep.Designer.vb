Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DescarteRep
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
        Me.dtdesde = New MetroFramework.Controls.MetroDateTime()
        Me.dthasta = New MetroFramework.Controls.MetroDateTime()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.btngenerar = New MetroFramework.Controls.MetroButton()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.cbDescarte = New MetroFramework.Controls.MetroComboBox()
        Me.chkTodos = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.chkSinTriturar = New MetroFramework.Controls.MetroCheckBox()
        Me.chkTriturado = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtdesde
        '
        Me.dtdesde.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdesde.Location = New System.Drawing.Point(47, 92)
        Me.dtdesde.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(96, 25)
        Me.dtdesde.TabIndex = 2
        '
        'dthasta
        '
        Me.dthasta.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(200, 92)
        Me.dthasta.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(96, 25)
        Me.dthasta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(226, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(71, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Desde:"
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(258, 270)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 4
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseSelectable = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(73, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 19)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Tipo descarte:"
        '
        'cbDescarte
        '
        Me.cbDescarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDescarte.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbDescarte.FormattingEnabled = True
        Me.cbDescarte.ItemHeight = 19
        Me.cbDescarte.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbDescarte.Location = New System.Drawing.Point(47, 147)
        Me.cbDescarte.Name = "cbDescarte"
        Me.cbDescarte.Size = New System.Drawing.Size(249, 25)
        Me.cbDescarte.TabIndex = 49
        Me.cbDescarte.UseSelectable = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(170, 129)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(56, 15)
        Me.chkTodos.TabIndex = 51
        Me.chkTodos.Text = "Todos"
        Me.chkTodos.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.chkSinTriturar)
        Me.MetroPanel1.Controls.Add(Me.chkTriturado)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(47, 198)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(249, 29)
        Me.MetroPanel1.TabIndex = 52
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'chkSinTriturar
        '
        Me.chkSinTriturar.AutoSize = True
        Me.chkSinTriturar.Checked = True
        Me.chkSinTriturar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSinTriturar.Location = New System.Drawing.Point(145, 4)
        Me.chkSinTriturar.Name = "chkSinTriturar"
        Me.chkSinTriturar.Size = New System.Drawing.Size(78, 15)
        Me.chkSinTriturar.TabIndex = 3
        Me.chkSinTriturar.Text = "Sin triturar"
        Me.chkSinTriturar.UseSelectable = True
        '
        'chkTriturado
        '
        Me.chkTriturado.AutoSize = True
        Me.chkTriturado.Checked = True
        Me.chkTriturado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTriturado.Location = New System.Drawing.Point(26, 4)
        Me.chkTriturado.Name = "chkTriturado"
        Me.chkTriturado.Size = New System.Drawing.Size(72, 15)
        Me.chkTriturado.TabIndex = 2
        Me.chkTriturado.Text = "Triturado"
        Me.chkTriturado.UseSelectable = True
        '
        'DescarteRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 316)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbDescarte)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dthasta)
        Me.Controls.Add(Me.dtdesde)
        Me.Name = "DescarteRep"
        Me.Text = "Descartes para Biomasa"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtdesde As MetroDateTime
    Friend WithEvents dthasta As MetroDateTime
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents btngenerar As MetroButton
    Friend WithEvents Label12 As MetroLabel
    Friend WithEvents cbDescarte As MetroComboBox
    Friend WithEvents chkTodos As MetroCheckBox
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents chkSinTriturar As MetroCheckBox
    Friend WithEvents chkTriturado As MetroCheckBox
End Class
