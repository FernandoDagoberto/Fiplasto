Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework.Controls
Imports MetroFramework

Public Class abmusuario
    Inherits MetroFramework.Forms.MetroForm
    Dim sql, sql1, sql2, sql3, sql4 As String
    Dim da, da1 As New SqlDataAdapter
    Dim cmd, cmd2, cmd3, cmd4 As SqlCommand
    Dim dt As DataTable = New DataTable
    Dim dt1 As DataTable = New DataTable
    Dim TextCol1 As New DataGridTextBoxColumn
    Dim TextCol2 As New DataGridTextBoxColumn
    Dim TextCol3 As New DataGridTextBoxColumn
    Dim TextCol4 As New DataGridTextBoxColumn
    Dim sen, campos, variables, idl As String
    Dim line, ms As Integer
    Friend WithEvents dg As MetroGrid
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents MetroTile1 As MetroTile
    Friend WithEvents btnSalir As MetroTile
    Friend WithEvents btnGuardar As MetroTile
    Friend WithEvents btnBorrar As MetroTile
    Friend WithEvents btnEditar As MetroTile
    Friend WithEvents BtnNuevo As MetroTile

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
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents txtid As MetroTextBox
    Friend WithEvents txtdes As MetroTextBox
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents cbperfil As MetroComboBox
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents txtapenom As MetroTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmusuario))
        Me.btncancel = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txtid = New MetroFramework.Controls.MetroTextBox()
        Me.txtdes = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.cbperfil = New MetroFramework.Controls.MetroComboBox()
        Me.txtapenom = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.dg = New MetroFramework.Controls.MetroGrid()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.btnSalir = New MetroFramework.Controls.MetroTile()
        Me.btnGuardar = New MetroFramework.Controls.MetroTile()
        Me.btnBorrar = New MetroFramework.Controls.MetroTile()
        Me.btnEditar = New MetroFramework.Controls.MetroTile()
        Me.BtnNuevo = New MetroFramework.Controls.MetroTile()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncancel.Location = New System.Drawing.Point(130, 316)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 24)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseSelectable = True
        Me.btncancel.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(17, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Contraseña"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(17, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtid
        '
        '
        '
        '
        Me.txtid.CustomButton.Image = Nothing
        Me.txtid.CustomButton.Location = New System.Drawing.Point(88, 2)
        Me.txtid.CustomButton.Name = ""
        Me.txtid.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtid.CustomButton.TabIndex = 1
        Me.txtid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtid.CustomButton.UseSelectable = True
        Me.txtid.CustomButton.Visible = False
        Me.txtid.Lines = New String(-1) {}
        Me.txtid.Location = New System.Drawing.Point(17, 139)
        Me.txtid.MaxLength = 32767
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtid.SelectedText = ""
        Me.txtid.SelectionLength = 0
        Me.txtid.SelectionStart = 0
        Me.txtid.ShortcutsEnabled = True
        Me.txtid.Size = New System.Drawing.Size(106, 20)
        Me.txtid.TabIndex = 1
        Me.txtid.UseSelectable = True
        Me.txtid.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtid.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtdes
        '
        '
        '
        '
        Me.txtdes.CustomButton.Image = Nothing
        Me.txtdes.CustomButton.Location = New System.Drawing.Point(136, 2)
        Me.txtdes.CustomButton.Name = ""
        Me.txtdes.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtdes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdes.CustomButton.TabIndex = 1
        Me.txtdes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdes.CustomButton.UseSelectable = True
        Me.txtdes.CustomButton.Visible = False
        Me.txtdes.Lines = New String(-1) {}
        Me.txtdes.Location = New System.Drawing.Point(17, 229)
        Me.txtdes.MaxLength = 32767
        Me.txtdes.Name = "txtdes"
        Me.txtdes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdes.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdes.SelectedText = ""
        Me.txtdes.SelectionLength = 0
        Me.txtdes.SelectionStart = 0
        Me.txtdes.ShortcutsEnabled = True
        Me.txtdes.Size = New System.Drawing.Size(154, 20)
        Me.txtdes.TabIndex = 3
        Me.txtdes.UseSelectable = True
        Me.txtdes.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtdes.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(17, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Perfil"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbperfil
        '
        Me.cbperfil.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbperfil.ItemHeight = 19
        Me.cbperfil.Items.AddRange(New Object() {"Administrador", "Usuario Avanzado", "Usuario Standard"})
        Me.cbperfil.Location = New System.Drawing.Point(17, 274)
        Me.cbperfil.Name = "cbperfil"
        Me.cbperfil.Size = New System.Drawing.Size(152, 25)
        Me.cbperfil.TabIndex = 4
        Me.cbperfil.UseSelectable = True
        '
        'txtapenom
        '
        '
        '
        '
        Me.txtapenom.CustomButton.Image = Nothing
        Me.txtapenom.CustomButton.Location = New System.Drawing.Point(192, 2)
        Me.txtapenom.CustomButton.Name = ""
        Me.txtapenom.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtapenom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtapenom.CustomButton.TabIndex = 1
        Me.txtapenom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtapenom.CustomButton.UseSelectable = True
        Me.txtapenom.CustomButton.Visible = False
        Me.txtapenom.Lines = New String(-1) {}
        Me.txtapenom.Location = New System.Drawing.Point(17, 184)
        Me.txtapenom.MaxLength = 32767
        Me.txtapenom.Name = "txtapenom"
        Me.txtapenom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtapenom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtapenom.SelectedText = ""
        Me.txtapenom.SelectionLength = 0
        Me.txtapenom.SelectionStart = 0
        Me.txtapenom.ShortcutsEnabled = True
        Me.txtapenom.Size = New System.Drawing.Size(210, 20)
        Me.txtapenom.TabIndex = 2
        Me.txtapenom.UseSelectable = True
        Me.txtapenom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtapenom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(17, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 19)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Nombre y Apellido"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToResizeColumns = False
        Me.dg.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dg.BackgroundColor = System.Drawing.Color.Silver
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle3
        Me.dg.Dock = System.Windows.Forms.DockStyle.Right
        Me.dg.EnableHeadersVisualStyles = False
        Me.dg.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dg.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.Location = New System.Drawing.Point(237, 101)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg.RowHeadersVisible = False
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(474, 304)
        Me.dg.TabIndex = 85
        Me.dg.UseCustomBackColor = True
        Me.dg.UseCustomForeColor = True
        Me.dg.UseStyleColors = True
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
        Me.MetroPanel1.Size = New System.Drawing.Size(706, 41)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroPanel1.TabIndex = 84
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
        Me.MetroTile1.Size = New System.Drawing.Size(261, 41)
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
        'abmusuario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(716, 410)
        Me.ControlBox = False
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.txtapenom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbperfil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtdes)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "abmusuario"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Usuarios"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub abmusuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call bloquea()
        Call LLENAcBPERFIL()
        Call buscadatos()
        btnGuardar.Enabled = False
        If dt.Rows.Count <> 0 Then
            dg.Select()
        Else
            btnEditar.Enabled = False
            btnBorrar.Enabled = False
        End If
    End Sub

    Private Sub Opcion(sender As Object, e As EventArgs) Handles BtnNuevo.Click, btnSalir.Click, btnGuardar.Click, btnEditar.Click, btnBorrar.Click
        'Busco la opción por el nombre del botón
        Select Case sender.Name

            Case BtnNuevo.Name ' boton nuevo
                sen = "n"
                btncancel.Visible = True
                btnGuardar.Enabled = True
                btnEditar.Enabled = False
                btnBorrar.Enabled = False
                Call habilita()
                txtid.Focus()

            Case btnEditar.Name 'boton editar
                sen = "m"
                btncancel.Visible = True
                BtnNuevo.Enabled = False
                btnBorrar.Enabled = False
                btnGuardar.Enabled = True
                Call habilita()
                txtid.Enabled = False
                Call modifica()

            Case btnBorrar.Name ' boton borrar

                ms = MetroMessageBox.Show(Me, "Desea eliminar el usuario: " + dg.CurrentRow.Cells("Descripcion").Value + " ?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If ms = 1 Then
                    Call eliminalinea()
                    btncancel.Visible = False
                End If

            Case btnGuardar.Name 'boton guardar
                Call guardanuevo()
                Call limpia()
                Call buscadatos()
                Call bloquea()
                If BtnNuevo.Enabled = False Then BtnNuevo.Enabled = True
                If btnEditar.Enabled = False Then btnEditar.Enabled = True
                If btnBorrar.Enabled = False Then btnBorrar.Enabled = True
                btnGuardar.Enabled = False
                btncancel.Visible = False
                dg.Select()

            Case btnSalir.Name ' boton salir
                Me.Close()
        End Select
    End Sub

    Private Sub modifica()
        If dg.SelectedRows.Count = 1 Then
            txtid.Text = dg.CurrentRow.Cells("ID").Value
            txtapenom.Text = dg.CurrentRow.Cells("Descripcion").Value
            txtdes.Text = dg.CurrentRow.Cells("Clave").Value
            cbperfil.Text = dg.CurrentRow.Cells("Perfil").Value
            txtdes.Focus()
        End If
    End Sub

    Private Sub habilita()
        txtid.Enabled = True
        txtapenom.Enabled = True
        txtdes.Enabled = True
        cbperfil.Enabled = True
    End Sub

    Private Sub dg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.Click
        Call limpia()
        Call bloquea()
        If dg.SelectedRows.Count = 1 Then
            linea = dg.CurrentRow.Cells("ID").Value
        End If
    End Sub

    Private Sub deshabilita()
        txtid.Enabled = False
        txtapenom.Enabled = False
        txtdes.Enabled = False
        cbperfil.Enabled = False
    End Sub

    Private Sub limpia()
        txtid.Text = Nothing
        txtapenom.Text = Nothing
        txtdes.Text = Nothing
    End Sub

    Private Sub buscadatos()
        conex("sit")
        sql = "SELECT user_id as ID, user_apenom as Descripcion, user_pass as Clave,perfil_desc as Perfil From usuarios inner join perfil on user_perfil=PERFIL_ID order by user_id"
        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)

        dg.DataSource = dt
    End Sub

    Private Sub bloquea()
        txtid.Enabled = False
        txtapenom.Enabled = False
        txtdes.Enabled = False
        cbperfil.Enabled = False
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        Opcion(btnEditar, e)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Call limpia()
        BtnNuevo.Enabled = True
        btnEditar.Enabled = True
        btnBorrar.Enabled = True
        btnGuardar.Enabled = False
        Call bloquea()
        btncancel.Visible = False
    End Sub

    Private Sub guardanuevo()
        conex("pcia")
        perfil = cbperfil.SelectedValue
        If sen = "n" Then
            campos = "user_id,user_apenom,user_pass,user_perfil"
            variables = "'" + txtid.Text + "', '" + txtapenom.Text + "', '" + txtdes.Text + "','" + perfil + "'"
            sql3 = "INSERT INTO usuarios (" + campos + ") VALUES (" + variables + ")"
            cmd3 = New SqlCommand(sql3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()
        Else
            sql2 = "update usuarios set user_apenom='" + txtapenom.Text + "',user_pass='" + txtdes.Text + "', user_perfil='" + perfil + "' where user_id='" + txtid.Text + "' "
            cmd2 = New SqlCommand(sql2, cnn)
            cmd2.Connection.Open()
            cmd2.ExecuteNonQuery()
            cmd2.Connection.Close()
        End If
        Call bloquea()
    End Sub

    Private Sub dg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg.KeyUp
        If e.KeyCode = Keys.Delete Then
            Opcion(btnBorrar, e)
        End If
    End Sub

    Private Sub eliminalinea()
        If dg.CurrentRow.Cells("Descripcion").Value = user Then
            MetroMessageBox.Show(Me, "Usuario Actual, el mismo no puede ser eliminado ", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            sql4 = "delete from usuarios where user_id='" + Trim(linea) + "' "
            cmd4 = New SqlCommand(sql4, cnn)
            cmd4.Connection.Open()
            cmd4.ExecuteNonQuery()
            cmd4.Connection.Close()
            Call buscadatos()
            If dt.Rows.Count <> 0 Then
                dg.Select()
            Else
                btnEditar.Enabled = False
                btnBorrar.Enabled = False
            End If
        End If
    End Sub
    Private Sub LLENAcBPERFIL()
        llenacb("perfil")
        cbperfil.DataSource = dt7
        cbperfil.DisplayMember = "perfil_desc"
        cbperfil.ValueMember = "perfil_id"
        'lblp.Text = cbcodigo.SelectedValue
    End Sub


End Class
