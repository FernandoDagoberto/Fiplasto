Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LAVCCP
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.cblinea = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tpIng = New MetroFramework.Controls.MetroTabPage()
        Me.dgIng = New MetroFramework.Controls.MetroGrid()
        Me.tpEgr = New MetroFramework.Controls.MetroTabPage()
        Me.dgEgr = New MetroFramework.Controls.MetroGrid()
        Me.cbrazon = New MetroFramework.Controls.MetroComboBox()
        Me.Label18 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txtplaca = New MetroFramework.Controls.MetroTextBox()
        Me.Label20 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbEgr = New MetroFramework.Controls.MetroRadioButton()
        Me.rbIng = New MetroFramework.Controls.MetroRadioButton()
        Me.pnlplaca = New MetroFramework.Controls.MetroPanel()
        Me.cbplaca = New MetroFramework.Controls.MetroComboBox()
        Me.pnlabertura = New MetroFramework.Controls.MetroPanel()
        Me.txtabertura = New MetroFramework.Controls.MetroTextBox()
        Me.cbabertura = New MetroFramework.Controls.MetroComboBox()
        Me.pnlrazon = New MetroFramework.Controls.MetroPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgLineaII = New MetroFramework.Controls.MetroGrid()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgLineaI = New MetroFramework.Controls.MetroGrid()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.TabControl1.SuspendLayout()
        Me.tpIng.SuspendLayout()
        CType(Me.dgIng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEgr.SuspendLayout()
        CType(Me.dgEgr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pnlplaca.SuspendLayout()
        Me.pnlabertura.SuspendLayout()
        Me.pnlrazon.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgLineaII, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgLineaI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(242, 59)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(55, 25)
        Me.cbturno.TabIndex = 1
        Me.cbturno.UseSelectable = True
        '
        'cbgrupo
        '
        Me.cbgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbgrupo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbgrupo.FormattingEnabled = True
        Me.cbgrupo.ItemHeight = 19
        Me.cbgrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbgrupo.Location = New System.Drawing.Point(356, 59)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(50, 25)
        Me.cbgrupo.TabIndex = 2
        Me.cbgrupo.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(175, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(307, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(245, 196)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 8
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(354, 196)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 7
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'cblinea
        '
        Me.cblinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cblinea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cblinea.FormattingEnabled = True
        Me.cblinea.ItemHeight = 19
        Me.cblinea.Items.AddRange(New Object() {"1", "2"})
        Me.cblinea.Location = New System.Drawing.Point(242, 89)
        Me.cblinea.Name = "cblinea"
        Me.cblinea.Size = New System.Drawing.Size(55, 25)
        Me.cblinea.TabIndex = 3
        Me.cblinea.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(175, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 19)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Línea:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpIng)
        Me.TabControl1.Controls.Add(Me.tpEgr)
        Me.TabControl1.Location = New System.Drawing.Point(21, 256)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(516, 225)
        Me.TabControl1.Style = MetroFramework.MetroColorStyle.Orange
        Me.TabControl1.TabIndex = 71
        Me.TabControl1.UseSelectable = True
        '
        'tpIng
        '
        Me.tpIng.Controls.Add(Me.dgIng)
        Me.tpIng.HorizontalScrollbarBarColor = True
        Me.tpIng.HorizontalScrollbarHighlightOnWheel = False
        Me.tpIng.HorizontalScrollbarSize = 10
        Me.tpIng.Location = New System.Drawing.Point(4, 38)
        Me.tpIng.Name = "tpIng"
        Me.tpIng.Padding = New System.Windows.Forms.Padding(3)
        Me.tpIng.Size = New System.Drawing.Size(508, 183)
        Me.tpIng.TabIndex = 0
        Me.tpIng.Text = "Ingreso"
        Me.tpIng.VerticalScrollbarBarColor = True
        Me.tpIng.VerticalScrollbarHighlightOnWheel = False
        Me.tpIng.VerticalScrollbarSize = 10
        '
        'dgIng
        '
        Me.dgIng.AllowUserToAddRows = False
        Me.dgIng.AllowUserToDeleteRows = False
        Me.dgIng.AllowUserToResizeRows = False
        Me.dgIng.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgIng.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgIng.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgIng.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgIng.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgIng.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgIng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgIng.EnableHeadersVisualStyles = False
        Me.dgIng.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgIng.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgIng.Location = New System.Drawing.Point(3, 3)
        Me.dgIng.MultiSelect = False
        Me.dgIng.Name = "dgIng"
        Me.dgIng.ReadOnly = True
        Me.dgIng.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgIng.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgIng.RowHeadersVisible = False
        Me.dgIng.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgIng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgIng.Size = New System.Drawing.Size(502, 177)
        Me.dgIng.Style = MetroFramework.MetroColorStyle.Orange
        Me.dgIng.TabIndex = 2
        Me.dgIng.UseCustomBackColor = True
        Me.dgIng.UseCustomForeColor = True
        '
        'tpEgr
        '
        Me.tpEgr.Controls.Add(Me.dgEgr)
        Me.tpEgr.HorizontalScrollbarBarColor = True
        Me.tpEgr.HorizontalScrollbarHighlightOnWheel = False
        Me.tpEgr.HorizontalScrollbarSize = 10
        Me.tpEgr.Location = New System.Drawing.Point(4, 38)
        Me.tpEgr.Name = "tpEgr"
        Me.tpEgr.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEgr.Size = New System.Drawing.Size(508, 183)
        Me.tpEgr.TabIndex = 1
        Me.tpEgr.Text = "Egreso"
        Me.tpEgr.UseVisualStyleBackColor = True
        Me.tpEgr.VerticalScrollbarBarColor = True
        Me.tpEgr.VerticalScrollbarHighlightOnWheel = False
        Me.tpEgr.VerticalScrollbarSize = 10
        '
        'dgEgr
        '
        Me.dgEgr.AllowUserToAddRows = False
        Me.dgEgr.AllowUserToDeleteRows = False
        Me.dgEgr.AllowUserToResizeRows = False
        Me.dgEgr.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgEgr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEgr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgEgr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEgr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgEgr.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgEgr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgEgr.EnableHeadersVisualStyles = False
        Me.dgEgr.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgEgr.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgEgr.Location = New System.Drawing.Point(3, 3)
        Me.dgEgr.MultiSelect = False
        Me.dgEgr.Name = "dgEgr"
        Me.dgEgr.ReadOnly = True
        Me.dgEgr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEgr.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgEgr.RowHeadersVisible = False
        Me.dgEgr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgEgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEgr.Size = New System.Drawing.Size(502, 177)
        Me.dgEgr.Style = MetroFramework.MetroColorStyle.Orange
        Me.dgEgr.TabIndex = 3
        Me.dgEgr.UseCustomBackColor = True
        Me.dgEgr.UseCustomForeColor = True
        '
        'cbrazon
        '
        Me.cbrazon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbrazon.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbrazon.FormattingEnabled = True
        Me.cbrazon.ItemHeight = 19
        Me.cbrazon.Location = New System.Drawing.Point(74, 6)
        Me.cbrazon.Name = "cbrazon"
        Me.cbrazon.Size = New System.Drawing.Size(110, 25)
        Me.cbrazon.TabIndex = 78
        Me.cbrazon.UseSelectable = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(7, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 19)
        Me.Label18.TabIndex = 79
        Me.Label18.Text = "Razón:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Número:"
        '
        'txtplaca
        '
        '
        '
        '
        Me.txtplaca.CustomButton.Image = Nothing
        Me.txtplaca.CustomButton.Location = New System.Drawing.Point(37, 2)
        Me.txtplaca.CustomButton.Name = ""
        Me.txtplaca.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtplaca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtplaca.CustomButton.TabIndex = 1
        Me.txtplaca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtplaca.CustomButton.UseSelectable = True
        Me.txtplaca.CustomButton.Visible = False
        Me.txtplaca.Lines = New String(-1) {}
        Me.txtplaca.Location = New System.Drawing.Point(74, 5)
        Me.txtplaca.MaxLength = 32767
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtplaca.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtplaca.SelectedText = ""
        Me.txtplaca.SelectionLength = 0
        Me.txtplaca.SelectionStart = 0
        Me.txtplaca.ShortcutsEnabled = True
        Me.txtplaca.Size = New System.Drawing.Size(55, 20)
        Me.txtplaca.TabIndex = 76
        Me.txtplaca.UseSelectable = True
        Me.txtplaca.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtplaca.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(3, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 19)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "Abertura:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(21, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 19)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Fecha para búsqueda:"
        '
        'dtfecha
        '
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(194, 234)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(80, 20)
        Me.dtfecha.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbEgr)
        Me.GroupBox1.Controls.Add(Me.rbIng)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rbEgr
        '
        Me.rbEgr.AutoSize = True
        Me.rbEgr.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbEgr.Location = New System.Drawing.Point(6, 54)
        Me.rbEgr.Name = "rbEgr"
        Me.rbEgr.Size = New System.Drawing.Size(112, 15)
        Me.rbEgr.TabIndex = 1
        Me.rbEgr.Text = "Egreso de prensa"
        Me.rbEgr.UseSelectable = True
        '
        'rbIng
        '
        Me.rbIng.AutoSize = True
        Me.rbIng.Checked = True
        Me.rbIng.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbIng.Location = New System.Drawing.Point(6, 23)
        Me.rbIng.Name = "rbIng"
        Me.rbIng.Size = New System.Drawing.Size(109, 15)
        Me.rbIng.TabIndex = 0
        Me.rbIng.TabStop = True
        Me.rbIng.Text = "Ingreso a prensa"
        Me.rbIng.UseSelectable = True
        '
        'pnlplaca
        '
        Me.pnlplaca.Controls.Add(Me.Label1)
        Me.pnlplaca.Controls.Add(Me.txtplaca)
        Me.pnlplaca.Controls.Add(Me.cbplaca)
        Me.pnlplaca.HorizontalScrollbarBarColor = True
        Me.pnlplaca.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlplaca.HorizontalScrollbarSize = 10
        Me.pnlplaca.Location = New System.Drawing.Point(168, 120)
        Me.pnlplaca.Name = "pnlplaca"
        Me.pnlplaca.Size = New System.Drawing.Size(188, 33)
        Me.pnlplaca.TabIndex = 4
        Me.pnlplaca.VerticalScrollbarBarColor = True
        Me.pnlplaca.VerticalScrollbarHighlightOnWheel = False
        Me.pnlplaca.VerticalScrollbarSize = 10
        '
        'cbplaca
        '
        Me.cbplaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbplaca.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbplaca.FormattingEnabled = True
        Me.cbplaca.ItemHeight = 19
        Me.cbplaca.Location = New System.Drawing.Point(74, 5)
        Me.cbplaca.Name = "cbplaca"
        Me.cbplaca.Size = New System.Drawing.Size(65, 25)
        Me.cbplaca.TabIndex = 90
        Me.cbplaca.UseSelectable = True
        '
        'pnlabertura
        '
        Me.pnlabertura.Controls.Add(Me.txtabertura)
        Me.pnlabertura.Controls.Add(Me.Label20)
        Me.pnlabertura.Controls.Add(Me.cbabertura)
        Me.pnlabertura.HorizontalScrollbarBarColor = True
        Me.pnlabertura.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlabertura.HorizontalScrollbarSize = 10
        Me.pnlabertura.Location = New System.Drawing.Point(362, 120)
        Me.pnlabertura.Name = "pnlabertura"
        Me.pnlabertura.Size = New System.Drawing.Size(165, 30)
        Me.pnlabertura.TabIndex = 5
        Me.pnlabertura.VerticalScrollbarBarColor = True
        Me.pnlabertura.VerticalScrollbarHighlightOnWheel = False
        Me.pnlabertura.VerticalScrollbarSize = 10
        '
        'txtabertura
        '
        '
        '
        '
        Me.txtabertura.CustomButton.Image = Nothing
        Me.txtabertura.CustomButton.Location = New System.Drawing.Point(37, 2)
        Me.txtabertura.CustomButton.Name = ""
        Me.txtabertura.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtabertura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtabertura.CustomButton.TabIndex = 1
        Me.txtabertura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtabertura.CustomButton.UseSelectable = True
        Me.txtabertura.CustomButton.Visible = False
        Me.txtabertura.Lines = New String(-1) {}
        Me.txtabertura.Location = New System.Drawing.Point(73, 4)
        Me.txtabertura.MaxLength = 32767
        Me.txtabertura.Name = "txtabertura"
        Me.txtabertura.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtabertura.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtabertura.SelectedText = ""
        Me.txtabertura.SelectionLength = 0
        Me.txtabertura.SelectionStart = 0
        Me.txtabertura.ShortcutsEnabled = True
        Me.txtabertura.Size = New System.Drawing.Size(55, 20)
        Me.txtabertura.TabIndex = 78
        Me.txtabertura.UseSelectable = True
        Me.txtabertura.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtabertura.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbabertura
        '
        Me.cbabertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbabertura.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbabertura.FormattingEnabled = True
        Me.cbabertura.ItemHeight = 19
        Me.cbabertura.Location = New System.Drawing.Point(73, 4)
        Me.cbabertura.Name = "cbabertura"
        Me.cbabertura.Size = New System.Drawing.Size(65, 25)
        Me.cbabertura.TabIndex = 90
        Me.cbabertura.UseSelectable = True
        '
        'pnlrazon
        '
        Me.pnlrazon.Controls.Add(Me.cbrazon)
        Me.pnlrazon.Controls.Add(Me.Label18)
        Me.pnlrazon.HorizontalScrollbarBarColor = True
        Me.pnlrazon.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlrazon.HorizontalScrollbarSize = 10
        Me.pnlrazon.Location = New System.Drawing.Point(168, 156)
        Me.pnlrazon.Name = "pnlrazon"
        Me.pnlrazon.Size = New System.Drawing.Size(207, 34)
        Me.pnlrazon.TabIndex = 6
        Me.pnlrazon.VerticalScrollbarBarColor = True
        Me.pnlrazon.VerticalScrollbarHighlightOnWheel = False
        Me.pnlrazon.VerticalScrollbarSize = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(563, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 425)
        Me.GroupBox2.TabIndex = 92
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CubrePlacas en Línea"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgLineaII)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(189, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(209, 346)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Linea II"
        '
        'dgLineaII
        '
        Me.dgLineaII.AllowUserToAddRows = False
        Me.dgLineaII.AllowUserToDeleteRows = False
        Me.dgLineaII.AllowUserToResizeRows = False
        Me.dgLineaII.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLineaII.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgLineaII.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgLineaII.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineaII.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLineaII.DefaultCellStyle = DataGridViewCellStyle20
        Me.dgLineaII.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLineaII.EnableHeadersVisualStyles = False
        Me.dgLineaII.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgLineaII.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLineaII.Location = New System.Drawing.Point(3, 16)
        Me.dgLineaII.MultiSelect = False
        Me.dgLineaII.Name = "dgLineaII"
        Me.dgLineaII.ReadOnly = True
        Me.dgLineaII.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineaII.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgLineaII.RowHeadersVisible = False
        Me.dgLineaII.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLineaII.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLineaII.Size = New System.Drawing.Size(203, 327)
        Me.dgLineaII.Style = MetroFramework.MetroColorStyle.Orange
        Me.dgLineaII.TabIndex = 4
        Me.dgLineaII.UseCustomBackColor = True
        Me.dgLineaII.UseCustomForeColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgLineaI)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(186, 346)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Línea I"
        '
        'dgLineaI
        '
        Me.dgLineaI.AllowUserToAddRows = False
        Me.dgLineaI.AllowUserToDeleteRows = False
        Me.dgLineaI.AllowUserToResizeRows = False
        Me.dgLineaI.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLineaI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgLineaI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgLineaI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineaI.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLineaI.DefaultCellStyle = DataGridViewCellStyle23
        Me.dgLineaI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLineaI.EnableHeadersVisualStyles = False
        Me.dgLineaI.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgLineaI.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLineaI.Location = New System.Drawing.Point(3, 16)
        Me.dgLineaI.MultiSelect = False
        Me.dgLineaI.Name = "dgLineaI"
        Me.dgLineaI.ReadOnly = True
        Me.dgLineaI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineaI.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.dgLineaI.RowHeadersVisible = False
        Me.dgLineaI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLineaI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLineaI.Size = New System.Drawing.Size(180, 327)
        Me.dgLineaI.Style = MetroFramework.MetroColorStyle.Orange
        Me.dgLineaI.TabIndex = 3
        Me.dgLineaI.UseCustomBackColor = True
        Me.dgLineaI.UseCustomForeColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(3, 362)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(395, 60)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.TextBox1.CustomButton.Image = Nothing
        Me.TextBox1.CustomButton.Location = New System.Drawing.Point(349, 1)
        Me.TextBox1.CustomButton.Name = ""
        Me.TextBox1.CustomButton.Size = New System.Drawing.Size(39, 39)
        Me.TextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBox1.CustomButton.TabIndex = 1
        Me.TextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBox1.CustomButton.UseSelectable = True
        Me.TextBox1.CustomButton.Visible = False
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Lines = New String() {"Puede hacer un egreso presionando doble click sobre la abertura seleccionada. Lue" &
            "go deberá seleccionar la razón de egreso."}
        Me.TextBox1.Location = New System.Drawing.Point(3, 16)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionLength = 0
        Me.TextBox1.SelectionStart = 0
        Me.TextBox1.ShortcutsEnabled = True
        Me.TextBox1.Size = New System.Drawing.Size(389, 41)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Puede hacer un egreso presionando doble click sobre la abertura seleccionada. Lue" &
    "go deberá seleccionar la razón de egreso."
        Me.TextBox1.UseSelectable = True
        Me.TextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LAVCCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 522)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pnlrazon)
        Me.Controls.Add(Me.pnlabertura)
        Me.Controls.Add(Me.pnlplaca)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cblinea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Name = "LAVCCP"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Cambio de Cubreplacas"
        Me.TabControl1.ResumeLayout(False)
        Me.tpIng.ResumeLayout(False)
        CType(Me.dgIng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEgr.ResumeLayout(False)
        CType(Me.dgEgr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlplaca.ResumeLayout(False)
        Me.pnlplaca.PerformLayout()
        Me.pnlabertura.ResumeLayout(False)
        Me.pnlabertura.PerformLayout()
        Me.pnlrazon.ResumeLayout(False)
        Me.pnlrazon.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgLineaII, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgLineaI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cblinea As MetroComboBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents TabControl1 As MetroTabControl
    Friend WithEvents tpIng As MetroTabPage
    Friend WithEvents cbrazon As MetroComboBox
    Friend WithEvents Label18 As MetroLabel
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents txtplaca As MetroTextBox
    Friend WithEvents Label20 As MetroLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbEgr As MetroRadioButton
    Friend WithEvents rbIng As MetroRadioButton
    Friend WithEvents pnlplaca As MetroPanel
    Friend WithEvents pnlabertura As MetroPanel
    Friend WithEvents tpEgr As MetroTabPage
    Friend WithEvents pnlrazon As MetroPanel
    Friend WithEvents txtabertura As MetroTextBox
    Friend WithEvents cbplaca As MetroComboBox
    Friend WithEvents cbabertura As MetroComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As MetroTextBox
    Friend WithEvents dgIng As MetroGrid
    Friend WithEvents dgEgr As MetroGrid
    Friend WithEvents dgLineaII As MetroGrid
    Friend WithEvents dgLineaI As MetroGrid
End Class
