Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Remitos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Remitos))
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txtRemito = New MetroFramework.Controls.MetroTextBox()
        Me.txtFecha = New MetroFramework.Controls.MetroTextBox()
        Me.lab = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMadera = New MetroFramework.Controls.MetroLabel()
        Me.txtNeto = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.txtTara = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.txtBruto = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.txtMadera = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPie = New MetroFramework.Controls.MetroCheckBox()
        Me.chkMadera = New MetroFramework.Controls.MetroCheckBox()
        Me.cbMadera = New MetroFramework.Controls.MetroComboBox()
        Me.txtCodMad = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkTala = New MetroFramework.Controls.MetroCheckBox()
        Me.cbTala = New MetroFramework.Controls.MetroComboBox()
        Me.txtCodTala = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkFlete = New MetroFramework.Controls.MetroCheckBox()
        Me.cbFlete = New MetroFramework.Controls.MetroComboBox()
        Me.txtCodFlete = New MetroFramework.Controls.MetroTextBox()
        Me.cbCampo = New MetroFramework.Controls.MetroComboBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.chkCampo = New MetroFramework.Controls.MetroCheckBox()
        Me.btncancel = New MetroFramework.Controls.MetroButton()
        Me.pnlProv = New MetroFramework.Controls.MetroPanel()
        Me.btnGrabar = New MetroFramework.Controls.MetroButton()
        Me.txtRemPI = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.btnSalir = New MetroFramework.Controls.MetroTile()
        Me.btnGuardar = New MetroFramework.Controls.MetroTile()
        Me.btnEditar = New MetroFramework.Controls.MetroTile()
        Me.BtnNuevo = New MetroFramework.Controls.MetroTile()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.pnlProv.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Remito"
        '
        'txtRemito
        '
        '
        '
        '
        Me.txtRemito.CustomButton.Image = Nothing
        Me.txtRemito.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtRemito.CustomButton.Name = ""
        Me.txtRemito.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtRemito.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRemito.CustomButton.TabIndex = 1
        Me.txtRemito.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRemito.CustomButton.UseSelectable = True
        Me.txtRemito.CustomButton.Visible = False
        Me.txtRemito.Enabled = False
        Me.txtRemito.Lines = New String(-1) {}
        Me.txtRemito.Location = New System.Drawing.Point(83, 109)
        Me.txtRemito.MaxLength = 32767
        Me.txtRemito.Name = "txtRemito"
        Me.txtRemito.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRemito.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRemito.SelectedText = ""
        Me.txtRemito.SelectionLength = 0
        Me.txtRemito.SelectionStart = 0
        Me.txtRemito.ShortcutsEnabled = True
        Me.txtRemito.Size = New System.Drawing.Size(100, 20)
        Me.txtRemito.TabIndex = 0
        Me.txtRemito.UseSelectable = True
        Me.txtRemito.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRemito.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFecha
        '
        '
        '
        '
        Me.txtFecha.CustomButton.Image = Nothing
        Me.txtFecha.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtFecha.CustomButton.Name = ""
        Me.txtFecha.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtFecha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFecha.CustomButton.TabIndex = 1
        Me.txtFecha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFecha.CustomButton.UseSelectable = True
        Me.txtFecha.CustomButton.Visible = False
        Me.txtFecha.Enabled = False
        Me.txtFecha.Lines = New String(-1) {}
        Me.txtFecha.Location = New System.Drawing.Point(285, 109)
        Me.txtFecha.MaxLength = 32767
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFecha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFecha.SelectedText = ""
        Me.txtFecha.SelectionLength = 0
        Me.txtFecha.SelectionStart = 0
        Me.txtFecha.ShortcutsEnabled = True
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 2
        Me.txtFecha.UseSelectable = True
        Me.txtFecha.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFecha.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lab
        '
        Me.lab.AutoSize = True
        Me.lab.Location = New System.Drawing.Point(229, 110)
        Me.lab.Name = "lab"
        Me.lab.Size = New System.Drawing.Size(43, 19)
        Me.lab.TabIndex = 8
        Me.lab.Text = "Fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMadera)
        Me.GroupBox1.Controls.Add(Me.txtNeto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTara)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBruto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMadera)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 118)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'lblMadera
        '
        Me.lblMadera.AutoSize = True
        Me.lblMadera.Location = New System.Drawing.Point(9, 61)
        Me.lblMadera.Name = "lblMadera"
        Me.lblMadera.Size = New System.Drawing.Size(35, 19)
        Me.lblMadera.TabIndex = 22
        Me.lblMadera.Text = "Tipo"
        '
        'txtNeto
        '
        '
        '
        '
        Me.txtNeto.CustomButton.Image = Nothing
        Me.txtNeto.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtNeto.CustomButton.Name = ""
        Me.txtNeto.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtNeto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNeto.CustomButton.TabIndex = 1
        Me.txtNeto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNeto.CustomButton.UseSelectable = True
        Me.txtNeto.CustomButton.Visible = False
        Me.txtNeto.Lines = New String(-1) {}
        Me.txtNeto.Location = New System.Drawing.Point(273, 84)
        Me.txtNeto.MaxLength = 32767
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNeto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNeto.SelectedText = ""
        Me.txtNeto.SelectionLength = 0
        Me.txtNeto.SelectionStart = 0
        Me.txtNeto.ShortcutsEnabled = True
        Me.txtNeto.Size = New System.Drawing.Size(100, 20)
        Me.txtNeto.TabIndex = 7
        Me.txtNeto.UseSelectable = True
        Me.txtNeto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNeto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Neto:"
        '
        'txtTara
        '
        '
        '
        '
        Me.txtTara.CustomButton.Image = Nothing
        Me.txtTara.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtTara.CustomButton.Name = ""
        Me.txtTara.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtTara.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTara.CustomButton.TabIndex = 1
        Me.txtTara.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTara.CustomButton.UseSelectable = True
        Me.txtTara.CustomButton.Visible = False
        Me.txtTara.Lines = New String(-1) {}
        Me.txtTara.Location = New System.Drawing.Point(273, 49)
        Me.txtTara.MaxLength = 32767
        Me.txtTara.Name = "txtTara"
        Me.txtTara.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTara.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTara.SelectedText = ""
        Me.txtTara.SelectionLength = 0
        Me.txtTara.SelectionStart = 0
        Me.txtTara.ShortcutsEnabled = True
        Me.txtTara.Size = New System.Drawing.Size(100, 20)
        Me.txtTara.TabIndex = 5
        Me.txtTara.UseSelectable = True
        Me.txtTara.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTara.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tara:"
        '
        'txtBruto
        '
        '
        '
        '
        Me.txtBruto.CustomButton.Image = Nothing
        Me.txtBruto.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtBruto.CustomButton.Name = ""
        Me.txtBruto.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtBruto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBruto.CustomButton.TabIndex = 1
        Me.txtBruto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBruto.CustomButton.UseSelectable = True
        Me.txtBruto.CustomButton.Visible = False
        Me.txtBruto.Lines = New String(-1) {}
        Me.txtBruto.Location = New System.Drawing.Point(273, 23)
        Me.txtBruto.MaxLength = 32767
        Me.txtBruto.Name = "txtBruto"
        Me.txtBruto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBruto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBruto.SelectedText = ""
        Me.txtBruto.SelectionLength = 0
        Me.txtBruto.SelectionStart = 0
        Me.txtBruto.ShortcutsEnabled = True
        Me.txtBruto.Size = New System.Drawing.Size(100, 20)
        Me.txtBruto.TabIndex = 3
        Me.txtBruto.UseSelectable = True
        Me.txtBruto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBruto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bruto:"
        '
        'txtMadera
        '
        '
        '
        '
        Me.txtMadera.CustomButton.Image = Nothing
        Me.txtMadera.CustomButton.Location = New System.Drawing.Point(174, 2)
        Me.txtMadera.CustomButton.Name = ""
        Me.txtMadera.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtMadera.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMadera.CustomButton.TabIndex = 1
        Me.txtMadera.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMadera.CustomButton.UseSelectable = True
        Me.txtMadera.CustomButton.Visible = False
        Me.txtMadera.Lines = New String(-1) {}
        Me.txtMadera.Location = New System.Drawing.Point(11, 38)
        Me.txtMadera.MaxLength = 32767
        Me.txtMadera.Name = "txtMadera"
        Me.txtMadera.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMadera.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMadera.SelectedText = ""
        Me.txtMadera.SelectionLength = 0
        Me.txtMadera.SelectionStart = 0
        Me.txtMadera.ShortcutsEnabled = True
        Me.txtMadera.Size = New System.Drawing.Size(192, 20)
        Me.txtMadera.TabIndex = 0
        Me.txtMadera.UseSelectable = True
        Me.txtMadera.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMadera.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Madera"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(394, 99)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 227
        Me.LineShape1.X2 = 381
        Me.LineShape1.Y1 = 59
        Me.LineShape1.Y2 = 59
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPie)
        Me.GroupBox2.Controls.Add(Me.chkMadera)
        Me.GroupBox2.Controls.Add(Me.cbMadera)
        Me.GroupBox2.Controls.Add(Me.txtCodMad)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 68)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Madera"
        '
        'chkPie
        '
        Me.chkPie.AutoSize = True
        Me.chkPie.Location = New System.Drawing.Point(6, 45)
        Me.chkPie.Name = "chkPie"
        Me.chkPie.Size = New System.Drawing.Size(55, 15)
        Me.chkPie.Style = MetroFramework.MetroColorStyle.Black
        Me.chkPie.TabIndex = 1
        Me.chkPie.Text = "En Pie"
        Me.chkPie.UseSelectable = True
        '
        'chkMadera
        '
        Me.chkMadera.AutoSize = True
        Me.chkMadera.Checked = True
        Me.chkMadera.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkMadera.Location = New System.Drawing.Point(6, 21)
        Me.chkMadera.Name = "chkMadera"
        Me.chkMadera.Size = New System.Drawing.Size(68, 15)
        Me.chkMadera.Style = MetroFramework.MetroColorStyle.Black
        Me.chkMadera.TabIndex = 0
        Me.chkMadera.Text = "Terceros"
        Me.chkMadera.UseSelectable = True
        '
        'cbMadera
        '
        Me.cbMadera.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbMadera.FormattingEnabled = True
        Me.cbMadera.ItemHeight = 19
        Me.cbMadera.Location = New System.Drawing.Point(163, 19)
        Me.cbMadera.Name = "cbMadera"
        Me.cbMadera.Size = New System.Drawing.Size(207, 25)
        Me.cbMadera.Style = MetroFramework.MetroColorStyle.Silver
        Me.cbMadera.TabIndex = 3
        Me.cbMadera.UseSelectable = True
        '
        'txtCodMad
        '
        '
        '
        '
        Me.txtCodMad.CustomButton.Image = Nothing
        Me.txtCodMad.CustomButton.Location = New System.Drawing.Point(39, 2)
        Me.txtCodMad.CustomButton.Name = ""
        Me.txtCodMad.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtCodMad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodMad.CustomButton.TabIndex = 1
        Me.txtCodMad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodMad.CustomButton.UseSelectable = True
        Me.txtCodMad.CustomButton.Visible = False
        Me.txtCodMad.Lines = New String(-1) {}
        Me.txtCodMad.Location = New System.Drawing.Point(98, 19)
        Me.txtCodMad.MaxLength = 32767
        Me.txtCodMad.Name = "txtCodMad"
        Me.txtCodMad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodMad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodMad.SelectedText = ""
        Me.txtCodMad.SelectionLength = 0
        Me.txtCodMad.SelectionStart = 0
        Me.txtCodMad.ShortcutsEnabled = True
        Me.txtCodMad.Size = New System.Drawing.Size(57, 20)
        Me.txtCodMad.TabIndex = 2
        Me.txtCodMad.UseSelectable = True
        Me.txtCodMad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodMad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkTala)
        Me.GroupBox3.Controls.Add(Me.cbTala)
        Me.GroupBox3.Controls.Add(Me.txtCodTala)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 50)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tala"
        '
        'chkTala
        '
        Me.chkTala.AutoSize = True
        Me.chkTala.Checked = True
        Me.chkTala.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkTala.Location = New System.Drawing.Point(6, 22)
        Me.chkTala.Name = "chkTala"
        Me.chkTala.Size = New System.Drawing.Size(68, 15)
        Me.chkTala.Style = MetroFramework.MetroColorStyle.Black
        Me.chkTala.TabIndex = 0
        Me.chkTala.Text = "Terceros"
        Me.chkTala.UseSelectable = True
        '
        'cbTala
        '
        Me.cbTala.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbTala.FormattingEnabled = True
        Me.cbTala.ItemHeight = 19
        Me.cbTala.Location = New System.Drawing.Point(163, 19)
        Me.cbTala.Name = "cbTala"
        Me.cbTala.Size = New System.Drawing.Size(207, 25)
        Me.cbTala.Style = MetroFramework.MetroColorStyle.Silver
        Me.cbTala.TabIndex = 2
        Me.cbTala.UseSelectable = True
        '
        'txtCodTala
        '
        '
        '
        '
        Me.txtCodTala.CustomButton.Image = Nothing
        Me.txtCodTala.CustomButton.Location = New System.Drawing.Point(39, 2)
        Me.txtCodTala.CustomButton.Name = ""
        Me.txtCodTala.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtCodTala.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodTala.CustomButton.TabIndex = 1
        Me.txtCodTala.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodTala.CustomButton.UseSelectable = True
        Me.txtCodTala.CustomButton.Visible = False
        Me.txtCodTala.Lines = New String(-1) {}
        Me.txtCodTala.Location = New System.Drawing.Point(98, 19)
        Me.txtCodTala.MaxLength = 32767
        Me.txtCodTala.Name = "txtCodTala"
        Me.txtCodTala.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodTala.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodTala.SelectedText = ""
        Me.txtCodTala.SelectionLength = 0
        Me.txtCodTala.SelectionStart = 0
        Me.txtCodTala.ShortcutsEnabled = True
        Me.txtCodTala.Size = New System.Drawing.Size(57, 20)
        Me.txtCodTala.TabIndex = 1
        Me.txtCodTala.UseSelectable = True
        Me.txtCodTala.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodTala.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkFlete)
        Me.GroupBox4.Controls.Add(Me.cbFlete)
        Me.GroupBox4.Controls.Add(Me.txtCodFlete)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 142)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 49)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Flete"
        '
        'chkFlete
        '
        Me.chkFlete.AutoSize = True
        Me.chkFlete.Checked = True
        Me.chkFlete.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkFlete.Location = New System.Drawing.Point(6, 22)
        Me.chkFlete.Name = "chkFlete"
        Me.chkFlete.Size = New System.Drawing.Size(68, 15)
        Me.chkFlete.Style = MetroFramework.MetroColorStyle.Black
        Me.chkFlete.TabIndex = 0
        Me.chkFlete.Text = "Terceros"
        Me.chkFlete.UseSelectable = True
        '
        'cbFlete
        '
        Me.cbFlete.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbFlete.FormattingEnabled = True
        Me.cbFlete.ItemHeight = 19
        Me.cbFlete.Location = New System.Drawing.Point(163, 19)
        Me.cbFlete.Name = "cbFlete"
        Me.cbFlete.Size = New System.Drawing.Size(207, 25)
        Me.cbFlete.Style = MetroFramework.MetroColorStyle.Silver
        Me.cbFlete.TabIndex = 2
        Me.cbFlete.UseSelectable = True
        '
        'txtCodFlete
        '
        '
        '
        '
        Me.txtCodFlete.CustomButton.Image = Nothing
        Me.txtCodFlete.CustomButton.Location = New System.Drawing.Point(39, 2)
        Me.txtCodFlete.CustomButton.Name = ""
        Me.txtCodFlete.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtCodFlete.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodFlete.CustomButton.TabIndex = 1
        Me.txtCodFlete.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodFlete.CustomButton.UseSelectable = True
        Me.txtCodFlete.CustomButton.Visible = False
        Me.txtCodFlete.Lines = New String(-1) {}
        Me.txtCodFlete.Location = New System.Drawing.Point(98, 19)
        Me.txtCodFlete.MaxLength = 32767
        Me.txtCodFlete.Name = "txtCodFlete"
        Me.txtCodFlete.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodFlete.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodFlete.SelectedText = ""
        Me.txtCodFlete.SelectionLength = 0
        Me.txtCodFlete.SelectionStart = 0
        Me.txtCodFlete.ShortcutsEnabled = True
        Me.txtCodFlete.Size = New System.Drawing.Size(57, 20)
        Me.txtCodFlete.TabIndex = 1
        Me.txtCodFlete.UseSelectable = True
        Me.txtCodFlete.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodFlete.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbCampo
        '
        Me.cbCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCampo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.ItemHeight = 19
        Me.cbCampo.Location = New System.Drawing.Point(106, 202)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(269, 25)
        Me.cbCampo.Style = MetroFramework.MetroColorStyle.Silver
        Me.cbCampo.TabIndex = 4
        Me.cbCampo.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label7.ForeColor = Color.Black
        Me.Label7.Location = New System.Drawing.Point(54, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(331, 34)
        Me.Label7.Style = MetroFramework.MetroColorStyle.Blue
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "PROVEEDORES"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.UseCustomBackColor = True
        Me.Label7.UseCustomForeColor = True
        Me.Label7.UseStyleColors = True
        '
        'chkCampo
        '
        Me.chkCampo.Checked = True
        Me.chkCampo.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkCampo.Location = New System.Drawing.Point(9, 204)
        Me.chkCampo.Name = "chkCampo"
        Me.chkCampo.Size = New System.Drawing.Size(77, 23)
        Me.chkCampo.TabIndex = 3
        Me.chkCampo.Text = "Campo"
        Me.chkCampo.UseSelectable = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(328, 244)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseSelectable = True
        '
        'pnlProv
        '
        Me.pnlProv.Controls.Add(Me.btnGrabar)
        Me.pnlProv.Controls.Add(Me.btncancel)
        Me.pnlProv.Controls.Add(Me.GroupBox2)
        Me.pnlProv.Controls.Add(Me.chkCampo)
        Me.pnlProv.Controls.Add(Me.GroupBox3)
        Me.pnlProv.Controls.Add(Me.GroupBox4)
        Me.pnlProv.Controls.Add(Me.cbCampo)
        Me.pnlProv.Enabled = False
        Me.pnlProv.HorizontalScrollbarBarColor = True
        Me.pnlProv.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlProv.HorizontalScrollbarSize = 10
        Me.pnlProv.Location = New System.Drawing.Point(12, 328)
        Me.pnlProv.Name = "pnlProv"
        Me.pnlProv.Size = New System.Drawing.Size(417, 281)
        Me.pnlProv.TabIndex = 21
        Me.pnlProv.VerticalScrollbarBarColor = True
        Me.pnlProv.VerticalScrollbarHighlightOnWheel = False
        Me.pnlProv.VerticalScrollbarSize = 10
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(231, 244)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 5
        Me.btnGrabar.Text = "&Guardar"
        Me.btnGrabar.UseSelectable = True
        '
        'txtRemPI
        '
        '
        '
        '
        Me.txtRemPI.CustomButton.Image = Nothing
        Me.txtRemPI.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtRemPI.CustomButton.Name = ""
        Me.txtRemPI.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtRemPI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRemPI.CustomButton.TabIndex = 1
        Me.txtRemPI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRemPI.CustomButton.UseSelectable = True
        Me.txtRemPI.CustomButton.Visible = False
        Me.txtRemPI.Enabled = False
        Me.txtRemPI.Lines = New String(-1) {}
        Me.txtRemPI.Location = New System.Drawing.Point(83, 135)
        Me.txtRemPI.MaxLength = 32767
        Me.txtRemPI.Name = "txtRemPI"
        Me.txtRemPI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRemPI.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRemPI.SelectedText = ""
        Me.txtRemPI.SelectionLength = 0
        Me.txtRemPI.SelectionStart = 0
        Me.txtRemPI.ShortcutsEnabled = True
        Me.txtRemPI.Size = New System.Drawing.Size(100, 20)
        Me.txtRemPI.TabIndex = 1
        Me.txtRemPI.UseSelectable = True
        Me.txtRemPI.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRemPI.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Remito PI"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanel1.Controls.Add(Me.MetroTile2)
        Me.MetroPanel1.Controls.Add(Me.btnSalir)
        Me.MetroPanel1.Controls.Add(Me.btnGuardar)
        Me.MetroPanel1.Controls.Add(Me.btnEditar)
        Me.MetroPanel1.Controls.Add(Me.BtnNuevo)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(5, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(437, 41)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroPanel1.TabIndex = 28
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroTile2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTile2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MetroTile2.Location = New System.Drawing.Point(356, 0)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(81, 41)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile2.TabIndex = 7
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        '
        'btnSalir
        '
        Me.btnSalir.ActiveControl = Nothing
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Location = New System.Drawing.Point(267, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 41)
        Me.btnSalir.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.TileImage = CType(resources.GetObject("btnSalir.TileImage"), System.Drawing.Image)
        Me.btnSalir.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnSalir.UseSelectable = True
        Me.btnSalir.UseTileImage = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ActiveControl = Nothing
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardar.Location = New System.Drawing.Point(178, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(89, 41)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.TileImage = CType(resources.GetObject("btnGuardar.TileImage"), System.Drawing.Image)
        Me.btnGuardar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseTileImage = True
        '
        'btnEditar
        '
        Me.btnEditar.ActiveControl = Nothing
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEditar.Location = New System.Drawing.Point(89, 0)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(89, 41)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TileImage = CType(resources.GetObject("btnEditar.TileImage"), System.Drawing.Image)
        Me.btnEditar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnEditar.UseSelectable = True
        Me.btnEditar.UseTileImage = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.ActiveControl = Nothing
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnNuevo.Location = New System.Drawing.Point(0, 0)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(89, 41)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.TileImage = CType(resources.GetObject("BtnNuevo.TileImage"), System.Drawing.Image)
        Me.BtnNuevo.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.BtnNuevo.UseSelectable = True
        Me.BtnNuevo.UseTileImage = True
        '
        'Remitos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 659)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.txtRemPI)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pnlProv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lab)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtRemito)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Remitos"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Style = MetroFramework.MetroColorStyle.Black
        Me.Text = "Remitos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.pnlProv.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents txtRemito As MetroTextBox
    Friend WithEvents txtFecha As MetroTextBox
    Friend WithEvents lab As MetroLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents txtMadera As MetroTextBox
    Friend WithEvents txtNeto As MetroTextBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents txtTara As MetroTextBox
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents txtBruto As MetroTextBox
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMadera As MetroComboBox
    Friend WithEvents txtCodMad As MetroTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbTala As MetroComboBox
    Friend WithEvents txtCodTala As MetroTextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbFlete As MetroComboBox
    Friend WithEvents txtCodFlete As MetroTextBox
    Friend WithEvents cbCampo As MetroComboBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents chkMadera As MetroCheckBox
    Friend WithEvents chkTala As MetroCheckBox
    Friend WithEvents chkFlete As MetroCheckBox
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents chkCampo As MetroCheckBox
    Friend WithEvents btncancel As MetroButton
    Friend WithEvents pnlProv As MetroPanel
    Friend WithEvents lblMadera As MetroLabel
    Friend WithEvents btnGrabar As MetroButton
    Friend WithEvents txtRemPI As MetroTextBox
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents chkPie As MetroCheckBox
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents MetroTile2 As MetroTile
    Friend WithEvents btnSalir As MetroTile
    Friend WithEvents btnGuardar As MetroTile
    Friend WithEvents btnEditar As MetroTile
    Friend WithEvents BtnNuevo As MetroTile
End Class
