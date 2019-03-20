Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pilapic
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
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.cbpila = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cmdGuardar = New MetroFramework.Controls.MetroButton()
        Me.lbllena = New System.Windows.Forms.ListBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.chkfin = New MetroFramework.Controls.MetroCheckBox()
        Me.cbmotpi = New MetroFramework.Controls.MetroComboBox()
        Me.chkajuste = New MetroFramework.Controls.MetroCheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbltn = New MetroFramework.Controls.MetroLabel()
        Me.cmdcancelar = New MetroFramework.Controls.MetroButton()
        Me.gbautoriza = New System.Windows.Forms.GroupBox()
        Me.cmdautoriza = New MetroFramework.Controls.MetroButton()
        Me.cmdrecha = New MetroFramework.Controls.MetroButton()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.txtpass = New System.Windows.Forms.MaskedTextBox()
        Me.txtusu = New MetroFramework.Controls.MetroTextBox()
        Me.lblmotaju = New MetroFramework.Controls.MetroLabel()
        Me.txtmotaju = New MetroFramework.Controls.MetroTextBox()
        Me.cbAcpl = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.gbautoriza.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(115, 103)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(71, 25)
        Me.cbturno.TabIndex = 1
        Me.cbturno.UseSelectable = True
        '
        'cbgrupo
        '
        Me.cbgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbgrupo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbgrupo.FormattingEnabled = True
        Me.cbgrupo.ItemHeight = 19
        Me.cbgrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbgrupo.Location = New System.Drawing.Point(115, 138)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(71, 25)
        Me.cbgrupo.TabIndex = 2
        Me.cbgrupo.UseSelectable = True
        '
        'cbpila
        '
        Me.cbpila.DropDownWidth = 170
        Me.cbpila.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbpila.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbpila.FormattingEnabled = True
        Me.cbpila.ItemHeight = 19
        Me.cbpila.Location = New System.Drawing.Point(115, 173)
        Me.cbpila.Name = "cbpila"
        Me.cbpila.Size = New System.Drawing.Size(132, 25)
        Me.cbpila.TabIndex = 3
        Me.cbpila.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nº Acoplado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(13, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Turno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(13, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Grupo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(13, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Pila"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(391, 378)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 6
        Me.cmdGuardar.Text = "&Guardar"
        Me.cmdGuardar.UseSelectable = True
        Me.cmdGuardar.Visible = False
        '
        'lbllena
        '
        Me.lbllena.BackColor = System.Drawing.SystemColors.Menu
        Me.lbllena.DisplayMember = "1"
        Me.lbllena.FormattingEnabled = True
        Me.lbllena.Location = New System.Drawing.Point(285, 90)
        Me.lbllena.Name = "lbllena"
        Me.lbllena.Size = New System.Drawing.Size(181, 95)
        Me.lbllena.TabIndex = 12
        Me.lbllena.ValueMember = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(13, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Motivo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(282, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Pilas habilitadas para descarga"
        '
        'chkfin
        '
        Me.chkfin.AutoSize = True
        Me.chkfin.Enabled = False
        Me.chkfin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkfin.Location = New System.Drawing.Point(189, 14)
        Me.chkfin.Name = "chkfin"
        Me.chkfin.Size = New System.Drawing.Size(77, 15)
        Me.chkfin.TabIndex = 1
        Me.chkfin.Text = "Fin de pila"
        Me.chkfin.UseSelectable = True
        '
        'cbmotpi
        '
        Me.cbmotpi.Enabled = False
        Me.cbmotpi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmotpi.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmotpi.FormattingEnabled = True
        Me.cbmotpi.ItemHeight = 19
        Me.cbmotpi.Location = New System.Drawing.Point(115, 208)
        Me.cbmotpi.Name = "cbmotpi"
        Me.cbmotpi.Size = New System.Drawing.Size(195, 25)
        Me.cbmotpi.TabIndex = 4
        Me.cbmotpi.UseSelectable = True
        '
        'chkajuste
        '
        Me.chkajuste.AutoSize = True
        Me.chkajuste.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkajuste.Location = New System.Drawing.Point(22, 14)
        Me.chkajuste.Name = "chkajuste"
        Me.chkajuste.Size = New System.Drawing.Size(56, 15)
        Me.chkajuste.TabIndex = 0
        Me.chkajuste.Text = "Ajuste"
        Me.chkajuste.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbltn)
        Me.GroupBox1.Controls.Add(Me.chkajuste)
        Me.GroupBox1.Controls.Add(Me.chkfin)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 239)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 38)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'lbltn
        '
        Me.lbltn.AutoSize = True
        Me.lbltn.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbltn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltn.Location = New System.Drawing.Point(84, 10)
        Me.lbltn.Name = "lbltn"
        Me.lbltn.Size = New System.Drawing.Size(0, 0)
        Me.lbltn.TabIndex = 19
        Me.lbltn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Location = New System.Drawing.Point(286, 378)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdcancelar.TabIndex = 7
        Me.cmdcancelar.Text = "&Cancelar"
        Me.cmdcancelar.UseSelectable = True
        '
        'gbautoriza
        '
        Me.gbautoriza.BackColor = System.Drawing.Color.LightSkyBlue
        Me.gbautoriza.Controls.Add(Me.cmdautoriza)
        Me.gbautoriza.Controls.Add(Me.cmdrecha)
        Me.gbautoriza.Controls.Add(Me.Label8)
        Me.gbautoriza.Controls.Add(Me.Label5)
        Me.gbautoriza.Controls.Add(Me.txtpass)
        Me.gbautoriza.Controls.Add(Me.txtusu)
        Me.gbautoriza.Location = New System.Drawing.Point(186, 115)
        Me.gbautoriza.Name = "gbautoriza"
        Me.gbautoriza.Size = New System.Drawing.Size(217, 118)
        Me.gbautoriza.TabIndex = 8
        Me.gbautoriza.TabStop = False
        Me.gbautoriza.Text = "Autorización supervisor"
        Me.gbautoriza.Visible = False
        '
        'cmdautoriza
        '
        Me.cmdautoriza.Location = New System.Drawing.Point(138, 76)
        Me.cmdautoriza.Name = "cmdautoriza"
        Me.cmdautoriza.Size = New System.Drawing.Size(58, 23)
        Me.cmdautoriza.TabIndex = 2
        Me.cmdautoriza.Text = "&Autoriza"
        Me.cmdautoriza.UseSelectable = True
        '
        'cmdrecha
        '
        Me.cmdrecha.Location = New System.Drawing.Point(64, 76)
        Me.cmdrecha.Name = "cmdrecha"
        Me.cmdrecha.Size = New System.Drawing.Size(60, 23)
        Me.cmdrecha.TabIndex = 3
        Me.cmdrecha.Text = "&Rechaza"
        Me.cmdrecha.UseSelectable = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label8.Location = New System.Drawing.Point(15, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Clave"
        Me.Label8.UseCustomBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label5.Location = New System.Drawing.Point(15, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Usuario"
        Me.Label5.UseCustomBackColor = True
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(96, 45)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(100, 20)
        Me.txtpass.TabIndex = 1
        '
        'txtusu
        '
        '
        '
        '
        Me.txtusu.CustomButton.Image = Nothing
        Me.txtusu.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtusu.CustomButton.Name = ""
        Me.txtusu.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtusu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtusu.CustomButton.TabIndex = 1
        Me.txtusu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtusu.CustomButton.UseSelectable = True
        Me.txtusu.CustomButton.Visible = False
        Me.txtusu.Lines = New String(-1) {}
        Me.txtusu.Location = New System.Drawing.Point(96, 19)
        Me.txtusu.MaxLength = 32767
        Me.txtusu.Name = "txtusu"
        Me.txtusu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusu.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtusu.SelectedText = ""
        Me.txtusu.SelectionLength = 0
        Me.txtusu.SelectionStart = 0
        Me.txtusu.ShortcutsEnabled = True
        Me.txtusu.Size = New System.Drawing.Size(100, 20)
        Me.txtusu.TabIndex = 0
        Me.txtusu.UseSelectable = True
        Me.txtusu.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtusu.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblmotaju
        '
        Me.lblmotaju.AutoSize = True
        Me.lblmotaju.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblmotaju.Location = New System.Drawing.Point(13, 293)
        Me.lblmotaju.Name = "lblmotaju"
        Me.lblmotaju.Size = New System.Drawing.Size(89, 19)
        Me.lblmotaju.TabIndex = 22
        Me.lblmotaju.Text = "Motivo Ajuste"
        Me.lblmotaju.Visible = False
        '
        'txtmotaju
        '
        '
        '
        '
        Me.txtmotaju.CustomButton.Image = Nothing
        Me.txtmotaju.CustomButton.Location = New System.Drawing.Point(290, 2)
        Me.txtmotaju.CustomButton.Name = ""
        Me.txtmotaju.CustomButton.Size = New System.Drawing.Size(63, 63)
        Me.txtmotaju.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtmotaju.CustomButton.TabIndex = 1
        Me.txtmotaju.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtmotaju.CustomButton.UseSelectable = True
        Me.txtmotaju.CustomButton.Visible = False
        Me.txtmotaju.Lines = New String(-1) {}
        Me.txtmotaju.Location = New System.Drawing.Point(115, 286)
        Me.txtmotaju.MaxLength = 32767
        Me.txtmotaju.Multiline = True
        Me.txtmotaju.Name = "txtmotaju"
        Me.txtmotaju.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmotaju.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtmotaju.SelectedText = ""
        Me.txtmotaju.SelectionLength = 0
        Me.txtmotaju.SelectionStart = 0
        Me.txtmotaju.ShortcutsEnabled = True
        Me.txtmotaju.Size = New System.Drawing.Size(356, 68)
        Me.txtmotaju.TabIndex = 5
        Me.txtmotaju.UseSelectable = True
        Me.txtmotaju.Visible = False
        Me.txtmotaju.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtmotaju.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbAcpl
        '
        Me.cbAcpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAcpl.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbAcpl.FormattingEnabled = True
        Me.cbAcpl.ItemHeight = 19
        Me.cbAcpl.Location = New System.Drawing.Point(115, 68)
        Me.cbAcpl.Name = "cbAcpl"
        Me.cbAcpl.Size = New System.Drawing.Size(132, 25)
        Me.cbAcpl.TabIndex = 0
        Me.cbAcpl.UseSelectable = True
        '
        'Pilapic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 420)
        Me.Controls.Add(Me.gbautoriza)
        Me.Controls.Add(Me.cbAcpl)
        Me.Controls.Add(Me.txtmotaju)
        Me.Controls.Add(Me.lblmotaju)
        Me.Controls.Add(Me.cmdcancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbmotpi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbllena)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbpila)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.cbturno)
        Me.Name = "Pilapic"
        Me.Resizable = False
        Me.Text = "Consumo de madera"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbautoriza.ResumeLayout(False)
        Me.gbautoriza.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents cbpila As MetroComboBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents cmdGuardar As MetroButton
    Friend WithEvents lbllena As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents chkfin As MetroCheckBox
    Friend WithEvents cbmotpi As MetroComboBox
    Friend WithEvents chkajuste As MetroCheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdcancelar As MetroButton
    Friend WithEvents lbltn As MetroLabel
    Friend WithEvents gbautoriza As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents txtpass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtusu As MetroTextBox
    Friend WithEvents cmdautoriza As MetroButton
    Friend WithEvents cmdrecha As MetroButton
    Friend WithEvents lblmotaju As MetroLabel
    Friend WithEvents txtmotaju As MetroTextBox
    Friend WithEvents cbAcpl As MetroComboBox
End Class
