Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Novedades
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
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.txtobs = New MetroFramework.Controls.MetroTextBox()
        Me.btnagregar = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.cbmotivo = New MetroFramework.Controls.MetroComboBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.tabcontrol = New MetroFramework.Controls.MetroTabControl()
        Me.tpnov = New MetroFramework.Controls.MetroTabPage()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.tptareas = New MetroFramework.Controls.MetroTabPage()
        Me.dgtareas = New System.Windows.Forms.DataGridView()
        Me.cbSector = New System.Windows.Forms.ComboBox()
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
        Me.dtfecha.Location = New System.Drawing.Point(275, 60)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(91, 20)
        Me.dtfecha.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(215, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(35, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Turno"
        '
        'cbturno
        '
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(110, 89)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(56, 25)
        Me.cbturno.TabIndex = 0
        Me.cbturno.UseSelectable = True
        '
        'cbgrupo
        '
        Me.cbgrupo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbgrupo.FormattingEnabled = True
        Me.cbgrupo.ItemHeight = 19
        Me.cbgrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbgrupo.Location = New System.Drawing.Point(275, 89)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(58, 25)
        Me.cbgrupo.TabIndex = 1
        Me.cbgrupo.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(215, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Grupo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(35, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 19)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Novedad"
        '
        'txtobs
        '
        '
        '
        '
        Me.txtobs.CustomButton.Image = Nothing
        Me.txtobs.CustomButton.Location = New System.Drawing.Point(386, 2)
        Me.txtobs.CustomButton.Name = ""
        Me.txtobs.CustomButton.Size = New System.Drawing.Size(111, 111)
        Me.txtobs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtobs.CustomButton.TabIndex = 1
        Me.txtobs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtobs.CustomButton.UseSelectable = True
        Me.txtobs.CustomButton.Visible = False
        Me.txtobs.Lines = New String(-1) {}
        Me.txtobs.Location = New System.Drawing.Point(35, 173)
        Me.txtobs.MaxLength = 32767
        Me.txtobs.Multiline = True
        Me.txtobs.Name = "txtobs"
        Me.txtobs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtobs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtobs.SelectedText = ""
        Me.txtobs.SelectionLength = 0
        Me.txtobs.SelectionStart = 0
        Me.txtobs.ShortcutsEnabled = True
        Me.txtobs.Size = New System.Drawing.Size(500, 116)
        Me.txtobs.TabIndex = 3
        Me.txtobs.UseSelectable = True
        Me.txtobs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtobs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(211, 295)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 4
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(35, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Área"
        '
        'cbmotivo
        '
        Me.cbmotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmotivo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmotivo.FormattingEnabled = True
        Me.cbmotivo.ItemHeight = 19
        Me.cbmotivo.Location = New System.Drawing.Point(110, 120)
        Me.cbmotivo.Name = "cbmotivo"
        Me.cbmotivo.Size = New System.Drawing.Size(95, 25)
        Me.cbmotivo.TabIndex = 2
        Me.cbmotivo.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(35, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Motivo"
        '
        'tabcontrol
        '
        Me.tabcontrol.Controls.Add(Me.tpnov)
        Me.tabcontrol.Controls.Add(Me.tptareas)
        Me.tabcontrol.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabcontrol.Location = New System.Drawing.Point(5, 324)
        Me.tabcontrol.Name = "tabcontrol"
        Me.tabcontrol.SelectedIndex = 0
        Me.tabcontrol.Size = New System.Drawing.Size(726, 262)
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
        Me.tpnov.Size = New System.Drawing.Size(718, 220)
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
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.Location = New System.Drawing.Point(3, 3)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersVisible = False
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(712, 214)
        Me.dg.TabIndex = 30
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
        Me.tptareas.Size = New System.Drawing.Size(718, 220)
        Me.tptareas.TabIndex = 1
        Me.tptareas.Text = "Tareas"
        Me.tptareas.UseVisualStyleBackColor = True
        Me.tptareas.VerticalScrollbarBarColor = True
        Me.tptareas.VerticalScrollbarHighlightOnWheel = False
        Me.tptareas.VerticalScrollbarSize = 10
        '
        'dgtareas
        '
        Me.dgtareas.AllowUserToAddRows = False
        Me.dgtareas.AllowUserToDeleteRows = False
        Me.dgtareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgtareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtareas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgtareas.EnableHeadersVisualStyles = False
        Me.dgtareas.Location = New System.Drawing.Point(3, 3)
        Me.dgtareas.MultiSelect = False
        Me.dgtareas.Name = "dgtareas"
        Me.dgtareas.ReadOnly = True
        Me.dgtareas.RowHeadersVisible = False
        Me.dgtareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtareas.Size = New System.Drawing.Size(712, 214)
        Me.dgtareas.TabIndex = 2
        '
        'cbSector
        '
        Me.cbSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSector.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSector.FormattingEnabled = True
        Me.cbSector.Location = New System.Drawing.Point(110, 58)
        Me.cbSector.Name = "cbSector"
        Me.cbSector.Size = New System.Drawing.Size(99, 23)
        Me.cbSector.TabIndex = 35
        '
        'Novedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 591)
        Me.Controls.Add(Me.cbSector)
        Me.Controls.Add(Me.tabcontrol)
        Me.Controls.Add(Me.cbmotivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txtobs)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtfecha)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Novedades"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Libro de Novedades"
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
    Friend WithEvents Label11 As MetroLabel
    Friend WithEvents txtobs As MetroTextBox
    Friend WithEvents btnagregar As MetroButton
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents cbmotivo As MetroComboBox
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents tabcontrol As MetroTabControl
    Friend WithEvents tpnov As MetroTabPage
    Friend WithEvents tptareas As MetroTabPage
    Friend WithEvents cbSector As ComboBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents dgtareas As DataGridView
End Class
