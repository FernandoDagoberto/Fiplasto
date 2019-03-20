Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMProdAlis
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMProdAlis))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.btnSalir = New MetroFramework.Controls.MetroTile()
        Me.btnGuardar = New MetroFramework.Controls.MetroTile()
        Me.btnBorrar = New MetroFramework.Controls.MetroTile()
        Me.btnEditar = New MetroFramework.Controls.MetroTile()
        Me.BtnNuevo = New MetroFramework.Controls.MetroTile()
        Me.Panel2 = New MetroFramework.Controls.MetroPanel()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.txtFactor = New MetroFramework.Controls.MetroTextBox()
        Me.txtEspesor = New MetroFramework.Controls.MetroTextBox()
        Me.txtDescrp = New MetroFramework.Controls.MetroTextBox()
        Me.txtLargo = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txtcod = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.btncancel = New MetroFramework.Controls.MetroButton()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.txtAncho = New MetroFramework.Controls.MetroTextBox()
        Me.dg = New MetroFramework.Controls.MetroGrid()
        Me.MetroPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanel1.Controls.Add(Me.MetroTile1)
        Me.MetroPanel1.Controls.Add(Me.btnSalir)
        Me.MetroPanel1.Controls.Add(Me.btnGuardar)
        Me.MetroPanel1.Controls.Add(Me.btnBorrar)
        Me.MetroPanel1.Controls.Add(Me.btnEditar)
        Me.MetroPanel1.Controls.Add(Me.BtnNuevo)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(5, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(847, 41)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroPanel1.TabIndex = 31
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
        Me.MetroTile1.Location = New System.Drawing.Point(445, 0)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(402, 41)
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
        Me.btnSalir.Location = New System.Drawing.Point(356, 0)
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
        Me.btnGuardar.Location = New System.Drawing.Point(267, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(89, 41)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.TileImage = CType(resources.GetObject("btnGuardar.TileImage"), System.Drawing.Image)
        Me.btnGuardar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseTileImage = True
        '
        'btnBorrar
        '
        Me.btnBorrar.ActiveControl = Nothing
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBorrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBorrar.Location = New System.Drawing.Point(178, 0)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(89, 41)
        Me.btnBorrar.TabIndex = 4
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrar.TileImage = CType(resources.GetObject("btnBorrar.TileImage"), System.Drawing.Image)
        Me.btnBorrar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnBorrar.UseSelectable = True
        Me.btnBorrar.UseTileImage = True
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
        Me.BtnNuevo.TabIndex = 2
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.TileImage = CType(resources.GetObject("BtnNuevo.TileImage"), System.Drawing.Image)
        Me.BtnNuevo.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.BtnNuevo.UseSelectable = True
        Me.BtnNuevo.UseTileImage = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtFactor)
        Me.Panel2.Controls.Add(Me.txtEspesor)
        Me.Panel2.Controls.Add(Me.txtDescrp)
        Me.Panel2.Controls.Add(Me.txtLargo)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtcod)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtAncho)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.HorizontalScrollbarBarColor = True
        Me.Panel2.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel2.HorizontalScrollbarSize = 10
        Me.Panel2.Location = New System.Drawing.Point(5, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(346, 360)
        Me.Panel2.TabIndex = 33
        Me.Panel2.VerticalScrollbarBarColor = True
        Me.Panel2.VerticalScrollbarHighlightOnWheel = False
        Me.Panel2.VerticalScrollbarSize = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(192, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 19)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Espesor:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(21, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 19)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Factor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFactor
        '
        '
        '
        '
        Me.txtFactor.CustomButton.Image = Nothing
        Me.txtFactor.CustomButton.Location = New System.Drawing.Point(36, 2)
        Me.txtFactor.CustomButton.Name = ""
        Me.txtFactor.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtFactor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFactor.CustomButton.TabIndex = 1
        Me.txtFactor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFactor.CustomButton.UseSelectable = True
        Me.txtFactor.CustomButton.Visible = False
        Me.txtFactor.Enabled = False
        Me.txtFactor.Lines = New String(-1) {}
        Me.txtFactor.Location = New System.Drawing.Point(109, 171)
        Me.txtFactor.MaxLength = 32767
        Me.txtFactor.Name = "txtFactor"
        Me.txtFactor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFactor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFactor.SelectedText = ""
        Me.txtFactor.SelectionLength = 0
        Me.txtFactor.SelectionStart = 0
        Me.txtFactor.ShortcutsEnabled = True
        Me.txtFactor.Size = New System.Drawing.Size(54, 20)
        Me.txtFactor.TabIndex = 48
        Me.txtFactor.Tag = "Factor"
        Me.txtFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFactor.UseSelectable = True
        Me.txtFactor.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFactor.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEspesor
        '
        '
        '
        '
        Me.txtEspesor.CustomButton.Image = Nothing
        Me.txtEspesor.CustomButton.Location = New System.Drawing.Point(42, 2)
        Me.txtEspesor.CustomButton.Name = ""
        Me.txtEspesor.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtEspesor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEspesor.CustomButton.TabIndex = 1
        Me.txtEspesor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEspesor.CustomButton.UseSelectable = True
        Me.txtEspesor.CustomButton.Visible = False
        Me.txtEspesor.Enabled = False
        Me.txtEspesor.Lines = New String(-1) {}
        Me.txtEspesor.Location = New System.Drawing.Point(192, 131)
        Me.txtEspesor.MaxLength = 32767
        Me.txtEspesor.Name = "txtEspesor"
        Me.txtEspesor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEspesor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEspesor.SelectedText = ""
        Me.txtEspesor.SelectionLength = 0
        Me.txtEspesor.SelectionStart = 0
        Me.txtEspesor.ShortcutsEnabled = True
        Me.txtEspesor.Size = New System.Drawing.Size(60, 20)
        Me.txtEspesor.TabIndex = 4
        Me.txtEspesor.Tag = "Espesor"
        Me.txtEspesor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEspesor.UseSelectable = True
        Me.txtEspesor.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEspesor.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDescrp
        '
        '
        '
        '
        Me.txtDescrp.CustomButton.Image = Nothing
        Me.txtDescrp.CustomButton.Location = New System.Drawing.Point(213, 2)
        Me.txtDescrp.CustomButton.Name = ""
        Me.txtDescrp.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtDescrp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescrp.CustomButton.TabIndex = 1
        Me.txtDescrp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescrp.CustomButton.UseSelectable = True
        Me.txtDescrp.CustomButton.Visible = False
        Me.txtDescrp.Enabled = False
        Me.txtDescrp.Lines = New String(-1) {}
        Me.txtDescrp.Location = New System.Drawing.Point(109, 67)
        Me.txtDescrp.MaxLength = 32767
        Me.txtDescrp.Name = "txtDescrp"
        Me.txtDescrp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescrp.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescrp.SelectedText = ""
        Me.txtDescrp.SelectionLength = 0
        Me.txtDescrp.SelectionStart = 0
        Me.txtDescrp.ShortcutsEnabled = True
        Me.txtDescrp.Size = New System.Drawing.Size(231, 20)
        Me.txtDescrp.TabIndex = 1
        Me.txtDescrp.Tag = "Descripción"
        Me.txtDescrp.UseSelectable = True
        Me.txtDescrp.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescrp.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLargo
        '
        '
        '
        '
        Me.txtLargo.CustomButton.Image = Nothing
        Me.txtLargo.CustomButton.Location = New System.Drawing.Point(36, 2)
        Me.txtLargo.CustomButton.Name = ""
        Me.txtLargo.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtLargo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLargo.CustomButton.TabIndex = 1
        Me.txtLargo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLargo.CustomButton.UseSelectable = True
        Me.txtLargo.CustomButton.Visible = False
        Me.txtLargo.Enabled = False
        Me.txtLargo.Lines = New String(-1) {}
        Me.txtLargo.Location = New System.Drawing.Point(109, 131)
        Me.txtLargo.MaxLength = 32767
        Me.txtLargo.Name = "txtLargo"
        Me.txtLargo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLargo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLargo.SelectedText = ""
        Me.txtLargo.SelectionLength = 0
        Me.txtLargo.SelectionStart = 0
        Me.txtLargo.ShortcutsEnabled = True
        Me.txtLargo.Size = New System.Drawing.Size(54, 20)
        Me.txtLargo.TabIndex = 3
        Me.txtLargo.Tag = "Largo"
        Me.txtLargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLargo.UseSelectable = True
        Me.txtLargo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLargo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Descripción:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.txtcod.Enabled = False
        Me.txtcod.Lines = New String(-1) {}
        Me.txtcod.Location = New System.Drawing.Point(109, 36)
        Me.txtcod.MaxLength = 32767
        Me.txtcod.Name = "txtcod"
        Me.txtcod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcod.SelectedText = ""
        Me.txtcod.SelectionLength = 0
        Me.txtcod.SelectionStart = 0
        Me.txtcod.ShortcutsEnabled = True
        Me.txtcod.Size = New System.Drawing.Size(88, 20)
        Me.txtcod.TabIndex = 0
        Me.txtcod.Tag = "Código"
        Me.txtcod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtcod.UseSelectable = True
        Me.txtcod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Código:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncancel.Location = New System.Drawing.Point(192, 233)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 24)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseSelectable = True
        Me.btncancel.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(106, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Largo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(21, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Ancho:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAncho
        '
        '
        '
        '
        Me.txtAncho.CustomButton.Image = Nothing
        Me.txtAncho.CustomButton.Location = New System.Drawing.Point(37, 2)
        Me.txtAncho.CustomButton.Name = ""
        Me.txtAncho.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtAncho.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAncho.CustomButton.TabIndex = 1
        Me.txtAncho.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAncho.CustomButton.UseSelectable = True
        Me.txtAncho.CustomButton.Visible = False
        Me.txtAncho.Enabled = False
        Me.txtAncho.Lines = New String(-1) {}
        Me.txtAncho.Location = New System.Drawing.Point(22, 131)
        Me.txtAncho.MaxLength = 32767
        Me.txtAncho.Name = "txtAncho"
        Me.txtAncho.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAncho.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAncho.SelectedText = ""
        Me.txtAncho.SelectionLength = 0
        Me.txtAncho.SelectionStart = 0
        Me.txtAncho.ShortcutsEnabled = True
        Me.txtAncho.Size = New System.Drawing.Size(55, 20)
        Me.txtAncho.TabIndex = 2
        Me.txtAncho.Tag = "Ancho"
        Me.txtAncho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAncho.UseSelectable = True
        Me.txtAncho.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAncho.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToResizeColumns = False
        Me.dg.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender
        Me.dg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle7
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.EnableHeadersVisualStyles = False
        Me.dg.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dg.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.Location = New System.Drawing.Point(351, 101)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dg.RowHeadersVisible = False
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(501, 360)
        Me.dg.Style = MetroFramework.MetroColorStyle.Silver
        Me.dg.TabIndex = 34
        Me.dg.UseCustomBackColor = True
        Me.dg.UseCustomForeColor = True
        Me.dg.UseStyleColors = True
        '
        'ABMProdAlis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 466)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "ABMProdAlis"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Productos"
        Me.MetroPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents MetroTile1 As MetroTile
    Friend WithEvents btnSalir As MetroTile
    Friend WithEvents btnGuardar As MetroTile
    Friend WithEvents btnBorrar As MetroTile
    Friend WithEvents btnEditar As MetroTile
    Friend WithEvents BtnNuevo As MetroTile
    Friend WithEvents Panel2 As MetroPanel
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents txtFactor As MetroTextBox
    Friend WithEvents txtEspesor As MetroTextBox
    Friend WithEvents txtDescrp As MetroTextBox
    Friend WithEvents txtLargo As MetroTextBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents txtcod As MetroTextBox
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents btncancel As MetroButton
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents txtAncho As MetroTextBox
    Friend WithEvents dg As MetroGrid
End Class
