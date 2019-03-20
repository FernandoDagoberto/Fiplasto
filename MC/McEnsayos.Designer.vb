Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class McEnsayos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbmc = New MetroFramework.Controls.MetroComboBox()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.cbmaterial = New MetroFramework.Controls.MetroComboBox()
        Me.txtcpseco = New MetroFramework.Controls.MetroTextBox()
        Me.txtcpconc = New MetroFramework.Controls.MetroTextBox()
        Me.txtsdsd = New MetroFramework.Controls.MetroTextBox()
        Me.txtshhhumedo = New MetroFramework.Controls.MetroTextBox()
        Me.txtshhseco = New MetroFramework.Controls.MetroTextBox()
        Me.txtshhsequedad = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.Label13 = New MetroFramework.Controls.MetroLabel()
        Me.Label14 = New MetroFramework.Controls.MetroLabel()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.Label15 = New MetroFramework.Controls.MetroLabel()
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
        Me.Label16 = New MetroFramework.Controls.MetroLabel()
        Me.dtencabezado = New MetroFramework.Controls.MetroDateTime()
        Me.Label17 = New MetroFramework.Controls.MetroLabel()
        Me.Label18 = New MetroFramework.Controls.MetroLabel()
        Me.txtsdtiempo = New MetroFramework.Controls.MetroTextBox()
        Me.txtsdseco = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gbensayo = New System.Windows.Forms.GroupBox()
        Me.PanelGrupo1 = New MetroFramework.Controls.MetroPanel()
        Me.chkgrupo1 = New MetroFramework.Controls.MetroCheckBox()
        Me.gbtq3 = New System.Windows.Forms.GroupBox()
        Me.panelGrupo2 = New MetroFramework.Controls.MetroPanel()
        Me.gb3 = New System.Windows.Forms.GroupBox()
        Me.txtcptqconc = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.txtcptqseco = New MetroFramework.Controls.MetroTextBox()
        Me.gb5 = New System.Windows.Forms.GroupBox()
        Me.dtensayo = New System.Windows.Forms.DateTimePicker()
        Me.txtensayo = New MetroFramework.Controls.MetroTextBox()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.Label19 = New MetroFramework.Controls.MetroLabel()
        Me.gb4 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New MetroFramework.Controls.MetroLabel()
        Me.Label21 = New MetroFramework.Controls.MetroLabel()
        Me.Label22 = New MetroFramework.Controls.MetroLabel()
        Me.txtsdtqsd = New MetroFramework.Controls.MetroTextBox()
        Me.txtsdtqseco = New MetroFramework.Controls.MetroTextBox()
        Me.txtsdtqtiempo = New MetroFramework.Controls.MetroTextBox()
        Me.chkgrupo2 = New MetroFramework.Controls.MetroCheckBox()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgEnsayos = New MetroFramework.Controls.MetroGrid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgtq3 = New MetroFramework.Controls.MetroGrid()
        Me.encabezado = New MetroFramework.Controls.MetroPanel()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbensayo.SuspendLayout()
        Me.PanelGrupo1.SuspendLayout()
        Me.gbtq3.SuspendLayout()
        Me.panelGrupo2.SuspendLayout()
        Me.gb3.SuspendLayout()
        Me.gb5.SuspendLayout()
        Me.gb4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgEnsayos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgtq3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.encabezado.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbmc
        '
        Me.cbmc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmc.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmc.FormattingEnabled = True
        Me.cbmc.ItemHeight = 19
        Me.cbmc.Items.AddRange(New Object() {"1", "2"})
        Me.cbmc.Location = New System.Drawing.Point(241, 1)
        Me.cbmc.Name = "cbmc"
        Me.cbmc.Size = New System.Drawing.Size(90, 25)
        Me.cbmc.TabIndex = 2
        Me.cbmc.UseSelectable = True
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(73, 37)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(86, 25)
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
        Me.cbgrupo.Location = New System.Drawing.Point(242, 37)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(89, 25)
        Me.cbgrupo.TabIndex = 3
        Me.cbgrupo.UseSelectable = True
        '
        'cbmaterial
        '
        Me.cbmaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmaterial.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmaterial.FormattingEnabled = True
        Me.cbmaterial.ItemHeight = 19
        Me.cbmaterial.Location = New System.Drawing.Point(421, 2)
        Me.cbmaterial.Name = "cbmaterial"
        Me.cbmaterial.Size = New System.Drawing.Size(90, 25)
        Me.cbmaterial.TabIndex = 4
        Me.cbmaterial.UseSelectable = True
        '
        'txtcpseco
        '
        '
        '
        '
        Me.txtcpseco.CustomButton.Image = Nothing
        Me.txtcpseco.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtcpseco.CustomButton.Name = ""
        Me.txtcpseco.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcpseco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcpseco.CustomButton.TabIndex = 1
        Me.txtcpseco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcpseco.CustomButton.UseSelectable = True
        Me.txtcpseco.CustomButton.Visible = False
        Me.txtcpseco.Lines = New String(-1) {}
        Me.txtcpseco.Location = New System.Drawing.Point(135, 20)
        Me.txtcpseco.MaxLength = 32767
        Me.txtcpseco.Name = "txtcpseco"
        Me.txtcpseco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcpseco.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcpseco.SelectedText = ""
        Me.txtcpseco.SelectionLength = 0
        Me.txtcpseco.SelectionStart = 0
        Me.txtcpseco.ShortcutsEnabled = True
        Me.txtcpseco.Size = New System.Drawing.Size(75, 20)
        Me.txtcpseco.TabIndex = 1
        Me.txtcpseco.UseSelectable = True
        Me.txtcpseco.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcpseco.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtcpconc
        '
        '
        '
        '
        Me.txtcpconc.CustomButton.Image = Nothing
        Me.txtcpconc.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtcpconc.CustomButton.Name = ""
        Me.txtcpconc.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcpconc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcpconc.CustomButton.TabIndex = 1
        Me.txtcpconc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcpconc.CustomButton.UseSelectable = True
        Me.txtcpconc.CustomButton.Visible = False
        Me.txtcpconc.Lines = New String(-1) {}
        Me.txtcpconc.Location = New System.Drawing.Point(135, 45)
        Me.txtcpconc.MaxLength = 32767
        Me.txtcpconc.Name = "txtcpconc"
        Me.txtcpconc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcpconc.ReadOnly = True
        Me.txtcpconc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcpconc.SelectedText = ""
        Me.txtcpconc.SelectionLength = 0
        Me.txtcpconc.SelectionStart = 0
        Me.txtcpconc.ShortcutsEnabled = True
        Me.txtcpconc.Size = New System.Drawing.Size(75, 20)
        Me.txtcpconc.TabIndex = 2
        Me.txtcpconc.UseSelectable = True
        Me.txtcpconc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcpconc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtsdsd
        '
        '
        '
        '
        Me.txtsdsd.CustomButton.Image = Nothing
        Me.txtsdsd.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtsdsd.CustomButton.Name = ""
        Me.txtsdsd.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsdsd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsdsd.CustomButton.TabIndex = 1
        Me.txtsdsd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsdsd.CustomButton.UseSelectable = True
        Me.txtsdsd.CustomButton.Visible = False
        Me.txtsdsd.Lines = New String(-1) {}
        Me.txtsdsd.Location = New System.Drawing.Point(135, 71)
        Me.txtsdsd.MaxLength = 32767
        Me.txtsdsd.Name = "txtsdsd"
        Me.txtsdsd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsdsd.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsdsd.SelectedText = ""
        Me.txtsdsd.SelectionLength = 0
        Me.txtsdsd.SelectionStart = 0
        Me.txtsdsd.ShortcutsEnabled = True
        Me.txtsdsd.Size = New System.Drawing.Size(75, 20)
        Me.txtsdsd.TabIndex = 2
        Me.txtsdsd.UseSelectable = True
        Me.txtsdsd.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsdsd.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtshhhumedo
        '
        '
        '
        '
        Me.txtshhhumedo.CustomButton.Image = Nothing
        Me.txtshhhumedo.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtshhhumedo.CustomButton.Name = ""
        Me.txtshhhumedo.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtshhhumedo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtshhhumedo.CustomButton.TabIndex = 1
        Me.txtshhhumedo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtshhhumedo.CustomButton.UseSelectable = True
        Me.txtshhhumedo.CustomButton.Visible = False
        Me.txtshhhumedo.Lines = New String(-1) {}
        Me.txtshhhumedo.Location = New System.Drawing.Point(135, 21)
        Me.txtshhhumedo.MaxLength = 32767
        Me.txtshhhumedo.Name = "txtshhhumedo"
        Me.txtshhhumedo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtshhhumedo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtshhhumedo.SelectedText = ""
        Me.txtshhhumedo.SelectionLength = 0
        Me.txtshhhumedo.SelectionStart = 0
        Me.txtshhhumedo.ShortcutsEnabled = True
        Me.txtshhhumedo.Size = New System.Drawing.Size(75, 20)
        Me.txtshhhumedo.TabIndex = 0
        Me.txtshhhumedo.UseSelectable = True
        Me.txtshhhumedo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtshhhumedo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtshhseco
        '
        '
        '
        '
        Me.txtshhseco.CustomButton.Image = Nothing
        Me.txtshhseco.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtshhseco.CustomButton.Name = ""
        Me.txtshhseco.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtshhseco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtshhseco.CustomButton.TabIndex = 1
        Me.txtshhseco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtshhseco.CustomButton.UseSelectable = True
        Me.txtshhseco.CustomButton.Visible = False
        Me.txtshhseco.Lines = New String(-1) {}
        Me.txtshhseco.Location = New System.Drawing.Point(135, 47)
        Me.txtshhseco.MaxLength = 32767
        Me.txtshhseco.Name = "txtshhseco"
        Me.txtshhseco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtshhseco.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtshhseco.SelectedText = ""
        Me.txtshhseco.SelectionLength = 0
        Me.txtshhseco.SelectionStart = 0
        Me.txtshhseco.ShortcutsEnabled = True
        Me.txtshhseco.Size = New System.Drawing.Size(75, 20)
        Me.txtshhseco.TabIndex = 1
        Me.txtshhseco.UseSelectable = True
        Me.txtshhseco.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtshhseco.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtshhsequedad
        '
        '
        '
        '
        Me.txtshhsequedad.CustomButton.Image = Nothing
        Me.txtshhsequedad.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtshhsequedad.CustomButton.Name = ""
        Me.txtshhsequedad.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtshhsequedad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtshhsequedad.CustomButton.TabIndex = 1
        Me.txtshhsequedad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtshhsequedad.CustomButton.UseSelectable = True
        Me.txtshhsequedad.CustomButton.Visible = False
        Me.txtshhsequedad.Lines = New String(-1) {}
        Me.txtshhsequedad.Location = New System.Drawing.Point(135, 74)
        Me.txtshhsequedad.MaxLength = 32767
        Me.txtshhsequedad.Name = "txtshhsequedad"
        Me.txtshhsequedad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtshhsequedad.ReadOnly = True
        Me.txtshhsequedad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtshhsequedad.SelectedText = ""
        Me.txtshhsequedad.SelectionLength = 0
        Me.txtshhsequedad.SelectionStart = 0
        Me.txtshhsequedad.ShortcutsEnabled = True
        Me.txtshhsequedad.Size = New System.Drawing.Size(75, 20)
        Me.txtshhsequedad.TabIndex = 2
        Me.txtshhsequedad.UseSelectable = True
        Me.txtshhsequedad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtshhsequedad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(179, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "MC:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(11, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(181, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(359, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Material:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(6, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Peso seco (gr):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(6, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Concentración(%):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(16, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "SD:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(16, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 15)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Peso Húmedo (gr):"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(16, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 15)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Peso Seco (gr):"
        '
        'Label14
        '
        Me.Label14.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(16, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 17)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Sequedad (%):"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(220, 513)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(309, 513)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 3
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(220, 557)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 19)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Fecha:"
        '
        'dtfecha
        '
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(272, 550)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(84, 25)
        Me.dtfecha.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(11, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 15)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Fecha:"
        '
        'dtencabezado
        '
        Me.dtencabezado.Enabled = False
        Me.dtencabezado.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtencabezado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtencabezado.Location = New System.Drawing.Point(73, 4)
        Me.dtencabezado.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtencabezado.Name = "dtencabezado"
        Me.dtencabezado.Size = New System.Drawing.Size(86, 25)
        Me.dtencabezado.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(16, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 15)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Tiempo (seg):"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(16, 27)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 15)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "Peso seco (gr):"
        '
        'txtsdtiempo
        '
        '
        '
        '
        Me.txtsdtiempo.CustomButton.Image = Nothing
        Me.txtsdtiempo.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtsdtiempo.CustomButton.Name = ""
        Me.txtsdtiempo.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsdtiempo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsdtiempo.CustomButton.TabIndex = 1
        Me.txtsdtiempo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsdtiempo.CustomButton.UseSelectable = True
        Me.txtsdtiempo.CustomButton.Visible = False
        Me.txtsdtiempo.Lines = New String(-1) {}
        Me.txtsdtiempo.Location = New System.Drawing.Point(135, 45)
        Me.txtsdtiempo.MaxLength = 32767
        Me.txtsdtiempo.Name = "txtsdtiempo"
        Me.txtsdtiempo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsdtiempo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsdtiempo.SelectedText = ""
        Me.txtsdtiempo.SelectionLength = 0
        Me.txtsdtiempo.SelectionStart = 0
        Me.txtsdtiempo.ShortcutsEnabled = True
        Me.txtsdtiempo.Size = New System.Drawing.Size(75, 20)
        Me.txtsdtiempo.TabIndex = 1
        Me.txtsdtiempo.UseSelectable = True
        Me.txtsdtiempo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsdtiempo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtsdseco
        '
        '
        '
        '
        Me.txtsdseco.CustomButton.Image = Nothing
        Me.txtsdseco.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtsdseco.CustomButton.Name = ""
        Me.txtsdseco.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsdseco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsdseco.CustomButton.TabIndex = 1
        Me.txtsdseco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsdseco.CustomButton.UseSelectable = True
        Me.txtsdseco.CustomButton.Visible = False
        Me.txtsdseco.Lines = New String(-1) {}
        Me.txtsdseco.Location = New System.Drawing.Point(135, 20)
        Me.txtsdseco.MaxLength = 32767
        Me.txtsdseco.Name = "txtsdseco"
        Me.txtsdseco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsdseco.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsdseco.SelectedText = ""
        Me.txtsdseco.SelectionLength = 0
        Me.txtsdseco.SelectionStart = 0
        Me.txtsdseco.ShortcutsEnabled = True
        Me.txtsdseco.Size = New System.Drawing.Size(75, 20)
        Me.txtsdseco.TabIndex = 0
        Me.txtsdseco.UseSelectable = True
        Me.txtsdseco.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsdseco.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcpconc)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtcpseco)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 84)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Concentración Pulpa"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtsdsd)
        Me.GroupBox3.Controls.Add(Me.txtsdseco)
        Me.GroupBox3.Controls.Add(Me.txtsdtiempo)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(10, 95)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 101)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Segundos Drenaje"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtshhsequedad)
        Me.GroupBox4.Controls.Add(Me.txtshhseco)
        Me.GroupBox4.Controls.Add(Me.txtshhhumedo)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(10, 202)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(232, 104)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sequedad Hoja Húmeda"
        '
        'gbensayo
        '
        Me.gbensayo.BackColor = System.Drawing.Color.Transparent
        Me.gbensayo.Controls.Add(Me.PanelGrupo1)
        Me.gbensayo.Controls.Add(Me.chkgrupo1)
        Me.gbensayo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbensayo.ForeColor = Color.Black
        Me.gbensayo.Location = New System.Drawing.Point(37, 145)
        Me.gbensayo.Name = "gbensayo"
        Me.gbensayo.Size = New System.Drawing.Size(264, 362)
        Me.gbensayo.TabIndex = 1
        Me.gbensayo.TabStop = False
        Me.gbensayo.Text = "Ensayos en máquina"
        '
        'PanelGrupo1
        '
        Me.PanelGrupo1.Controls.Add(Me.GroupBox2)
        Me.PanelGrupo1.Controls.Add(Me.GroupBox4)
        Me.PanelGrupo1.Controls.Add(Me.GroupBox3)
        Me.PanelGrupo1.HorizontalScrollbarBarColor = True
        Me.PanelGrupo1.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelGrupo1.HorizontalScrollbarSize = 10
        Me.PanelGrupo1.Location = New System.Drawing.Point(6, 37)
        Me.PanelGrupo1.Name = "PanelGrupo1"
        Me.PanelGrupo1.Size = New System.Drawing.Size(252, 319)
        Me.PanelGrupo1.TabIndex = 60
        Me.PanelGrupo1.VerticalScrollbarBarColor = True
        Me.PanelGrupo1.VerticalScrollbarHighlightOnWheel = False
        Me.PanelGrupo1.VerticalScrollbarSize = 10
        '
        'chkgrupo1
        '
        Me.chkgrupo1.AutoSize = True
        Me.chkgrupo1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkgrupo1.Location = New System.Drawing.Point(16, 14)
        Me.chkgrupo1.Name = "chkgrupo1"
        Me.chkgrupo1.Size = New System.Drawing.Size(103, 15)
        Me.chkgrupo1.TabIndex = 0
        Me.chkgrupo1.Text = "Cargar ensayos"
        Me.chkgrupo1.UseSelectable = True
        '
        'gbtq3
        '
        Me.gbtq3.BackColor = System.Drawing.Color.Transparent
        Me.gbtq3.Controls.Add(Me.panelGrupo2)
        Me.gbtq3.Controls.Add(Me.chkgrupo2)
        Me.gbtq3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtq3.ForeColor = Color.Black
        Me.gbtq3.Location = New System.Drawing.Point(318, 145)
        Me.gbtq3.Name = "gbtq3"
        Me.gbtq3.Size = New System.Drawing.Size(264, 362)
        Me.gbtq3.TabIndex = 2
        Me.gbtq3.TabStop = False
        Me.gbtq3.Text = "Ensayos en tanque"
        '
        'panelGrupo2
        '
        Me.panelGrupo2.Controls.Add(Me.gb3)
        Me.panelGrupo2.Controls.Add(Me.gb5)
        Me.panelGrupo2.Controls.Add(Me.gb4)
        Me.panelGrupo2.HorizontalScrollbarBarColor = True
        Me.panelGrupo2.HorizontalScrollbarHighlightOnWheel = False
        Me.panelGrupo2.HorizontalScrollbarSize = 10
        Me.panelGrupo2.Location = New System.Drawing.Point(6, 40)
        Me.panelGrupo2.Name = "panelGrupo2"
        Me.panelGrupo2.Size = New System.Drawing.Size(250, 295)
        Me.panelGrupo2.TabIndex = 58
        Me.panelGrupo2.VerticalScrollbarBarColor = True
        Me.panelGrupo2.VerticalScrollbarHighlightOnWheel = False
        Me.panelGrupo2.VerticalScrollbarSize = 10
        '
        'gb3
        '
        Me.gb3.Controls.Add(Me.txtcptqconc)
        Me.gb3.Controls.Add(Me.Label7)
        Me.gb3.Controls.Add(Me.Label8)
        Me.gb3.Controls.Add(Me.txtcptqseco)
        Me.gb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb3.ForeColor = Color.Black
        Me.gb3.Location = New System.Drawing.Point(9, 5)
        Me.gb3.Name = "gb3"
        Me.gb3.Size = New System.Drawing.Size(232, 84)
        Me.gb3.TabIndex = 0
        Me.gb3.TabStop = False
        Me.gb3.Text = "Concentración Pulpa Tanque Nº 3"
        '
        'txtcptqconc
        '
        '
        '
        '
        Me.txtcptqconc.CustomButton.Image = Nothing
        Me.txtcptqconc.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtcptqconc.CustomButton.Name = ""
        Me.txtcptqconc.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcptqconc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcptqconc.CustomButton.TabIndex = 1
        Me.txtcptqconc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcptqconc.CustomButton.UseSelectable = True
        Me.txtcptqconc.CustomButton.Visible = False
        Me.txtcptqconc.Lines = New String(-1) {}
        Me.txtcptqconc.Location = New System.Drawing.Point(125, 45)
        Me.txtcptqconc.MaxLength = 32767
        Me.txtcptqconc.Name = "txtcptqconc"
        Me.txtcptqconc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcptqconc.ReadOnly = True
        Me.txtcptqconc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcptqconc.SelectedText = ""
        Me.txtcptqconc.SelectionLength = 0
        Me.txtcptqconc.SelectionStart = 0
        Me.txtcptqconc.ShortcutsEnabled = True
        Me.txtcptqconc.Size = New System.Drawing.Size(75, 20)
        Me.txtcptqconc.TabIndex = 1
        Me.txtcptqconc.UseSelectable = True
        Me.txtcptqconc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcptqconc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(6, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Concentración(%):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(6, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Peso seco (gr):"
        '
        'txtcptqseco
        '
        '
        '
        '
        Me.txtcptqseco.CustomButton.Image = Nothing
        Me.txtcptqseco.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtcptqseco.CustomButton.Name = ""
        Me.txtcptqseco.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcptqseco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcptqseco.CustomButton.TabIndex = 1
        Me.txtcptqseco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcptqseco.CustomButton.UseSelectable = True
        Me.txtcptqseco.CustomButton.Visible = False
        Me.txtcptqseco.Lines = New String(-1) {}
        Me.txtcptqseco.Location = New System.Drawing.Point(125, 20)
        Me.txtcptqseco.MaxLength = 32767
        Me.txtcptqseco.Name = "txtcptqseco"
        Me.txtcptqseco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcptqseco.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcptqseco.SelectedText = ""
        Me.txtcptqseco.SelectionLength = 0
        Me.txtcptqseco.SelectionStart = 0
        Me.txtcptqseco.ShortcutsEnabled = True
        Me.txtcptqseco.Size = New System.Drawing.Size(75, 20)
        Me.txtcptqseco.TabIndex = 0
        Me.txtcptqseco.UseSelectable = True
        Me.txtcptqseco.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcptqseco.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'gb5
        '
        Me.gb5.Controls.Add(Me.dtensayo)
        Me.gb5.Controls.Add(Me.txtensayo)
        Me.gb5.Controls.Add(Me.Label11)
        Me.gb5.Controls.Add(Me.Label19)
        Me.gb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb5.ForeColor = Color.Black
        Me.gb5.Location = New System.Drawing.Point(9, 202)
        Me.gb5.Name = "gb5"
        Me.gb5.Size = New System.Drawing.Size(232, 79)
        Me.gb5.TabIndex = 2
        Me.gb5.TabStop = False
        Me.gb5.Text = "Ensayo en Blanco Segundos Drenaje"
        '
        'dtensayo
        '
        Me.dtensayo.CustomFormat = "HH:mm"
        Me.dtensayo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtensayo.Location = New System.Drawing.Point(125, 21)
        Me.dtensayo.MinimumSize = New System.Drawing.Size(4, 25)
        Me.dtensayo.Name = "dtensayo"
        Me.dtensayo.Size = New System.Drawing.Size(75, 25)
        Me.dtensayo.TabIndex = 0
        Me.dtensayo.UseWaitCursor = True
        '
        'txtensayo
        '
        '
        '
        '
        Me.txtensayo.CustomButton.Image = Nothing
        Me.txtensayo.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtensayo.CustomButton.Name = ""
        Me.txtensayo.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtensayo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtensayo.CustomButton.TabIndex = 1
        Me.txtensayo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtensayo.CustomButton.UseSelectable = True
        Me.txtensayo.CustomButton.Visible = False
        Me.txtensayo.Lines = New String(-1) {}
        Me.txtensayo.Location = New System.Drawing.Point(125, 50)
        Me.txtensayo.MaxLength = 32767
        Me.txtensayo.Name = "txtensayo"
        Me.txtensayo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtensayo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtensayo.SelectedText = ""
        Me.txtensayo.SelectionLength = 0
        Me.txtensayo.SelectionStart = 0
        Me.txtensayo.ShortcutsEnabled = True
        Me.txtensayo.Size = New System.Drawing.Size(75, 20)
        Me.txtensayo.TabIndex = 1
        Me.txtensayo.UseSelectable = True
        Me.txtensayo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtensayo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(16, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 15)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Hora:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(16, 54)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 15)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Tiempo (seg):"
        '
        'gb4
        '
        Me.gb4.Controls.Add(Me.Label20)
        Me.gb4.Controls.Add(Me.Label21)
        Me.gb4.Controls.Add(Me.Label22)
        Me.gb4.Controls.Add(Me.txtsdtqsd)
        Me.gb4.Controls.Add(Me.txtsdtqseco)
        Me.gb4.Controls.Add(Me.txtsdtqtiempo)
        Me.gb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb4.ForeColor = Color.Black
        Me.gb4.Location = New System.Drawing.Point(9, 95)
        Me.gb4.Name = "gb4"
        Me.gb4.Size = New System.Drawing.Size(232, 101)
        Me.gb4.TabIndex = 1
        Me.gb4.TabStop = False
        Me.gb4.Text = "Segundos de Drenaje Tanque Nº 3"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(16, 27)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 15)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Peso seco (gr):"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(16, 77)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(24, 15)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "SD:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label22.Location = New System.Drawing.Point(16, 52)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 15)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Tiempo (seg):"
        '
        'txtsdtqsd
        '
        '
        '
        '
        Me.txtsdtqsd.CustomButton.Image = Nothing
        Me.txtsdtqsd.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtsdtqsd.CustomButton.Name = ""
        Me.txtsdtqsd.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsdtqsd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsdtqsd.CustomButton.TabIndex = 1
        Me.txtsdtqsd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsdtqsd.CustomButton.UseSelectable = True
        Me.txtsdtqsd.CustomButton.Visible = False
        Me.txtsdtqsd.Lines = New String(-1) {}
        Me.txtsdtqsd.Location = New System.Drawing.Point(125, 71)
        Me.txtsdtqsd.MaxLength = 32767
        Me.txtsdtqsd.Name = "txtsdtqsd"
        Me.txtsdtqsd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsdtqsd.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsdtqsd.SelectedText = ""
        Me.txtsdtqsd.SelectionLength = 0
        Me.txtsdtqsd.SelectionStart = 0
        Me.txtsdtqsd.ShortcutsEnabled = True
        Me.txtsdtqsd.Size = New System.Drawing.Size(75, 20)
        Me.txtsdtqsd.TabIndex = 2
        Me.txtsdtqsd.UseSelectable = True
        Me.txtsdtqsd.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsdtqsd.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtsdtqseco
        '
        '
        '
        '
        Me.txtsdtqseco.CustomButton.Image = Nothing
        Me.txtsdtqseco.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtsdtqseco.CustomButton.Name = ""
        Me.txtsdtqseco.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsdtqseco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsdtqseco.CustomButton.TabIndex = 1
        Me.txtsdtqseco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsdtqseco.CustomButton.UseSelectable = True
        Me.txtsdtqseco.CustomButton.Visible = False
        Me.txtsdtqseco.Lines = New String(-1) {}
        Me.txtsdtqseco.Location = New System.Drawing.Point(125, 20)
        Me.txtsdtqseco.MaxLength = 32767
        Me.txtsdtqseco.Name = "txtsdtqseco"
        Me.txtsdtqseco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsdtqseco.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsdtqseco.SelectedText = ""
        Me.txtsdtqseco.SelectionLength = 0
        Me.txtsdtqseco.SelectionStart = 0
        Me.txtsdtqseco.ShortcutsEnabled = True
        Me.txtsdtqseco.Size = New System.Drawing.Size(75, 20)
        Me.txtsdtqseco.TabIndex = 0
        Me.txtsdtqseco.UseSelectable = True
        Me.txtsdtqseco.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsdtqseco.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtsdtqtiempo
        '
        '
        '
        '
        Me.txtsdtqtiempo.CustomButton.Image = Nothing
        Me.txtsdtqtiempo.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtsdtqtiempo.CustomButton.Name = ""
        Me.txtsdtqtiempo.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsdtqtiempo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsdtqtiempo.CustomButton.TabIndex = 1
        Me.txtsdtqtiempo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsdtqtiempo.CustomButton.UseSelectable = True
        Me.txtsdtqtiempo.CustomButton.Visible = False
        Me.txtsdtqtiempo.Lines = New String(-1) {}
        Me.txtsdtqtiempo.Location = New System.Drawing.Point(125, 45)
        Me.txtsdtqtiempo.MaxLength = 32767
        Me.txtsdtqtiempo.Name = "txtsdtqtiempo"
        Me.txtsdtqtiempo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsdtqtiempo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsdtqtiempo.SelectedText = ""
        Me.txtsdtqtiempo.SelectionLength = 0
        Me.txtsdtqtiempo.SelectionStart = 0
        Me.txtsdtqtiempo.ShortcutsEnabled = True
        Me.txtsdtqtiempo.Size = New System.Drawing.Size(75, 20)
        Me.txtsdtqtiempo.TabIndex = 1
        Me.txtsdtqtiempo.UseSelectable = True
        Me.txtsdtqtiempo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsdtqtiempo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkgrupo2
        '
        Me.chkgrupo2.AutoSize = True
        Me.chkgrupo2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkgrupo2.Location = New System.Drawing.Point(15, 14)
        Me.chkgrupo2.Name = "chkgrupo2"
        Me.chkgrupo2.Size = New System.Drawing.Size(103, 15)
        Me.chkgrupo2.TabIndex = 0
        Me.chkgrupo2.Text = "Cargar ensayos"
        Me.chkgrupo2.UseSelectable = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(37, 581)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 1
        Me.TabControl1.Size = New System.Drawing.Size(545, 172)
        Me.TabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.TabControl1.TabIndex = 56
        Me.TabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgEnsayos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(537, 130)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ensayos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgEnsayos
        '
        Me.dgEnsayos.AllowUserToAddRows = False
        Me.dgEnsayos.AllowUserToDeleteRows = False
        Me.dgEnsayos.AllowUserToResizeRows = False
        Me.dgEnsayos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgEnsayos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEnsayos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgEnsayos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEnsayos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgEnsayos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgEnsayos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgEnsayos.EnableHeadersVisualStyles = False
        Me.dgEnsayos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgEnsayos.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgEnsayos.Location = New System.Drawing.Point(3, 3)
        Me.dgEnsayos.MultiSelect = False
        Me.dgEnsayos.Name = "dgEnsayos"
        Me.dgEnsayos.ReadOnly = True
        Me.dgEnsayos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEnsayos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgEnsayos.RowHeadersVisible = False
        Me.dgEnsayos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgEnsayos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEnsayos.Size = New System.Drawing.Size(531, 124)
        Me.dgEnsayos.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgEnsayos.TabIndex = 0
        Me.dgEnsayos.UseCustomBackColor = True
        Me.dgEnsayos.UseCustomForeColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgtq3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(537, 130)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tanque 3"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgtq3
        '
        Me.dgtq3.AllowUserToAddRows = False
        Me.dgtq3.AllowUserToDeleteRows = False
        Me.dgtq3.AllowUserToResizeRows = False
        Me.dgtq3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgtq3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgtq3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgtq3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgtq3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtq3.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgtq3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgtq3.EnableHeadersVisualStyles = False
        Me.dgtq3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgtq3.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgtq3.Location = New System.Drawing.Point(3, 3)
        Me.dgtq3.MultiSelect = False
        Me.dgtq3.Name = "dgtq3"
        Me.dgtq3.ReadOnly = True
        Me.dgtq3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgtq3.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgtq3.RowHeadersVisible = False
        Me.dgtq3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgtq3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtq3.Size = New System.Drawing.Size(531, 124)
        Me.dgtq3.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgtq3.TabIndex = 0
        Me.dgtq3.UseCustomBackColor = True
        Me.dgtq3.UseCustomForeColor = True
        '
        'encabezado
        '
        Me.encabezado.Controls.Add(Me.cbmaterial)
        Me.encabezado.Controls.Add(Me.Label3)
        Me.encabezado.Controls.Add(Me.cbmc)
        Me.encabezado.Controls.Add(Me.cbturno)
        Me.encabezado.Controls.Add(Me.dtencabezado)
        Me.encabezado.Controls.Add(Me.Label1)
        Me.encabezado.Controls.Add(Me.Label2)
        Me.encabezado.Controls.Add(Me.cbgrupo)
        Me.encabezado.Controls.Add(Me.Label4)
        Me.encabezado.Controls.Add(Me.Label16)
        Me.encabezado.HorizontalScrollbarBarColor = True
        Me.encabezado.HorizontalScrollbarHighlightOnWheel = False
        Me.encabezado.HorizontalScrollbarSize = 10
        Me.encabezado.Location = New System.Drawing.Point(33, 63)
        Me.encabezado.Name = "encabezado"
        Me.encabezado.Size = New System.Drawing.Size(545, 67)
        Me.encabezado.TabIndex = 0
        Me.encabezado.VerticalScrollbarBarColor = True
        Me.encabezado.VerticalScrollbarHighlightOnWheel = False
        Me.encabezado.VerticalScrollbarSize = 10
        '
        'McEnsayos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 780)
        Me.Controls.Add(Me.encabezado)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.gbtq3)
        Me.Controls.Add(Me.gbensayo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Name = "McEnsayos"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Ensayos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbensayo.ResumeLayout(False)
        Me.gbensayo.PerformLayout()
        Me.PanelGrupo1.ResumeLayout(False)
        Me.gbtq3.ResumeLayout(False)
        Me.gbtq3.PerformLayout()
        Me.panelGrupo2.ResumeLayout(False)
        Me.gb3.ResumeLayout(False)
        Me.gb3.PerformLayout()
        Me.gb5.ResumeLayout(False)
        Me.gb5.PerformLayout()
        Me.gb4.ResumeLayout(False)
        Me.gb4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgEnsayos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgtq3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.encabezado.ResumeLayout(False)
        Me.encabezado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbmc As MetroComboBox
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents cbmaterial As MetroComboBox
    Friend WithEvents txtcpseco As MetroTextBox
    Friend WithEvents txtcpconc As MetroTextBox
    Friend WithEvents txtsdsd As MetroTextBox
    Friend WithEvents txtshhhumedo As MetroTextBox
    Friend WithEvents txtshhseco As MetroTextBox
    Friend WithEvents txtshhsequedad As MetroTextBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents Label9 As MetroLabel
    Friend WithEvents Label12 As MetroLabel
    Friend WithEvents Label13 As MetroLabel
    Friend WithEvents Label14 As MetroLabel
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents Label15 As MetroLabel
    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents Label16 As MetroLabel
    Friend WithEvents dtencabezado As MetroDateTime
    Friend WithEvents Label17 As MetroLabel
    Friend WithEvents Label18 As MetroLabel
    Friend WithEvents txtsdtiempo As MetroTextBox
    Friend WithEvents txtsdseco As MetroTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents gbensayo As System.Windows.Forms.GroupBox
    Friend WithEvents gbtq3 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As MetroTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgtq3 As MetroGrid
    Friend WithEvents chkgrupo2 As MetroCheckBox
    Friend WithEvents gb3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcptqconc As MetroTextBox
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents txtcptqseco As MetroTextBox
    Friend WithEvents gb5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtensayo As MetroTextBox
    Friend WithEvents Label11 As MetroLabel
    Friend WithEvents Label19 As MetroLabel
    Friend WithEvents gb4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As MetroLabel
    Friend WithEvents Label21 As MetroLabel
    Friend WithEvents Label22 As MetroLabel
    Friend WithEvents txtsdtqsd As MetroTextBox
    Friend WithEvents txtsdtqseco As MetroTextBox
    Friend WithEvents txtsdtqtiempo As MetroTextBox
    Friend WithEvents panelGrupo2 As MetroPanel
    Friend WithEvents PanelGrupo1 As MetroPanel
    Friend WithEvents chkgrupo1 As MetroCheckBox
    Friend WithEvents encabezado As MetroPanel
    Friend WithEvents dgEnsayos As MetroGrid
    Friend WithEvents dtensayo As DateTimePicker
End Class
