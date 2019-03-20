Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MaderaRep
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
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.gbdia = New System.Windows.Forms.GroupBox()
        Me.rbBiomasa = New MetroFramework.Controls.MetroRadioButton()
        Me.rbMadera = New MetroFramework.Controls.MetroRadioButton()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.dthasta = New MetroFramework.Controls.MetroDateTime()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.rbIngMadera = New MetroFramework.Controls.MetroRadioButton()
        Me.rbInfCampos = New MetroFramework.Controls.MetroRadioButton()
        Me.rbInfServicios = New MetroFramework.Controls.MetroRadioButton()
        Me.rbTerceros = New MetroFramework.Controls.MetroRadioButton()
        Me.gbProveedor = New System.Windows.Forms.GroupBox()
        Me.cbProv = New System.Windows.Forms.ComboBox()
        Me.txtProv = New MetroFramework.Controls.MetroTextBox()
        Me.chKProv = New MetroFramework.Controls.MetroCheckBox()
        Me.gbMadera = New System.Windows.Forms.GroupBox()
        Me.cbMadera = New System.Windows.Forms.ComboBox()
        Me.chkMadera = New MetroFramework.Controls.MetroCheckBox()
        Me.gbCampos = New System.Windows.Forms.GroupBox()
        Me.chkPropios = New MetroFramework.Controls.MetroCheckBox()
        Me.cbCampos = New System.Windows.Forms.ComboBox()
        Me.chkCampos = New MetroFramework.Controls.MetroCheckBox()
        Me.gbdia.SuspendLayout()
        Me.gbProveedor.SuspendLayout()
        Me.gbMadera.SuspendLayout()
        Me.gbCampos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtfecha
        '
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(77, 25)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(94, 25)
        Me.dtfecha.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Generar"
        Me.Button1.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(26, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbdia
        '
        Me.gbdia.Controls.Add(Me.rbBiomasa)
        Me.gbdia.Controls.Add(Me.rbMadera)
        Me.gbdia.Controls.Add(Me.Label6)
        Me.gbdia.Controls.Add(Me.dthasta)
        Me.gbdia.Controls.Add(Me.Label1)
        Me.gbdia.Controls.Add(Me.dtfecha)
        Me.gbdia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbdia.Location = New System.Drawing.Point(12, 129)
        Me.gbdia.Name = "gbdia"
        Me.gbdia.Size = New System.Drawing.Size(196, 178)
        Me.gbdia.TabIndex = 4
        Me.gbdia.TabStop = False
        '
        'rbBiomasa
        '
        Me.rbBiomasa.AutoSize = True
        Me.rbBiomasa.Location = New System.Drawing.Point(29, 112)
        Me.rbBiomasa.Name = "rbBiomasa"
        Me.rbBiomasa.Size = New System.Drawing.Size(68, 15)
        Me.rbBiomasa.Style = MetroFramework.MetroColorStyle.Black
        Me.rbBiomasa.TabIndex = 3
        Me.rbBiomasa.Text = "Biomasa"
        Me.rbBiomasa.UseSelectable = True
        '
        'rbMadera
        '
        Me.rbMadera.AutoSize = True
        Me.rbMadera.Checked = True
        Me.rbMadera.Location = New System.Drawing.Point(29, 89)
        Me.rbMadera.Name = "rbMadera"
        Me.rbMadera.Size = New System.Drawing.Size(63, 15)
        Me.rbMadera.Style = MetroFramework.MetroColorStyle.Black
        Me.rbMadera.TabIndex = 2
        Me.rbMadera.TabStop = True
        Me.rbMadera.Text = "Madera"
        Me.rbMadera.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(26, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Hasta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dthasta
        '
        Me.dthasta.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(77, 56)
        Me.dthasta.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(94, 25)
        Me.dthasta.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(180, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Seleccione el tipo de reporte"
        '
        'rbIngMadera
        '
        Me.rbIngMadera.AutoSize = True
        Me.rbIngMadera.Checked = True
        Me.rbIngMadera.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbIngMadera.Location = New System.Drawing.Point(116, 91)
        Me.rbIngMadera.Name = "rbIngMadera"
        Me.rbIngMadera.Size = New System.Drawing.Size(67, 15)
        Me.rbIngMadera.Style = MetroFramework.MetroColorStyle.Black
        Me.rbIngMadera.TabIndex = 0
        Me.rbIngMadera.TabStop = True
        Me.rbIngMadera.Text = "Ingresos"
        Me.rbIngMadera.UseSelectable = True
        '
        'rbInfCampos
        '
        Me.rbInfCampos.AutoSize = True
        Me.rbInfCampos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbInfCampos.Location = New System.Drawing.Point(205, 91)
        Me.rbInfCampos.Name = "rbInfCampos"
        Me.rbInfCampos.Size = New System.Drawing.Size(67, 15)
        Me.rbInfCampos.Style = MetroFramework.MetroColorStyle.Black
        Me.rbInfCampos.TabIndex = 1
        Me.rbInfCampos.Text = "Campos"
        Me.rbInfCampos.UseSelectable = True
        '
        'rbInfServicios
        '
        Me.rbInfServicios.AutoSize = True
        Me.rbInfServicios.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbInfServicios.Location = New System.Drawing.Point(284, 91)
        Me.rbInfServicios.Name = "rbInfServicios"
        Me.rbInfServicios.Size = New System.Drawing.Size(69, 15)
        Me.rbInfServicios.Style = MetroFramework.MetroColorStyle.Black
        Me.rbInfServicios.TabIndex = 2
        Me.rbInfServicios.Text = "Servicios"
        Me.rbInfServicios.UseSelectable = True
        '
        'rbTerceros
        '
        Me.rbTerceros.AutoSize = True
        Me.rbTerceros.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbTerceros.Location = New System.Drawing.Point(366, 91)
        Me.rbTerceros.Name = "rbTerceros"
        Me.rbTerceros.Size = New System.Drawing.Size(127, 15)
        Me.rbTerceros.Style = MetroFramework.MetroColorStyle.Black
        Me.rbTerceros.TabIndex = 3
        Me.rbTerceros.Text = "Madera de Terceros"
        Me.rbTerceros.UseSelectable = True
        '
        'gbProveedor
        '
        Me.gbProveedor.Controls.Add(Me.cbProv)
        Me.gbProveedor.Controls.Add(Me.txtProv)
        Me.gbProveedor.Controls.Add(Me.chKProv)
        Me.gbProveedor.Enabled = False
        Me.gbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProveedor.ForeColor = System.Drawing.Color.Black
        Me.gbProveedor.Location = New System.Drawing.Point(232, 129)
        Me.gbProveedor.Name = "gbProveedor"
        Me.gbProveedor.Size = New System.Drawing.Size(346, 48)
        Me.gbProveedor.TabIndex = 5
        Me.gbProveedor.TabStop = False
        Me.gbProveedor.Text = "Proveedor"
        '
        'cbProv
        '
        Me.cbProv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProv.FormattingEnabled = True
        Me.cbProv.ItemHeight = 15
        Me.cbProv.Location = New System.Drawing.Point(119, 15)
        Me.cbProv.Name = "cbProv"
        Me.cbProv.Size = New System.Drawing.Size(221, 23)
        Me.cbProv.TabIndex = 2
        '
        'txtProv
        '
        '
        '
        '
        Me.txtProv.CustomButton.Image = Nothing
        Me.txtProv.CustomButton.Location = New System.Drawing.Point(27, 2)
        Me.txtProv.CustomButton.Name = ""
        Me.txtProv.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtProv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtProv.CustomButton.TabIndex = 1
        Me.txtProv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtProv.CustomButton.UseSelectable = True
        Me.txtProv.CustomButton.Visible = False
        Me.txtProv.Lines = New String(-1) {}
        Me.txtProv.Location = New System.Drawing.Point(68, 16)
        Me.txtProv.MaxLength = 32767
        Me.txtProv.Name = "txtProv"
        Me.txtProv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProv.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtProv.SelectedText = ""
        Me.txtProv.SelectionLength = 0
        Me.txtProv.SelectionStart = 0
        Me.txtProv.ShortcutsEnabled = True
        Me.txtProv.Size = New System.Drawing.Size(45, 20)
        Me.txtProv.TabIndex = 1
        Me.txtProv.UseSelectable = True
        Me.txtProv.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtProv.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chKProv
        '
        Me.chKProv.AutoSize = True
        Me.chKProv.Checked = True
        Me.chKProv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chKProv.Location = New System.Drawing.Point(6, 19)
        Me.chKProv.Name = "chKProv"
        Me.chKProv.Size = New System.Drawing.Size(56, 15)
        Me.chKProv.Style = MetroFramework.MetroColorStyle.Black
        Me.chKProv.TabIndex = 0
        Me.chKProv.Text = "Todos"
        Me.chKProv.UseSelectable = True
        '
        'gbMadera
        '
        Me.gbMadera.Controls.Add(Me.cbMadera)
        Me.gbMadera.Controls.Add(Me.chkMadera)
        Me.gbMadera.Enabled = False
        Me.gbMadera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMadera.ForeColor = System.Drawing.Color.Black
        Me.gbMadera.Location = New System.Drawing.Point(232, 183)
        Me.gbMadera.Name = "gbMadera"
        Me.gbMadera.Size = New System.Drawing.Size(346, 48)
        Me.gbMadera.TabIndex = 6
        Me.gbMadera.TabStop = False
        Me.gbMadera.Text = "Madera"
        '
        'cbMadera
        '
        Me.cbMadera.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbMadera.FormattingEnabled = True
        Me.cbMadera.ItemHeight = 15
        Me.cbMadera.Location = New System.Drawing.Point(82, 15)
        Me.cbMadera.Name = "cbMadera"
        Me.cbMadera.Size = New System.Drawing.Size(258, 23)
        Me.cbMadera.TabIndex = 1
        '
        'chkMadera
        '
        Me.chkMadera.AutoSize = True
        Me.chkMadera.Checked = True
        Me.chkMadera.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMadera.Location = New System.Drawing.Point(6, 19)
        Me.chkMadera.Name = "chkMadera"
        Me.chkMadera.Size = New System.Drawing.Size(56, 15)
        Me.chkMadera.Style = MetroFramework.MetroColorStyle.Black
        Me.chkMadera.TabIndex = 0
        Me.chkMadera.Text = "Todos"
        Me.chkMadera.UseSelectable = True
        '
        'gbCampos
        '
        Me.gbCampos.Controls.Add(Me.chkPropios)
        Me.gbCampos.Controls.Add(Me.cbCampos)
        Me.gbCampos.Controls.Add(Me.chkCampos)
        Me.gbCampos.Enabled = False
        Me.gbCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCampos.ForeColor = System.Drawing.Color.Black
        Me.gbCampos.Location = New System.Drawing.Point(232, 241)
        Me.gbCampos.Name = "gbCampos"
        Me.gbCampos.Size = New System.Drawing.Size(346, 66)
        Me.gbCampos.TabIndex = 7
        Me.gbCampos.TabStop = False
        Me.gbCampos.Text = "Campos"
        '
        'chkPropios
        '
        Me.chkPropios.AutoSize = True
        Me.chkPropios.Location = New System.Drawing.Point(6, 42)
        Me.chkPropios.Name = "chkPropios"
        Me.chkPropios.Size = New System.Drawing.Size(89, 15)
        Me.chkPropios.Style = MetroFramework.MetroColorStyle.Black
        Me.chkPropios.TabIndex = 1
        Me.chkPropios.Text = "Solo Propios"
        Me.chkPropios.UseSelectable = True
        '
        'cbCampos
        '
        Me.cbCampos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbCampos.FormattingEnabled = True
        Me.cbCampos.ItemHeight = 15
        Me.cbCampos.Location = New System.Drawing.Point(82, 15)
        Me.cbCampos.Name = "cbCampos"
        Me.cbCampos.Size = New System.Drawing.Size(258, 23)
        Me.cbCampos.TabIndex = 2
        '
        'chkCampos
        '
        Me.chkCampos.AutoSize = True
        Me.chkCampos.Checked = True
        Me.chkCampos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCampos.Location = New System.Drawing.Point(6, 19)
        Me.chkCampos.Name = "chkCampos"
        Me.chkCampos.Size = New System.Drawing.Size(56, 15)
        Me.chkCampos.Style = MetroFramework.MetroColorStyle.Black
        Me.chkCampos.TabIndex = 0
        Me.chkCampos.Text = "Todos"
        Me.chkCampos.UseSelectable = True
        '
        'MaderaRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 364)
        Me.Controls.Add(Me.gbCampos)
        Me.Controls.Add(Me.gbMadera)
        Me.Controls.Add(Me.gbProveedor)
        Me.Controls.Add(Me.rbTerceros)
        Me.Controls.Add(Me.rbInfServicios)
        Me.Controls.Add(Me.rbInfCampos)
        Me.Controls.Add(Me.rbIngMadera)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gbdia)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MaderaRep"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Black
        Me.Text = "Informes de Madera"
        Me.gbdia.ResumeLayout(False)
        Me.gbdia.PerformLayout()
        Me.gbProveedor.ResumeLayout(False)
        Me.gbProveedor.PerformLayout()
        Me.gbMadera.ResumeLayout(False)
        Me.gbMadera.PerformLayout()
        Me.gbCampos.ResumeLayout(False)
        Me.gbCampos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents Button1 As MetroButton
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents gbdia As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents dthasta As MetroDateTime
    Friend WithEvents rbBiomasa As MetroRadioButton
    Friend WithEvents rbMadera As MetroRadioButton
    Friend WithEvents rbIngMadera As MetroRadioButton
    Friend WithEvents rbInfCampos As MetroRadioButton
    Friend WithEvents rbInfServicios As MetroRadioButton
    Friend WithEvents rbTerceros As MetroRadioButton
    Friend WithEvents gbProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents gbMadera As System.Windows.Forms.GroupBox
    Friend WithEvents gbCampos As System.Windows.Forms.GroupBox
    Friend WithEvents cbProv As ComboBox
    Friend WithEvents txtProv As MetroTextBox
    Friend WithEvents chKProv As MetroCheckBox
    Friend WithEvents cbMadera As ComboBox
    Friend WithEvents chkMadera As MetroCheckBox
    Friend WithEvents cbCampos As ComboBox
    Friend WithEvents chkCampos As MetroCheckBox
    Friend WithEvents chkPropios As MetroCheckBox
End Class
