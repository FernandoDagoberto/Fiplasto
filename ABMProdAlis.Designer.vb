<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuConf
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuConf))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New MetroFramework.Controls.MetroPanel()
        Me.txtDescrp = New MetroFramework.Controls.MetroTextBox()
        Me.txtcod = New MetroFramework.Controls.MetroTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.mnuNuevo = New System.Windows.Forms.ToolStripButton()
        Me.mnuEditar = New System.Windows.Forms.ToolStripButton()
        Me.mnuBorrar = New System.Windows.Forms.ToolStripButton()
        Me.mnuGuardar = New System.Windows.Forms.ToolStripButton()
        Me.mnuSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.btncancel = New MetroFramework.Controls.MetroButton()
        Me.DGVMenu = New MetroFramework.Controls.MetroGrid()
        Me.MenucodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenudescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MENUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FIPLANEWDataSetTotal = New SPIF.FIPLANEWDataSetTotal()
        Me.MENUTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.MENUTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DGVMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MENUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FIPLANEWDataSetTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Panel2.Controls.Add(Me.txtDescrp)
        Me.Panel2.Controls.Add(Me.txtcod)
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btncancel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.HorizontalScrollbarBarColor = True
        Me.Panel2.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel2.HorizontalScrollbarSize = 10
        Me.Panel2.Location = New System.Drawing.Point(20, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(382, 323)
        Me.Panel2.TabIndex = 1
        Me.Panel2.VerticalScrollbarBarColor = True
        Me.Panel2.VerticalScrollbarHighlightOnWheel = False
        Me.Panel2.VerticalScrollbarSize = 10
        '
        'txtDescrp
        '
        '
        '
        '
        Me.txtDescrp.CustomButton.Image = Nothing
        Me.txtDescrp.CustomButton.Location = New System.Drawing.Point(144, 1)
        Me.txtDescrp.CustomButton.Name = ""
        Me.txtDescrp.CustomButton.Size = New System.Drawing.Size(103, 103)
        Me.txtDescrp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescrp.CustomButton.TabIndex = 1
        Me.txtDescrp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescrp.CustomButton.UseSelectable = True
        Me.txtDescrp.CustomButton.Visible = False
        Me.txtDescrp.Lines = New String(-1) {}
        Me.txtDescrp.Location = New System.Drawing.Point(106, 74)
        Me.txtDescrp.MaxLength = 32767
        Me.txtDescrp.Multiline = True
        Me.txtDescrp.Name = "txtDescrp"
        Me.txtDescrp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescrp.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescrp.SelectedText = ""
        Me.txtDescrp.SelectionLength = 0
        Me.txtDescrp.SelectionStart = 0
        Me.txtDescrp.ShortcutsEnabled = True
        Me.txtDescrp.Size = New System.Drawing.Size(248, 105)
        Me.txtDescrp.TabIndex = 49
        Me.txtDescrp.UseSelectable = True
        Me.txtDescrp.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescrp.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtcod
        '
        '
        '
        '
        Me.txtcod.CustomButton.Image = Nothing
        Me.txtcod.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtcod.CustomButton.Name = ""
        Me.txtcod.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtcod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcod.CustomButton.TabIndex = 1
        Me.txtcod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcod.CustomButton.UseSelectable = True
        Me.txtcod.CustomButton.Visible = False
        Me.txtcod.Lines = New String(-1) {}
        Me.txtcod.Location = New System.Drawing.Point(109, 38)
        Me.txtcod.MaxLength = 32767
        Me.txtcod.Name = "txtcod"
        Me.txtcod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcod.SelectedText = ""
        Me.txtcod.SelectionLength = 0
        Me.txtcod.SelectionStart = 0
        Me.txtcod.ShortcutsEnabled = True
        Me.txtcod.Size = New System.Drawing.Size(75, 23)
        Me.txtcod.TabIndex = 48
        Me.txtcod.UseSelectable = True
        Me.txtcod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNuevo, Me.mnuEditar, Me.mnuBorrar, Me.mnuGuardar, Me.mnuSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(382, 25)
        Me.ToolStrip1.TabIndex = 47
        Me.ToolStrip1.Text = "ToolStrip2"
        '
        'mnuNuevo
        '
        Me.mnuNuevo.Image = CType(resources.GetObject("mnuNuevo.Image"), System.Drawing.Image)
        Me.mnuNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuNuevo.Name = "mnuNuevo"
        Me.mnuNuevo.Size = New System.Drawing.Size(62, 22)
        Me.mnuNuevo.Text = "Nuevo"
        '
        'mnuEditar
        '
        Me.mnuEditar.Image = CType(resources.GetObject("mnuEditar.Image"), System.Drawing.Image)
        Me.mnuEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuEditar.Name = "mnuEditar"
        Me.mnuEditar.Size = New System.Drawing.Size(57, 22)
        Me.mnuEditar.Text = "Editar"
        '
        'mnuBorrar
        '
        Me.mnuBorrar.Image = CType(resources.GetObject("mnuBorrar.Image"), System.Drawing.Image)
        Me.mnuBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuBorrar.Name = "mnuBorrar"
        Me.mnuBorrar.Size = New System.Drawing.Size(59, 22)
        Me.mnuBorrar.Text = "Borrar"
        '
        'mnuGuardar
        '
        Me.mnuGuardar.Enabled = False
        Me.mnuGuardar.Image = CType(resources.GetObject("mnuGuardar.Image"), System.Drawing.Image)
        Me.mnuGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuGuardar.Name = "mnuGuardar"
        Me.mnuGuardar.Size = New System.Drawing.Size(69, 22)
        Me.mnuGuardar.Text = "Guardar"
        '
        'mnuSalir
        '
        Me.mnuSalir.Image = CType(resources.GetObject("mnuSalir.Image"), System.Drawing.Image)
        Me.mnuSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(49, 22)
        Me.mnuSalir.Text = "Salir"
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
        Me.btncancel.Location = New System.Drawing.Point(279, 204)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 24)
        Me.btncancel.TabIndex = 40
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseSelectable = True
        Me.btncancel.Visible = False
        '
        'DGVMenu
        '
        Me.DGVMenu.AllowUserToAddRows = False
        Me.DGVMenu.AllowUserToDeleteRows = False
        Me.DGVMenu.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.DGVMenu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVMenu.AutoGenerateColumns = False
        Me.DGVMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVMenu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGVMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenucodDataGridViewTextBoxColumn, Me.MenudescDataGridViewTextBoxColumn})
        Me.DGVMenu.DataSource = Me.MENUBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVMenu.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVMenu.EnableHeadersVisualStyles = False
        Me.DGVMenu.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DGVMenu.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVMenu.Location = New System.Drawing.Point(402, 60)
        Me.DGVMenu.MultiSelect = False
        Me.DGVMenu.Name = "DGVMenu"
        Me.DGVMenu.ReadOnly = True
        Me.DGVMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVMenu.RowHeadersVisible = False
        Me.DGVMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVMenu.Size = New System.Drawing.Size(435, 323)
        Me.DGVMenu.TabIndex = 2
        '
        'MenucodDataGridViewTextBoxColumn
        '
        Me.MenucodDataGridViewTextBoxColumn.DataPropertyName = "menu_cod"
        Me.MenucodDataGridViewTextBoxColumn.HeaderText = "menu_cod"
        Me.MenucodDataGridViewTextBoxColumn.Name = "MenucodDataGridViewTextBoxColumn"
        Me.MenucodDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenucodDataGridViewTextBoxColumn.Width = 83
        '
        'MenudescDataGridViewTextBoxColumn
        '
        Me.MenudescDataGridViewTextBoxColumn.DataPropertyName = "menu_desc"
        Me.MenudescDataGridViewTextBoxColumn.HeaderText = "menu_desc"
        Me.MenudescDataGridViewTextBoxColumn.Name = "MenudescDataGridViewTextBoxColumn"
        Me.MenudescDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenudescDataGridViewTextBoxColumn.Width = 87
        '
        'MENUBindingSource
        '
        Me.MENUBindingSource.DataMember = "MENU"
        Me.MENUBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'FIPLANEWDataSetTotal
        '
        Me.FIPLANEWDataSetTotal.DataSetName = "FIPLANEWDataSetTotal"
        Me.FIPLANEWDataSetTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MENUTableAdapter
        '
        Me.MENUTableAdapter.ClearBeforeFill = True
        '
        'MenuConf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 403)
        Me.Controls.Add(Me.DGVMenu)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "MenuConf"
        Me.Text = "Armado de Menú"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DGVMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MENUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FIPLANEWDataSetTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents FIPLANEWDataSetTotal As SPIF.FIPLANEWDataSetTotal
    Friend WithEvents MENUBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MENUTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.MENUTableAdapter
    Friend WithEvents MenucodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenudescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btncancel As MetroFramework.Controls.MetroButton
    Friend WithEvents DGVMenu As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtDescrp As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtcod As MetroFramework.Controls.MetroTextBox
End Class
