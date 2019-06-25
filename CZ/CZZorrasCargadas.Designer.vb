Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CZZorrasCargadas
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
        Me.cblinea = New MetroFramework.Controls.MetroComboBox()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.cbmaterial = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.Label15 = New MetroFramework.Controls.MetroLabel()
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
        Me.encabezado = New MetroFramework.Controls.MetroPanel()
        Me.pnldefectos = New MetroFramework.Controls.MetroPanel()
        Me.chkdef3 = New MetroFramework.Controls.MetroCheckBox()
        Me.chkdef2 = New MetroFramework.Controls.MetroCheckBox()
        Me.cbdefecto3 = New MetroFramework.Controls.MetroComboBox()
        Me.Label20 = New MetroFramework.Controls.MetroLabel()
        Me.cbdefecto1 = New MetroFramework.Controls.MetroComboBox()
        Me.cbdefecto2 = New MetroFramework.Controls.MetroComboBox()
        Me.cbcalid = New MetroFramework.Controls.MetroComboBox()
        Me.Label19 = New MetroFramework.Controls.MetroLabel()
        Me.chkdeco = New MetroFramework.Controls.MetroCheckBox()
        Me.dthora = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.txtcantid = New MetroFramework.Controls.MetroTextBox()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.cbzorra = New MetroFramework.Controls.MetroComboBox()
        Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.dglineaI = New MetroFramework.Controls.MetroGrid()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.dglineaII = New MetroFramework.Controls.MetroGrid()
        Me.encabezado.SuspendLayout()
        Me.pnldefectos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dglineaI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dglineaII, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cblinea
        '
        Me.cblinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cblinea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cblinea.FormattingEnabled = True
        Me.cblinea.ItemHeight = 19
        Me.cblinea.Items.AddRange(New Object() {"1", "2"})
        Me.cblinea.Location = New System.Drawing.Point(12, 28)
        Me.cblinea.Name = "cblinea"
        Me.cblinea.Size = New System.Drawing.Size(56, 25)
        Me.cblinea.Style = MetroFramework.MetroColorStyle.Brown
        Me.cblinea.TabIndex = 0
        Me.cblinea.UseCustomBackColor = True
        Me.cblinea.UseCustomForeColor = True
        Me.cblinea.UseSelectable = True
        Me.cblinea.UseStyleColors = True
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(88, 28)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(56, 25)
        Me.cbturno.Style = MetroFramework.MetroColorStyle.Brown
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
        Me.cbgrupo.Location = New System.Drawing.Point(170, 28)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(56, 25)
        Me.cbgrupo.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbgrupo.TabIndex = 2
        Me.cbgrupo.UseSelectable = True
        '
        'cbmaterial
        '
        Me.cbmaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmaterial.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmaterial.FormattingEnabled = True
        Me.cbmaterial.ItemHeight = 19
        Me.cbmaterial.Location = New System.Drawing.Point(151, 79)
        Me.cbmaterial.Name = "cbmaterial"
        Me.cbmaterial.Size = New System.Drawing.Size(56, 25)
        Me.cbmaterial.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbmaterial.TabIndex = 4
        Me.cbmaterial.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(14, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Línea: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(91, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(177, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(147, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Material:"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(39, 344)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 11
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(132, 344)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 10
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(425, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 19)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Fecha:"
        '
        'dtfecha
        '
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(477, 25)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(92, 25)
        Me.dtfecha.TabIndex = 1
        '
        'encabezado
        '
        Me.encabezado.Controls.Add(Me.pnldefectos)
        Me.encabezado.Controls.Add(Me.cbcalid)
        Me.encabezado.Controls.Add(Me.Label19)
        Me.encabezado.Controls.Add(Me.chkdeco)
        Me.encabezado.Controls.Add(Me.dthora)
        Me.encabezado.Controls.Add(Me.btnguardar)
        Me.encabezado.Controls.Add(Me.Label11)
        Me.encabezado.Controls.Add(Me.btncancelar)
        Me.encabezado.Controls.Add(Me.txtcantid)
        Me.encabezado.Controls.Add(Me.Label10)
        Me.encabezado.Controls.Add(Me.Label8)
        Me.encabezado.Controls.Add(Me.cbzorra)
        Me.encabezado.Controls.Add(Me.cbmaterial)
        Me.encabezado.Controls.Add(Me.Label3)
        Me.encabezado.Controls.Add(Me.cblinea)
        Me.encabezado.Controls.Add(Me.cbturno)
        Me.encabezado.Controls.Add(Me.Label1)
        Me.encabezado.Controls.Add(Me.Label2)
        Me.encabezado.Controls.Add(Me.cbgrupo)
        Me.encabezado.Controls.Add(Me.Label4)
        Me.encabezado.HorizontalScrollbarBarColor = True
        Me.encabezado.HorizontalScrollbarHighlightOnWheel = False
        Me.encabezado.HorizontalScrollbarSize = 10
        Me.encabezado.Location = New System.Drawing.Point(35, 60)
        Me.encabezado.Name = "encabezado"
        Me.encabezado.Size = New System.Drawing.Size(260, 380)
        Me.encabezado.TabIndex = 0
        Me.encabezado.VerticalScrollbarBarColor = True
        Me.encabezado.VerticalScrollbarHighlightOnWheel = False
        Me.encabezado.VerticalScrollbarSize = 10
        '
        'pnldefectos
        '
        Me.pnldefectos.Controls.Add(Me.chkdef3)
        Me.pnldefectos.Controls.Add(Me.chkdef2)
        Me.pnldefectos.Controls.Add(Me.cbdefecto3)
        Me.pnldefectos.Controls.Add(Me.Label20)
        Me.pnldefectos.Controls.Add(Me.cbdefecto1)
        Me.pnldefectos.Controls.Add(Me.cbdefecto2)
        Me.pnldefectos.HorizontalScrollbarBarColor = True
        Me.pnldefectos.HorizontalScrollbarHighlightOnWheel = False
        Me.pnldefectos.HorizontalScrollbarSize = 10
        Me.pnldefectos.Location = New System.Drawing.Point(3, 238)
        Me.pnldefectos.Name = "pnldefectos"
        Me.pnldefectos.Size = New System.Drawing.Size(257, 100)
        Me.pnldefectos.TabIndex = 9
        Me.pnldefectos.VerticalScrollbarBarColor = True
        Me.pnldefectos.VerticalScrollbarHighlightOnWheel = False
        Me.pnldefectos.VerticalScrollbarSize = 10
        '
        'chkdef3
        '
        Me.chkdef3.AutoSize = True
        Me.chkdef3.Enabled = False
        Me.chkdef3.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkdef3.Location = New System.Drawing.Point(11, 73)
        Me.chkdef3.Name = "chkdef3"
        Me.chkdef3.Size = New System.Drawing.Size(84, 19)
        Me.chkdef3.TabIndex = 4
        Me.chkdef3.Text = "Defecto 3"
        Me.chkdef3.UseSelectable = True
        '
        'chkdef2
        '
        Me.chkdef2.AutoSize = True
        Me.chkdef2.Enabled = False
        Me.chkdef2.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkdef2.Location = New System.Drawing.Point(9, 48)
        Me.chkdef2.Name = "chkdef2"
        Me.chkdef2.Size = New System.Drawing.Size(84, 19)
        Me.chkdef2.Style = MetroFramework.MetroColorStyle.Brown
        Me.chkdef2.TabIndex = 2
        Me.chkdef2.Text = "Defecto 2"
        Me.chkdef2.UseSelectable = True
        '
        'cbdefecto3
        '
        Me.cbdefecto3.Enabled = False
        Me.cbdefecto3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbdefecto3.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbdefecto3.FormattingEnabled = True
        Me.cbdefecto3.ItemHeight = 19
        Me.cbdefecto3.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbdefecto3.Location = New System.Drawing.Point(110, 69)
        Me.cbdefecto3.Name = "cbdefecto3"
        Me.cbdefecto3.Size = New System.Drawing.Size(133, 25)
        Me.cbdefecto3.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbdefecto3.TabIndex = 5
        Me.cbdefecto3.UseSelectable = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(3, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 19)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Defecto 1:"
        '
        'cbdefecto1
        '
        Me.cbdefecto1.Enabled = False
        Me.cbdefecto1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbdefecto1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbdefecto1.FormattingEnabled = True
        Me.cbdefecto1.ItemHeight = 19
        Me.cbdefecto1.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbdefecto1.Location = New System.Drawing.Point(110, 7)
        Me.cbdefecto1.Name = "cbdefecto1"
        Me.cbdefecto1.Size = New System.Drawing.Size(133, 25)
        Me.cbdefecto1.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbdefecto1.TabIndex = 1
        Me.cbdefecto1.UseSelectable = True
        '
        'cbdefecto2
        '
        Me.cbdefecto2.Enabled = False
        Me.cbdefecto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbdefecto2.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbdefecto2.FormattingEnabled = True
        Me.cbdefecto2.ItemHeight = 19
        Me.cbdefecto2.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbdefecto2.Location = New System.Drawing.Point(110, 38)
        Me.cbdefecto2.Name = "cbdefecto2"
        Me.cbdefecto2.Size = New System.Drawing.Size(133, 25)
        Me.cbdefecto2.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbdefecto2.TabIndex = 3
        Me.cbdefecto2.UseSelectable = True
        '
        'cbcalid
        '
        Me.cbcalid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbcalid.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbcalid.FormattingEnabled = True
        Me.cbcalid.ItemHeight = 19
        Me.cbcalid.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbcalid.Location = New System.Drawing.Point(75, 207)
        Me.cbcalid.Name = "cbcalid"
        Me.cbcalid.Size = New System.Drawing.Size(138, 25)
        Me.cbcalid.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbcalid.TabIndex = 8
        Me.cbcalid.UseSelectable = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(11, 213)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 19)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "Calidad:"
        '
        'chkdeco
        '
        Me.chkdeco.AutoSize = True
        Me.chkdeco.Location = New System.Drawing.Point(14, 186)
        Me.chkdeco.Name = "chkdeco"
        Me.chkdeco.Size = New System.Drawing.Size(80, 15)
        Me.chkdeco.TabIndex = 7
        Me.chkdeco.Text = "Decorativo"
        Me.chkdeco.UseSelectable = True
        '
        'dthora
        '
        Me.dthora.CustomFormat = "HH:mm"
        Me.dthora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dthora.Location = New System.Drawing.Point(151, 150)
        Me.dthora.Name = "dthora"
        Me.dthora.Size = New System.Drawing.Size(49, 20)
        Me.dthora.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(14, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 33)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Hora Salida:"
        '
        'txtcantid
        '
        '
        '
        '
        Me.txtcantid.CustomButton.Image = Nothing
        Me.txtcantid.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtcantid.CustomButton.Name = ""
        Me.txtcantid.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcantid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcantid.CustomButton.TabIndex = 1
        Me.txtcantid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcantid.CustomButton.UseSelectable = True
        Me.txtcantid.CustomButton.Visible = False
        Me.txtcantid.Lines = New String(-1) {}
        Me.txtcantid.Location = New System.Drawing.Point(151, 117)
        Me.txtcantid.MaxLength = 32767
        Me.txtcantid.Name = "txtcantid"
        Me.txtcantid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcantid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcantid.SelectedText = ""
        Me.txtcantid.SelectionLength = 0
        Me.txtcantid.SelectionStart = 0
        Me.txtcantid.ShortcutsEnabled = True
        Me.txtcantid.Size = New System.Drawing.Size(56, 20)
        Me.txtcantid.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtcantid.TabIndex = 5
        Me.txtcantid.UseSelectable = True
        Me.txtcantid.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcantid.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(12, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 33)
        Me.Label10.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Cantidad Tableros:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(14, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 19)
        Me.Label8.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Nº Zorra:"
        '
        'cbzorra
        '
        Me.cbzorra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbzorra.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbzorra.FormattingEnabled = True
        Me.cbzorra.ItemHeight = 19
        Me.cbzorra.Location = New System.Drawing.Point(14, 79)
        Me.cbzorra.Name = "cbzorra"
        Me.cbzorra.Size = New System.Drawing.Size(90, 25)
        Me.cbzorra.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbzorra.TabIndex = 3
        Me.cbzorra.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dglineaI)
        Me.TabPage1.HorizontalScrollbarBarColor = True
        Me.TabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage1.HorizontalScrollbarSize = 10
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(594, 247)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Línea I"
        Me.TabPage1.UseVisualStyleBackColor = True
        Me.TabPage1.VerticalScrollbarBarColor = True
        Me.TabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage1.VerticalScrollbarSize = 10
        '
        'dglineaI
        '
        Me.dglineaI.AllowUserToAddRows = False
        Me.dglineaI.AllowUserToDeleteRows = False
        Me.dglineaI.AllowUserToResizeRows = False
        Me.dglineaI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dglineaI.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dglineaI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dglineaI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dglineaI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dglineaI.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dglineaI.DefaultCellStyle = DataGridViewCellStyle2
        Me.dglineaI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dglineaI.EnableHeadersVisualStyles = False
        Me.dglineaI.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dglineaI.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dglineaI.Location = New System.Drawing.Point(3, 3)
        Me.dglineaI.MultiSelect = False
        Me.dglineaI.Name = "dglineaI"
        Me.dglineaI.ReadOnly = True
        Me.dglineaI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dglineaI.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dglineaI.RowHeadersVisible = False
        Me.dglineaI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dglineaI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dglineaI.Size = New System.Drawing.Size(588, 241)
        Me.dglineaI.Style = MetroFramework.MetroColorStyle.Brown
        Me.dglineaI.TabIndex = 2
        Me.dglineaI.UseCustomBackColor = True
        Me.dglineaI.UseCustomForeColor = True
        Me.dglineaI.UseStyleColors = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(318, 60)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(602, 289)
        Me.TabControl1.Style = MetroFramework.MetroColorStyle.Brown
        Me.TabControl1.TabIndex = 56
        Me.TabControl1.UseCustomBackColor = True
        Me.TabControl1.UseCustomForeColor = True
        Me.TabControl1.UseSelectable = True
        Me.TabControl1.UseStyleColors = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dglineaII)
        Me.TabPage2.HorizontalScrollbarBarColor = True
        Me.TabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage2.HorizontalScrollbarSize = 10
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(594, 247)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Línea II"
        Me.TabPage2.UseVisualStyleBackColor = True
        Me.TabPage2.VerticalScrollbarBarColor = True
        Me.TabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage2.VerticalScrollbarSize = 10
        '
        'dglineaII
        '
        Me.dglineaII.AllowUserToAddRows = False
        Me.dglineaII.AllowUserToDeleteRows = False
        Me.dglineaII.AllowUserToResizeRows = False
        Me.dglineaII.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dglineaII.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dglineaII.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dglineaII.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dglineaII.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dglineaII.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dglineaII.DefaultCellStyle = DataGridViewCellStyle5
        Me.dglineaII.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dglineaII.EnableHeadersVisualStyles = False
        Me.dglineaII.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dglineaII.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dglineaII.Location = New System.Drawing.Point(3, 3)
        Me.dglineaII.MultiSelect = False
        Me.dglineaII.Name = "dglineaII"
        Me.dglineaII.ReadOnly = True
        Me.dglineaII.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dglineaII.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dglineaII.RowHeadersVisible = False
        Me.dglineaII.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dglineaII.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dglineaII.Size = New System.Drawing.Size(588, 241)
        Me.dglineaII.Style = MetroFramework.MetroColorStyle.Brown
        Me.dglineaII.TabIndex = 1
        Me.dglineaII.UseCustomBackColor = True
        Me.dglineaII.UseCustomForeColor = True
        Me.dglineaII.UseStyleColors = True
        '
        'CZZorrasCargadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(943, 450)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.encabezado)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "CZZorrasCargadas"
        Me.Style = MetroFramework.MetroColorStyle.Brown
        Me.Text = "Tableros cargados"
        Me.encabezado.ResumeLayout(False)
        Me.encabezado.PerformLayout()
        Me.pnldefectos.ResumeLayout(False)
        Me.pnldefectos.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dglineaI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dglineaII, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cblinea As MetroComboBox
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents cbmaterial As MetroComboBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents Label15 As MetroLabel
    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents encabezado As MetroPanel
    Friend WithEvents TabPage1 As MetroTabPage
    Friend WithEvents dglineaI As MetroGrid
    Friend WithEvents txtcantid As MetroTextBox
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents cbzorra As MetroComboBox
    Friend WithEvents dthora As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As MetroLabel
    Friend WithEvents cbdefecto1 As MetroComboBox
    Friend WithEvents Label20 As MetroLabel
    Friend WithEvents cbcalid As MetroComboBox
    Friend WithEvents Label19 As MetroLabel
    Friend WithEvents chkdeco As MetroCheckBox
    Friend WithEvents cbdefecto3 As MetroComboBox
    Friend WithEvents cbdefecto2 As MetroComboBox
    Friend WithEvents pnldefectos As MetroPanel
    Friend WithEvents chkdef3 As MetroCheckBox
    Friend WithEvents chkdef2 As MetroCheckBox
    Friend WithEvents TabPage2 As MetroTabPage
    Friend WithEvents dglineaII As MetroGrid
    Friend WithEvents TabControl1 As MetroTabControl
    Friend WithEvents Label10 As MetroLabel
End Class
