Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LAVTDH
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.Label19 = New MetroFramework.Controls.MetroLabel()
        Me.txtcantidad = New MetroFramework.Controls.MetroTextBox()
        Me.cblinea = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tplavado = New MetroFramework.Controls.MetroTabPage()
        Me.dgLav = New MetroFramework.Controls.MetroGrid()
        Me.tprepara = New MetroFramework.Controls.MetroTabPage()
        Me.dgRepara = New MetroFramework.Controls.MetroGrid()
        Me.tpcambio = New MetroFramework.Controls.MetroTabPage()
        Me.dgCambio = New MetroFramework.Controls.MetroGrid()
        Me.tpnuevo = New MetroFramework.Controls.MetroTabPage()
        Me.dgNuevo = New MetroFramework.Controls.MetroGrid()
        Me.tpbaja = New MetroFramework.Controls.MetroTabPage()
        Me.dgBaja = New MetroFramework.Controls.MetroGrid()
        Me.cbrazon = New MetroFramework.Controls.MetroComboBox()
        Me.Label18 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txttejido = New MetroFramework.Controls.MetroTextBox()
        Me.cbdestino = New MetroFramework.Controls.MetroComboBox()
        Me.Label20 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbbaja = New MetroFramework.Controls.MetroRadioButton()
        Me.rbnuevos = New MetroFramework.Controls.MetroRadioButton()
        Me.rbcambio = New MetroFramework.Controls.MetroRadioButton()
        Me.rbrepara = New MetroFramework.Controls.MetroRadioButton()
        Me.rblavado = New MetroFramework.Controls.MetroRadioButton()
        Me.pnlcant = New MetroFramework.Controls.MetroPanel()
        Me.pnltejido = New MetroFramework.Controls.MetroPanel()
        Me.pnldestino = New MetroFramework.Controls.MetroPanel()
        Me.pnlrazon = New MetroFramework.Controls.MetroPanel()
        Me.TabControl1.SuspendLayout()
        Me.tplavado.SuspendLayout()
        CType(Me.dgLav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tprepara.SuspendLayout()
        CType(Me.dgRepara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpcambio.SuspendLayout()
        CType(Me.dgCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpnuevo.SuspendLayout()
        CType(Me.dgNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpbaja.SuspendLayout()
        CType(Me.dgBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pnlcant.SuspendLayout()
        Me.pnltejido.SuspendLayout()
        Me.pnldestino.SuspendLayout()
        Me.pnlrazon.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(320, 71)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(56, 25)
        Me.cbturno.Style = MetroFramework.MetroColorStyle.Orange
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
        Me.cbgrupo.Location = New System.Drawing.Point(439, 71)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(43, 25)
        Me.cbgrupo.Style = MetroFramework.MetroColorStyle.Orange
        Me.cbgrupo.TabIndex = 2
        Me.cbgrupo.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(268, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(388, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(446, 215)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 9
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(543, 215)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 8
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(6, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 19)
        Me.Label19.TabIndex = 77
        Me.Label19.Text = "Cantidad:"
        '
        'txtcantidad
        '
        '
        '
        '
        Me.txtcantidad.CustomButton.Image = Nothing
        Me.txtcantidad.CustomButton.Location = New System.Drawing.Point(37, 2)
        Me.txtcantidad.CustomButton.Name = ""
        Me.txtcantidad.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcantidad.CustomButton.TabIndex = 1
        Me.txtcantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcantidad.CustomButton.UseSelectable = True
        Me.txtcantidad.CustomButton.Visible = False
        Me.txtcantidad.Lines = New String(-1) {}
        Me.txtcantidad.Location = New System.Drawing.Point(96, 10)
        Me.txtcantidad.MaxLength = 32767
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcantidad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcantidad.SelectedText = ""
        Me.txtcantidad.SelectionLength = 0
        Me.txtcantidad.SelectionStart = 0
        Me.txtcantidad.ShortcutsEnabled = True
        Me.txtcantidad.Size = New System.Drawing.Size(55, 20)
        Me.txtcantidad.TabIndex = 76
        Me.txtcantidad.UseSelectable = True
        Me.txtcantidad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcantidad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cblinea
        '
        Me.cblinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cblinea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cblinea.FormattingEnabled = True
        Me.cblinea.ItemHeight = 19
        Me.cblinea.Items.AddRange(New Object() {"1", "2"})
        Me.cblinea.Location = New System.Drawing.Point(543, 71)
        Me.cblinea.Name = "cblinea"
        Me.cblinea.Size = New System.Drawing.Size(39, 25)
        Me.cblinea.Style = MetroFramework.MetroColorStyle.Orange
        Me.cblinea.TabIndex = 3
        Me.cblinea.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(495, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 19)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Línea:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tplavado)
        Me.TabControl1.Controls.Add(Me.tprepara)
        Me.TabControl1.Controls.Add(Me.tpcambio)
        Me.TabControl1.Controls.Add(Me.tpnuevo)
        Me.TabControl1.Controls.Add(Me.tpbaja)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(5, 271)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(635, 225)
        Me.TabControl1.Style = MetroFramework.MetroColorStyle.Orange
        Me.TabControl1.TabIndex = 71
        Me.TabControl1.UseSelectable = True
        '
        'tplavado
        '
        Me.tplavado.Controls.Add(Me.dgLav)
        Me.tplavado.HorizontalScrollbarBarColor = True
        Me.tplavado.HorizontalScrollbarHighlightOnWheel = False
        Me.tplavado.HorizontalScrollbarSize = 10
        Me.tplavado.Location = New System.Drawing.Point(4, 38)
        Me.tplavado.Name = "tplavado"
        Me.tplavado.Padding = New System.Windows.Forms.Padding(3)
        Me.tplavado.Size = New System.Drawing.Size(627, 183)
        Me.tplavado.TabIndex = 0
        Me.tplavado.Text = "Lavado"
        Me.tplavado.UseVisualStyleBackColor = True
        Me.tplavado.VerticalScrollbarBarColor = True
        Me.tplavado.VerticalScrollbarHighlightOnWheel = False
        Me.tplavado.VerticalScrollbarSize = 10
        '
        'dgLav
        '
        Me.dgLav.AllowUserToAddRows = False
        Me.dgLav.AllowUserToDeleteRows = False
        Me.dgLav.AllowUserToResizeRows = False
        Me.dgLav.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgLav.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLav.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgLav.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgLav.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLav.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLav.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgLav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLav.EnableHeadersVisualStyles = False
        Me.dgLav.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgLav.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLav.Location = New System.Drawing.Point(3, 3)
        Me.dgLav.MultiSelect = False
        Me.dgLav.Name = "dgLav"
        Me.dgLav.ReadOnly = True
        Me.dgLav.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLav.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgLav.RowHeadersVisible = False
        Me.dgLav.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLav.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLav.Size = New System.Drawing.Size(621, 177)
        Me.dgLav.Style = MetroFramework.MetroColorStyle.Orange
        Me.dgLav.TabIndex = 5
        Me.dgLav.UseCustomBackColor = True
        Me.dgLav.UseCustomForeColor = True
        Me.dgLav.UseStyleColors = True
        '
        'tprepara
        '
        Me.tprepara.Controls.Add(Me.dgRepara)
        Me.tprepara.HorizontalScrollbarBarColor = True
        Me.tprepara.HorizontalScrollbarHighlightOnWheel = False
        Me.tprepara.HorizontalScrollbarSize = 10
        Me.tprepara.Location = New System.Drawing.Point(4, 38)
        Me.tprepara.Name = "tprepara"
        Me.tprepara.Padding = New System.Windows.Forms.Padding(3)
        Me.tprepara.Size = New System.Drawing.Size(627, 183)
        Me.tprepara.TabIndex = 1
        Me.tprepara.Text = "Reparación"
        Me.tprepara.UseVisualStyleBackColor = True
        Me.tprepara.VerticalScrollbarBarColor = True
        Me.tprepara.VerticalScrollbarHighlightOnWheel = False
        Me.tprepara.VerticalScrollbarSize = 10
        '
        'dgRepara
        '
        Me.dgRepara.AllowUserToAddRows = False
        Me.dgRepara.AllowUserToDeleteRows = False
        Me.dgRepara.AllowUserToResizeRows = False
        Me.dgRepara.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgRepara.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRepara.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgRepara.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgRepara.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRepara.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRepara.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgRepara.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRepara.EnableHeadersVisualStyles = False
        Me.dgRepara.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgRepara.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRepara.Location = New System.Drawing.Point(3, 3)
        Me.dgRepara.MultiSelect = False
        Me.dgRepara.Name = "dgRepara"
        Me.dgRepara.ReadOnly = True
        Me.dgRepara.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRepara.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgRepara.RowHeadersVisible = False
        Me.dgRepara.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgRepara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRepara.Size = New System.Drawing.Size(621, 177)
        Me.dgRepara.Style = MetroFramework.MetroColorStyle.Orange
        Me.dgRepara.TabIndex = 7
        Me.dgRepara.UseCustomBackColor = True
        Me.dgRepara.UseCustomForeColor = True
        Me.dgRepara.UseStyleColors = True
        '
        'tpcambio
        '
        Me.tpcambio.Controls.Add(Me.dgCambio)
        Me.tpcambio.HorizontalScrollbarBarColor = True
        Me.tpcambio.HorizontalScrollbarHighlightOnWheel = False
        Me.tpcambio.HorizontalScrollbarSize = 10
        Me.tpcambio.Location = New System.Drawing.Point(4, 38)
        Me.tpcambio.Name = "tpcambio"
        Me.tpcambio.Padding = New System.Windows.Forms.Padding(3)
        Me.tpcambio.Size = New System.Drawing.Size(627, 183)
        Me.tpcambio.TabIndex = 2
        Me.tpcambio.Text = "Cambio"
        Me.tpcambio.UseVisualStyleBackColor = True
        Me.tpcambio.VerticalScrollbarBarColor = True
        Me.tpcambio.VerticalScrollbarHighlightOnWheel = False
        Me.tpcambio.VerticalScrollbarSize = 10
        '
        'dgCambio
        '
        Me.dgCambio.AllowUserToAddRows = False
        Me.dgCambio.AllowUserToDeleteRows = False
        Me.dgCambio.AllowUserToResizeRows = False
        Me.dgCambio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgCambio.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCambio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCambio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgCambio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCambio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCambio.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgCambio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCambio.EnableHeadersVisualStyles = False
        Me.dgCambio.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgCambio.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCambio.Location = New System.Drawing.Point(3, 3)
        Me.dgCambio.MultiSelect = False
        Me.dgCambio.Name = "dgCambio"
        Me.dgCambio.ReadOnly = True
        Me.dgCambio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCambio.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgCambio.RowHeadersVisible = False
        Me.dgCambio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgCambio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCambio.Size = New System.Drawing.Size(621, 177)
        Me.dgCambio.Style = MetroFramework.MetroColorStyle.Orange
        Me.dgCambio.TabIndex = 8
        Me.dgCambio.UseCustomBackColor = True
        Me.dgCambio.UseCustomForeColor = True
        Me.dgCambio.UseStyleColors = True
        '
        'tpnuevo
        '
        Me.tpnuevo.Controls.Add(Me.dgNuevo)
        Me.tpnuevo.HorizontalScrollbarBarColor = True
        Me.tpnuevo.HorizontalScrollbarHighlightOnWheel = False
        Me.tpnuevo.HorizontalScrollbarSize = 10
        Me.tpnuevo.Location = New System.Drawing.Point(4, 38)
        Me.tpnuevo.Name = "tpnuevo"
        Me.tpnuevo.Size = New System.Drawing.Size(627, 183)
        Me.tpnuevo.TabIndex = 3
        Me.tpnuevo.Text = "Nuevos"
        Me.tpnuevo.UseVisualStyleBackColor = True
        Me.tpnuevo.VerticalScrollbarBarColor = True
        Me.tpnuevo.VerticalScrollbarHighlightOnWheel = False
        Me.tpnuevo.VerticalScrollbarSize = 10
        '
        'dgNuevo
        '
        Me.dgNuevo.AllowUserToAddRows = False
        Me.dgNuevo.AllowUserToDeleteRows = False
        Me.dgNuevo.AllowUserToResizeRows = False
        Me.dgNuevo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgNuevo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgNuevo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgNuevo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgNuevo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgNuevo.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgNuevo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgNuevo.EnableHeadersVisualStyles = False
        Me.dgNuevo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgNuevo.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgNuevo.Location = New System.Drawing.Point(0, 0)
        Me.dgNuevo.MultiSelect = False
        Me.dgNuevo.Name = "dgNuevo"
        Me.dgNuevo.ReadOnly = True
        Me.dgNuevo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgNuevo.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgNuevo.RowHeadersVisible = False
        Me.dgNuevo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgNuevo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgNuevo.Size = New System.Drawing.Size(627, 183)
        Me.dgNuevo.Style = MetroFramework.MetroColorStyle.Orange
        Me.dgNuevo.TabIndex = 6
        Me.dgNuevo.UseCustomBackColor = True
        Me.dgNuevo.UseCustomForeColor = True
        Me.dgNuevo.UseStyleColors = True
        '
        'tpbaja
        '
        Me.tpbaja.Controls.Add(Me.dgBaja)
        Me.tpbaja.HorizontalScrollbarBarColor = True
        Me.tpbaja.HorizontalScrollbarHighlightOnWheel = False
        Me.tpbaja.HorizontalScrollbarSize = 10
        Me.tpbaja.Location = New System.Drawing.Point(4, 38)
        Me.tpbaja.Name = "tpbaja"
        Me.tpbaja.Size = New System.Drawing.Size(627, 183)
        Me.tpbaja.TabIndex = 4
        Me.tpbaja.Text = "Bajas"
        Me.tpbaja.UseVisualStyleBackColor = True
        Me.tpbaja.VerticalScrollbarBarColor = True
        Me.tpbaja.VerticalScrollbarHighlightOnWheel = False
        Me.tpbaja.VerticalScrollbarSize = 10
        '
        'dgBaja
        '
        Me.dgBaja.AllowUserToAddRows = False
        Me.dgBaja.AllowUserToDeleteRows = False
        Me.dgBaja.AllowUserToResizeRows = False
        Me.dgBaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgBaja.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBaja.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgBaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgBaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgBaja.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgBaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBaja.EnableHeadersVisualStyles = False
        Me.dgBaja.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgBaja.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBaja.Location = New System.Drawing.Point(0, 0)
        Me.dgBaja.MultiSelect = False
        Me.dgBaja.Name = "dgBaja"
        Me.dgBaja.ReadOnly = True
        Me.dgBaja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBaja.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgBaja.RowHeadersVisible = False
        Me.dgBaja.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgBaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBaja.Size = New System.Drawing.Size(627, 183)
        Me.dgBaja.Style = MetroFramework.MetroColorStyle.Orange
        Me.dgBaja.TabIndex = 4
        Me.dgBaja.UseCustomBackColor = True
        Me.dgBaja.UseCustomForeColor = True
        Me.dgBaja.UseStyleColors = True
        '
        'cbrazon
        '
        Me.cbrazon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbrazon.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbrazon.FormattingEnabled = True
        Me.cbrazon.ItemHeight = 19
        Me.cbrazon.Location = New System.Drawing.Point(67, 4)
        Me.cbrazon.Name = "cbrazon"
        Me.cbrazon.Size = New System.Drawing.Size(112, 25)
        Me.cbrazon.Style = MetroFramework.MetroColorStyle.Orange
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
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Nº de tejido:"
        '
        'txttejido
        '
        '
        '
        '
        Me.txttejido.CustomButton.Image = Nothing
        Me.txttejido.CustomButton.Location = New System.Drawing.Point(37, 2)
        Me.txttejido.CustomButton.Name = ""
        Me.txttejido.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txttejido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttejido.CustomButton.TabIndex = 1
        Me.txttejido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttejido.CustomButton.UseSelectable = True
        Me.txttejido.CustomButton.Visible = False
        Me.txttejido.Lines = New String(-1) {}
        Me.txttejido.Location = New System.Drawing.Point(97, 9)
        Me.txttejido.MaxLength = 32767
        Me.txttejido.Name = "txttejido"
        Me.txttejido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttejido.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttejido.SelectedText = ""
        Me.txttejido.SelectionLength = 0
        Me.txttejido.SelectionStart = 0
        Me.txttejido.ShortcutsEnabled = True
        Me.txttejido.Size = New System.Drawing.Size(55, 20)
        Me.txttejido.TabIndex = 76
        Me.txttejido.UseSelectable = True
        Me.txttejido.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttejido.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbdestino
        '
        Me.cbdestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbdestino.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbdestino.FormattingEnabled = True
        Me.cbdestino.ItemHeight = 19
        Me.cbdestino.Location = New System.Drawing.Point(230, 2)
        Me.cbdestino.Name = "cbdestino"
        Me.cbdestino.Size = New System.Drawing.Size(111, 25)
        Me.cbdestino.Style = MetroFramework.MetroColorStyle.Orange
        Me.cbdestino.TabIndex = 84
        Me.cbdestino.UseSelectable = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(169, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 19)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "Destino:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 15)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Fecha para búsqueda:"
        '
        'dtfecha
        '
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(156, 240)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(80, 20)
        Me.dtfecha.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbbaja)
        Me.GroupBox1.Controls.Add(Me.rbnuevos)
        Me.GroupBox1.Controls.Add(Me.rbcambio)
        Me.GroupBox1.Controls.Add(Me.rbrepara)
        Me.GroupBox1.Controls.Add(Me.rblavado)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rbbaja
        '
        Me.rbbaja.AutoSize = True
        Me.rbbaja.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbbaja.Location = New System.Drawing.Point(6, 108)
        Me.rbbaja.Name = "rbbaja"
        Me.rbbaja.Size = New System.Drawing.Size(137, 15)
        Me.rbbaja.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbbaja.TabIndex = 4
        Me.rbbaja.Text = "Tejidos dados de baja"
        Me.rbbaja.UseSelectable = True
        '
        'rbnuevos
        '
        Me.rbnuevos.AutoSize = True
        Me.rbnuevos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbnuevos.Location = New System.Drawing.Point(6, 87)
        Me.rbnuevos.Name = "rbnuevos"
        Me.rbnuevos.Size = New System.Drawing.Size(178, 15)
        Me.rbnuevos.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbnuevos.TabIndex = 3
        Me.rbnuevos.Text = "Colocación de tejidos nuevos"
        Me.rbnuevos.UseSelectable = True
        '
        'rbcambio
        '
        Me.rbcambio.AutoSize = True
        Me.rbcambio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbcambio.Location = New System.Drawing.Point(6, 65)
        Me.rbcambio.Name = "rbcambio"
        Me.rbcambio.Size = New System.Drawing.Size(119, 15)
        Me.rbcambio.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbcambio.TabIndex = 2
        Me.rbcambio.Text = "Cambio de tejidos"
        Me.rbcambio.UseSelectable = True
        '
        'rbrepara
        '
        Me.rbrepara.AutoSize = True
        Me.rbrepara.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbrepara.Location = New System.Drawing.Point(6, 44)
        Me.rbrepara.Name = "rbrepara"
        Me.rbrepara.Size = New System.Drawing.Size(218, 15)
        Me.rbrepara.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbrepara.TabIndex = 1
        Me.rbrepara.Text = "Segregado de tejidos para reparación"
        Me.rbrepara.UseSelectable = True
        '
        'rblavado
        '
        Me.rblavado.AutoSize = True
        Me.rblavado.Checked = True
        Me.rblavado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rblavado.Location = New System.Drawing.Point(6, 23)
        Me.rblavado.Name = "rblavado"
        Me.rblavado.Size = New System.Drawing.Size(115, 15)
        Me.rblavado.Style = MetroFramework.MetroColorStyle.Orange
        Me.rblavado.TabIndex = 0
        Me.rblavado.TabStop = True
        Me.rblavado.Text = "Lavado de tejidos"
        Me.rblavado.UseSelectable = True
        '
        'pnlcant
        '
        Me.pnlcant.Controls.Add(Me.Label19)
        Me.pnlcant.Controls.Add(Me.txtcantidad)
        Me.pnlcant.HorizontalScrollbarBarColor = True
        Me.pnlcant.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlcant.HorizontalScrollbarSize = 10
        Me.pnlcant.Location = New System.Drawing.Point(277, 101)
        Me.pnlcant.Name = "pnlcant"
        Me.pnlcant.Size = New System.Drawing.Size(160, 33)
        Me.pnlcant.TabIndex = 4
        Me.pnlcant.VerticalScrollbarBarColor = True
        Me.pnlcant.VerticalScrollbarHighlightOnWheel = False
        Me.pnlcant.VerticalScrollbarSize = 10
        '
        'pnltejido
        '
        Me.pnltejido.Controls.Add(Me.Label1)
        Me.pnltejido.Controls.Add(Me.txttejido)
        Me.pnltejido.HorizontalScrollbarBarColor = True
        Me.pnltejido.HorizontalScrollbarHighlightOnWheel = False
        Me.pnltejido.HorizontalScrollbarSize = 10
        Me.pnltejido.Location = New System.Drawing.Point(276, 133)
        Me.pnltejido.Name = "pnltejido"
        Me.pnltejido.Size = New System.Drawing.Size(161, 33)
        Me.pnltejido.TabIndex = 5
        Me.pnltejido.VerticalScrollbarBarColor = True
        Me.pnltejido.VerticalScrollbarHighlightOnWheel = False
        Me.pnltejido.VerticalScrollbarSize = 10
        '
        'pnldestino
        '
        Me.pnldestino.Controls.Add(Me.cbdestino)
        Me.pnldestino.Controls.Add(Me.Label20)
        Me.pnldestino.HorizontalScrollbarBarColor = True
        Me.pnldestino.HorizontalScrollbarHighlightOnWheel = False
        Me.pnldestino.HorizontalScrollbarSize = 10
        Me.pnldestino.Location = New System.Drawing.Point(277, 167)
        Me.pnldestino.Name = "pnldestino"
        Me.pnldestino.Size = New System.Drawing.Size(351, 30)
        Me.pnldestino.TabIndex = 7
        Me.pnldestino.VerticalScrollbarBarColor = True
        Me.pnldestino.VerticalScrollbarHighlightOnWheel = False
        Me.pnldestino.VerticalScrollbarSize = 10
        '
        'pnlrazon
        '
        Me.pnlrazon.Controls.Add(Me.cbrazon)
        Me.pnlrazon.Controls.Add(Me.Label18)
        Me.pnlrazon.HorizontalScrollbarBarColor = True
        Me.pnlrazon.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlrazon.HorizontalScrollbarSize = 10
        Me.pnlrazon.Location = New System.Drawing.Point(439, 133)
        Me.pnlrazon.Name = "pnlrazon"
        Me.pnlrazon.Size = New System.Drawing.Size(188, 34)
        Me.pnlrazon.TabIndex = 6
        Me.pnlrazon.VerticalScrollbarBarColor = True
        Me.pnlrazon.VerticalScrollbarHighlightOnWheel = False
        Me.pnlrazon.VerticalScrollbarSize = 10
        '
        'LAVTDH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 501)
        Me.Controls.Add(Me.pnlrazon)
        Me.Controls.Add(Me.pnldestino)
        Me.Controls.Add(Me.pnltejido)
        Me.Controls.Add(Me.pnlcant)
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
        Me.Name = "LAVTDH"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Tejidos Doble Hilado"
        Me.TransparencyKey = System.Drawing.Color.CornflowerBlue
        Me.TabControl1.ResumeLayout(False)
        Me.tplavado.ResumeLayout(False)
        CType(Me.dgLav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tprepara.ResumeLayout(False)
        CType(Me.dgRepara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpcambio.ResumeLayout(False)
        CType(Me.dgCambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpnuevo.ResumeLayout(False)
        CType(Me.dgNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpbaja.ResumeLayout(False)
        CType(Me.dgBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlcant.ResumeLayout(False)
        Me.pnlcant.PerformLayout()
        Me.pnltejido.ResumeLayout(False)
        Me.pnltejido.PerformLayout()
        Me.pnldestino.ResumeLayout(False)
        Me.pnldestino.PerformLayout()
        Me.pnlrazon.ResumeLayout(False)
        Me.pnlrazon.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents Label19 As MetroLabel
    Friend WithEvents txtcantidad As MetroTextBox
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cblinea As MetroComboBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents TabControl1 As MetroTabControl
    Friend WithEvents cbrazon As MetroComboBox
    Friend WithEvents Label18 As MetroLabel
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents txttejido As MetroTextBox
    Friend WithEvents cbdestino As MetroComboBox
    Friend WithEvents Label20 As MetroLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbbaja As MetroRadioButton
    Friend WithEvents rbnuevos As MetroRadioButton
    Friend WithEvents rbcambio As MetroRadioButton
    Friend WithEvents rbrepara As MetroRadioButton
    Friend WithEvents rblavado As MetroRadioButton
    Friend WithEvents pnlcant As MetroPanel
    Friend WithEvents pnltejido As MetroPanel
    Friend WithEvents pnldestino As MetroPanel
    Friend WithEvents tprepara As MetroTabPage
    Friend WithEvents tpcambio As MetroTabPage
    Friend WithEvents tpnuevo As MetroTabPage
    Friend WithEvents tpbaja As MetroTabPage
    Friend WithEvents pnlrazon As MetroPanel
    Friend WithEvents tplavado As MetroTabPage
    Friend WithEvents dgBaja As MetroGrid
    Friend WithEvents dgLav As MetroGrid
    Friend WithEvents dgRepara As MetroGrid
    Friend WithEvents dgNuevo As MetroGrid
    Friend WithEvents dgCambio As MetroGrid
End Class
