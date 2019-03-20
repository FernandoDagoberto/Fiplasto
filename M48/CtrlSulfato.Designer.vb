Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlSulfato
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
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txtbolsas = New MetroFramework.Controls.MetroTextBox()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(79, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Grupo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(79, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Turno"
        '
        'cbgrupo
        '
        Me.cbgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgrupo.FormattingEnabled = True
        Me.cbgrupo.ItemHeight = 23
        Me.cbgrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbgrupo.Location = New System.Drawing.Point(184, 96)
        Me.cbgrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(160, 29)
        Me.cbgrupo.TabIndex = 1
        Me.cbgrupo.UseSelectable = True
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 23
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(184, 64)
        Me.cbturno.Margin = New System.Windows.Forms.Padding(4)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(160, 29)
        Me.cbturno.TabIndex = 0
        Me.cbturno.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(79, 134)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Bolsas"
        '
        'txtbolsas
        '
        '
        '
        '
        Me.txtbolsas.CustomButton.Image = Nothing
        Me.txtbolsas.CustomButton.Location = New System.Drawing.Point(112, 2)
        Me.txtbolsas.CustomButton.Name = ""
        Me.txtbolsas.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtbolsas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbolsas.CustomButton.TabIndex = 1
        Me.txtbolsas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbolsas.CustomButton.UseSelectable = True
        Me.txtbolsas.CustomButton.Visible = False
        Me.txtbolsas.Lines = New String(-1) {}
        Me.txtbolsas.Location = New System.Drawing.Point(184, 128)
        Me.txtbolsas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbolsas.MaxLength = 32767
        Me.txtbolsas.Name = "txtbolsas"
        Me.txtbolsas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbolsas.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbolsas.SelectedText = ""
        Me.txtbolsas.SelectionLength = 0
        Me.txtbolsas.SelectionStart = 0
        Me.txtbolsas.ShortcutsEnabled = True
        Me.txtbolsas.Size = New System.Drawing.Size(132, 22)
        Me.txtbolsas.TabIndex = 2
        Me.txtbolsas.UseSelectable = True
        Me.txtbolsas.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbolsas.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(184, 194)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(74, 25)
        Me.btnguardar.TabIndex = 3
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'CtrlSulfato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(440, 310)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtbolsas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.cbturno)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CtrlSulfato"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Ctrl Solución Sulfato Alumino - Bolsas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents txtbolsas As MetroTextBox
    Friend WithEvents btnguardar As MetroButton
End Class
