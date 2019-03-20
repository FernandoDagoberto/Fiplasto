Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports MetroFramework.Controls
Imports MetroFramework

Public Class PIModiMad

    Inherits MetroFramework.Forms.MetroForm

    Dim sql, sql1, sql2, sql3, sql4, sql5, tabla As String
    Dim da, da1, da3, da5 As New SqlDataAdapter
    Dim cmd, cmd2, cmd3, cmd4, cmd5 As SqlCommand
    Dim cmdACC As OleDbCommand
    Dim dt As DataTable = New DataTable
    Dim dt1 As DataTable = New DataTable
    Dim dt3 As DataTable = New DataTable
    Dim dt5 As DataTable = New DataTable
    Dim TextCol1 As New DataGridTextBoxColumn
    Dim TextCol2 As New DataGridTextBoxColumn

    Dim sen, sen1, sen2, campos, variables, idl, dias As String
    Dim conforme, destino, rechazado As String
    Dim pendiente, reporte As String
    Dim line, ms As Integer
    Dim CodMadPortertia As Integer
    Dim TipMadPorteria As String
    Dim mensaje As String
    Dim alerta As String

    Dim cargamanual As String

    Friend WithEvents btnbusco As MetroButton
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents dthora As MetroDateTime
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents txthhegr As MetroTextBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents rbRem As MetroRadioButton
    Friend WithEvents rbMad As MetroRadioButton
    Friend WithEvents gbMad As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents cbMadera As MetroComboBox
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents txtMadera As MetroTextBox
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents btnSalir As MetroTile
    Friend WithEvents BtnNuevo As MetroTile
    Friend WithEvents MetroTile1 As MetroTile
    Friend WithEvents cbturno As MetroComboBox

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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    Friend WithEvents btncancel As MetroButton
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents txtremito As MetroTextBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PIModiMad))
        Me.btncancel = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.txtremito = New MetroFramework.Controls.MetroTextBox()
        Me.btnbusco = New MetroFramework.Controls.MetroButton()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.dthora = New MetroFramework.Controls.MetroDateTime()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.txthhegr = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.rbRem = New MetroFramework.Controls.MetroRadioButton()
        Me.rbMad = New MetroFramework.Controls.MetroRadioButton()
        Me.gbMad = New System.Windows.Forms.GroupBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.cbMadera = New MetroFramework.Controls.MetroComboBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.txtMadera = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.btnSalir = New MetroFramework.Controls.MetroTile()
        Me.BtnNuevo = New MetroFramework.Controls.MetroTile()
        Me.gb1.SuspendLayout()
        Me.gbMad.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncancel.Location = New System.Drawing.Point(165, 390)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 24)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseSelectable = True
        Me.btncancel.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(170, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Remito"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtremito
        '
        Me.txtremito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtremito.CustomButton.Image = Nothing
        Me.txtremito.CustomButton.Location = New System.Drawing.Point(70, 2)
        Me.txtremito.CustomButton.Name = ""
        Me.txtremito.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtremito.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtremito.CustomButton.TabIndex = 1
        Me.txtremito.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtremito.CustomButton.UseSelectable = True
        Me.txtremito.CustomButton.Visible = False
        Me.txtremito.Lines = New String(-1) {}
        Me.txtremito.Location = New System.Drawing.Point(152, 168)
        Me.txtremito.MaxLength = 6
        Me.txtremito.Name = "txtremito"
        Me.txtremito.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtremito.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtremito.SelectedText = ""
        Me.txtremito.SelectionLength = 0
        Me.txtremito.SelectionStart = 0
        Me.txtremito.ShortcutsEnabled = True
        Me.txtremito.Size = New System.Drawing.Size(88, 20)
        Me.txtremito.TabIndex = 2
        Me.txtremito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtremito.UseSelectable = True
        Me.txtremito.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtremito.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnbusco
        '
        Me.btnbusco.Location = New System.Drawing.Point(240, 168)
        Me.btnbusco.Name = "btnbusco"
        Me.btnbusco.Size = New System.Drawing.Size(32, 20)
        Me.btnbusco.TabIndex = 3
        Me.btnbusco.Text = "..."
        Me.btnbusco.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(245, 390)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(88, 24)
        Me.btnguardar.TabIndex = 6
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseSelectable = True
        Me.btnguardar.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(118, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Grupo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(27, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Turno"
        '
        'cbgrupo
        '
        Me.cbgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbgrupo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbgrupo.FormattingEnabled = True
        Me.cbgrupo.ItemHeight = 19
        Me.cbgrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbgrupo.Location = New System.Drawing.Point(111, 84)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(60, 25)
        Me.cbgrupo.TabIndex = 0
        Me.cbgrupo.UseSelectable = True
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(17, 84)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(60, 25)
        Me.cbturno.TabIndex = 6
        Me.cbturno.UseSelectable = True
        '
        'dtfecha
        '
        Me.dtfecha.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(8, 38)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(88, 25)
        Me.dtfecha.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Fecha y hora"
        '
        'dthora
        '
        Me.dthora.CustomFormat = "HH:mm:ss"
        Me.dthora.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dthora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dthora.Location = New System.Drawing.Point(102, 38)
        Me.dthora.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dthora.Name = "dthora"
        Me.dthora.Size = New System.Drawing.Size(79, 25)
        Me.dthora.TabIndex = 5
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.dthora)
        Me.gb1.Controls.Add(Me.Label4)
        Me.gb1.Controls.Add(Me.Label1)
        Me.gb1.Controls.Add(Me.cbgrupo)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Controls.Add(Me.dtfecha)
        Me.gb1.Controls.Add(Me.cbturno)
        Me.gb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.ForeColor = Color.Black
        Me.gb1.Location = New System.Drawing.Point(41, 241)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(200, 129)
        Me.gb1.TabIndex = 4
        Me.gb1.TabStop = False
        Me.gb1.Text = "Modificar datos"
        '
        'txthhegr
        '
        '
        '
        '
        Me.txthhegr.CustomButton.Image = Nothing
        Me.txthhegr.CustomButton.Location = New System.Drawing.Point(168, 2)
        Me.txthhegr.CustomButton.Name = ""
        Me.txthhegr.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txthhegr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txthhegr.CustomButton.TabIndex = 1
        Me.txthhegr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txthhegr.CustomButton.UseSelectable = True
        Me.txthhegr.CustomButton.Visible = False
        Me.txthhegr.Enabled = False
        Me.txthhegr.Lines = New String(-1) {}
        Me.txthhegr.Location = New System.Drawing.Point(40, 215)
        Me.txthhegr.MaxLength = 32767
        Me.txthhegr.Name = "txthhegr"
        Me.txthhegr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txthhegr.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txthhegr.SelectedText = ""
        Me.txthhegr.SelectionLength = 0
        Me.txthhegr.SelectionStart = 0
        Me.txthhegr.ShortcutsEnabled = True
        Me.txthhegr.Size = New System.Drawing.Size(186, 20)
        Me.txthhegr.TabIndex = 54
        Me.txthhegr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txthhegr.UseSelectable = True
        Me.txthhegr.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txthhegr.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(41, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 14)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Fecha y hora de Egreso del Camión"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbRem
        '
        Me.rbRem.AutoSize = True
        Me.rbRem.Checked = True
        Me.rbRem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbRem.Location = New System.Drawing.Point(49, 124)
        Me.rbRem.Name = "rbRem"
        Me.rbRem.Size = New System.Drawing.Size(149, 15)
        Me.rbRem.TabIndex = 0
        Me.rbRem.TabStop = True
        Me.rbRem.Text = "Modificar Carga Remito"
        Me.rbRem.UseSelectable = True
        '
        'rbMad
        '
        Me.rbMad.AutoSize = True
        Me.rbMad.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbMad.Location = New System.Drawing.Point(231, 124)
        Me.rbMad.Name = "rbMad"
        Me.rbMad.Size = New System.Drawing.Size(161, 15)
        Me.rbMad.TabIndex = 1
        Me.rbMad.Text = "Modificar Madera Portería"
        Me.rbMad.UseSelectable = True
        '
        'gbMad
        '
        Me.gbMad.Controls.Add(Me.Label6)
        Me.gbMad.Controls.Add(Me.cbMadera)
        Me.gbMad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMad.ForeColor = Color.Black
        Me.gbMad.Location = New System.Drawing.Point(271, 241)
        Me.gbMad.Name = "gbMad"
        Me.gbMad.Size = New System.Drawing.Size(200, 110)
        Me.gbMad.TabIndex = 5
        Me.gbMad.TabStop = False
        Me.gbMad.Text = "Modificar datos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(6, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Madera"
        '
        'cbMadera
        '
        Me.cbMadera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMadera.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbMadera.FormattingEnabled = True
        Me.cbMadera.ItemHeight = 19
        Me.cbMadera.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbMadera.Location = New System.Drawing.Point(4, 48)
        Me.cbMadera.Name = "cbMadera"
        Me.cbMadera.Size = New System.Drawing.Size(186, 25)
        Me.cbMadera.TabIndex = 0
        Me.cbMadera.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(276, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 14)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Tipo de Madera BD Portería"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMadera
        '
        '
        '
        '
        Me.txtMadera.CustomButton.Image = Nothing
        Me.txtMadera.CustomButton.Location = New System.Drawing.Point(168, 2)
        Me.txtMadera.CustomButton.Name = ""
        Me.txtMadera.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtMadera.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMadera.CustomButton.TabIndex = 1
        Me.txtMadera.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMadera.CustomButton.UseSelectable = True
        Me.txtMadera.CustomButton.Visible = False
        Me.txtMadera.Enabled = False
        Me.txtMadera.Lines = New String(-1) {}
        Me.txtMadera.Location = New System.Drawing.Point(275, 215)
        Me.txtMadera.MaxLength = 32767
        Me.txtMadera.Name = "txtMadera"
        Me.txtMadera.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMadera.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMadera.SelectedText = ""
        Me.txtMadera.SelectionLength = 0
        Me.txtMadera.SelectionStart = 0
        Me.txtMadera.ShortcutsEnabled = True
        Me.txtMadera.Size = New System.Drawing.Size(186, 20)
        Me.txtMadera.TabIndex = 58
        Me.txtMadera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMadera.UseSelectable = True
        Me.txtMadera.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMadera.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanel1.Controls.Add(Me.MetroTile1)
        Me.MetroPanel1.Controls.Add(Me.btnSalir)
        Me.MetroPanel1.Controls.Add(Me.BtnNuevo)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(427, 41)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroPanel1.TabIndex = 60
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroTile1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTile1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MetroTile1.Location = New System.Drawing.Point(178, 0)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(249, 41)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile1.TabIndex = 8
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'btnSalir
        '
        Me.btnSalir.ActiveControl = Nothing
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Location = New System.Drawing.Point(89, 0)
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
        'BtnNuevo
        '
        Me.BtnNuevo.ActiveControl = Nothing
        Me.BtnNuevo.BackColor = System.Drawing.Color.Transparent
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
        'PIModiMad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(467, 460)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMadera)
        Me.Controls.Add(Me.gbMad)
        Me.Controls.Add(Me.rbMad)
        Me.Controls.Add(Me.rbRem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtremito)
        Me.Controls.Add(Me.btnbusco)
        Me.Controls.Add(Me.txthhegr)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.gb1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PIModiMad"
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Modificación de carga Remito"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.gbMad.ResumeLayout(False)
        Me.gbMad.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub PIModiMad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call bloquea()
        BtnNuevo.Enabled = True
        sen1 = 0
        sen2 = 0

    End Sub

    Private Sub Opcion(sender As Object, e As EventArgs) Handles BtnNuevo.Click, btnSalir.Click
        'Busco la opción por el nombre del botón
        Select Case sender.Name

            Case BtnNuevo.Name ' boton nuevo
                sen = "n"
                btncancel.Visible = True
                btnguardar.Visible = True
                BtnNuevo.Enabled = False
                Call habilita()
                txtremito.Focus()

            Case btnSalir.Name ' boton salir
                Me.Close()
        End Select
    End Sub


    Private Sub modifica()
        txtremito.Focus()
    End Sub
    Private Sub habilita()
        txtremito.Enabled = True
    End Sub

    Private Sub permiteCarga(ByVal opcion)
        txtremito.Enabled = False
        If opcion = "Remito" Then
            gb1.Enabled = True
        ElseIf opcion = "Madera" Then
            gbMad.Enabled = True
        End If

    End Sub


    Private Sub bloquea()

        txtremito.Enabled = False
        gb1.Enabled = False
        gbMad.Enabled = False

    End Sub
    Private Sub limpia()
        txtremito.Text = ""
        cbturno.Text = ""
        cbgrupo.Text = ""
        dtfecha.Value = Now
        dthora.Value = Now
        txthhegr.Text = ""
        txtMadera.Text = ""
        cbMadera.DataSource = Nothing

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click

        Call limpia()
        BtnNuevo.Enabled = True
        Call bloquea()
        btncancel.Visible = False
        btnguardar.Visible = False

    End Sub


    Private Sub guardanuevo(ByVal op)
        If op = "Remito" Then
            If cbturno.Text = "" Or cbgrupo.Text = "" Then
                mensaje = "Favor de completar los campos Turno y Grupo"
                MetroMessageBox.Show(Me, "" + mensaje + "", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbturno.Focus()
                sen1 = 99
                Exit Sub
            End If

            Dim fhcarga As DateTime
            fhcarga = dtfecha.Text & " " & dthora.Text

            sql3 = "UPDATE MARMV set marmv_fecha='" + fhcarga + "',marmv_turno='" + cbturno.Text + "', marmv_grupo='" + cbgrupo.Text + "' where marmv_nroremito='" + Trim(txtremito.Text) + "'"
            cmd3 = New SqlCommand(sql3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

            MetroMessageBox.Show(Me, "Datos actualizados")
            Call limpia()
            Call bloquea()


        ElseIf op = "Madera" Then
            If cbMadera.Text = "" Then
                mensaje = "Favor de seleccionar un tipo de madera"
                MetroMessageBox.Show(Me, "" + mensaje + "", "Atención")
                cbturno.Focus()
                sen1 = 99
                Exit Sub
            End If

            conexA("camion")
            sql = "SELECT * From Productos WHERE codigo=" + Trim(cbMadera.SelectedValue) + ""
            daA = New OleDbDataAdapter(sql, cnnA)
            dt = New DataTable
            daA.Fill(dt)
            n = dt.Rows.Count

            CodMadPortertia = dt.Rows(0).Item("codigo")
            TipMadPorteria = dt.Rows(0).Item("nombre")

            If tabla = "Pendientes" Then
                sql3 = "UPDATE Pendientes set p_codigo='" + CodMadPortertia + "',p_nombre='" + TipMadPorteria + "' where aux3='" + Trim(txtremito.Text) + "'"
                cmdACC = New OleDbCommand(sql3, cnnA)

            ElseIf tabla = "Reporte" Then
                sql3 = "UPDATE Reporte set p_codigo=" + Str(CodMadPortertia) + ",p_nombre='" + TipMadPorteria + "' where aux3='" + Trim(txtremito.Text) + "'"
                cmdACC = New OleDbCommand(sql3, cnnA)
            End If

            cmdACC.Connection.Open()
            cmdACC.ExecuteNonQuery()
            cmdACC.Connection.Close()

            MetroMessageBox.Show(Me, "Datos actualizados")
            Call limpia()
            Call bloquea()



        End If

    End Sub



    Private Sub btnbusco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbusco.Click
        Call buscasiexisteremito()

        'Sí está chequeado rbRem
        If rbRem.Checked = True Then
            If n = 1 Then

                Call buscaHHEgreso()
                If n = 1 Then
                    txthhegr.Text = FormatDateTime(dt2.Rows(0).Item("camion_fechaegr"), DateFormat.ShortDate) & " " & FormatDateTime(dt2.Rows(0).Item("camion_horaegr"), DateFormat.ShortTime)
                End If

                Call permiteCarga("Remito")
                Call cargadatos()
            Else

                MetroMessageBox.Show(Me, "No existe movimiento de ese número de remito")
                txtremito.Text = ""
                Call bloquea()
            End If


        ElseIf rbMad.Checked = True Then

            'Sí existe en MARMV no se puede modificar la madera
            If n = 1 Then
                MetroMessageBox.Show(Me, "Remito ya cargado en la BD, no se puede modificar la madera")
                txtremito.Text = ""
                Call bloquea()
            Else
                'Si no existe debo buscar el remito en Access de portería en tablas:
                'PENDIENTE y REPORTE

                Call buscoEnAccess(txtremito.Text)

                'Sí existe el remito en access
                If n = 1 Then
                    txtMadera.Text = dt.Rows(0).Item("p_nombre")

                    Call permiteCarga("Madera")

                    Call llenacb("tipmad")
                    cbMadera.DataSource = dt7
                    cbMadera.DisplayMember = "tipmad_desc"
                    cbMadera.ValueMember = "tipmad_codbalanza"

                Else
                    MetroMessageBox.Show(Me, "Remito no cargado en portería")
                    txtremito.Text = ""
                    Call bloquea()
                End If

            End If

        End If


    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click


        If txtremito.Text = "" Then
            MetroMessageBox.Show(Me, "El campo Nro remito es obligatorio", "Atención")
            txtremito.Focus()
            txtremito.SelectAll()

        Else

            If rbRem.Checked = True Then
                Call guardanuevo("Remito")
            ElseIf rbMad.Checked = True Then
                Call guardanuevo("Madera")
            End If

            If sen1 = 99 Then
                sen1 = 0
                Exit Sub
            End If
            Call limpia()
            Call bloquea()

            btncancel.Visible = False
            btnguardar.Visible = False
        End If

    End Sub

    Private Sub buscaHHEgreso()
        conex("camion")
        sql2 = "SELECT camion_fechaegr,camion_horaegr From camion where camion_nroremito='" + txtremito.Text + "'"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)
        n = dt2.Rows.Count
    End Sub



    Private Sub txtremito_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtremito.KeyUp
        If e.KeyCode = Keys.Enter Then

            Call buscasiexisteremito()

            'Sí está chequeado rbRem
            If rbRem.Checked = True Then
                If n = 1 Then

                    Call buscaHHEgreso()
                    If n = 1 Then
                        txthhegr.Text = FormatDateTime(dt2.Rows(0).Item("camion_fechaegr"), DateFormat.ShortDate) & " " & FormatDateTime(dt2.Rows(0).Item("camion_horaegr"), DateFormat.ShortTime)
                    End If

                    Call permiteCarga("Remito")
                    Call cargadatos()
                Else

                    MetroMessageBox.Show(Me, "No existe movimiento de ese número de remito")
                    txtremito.Text = ""
                    Call bloquea()
                End If


            ElseIf rbMad.Checked = True Then

                'Sí existe en MARMV no se puede modificar la madera
                If n = 1 Then
                    MetroMessageBox.Show(Me, "Remito ya cargado en la BD, no se puede modificar la madera")
                    txtremito.Text = ""
                    Call bloquea()
                Else
                    'Si no existe debo buscar el remito en Access de portería en tablas:
                    'PENDIENTE y REPORTE

                    Call buscoEnAccess(txtremito.Text)

                    'Sí existe el remito en access
                    If n = 1 Then
                        txtMadera.Text = dt.Rows(0).Item("p_nombre")

                        Call permiteCarga("Madera")

                        Call llenacb("tipmad")
                        cbMadera.DataSource = dt7
                        cbMadera.DisplayMember = "tipmad_desc"
                        cbMadera.ValueMember = "tipmad_codbalanza"

                    Else
                        MetroMessageBox.Show(Me, "Remito no cargado en portería")
                        txtremito.Text = ""
                        Call bloquea()
                    End If

                End If

            End If
        End If
    End Sub


    Private Sub cargadatos()
        dtfecha.Text = FormatDateTime(dt5.Rows(0).Item("marmv_fecha"), DateFormat.ShortDate)
        dthora.Text = FormatDateTime(dt5.Rows(0).Item("marmv_fecha"), DateFormat.ShortTime)
        cbturno.Text = dt5.Rows(0).Item("marmv_turno")
        cbgrupo.Text = dt5.Rows(0).Item("marmv_grupo")
    End Sub



    Private Sub buscasiexisteremito()
        conex("marmv")
        sql5 = "SELECT * From MARMV where marmv_nroremito='" + txtremito.Text + "'and marmv_ingegr='I' "
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        Application.DoEvents()
        n = dt5.Rows.Count
    End Sub


    Private Sub rbRem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRem.CheckedChanged
        If rbRem.Checked = True Then
            gb1.Visible = True
            gbMad.Visible = False
        End If
    End Sub

    Private Sub rbMad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMad.CheckedChanged
        If rbMad.Checked = True Then
            gbMad.Visible = True
            gb1.Visible = False
        End If

    End Sub


    Private Sub buscoEnAccess(ByVal remito)

        conexA("camion")
        sql = "SELECT * From Pendientes WHERE aux3='" + RTrim(remito) + "'"
        daA = New OleDbDataAdapter(sql, cnnA)
        dt = New DataTable
        daA.Fill(dt)
        n = dt.Rows.Count

        If n = 1 Then
            tabla = "Pendientes"
        Else
            conexA("Camion")
            sql5 = "SELECT * From Reporte where aux3='" + RTrim(remito) + "'"
            daA = New OleDbDataAdapter(sql5, cnnA)
            dt = New DataTable
            daA.Fill(dt)
            n = dt.Rows.Count
            If n = 1 Then
                tabla = "Reporte"
            Else
            End If


        End If


    End Sub


End Class
