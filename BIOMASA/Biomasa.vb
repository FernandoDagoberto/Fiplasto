Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework.Controls
Imports MetroFramework

Public Class Biomasa
    Inherits MetroFramework.Forms.MetroForm
    Dim sql, sql1, sql2, sql3, sql4, sql5 As String
    Dim da, da1, da5 As New SqlDataAdapter
    Dim cmd, cmd2, cmd3, cmd4, cmd5 As SqlCommand
    Dim dt As DataTable = New DataTable
    Dim dt1 As DataTable = New DataTable
    Dim dt5 As DataTable = New DataTable
    Dim sen, campos, variables, idl, dias As String
    Dim destino, mensaje, tipomad As String

    Dim line, ms, stockfin, TnConsumo As Integer
    Friend WithEvents TabControl1 As MetroTabControl
    Friend WithEvents TPIngreso As MetroTabPage
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents gbconforme As System.Windows.Forms.GroupBox
    Friend WithEvents cbpila As MetroComboBox
    Friend WithEvents rbpila As MetroRadioButton
    Friend WithEvents rbConsumo As MetroRadioButton
    Friend WithEvents PBar As MetroProgressBar
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents txttipmad As MetroTextBox
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents btnbusco As MetroButton
    Friend WithEvents txtremito As MetroTextBox
    Friend WithEvents btncancel As MetroButton
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents txtTN As MetroTextBox
    Friend WithEvents cmdcancelar As MetroButton
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents Label9 As MetroLabel
    Friend WithEvents lbllena As System.Windows.Forms.ListBox
    Friend WithEvents cmdGuardarConsumo As MetroButton
    Friend WithEvents Label10 As MetroLabel
    Friend WithEvents Label11 As MetroLabel
    Friend WithEvents Label12 As MetroLabel
    Friend WithEvents cbPilaConsumo As MetroComboBox
    Friend WithEvents cbGrupoCon As MetroComboBox
    Friend WithEvents cbTurnoCon As MetroComboBox
    Friend WithEvents PBBuscar As MetroProgressBar
    Friend WithEvents txtCod As MetroTextBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Panel1 As MetroPanel
    Friend WithEvents btnSalir As MetroButton
    Friend WithEvents Panel3 As MetroPanel
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents dtFecha As MetroDateTime
    Friend WithEvents cbgrupo As MetroTextBox
    Friend WithEvents cbturno As MetroTextBox
    Friend WithEvents TPConsumo As MetroTabPage

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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Biomasa))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TPIngreso = New MetroFramework.Controls.MetroTabPage()
        Me.cbgrupo = New MetroFramework.Controls.MetroTextBox()
        Me.cbturno = New MetroFramework.Controls.MetroTextBox()
        Me.txtCod = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.PBBuscar = New MetroFramework.Controls.MetroProgressBar()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.gbconforme = New System.Windows.Forms.GroupBox()
        Me.cbpila = New MetroFramework.Controls.MetroComboBox()
        Me.rbpila = New MetroFramework.Controls.MetroRadioButton()
        Me.rbConsumo = New MetroFramework.Controls.MetroRadioButton()
        Me.PBar = New MetroFramework.Controls.MetroProgressBar()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.txttipmad = New MetroFramework.Controls.MetroTextBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.btnbusco = New MetroFramework.Controls.MetroButton()
        Me.txtremito = New MetroFramework.Controls.MetroTextBox()
        Me.btncancel = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.TPConsumo = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dtFecha = New MetroFramework.Controls.MetroDateTime()
        Me.txtTN = New MetroFramework.Controls.MetroTextBox()
        Me.cmdcancelar = New MetroFramework.Controls.MetroButton()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.lbllena = New System.Windows.Forms.ListBox()
        Me.cmdGuardarConsumo = New MetroFramework.Controls.MetroButton()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.cbPilaConsumo = New MetroFramework.Controls.MetroComboBox()
        Me.cbGrupoCon = New MetroFramework.Controls.MetroComboBox()
        Me.cbTurnoCon = New MetroFramework.Controls.MetroComboBox()
        Me.Panel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnSalir = New MetroFramework.Controls.MetroButton()
        Me.Panel3 = New MetroFramework.Controls.MetroPanel()
        Me.TabControl1.SuspendLayout()
        Me.TPIngreso.SuspendLayout()
        Me.gbconforme.SuspendLayout()
        Me.TPConsumo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TPIngreso)
        Me.TabControl1.Controls.Add(Me.TPConsumo)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(568, 388)
        Me.TabControl1.Style = MetroFramework.MetroColorStyle.Red
        Me.TabControl1.TabIndex = 28
        Me.TabControl1.UseSelectable = True
        '
        'TPIngreso
        '
        Me.TPIngreso.BackColor = System.Drawing.Color.CadetBlue
        Me.TPIngreso.Controls.Add(Me.cbgrupo)
        Me.TPIngreso.Controls.Add(Me.cbturno)
        Me.TPIngreso.Controls.Add(Me.txtCod)
        Me.TPIngreso.Controls.Add(Me.Label1)
        Me.TPIngreso.Controls.Add(Me.PBBuscar)
        Me.TPIngreso.Controls.Add(Me.Label4)
        Me.TPIngreso.Controls.Add(Me.Label3)
        Me.TPIngreso.Controls.Add(Me.gbconforme)
        Me.TPIngreso.Controls.Add(Me.PBar)
        Me.TPIngreso.Controls.Add(Me.btnguardar)
        Me.TPIngreso.Controls.Add(Me.txttipmad)
        Me.TPIngreso.Controls.Add(Me.Label6)
        Me.TPIngreso.Controls.Add(Me.btnbusco)
        Me.TPIngreso.Controls.Add(Me.txtremito)
        Me.TPIngreso.Controls.Add(Me.btncancel)
        Me.TPIngreso.Controls.Add(Me.Label2)
        Me.TPIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPIngreso.HorizontalScrollbarBarColor = True
        Me.TPIngreso.HorizontalScrollbarHighlightOnWheel = False
        Me.TPIngreso.HorizontalScrollbarSize = 10
        Me.TPIngreso.Location = New System.Drawing.Point(4, 38)
        Me.TPIngreso.Name = "TPIngreso"
        Me.TPIngreso.Padding = New System.Windows.Forms.Padding(3)
        Me.TPIngreso.Size = New System.Drawing.Size(560, 346)
        Me.TPIngreso.TabIndex = 0
        Me.TPIngreso.Text = "Ingreso"
        Me.TPIngreso.VerticalScrollbarBarColor = True
        Me.TPIngreso.VerticalScrollbarHighlightOnWheel = False
        Me.TPIngreso.VerticalScrollbarSize = 10
        '
        'cbgrupo
        '
        '
        '
        '
        Me.cbgrupo.CustomButton.Image = Nothing
        Me.cbgrupo.CustomButton.Location = New System.Drawing.Point(30, 2)
        Me.cbgrupo.CustomButton.Name = ""
        Me.cbgrupo.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.cbgrupo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.cbgrupo.CustomButton.TabIndex = 1
        Me.cbgrupo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cbgrupo.CustomButton.UseSelectable = True
        Me.cbgrupo.CustomButton.Visible = False
        Me.cbgrupo.Lines = New String() {"A"}
        Me.cbgrupo.Location = New System.Drawing.Point(274, 41)
        Me.cbgrupo.MaxLength = 32767
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cbgrupo.ReadOnly = True
        Me.cbgrupo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.cbgrupo.SelectedText = ""
        Me.cbgrupo.SelectionLength = 0
        Me.cbgrupo.SelectionStart = 0
        Me.cbgrupo.ShortcutsEnabled = True
        Me.cbgrupo.Size = New System.Drawing.Size(48, 20)
        Me.cbgrupo.TabIndex = 3
        Me.cbgrupo.Text = "A"
        Me.cbgrupo.UseSelectable = True
        Me.cbgrupo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cbgrupo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbturno
        '
        '
        '
        '
        Me.cbturno.CustomButton.Image = Nothing
        Me.cbturno.CustomButton.Location = New System.Drawing.Point(35, 2)
        Me.cbturno.CustomButton.Name = ""
        Me.cbturno.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.cbturno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.cbturno.CustomButton.TabIndex = 1
        Me.cbturno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cbturno.CustomButton.UseSelectable = True
        Me.cbturno.CustomButton.Visible = False
        Me.cbturno.Lines = New String() {"06-14"}
        Me.cbturno.Location = New System.Drawing.Point(169, 41)
        Me.cbturno.MaxLength = 32767
        Me.cbturno.Name = "cbturno"
        Me.cbturno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cbturno.ReadOnly = True
        Me.cbturno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.cbturno.SelectedText = ""
        Me.cbturno.SelectionLength = 0
        Me.cbturno.SelectionStart = 0
        Me.cbturno.ShortcutsEnabled = True
        Me.cbturno.Size = New System.Drawing.Size(53, 20)
        Me.cbturno.TabIndex = 2
        Me.cbturno.Text = "06-14"
        Me.cbturno.UseSelectable = True
        Me.cbturno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cbturno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCod
        '
        '
        '
        '
        Me.txtCod.CustomButton.Image = Nothing
        Me.txtCod.CustomButton.Location = New System.Drawing.Point(70, 2)
        Me.txtCod.CustomButton.Name = ""
        Me.txtCod.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtCod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCod.CustomButton.TabIndex = 1
        Me.txtCod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCod.CustomButton.UseSelectable = True
        Me.txtCod.CustomButton.Visible = False
        Me.txtCod.Lines = New String(-1) {}
        Me.txtCod.Location = New System.Drawing.Point(16, 112)
        Me.txtCod.MaxLength = 32767
        Me.txtCod.Name = "txtCod"
        Me.txtCod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCod.ReadOnly = True
        Me.txtCod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCod.SelectedText = ""
        Me.txtCod.SelectionLength = 0
        Me.txtCod.SelectionStart = 0
        Me.txtCod.ShortcutsEnabled = True
        Me.txtCod.Size = New System.Drawing.Size(88, 20)
        Me.txtCod.TabIndex = 4
        Me.txtCod.UseSelectable = True
        Me.txtCod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 27)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PBBuscar
        '
        Me.PBBuscar.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PBBuscar.Location = New System.Drawing.Point(17, 68)
        Me.PBBuscar.Name = "PBBuscar"
        Me.PBBuscar.Size = New System.Drawing.Size(118, 5)
        Me.PBBuscar.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(276, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 19)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Grupo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(169, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 19)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Turno"
        '
        'gbconforme
        '
        Me.gbconforme.BackColor = System.Drawing.Color.Transparent
        Me.gbconforme.Controls.Add(Me.cbpila)
        Me.gbconforme.Controls.Add(Me.rbpila)
        Me.gbconforme.Controls.Add(Me.rbConsumo)
        Me.gbconforme.Enabled = False
        Me.gbconforme.ForeColor = Color.Black
        Me.gbconforme.Location = New System.Drawing.Point(18, 142)
        Me.gbconforme.Name = "gbconforme"
        Me.gbconforme.Size = New System.Drawing.Size(142, 129)
        Me.gbconforme.TabIndex = 63
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
        Me.cbpila.Location = New System.Drawing.Point(21, 85)
        Me.cbpila.Name = "cbpila"
        Me.cbpila.Size = New System.Drawing.Size(86, 25)
        Me.cbpila.TabIndex = 2
        Me.cbpila.UseSelectable = True
        '
        'rbpila
        '
        Me.rbpila.AutoSize = True
        Me.rbpila.Checked = True
        Me.rbpila.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbpila.Location = New System.Drawing.Point(21, 64)
        Me.rbpila.Name = "rbpila"
        Me.rbpila.Size = New System.Drawing.Size(53, 15)
        Me.rbpila.TabIndex = 1
        Me.rbpila.TabStop = True
        Me.rbpila.Text = "A pila"
        Me.rbpila.UseSelectable = True
        '
        'rbConsumo
        '
        Me.rbConsumo.AutoSize = True
        Me.rbConsumo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbConsumo.Location = New System.Drawing.Point(21, 31)
        Me.rbConsumo.Name = "rbConsumo"
        Me.rbConsumo.Size = New System.Drawing.Size(75, 15)
        Me.rbConsumo.TabIndex = 0
        Me.rbConsumo.Text = "Consumo"
        Me.rbConsumo.UseSelectable = True
        '
        'PBar
        '
        Me.PBar.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PBar.Location = New System.Drawing.Point(171, 186)
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(191, 12)
        Me.PBar.TabIndex = 61
        Me.PBar.Visible = False
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(124, 277)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(88, 24)
        Me.btnguardar.TabIndex = 6
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseSelectable = True
        Me.btnguardar.Visible = False
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
        Me.txttipmad.Location = New System.Drawing.Point(138, 112)
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
        Me.txttipmad.TabIndex = 5
        Me.txttipmad.UseSelectable = True
        Me.txttipmad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttipmad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(136, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 23)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Tipo Madera"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnbusco
        '
        Me.btnbusco.Location = New System.Drawing.Point(106, 42)
        Me.btnbusco.Name = "btnbusco"
        Me.btnbusco.Size = New System.Drawing.Size(32, 20)
        Me.btnbusco.TabIndex = 1
        Me.btnbusco.Text = "..."
        Me.btnbusco.UseSelectable = True
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
        Me.txtremito.Location = New System.Drawing.Point(18, 42)
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
        Me.txtremito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtremito.UseSelectable = True
        Me.txtremito.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtremito.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncancel.Location = New System.Drawing.Point(44, 277)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 24)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(18, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Remito"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TPConsumo
        '
        Me.TPConsumo.BackColor = System.Drawing.Color.CadetBlue
        Me.TPConsumo.Controls.Add(Me.MetroLabel1)
        Me.TPConsumo.Controls.Add(Me.dtFecha)
        Me.TPConsumo.Controls.Add(Me.txtTN)
        Me.TPConsumo.Controls.Add(Me.cmdcancelar)
        Me.TPConsumo.Controls.Add(Me.Label7)
        Me.TPConsumo.Controls.Add(Me.Label9)
        Me.TPConsumo.Controls.Add(Me.lbllena)
        Me.TPConsumo.Controls.Add(Me.cmdGuardarConsumo)
        Me.TPConsumo.Controls.Add(Me.Label10)
        Me.TPConsumo.Controls.Add(Me.Label11)
        Me.TPConsumo.Controls.Add(Me.Label12)
        Me.TPConsumo.Controls.Add(Me.cbPilaConsumo)
        Me.TPConsumo.Controls.Add(Me.cbGrupoCon)
        Me.TPConsumo.Controls.Add(Me.cbTurnoCon)
        Me.TPConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPConsumo.HorizontalScrollbarBarColor = True
        Me.TPConsumo.HorizontalScrollbarHighlightOnWheel = False
        Me.TPConsumo.HorizontalScrollbarSize = 10
        Me.TPConsumo.Location = New System.Drawing.Point(4, 35)
        Me.TPConsumo.Name = "TPConsumo"
        Me.TPConsumo.Padding = New System.Windows.Forms.Padding(3)
        Me.TPConsumo.Size = New System.Drawing.Size(560, 349)
        Me.TPConsumo.TabIndex = 1
        Me.TPConsumo.Text = "Consumo"
        Me.TPConsumo.VerticalScrollbarBarColor = True
        Me.TPConsumo.VerticalScrollbarHighlightOnWheel = False
        Me.TPConsumo.VerticalScrollbarSize = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroLabel1.Location = New System.Drawing.Point(18, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel1.TabIndex = 43
        Me.MetroLabel1.Text = "Fecha"
        '
        'dtFecha
        '
        Me.dtFecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(18, 33)
        Me.dtFecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(98, 25)
        Me.dtFecha.TabIndex = 42
        '
        'txtTN
        '
        '
        '
        '
        Me.txtTN.CustomButton.Image = Nothing
        Me.txtTN.CustomButton.Location = New System.Drawing.Point(69, 2)
        Me.txtTN.CustomButton.Name = ""
        Me.txtTN.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtTN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTN.CustomButton.TabIndex = 1
        Me.txtTN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTN.CustomButton.UseSelectable = True
        Me.txtTN.CustomButton.Visible = False
        Me.txtTN.Lines = New String(-1) {}
        Me.txtTN.Location = New System.Drawing.Point(18, 188)
        Me.txtTN.MaxLength = 32767
        Me.txtTN.Name = "txtTN"
        Me.txtTN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTN.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTN.SelectedText = ""
        Me.txtTN.SelectionLength = 0
        Me.txtTN.SelectionStart = 0
        Me.txtTN.ShortcutsEnabled = True
        Me.txtTN.Size = New System.Drawing.Size(87, 20)
        Me.txtTN.TabIndex = 41
        Me.txtTN.UseSelectable = True
        Me.txtTN.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTN.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Location = New System.Drawing.Point(29, 241)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdcancelar.TabIndex = 38
        Me.cmdcancelar.Text = "&Cancelar"
        Me.cmdcancelar.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(375, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Stock Pilas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(15, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 19)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Cantidad TN:"
        '
        'lbllena
        '
        Me.lbllena.BackColor = System.Drawing.SystemColors.Menu
        Me.lbllena.DisplayMember = "1"
        Me.lbllena.FormattingEnabled = True
        Me.lbllena.Location = New System.Drawing.Point(251, 35)
        Me.lbllena.Name = "lbllena"
        Me.lbllena.Size = New System.Drawing.Size(303, 95)
        Me.lbllena.TabIndex = 33
        Me.lbllena.ValueMember = "1"
        '
        'cmdGuardarConsumo
        '
        Me.cmdGuardarConsumo.Location = New System.Drawing.Point(134, 241)
        Me.cmdGuardarConsumo.Name = "cmdGuardarConsumo"
        Me.cmdGuardarConsumo.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardarConsumo.TabIndex = 28
        Me.cmdGuardarConsumo.Text = "&Guardar"
        Me.cmdGuardarConsumo.UseSelectable = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(15, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 19)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Pila"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(121, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 19)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Grupo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(15, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 19)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Turno"
        '
        'cbPilaConsumo
        '
        Me.cbPilaConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPilaConsumo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbPilaConsumo.FormattingEnabled = True
        Me.cbPilaConsumo.ItemHeight = 19
        Me.cbPilaConsumo.Location = New System.Drawing.Point(18, 138)
        Me.cbPilaConsumo.Name = "cbPilaConsumo"
        Me.cbPilaConsumo.Size = New System.Drawing.Size(191, 25)
        Me.cbPilaConsumo.TabIndex = 27
        Me.cbPilaConsumo.UseSelectable = True
        '
        'cbGrupoCon
        '
        Me.cbGrupoCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGrupoCon.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbGrupoCon.FormattingEnabled = True
        Me.cbGrupoCon.ItemHeight = 19
        Me.cbGrupoCon.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbGrupoCon.Location = New System.Drawing.Point(124, 88)
        Me.cbGrupoCon.Name = "cbGrupoCon"
        Me.cbGrupoCon.Size = New System.Drawing.Size(67, 25)
        Me.cbGrupoCon.TabIndex = 26
        Me.cbGrupoCon.UseSelectable = True
        '
        'cbTurnoCon
        '
        Me.cbTurnoCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTurnoCon.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbTurnoCon.FormattingEnabled = True
        Me.cbTurnoCon.ItemHeight = 19
        Me.cbTurnoCon.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbTurnoCon.Location = New System.Drawing.Point(18, 88)
        Me.cbTurnoCon.Name = "cbTurnoCon"
        Me.cbTurnoCon.Size = New System.Drawing.Size(66, 25)
        Me.cbTurnoCon.TabIndex = 25
        Me.cbTurnoCon.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.HorizontalScrollbarBarColor = True
        Me.Panel1.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel1.HorizontalScrollbarSize = 10
        Me.Panel1.Location = New System.Drawing.Point(5, 415)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 33)
        Me.Panel1.Style = MetroFramework.MetroColorStyle.Red
        Me.Panel1.TabIndex = 72
        Me.Panel1.VerticalScrollbarBarColor = True
        Me.Panel1.VerticalScrollbarHighlightOnWheel = False
        Me.Panel1.VerticalScrollbarSize = 10
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(474, 6)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseSelectable = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TabControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.HorizontalScrollbarBarColor = True
        Me.Panel3.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel3.HorizontalScrollbarSize = 10
        Me.Panel3.Location = New System.Drawing.Point(5, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(568, 388)
        Me.Panel3.Style = MetroFramework.MetroColorStyle.Red
        Me.Panel3.TabIndex = 74
        Me.Panel3.VerticalScrollbarBarColor = True
        Me.Panel3.VerticalScrollbarHighlightOnWheel = False
        Me.Panel3.VerticalScrollbarSize = 10
        '
        'Biomasa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(578, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Biomasa"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Biomasa"
        Me.TabControl1.ResumeLayout(False)
        Me.TPIngreso.ResumeLayout(False)
        Me.TPIngreso.PerformLayout()
        Me.gbconforme.ResumeLayout(False)
        Me.gbconforme.PerformLayout()
        Me.TPConsumo.ResumeLayout(False)
        Me.TPConsumo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BIOPila_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabControl1_SelectedIndexChanged(sender, e)





    End Sub

    Private Sub habilita()
        '     txtcod.Enabled = True
        '    CBtipo.Enabled = True
        '   TXTtn.Enabled = True
    End Sub
    Private Sub buscasiexiste(ByVal pila As String)
        conex("pila")
        sql1 = "SELECT pila_id From pila where pila_id='" + Trim(pila) + "'"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
    End Sub

    Private Sub deshabilita()
        '    txtcod.Enabled = False
        '   CBtipo.Enabled = False
        '  TXTtn.Enabled = False
        ' txtfecalta.Enabled = False
    End Sub
    Private Sub limpia()
        If TabControl1.SelectedTab Is TPIngreso Then
            txtremito.Text = ""
            txtCod.Text = ""
            txttipmad.Text = ""
            rbConsumo.Checked = True
            gbconforme.Enabled = False

        ElseIf TabControl1.SelectedTab Is TPConsumo Then
            txtTN.Text = ""
        End If




    End Sub
    Private Sub buscadatos()
        '    conex("pila")
        '   sql = "SELECT * From pila"
        '  da = New SqlDataAdapter(sql, cnn)
        ' dt = New DataTable
        'da.Fill(dt)
    End Sub

    Private Sub bloquea()
        'txtcod.Enabled = False
        'CBtipo.Enabled = False
        'TXTtn.Enabled = False
        'txtfecalta.Enabled = False
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call limpia()
        Call deshabilita()
        btncancel.Visible = False

    End Sub
    Private Sub guardaBIOMOV()

        If rbpila.Checked = True Then
            destino = "P"
        Else
            destino = "C"
        End If



        campos = "ingegr,nroremito,tipmad,destino,pila,neto,fecha,turno,grupo,userid"

        variables = "'I','" + Trim(txtremito.Text) + "','" + Trim(campcod) + "', '" + destino + "','" + Trim(cbpila.Text) + "', " &
                    " 0,'" + Now + "','" + cbturno.Text + "','" + cbgrupo.Text + "','" + user + "'"

        Try

            sql3 = ("INSERT INTO BIOMOV (" + campos + ") VALUES (" + variables + ")")
            cmd3 = New SqlCommand(sql3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

        Catch ex As Exception
            MetroMessageBox.Show(Me, "No se pudieron guardar los datos en BIOMOV" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Elimina carga de datos de la base BIOCAMION
            Call EliminaCarga(txtremito.Text)
            sen1 = 99

        End Try



    End Sub


    Sub llenastpila()
        'campos = "stpila_pila,stpila_stock,stpila_llena"
        ''variables = "'" + Trim(txtcod.Text) + "','0','N'"
        'sql3 = "INSERT INTO STPILA (" + campos + ") VALUES (" + variables + ")"
        'cmd3 = New SqlCommand(sql3, cnn)
        'cmd3.Connection.Open()
        'cmd3.ExecuteNonQuery()
        'cmd3.Connection.Close()
    End Sub

    Private Sub BioTipMad()
        Dim i As Integer
        conexA("tipmadera")
        sql1 = "select codigo from productos where info like '%bio%'"
        daA = New OleDbDataAdapter(sql1, cnnA)
        dt = New DataTable
        daA.Fill(dt)
        Application.DoEvents()
        n = dt.Rows.Count
        If n > 0 Then
            var = ""
            For i = 0 To n - 1
                var1 = Trim(dt.Rows(i).Item("codigo"))
                If i < (n - 1) Then
                    var = var + var1 + ", "
                Else
                    var = var + var1
                End If
            Next
        Else
            MetroMessageBox.Show(Me, "No existen relacion entre codigo de tipo de madera y codigo de balanza", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnbusco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbusco.Click

        btnguardar.Visible = False


        PBBuscar.Value = 25
        Call buscoEnBioCamion()
        'Sí existe muestro msj
        If n = 1 Then
            MetroMessageBox.Show(Me, "Nro de Remito ya cargado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PBBuscar.Value = 0
            txtremito.Text = ""
            Exit Sub
        Else
            PBBuscar.Value = 50
            Call buscoEnReporte()
            If n = 1 Then
                marca = "R"
                Call cargacamion()
                PBBuscar.Value = 0
                btnguardar.Focus()
                Exit Sub

            Else
                PBBuscar.Value = 75
                Call buscoEnPendientes()
                If n = 1 Then
                    marca = "P"
                    Call cargacamion()
                    PBBuscar.Value = 0
                    btnguardar.Focus()
                    Exit Sub
                Else
                    MetroMessageBox.Show(Me, "Número de remito no existe o no fue cargado por portería", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PBBuscar.Value = 0
                End If
            End If
        End If

    End Sub




    Private Sub buscoEnBioCamion()
        conex("Camion")
        sql5 = "SELECT * From Biocamion where nroremito='" + txtremito.Text + "'"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        Application.DoEvents()
        n = dt5.Rows.Count
    End Sub

    Private Sub buscoEnReporte()
        conexA("camion")
        sql = "SELECT * From Reporte WHERE aux3='" + RTrim(txtremito.Text) + "' and p_codigo in (" + var + ")"
        daA = New OleDbDataAdapter(sql, cnnA)
        dt = New DataTable
        daA.Fill(dt)
        cnnA.Close()
        Application.DoEvents()
        n = dt.Rows.Count
    End Sub

    Private Sub buscoEnPendientes()
        conexA("camion")
        sql = "SELECT * From pendientes WHERE aux3='" + RTrim(txtremito.Text) + "' and p_codigo in (" + var + ")"
        daA = New OleDbDataAdapter(sql, cnnA)
        dt = New DataTable
        daA.Fill(dt)
        Application.DoEvents()
        n = dt.Rows.Count
    End Sub


    Private Sub cargacamion()
        If n > 0 Then
            campatente = dt.Rows(0).Item("patente")
            camticket = dt.Rows(0).Item("ticket")
            camfching = dt.Rows(0).Item("fecha_1")
            camhoraing = dt.Rows(0).Item("hora_1")

            'Flete
            camtcod = dt.Rows(0).Item("t_codigo")
            camtdesc = dt.Rows(0).Item("t_nombre")

            'Proveedor de madera
            camrnombre = dt.Rows(0).Item("r_nombre")
            camrcod = dt.Rows(0).Item("r_codigo")


            'controlar chofer y dni
            camchofer = dt.Rows(0).Item("chofer")
            camdni = Format(dt.Rows(0).Item("dni"), "##.###.###")

            'Tipo de madera
            campcod = dt.Rows(0).Item("p_codigo")
            txtCod.Text = campcod
            campdesc = dt.Rows(0).Item("p_nombre")
            txttipmad.Text = campdesc

            If marca = "R" Then
                campbruto = Format(dt.Rows(0).Item("bruto"), "0#.##")
            ElseIf marca = "P" Then
                campbruto = Format(dt.Rows(0).Item("peso"), "0#.##")
            End If

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

            'habilitar panel consumo o pila

            btnguardar.Visible = True
            txtremito.Enabled = False
            gbconforme.Enabled = True

        End If


    End Sub

    Private Sub guardarcamion()

        conex("BioCamion")
        Try


            campos = "patente, ticket, fechaing,horaing,tcod, tdesc, " &
                     "rcod,rnombre,chofer, dni,pcod, pdesc,nroremito, pesobruto,aviso" ' 
            variables = "'" + Trim(campatente) + "','" + Trim(camticket) + "', '" + Trim(camfching) + "','" + Trim(camhoraing) + "', " &
            "'" + Trim(camtcod) + "','" + Trim(camtdesc) + "'," + Trim(camrcod) + ",'" + Trim(camrnombre) + "','" + Trim(camchofer) + "', '" + Trim(camdni) + "','" + Trim(campcod) + "'," &
                        "'" + Trim(campdesc) + "','" + Trim(txtremito.Text) + "','" + Trim(campbruto) + "','" + Trim(camAviso) + "'"
            sql3 = "INSERT INTO BioCamion (" + campos + ") VALUES (" + variables + ")" '
            cmd3 = New SqlCommand(sql3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

        Catch ex As Exception
            MetroMessageBox.Show(Me, "No se pudieron guardar los datos en BIOCAMION" + ex.Message, "Error", MessageBoxButtons.OK)
            sen1 = 99

        End Try


    End Sub

    Sub llenapila()
        conex("BioPila")
        sql5 = "SELECT  * From BIOPILA  where rtrim(tipo)='" + Trim(txttipmad.Text) + "'order by id"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        n = dt5.Rows.Count
        If n <> 0 Then
            cbpila.DataSource = dt5
            cbpila.DisplayMember = "id"
            cbpila.ValueMember = "id"
        Else

        End If

    End Sub

    Private Sub opcion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbpila.CheckedChanged, rbConsumo.CheckedChanged

        If rbConsumo.Checked = True Then
            destino = "C"
            cbpila.Text = Nothing
            cbpila.Enabled = False
        Else
            cbpila.Enabled = True
            destino = "P"
            Call llenapila()
        End If

    End Sub


    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Call guardar()
    End Sub


    Private Sub guardar()

        ' Controlo que hayan completado todos los campos
        If String.IsNullOrEmpty(txtremito.Text) Then

            MetroMessageBox.Show(Me, "El campo Nro remito es obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtremito.Focus()
            txtremito.SelectAll()
            Exit Sub

        ElseIf String.IsNullOrEmpty(cbgrupo.Text) Or String.IsNullOrEmpty(cbturno.Text) Then
            MetroMessageBox.Show(Me, "Completar Turno y Grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        ElseIf rbpila.Checked = True And String.IsNullOrEmpty(cbpila.Text) Then
            MetroMessageBox.Show(Me, "Seleccionar número de pila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbpila.SelectAll()
            Exit Sub

        End If



        Call guardarcamion()
        If sen1 = 99 Then
            sen1 = 0
            Exit Sub

        Else
            'Guardo los datos en BIOMOV una vez que ya fue guardado en BIOCAMION
            Call guardaBIOMOV()
            If sen1 = 99 Then
                sen1 = 0
                Exit Sub
            End If

        End If



        btnguardar.Visible = False
        txtremito.Enabled = True
        Call limpia()



    End Sub



    Private Sub EliminaCarga(ByVal remito)

        conex("BioCamion")
        Try
            sql3 = "DELETE FROM BioCamion WHERE nroremito= '" + remito + "'"
            cmd3 = New SqlCommand(sql3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub



    Private Sub btncancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click

        btnguardar.Visible = False
        txtremito.Enabled = True
        Call limpia()
    End Sub

    Sub llenapilaConsumo()

        sql = "SELECT ('Pila Nro: ' + ltrim(str(pila)) + ' - ' +  ltrim(cast(stock as float)/1000) + ' TN '  ) as StockPila,* From BIOPila inner join BioStock on ltrim(id)=ltrim(pila) where stock>0 order by pila"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        cbPilaConsumo.DataSource = dt
        cbPilaConsumo.DisplayMember = "stockpila"
        cbPilaConsumo.ValueMember = "id"

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TPIngreso Then

            Call bloquea()
            Call BioTipMad()

        ElseIf TabControl1.SelectedTab Is TPConsumo Then

            Call llenapilaConsumo()
            Call muestraStock()

        End If

    End Sub



    Sub muestraStock()
        sql3 = "select ('Pila Nro: ' + ltrim(str(pila)) + ' - ' +  tipo + ' - ' +  ltrim(cast(stock as float)/1000) + ' TN '  ) as PilasHab,* from BIOSTOCK inner join BIOPILA on ltrim(pila)=ltrim(id) order by pila"
        da3 = New SqlDataAdapter(sql3, cnn)
        dt3 = New DataTable
        da3.Fill(dt3)
        n = dt3.Rows.Count
        If n <> 0 Then
            lbllena.DataSource = dt3
            lbllena.DisplayMember = "PilasHab"
            lbllena.ValueMember = "pila"

        End If

    End Sub


    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardarConsumo.Click


        If String.IsNullOrEmpty(txtTN.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar TN", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txttipmad.Focus()
            Exit Sub
        ElseIf String.IsNullOrEmpty(cbTurnoCon.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar turno", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbturno.Focus()
            Exit Sub
        ElseIf String.IsNullOrEmpty(cbGrupoCon.Text) Then
            MetroMessageBox.Show(Me, "Favor de completar grupo", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbgrupo.Focus()
            Exit Sub

        Else

            Call control()

            If sen1 = 999 Then
                Exit Sub
            End If


            Call buscamax()
            If IsDBNull(dt1.Rows(0).Item("ult")) Then
                ultnro = "1"
            Else
                ultnro = dt1.Rows(0).Item("ult") + 1
            End If

            If stockfin > 0 Then
                TnConsumo = stockfin
            Else
                TnConsumo = (txtTN.Text * 1000)

            End If

            campos = "ingegr,nroremito,tipmad,pila,neto,fecha,turno,grupo,userid"
            variables = "'E','" + ultnro + "','" + tipomad + "','" + Str(cbPilaConsumo.SelectedValue) + "','" + Str(TnConsumo) + "','" + dtFecha.Value + "','" + cbTurnoCon.Text + "','" + cbGrupoCon.Text + "','" + user + "'"
            sql4 = "INSERT INTO BIOMOV (" + campos + ") VALUES (" + variables + ")"
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()

            Call ActualizaStock()
            MetroMessageBox.Show(Me, "Consumo generado", "", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Call limpia()
            TabControl1_SelectedIndexChanged(sender, e)

        End If


    End Sub

    Private Sub buscamax()
        conex("BIOMOV")
        sql1 = "SELECT max(nroremito)as ult From BIOMOV where ingegr='E'"
        da1 = New SqlDataAdapter(sql1, cnn)
        dt1 = New DataTable
        da1.Fill(dt1)
    End Sub

    Sub ActualizaStock()

        If stockfin > 0 Then
            stock = 0
            sql2 = "update BioStock set stock='" + Str(stock) + "' where pila='" + Str(cbPilaConsumo.SelectedValue) + "'"

            'Blanquea fecha en Pila
            sql3 = "update BioPila set fecalta=null where id='" + Trim(Str(cbPilaConsumo.SelectedValue)) + "'"
            cmd2 = New SqlCommand(sql3, cnn)
            cmd2.Connection.Open()
            cmd2.ExecuteNonQuery()
            cmd2.Connection.Close()

        Else
            stock = stock - (TnConsumo)
            sql2 = "update BioStock set stock='" + Str(stock) + "' where pila='" + Trim(Str(cbPilaConsumo.SelectedValue)) + "'"
        End If

        cmd2 = New SqlCommand(sql2, cnn)
        cmd2.Connection.Open()
        cmd2.ExecuteNonQuery()
        cmd2.Connection.Close()

    End Sub


    Sub control()

        sql2 = "select * from BIOPila INNER JOIN BioStock ON id=pila  where pila='" + Trim(cbPilaConsumo.SelectedValue) + "'"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)
        tipomad = dt2.Rows(0).Item("codMad")
        stock = dt2.Rows(0).Item("stock")

        'Controlo cuanto es mí stock de pila contra lo que ingreso el usuario
        'En caso de ser mayor debería mostrarle un mensaje diciendo cuanto es el contenido real 
        'de la pila y si desea consumirlo.
        If stock <= (txtTN.Text * 1000) Then

            msg = MetroMessageBox.Show(Me, "El stock de Pila es: " + Str(dt2.Rows(0).Item("stock") / 1000) + Chr(13) + " En caso de aceptar va a consumir toda la madera", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If msg = 1 Then
                stockfin = dt2.Rows(0).Item("stock")
            Else
                txtTN.Focus()
                sen1 = 999
                Exit Sub
            End If
        Else
            stockfin = 0

        End If
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class
