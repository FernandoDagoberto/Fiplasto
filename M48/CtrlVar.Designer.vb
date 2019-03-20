Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlVar
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
        Me.txtaltura = New MetroFramework.Controls.MetroTextBox()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.txttiempo = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.txtprevap = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(212, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Grupo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(124, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Turno"
        '
        'cbgrupo
        '
        Me.cbgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgrupo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbgrupo.FormattingEnabled = True
        Me.cbgrupo.ItemHeight = 19
        Me.cbgrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbgrupo.Location = New System.Drawing.Point(197, 82)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(72, 25)
        Me.cbgrupo.TabIndex = 1
        Me.cbgrupo.UseSelectable = True
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(106, 82)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(72, 25)
        Me.cbturno.TabIndex = 0
        Me.cbturno.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(165, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Altura"
        '
        'txtaltura
        '
        '
        '
        '
        Me.txtaltura.CustomButton.Image = Nothing
        Me.txtaltura.CustomButton.Location = New System.Drawing.Point(54, 2)
        Me.txtaltura.CustomButton.Name = ""
        Me.txtaltura.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtaltura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtaltura.CustomButton.TabIndex = 1
        Me.txtaltura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtaltura.CustomButton.UseSelectable = True
        Me.txtaltura.CustomButton.Visible = False
        Me.txtaltura.Lines = New String(-1) {}
        Me.txtaltura.Location = New System.Drawing.Point(151, 132)
        Me.txtaltura.MaxLength = 32767
        Me.txtaltura.Name = "txtaltura"
        Me.txtaltura.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaltura.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtaltura.SelectedText = ""
        Me.txtaltura.SelectionLength = 0
        Me.txtaltura.SelectionStart = 0
        Me.txtaltura.ShortcutsEnabled = True
        Me.txtaltura.Size = New System.Drawing.Size(72, 20)
        Me.txtaltura.TabIndex = 2
        Me.txtaltura.UseSelectable = True
        Me.txtaltura.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtaltura.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(149, 287)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(76, 25)
        Me.btnguardar.TabIndex = 5
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'txttiempo
        '
        '
        '
        '
        Me.txttiempo.CustomButton.Image = Nothing
        Me.txttiempo.CustomButton.Location = New System.Drawing.Point(54, 2)
        Me.txttiempo.CustomButton.Name = ""
        Me.txttiempo.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txttiempo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttiempo.CustomButton.TabIndex = 1
        Me.txttiempo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttiempo.CustomButton.UseSelectable = True
        Me.txttiempo.CustomButton.Visible = False
        Me.txttiempo.Lines = New String(-1) {}
        Me.txttiempo.Location = New System.Drawing.Point(149, 186)
        Me.txttiempo.MaxLength = 32767
        Me.txttiempo.Name = "txttiempo"
        Me.txttiempo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttiempo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttiempo.SelectedText = ""
        Me.txttiempo.SelectionLength = 0
        Me.txttiempo.SelectionStart = 0
        Me.txttiempo.ShortcutsEnabled = True
        Me.txttiempo.Size = New System.Drawing.Size(72, 20)
        Me.txttiempo.TabIndex = 3
        Me.txttiempo.UseSelectable = True
        Me.txttiempo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttiempo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(46, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(330, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Tiempo de retención en precalentador (min)"
        '
        'txtprevap
        '
        '
        '
        '
        Me.txtprevap.CustomButton.Image = Nothing
        Me.txtprevap.CustomButton.Location = New System.Drawing.Point(54, 2)
        Me.txtprevap.CustomButton.Name = ""
        Me.txtprevap.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtprevap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtprevap.CustomButton.TabIndex = 1
        Me.txtprevap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtprevap.CustomButton.UseSelectable = True
        Me.txtprevap.CustomButton.Visible = False
        Me.txtprevap.Lines = New String(-1) {}
        Me.txtprevap.Location = New System.Drawing.Point(144, 247)
        Me.txtprevap.MaxLength = 32767
        Me.txtprevap.Name = "txtprevap"
        Me.txtprevap.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprevap.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtprevap.SelectedText = ""
        Me.txtprevap.SelectionLength = 0
        Me.txtprevap.SelectionStart = 0
        Me.txtprevap.ShortcutsEnabled = True
        Me.txtprevap.Size = New System.Drawing.Size(72, 20)
        Me.txtprevap.TabIndex = 4
        Me.txtprevap.UseSelectable = True
        Me.txtprevap.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtprevap.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(59, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(317, 28)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Presión de Vapor en precalentador (bar)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(227, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Mín: 3.7 Máx: 4.5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(222, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Mín: 9 Máx: 9.5"
        '
        'CtrlVar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(436, 340)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtprevap)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttiempo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtaltura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.cbturno)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CtrlVar"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Control Variables Precalentador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents txtaltura As MetroTextBox
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents txttiempo As MetroTextBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents txtprevap As MetroTextBox
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents Label7 As MetroLabel
End Class
