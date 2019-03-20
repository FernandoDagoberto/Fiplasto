Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CamposMad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CamposMad))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnSalir = New MetroFramework.Controls.MetroTile()
        Me.btnGuardar = New MetroFramework.Controls.MetroTile()
        Me.btnEditar = New MetroFramework.Controls.MetroTile()
        Me.BtnNuevo = New MetroFramework.Controls.MetroTile()
        Me.pnlDatos = New MetroFramework.Controls.MetroPanel()
        Me.chkPropio = New MetroFramework.Controls.MetroCheckBox()
        Me.btncancel = New MetroFramework.Controls.MetroButton()
        Me.txtCod = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.pnlBuscar = New MetroFramework.Controls.MetroPanel()
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.dg = New MetroFramework.Controls.MetroGrid()
        Me.MetroPanel1.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        Me.pnlBuscar.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.Transparent
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
        Me.MetroPanel1.Size = New System.Drawing.Size(361, 41)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroPanel1.TabIndex = 26
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
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
        Me.BtnNuevo.TabIndex = 2
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.TileImage = CType(resources.GetObject("BtnNuevo.TileImage"), System.Drawing.Image)
        Me.BtnNuevo.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.BtnNuevo.UseSelectable = True
        Me.BtnNuevo.UseTileImage = True
        '
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.chkPropio)
        Me.pnlDatos.Controls.Add(Me.btncancel)
        Me.pnlDatos.Controls.Add(Me.txtCod)
        Me.pnlDatos.Controls.Add(Me.txtNombre)
        Me.pnlDatos.Controls.Add(Me.Label4)
        Me.pnlDatos.Controls.Add(Me.Label3)
        Me.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDatos.Enabled = False
        Me.pnlDatos.HorizontalScrollbarBarColor = True
        Me.pnlDatos.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlDatos.HorizontalScrollbarSize = 10
        Me.pnlDatos.Location = New System.Drawing.Point(5, 101)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(361, 117)
        Me.pnlDatos.TabIndex = 0
        Me.pnlDatos.VerticalScrollbarBarColor = True
        Me.pnlDatos.VerticalScrollbarHighlightOnWheel = False
        Me.pnlDatos.VerticalScrollbarSize = 10
        '
        'chkPropio
        '
        Me.chkPropio.AutoSize = True
        Me.chkPropio.Location = New System.Drawing.Point(100, 73)
        Me.chkPropio.Name = "chkPropio"
        Me.chkPropio.Size = New System.Drawing.Size(58, 15)
        Me.chkPropio.TabIndex = 2
        Me.chkPropio.Text = "Propio"
        Me.chkPropio.UseSelectable = True
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncancel.Location = New System.Drawing.Point(223, 90)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 24)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseSelectable = True
        Me.btncancel.Visible = False
        '
        'txtCod
        '
        '
        '
        '
        Me.txtCod.CustomButton.Image = Nothing
        Me.txtCod.CustomButton.Location = New System.Drawing.Point(32, 2)
        Me.txtCod.CustomButton.Name = ""
        Me.txtCod.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtCod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCod.CustomButton.TabIndex = 1
        Me.txtCod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCod.CustomButton.UseSelectable = True
        Me.txtCod.CustomButton.Visible = False
        Me.txtCod.Lines = New String(-1) {}
        Me.txtCod.Location = New System.Drawing.Point(100, 21)
        Me.txtCod.MaxLength = 32767
        Me.txtCod.Name = "txtCod"
        Me.txtCod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCod.SelectedText = ""
        Me.txtCod.SelectionLength = 0
        Me.txtCod.SelectionStart = 0
        Me.txtCod.ShortcutsEnabled = True
        Me.txtCod.Size = New System.Drawing.Size(50, 20)
        Me.txtCod.TabIndex = 0
        Me.txtCod.UseSelectable = True
        Me.txtCod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(211, 2)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(100, 47)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(229, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descripción:"
        '
        'pnlBuscar
        '
        Me.pnlBuscar.Controls.Add(Me.txtBuscar)
        Me.pnlBuscar.Controls.Add(Me.Label1)
        Me.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBuscar.HorizontalScrollbarBarColor = True
        Me.pnlBuscar.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlBuscar.HorizontalScrollbarSize = 10
        Me.pnlBuscar.Location = New System.Drawing.Point(5, 218)
        Me.pnlBuscar.Name = "pnlBuscar"
        Me.pnlBuscar.Size = New System.Drawing.Size(361, 50)
        Me.pnlBuscar.TabIndex = 1
        Me.pnlBuscar.VerticalScrollbarBarColor = True
        Me.pnlBuscar.VerticalScrollbarHighlightOnWheel = False
        Me.pnlBuscar.VerticalScrollbarSize = 10
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtBuscar.CustomButton.Image = Nothing
        Me.txtBuscar.CustomButton.Location = New System.Drawing.Point(238, 2)
        Me.txtBuscar.CustomButton.Name = ""
        Me.txtBuscar.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBuscar.CustomButton.TabIndex = 1
        Me.txtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBuscar.CustomButton.UseSelectable = True
        Me.txtBuscar.CustomButton.Visible = False
        Me.txtBuscar.Lines = New String(-1) {}
        Me.txtBuscar.Location = New System.Drawing.Point(75, 16)
        Me.txtBuscar.MaxLength = 32767
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.SelectionLength = 0
        Me.txtBuscar.SelectionStart = 0
        Me.txtBuscar.ShortcutsEnabled = True
        Me.txtBuscar.Size = New System.Drawing.Size(256, 20)
        Me.txtBuscar.TabIndex = 0
        Me.txtBuscar.UseSelectable = True
        Me.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBuscar.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 19)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Buscar:"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToOrderColumns = True
        Me.dg.AllowUserToResizeRows = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.EnableHeadersVisualStyles = False
        Me.dg.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dg.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.Location = New System.Drawing.Point(5, 268)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg.RowHeadersVisible = False
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(361, 249)
        Me.dg.Style = MetroFramework.MetroColorStyle.Silver
        Me.dg.TabIndex = 29
        '
        'CamposMad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 522)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.pnlBuscar)
        Me.Controls.Add(Me.pnlDatos)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "CamposMad"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Black
        Me.Text = "Campos"
        Me.MetroPanel1.ResumeLayout(False)
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        Me.pnlBuscar.ResumeLayout(False)
        Me.pnlBuscar.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents btnSalir As MetroTile
    Friend WithEvents btnGuardar As MetroTile
    Friend WithEvents btnEditar As MetroTile
    Friend WithEvents BtnNuevo As MetroTile
    Friend WithEvents pnlDatos As MetroPanel
    Friend WithEvents chkPropio As MetroCheckBox
    Friend WithEvents btncancel As MetroButton
    Friend WithEvents txtCod As MetroTextBox
    Friend WithEvents txtNombre As MetroTextBox
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents pnlBuscar As MetroPanel
    Friend WithEvents txtBuscar As MetroTextBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents dg As MetroGrid
End Class
