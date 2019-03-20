Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NivelSilos
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
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pbsilo1 = New MetroFramework.Controls.MetroProgressBar()
        Me.cbsilo1 = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pbsilo2 = New MetroFramework.Controls.MetroProgressBar()
        Me.cbsilo2 = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pbsilo3 = New MetroFramework.Controls.MetroProgressBar()
        Me.cbsilo3 = New MetroFramework.Controls.MetroComboBox()
        Me.btncargar = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(20, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Grupo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(20, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Turno"
        '
        'cbgrupo
        '
        Me.cbgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbgrupo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbgrupo.FormattingEnabled = True
        Me.cbgrupo.ItemHeight = 19
        Me.cbgrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbgrupo.Location = New System.Drawing.Point(77, 114)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(68, 25)
        Me.cbgrupo.TabIndex = 1
        Me.cbgrupo.UseSelectable = True
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(77, 80)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(68, 25)
        Me.cbturno.TabIndex = 0
        Me.cbturno.UseSelectable = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pbsilo1)
        Me.GroupBox2.Controls.Add(Me.cbsilo1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(180, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 102)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Silo 1"
        '
        'pbsilo1
        '
        Me.pbsilo1.Location = New System.Drawing.Point(6, 63)
        Me.pbsilo1.Name = "pbsilo1"
        Me.pbsilo1.Size = New System.Drawing.Size(175, 18)
        Me.pbsilo1.TabIndex = 18
        '
        'cbsilo1
        '
        Me.cbsilo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbsilo1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbsilo1.FormattingEnabled = True
        Me.cbsilo1.ItemHeight = 19
        Me.cbsilo1.Location = New System.Drawing.Point(6, 32)
        Me.cbsilo1.Name = "cbsilo1"
        Me.cbsilo1.Size = New System.Drawing.Size(119, 25)
        Me.cbsilo1.TabIndex = 0
        Me.cbsilo1.UseSelectable = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.pbsilo2)
        Me.GroupBox3.Controls.Add(Me.cbsilo2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(180, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(187, 102)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Silo 2"
        '
        'pbsilo2
        '
        Me.pbsilo2.Location = New System.Drawing.Point(6, 63)
        Me.pbsilo2.Name = "pbsilo2"
        Me.pbsilo2.Size = New System.Drawing.Size(175, 18)
        Me.pbsilo2.TabIndex = 19
        '
        'cbsilo2
        '
        Me.cbsilo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbsilo2.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbsilo2.FormattingEnabled = True
        Me.cbsilo2.ItemHeight = 19
        Me.cbsilo2.Location = New System.Drawing.Point(6, 32)
        Me.cbsilo2.Name = "cbsilo2"
        Me.cbsilo2.Size = New System.Drawing.Size(121, 25)
        Me.cbsilo2.TabIndex = 0
        Me.cbsilo2.UseSelectable = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pbsilo3)
        Me.GroupBox4.Controls.Add(Me.cbsilo3)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(180, 258)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(187, 102)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Silo 3"
        '
        'pbsilo3
        '
        Me.pbsilo3.Location = New System.Drawing.Point(6, 63)
        Me.pbsilo3.Name = "pbsilo3"
        Me.pbsilo3.Size = New System.Drawing.Size(175, 18)
        Me.pbsilo3.TabIndex = 20
        '
        'cbsilo3
        '
        Me.cbsilo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbsilo3.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbsilo3.FormattingEnabled = True
        Me.cbsilo3.ItemHeight = 19
        Me.cbsilo3.Location = New System.Drawing.Point(6, 32)
        Me.cbsilo3.Name = "cbsilo3"
        Me.cbsilo3.Size = New System.Drawing.Size(121, 25)
        Me.cbsilo3.TabIndex = 0
        Me.cbsilo3.UseSelectable = True
        '
        'btncargar
        '
        Me.btncargar.Location = New System.Drawing.Point(225, 366)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(93, 23)
        Me.btncargar.TabIndex = 5
        Me.btncargar.Text = "Cargar Niveles"
        Me.btncargar.UseSelectable = True
        '
        'NivelSilos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 407)
        Me.Controls.Add(Me.btncargar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.cbturno)
        Me.Name = "NivelSilos"
        Me.Resizable = False
        Me.Text = "NivelSilos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btncargar As MetroButton
    Friend WithEvents cbsilo1 As MetroComboBox
    Friend WithEvents cbsilo2 As MetroComboBox
    Friend WithEvents cbsilo3 As MetroComboBox
    Friend WithEvents pbsilo1 As MetroProgressBar
    Friend WithEvents pbsilo2 As MetroProgressBar
    Friend WithEvents pbsilo3 As MetroProgressBar
End Class
