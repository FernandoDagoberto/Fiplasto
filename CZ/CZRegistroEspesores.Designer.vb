Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CZRegistroEspesores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CZRegistroEspesores))
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.cbmatl1 = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.btnguardarLI = New MetroFramework.Controls.MetroButton()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.cbzorra1 = New MetroFramework.Controls.MetroComboBox()
        Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.dgLineaI = New MetroFramework.Controls.MetroGrid()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.dgLineaII = New MetroFramework.Controls.MetroGrid()
        Me.lblL1 = New MetroFramework.Controls.MetroLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnRepL2 = New MetroFramework.Controls.MetroButton()
        Me.btnGuargarLII = New MetroFramework.Controls.MetroButton()
        Me.txtsup21 = New MetroFramework.Controls.MetroTextBox()
        Me.lblps2 = New MetroFramework.Controls.MetroLabel()
        Me.lblL2 = New MetroFramework.Controls.MetroLabel()
        Me.lblpm2 = New MetroFramework.Controls.MetroLabel()
        Me.txtsup22 = New MetroFramework.Controls.MetroTextBox()
        Me.cbmatl2 = New MetroFramework.Controls.MetroComboBox()
        Me.lblpi2 = New MetroFramework.Controls.MetroLabel()
        Me.txtsup23 = New MetroFramework.Controls.MetroTextBox()
        Me.Label14 = New MetroFramework.Controls.MetroLabel()
        Me.txtmed23 = New MetroFramework.Controls.MetroTextBox()
        Me.Label13 = New MetroFramework.Controls.MetroLabel()
        Me.txtmed22 = New MetroFramework.Controls.MetroTextBox()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.txtmed21 = New MetroFramework.Controls.MetroTextBox()
        Me.cbzorra2 = New MetroFramework.Controls.MetroComboBox()
        Me.txtinf22 = New MetroFramework.Controls.MetroTextBox()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.txtinf23 = New MetroFramework.Controls.MetroTextBox()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.txtinf21 = New MetroFramework.Controls.MetroTextBox()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.btnRepL1 = New MetroFramework.Controls.MetroButton()
        Me.lblps1 = New MetroFramework.Controls.MetroLabel()
        Me.lblpm1 = New MetroFramework.Controls.MetroLabel()
        Me.lblpi1 = New MetroFramework.Controls.MetroLabel()
        Me.txtsup11 = New MetroFramework.Controls.MetroTextBox()
        Me.txtsup12 = New MetroFramework.Controls.MetroTextBox()
        Me.txtsup13 = New MetroFramework.Controls.MetroTextBox()
        Me.txtmed13 = New MetroFramework.Controls.MetroTextBox()
        Me.txtmed12 = New MetroFramework.Controls.MetroTextBox()
        Me.txtmed11 = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.txtinf12 = New MetroFramework.Controls.MetroTextBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.txtinf13 = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.txtinf11 = New MetroFramework.Controls.MetroTextBox()
        Me.Label15 = New MetroFramework.Controls.MetroLabel()
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
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
        Me.cbturno.Location = New System.Drawing.Point(345, 22)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(86, 25)
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
        Me.cbgrupo.Location = New System.Drawing.Point(518, 22)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(89, 25)
        Me.cbgrupo.TabIndex = 2
        Me.cbgrupo.UseSelectable = True
        '
        'cbmatl1
        '
        Me.cbmatl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmatl1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmatl1.FormattingEnabled = True
        Me.cbmatl1.ItemHeight = 19
        Me.cbmatl1.Location = New System.Drawing.Point(76, 58)
        Me.cbmatl1.Name = "cbmatl1"
        Me.cbmatl1.Size = New System.Drawing.Size(60, 25)
        Me.cbmatl1.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbmatl1.TabIndex = 0
        Me.cbmatl1.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(148, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Línea: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(293, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(463, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(76, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Material:"
        '
        'btnguardarLI
        '
        Me.btnguardarLI.BackgroundImage = Global.SPIF.My.Resources.Resources.Arrow_Down
        Me.btnguardarLI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnguardarLI.Location = New System.Drawing.Point(160, 236)
        Me.btnguardarLI.Name = "btnguardarLI"
        Me.btnguardarLI.Size = New System.Drawing.Size(46, 37)
        Me.btnguardarLI.Style = MetroFramework.MetroColorStyle.Brown
        Me.btnguardarLI.TabIndex = 11
        Me.btnguardarLI.UseSelectable = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(212, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 19)
        Me.Label8.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Nº Zorra:"
        '
        'cbzorra1
        '
        Me.cbzorra1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbzorra1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbzorra1.FormattingEnabled = True
        Me.cbzorra1.ItemHeight = 19
        Me.cbzorra1.Location = New System.Drawing.Point(199, 58)
        Me.cbzorra1.Name = "cbzorra1"
        Me.cbzorra1.Size = New System.Drawing.Size(90, 25)
        Me.cbzorra1.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbzorra1.TabIndex = 1
        Me.cbzorra1.UseSelectable = True
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
        Me.TabPage1.Size = New System.Drawing.Size(726, 288)
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
        Me.dgLineaI.AllowUserToResizeRows = False
        Me.dgLineaI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgLineaI.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLineaI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgLineaI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgLineaI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineaI.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLineaI.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgLineaI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLineaI.EnableHeadersVisualStyles = False
        Me.dgLineaI.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgLineaI.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLineaI.Location = New System.Drawing.Point(3, 3)
        Me.dgLineaI.MultiSelect = False
        Me.dgLineaI.Name = "dgLineaI"
        Me.dgLineaI.ReadOnly = True
        Me.dgLineaI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineaI.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgLineaI.RowHeadersVisible = False
        Me.dgLineaI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLineaI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLineaI.Size = New System.Drawing.Size(720, 282)
        Me.dgLineaI.Style = MetroFramework.MetroColorStyle.Brown
        Me.dgLineaI.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(20, 390)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 1
        Me.TabControl1.Size = New System.Drawing.Size(734, 330)
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
        Me.TabPage2.Size = New System.Drawing.Size(726, 288)
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
        Me.dgLineaII.AllowUserToResizeRows = False
        Me.dgLineaII.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgLineaII.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLineaII.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgLineaII.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgLineaII.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineaII.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLineaII.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgLineaII.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLineaII.EnableHeadersVisualStyles = False
        Me.dgLineaII.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgLineaII.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLineaII.Location = New System.Drawing.Point(3, 3)
        Me.dgLineaII.MultiSelect = False
        Me.dgLineaII.Name = "dgLineaII"
        Me.dgLineaII.ReadOnly = True
        Me.dgLineaII.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLineaII.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgLineaII.RowHeadersVisible = False
        Me.dgLineaII.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLineaII.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLineaII.Size = New System.Drawing.Size(720, 282)
        Me.dgLineaII.Style = MetroFramework.MetroColorStyle.Brown
        Me.dgLineaII.TabIndex = 1
        '
        'lblL1
        '
        Me.lblL1.AutoSize = True
        Me.lblL1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblL1.Location = New System.Drawing.Point(200, 10)
        Me.lblL1.Name = "lblL1"
        Me.lblL1.Size = New System.Drawing.Size(16, 19)
        Me.lblL1.Style = MetroFramework.MetroColorStyle.Brown
        Me.lblL1.TabIndex = 69
        Me.lblL1.Text = "1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 63)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRepL2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnGuargarLII)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsup21)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblps2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblL2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblpm2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsup22)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbmatl2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblpi2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsup23)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtmed23)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtmed22)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtmed21)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbzorra2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtinf22)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtinf23)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtinf21)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnRepL1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblps1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblpm1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblpi1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtsup11)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbzorra1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtsup12)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnguardarLI)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtsup13)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtmed13)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbmatl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtmed12)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblL1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtmed11)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtinf12)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtinf13)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtinf11)
        Me.SplitContainer1.Size = New System.Drawing.Size(741, 290)
        Me.SplitContainer1.SplitterDistance = 368
        Me.SplitContainer1.TabIndex = 4
        '
        'btnRepL2
        '
        Me.btnRepL2.BackgroundImage = CType(resources.GetObject("btnRepL2.BackgroundImage"), System.Drawing.Image)
        Me.btnRepL2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRepL2.Location = New System.Drawing.Point(11, 246)
        Me.btnRepL2.Name = "btnRepL2"
        Me.btnRepL2.Size = New System.Drawing.Size(46, 37)
        Me.btnRepL2.Style = MetroFramework.MetroColorStyle.Brown
        Me.btnRepL2.TabIndex = 12
        Me.btnRepL2.UseSelectable = True
        '
        'btnGuargarLII
        '
        Me.btnGuargarLII.BackgroundImage = Global.SPIF.My.Resources.Resources.Arrow_Down
        Me.btnGuargarLII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuargarLII.Location = New System.Drawing.Point(140, 236)
        Me.btnGuargarLII.Name = "btnGuargarLII"
        Me.btnGuargarLII.Size = New System.Drawing.Size(46, 37)
        Me.btnGuargarLII.Style = MetroFramework.MetroColorStyle.Brown
        Me.btnGuargarLII.TabIndex = 11
        Me.btnGuargarLII.UseSelectable = True
        '
        'txtsup21
        '
        '
        '
        '
        Me.txtsup21.CustomButton.Image = Nothing
        Me.txtsup21.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtsup21.CustomButton.Name = ""
        Me.txtsup21.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsup21.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsup21.CustomButton.TabIndex = 1
        Me.txtsup21.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsup21.CustomButton.UseSelectable = True
        Me.txtsup21.CustomButton.Visible = False
        Me.txtsup21.Lines = New String(-1) {}
        Me.txtsup21.Location = New System.Drawing.Point(229, 134)
        Me.txtsup21.MaxLength = 32767
        Me.txtsup21.Name = "txtsup21"
        Me.txtsup21.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsup21.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsup21.SelectedText = ""
        Me.txtsup21.SelectionLength = 0
        Me.txtsup21.SelectionStart = 0
        Me.txtsup21.ShortcutsEnabled = True
        Me.txtsup21.Size = New System.Drawing.Size(69, 20)
        Me.txtsup21.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtsup21.TabIndex = 8
        Me.txtsup21.UseSelectable = True
        Me.txtsup21.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsup21.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblps2
        '
        Me.lblps2.AutoSize = True
        Me.lblps2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblps2.Location = New System.Drawing.Point(260, 214)
        Me.lblps2.Name = "lblps2"
        Me.lblps2.Size = New System.Drawing.Size(0, 0)
        Me.lblps2.Style = MetroFramework.MetroColorStyle.Brown
        Me.lblps2.TabIndex = 109
        '
        'lblL2
        '
        Me.lblL2.AutoSize = True
        Me.lblL2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblL2.Location = New System.Drawing.Point(211, 10)
        Me.lblL2.Name = "lblL2"
        Me.lblL2.Size = New System.Drawing.Size(16, 19)
        Me.lblL2.Style = MetroFramework.MetroColorStyle.Brown
        Me.lblL2.TabIndex = 100
        Me.lblL2.Text = "2"
        '
        'lblpm2
        '
        Me.lblpm2.AutoSize = True
        Me.lblpm2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblpm2.Location = New System.Drawing.Point(153, 214)
        Me.lblpm2.Name = "lblpm2"
        Me.lblpm2.Size = New System.Drawing.Size(0, 0)
        Me.lblpm2.Style = MetroFramework.MetroColorStyle.Brown
        Me.lblpm2.TabIndex = 108
        '
        'txtsup22
        '
        '
        '
        '
        Me.txtsup22.CustomButton.Image = Nothing
        Me.txtsup22.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtsup22.CustomButton.Name = ""
        Me.txtsup22.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsup22.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsup22.CustomButton.TabIndex = 1
        Me.txtsup22.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsup22.CustomButton.UseSelectable = True
        Me.txtsup22.CustomButton.Visible = False
        Me.txtsup22.Lines = New String(-1) {}
        Me.txtsup22.Location = New System.Drawing.Point(229, 160)
        Me.txtsup22.MaxLength = 32767
        Me.txtsup22.Name = "txtsup22"
        Me.txtsup22.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsup22.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsup22.SelectedText = ""
        Me.txtsup22.SelectionLength = 0
        Me.txtsup22.SelectionStart = 0
        Me.txtsup22.ShortcutsEnabled = True
        Me.txtsup22.Size = New System.Drawing.Size(69, 20)
        Me.txtsup22.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtsup22.TabIndex = 9
        Me.txtsup22.UseSelectable = True
        Me.txtsup22.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsup22.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbmatl2
        '
        Me.cbmatl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmatl2.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmatl2.FormattingEnabled = True
        Me.cbmatl2.ItemHeight = 19
        Me.cbmatl2.Location = New System.Drawing.Point(68, 58)
        Me.cbmatl2.Name = "cbmatl2"
        Me.cbmatl2.Size = New System.Drawing.Size(60, 25)
        Me.cbmatl2.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbmatl2.TabIndex = 0
        Me.cbmatl2.UseSelectable = True
        '
        'lblpi2
        '
        Me.lblpi2.AutoSize = True
        Me.lblpi2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblpi2.Location = New System.Drawing.Point(59, 214)
        Me.lblpi2.Name = "lblpi2"
        Me.lblpi2.Size = New System.Drawing.Size(0, 0)
        Me.lblpi2.Style = MetroFramework.MetroColorStyle.Brown
        Me.lblpi2.TabIndex = 107
        '
        'txtsup23
        '
        '
        '
        '
        Me.txtsup23.CustomButton.Image = Nothing
        Me.txtsup23.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtsup23.CustomButton.Name = ""
        Me.txtsup23.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsup23.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsup23.CustomButton.TabIndex = 1
        Me.txtsup23.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsup23.CustomButton.UseSelectable = True
        Me.txtsup23.CustomButton.Visible = False
        Me.txtsup23.Lines = New String(-1) {}
        Me.txtsup23.Location = New System.Drawing.Point(229, 186)
        Me.txtsup23.MaxLength = 32767
        Me.txtsup23.Name = "txtsup23"
        Me.txtsup23.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsup23.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsup23.SelectedText = ""
        Me.txtsup23.SelectionLength = 0
        Me.txtsup23.SelectionStart = 0
        Me.txtsup23.ShortcutsEnabled = True
        Me.txtsup23.Size = New System.Drawing.Size(69, 20)
        Me.txtsup23.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtsup23.TabIndex = 10
        Me.txtsup23.UseSelectable = True
        Me.txtsup23.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsup23.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(68, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 19)
        Me.Label14.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "Material:"
        '
        'txtmed23
        '
        '
        '
        '
        Me.txtmed23.CustomButton.Image = Nothing
        Me.txtmed23.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtmed23.CustomButton.Name = ""
        Me.txtmed23.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtmed23.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtmed23.CustomButton.TabIndex = 1
        Me.txtmed23.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtmed23.CustomButton.UseSelectable = True
        Me.txtmed23.CustomButton.Visible = False
        Me.txtmed23.Lines = New String(-1) {}
        Me.txtmed23.Location = New System.Drawing.Point(128, 186)
        Me.txtmed23.MaxLength = 32767
        Me.txtmed23.Name = "txtmed23"
        Me.txtmed23.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmed23.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtmed23.SelectedText = ""
        Me.txtmed23.SelectionLength = 0
        Me.txtmed23.SelectionStart = 0
        Me.txtmed23.ShortcutsEnabled = True
        Me.txtmed23.Size = New System.Drawing.Size(69, 20)
        Me.txtmed23.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtmed23.TabIndex = 7
        Me.txtmed23.UseSelectable = True
        Me.txtmed23.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtmed23.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(165, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 19)
        Me.Label13.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Línea: "
        '
        'txtmed22
        '
        '
        '
        '
        Me.txtmed22.CustomButton.Image = Nothing
        Me.txtmed22.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtmed22.CustomButton.Name = ""
        Me.txtmed22.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtmed22.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtmed22.CustomButton.TabIndex = 1
        Me.txtmed22.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtmed22.CustomButton.UseSelectable = True
        Me.txtmed22.CustomButton.Visible = False
        Me.txtmed22.Lines = New String(-1) {}
        Me.txtmed22.Location = New System.Drawing.Point(128, 159)
        Me.txtmed22.MaxLength = 32767
        Me.txtmed22.Name = "txtmed22"
        Me.txtmed22.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmed22.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtmed22.SelectedText = ""
        Me.txtmed22.SelectionLength = 0
        Me.txtmed22.SelectionStart = 0
        Me.txtmed22.ShortcutsEnabled = True
        Me.txtmed22.Size = New System.Drawing.Size(69, 20)
        Me.txtmed22.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtmed22.TabIndex = 6
        Me.txtmed22.UseSelectable = True
        Me.txtmed22.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtmed22.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(229, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 19)
        Me.Label12.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Nº Zorra:"
        '
        'txtmed21
        '
        '
        '
        '
        Me.txtmed21.CustomButton.Image = Nothing
        Me.txtmed21.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtmed21.CustomButton.Name = ""
        Me.txtmed21.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtmed21.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtmed21.CustomButton.TabIndex = 1
        Me.txtmed21.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtmed21.CustomButton.UseSelectable = True
        Me.txtmed21.CustomButton.Visible = False
        Me.txtmed21.Lines = New String(-1) {}
        Me.txtmed21.Location = New System.Drawing.Point(128, 134)
        Me.txtmed21.MaxLength = 32767
        Me.txtmed21.Name = "txtmed21"
        Me.txtmed21.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmed21.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtmed21.SelectedText = ""
        Me.txtmed21.SelectionLength = 0
        Me.txtmed21.SelectionStart = 0
        Me.txtmed21.ShortcutsEnabled = True
        Me.txtmed21.Size = New System.Drawing.Size(69, 20)
        Me.txtmed21.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtmed21.TabIndex = 5
        Me.txtmed21.UseSelectable = True
        Me.txtmed21.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtmed21.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbzorra2
        '
        Me.cbzorra2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbzorra2.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbzorra2.FormattingEnabled = True
        Me.cbzorra2.ItemHeight = 19
        Me.cbzorra2.Location = New System.Drawing.Point(215, 58)
        Me.cbzorra2.Name = "cbzorra2"
        Me.cbzorra2.Size = New System.Drawing.Size(90, 25)
        Me.cbzorra2.Style = MetroFramework.MetroColorStyle.Brown
        Me.cbzorra2.TabIndex = 1
        Me.cbzorra2.UseSelectable = True
        '
        'txtinf22
        '
        '
        '
        '
        Me.txtinf22.CustomButton.Image = Nothing
        Me.txtinf22.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtinf22.CustomButton.Name = ""
        Me.txtinf22.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtinf22.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtinf22.CustomButton.TabIndex = 1
        Me.txtinf22.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtinf22.CustomButton.UseSelectable = True
        Me.txtinf22.CustomButton.Visible = False
        Me.txtinf22.Lines = New String(-1) {}
        Me.txtinf22.Location = New System.Drawing.Point(35, 159)
        Me.txtinf22.MaxLength = 32767
        Me.txtinf22.Name = "txtinf22"
        Me.txtinf22.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtinf22.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtinf22.SelectedText = ""
        Me.txtinf22.SelectionLength = 0
        Me.txtinf22.SelectionStart = 0
        Me.txtinf22.ShortcutsEnabled = True
        Me.txtinf22.Size = New System.Drawing.Size(69, 20)
        Me.txtinf22.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtinf22.TabIndex = 3
        Me.txtinf22.UseSelectable = True
        Me.txtinf22.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtinf22.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(228, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 19)
        Me.Label9.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Superior"
        '
        'txtinf23
        '
        '
        '
        '
        Me.txtinf23.CustomButton.Image = Nothing
        Me.txtinf23.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtinf23.CustomButton.Name = ""
        Me.txtinf23.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtinf23.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtinf23.CustomButton.TabIndex = 1
        Me.txtinf23.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtinf23.CustomButton.UseSelectable = True
        Me.txtinf23.CustomButton.Visible = False
        Me.txtinf23.Lines = New String(-1) {}
        Me.txtinf23.Location = New System.Drawing.Point(35, 186)
        Me.txtinf23.MaxLength = 32767
        Me.txtinf23.Name = "txtinf23"
        Me.txtinf23.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtinf23.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtinf23.SelectedText = ""
        Me.txtinf23.SelectionLength = 0
        Me.txtinf23.SelectionStart = 0
        Me.txtinf23.ShortcutsEnabled = True
        Me.txtinf23.Size = New System.Drawing.Size(69, 20)
        Me.txtinf23.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtinf23.TabIndex = 4
        Me.txtinf23.UseSelectable = True
        Me.txtinf23.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtinf23.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(41, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 19)
        Me.Label11.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Inferior"
        '
        'txtinf21
        '
        '
        '
        '
        Me.txtinf21.CustomButton.Image = Nothing
        Me.txtinf21.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtinf21.CustomButton.Name = ""
        Me.txtinf21.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtinf21.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtinf21.CustomButton.TabIndex = 1
        Me.txtinf21.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtinf21.CustomButton.UseSelectable = True
        Me.txtinf21.CustomButton.Visible = False
        Me.txtinf21.Lines = New String(-1) {}
        Me.txtinf21.Location = New System.Drawing.Point(35, 134)
        Me.txtinf21.MaxLength = 32767
        Me.txtinf21.Name = "txtinf21"
        Me.txtinf21.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtinf21.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtinf21.SelectedText = ""
        Me.txtinf21.SelectionLength = 0
        Me.txtinf21.SelectionStart = 0
        Me.txtinf21.ShortcutsEnabled = True
        Me.txtinf21.Size = New System.Drawing.Size(69, 20)
        Me.txtinf21.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtinf21.TabIndex = 2
        Me.txtinf21.UseSelectable = True
        Me.txtinf21.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtinf21.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(140, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 19)
        Me.Label10.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Media"
        '
        'btnRepL1
        '
        Me.btnRepL1.BackgroundImage = CType(resources.GetObject("btnRepL1.BackgroundImage"), System.Drawing.Image)
        Me.btnRepL1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRepL1.Location = New System.Drawing.Point(293, 246)
        Me.btnRepL1.Name = "btnRepL1"
        Me.btnRepL1.Size = New System.Drawing.Size(46, 37)
        Me.btnRepL1.Style = MetroFramework.MetroColorStyle.Brown
        Me.btnRepL1.TabIndex = 12
        Me.btnRepL1.UseSelectable = True
        '
        'lblps1
        '
        Me.lblps1.AutoSize = True
        Me.lblps1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblps1.Location = New System.Drawing.Point(280, 215)
        Me.lblps1.Name = "lblps1"
        Me.lblps1.Size = New System.Drawing.Size(0, 0)
        Me.lblps1.Style = MetroFramework.MetroColorStyle.Brown
        Me.lblps1.TabIndex = 106
        '
        'lblpm1
        '
        Me.lblpm1.AutoSize = True
        Me.lblpm1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblpm1.Location = New System.Drawing.Point(183, 215)
        Me.lblpm1.Name = "lblpm1"
        Me.lblpm1.Size = New System.Drawing.Size(0, 0)
        Me.lblpm1.Style = MetroFramework.MetroColorStyle.Brown
        Me.lblpm1.TabIndex = 105
        '
        'lblpi1
        '
        Me.lblpi1.AutoSize = True
        Me.lblpi1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblpi1.Location = New System.Drawing.Point(84, 215)
        Me.lblpi1.Name = "lblpi1"
        Me.lblpi1.Size = New System.Drawing.Size(0, 0)
        Me.lblpi1.Style = MetroFramework.MetroColorStyle.Brown
        Me.lblpi1.TabIndex = 104
        '
        'txtsup11
        '
        '
        '
        '
        Me.txtsup11.CustomButton.Image = Nothing
        Me.txtsup11.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtsup11.CustomButton.Name = ""
        Me.txtsup11.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsup11.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsup11.CustomButton.TabIndex = 1
        Me.txtsup11.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsup11.CustomButton.UseSelectable = True
        Me.txtsup11.CustomButton.Visible = False
        Me.txtsup11.Lines = New String(-1) {}
        Me.txtsup11.Location = New System.Drawing.Point(246, 135)
        Me.txtsup11.MaxLength = 32767
        Me.txtsup11.Name = "txtsup11"
        Me.txtsup11.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsup11.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsup11.SelectedText = ""
        Me.txtsup11.SelectionLength = 0
        Me.txtsup11.SelectionStart = 0
        Me.txtsup11.ShortcutsEnabled = True
        Me.txtsup11.Size = New System.Drawing.Size(69, 20)
        Me.txtsup11.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtsup11.TabIndex = 8
        Me.txtsup11.UseSelectable = True
        Me.txtsup11.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsup11.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtsup12
        '
        '
        '
        '
        Me.txtsup12.CustomButton.Image = Nothing
        Me.txtsup12.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtsup12.CustomButton.Name = ""
        Me.txtsup12.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsup12.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsup12.CustomButton.TabIndex = 1
        Me.txtsup12.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsup12.CustomButton.UseSelectable = True
        Me.txtsup12.CustomButton.Visible = False
        Me.txtsup12.Lines = New String(-1) {}
        Me.txtsup12.Location = New System.Drawing.Point(246, 161)
        Me.txtsup12.MaxLength = 32767
        Me.txtsup12.Name = "txtsup12"
        Me.txtsup12.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsup12.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsup12.SelectedText = ""
        Me.txtsup12.SelectionLength = 0
        Me.txtsup12.SelectionStart = 0
        Me.txtsup12.ShortcutsEnabled = True
        Me.txtsup12.Size = New System.Drawing.Size(69, 20)
        Me.txtsup12.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtsup12.TabIndex = 9
        Me.txtsup12.UseSelectable = True
        Me.txtsup12.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsup12.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtsup13
        '
        '
        '
        '
        Me.txtsup13.CustomButton.Image = Nothing
        Me.txtsup13.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtsup13.CustomButton.Name = ""
        Me.txtsup13.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsup13.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsup13.CustomButton.TabIndex = 1
        Me.txtsup13.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsup13.CustomButton.UseSelectable = True
        Me.txtsup13.CustomButton.Visible = False
        Me.txtsup13.Lines = New String(-1) {}
        Me.txtsup13.Location = New System.Drawing.Point(246, 187)
        Me.txtsup13.MaxLength = 32767
        Me.txtsup13.Name = "txtsup13"
        Me.txtsup13.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsup13.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsup13.SelectedText = ""
        Me.txtsup13.SelectionLength = 0
        Me.txtsup13.SelectionStart = 0
        Me.txtsup13.ShortcutsEnabled = True
        Me.txtsup13.Size = New System.Drawing.Size(69, 20)
        Me.txtsup13.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtsup13.TabIndex = 10
        Me.txtsup13.UseSelectable = True
        Me.txtsup13.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsup13.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtmed13
        '
        '
        '
        '
        Me.txtmed13.CustomButton.Image = Nothing
        Me.txtmed13.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtmed13.CustomButton.Name = ""
        Me.txtmed13.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtmed13.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtmed13.CustomButton.TabIndex = 1
        Me.txtmed13.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtmed13.CustomButton.UseSelectable = True
        Me.txtmed13.CustomButton.Visible = False
        Me.txtmed13.Lines = New String(-1) {}
        Me.txtmed13.Location = New System.Drawing.Point(149, 186)
        Me.txtmed13.MaxLength = 32767
        Me.txtmed13.Name = "txtmed13"
        Me.txtmed13.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmed13.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtmed13.SelectedText = ""
        Me.txtmed13.SelectionLength = 0
        Me.txtmed13.SelectionStart = 0
        Me.txtmed13.ShortcutsEnabled = True
        Me.txtmed13.Size = New System.Drawing.Size(69, 20)
        Me.txtmed13.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtmed13.TabIndex = 7
        Me.txtmed13.UseSelectable = True
        Me.txtmed13.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtmed13.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtmed12
        '
        '
        '
        '
        Me.txtmed12.CustomButton.Image = Nothing
        Me.txtmed12.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtmed12.CustomButton.Name = ""
        Me.txtmed12.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtmed12.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtmed12.CustomButton.TabIndex = 1
        Me.txtmed12.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtmed12.CustomButton.UseSelectable = True
        Me.txtmed12.CustomButton.Visible = False
        Me.txtmed12.Lines = New String(-1) {}
        Me.txtmed12.Location = New System.Drawing.Point(149, 159)
        Me.txtmed12.MaxLength = 32767
        Me.txtmed12.Name = "txtmed12"
        Me.txtmed12.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmed12.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtmed12.SelectedText = ""
        Me.txtmed12.SelectionLength = 0
        Me.txtmed12.SelectionStart = 0
        Me.txtmed12.ShortcutsEnabled = True
        Me.txtmed12.Size = New System.Drawing.Size(69, 20)
        Me.txtmed12.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtmed12.TabIndex = 6
        Me.txtmed12.UseSelectable = True
        Me.txtmed12.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtmed12.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtmed11
        '
        '
        '
        '
        Me.txtmed11.CustomButton.Image = Nothing
        Me.txtmed11.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtmed11.CustomButton.Name = ""
        Me.txtmed11.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtmed11.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtmed11.CustomButton.TabIndex = 1
        Me.txtmed11.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtmed11.CustomButton.UseSelectable = True
        Me.txtmed11.CustomButton.Visible = False
        Me.txtmed11.Lines = New String(-1) {}
        Me.txtmed11.Location = New System.Drawing.Point(149, 134)
        Me.txtmed11.MaxLength = 32767
        Me.txtmed11.Name = "txtmed11"
        Me.txtmed11.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmed11.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtmed11.SelectedText = ""
        Me.txtmed11.SelectionLength = 0
        Me.txtmed11.SelectionStart = 0
        Me.txtmed11.ShortcutsEnabled = True
        Me.txtmed11.Size = New System.Drawing.Size(69, 20)
        Me.txtmed11.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtmed11.TabIndex = 5
        Me.txtmed11.UseSelectable = True
        Me.txtmed11.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtmed11.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(59, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Inferior"
        '
        'txtinf12
        '
        '
        '
        '
        Me.txtinf12.CustomButton.Image = Nothing
        Me.txtinf12.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtinf12.CustomButton.Name = ""
        Me.txtinf12.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtinf12.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtinf12.CustomButton.TabIndex = 1
        Me.txtinf12.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtinf12.CustomButton.UseSelectable = True
        Me.txtinf12.CustomButton.Visible = False
        Me.txtinf12.Lines = New String(-1) {}
        Me.txtinf12.Location = New System.Drawing.Point(50, 159)
        Me.txtinf12.MaxLength = 32767
        Me.txtinf12.Name = "txtinf12"
        Me.txtinf12.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtinf12.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtinf12.SelectedText = ""
        Me.txtinf12.SelectionLength = 0
        Me.txtinf12.SelectionStart = 0
        Me.txtinf12.ShortcutsEnabled = True
        Me.txtinf12.Size = New System.Drawing.Size(69, 20)
        Me.txtinf12.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtinf12.TabIndex = 3
        Me.txtinf12.UseSelectable = True
        Me.txtinf12.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtinf12.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(160, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 19)
        Me.Label6.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Media"
        '
        'txtinf13
        '
        '
        '
        '
        Me.txtinf13.CustomButton.Image = Nothing
        Me.txtinf13.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtinf13.CustomButton.Name = ""
        Me.txtinf13.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtinf13.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtinf13.CustomButton.TabIndex = 1
        Me.txtinf13.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtinf13.CustomButton.UseSelectable = True
        Me.txtinf13.CustomButton.Visible = False
        Me.txtinf13.Lines = New String(-1) {}
        Me.txtinf13.Location = New System.Drawing.Point(50, 186)
        Me.txtinf13.MaxLength = 32767
        Me.txtinf13.Name = "txtinf13"
        Me.txtinf13.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtinf13.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtinf13.SelectedText = ""
        Me.txtinf13.SelectionLength = 0
        Me.txtinf13.SelectionStart = 0
        Me.txtinf13.ShortcutsEnabled = True
        Me.txtinf13.Size = New System.Drawing.Size(69, 20)
        Me.txtinf13.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtinf13.TabIndex = 4
        Me.txtinf13.UseSelectable = True
        Me.txtinf13.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtinf13.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(251, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 19)
        Me.Label7.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Superior"
        '
        'txtinf11
        '
        '
        '
        '
        Me.txtinf11.CustomButton.Image = Nothing
        Me.txtinf11.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtinf11.CustomButton.Name = ""
        Me.txtinf11.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtinf11.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtinf11.CustomButton.TabIndex = 1
        Me.txtinf11.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtinf11.CustomButton.UseSelectable = True
        Me.txtinf11.CustomButton.Visible = False
        Me.txtinf11.Lines = New String(-1) {}
        Me.txtinf11.Location = New System.Drawing.Point(50, 134)
        Me.txtinf11.MaxLength = 32767
        Me.txtinf11.Name = "txtinf11"
        Me.txtinf11.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtinf11.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtinf11.SelectedText = ""
        Me.txtinf11.SelectionLength = 0
        Me.txtinf11.SelectionStart = 0
        Me.txtinf11.ShortcutsEnabled = True
        Me.txtinf11.Size = New System.Drawing.Size(69, 20)
        Me.txtinf11.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtinf11.TabIndex = 2
        Me.txtinf11.UseSelectable = True
        Me.txtinf11.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtinf11.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(318, 366)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 19)
        Me.Label15.Style = MetroFramework.MetroColorStyle.Brown
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "Fecha:"
        '
        'dtfecha
        '
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(370, 359)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(86, 25)
        Me.dtfecha.Style = MetroFramework.MetroColorStyle.Brown
        Me.dtfecha.TabIndex = 5
        '
        'CZRegistroEspesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 740)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbgrupo)
        Me.MaximizeBox = False
        Me.Name = "CZRegistroEspesores"
        Me.Style = MetroFramework.MetroColorStyle.Brown
        Me.Text = "Registro de espesores"
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
    Friend WithEvents cbmatl1 As MetroComboBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents btnguardarLI As MetroButton
    Friend WithEvents TabPage1 As MetroTabPage
    Friend WithEvents TabControl1 As MetroTabControl
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents cbzorra1 As MetroComboBox
    Friend WithEvents lblL1 As MetroLabel
    Friend WithEvents dgLineaI As MetroGrid
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtsup11 As MetroTextBox
    Friend WithEvents txtsup12 As MetroTextBox
    Friend WithEvents txtsup13 As MetroTextBox
    Friend WithEvents txtmed13 As MetroTextBox
    Friend WithEvents txtmed12 As MetroTextBox
    Friend WithEvents txtmed11 As MetroTextBox
    Friend WithEvents txtinf12 As MetroTextBox
    Friend WithEvents txtinf13 As MetroTextBox
    Friend WithEvents txtinf11 As MetroTextBox
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents TabPage2 As MetroTabPage
    Friend WithEvents dgLineaII As MetroGrid
    Friend WithEvents Label15 As MetroLabel
    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents btnGuargarLII As MetroButton
    Friend WithEvents txtsup21 As MetroTextBox
    Friend WithEvents lblL2 As MetroLabel
    Friend WithEvents txtsup22 As MetroTextBox
    Friend WithEvents cbmatl2 As MetroComboBox
    Friend WithEvents txtsup23 As MetroTextBox
    Friend WithEvents Label14 As MetroLabel
    Friend WithEvents txtmed23 As MetroTextBox
    Friend WithEvents Label13 As MetroLabel
    Friend WithEvents txtmed22 As MetroTextBox
    Friend WithEvents Label12 As MetroLabel
    Friend WithEvents txtmed21 As MetroTextBox
    Friend WithEvents cbzorra2 As MetroComboBox
    Friend WithEvents txtinf22 As MetroTextBox
    Friend WithEvents Label9 As MetroLabel
    Friend WithEvents txtinf23 As MetroTextBox
    Friend WithEvents Label11 As MetroLabel
    Friend WithEvents txtinf21 As MetroTextBox
    Friend WithEvents Label10 As MetroLabel
    Friend WithEvents lblps1 As MetroLabel
    Friend WithEvents lblpm1 As MetroLabel
    Friend WithEvents lblpi1 As MetroLabel
    Friend WithEvents lblps2 As MetroLabel
    Friend WithEvents lblpm2 As MetroLabel
    Friend WithEvents lblpi2 As MetroLabel
    Friend WithEvents btnRepL2 As MetroButton
    Friend WithEvents btnRepL1 As MetroButton
End Class
