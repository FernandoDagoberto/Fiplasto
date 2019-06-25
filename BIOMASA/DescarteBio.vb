Imports System.Data.SqlClient
Imports MetroFramework
Imports MetroFramework.Controls
Imports SPIF

Public Class DescarteBio
    Inherits MetroFramework.Forms.MetroForm


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents MetroPanel1 As MetroPanel

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DescarteBio))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dgPendientes = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dtFechaPesada = New MetroFramework.Controls.MetroDateTime()
        Me.txtDescarte = New MetroFramework.Controls.MetroTextBox()
        Me.cmdcancelar = New MetroFramework.Controls.MetroButton()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.cmdGuardar = New MetroFramework.Controls.MetroButton()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.cbGrupo = New MetroFramework.Controls.MetroComboBox()
        Me.cbTurno = New MetroFramework.Controls.MetroComboBox()
        Me.txtTicket = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.dtFechaPicado = New MetroFramework.Controls.MetroDateTime()
        Me.txtNeto = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        CType(Me.dgPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        Me.ImageList1.Images.SetKeyName(14, "")
        Me.ImageList1.Images.SetKeyName(15, "")
        Me.ImageList1.Images.SetKeyName(16, "")
        Me.ImageList1.Images.SetKeyName(17, "")
        Me.ImageList1.Images.SetKeyName(18, "")
        Me.ImageList1.Images.SetKeyName(19, "")
        Me.ImageList1.Images.SetKeyName(20, "")
        Me.ImageList1.Images.SetKeyName(21, "")
        Me.ImageList1.Images.SetKeyName(22, "")
        '
        'dgPendientes
        '
        Me.dgPendientes.AllowUserToAddRows = False
        Me.dgPendientes.AllowUserToDeleteRows = False
        Me.dgPendientes.AllowUserToResizeColumns = False
        Me.dgPendientes.AllowUserToResizeRows = False
        Me.dgPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPendientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgPendientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPendientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPendientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgPendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPendientes.EnableHeadersVisualStyles = False
        Me.dgPendientes.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgPendientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgPendientes.Location = New System.Drawing.Point(0, 0)
        Me.dgPendientes.MultiSelect = False
        Me.dgPendientes.Name = "dgPendientes"
        Me.dgPendientes.ReadOnly = True
        Me.dgPendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPendientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgPendientes.RowHeadersVisible = False
        Me.dgPendientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPendientes.Size = New System.Drawing.Size(194, 278)
        Me.dgPendientes.Style = MetroFramework.MetroColorStyle.Red
        Me.dgPendientes.TabIndex = 0
        Me.dgPendientes.UseCustomBackColor = True
        Me.dgPendientes.UseCustomForeColor = True
        Me.dgPendientes.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroLabel1.Location = New System.Drawing.Point(239, 105)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel1.TabIndex = 55
        Me.MetroLabel1.Text = "Fecha pesada"
        '
        'dtFechaPesada
        '
        Me.dtFechaPesada.Enabled = False
        Me.dtFechaPesada.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtFechaPesada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaPesada.Location = New System.Drawing.Point(239, 128)
        Me.dtFechaPesada.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtFechaPesada.Name = "dtFechaPesada"
        Me.dtFechaPesada.Size = New System.Drawing.Size(98, 25)
        Me.dtFechaPesada.TabIndex = 54
        '
        'txtDescarte
        '
        '
        '
        '
        Me.txtDescarte.CustomButton.Image = Nothing
        Me.txtDescarte.CustomButton.Location = New System.Drawing.Point(253, 2)
        Me.txtDescarte.CustomButton.Name = ""
        Me.txtDescarte.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtDescarte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescarte.CustomButton.TabIndex = 1
        Me.txtDescarte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescarte.CustomButton.UseSelectable = True
        Me.txtDescarte.CustomButton.Visible = False
        Me.txtDescarte.Enabled = False
        Me.txtDescarte.Lines = New String(-1) {}
        Me.txtDescarte.Location = New System.Drawing.Point(239, 81)
        Me.txtDescarte.MaxLength = 32767
        Me.txtDescarte.Name = "txtDescarte"
        Me.txtDescarte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescarte.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescarte.SelectedText = ""
        Me.txtDescarte.SelectionLength = 0
        Me.txtDescarte.SelectionStart = 0
        Me.txtDescarte.ShortcutsEnabled = True
        Me.txtDescarte.Size = New System.Drawing.Size(271, 20)
        Me.txtDescarte.TabIndex = 53
        Me.txtDescarte.UseSelectable = True
        Me.txtDescarte.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescarte.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Location = New System.Drawing.Point(326, 304)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdcancelar.TabIndex = 52
        Me.cmdcancelar.Text = "&Cancelar"
        Me.cmdcancelar.UseSelectable = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(239, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 19)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Tipo Descarte:"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Enabled = False
        Me.cmdGuardar.Location = New System.Drawing.Point(431, 304)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 47
        Me.cmdGuardar.Text = "&Guardar"
        Me.cmdGuardar.UseSelectable = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(355, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 19)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Grupo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(239, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 19)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Turno"
        '
        'cbGrupo
        '
        Me.cbGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGrupo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbGrupo.FormattingEnabled = True
        Me.cbGrupo.ItemHeight = 19
        Me.cbGrupo.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.cbGrupo.Location = New System.Drawing.Point(355, 180)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(67, 25)
        Me.cbGrupo.TabIndex = 45
        Me.cbGrupo.UseSelectable = True
        '
        'cbTurno
        '
        Me.cbTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTurno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbTurno.FormattingEnabled = True
        Me.cbTurno.ItemHeight = 19
        Me.cbTurno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbTurno.Location = New System.Drawing.Point(239, 180)
        Me.cbTurno.Name = "cbTurno"
        Me.cbTurno.Size = New System.Drawing.Size(66, 25)
        Me.cbTurno.TabIndex = 44
        Me.cbTurno.UseSelectable = True
        '
        'txtTicket
        '
        '
        '
        '
        Me.txtTicket.CustomButton.Image = Nothing
        Me.txtTicket.CustomButton.Location = New System.Drawing.Point(69, 2)
        Me.txtTicket.CustomButton.Name = ""
        Me.txtTicket.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtTicket.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTicket.CustomButton.TabIndex = 1
        Me.txtTicket.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTicket.CustomButton.UseSelectable = True
        Me.txtTicket.CustomButton.Visible = False
        Me.txtTicket.Enabled = False
        Me.txtTicket.Lines = New String(-1) {}
        Me.txtTicket.Location = New System.Drawing.Point(355, 133)
        Me.txtTicket.MaxLength = 32767
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTicket.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTicket.SelectedText = ""
        Me.txtTicket.SelectionLength = 0
        Me.txtTicket.SelectionStart = 0
        Me.txtTicket.ShortcutsEnabled = True
        Me.txtTicket.Size = New System.Drawing.Size(87, 20)
        Me.txtTicket.TabIndex = 57
        Me.txtTicket.UseSelectable = True
        Me.txtTicket.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTicket.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroLabel2.Location = New System.Drawing.Point(355, 105)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel2.TabIndex = 56
        Me.MetroLabel2.Text = "Ticket:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroLabel3.Location = New System.Drawing.Point(239, 209)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel3.TabIndex = 59
        Me.MetroLabel3.Text = "Fecha picado"
        '
        'dtFechaPicado
        '
        Me.dtFechaPicado.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtFechaPicado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaPicado.Location = New System.Drawing.Point(239, 232)
        Me.dtFechaPicado.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtFechaPicado.Name = "dtFechaPicado"
        Me.dtFechaPicado.Size = New System.Drawing.Size(98, 25)
        Me.dtFechaPicado.TabIndex = 58
        '
        'txtNeto
        '
        '
        '
        '
        Me.txtNeto.CustomButton.Image = Nothing
        Me.txtNeto.CustomButton.Location = New System.Drawing.Point(69, 2)
        Me.txtNeto.CustomButton.Name = ""
        Me.txtNeto.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtNeto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNeto.CustomButton.TabIndex = 1
        Me.txtNeto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNeto.CustomButton.UseSelectable = True
        Me.txtNeto.CustomButton.Visible = False
        Me.txtNeto.Enabled = False
        Me.txtNeto.Lines = New String(-1) {}
        Me.txtNeto.Location = New System.Drawing.Point(465, 133)
        Me.txtNeto.MaxLength = 32767
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNeto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNeto.SelectedText = ""
        Me.txtNeto.SelectionLength = 0
        Me.txtNeto.SelectionStart = 0
        Me.txtNeto.ShortcutsEnabled = True
        Me.txtNeto.Size = New System.Drawing.Size(87, 20)
        Me.txtNeto.TabIndex = 61
        Me.txtNeto.UseSelectable = True
        Me.txtNeto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNeto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroLabel4.Location = New System.Drawing.Point(465, 105)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 60
        Me.MetroLabel4.Text = "Neto:"
        '
        'txtBuscar
        '
        '
        '
        '
        Me.txtBuscar.CustomButton.Image = Nothing
        Me.txtBuscar.CustomButton.Location = New System.Drawing.Point(176, 2)
        Me.txtBuscar.CustomButton.Name = ""
        Me.txtBuscar.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBuscar.CustomButton.TabIndex = 1
        Me.txtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBuscar.CustomButton.UseSelectable = True
        Me.txtBuscar.CustomButton.Visible = False
        Me.txtBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtBuscar.Lines = New String(-1) {}
        Me.txtBuscar.Location = New System.Drawing.Point(0, 19)
        Me.txtBuscar.MaxLength = 32767
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.SelectionLength = 0
        Me.txtBuscar.SelectionStart = 0
        Me.txtBuscar.ShortcutsEnabled = True
        Me.txtBuscar.Size = New System.Drawing.Size(194, 20)
        Me.txtBuscar.TabIndex = 59
        Me.txtBuscar.UseSelectable = True
        Me.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBuscar.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroLabel5.Location = New System.Drawing.Point(0, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel5.TabIndex = 58
        Me.MetroLabel5.Text = "Buscar ticket:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroPanel2)
        Me.GroupBox1.Controls.Add(Me.MetroPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 345)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pendientes"
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.dgPendientes)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(3, 64)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(194, 278)
        Me.MetroPanel2.TabIndex = 1
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.txtBuscar)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 18)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(194, 46)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'DescarteBio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(581, 410)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNeto)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.dtFechaPicado)
        Me.Controls.Add(Me.txtTicket)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dtFechaPesada)
        Me.Controls.Add(Me.txtDescarte)
        Me.Controls.Add(Me.cmdcancelar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbGrupo)
        Me.Controls.Add(Me.cbTurno)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DescarteBio"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Descarte Biomasa"
        CType(Me.dgPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


#End Region

    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents dtFechaPesada As MetroDateTime
    Friend WithEvents txtDescarte As MetroTextBox
    Friend WithEvents cmdcancelar As MetroButton
    Friend WithEvents Label9 As MetroLabel
    Friend WithEvents cmdGuardar As MetroButton
    Friend WithEvents Label11 As MetroLabel
    Friend WithEvents Label12 As MetroLabel
    Friend WithEvents cbGrupo As MetroComboBox
    Friend WithEvents cbTurno As MetroComboBox
    Friend WithEvents txtTicket As MetroTextBox
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents dtFechaPicado As MetroDateTime
    Friend WithEvents txtNeto As MetroTextBox
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents txtBuscar As MetroTextBox
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents dgPendientes As MetroGrid

    Public Property Registros As New List(Of BiomasaPeso)
    Public Property todosLosRegistros As New List(Of BiomasaPeso)

    Private Sub DescarteBio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Registros = GetRemitos()
        Llenodatagrid()
    End Sub

    Private Sub dgPendientes_Click(sender As Object, e As EventArgs) Handles dgPendientes.Click
        If dgPendientes.SelectedRows.Count = 1 Then
            linea = dgPendientes.CurrentRow.Cells("Ticket").Value
        End If
    End Sub

    Private Sub Llenodatagrid()
        Dim query = From cli In Registros
                    Where cli.FechaPicado Is Nothing
                    Order By cli.Ticket
                    Select cli.Ticket, cli.Neto

        dgPendientes.DataSource = query.ToList()
    End Sub

    Private Function GetRemitos() As List(Of BiomasaPeso)
        conex("BioPila")
        sql = "Select * from BioDescarte"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        For Each filas As DataRow In dt.Rows
            Dim registro = New BiomasaPeso
            registro.Ticket = filas("Ticket")
            registro.Codmad = filas("CodMad")
            registro.TipMad = filas("TipMad")
            registro.FechaPesada = filas("FechaPesada")
            registro.Neto = filas("Neto")

            If filas("FechaPicado") Is DBNull.Value Then
                registro.FechaPicado = Nothing
            Else
                registro.FechaPicado = filas("FechaPicado")
            End If

            If filas("Grupo") Is DBNull.Value Then
                registro.Grupo = Nothing
            Else
                registro.Grupo = filas("Grupo")
            End If

            If filas("Turno") Is DBNull.Value Then
                registro.Turno = Nothing
            Else
                registro.Turno = filas("Turno")
            End If

            todosLosRegistros.Add(registro)
        Next


        Return todosLosRegistros


    End Function

    Private Sub dgPendientes_DoubleClick(sender As Object, e As EventArgs) Handles dgPendientes.DoubleClick
        If dgPendientes.SelectedRows.Count = 1 Then

            Dim query = From cli In Registros
                        Where cli.Ticket = linea
                        Select cli

            With query.ToList().Item(0)
                dtFechaPesada.Value = .FechaPesada
                txtTicket.Text = .Ticket
                txtDescarte.Text = .TipMad
                txtNeto.Text = .Neto

            End With

            cmdGuardar.Enabled = True
        Else
            cmdGuardar.Enabled = False
        End If


    End Sub


    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        Dim query = From cli In Registros
                    Where cli.Ticket.Contains(txtBuscar.Text) And cli.FechaPicado Is Nothing
                    Order By cli.Ticket
                    Select cli.Ticket, cli.Neto

        dgPendientes.DataSource = query.ToList()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If String.IsNullOrEmpty(cbTurno.Text) Or String.IsNullOrEmpty(cbGrupo.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar turno y grupo", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            SQL3 = "Update BioDescarte set FechaPicado='" + dtFechaPicado.Value + "', " &
            " Turno='" + cbTurno.Text + "', " &
            " Grupo='" + cbGrupo.Text + "' " &
            " where Ticket='" + txtTicket.Text + "'"

            cmd3 = New SqlCommand(SQL3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()


            Dim previusProduct = From cli In Registros
                                 Where cli.Ticket = txtTicket.Text
                                 Select cli
            If (previusProduct IsNot Nothing) Then
                Registros.Remove(previusProduct.FirstOrDefault)

            End If
            Me.Llenodatagrid()
            limpiar()

        Catch ex As Exception
            MetroMessageBox.Show(Me, "No se pudieron guardar los datos en BIODESCARTE" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End Try

    End Sub

    Private Sub limpiar()
        txtDescarte.Text = Nothing
        txtNeto.Text = Nothing
        txtTicket.Text = Nothing
        cmdGuardar.Enabled = False
    End Sub

    Private Sub cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        limpiar()

    End Sub
End Class
