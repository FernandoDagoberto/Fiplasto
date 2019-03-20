Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework.Controls
Imports MetroFramework

Public Class RecepcionMadera
    Inherits MetroFramework.Forms.MetroForm

    Dim sql, sql1, sql2, sql3, sql4, sql5 As String
    Dim da, da1, da3, da5 As New SqlDataAdapter
    Dim cmd, cmd2, cmd3, cmd4, cmd5 As SqlCommand
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
    Dim mensaje As String
    Dim alerta As String
    Dim cargamanual As String
    Friend WithEvents btnbusco As MetroButton
    Friend WithEvents txtcod As MetroTextBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents txttipmad As MetroTextBox
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents gbinspeccion As System.Windows.Forms.GroupBox
    Friend WithEvents rbnc As MetroRadioButton
    Friend WithEvents rbc As MetroRadioButton
    Friend WithEvents gbconforme As System.Windows.Forms.GroupBox
    Friend WithEvents gbnoconforme As System.Windows.Forms.GroupBox
    Friend WithEvents cbmotivo As MetroComboBox
    Friend WithEvents cbpila As MetroComboBox
    Friend WithEvents rbpila As MetroRadioButton
    Friend WithEvents rbpica As MetroRadioButton
    Friend WithEvents txtobs As MetroTextBox
    Friend WithEvents chkrech As MetroCheckBox
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents btnSalir As MetroTile
    Friend WithEvents BtnNuevo As MetroTile
    Friend WithEvents MetroTile1 As MetroTile
    Friend WithEvents PBar As MetroProgressBar

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
    Friend WithEvents btncancel As MetroButton
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents txtremito As MetroTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecepcionMadera))
        Me.btncancel = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.txtremito = New MetroFramework.Controls.MetroTextBox()
        Me.btnbusco = New MetroFramework.Controls.MetroButton()
        Me.txtcod = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txttipmad = New MetroFramework.Controls.MetroTextBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.PBar = New MetroFramework.Controls.MetroProgressBar()
        Me.gbinspeccion = New System.Windows.Forms.GroupBox()
        Me.rbnc = New MetroFramework.Controls.MetroRadioButton()
        Me.rbc = New MetroFramework.Controls.MetroRadioButton()
        Me.gbconforme = New System.Windows.Forms.GroupBox()
        Me.cbpila = New MetroFramework.Controls.MetroComboBox()
        Me.rbpila = New MetroFramework.Controls.MetroRadioButton()
        Me.rbpica = New MetroFramework.Controls.MetroRadioButton()
        Me.gbnoconforme = New System.Windows.Forms.GroupBox()
        Me.txtobs = New MetroFramework.Controls.MetroTextBox()
        Me.chkrech = New MetroFramework.Controls.MetroCheckBox()
        Me.cbmotivo = New MetroFramework.Controls.MetroComboBox()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.btnSalir = New MetroFramework.Controls.MetroTile()
        Me.BtnNuevo = New MetroFramework.Controls.MetroTile()
        Me.gbinspeccion.SuspendLayout()
        Me.gbconforme.SuspendLayout()
        Me.gbnoconforme.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncancel.Location = New System.Drawing.Point(127, 455)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 24)
        Me.btncancel.TabIndex = 8
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseSelectable = True
        Me.btncancel.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(19, 114)
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
        Me.txtremito.Location = New System.Drawing.Point(17, 133)
        Me.txtremito.MaxLength = 6
        Me.txtremito.Name = "txtremito"
        Me.txtremito.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtremito.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtremito.SelectedText = ""
        Me.txtremito.SelectionLength = 0
        Me.txtremito.SelectionStart = 0
        Me.txtremito.ShortcutsEnabled = True
        Me.txtremito.Size = New System.Drawing.Size(88, 20)
        Me.txtremito.TabIndex = 0
        Me.txtremito.UseSelectable = True
        Me.txtremito.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtremito.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnbusco
        '
        Me.btnbusco.Enabled = False
        Me.btnbusco.Location = New System.Drawing.Point(105, 133)
        Me.btnbusco.Name = "btnbusco"
        Me.btnbusco.Size = New System.Drawing.Size(32, 20)
        Me.btnbusco.TabIndex = 1
        Me.btnbusco.Text = "..."
        Me.btnbusco.UseSelectable = True
        '
        'txtcod
        '
        '
        '
        '
        Me.txtcod.CustomButton.Image = Nothing
        Me.txtcod.CustomButton.Location = New System.Drawing.Point(70, 2)
        Me.txtcod.CustomButton.Name = ""
        Me.txtcod.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcod.CustomButton.TabIndex = 1
        Me.txtcod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcod.CustomButton.UseSelectable = True
        Me.txtcod.CustomButton.Visible = False
        Me.txtcod.Lines = New String(-1) {}
        Me.txtcod.Location = New System.Drawing.Point(17, 179)
        Me.txtcod.MaxLength = 32767
        Me.txtcod.Name = "txtcod"
        Me.txtcod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcod.ReadOnly = True
        Me.txtcod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcod.SelectedText = ""
        Me.txtcod.SelectionLength = 0
        Me.txtcod.SelectionStart = 0
        Me.txtcod.ShortcutsEnabled = True
        Me.txtcod.Size = New System.Drawing.Size(88, 20)
        Me.txtcod.TabIndex = 21
        Me.txtcod.UseSelectable = True
        Me.txtcod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(17, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttipmad
        '
        '
        '
        '
        Me.txttipmad.CustomButton.Image = Nothing
        Me.txttipmad.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.txttipmad.CustomButton.Name = ""
        Me.txttipmad.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txttipmad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttipmad.CustomButton.TabIndex = 1
        Me.txttipmad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttipmad.CustomButton.UseSelectable = True
        Me.txttipmad.CustomButton.Visible = False
        Me.txttipmad.Lines = New String(-1) {}
        Me.txttipmad.Location = New System.Drawing.Point(129, 179)
        Me.txttipmad.MaxLength = 32767
        Me.txttipmad.Name = "txttipmad"
        Me.txttipmad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttipmad.ReadOnly = True
        Me.txttipmad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttipmad.SelectedText = ""
        Me.txttipmad.SelectionLength = 0
        Me.txttipmad.SelectionStart = 0
        Me.txttipmad.ShortcutsEnabled = True
        Me.txttipmad.Size = New System.Drawing.Size(232, 20)
        Me.txttipmad.TabIndex = 31
        Me.txttipmad.UseSelectable = True
        Me.txttipmad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttipmad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(126, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Tipo Madera"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(207, 455)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(88, 24)
        Me.btnguardar.TabIndex = 7
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseSelectable = True
        Me.btnguardar.Visible = False
        '
        'PBar
        '
        Me.PBar.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PBar.Location = New System.Drawing.Point(100, 439)
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(211, 10)
        Me.PBar.TabIndex = 40
        Me.PBar.Visible = False
        '
        'gbinspeccion
        '
        Me.gbinspeccion.Controls.Add(Me.rbnc)
        Me.gbinspeccion.Controls.Add(Me.rbc)
        Me.gbinspeccion.Enabled = False
        Me.gbinspeccion.ForeColor = Color.Black
        Me.gbinspeccion.Location = New System.Drawing.Point(17, 216)
        Me.gbinspeccion.Name = "gbinspeccion"
        Me.gbinspeccion.Size = New System.Drawing.Size(374, 47)
        Me.gbinspeccion.TabIndex = 4
        Me.gbinspeccion.TabStop = False
        Me.gbinspeccion.Text = "Conforme"
        '
        'rbnc
        '
        Me.rbnc.AutoSize = True
        Me.rbnc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbnc.Location = New System.Drawing.Point(205, 16)
        Me.rbnc.Name = "rbnc"
        Me.rbnc.Size = New System.Drawing.Size(96, 15)
        Me.rbnc.TabIndex = 1
        Me.rbnc.TabStop = True
        Me.rbnc.Text = "No Conforme"
        Me.rbnc.UseSelectable = True
        '
        'rbc
        '
        Me.rbc.AutoSize = True
        Me.rbc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbc.Location = New System.Drawing.Point(30, 19)
        Me.rbc.Name = "rbc"
        Me.rbc.Size = New System.Drawing.Size(77, 15)
        Me.rbc.TabIndex = 0
        Me.rbc.TabStop = True
        Me.rbc.Text = "Conforme"
        Me.rbc.UseSelectable = True
        '
        'gbconforme
        '
        Me.gbconforme.Controls.Add(Me.cbpila)
        Me.gbconforme.Controls.Add(Me.rbpila)
        Me.gbconforme.Controls.Add(Me.rbpica)
        Me.gbconforme.Enabled = False
        Me.gbconforme.ForeColor = Color.Black
        Me.gbconforme.Location = New System.Drawing.Point(20, 277)
        Me.gbconforme.Name = "gbconforme"
        Me.gbconforme.Size = New System.Drawing.Size(133, 154)
        Me.gbconforme.TabIndex = 5
        Me.gbconforme.TabStop = False
        Me.gbconforme.Text = "Destino"
        '
        'cbpila
        '
        Me.cbpila.Enabled = False
        Me.cbpila.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbpila.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbpila.FormattingEnabled = True
        Me.cbpila.ItemHeight = 19
        Me.cbpila.Location = New System.Drawing.Point(26, 100)
        Me.cbpila.Name = "cbpila"
        Me.cbpila.Size = New System.Drawing.Size(86, 25)
        Me.cbpila.TabIndex = 2
        Me.cbpila.UseSelectable = True
        '
        'rbpila
        '
        Me.rbpila.AutoSize = True
        Me.rbpila.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbpila.Location = New System.Drawing.Point(27, 66)
        Me.rbpila.Name = "rbpila"
        Me.rbpila.Size = New System.Drawing.Size(53, 15)
        Me.rbpila.TabIndex = 1
        Me.rbpila.TabStop = True
        Me.rbpila.Text = "A pila"
        Me.rbpila.UseSelectable = True
        '
        'rbpica
        '
        Me.rbpica.AutoSize = True
        Me.rbpica.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbpica.Location = New System.Drawing.Point(27, 31)
        Me.rbpica.Name = "rbpica"
        Me.rbpica.Size = New System.Drawing.Size(80, 15)
        Me.rbpica.TabIndex = 0
        Me.rbpica.TabStop = True
        Me.rbpica.Text = "A picadora"
        Me.rbpica.UseSelectable = True
        '
        'gbnoconforme
        '
        Me.gbnoconforme.Controls.Add(Me.txtobs)
        Me.gbnoconforme.Controls.Add(Me.chkrech)
        Me.gbnoconforme.Controls.Add(Me.cbmotivo)
        Me.gbnoconforme.Enabled = False
        Me.gbnoconforme.ForeColor = Color.Black
        Me.gbnoconforme.Location = New System.Drawing.Point(169, 277)
        Me.gbnoconforme.Name = "gbnoconforme"
        Me.gbnoconforme.Size = New System.Drawing.Size(222, 154)
        Me.gbnoconforme.TabIndex = 6
        Me.gbnoconforme.TabStop = False
        Me.gbnoconforme.Text = "Defecto"
        '
        'txtobs
        '
        '
        '
        '
        Me.txtobs.CustomButton.Image = Nothing
        Me.txtobs.CustomButton.Location = New System.Drawing.Point(162, 1)
        Me.txtobs.CustomButton.Name = ""
        Me.txtobs.CustomButton.Size = New System.Drawing.Size(45, 45)
        Me.txtobs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtobs.CustomButton.TabIndex = 1
        Me.txtobs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtobs.CustomButton.UseSelectable = True
        Me.txtobs.CustomButton.Visible = False
        Me.txtobs.Enabled = False
        Me.txtobs.Lines = New String(-1) {}
        Me.txtobs.Location = New System.Drawing.Point(8, 90)
        Me.txtobs.MaxLength = 32767
        Me.txtobs.Multiline = True
        Me.txtobs.Name = "txtobs"
        Me.txtobs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtobs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtobs.SelectedText = ""
        Me.txtobs.SelectionLength = 0
        Me.txtobs.SelectionStart = 0
        Me.txtobs.ShortcutsEnabled = True
        Me.txtobs.Size = New System.Drawing.Size(208, 47)
        Me.txtobs.TabIndex = 2
        Me.txtobs.UseSelectable = True
        Me.txtobs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtobs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkrech
        '
        Me.chkrech.AutoSize = True
        Me.chkrech.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkrech.Location = New System.Drawing.Point(8, 67)
        Me.chkrech.Name = "chkrech"
        Me.chkrech.Size = New System.Drawing.Size(80, 15)
        Me.chkrech.TabIndex = 1
        Me.chkrech.Text = "Rechazado"
        Me.chkrech.UseSelectable = True
        '
        'cbmotivo
        '
        Me.cbmotivo.DropDownWidth = 250
        Me.cbmotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmotivo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmotivo.FormattingEnabled = True
        Me.cbmotivo.ItemHeight = 19
        Me.cbmotivo.Location = New System.Drawing.Point(8, 32)
        Me.cbmotivo.Name = "cbmotivo"
        Me.cbmotivo.Size = New System.Drawing.Size(208, 25)
        Me.cbmotivo.TabIndex = 0
        Me.cbmotivo.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(260, 114)
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
        Me.Label3.Location = New System.Drawing.Point(154, 114)
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
        Me.cbgrupo.Location = New System.Drawing.Point(275, 133)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(58, 25)
        Me.cbgrupo.TabIndex = 3
        Me.cbgrupo.UseSelectable = True
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(169, 133)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(69, 25)
        Me.cbturno.TabIndex = 2
        Me.cbturno.UseSelectable = True
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
        Me.MetroPanel1.Location = New System.Drawing.Point(5, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(393, 41)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroPanel1.TabIndex = 61
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
        Me.MetroTile1.ForeColor = System.Drawing.Color.Transparent
        Me.MetroTile1.Location = New System.Drawing.Point(178, 0)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(215, 41)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile1.TabIndex = 7
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
        'RecepcionMadera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 503)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.gbnoconforme)
        Me.Controls.Add(Me.gbconforme)
        Me.Controls.Add(Me.gbinspeccion)
        Me.Controls.Add(Me.PBar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txttipmad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnbusco)
        Me.Controls.Add(Me.txtremito)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RecepcionMadera"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Recepción de madera"
        Me.gbinspeccion.ResumeLayout(False)
        Me.gbinspeccion.PerformLayout()
        Me.gbconforme.ResumeLayout(False)
        Me.gbconforme.PerformLayout()
        Me.gbnoconforme.ResumeLayout(False)
        Me.gbnoconforme.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub RecepcionMadera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                'Borra los datos cargados en la tabla camión sí no tienen movimientos
                Call borratblcamion()
                Me.Close()
        End Select
    End Sub



    Private Sub guardar()
        If txtremito.Text = "" Then
            mensaje = "El campo Nro remito es obligatorio"
            MetroMessageBox.Show(Me, "" + mensaje + "", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Call guardaLog()

            txtremito.Focus()
            txtremito.SelectAll()

        Else

            Call guardanuevo()
            If sen1 = 99 Then
                sen1 = 0
                Exit Sub
            End If

            Call limpia()
            If BtnNuevo.Enabled = False Then BtnNuevo.Enabled = True
            btncancel.Visible = False
            btnguardar.Visible = False
        End If

    End Sub
    Private Sub modifica()
        txtremito.Focus()
    End Sub
    Private Sub habilita()
        txtremito.Enabled = True
        btnbusco.Enabled = True
        cbturno.Enabled = True
        cbgrupo.Enabled = True

    End Sub
    Private Sub deshabilita()
        txtremito.Enabled = False
        btnbusco.Enabled = False
        cbturno.Enabled = False
        cbgrupo.Enabled = False
    End Sub
    Private Sub limpia()
        txtremito.Text = ""
        cbturno.Text = ""
        cbgrupo.Text = ""
        txtcod.Text = ""
        txttipmad.Text = ""

        rbc.Checked = False
        rbnc.Checked = False

        rbpica.Checked = False
        rbpila.Checked = False

        cbmotivo.Text = ""
        chkrech.Checked = False
        txtobs.Text = ""
        cbpila.Text = ""
        gbinspeccion.Enabled = False
        gbconforme.Enabled = False
        gbnoconforme.Enabled = False
    End Sub
    Private Sub buscadatos(ByVal remito)

        conex("camion")
        sql = "select  TIPMAD.TIPMAD_ID ,TIPMAD_DESC from CAMION inner join TIPMAD on camion_pcod=TIPMAD_CODBALANZA where camion_nroremito='" + RTrim(remito) + "' "
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count
    End Sub

    Private Sub bloquea()
        txtremito.Enabled = False
        cbturno.Enabled = False
        cbgrupo.Enabled = False
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        'Borra los datos cargados en la tabla camión sí no tienen movimientos
        Call borratblcamion()


        Call limpia()
        BtnNuevo.Enabled = True
        Call deshabilita()
        btncancel.Visible = False
        btnguardar.Visible = False

    End Sub


    Private Sub borratblcamion()

        sql7 = "SELECT * FROM camion left JOIN marmv ON MARMV.marmv_nroremito = CAMION.camion_nroremito where marmv_ingegr='I' and marmv_nroremito='" + txtremito.Text + "'"
        da7 = New SqlDataAdapter(sql7, cnn)
        dt7 = New DataTable
        da7.Fill(dt7)
        n = dt7.Rows.Count

        If n = 0 Then
            sql7 = "delete from camion where camion_nroremito='" + txtremito.Text + "'"
            cmd3 = New SqlCommand(sql7, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

        End If


    End Sub


    Private Sub guardanuevo()
        If cbturno.Text = "" Or cbgrupo.Text = "" Then

            mensaje = "Favor de completar los campos Turno y Grupo"
            MetroMessageBox.Show(Me, "" + mensaje + "", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbturno.Focus()
            sen1 = 99
            Exit Sub
        End If

        If rbc.Checked = False And rbnc.Checked = False Then
            mensaje = "Seleccione Conforme o no Conforme"
            MetroMessageBox.Show(Me, "" + mensaje + "", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            sen1 = 99
            Exit Sub

        End If

        If rbc.Checked = True And rbpica.Checked = False And rbpila.Checked = False Then
            mensaje = ("Seleccione destino")
            MetroMessageBox.Show(Me, "" + mensaje + "", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            sen1 = 99
            rbpica.Focus()
            Exit Sub
        End If


        If chkrech.Checked = True Then
            rechazado = "S"
        Else
            rechazado = ""
        End If

        If cbpila.Text = "500" Or cbpila.Text = "501" Or cbpila.Text = "502" Then
            sql = "select * from stpila where stpila_pila in (500,501,502) and stpila_llena='S'"
            da = New SqlDataAdapter(sql, cnn)
            dt = New DataTable
            da.Fill(dt)
            n = dt.Rows.Count
            If n > 0 Then
                mensaje = ("Pila de mesa de troncos llenas, una vez vacía se habilitará su descarga")
                MetroMessageBox.Show(Me, "" + mensaje + "", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Call guardaLog()
                sen1 = 99
                Exit Sub
            End If
        End If


        btncancel.Visible = False
        btnguardar.Visible = False
        conex("marmv")
        sql5 = "SELECT * From marmv where marmv_nroremito='" + txtremito.Text + "' and marmv_ingegr='I'"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        n = dt5.Rows.Count

        If n = 0 Or sen <> "n" Then
            If sen = "n" Then
                campos = "marmv_ingegr,marmv_nroremito,marmv_tipmad,marmv_conforme,marmv_motivonc,marmv_destino,marmv_pila,marmv_rechazado,marmv_obs,marmv_fecha,marmv_turno,marmv_grupo,marmv_userid"

                variables = "'I','" + Trim(txtremito.Text) + "','" + Trim(txtcod.Text) + "', '" + conforme + "'," &
                            "'" + Trim(cbmotivo.SelectedValue) + "', '" + destino + "','" + Trim(cbpila.Text) + "', " &
                            "'" + rechazado + "','" + txtobs.Text + "','" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + user + "'"
                sql3 = "INSERT INTO MARMV (" + campos + ") VALUES (" + variables + ")"
                cmd3 = New SqlCommand(sql3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()

                sql3 = "Update camion set camion_marca='' where camion_nroremito='" + Trim(txtremito.Text) + "'"
                cmd3 = New SqlCommand(sql3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()


                Call ControlInicioPila()

            End If
            Call limpia()
            Call bloquea()
            barra(PBar)
        Else
            ' MetroMessageBox.Show(Me,"Ese camion ya tiene cargado el Remito", MsgBoxStyle.Critical)
            txtremito.Focus()
            btncancel.Visible = True
            btnguardar.Visible = True
        End If

        destino = ""
        conforme = ""
        rechazado = ""

    End Sub



    Private Sub btnbusco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbusco.Click

        Call buscasiexistecamion()

        If n = 1 Then

        Else

            Call cargacamion()

        End If


        If sen2 = 999 Then
            Exit Sub
        Else

            If n = 1 Then

            Else
                Call busco()

            End If

        End If

    End Sub
    Private Sub busco()
        Call buscadatos(txtremito.Text)
        Application.DoEvents()


        If n <> 0 Then
            txtcod.Text = dt.Rows(0).Item("tipmad_id")
            txttipmad.Text = dt.Rows(0).Item("tipmad_desc")
            gbinspeccion.Enabled = True
            Application.DoEvents()

        Else
            mensaje = "Error 1: No existe número de remito o no fue cargado en portería"
            MetroMessageBox.Show(Me, "" + mensaje + "", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Call guardaLog()


        End If
    End Sub
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Call buscasiexiste()
        If n = 0 Then
            Call guardar()
        Else
            Call yaexiste()
        End If
    End Sub
    Private Sub yaexiste()
        mensaje = "Error 2: Ese camion ya tiene cargado el Remito"
        MetroMessageBox.Show(Me, "" + mensaje + "", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Application.DoEvents()

        Call limpia()
        txtremito.Focus()
        n = 0
    End Sub
    Private Sub buscasiexiste()
        conex("MARMV")
        sql5 = "SELECT * From MARMV where marmv_nroremito='" + txtremito.Text + "'and marmv_ingegr='I'"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        n = dt5.Rows.Count
    End Sub



    Sub motivonc()
        conex("MOTIVONC")
        sql5 = "SELECT * From motivonc"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        n = dt5.Rows.Count
        If n <> 0 Then
            cbmotivo.DataSource = dt5
            cbmotivo.DisplayMember = "motivonc_desc"
            cbmotivo.ValueMember = "motivonc_id"
            gbinspeccion.Enabled = True
        Else
            MetroMessageBox.Show(Me, "No existen motivos cargados en el sistema", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub


    Private Sub rbnc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnc.CheckedChanged
        If rbnc.Checked = True Then
            gbnoconforme.Enabled = True
            gbconforme.Enabled = True

            rbpica.Checked = True

            cbpila.Text = ""
            conforme = "N"
            Call motivonc()
        End If
    End Sub

    Private Sub rbc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbc.CheckedChanged
        If rbc.Checked = True Then

            gbconforme.Enabled = True
            rbpica.Checked = True
            conforme = "S"

            gbnoconforme.Enabled = False
            cbmotivo.DataSource = Nothing
            chkrech.Checked = False
            txtobs.Text = ""
            cbmotivo.Text = ""
        End If
    End Sub

    Private Sub rbpica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbpica.CheckedChanged
        If rbpica.Checked = True Then
            cbpila.Enabled = False
            cbpila.DataSource = Nothing

            destino = "C"
        End If
    End Sub

    Private Sub rbpila_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbpila.CheckedChanged
        If rbpila.Checked = True Then
            cbpila.Enabled = True
            destino = "P"
            Call llenapila()

        End If
    End Sub

    Sub llenapila()

        'Por pedido de Andrea Torales 11/12/17 se modificó para que traiga todas las pilas aunque estén llenas.
        conex("Pila")
        sql5 = "SELECT  * From pila inner join STPILA on pila_id=stpila_pila where rtrim(pila_tipo)='" + Trim(txttipmad.Text) + "' order by stpila_pila" 'and stpila_llena<>'S' 
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        n = dt5.Rows.Count
        If n <> 0 Then
            cbpila.DataSource = dt5
            cbpila.DisplayMember = "pila_id"
            cbpila.ValueMember = "pila_id"
        Else
            mensaje = "No hay pilas disponibles"
            MetroMessageBox.Show(Me, "" + mensaje + "", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub



    Private Sub chkrech_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkrech.CheckedChanged
        If chkrech.Checked = True Then
            txtobs.Enabled = True

            gbconforme.Enabled = False
            rbpica.Checked = False
            rbpila.Checked = False
            destino = ""
            cbpila.DataSource = Nothing
            cbpila.Text = ""

        Else
            gbconforme.Enabled = True
            rbpica.Checked = True
            txtobs.Text = ""
            txtobs.Enabled = True
        End If
    End Sub




    Private Sub cbpila_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbpila.SelectionChangeCommitted
        sql1 = "SELECT (Pila.Pila_tn * 1000 - STPILA.stpila_stock) AS advertencia FROM STPILA INNER JOIN Pila ON STPILA.stpila_pila = Pila.Pila_ID where pila.pila_id='" + Trim(cbpila.Text) + "' "

        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)

        'Cantidad de stock que falta para llenar la pila
        alerta = dt1.Rows(0).Item("advertencia")

        'Busco el límite de pila
        limites("avisopila")
        limi = dt8.Rows(0).Item("param_valor")

        If alerta < limi Then
            limi = limi / 1000
            MetroMessageBox.Show(Me, "Faltan menos de '" + Str(limi) + "' TN para llenar la pila", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Sub ControlInicioPila()

        sql = "select * from STPILA where stpila_pila='" + Trim(cbpila.Text) + "' and stpila_stock=0"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count

        If n <> 0 Then
            sql1 = "update pila set pila_fecalta='" + FormatDateTime(Now, DateFormat.ShortDate) + "' where pila_id='" + Trim(cbpila.Text) + "'"
            cmd3 = New SqlCommand(sql1, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

        End If


    End Sub

    Private Sub txtremito_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtremito.KeyUp
        If e.KeyCode = Keys.Enter Then

            Call buscasiexistecamion()

            Application.DoEvents()

            If n = 1 Then

            Else

                Call cargacamion()

            End If


            If sen2 = 999 Then
                Exit Sub
            Else

                If n = 1 Then


                Else
                    Call busco()

                End If

            End If

        End If
    End Sub


    Private Sub cargacamion()
        Call buscadatoscamion(txtremito.Text)

        If cargamanual <> "M" Then


            If n <> 0 And sen = "n" Then
                campatente = dt.Rows(0).Item("patente")
                camticket = dt.Rows(0).Item("ticket")
                camfching = dt.Rows(0).Item("fecha_1")
                camhoraing = dt.Rows(0).Item("hora_1")

                'Flete
                camtcod = dt.Rows(0).Item("t_codigo")
                camtdesc = dt.Rows(0).Item("t_nombre")

                'Proveedor de madera
                camrcod = dt.Rows(0).Item("r_codigo")
                camrnombre = dt.Rows(0).Item("r_nombre")


                'controlar chofer y dni
                camchofer = dt.Rows(0).Item("chofer")
                camdni = Format(dt.Rows(0).Item("dni"), "##.###.###")
                campcod = dt.Rows(0).Item("p_codigo")
                campdesc = dt.Rows(0).Item("p_nombre")
                campbruto = Format(dt.Rows(0).Item("peso"), "0#.##")

                Try
                    If IsDBNull(dt.Rows(0).Item("aux4")) Or dt.Rows(0).Item("aux4") = "" Then
                        camAviso = FormatDateTime(camfching & " " & camhoraing)
                    Else
                        camAviso = Format(camfching & " " & dt.Rows(0).Item("aux4"))
                        If camAviso > FormatDateTime(camfching & " " & camhoraing) Then
                            camAviso = camAviso.AddDays(-1)
                        Else
                            camAviso = camAviso
                        End If
                    End If
                Catch
                    camAviso = FormatDateTime(camfching & " " & camhoraing)
                End Try


                Call buscasiexistecamion()
                Application.DoEvents()
                If n = 0 Then

                    Call guardarcamion()
                    Application.DoEvents()

                Else
                    Call yaexiste()
                End If

            Else


                mensaje = "Error 3: Remito no cargado en portería o camión ya retirado de planta"
                MetroMessageBox.Show(Me, "" + mensaje + "" & Chr(13) & "Luego de aceptar se guardará el error", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)


                'guardar error
                Call buscaenpendienteoreporte()
                Application.DoEvents()
                Call guardaLog()
                Application.DoEvents()
                sen2 = 999
            End If


        Else


            Call busco()

        End If

    End Sub

    Private Sub buscaenpendienteoreporte()
        'Busca en pendiente o en la tabla reporte para ver sí existe el remito --- Para GUARDAR EN LOG


        conexA("camion")
        sql = "SELECT * From PENDIENTES WHERE aux3='" + RTrim(txtremito.Text) + "'"
        daA = New OleDbDataAdapter(sql, cnnA)
        dt = New DataTable
        daA.Fill(dt)
        n = dt.Rows.Count

        If n = 0 Then
            pendiente = "N"

            conexA("camion")
            sql = "SELECT * From REPORTE WHERE aux3='" + RTrim(txtremito.Text) + "'"
            daA = New OleDbDataAdapter(sql, cnnA)
            dt = New DataTable
            daA.Fill(dt)
            n = dt.Rows.Count

            If n = 0 Then
                reporte = "N"
            Else
                reporte = "S"
            End If

        Else
            pendiente = "S"

        End If


    End Sub



    Private Sub guardaLog()

        campos = "log_fecha,log_error,log_datos,log_enpend,log_enrep,log_user"
        variables = "'" + Now + "','" + mensaje + "','" + txtremito.Text + "','" + pendiente + "','" + reporte + "','" + user + "'"
        sql4 = "Insert into LOG (" + campos + ") VALUES (" + variables + ")"
        cmd4 = New SqlCommand(sql4, cnn)
        cmd4.Connection.Open()
        cmd4.ExecuteNonQuery()
        cmd4.Connection.Close()
        mensaje = ""

    End Sub




    Private Sub buscadatoscamion(ByVal remito)
        Dim i As Integer
        conex("tipmadera")
        sql1 = "select tipmad_codbalanza as tipo from tipmad"
        da = New SqlDataAdapter(sql1, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count
        If n > 0 Then
            var = ""
            For i = 0 To n - 1
                var1 = Trim(dt.Rows(i).Item("tipo"))
                If i < (n - 1) Then
                    var = var + var1 + ", "
                Else
                    var = var + var1
                End If
            Next
        Else
            MetroMessageBox.Show(Me, "No existen relacion entre codigo de tipo de madera y codigo de balanza", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


        conex("camion")
        sql4 = "SELECT * From camion WHERE camion_nroremito='" + RTrim(remito) + "' and camion_marca='M'"
        da4 = New SqlDataAdapter(sql4, cnn)
        dt4 = New DataTable
        da4.Fill(dt4)
        n = dt4.Rows.Count
        Application.DoEvents()

        If n = 0 Then


            If sen = "n" Then
                conexA("camion")
                sql = "SELECT * From PENDIENTES WHERE aux3='" + RTrim(remito) + "' and p_codigo in (" + var + ") "
                daA = New OleDbDataAdapter(sql, cnnA)
                dt = New DataTable
                daA.Fill(dt)
                Application.DoEvents()
                n = dt.Rows.Count
            Else
                conex("Camion")
                sql5 = "SELECT * From camion where camion_nroremito='" + RTrim(remito) + "' and camion_pesoneto is null"
                da5 = New SqlDataAdapter(sql5, cnn)
                dt5 = New DataTable
                Application.DoEvents()
                da5.Fill(dt5)
                n = dt5.Rows.Count
            End If


        Else

            cargamanual = "M"

            If sen = "n" Then
                conex("Camion")
                sql5 = "SELECT * From camion where camion_nroremito='" + RTrim(remito) + "'"
                da5 = New SqlDataAdapter(sql5, cnn)
                dt5 = New DataTable
                da5.Fill(dt5)
                Application.DoEvents()
                n = dt5.Rows.Count
            End If

        End If




    End Sub

    Private Sub buscasiexistecamion()
        conex("Camion")
        sql5 = "SELECT * From camion where camion_nroremito='" + txtremito.Text + "' and (camion_marca='' or camion_marca is null)"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        Application.DoEvents()
        n = dt5.Rows.Count
    End Sub

    Private Sub guardarcamion()

        conex("Camion")

        campos = "camion_patente, camion_ticket, camion_fechaing,camion_horaing,camion_tcod, camion_tdesc, " &
                 "camion_rcod,camion_rnombre,camion_chofer, camion_dni,camion_pcod, camion_pdesc,camion_nroremito, camion_pesobruto,camion_aviso" ' 
        variables = "'" + Trim(campatente) + "','" + Trim(camticket) + "', '" + Trim(camfching) + "','" + Trim(camhoraing) + "', " &
        "'" + Trim(camtcod) + "','" + Trim(camtdesc) + "'," + Str(camrcod) + ",'" + Trim(camrnombre) + "','" + Trim(camchofer) + "', '" + Trim(camdni) + "','" + Trim(campcod) + "'," &
                    "'" + Trim(campdesc) + "','" + Trim(txtremito.Text) + "','" + Trim(campbruto) + "','" + Trim(camAviso) + "'"
        sql3 = "INSERT INTO camion (" + campos + ") VALUES (" + variables + ")" '
        cmd3 = New SqlCommand(sql3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()


    End Sub


End Class
