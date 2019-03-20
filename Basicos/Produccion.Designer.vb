Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Produccion
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
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.btnagregar = New MetroFramework.Controls.MetroButton()
        Me.tabcontrol = New MetroFramework.Controls.MetroTabControl()
        Me.tpnov = New MetroFramework.Controls.MetroTabPage()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.nov_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nov_visto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nov_vistouser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nov_vistofch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tptareas = New MetroFramework.Controls.MetroTabPage()
        Me.dgtareas = New System.Windows.Forms.DataGridView()
        Me.tarea_area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbsector = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.ComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.TextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.TextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.ComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.CheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.tabcontrol.SuspendLayout()
        Me.tpnov.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tptareas.SuspendLayout()
        CType(Me.dgtareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtfecha
        '
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(95, 64)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(91, 20)
        Me.dtfecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(19, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(16, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Turno"
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 23
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(95, 90)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(59, 29)
        Me.cbturno.TabIndex = 1
        Me.cbturno.UseSelectable = True
        '
        'cbgrupo
        '
        Me.cbgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbgrupo.FormattingEnabled = True
        Me.cbgrupo.ItemHeight = 23
        Me.cbgrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbgrupo.Location = New System.Drawing.Point(274, 89)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(56, 29)
        Me.cbgrupo.TabIndex = 3
        Me.cbgrupo.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(199, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Grupo"
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(251, 323)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 5
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseSelectable = True
        '
        'tabcontrol
        '
        Me.tabcontrol.Controls.Add(Me.tpnov)
        Me.tabcontrol.Controls.Add(Me.tptareas)
        Me.tabcontrol.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabcontrol.Location = New System.Drawing.Point(5, 399)
        Me.tabcontrol.Name = "tabcontrol"
        Me.tabcontrol.SelectedIndex = 0
        Me.tabcontrol.Size = New System.Drawing.Size(850, 187)
        Me.tabcontrol.TabIndex = 34
        Me.tabcontrol.UseSelectable = True
        '
        'tpnov
        '
        Me.tpnov.Controls.Add(Me.dg)
        Me.tpnov.HorizontalScrollbarBarColor = True
        Me.tpnov.HorizontalScrollbarHighlightOnWheel = False
        Me.tpnov.HorizontalScrollbarSize = 10
        Me.tpnov.Location = New System.Drawing.Point(4, 38)
        Me.tpnov.Name = "tpnov"
        Me.tpnov.Padding = New System.Windows.Forms.Padding(3)
        Me.tpnov.Size = New System.Drawing.Size(842, 145)
        Me.tpnov.TabIndex = 0
        Me.tpnov.Text = "Novedades"
        Me.tpnov.VerticalScrollbarBarColor = True
        Me.tpnov.VerticalScrollbarHighlightOnWheel = False
        Me.tpnov.VerticalScrollbarSize = 10
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nov_user, Me.nov_visto, Me.nov_vistouser, Me.nov_vistofch})
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.Location = New System.Drawing.Point(3, 3)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersVisible = False
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(836, 139)
        Me.dg.TabIndex = 29
        '
        'nov_user
        '
        Me.nov_user.DataPropertyName = "nov_user"
        Me.nov_user.HeaderText = "Usuario"
        Me.nov_user.Name = "nov_user"
        Me.nov_user.ReadOnly = True
        Me.nov_user.Width = 120
        '
        'nov_visto
        '
        Me.nov_visto.DataPropertyName = "nov_visto"
        Me.nov_visto.HeaderText = "Visto"
        Me.nov_visto.Name = "nov_visto"
        Me.nov_visto.ReadOnly = True
        '
        'nov_vistouser
        '
        Me.nov_vistouser.DataPropertyName = "nov_vistouser"
        Me.nov_vistouser.HeaderText = "Por:"
        Me.nov_vistouser.Name = "nov_vistouser"
        Me.nov_vistouser.ReadOnly = True
        '
        'nov_vistofch
        '
        Me.nov_vistofch.DataPropertyName = "nov_vistofch"
        Me.nov_vistofch.HeaderText = "Fecha"
        Me.nov_vistofch.Name = "nov_vistofch"
        Me.nov_vistofch.ReadOnly = True
        '
        'tptareas
        '
        Me.tptareas.Controls.Add(Me.dgtareas)
        Me.tptareas.HorizontalScrollbarBarColor = True
        Me.tptareas.HorizontalScrollbarHighlightOnWheel = False
        Me.tptareas.HorizontalScrollbarSize = 10
        Me.tptareas.Location = New System.Drawing.Point(4, 38)
        Me.tptareas.Name = "tptareas"
        Me.tptareas.Padding = New System.Windows.Forms.Padding(3)
        Me.tptareas.Size = New System.Drawing.Size(852, 232)
        Me.tptareas.TabIndex = 1
        Me.tptareas.Text = "Tareas"
        Me.tptareas.VerticalScrollbarBarColor = True
        Me.tptareas.VerticalScrollbarHighlightOnWheel = False
        Me.tptareas.VerticalScrollbarSize = 10
        '
        'dgtareas
        '
        Me.dgtareas.AllowUserToAddRows = False
        Me.dgtareas.AllowUserToDeleteRows = False
        Me.dgtareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgtareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtareas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tarea_area})
        Me.dgtareas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgtareas.Location = New System.Drawing.Point(3, 3)
        Me.dgtareas.MultiSelect = False
        Me.dgtareas.Name = "dgtareas"
        Me.dgtareas.ReadOnly = True
        Me.dgtareas.RowHeadersVisible = False
        Me.dgtareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtareas.Size = New System.Drawing.Size(846, 226)
        Me.dgtareas.TabIndex = 0
        '
        'tarea_area
        '
        Me.tarea_area.DataPropertyName = "tarea_area"
        Me.tarea_area.HeaderText = "Área"
        Me.tarea_area.Name = "tarea_area"
        Me.tarea_area.ReadOnly = True
        '
        'cbsector
        '
        Me.cbsector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbsector.FormattingEnabled = True
        Me.cbsector.ItemHeight = 23
        Me.cbsector.Location = New System.Drawing.Point(274, 62)
        Me.cbsector.Name = "cbsector"
        Me.cbsector.Size = New System.Drawing.Size(43, 29)
        Me.cbsector.TabIndex = 29
        Me.cbsector.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(196, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Línea"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 23
        Me.ComboBox1.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.ComboBox1.Location = New System.Drawing.Point(95, 117)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(59, 29)
        Me.ComboBox1.TabIndex = 35
        Me.ComboBox1.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(16, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Producto"
        '
        'TextBox1
        '
        '
        '
        '
        Me.TextBox1.CustomButton.Image = Nothing
        Me.TextBox1.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.TextBox1.CustomButton.Name = ""
        Me.TextBox1.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.TextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBox1.CustomButton.TabIndex = 1
        Me.TextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBox1.CustomButton.UseSelectable = True
        Me.TextBox1.CustomButton.Visible = False
        Me.TextBox1.Lines = New String(-1) {}
        Me.TextBox1.Location = New System.Drawing.Point(37, 188)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionLength = 0
        Me.TextBox1.SelectionStart = 0
        Me.TextBox1.ShortcutsEnabled = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 37
        Me.TextBox1.UseSelectable = True
        Me.TextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TextBox2
        '
        '
        '
        '
        Me.TextBox2.CustomButton.Image = Nothing
        Me.TextBox2.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.TextBox2.CustomButton.Name = ""
        Me.TextBox2.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.TextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBox2.CustomButton.TabIndex = 1
        Me.TextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBox2.CustomButton.UseSelectable = True
        Me.TextBox2.CustomButton.Visible = False
        Me.TextBox2.Lines = New String(-1) {}
        Me.TextBox2.Location = New System.Drawing.Point(168, 188)
        Me.TextBox2.MaxLength = 32767
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.SelectionLength = 0
        Me.TextBox2.SelectionStart = 0
        Me.TextBox2.ShortcutsEnabled = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 38
        Me.TextBox2.UseSelectable = True
        Me.TextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TextBox3
        '
        '
        '
        '
        Me.TextBox3.CustomButton.Image = Nothing
        Me.TextBox3.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.TextBox3.CustomButton.Name = ""
        Me.TextBox3.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.TextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBox3.CustomButton.TabIndex = 1
        Me.TextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBox3.CustomButton.UseSelectable = True
        Me.TextBox3.CustomButton.Visible = False
        Me.TextBox3.Lines = New String(-1) {}
        Me.TextBox3.Location = New System.Drawing.Point(300, 188)
        Me.TextBox3.MaxLength = 32767
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox3.SelectedText = ""
        Me.TextBox3.SelectionLength = 0
        Me.TextBox3.SelectionStart = 0
        Me.TextBox3.ShortcutsEnabled = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 39
        Me.TextBox3.UseSelectable = True
        Me.TextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TextBox3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(19, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 19)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Prensadas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(150, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 19)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Abert. Hab.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(283, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 19)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Descarte"
        '
        'ComboBox2
        '
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.ItemHeight = 23
        Me.ComboBox2.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.ComboBox2.Location = New System.Drawing.Point(139, 263)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(59, 29)
        Me.ComboBox2.TabIndex = 43
        Me.ComboBox2.UseSelectable = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(40, 267)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 15)
        Me.CheckBox1.TabIndex = 45
        Me.CheckBox1.Text = "Decorativo"
        Me.CheckBox1.UseSelectable = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(233, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 19)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Cant. Decorativos"
        '
        'TextBox4
        '
        '
        '
        '
        Me.TextBox4.CustomButton.Image = Nothing
        Me.TextBox4.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.TextBox4.CustomButton.Name = ""
        Me.TextBox4.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.TextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBox4.CustomButton.TabIndex = 1
        Me.TextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBox4.CustomButton.UseSelectable = True
        Me.TextBox4.CustomButton.Visible = False
        Me.TextBox4.Lines = New String(-1) {}
        Me.TextBox4.Location = New System.Drawing.Point(251, 267)
        Me.TextBox4.MaxLength = 32767
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox4.SelectedText = ""
        Me.TextBox4.SelectionLength = 0
        Me.TextBox4.SelectionStart = 0
        Me.TextBox4.ShortcutsEnabled = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 46
        Me.TextBox4.UseSelectable = True
        Me.TextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TextBox4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 591)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cbsector)
        Me.Controls.Add(Me.tabcontrol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtfecha)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Produccion"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Producción"
        Me.tabcontrol.ResumeLayout(False)
        Me.tpnov.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tptareas.ResumeLayout(False)
        CType(Me.dgtareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents btnagregar As MetroButton
    Friend WithEvents tabcontrol As MetroTabControl
    Friend WithEvents tpnov As MetroTabPage
    Friend WithEvents tptareas As MetroTabPage
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents dgtareas As System.Windows.Forms.DataGridView
    Friend WithEvents tarea_area As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nov_user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nov_visto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nov_vistouser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nov_vistofch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbsector As MetroComboBox
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents ComboBox1 As MetroComboBox
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents TextBox1 As MetroTextBox
    Friend WithEvents TextBox2 As MetroTextBox
    Friend WithEvents TextBox3 As MetroTextBox
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents ComboBox2 As MetroComboBox
    Friend WithEvents CheckBox1 As MetroCheckBox
    Friend WithEvents Label9 As MetroLabel
    Friend WithEvents TextBox4 As MetroTextBox
End Class
