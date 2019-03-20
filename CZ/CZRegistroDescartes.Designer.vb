Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CZRegistroDescartes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.dgLineaI = New MetroFramework.Controls.MetroGrid()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.dgLineaII = New MetroFramework.Controls.MetroGrid()
        Me.lblL1 = New MetroFramework.Controls.MetroLabel()
        Me.Label15 = New MetroFramework.Controls.MetroLabel()
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnGuargarLII = New MetroFramework.Controls.MetroButton()
        Me.lblL2 = New MetroFramework.Controls.MetroLabel()
        Me.cbitm2 = New MetroFramework.Controls.MetroComboBox()
        Me.Label14 = New MetroFramework.Controls.MetroLabel()
        Me.Label13 = New MetroFramework.Controls.MetroLabel()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.txtcant2 = New MetroFramework.Controls.MetroTextBox()
        Me.cbgrupo2 = New MetroFramework.Controls.MetroComboBox()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.btnguardarLI = New MetroFramework.Controls.MetroButton()
        Me.txtcant1 = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.cbitm1 = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo1 = New MetroFramework.Controls.MetroComboBox()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgLineaI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgLineaII, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(305, 29)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(60, 25)
        Me.cbturno.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbturno.TabIndex = 0
        Me.cbturno.UseSelectable = True
        '
        'cbgrupo
        '
        Me.cbgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbgrupo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbgrupo.FormattingEnabled = True
        Me.cbgrupo.ItemHeight = 19
        Me.cbgrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbgrupo.Location = New System.Drawing.Point(456, 29)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(60, 25)
        Me.cbgrupo.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbgrupo.TabIndex = 1
        Me.cbgrupo.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(110, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Línea: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(253, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(401, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgLineaI)
        Me.TabPage1.HorizontalScrollbarBarColor = True
        Me.TabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage1.HorizontalScrollbarSize = 10
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(727, 184)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Línea I"
        Me.TabPage1.UseVisualStyleBackColor = True
        Me.TabPage1.VerticalScrollbarBarColor = True
        Me.TabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage1.VerticalScrollbarSize = 10
        '
        'dgLineaI
        '
        Me.dgLineaI.AllowUserToAddRows = False
        Me.dgLineaI.AllowUserToDeleteRows = False
        Me.dgLineaI.AllowUserToResizeColumns = False
        Me.dgLineaI.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dgLineaI.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgLineaI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgLineaI.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLineaI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgLineaI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgLineaI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineaI.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgLineaI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLineaI.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgLineaI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLineaI.EnableHeadersVisualStyles = False
        Me.dgLineaI.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgLineaI.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLineaI.Location = New System.Drawing.Point(3, 3)
        Me.dgLineaI.MultiSelect = False
        Me.dgLineaI.Name = "dgLineaI"
        Me.dgLineaI.ReadOnly = True
        Me.dgLineaI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineaI.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgLineaI.RowHeadersVisible = False
        Me.dgLineaI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLineaI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLineaI.Size = New System.Drawing.Size(721, 178)
        Me.dgLineaI.Style = MetroFramework.MetroColorStyle.Brown
        Me.dgLineaI.TabIndex = 28
        Me.dgLineaI.UseCustomBackColor = True
        Me.dgLineaI.UseCustomForeColor = True
        Me.dgLineaI.UseStyleColors = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(5, 314)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 1
        Me.TabControl1.Size = New System.Drawing.Size(735, 226)
        Me.TabControl1.Style = MetroFramework.MetroColorStyle.Brown
        Me.TabControl1.TabIndex = 56
        Me.TabControl1.UseSelectable = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgLineaII)
        Me.TabPage2.HorizontalScrollbarBarColor = True
        Me.TabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage2.HorizontalScrollbarSize = 10
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(727, 184)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Línea II"
        Me.TabPage2.UseVisualStyleBackColor = True
        Me.TabPage2.VerticalScrollbarBarColor = True
        Me.TabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage2.VerticalScrollbarSize = 10
        '
        'dgLineaII
        '
        Me.dgLineaII.AllowUserToAddRows = False
        Me.dgLineaII.AllowUserToDeleteRows = False
        Me.dgLineaII.AllowUserToResizeColumns = False
        Me.dgLineaII.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender
        Me.dgLineaII.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgLineaII.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgLineaII.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLineaII.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgLineaII.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgLineaII.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineaII.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgLineaII.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLineaII.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgLineaII.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLineaII.EnableHeadersVisualStyles = False
        Me.dgLineaII.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgLineaII.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLineaII.Location = New System.Drawing.Point(3, 3)
        Me.dgLineaII.MultiSelect = False
        Me.dgLineaII.Name = "dgLineaII"
        Me.dgLineaII.ReadOnly = True
        Me.dgLineaII.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineaII.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgLineaII.RowHeadersVisible = False
        Me.dgLineaII.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLineaII.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLineaII.Size = New System.Drawing.Size(721, 178)
        Me.dgLineaII.Style = MetroFramework.MetroColorStyle.Brown
        Me.dgLineaII.TabIndex = 28
        Me.dgLineaII.UseCustomBackColor = True
        Me.dgLineaII.UseCustomForeColor = True
        Me.dgLineaII.UseStyleColors = True
        '
        'lblL1
        '
        Me.lblL1.AutoSize = True
        Me.lblL1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblL1.Location = New System.Drawing.Point(194, 11)
        Me.lblL1.Name = "lblL1"
        Me.lblL1.Size = New System.Drawing.Size(16, 19)
        Me.lblL1.TabIndex = 69
        Me.lblL1.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(14, 290)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 19)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "Fecha:"
        '
        'dtfecha
        '
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(81, 283)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(86, 25)
        Me.dtfecha.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 63)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnGuargarLII)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblL2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbitm2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtcant2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbgrupo2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnguardarLI)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtcant1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblL1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbitm1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbgrupo1)
        Me.SplitContainer1.Size = New System.Drawing.Size(721, 201)
        Me.SplitContainer1.SplitterDistance = 352
        Me.SplitContainer1.TabIndex = 2
        '
        'btnGuargarLII
        '
        Me.btnGuargarLII.BackgroundImage = Global.SPIF.My.Resources.Resources.Arrow_Down
        Me.btnGuargarLII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuargarLII.Location = New System.Drawing.Point(151, 147)
        Me.btnGuargarLII.Name = "btnGuargarLII"
        Me.btnGuargarLII.Size = New System.Drawing.Size(46, 37)
        Me.btnGuargarLII.TabIndex = 3
        Me.btnGuargarLII.UseSelectable = True
        '
        'lblL2
        '
        Me.lblL2.AutoSize = True
        Me.lblL2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblL2.Location = New System.Drawing.Point(180, 13)
        Me.lblL2.Name = "lblL2"
        Me.lblL2.Size = New System.Drawing.Size(16, 19)
        Me.lblL2.TabIndex = 91
        Me.lblL2.Text = "2"
        '
        'cbitm2
        '
        Me.cbitm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbitm2.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbitm2.FormattingEnabled = True
        Me.cbitm2.ItemHeight = 19
        Me.cbitm2.Location = New System.Drawing.Point(84, 75)
        Me.cbitm2.Name = "cbitm2"
        Me.cbitm2.Size = New System.Drawing.Size(250, 25)
        Me.cbitm2.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbitm2.TabIndex = 1
        Me.cbitm2.UseSelectable = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(14, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 19)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "Razón:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(96, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 19)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "Línea: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(14, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 19)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Origen:"
        '
        'txtcant2
        '
        '
        '
        '
        Me.txtcant2.CustomButton.Image = Nothing
        Me.txtcant2.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtcant2.CustomButton.Name = ""
        Me.txtcant2.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcant2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcant2.CustomButton.TabIndex = 1
        Me.txtcant2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcant2.CustomButton.UseSelectable = True
        Me.txtcant2.CustomButton.Visible = False
        Me.txtcant2.Lines = New String(-1) {}
        Me.txtcant2.Location = New System.Drawing.Point(84, 109)
        Me.txtcant2.MaxLength = 32767
        Me.txtcant2.Name = "txtcant2"
        Me.txtcant2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcant2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcant2.SelectedText = ""
        Me.txtcant2.SelectionLength = 0
        Me.txtcant2.SelectionStart = 0
        Me.txtcant2.ShortcutsEnabled = True
        Me.txtcant2.Size = New System.Drawing.Size(69, 20)
        Me.txtcant2.TabIndex = 2
        Me.txtcant2.UseSelectable = True
        Me.txtcant2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcant2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbgrupo2
        '
        Me.cbgrupo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbgrupo2.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbgrupo2.FormattingEnabled = True
        Me.cbgrupo2.ItemHeight = 19
        Me.cbgrupo2.Location = New System.Drawing.Point(84, 48)
        Me.cbgrupo2.Name = "cbgrupo2"
        Me.cbgrupo2.Size = New System.Drawing.Size(250, 25)
        Me.cbgrupo2.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbgrupo2.TabIndex = 0
        Me.cbgrupo2.UseSelectable = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(14, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 19)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "Cantidad"
        '
        'btnguardarLI
        '
        Me.btnguardarLI.BackgroundImage = Global.SPIF.My.Resources.Resources.Arrow_Down
        Me.btnguardarLI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnguardarLI.Location = New System.Drawing.Point(162, 150)
        Me.btnguardarLI.Name = "btnguardarLI"
        Me.btnguardarLI.Size = New System.Drawing.Size(46, 37)
        Me.btnguardarLI.TabIndex = 3
        Me.btnguardarLI.UseSelectable = True
        '
        'txtcant1
        '
        '
        '
        '
        Me.txtcant1.CustomButton.Image = Nothing
        Me.txtcant1.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtcant1.CustomButton.Name = ""
        Me.txtcant1.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcant1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcant1.CustomButton.TabIndex = 1
        Me.txtcant1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcant1.CustomButton.UseSelectable = True
        Me.txtcant1.CustomButton.Visible = False
        Me.txtcant1.Lines = New String(-1) {}
        Me.txtcant1.Location = New System.Drawing.Point(97, 107)
        Me.txtcant1.MaxLength = 32767
        Me.txtcant1.Name = "txtcant1"
        Me.txtcant1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcant1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcant1.SelectedText = ""
        Me.txtcant1.SelectionLength = 0
        Me.txtcant1.SelectionStart = 0
        Me.txtcant1.ShortcutsEnabled = True
        Me.txtcant1.Size = New System.Drawing.Size(69, 20)
        Me.txtcant1.TabIndex = 2
        Me.txtcant1.UseSelectable = True
        Me.txtcant1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcant1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(19, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Razón:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(18, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(19, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 19)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Origen:"
        '
        'cbitm1
        '
        Me.cbitm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbitm1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbitm1.FormattingEnabled = True
        Me.cbitm1.ItemHeight = 19
        Me.cbitm1.Location = New System.Drawing.Point(98, 73)
        Me.cbitm1.Name = "cbitm1"
        Me.cbitm1.Size = New System.Drawing.Size(244, 25)
        Me.cbitm1.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbitm1.TabIndex = 1
        Me.cbitm1.UseSelectable = True
        '
        'cbgrupo1
        '
        Me.cbgrupo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbgrupo1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbgrupo1.FormattingEnabled = True
        Me.cbgrupo1.ItemHeight = 19
        Me.cbgrupo1.Location = New System.Drawing.Point(98, 46)
        Me.cbgrupo1.Name = "cbgrupo1"
        Me.cbgrupo1.Size = New System.Drawing.Size(244, 25)
        Me.cbgrupo1.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbgrupo1.TabIndex = 0
        Me.cbgrupo1.UseSelectable = True
        '
        'CZRegistroDescartes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 545)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "CZRegistroDescartes"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Brown
        Me.Text = "Registro descartes"
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgLineaI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgLineaII, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents TabPage1 As MetroTabPage
    Friend WithEvents TabControl1 As MetroTabControl
    Friend WithEvents lblL1 As MetroLabel
    Friend WithEvents TabPage2 As MetroTabPage
    Friend WithEvents Label15 As MetroLabel
    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtcant1 As MetroTextBox
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents cbgrupo1 As MetroComboBox
    Friend WithEvents cbitm1 As MetroComboBox
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents btnguardarLI As MetroButton
    Friend WithEvents btnGuargarLII As MetroButton
    Friend WithEvents lblL2 As MetroLabel
    Friend WithEvents cbitm2 As MetroComboBox
    Friend WithEvents Label14 As MetroLabel
    Friend WithEvents Label13 As MetroLabel
    Friend WithEvents Label12 As MetroLabel
    Friend WithEvents txtcant2 As MetroTextBox
    Friend WithEvents cbgrupo2 As MetroComboBox
    Friend WithEvents Label10 As MetroLabel
    Friend WithEvents dgLineaI As MetroGrid
    Friend WithEvents dgLineaII As MetroGrid
End Class
