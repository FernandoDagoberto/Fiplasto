Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlSulfEns
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
        Me.txtcaudal = New MetroFramework.Controls.MetroTextBox()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cblinea = New MetroFramework.Controls.MetroComboBox()
        Me.txtconc = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(88, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Grupo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(88, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Turno"
        '
        'cbgrupo
        '
        Me.cbgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgrupo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbgrupo.FormattingEnabled = True
        Me.cbgrupo.ItemHeight = 19
        Me.cbgrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbgrupo.Location = New System.Drawing.Point(227, 116)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(76, 25)
        Me.cbgrupo.TabIndex = 1
        Me.cbgrupo.UseSelectable = True
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(227, 79)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(76, 25)
        Me.cbturno.TabIndex = 0
        Me.cbturno.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(88, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Caudal (l/min)"
        '
        'txtcaudal
        '
        '
        '
        '
        Me.txtcaudal.CustomButton.Image = Nothing
        Me.txtcaudal.CustomButton.Location = New System.Drawing.Point(52, 2)
        Me.txtcaudal.CustomButton.Name = ""
        Me.txtcaudal.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtcaudal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcaudal.CustomButton.TabIndex = 1
        Me.txtcaudal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcaudal.CustomButton.UseSelectable = True
        Me.txtcaudal.CustomButton.Visible = False
        Me.txtcaudal.Lines = New String(-1) {}
        Me.txtcaudal.Location = New System.Drawing.Point(231, 190)
        Me.txtcaudal.MaxLength = 32767
        Me.txtcaudal.Name = "txtcaudal"
        Me.txtcaudal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcaudal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcaudal.SelectedText = ""
        Me.txtcaudal.SelectionLength = 0
        Me.txtcaudal.SelectionStart = 0
        Me.txtcaudal.ShortcutsEnabled = True
        Me.txtcaudal.Size = New System.Drawing.Size(72, 22)
        Me.txtcaudal.TabIndex = 3
        Me.txtcaudal.UseSelectable = True
        Me.txtcaudal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcaudal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(182, 266)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(76, 25)
        Me.btnguardar.TabIndex = 5
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(88, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Línea"
        '
        'cblinea
        '
        Me.cblinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cblinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cblinea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cblinea.FormattingEnabled = True
        Me.cblinea.ItemHeight = 19
        Me.cblinea.Items.AddRange(New Object() {"1", "2"})
        Me.cblinea.Location = New System.Drawing.Point(227, 153)
        Me.cblinea.Name = "cblinea"
        Me.cblinea.Size = New System.Drawing.Size(76, 25)
        Me.cblinea.TabIndex = 2
        Me.cblinea.UseSelectable = True
        '
        'txtconc
        '
        '
        '
        '
        Me.txtconc.CustomButton.Image = Nothing
        Me.txtconc.CustomButton.Location = New System.Drawing.Point(52, 2)
        Me.txtconc.CustomButton.Name = ""
        Me.txtconc.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtconc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtconc.CustomButton.TabIndex = 1
        Me.txtconc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtconc.CustomButton.UseSelectable = True
        Me.txtconc.CustomButton.Visible = False
        Me.txtconc.Lines = New String(-1) {}
        Me.txtconc.Location = New System.Drawing.Point(231, 227)
        Me.txtconc.MaxLength = 32767
        Me.txtconc.Name = "txtconc"
        Me.txtconc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtconc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtconc.SelectedText = ""
        Me.txtconc.SelectionLength = 0
        Me.txtconc.SelectionStart = 0
        Me.txtconc.ShortcutsEnabled = True
        Me.txtconc.Size = New System.Drawing.Size(72, 22)
        Me.txtconc.TabIndex = 4
        Me.txtconc.UseSelectable = True
        Me.txtconc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtconc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(88, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Concentración (%)"
        '
        'Label6
        '
        Me.Label6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(309, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 28)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Mín: 2.25 Máx: 2.75"
        '
        'Label7
        '
        Me.Label7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(309, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 28)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Mín: 5 Máx: 6"
        '
        'CtrlSulfEns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 336)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtconc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cblinea)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtcaudal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.cbturno)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CtrlSulfEns"
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Ctrl Solución Sulfato Alumino - Ensayos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents txtcaudal As MetroTextBox
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents cblinea As MetroComboBox
    Friend WithEvents txtconc As MetroTextBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents Label7 As MetroLabel
End Class
