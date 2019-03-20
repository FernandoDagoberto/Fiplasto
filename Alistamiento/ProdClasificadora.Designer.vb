Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProdClasificadora
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
    Public Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.cbTurno = New MetroFramework.Controls.MetroComboBox()
        Me.cbGrupo = New MetroFramework.Controls.MetroComboBox()
        Me.Panel1 = New MetroFramework.Controls.MetroPanel()
        Me.Label17 = New MetroFramework.Controls.MetroLabel()
        Me.cbLinea = New MetroFramework.Controls.MetroComboBox()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.cbProd1 = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAClasificar = New MetroFramework.Controls.MetroTextBox()
        Me.txtDisponible = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tblClasif = New System.Windows.Forms.TableLayoutPanel()
        Me.txtResto = New MetroFramework.Controls.MetroTextBox()
        Me.Label16 = New MetroFramework.Controls.MetroLabel()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.Label13 = New MetroFramework.Controls.MetroLabel()
        Me.Label14 = New MetroFramework.Controls.MetroLabel()
        Me.Label15 = New MetroFramework.Controls.MetroLabel()
        Me.txtpri1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtpp1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtrec1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtEstand1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtSeg1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtInd1 = New MetroFramework.Controls.MetroTextBox()
        Me.cmdGuardar = New MetroFramework.Controls.MetroButton()
        Me.Label18 = New MetroFramework.Controls.MetroLabel()
        Me.dtBuscar = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.dgGrilla = New MetroFramework.Controls.MetroGrid()
        Me.AliProduccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSAlistamiento = New SPIF.DSAlistamiento()
        Me.AliProduccionTableAdapter = New SPIF.DSAlistamientoTableAdapters.AliProduccionTableAdapter()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaquinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlacasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prod1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cc1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pri1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pp1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rec1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seg1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ind1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aclasif1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tblClasif.SuspendLayout()
        CType(Me.dgGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AliProduccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAlistamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtfecha
        '
        Me.dtfecha.CustomFormat = ""
        Me.dtfecha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(59, 13)
        Me.dtfecha.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(100, 23)
        Me.dtfecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Turno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Grupo"
        '
        'cbTurno
        '
        Me.cbTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTurno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbTurno.FormattingEnabled = True
        Me.cbTurno.ItemHeight = 19
        Me.cbTurno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbTurno.Location = New System.Drawing.Point(220, 11)
        Me.cbTurno.Name = "cbTurno"
        Me.cbTurno.Size = New System.Drawing.Size(49, 25)
        Me.cbTurno.TabIndex = 2
        Me.cbTurno.UseSelectable = True
        '
        'cbGrupo
        '
        Me.cbGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGrupo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbGrupo.FormattingEnabled = True
        Me.cbGrupo.ItemHeight = 19
        Me.cbGrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbGrupo.Location = New System.Drawing.Point(220, 43)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(49, 25)
        Me.cbGrupo.TabIndex = 3
        Me.cbGrupo.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.cbLinea)
        Me.Panel1.Controls.Add(Me.cbGrupo)
        Me.Panel1.Controls.Add(Me.cbTurno)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtfecha)
        Me.Panel1.HorizontalScrollbarBarColor = True
        Me.Panel1.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel1.HorizontalScrollbarSize = 10
        Me.Panel1.Location = New System.Drawing.Point(382, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 73)
        Me.Panel1.TabIndex = 1
        Me.Panel1.VerticalScrollbarBarColor = True
        Me.Panel1.VerticalScrollbarHighlightOnWheel = False
        Me.Panel1.VerticalScrollbarSize = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(10, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 19)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Línea"
        '
        'cbLinea
        '
        Me.cbLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLinea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbLinea.FormattingEnabled = True
        Me.cbLinea.ItemHeight = 19
        Me.cbLinea.Items.AddRange(New Object() {"1", "2"})
        Me.cbLinea.Location = New System.Drawing.Point(59, 42)
        Me.cbLinea.Name = "cbLinea"
        Me.cbLinea.Size = New System.Drawing.Size(44, 25)
        Me.cbLinea.TabIndex = 1
        Me.cbLinea.UseSelectable = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Producto"
        '
        'cbProd1
        '
        Me.cbProd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProd1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbProd1.FormattingEnabled = True
        Me.cbProd1.ItemHeight = 19
        Me.cbProd1.Location = New System.Drawing.Point(6, 38)
        Me.cbProd1.Name = "cbProd1"
        Me.cbProd1.Size = New System.Drawing.Size(247, 25)
        Me.cbProd1.TabIndex = 0
        Me.cbProd1.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAClasificar)
        Me.GroupBox1.Controls.Add(Me.txtDisponible)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbProd1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(90, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Material a Clasificar"
        '
        'txtAClasificar
        '
        '
        '
        '
        Me.txtAClasificar.CustomButton.Image = Nothing
        Me.txtAClasificar.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtAClasificar.CustomButton.Name = ""
        Me.txtAClasificar.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtAClasificar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAClasificar.CustomButton.TabIndex = 1
        Me.txtAClasificar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAClasificar.CustomButton.UseSelectable = True
        Me.txtAClasificar.CustomButton.Visible = False
        Me.txtAClasificar.Lines = New String() {"0"}
        Me.txtAClasificar.Location = New System.Drawing.Point(146, 88)
        Me.txtAClasificar.MaxLength = 32767
        Me.txtAClasificar.Name = "txtAClasificar"
        Me.txtAClasificar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAClasificar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAClasificar.SelectedText = ""
        Me.txtAClasificar.SelectionLength = 0
        Me.txtAClasificar.SelectionStart = 0
        Me.txtAClasificar.ShortcutsEnabled = True
        Me.txtAClasificar.Size = New System.Drawing.Size(75, 20)
        Me.txtAClasificar.TabIndex = 1
        Me.txtAClasificar.Text = "0"
        Me.txtAClasificar.UseSelectable = True
        Me.txtAClasificar.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAClasificar.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDisponible
        '
        '
        '
        '
        Me.txtDisponible.CustomButton.Image = Nothing
        Me.txtDisponible.CustomButton.Location = New System.Drawing.Point(57, 2)
        Me.txtDisponible.CustomButton.Name = ""
        Me.txtDisponible.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtDisponible.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDisponible.CustomButton.TabIndex = 1
        Me.txtDisponible.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDisponible.CustomButton.UseSelectable = True
        Me.txtDisponible.CustomButton.Visible = False
        Me.txtDisponible.Enabled = False
        Me.txtDisponible.Lines = New String(-1) {}
        Me.txtDisponible.Location = New System.Drawing.Point(45, 88)
        Me.txtDisponible.MaxLength = 32767
        Me.txtDisponible.Name = "txtDisponible"
        Me.txtDisponible.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDisponible.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDisponible.SelectedText = ""
        Me.txtDisponible.SelectionLength = 0
        Me.txtDisponible.SelectionStart = 0
        Me.txtDisponible.ShortcutsEnabled = True
        Me.txtDisponible.Size = New System.Drawing.Size(75, 20)
        Me.txtDisponible.TabIndex = 21
        Me.txtDisponible.UseSelectable = True
        Me.txtDisponible.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDisponible.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "A Clasificar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Disponible"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tblClasif)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(90, 187)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(568, 96)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Clasificación en Clasificadora"
        '
        'tblClasif
        '
        Me.tblClasif.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.tblClasif.ColumnCount = 7
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tblClasif.Controls.Add(Me.txtResto, 6, 1)
        Me.tblClasif.Controls.Add(Me.Label16, 6, 0)
        Me.tblClasif.Controls.Add(Me.Label10, 0, 0)
        Me.tblClasif.Controls.Add(Me.Label11, 1, 0)
        Me.tblClasif.Controls.Add(Me.Label12, 2, 0)
        Me.tblClasif.Controls.Add(Me.Label13, 3, 0)
        Me.tblClasif.Controls.Add(Me.Label14, 4, 0)
        Me.tblClasif.Controls.Add(Me.Label15, 5, 0)
        Me.tblClasif.Controls.Add(Me.txtpri1, 0, 1)
        Me.tblClasif.Controls.Add(Me.txtpp1, 1, 1)
        Me.tblClasif.Controls.Add(Me.txtrec1, 2, 1)
        Me.tblClasif.Controls.Add(Me.txtEstand1, 3, 1)
        Me.tblClasif.Controls.Add(Me.txtSeg1, 4, 1)
        Me.tblClasif.Controls.Add(Me.txtInd1, 5, 1)
        Me.tblClasif.Location = New System.Drawing.Point(15, 19)
        Me.tblClasif.Name = "tblClasif"
        Me.tblClasif.RowCount = 2
        Me.tblClasif.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.75!))
        Me.tblClasif.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.25!))
        Me.tblClasif.Size = New System.Drawing.Size(533, 59)
        Me.tblClasif.TabIndex = 0
        '
        'txtResto
        '
        Me.txtResto.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtResto.CustomButton.Image = Nothing
        Me.txtResto.CustomButton.Location = New System.Drawing.Point(41, 2)
        Me.txtResto.CustomButton.Name = ""
        Me.txtResto.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtResto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtResto.CustomButton.TabIndex = 1
        Me.txtResto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtResto.CustomButton.UseSelectable = True
        Me.txtResto.CustomButton.Visible = False
        Me.txtResto.Enabled = False
        Me.txtResto.Lines = New String() {"0"}
        Me.txtResto.Location = New System.Drawing.Point(462, 31)
        Me.txtResto.MaxLength = 32767
        Me.txtResto.Name = "txtResto"
        Me.txtResto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtResto.SelectedText = ""
        Me.txtResto.SelectionLength = 0
        Me.txtResto.SelectionStart = 0
        Me.txtResto.ShortcutsEnabled = True
        Me.txtResto.Size = New System.Drawing.Size(59, 20)
        Me.txtResto.TabIndex = 6
        Me.txtResto.Text = "0"
        Me.txtResto.UseSelectable = True
        Me.txtResto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtResto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(471, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 19)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Resto"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 19)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Primera"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(99, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 19)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "P/P"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(159, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 19)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Recortes"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(234, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 19)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Estándar"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(309, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 19)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Segunda"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(383, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 19)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Industrial"
        '
        'txtpri1
        '
        Me.txtpri1.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtpri1.CustomButton.Image = Nothing
        Me.txtpri1.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtpri1.CustomButton.Name = ""
        Me.txtpri1.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtpri1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpri1.CustomButton.TabIndex = 1
        Me.txtpri1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpri1.CustomButton.UseSelectable = True
        Me.txtpri1.CustomButton.Visible = False
        Me.txtpri1.Lines = New String() {"0"}
        Me.txtpri1.Location = New System.Drawing.Point(11, 31)
        Me.txtpri1.MaxLength = 32767
        Me.txtpri1.Name = "txtpri1"
        Me.txtpri1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpri1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpri1.SelectedText = ""
        Me.txtpri1.SelectionLength = 0
        Me.txtpri1.SelectionStart = 0
        Me.txtpri1.ShortcutsEnabled = True
        Me.txtpri1.Size = New System.Drawing.Size(56, 20)
        Me.txtpri1.TabIndex = 0
        Me.txtpri1.Text = "0"
        Me.txtpri1.UseSelectable = True
        Me.txtpri1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpri1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtpp1
        '
        Me.txtpp1.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtpp1.CustomButton.Image = Nothing
        Me.txtpp1.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtpp1.CustomButton.Name = ""
        Me.txtpp1.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtpp1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpp1.CustomButton.TabIndex = 1
        Me.txtpp1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpp1.CustomButton.UseSelectable = True
        Me.txtpp1.CustomButton.Visible = False
        Me.txtpp1.Lines = New String() {"0"}
        Me.txtpp1.Location = New System.Drawing.Point(86, 31)
        Me.txtpp1.MaxLength = 32767
        Me.txtpp1.Name = "txtpp1"
        Me.txtpp1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpp1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpp1.SelectedText = ""
        Me.txtpp1.SelectionLength = 0
        Me.txtpp1.SelectionStart = 0
        Me.txtpp1.ShortcutsEnabled = True
        Me.txtpp1.Size = New System.Drawing.Size(56, 20)
        Me.txtpp1.TabIndex = 1
        Me.txtpp1.Text = "0"
        Me.txtpp1.UseSelectable = True
        Me.txtpp1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpp1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtrec1
        '
        Me.txtrec1.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtrec1.CustomButton.Image = Nothing
        Me.txtrec1.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtrec1.CustomButton.Name = ""
        Me.txtrec1.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtrec1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtrec1.CustomButton.TabIndex = 1
        Me.txtrec1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtrec1.CustomButton.UseSelectable = True
        Me.txtrec1.CustomButton.Visible = False
        Me.txtrec1.Lines = New String() {"0"}
        Me.txtrec1.Location = New System.Drawing.Point(161, 31)
        Me.txtrec1.MaxLength = 32767
        Me.txtrec1.Name = "txtrec1"
        Me.txtrec1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrec1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtrec1.SelectedText = ""
        Me.txtrec1.SelectionLength = 0
        Me.txtrec1.SelectionStart = 0
        Me.txtrec1.ShortcutsEnabled = True
        Me.txtrec1.Size = New System.Drawing.Size(56, 20)
        Me.txtrec1.TabIndex = 2
        Me.txtrec1.Text = "0"
        Me.txtrec1.UseSelectable = True
        Me.txtrec1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtrec1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEstand1
        '
        Me.txtEstand1.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtEstand1.CustomButton.Image = Nothing
        Me.txtEstand1.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtEstand1.CustomButton.Name = ""
        Me.txtEstand1.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtEstand1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEstand1.CustomButton.TabIndex = 1
        Me.txtEstand1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEstand1.CustomButton.UseSelectable = True
        Me.txtEstand1.CustomButton.Visible = False
        Me.txtEstand1.Lines = New String() {"0"}
        Me.txtEstand1.Location = New System.Drawing.Point(236, 31)
        Me.txtEstand1.MaxLength = 32767
        Me.txtEstand1.Name = "txtEstand1"
        Me.txtEstand1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstand1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEstand1.SelectedText = ""
        Me.txtEstand1.SelectionLength = 0
        Me.txtEstand1.SelectionStart = 0
        Me.txtEstand1.ShortcutsEnabled = True
        Me.txtEstand1.Size = New System.Drawing.Size(56, 20)
        Me.txtEstand1.TabIndex = 3
        Me.txtEstand1.Text = "0"
        Me.txtEstand1.UseSelectable = True
        Me.txtEstand1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEstand1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSeg1
        '
        Me.txtSeg1.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtSeg1.CustomButton.Image = Nothing
        Me.txtSeg1.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtSeg1.CustomButton.Name = ""
        Me.txtSeg1.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtSeg1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSeg1.CustomButton.TabIndex = 1
        Me.txtSeg1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSeg1.CustomButton.UseSelectable = True
        Me.txtSeg1.CustomButton.Visible = False
        Me.txtSeg1.Lines = New String() {"0"}
        Me.txtSeg1.Location = New System.Drawing.Point(311, 31)
        Me.txtSeg1.MaxLength = 32767
        Me.txtSeg1.Name = "txtSeg1"
        Me.txtSeg1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSeg1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSeg1.SelectedText = ""
        Me.txtSeg1.SelectionLength = 0
        Me.txtSeg1.SelectionStart = 0
        Me.txtSeg1.ShortcutsEnabled = True
        Me.txtSeg1.Size = New System.Drawing.Size(56, 20)
        Me.txtSeg1.TabIndex = 4
        Me.txtSeg1.Text = "0"
        Me.txtSeg1.UseSelectable = True
        Me.txtSeg1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSeg1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtInd1
        '
        Me.txtInd1.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtInd1.CustomButton.Image = Nothing
        Me.txtInd1.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtInd1.CustomButton.Name = ""
        Me.txtInd1.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtInd1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtInd1.CustomButton.TabIndex = 1
        Me.txtInd1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtInd1.CustomButton.UseSelectable = True
        Me.txtInd1.CustomButton.Visible = False
        Me.txtInd1.Lines = New String() {"0"}
        Me.txtInd1.Location = New System.Drawing.Point(386, 31)
        Me.txtInd1.MaxLength = 32767
        Me.txtInd1.Name = "txtInd1"
        Me.txtInd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInd1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInd1.SelectedText = ""
        Me.txtInd1.SelectionLength = 0
        Me.txtInd1.SelectionStart = 0
        Me.txtInd1.ShortcutsEnabled = True
        Me.txtInd1.Size = New System.Drawing.Size(56, 20)
        Me.txtInd1.TabIndex = 5
        Me.txtInd1.Text = "0"
        Me.txtInd1.UseSelectable = True
        Me.txtInd1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtInd1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(583, 289)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 3
        Me.cmdGuardar.Text = "&Guardar"
        Me.cmdGuardar.UseSelectable = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 318)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 19)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Buscar:"
        '
        'dtBuscar
        '
        Me.dtBuscar.CustomFormat = ""
        Me.dtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBuscar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBuscar.Location = New System.Drawing.Point(70, 314)
        Me.dtBuscar.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtBuscar.Name = "dtBuscar"
        Me.dtBuscar.Size = New System.Drawing.Size(100, 23)
        Me.dtBuscar.TabIndex = 5
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(480, 289)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseSelectable = True
        '
        'dgGrilla
        '
        Me.dgGrilla.AllowUserToAddRows = False
        Me.dgGrilla.AllowUserToDeleteRows = False
        Me.dgGrilla.AllowUserToResizeRows = False
        Me.dgGrilla.AutoGenerateColumns = False
        Me.dgGrilla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgGrilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgGrilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.FechaDataGridViewTextBoxColumn, Me.MaquinaDataGridViewTextBoxColumn, Me.LineaDataGridViewTextBoxColumn, Me.TurnoDataGridViewTextBoxColumn, Me.GrupoDataGridViewTextBoxColumn, Me.PiesDataGridViewTextBoxColumn, Me.PlacasDataGridViewTextBoxColumn, Me.Prod1DataGridViewTextBoxColumn, Me.Producto1DataGridViewTextBoxColumn, Me.Cc1DataGridViewTextBoxColumn, Me.Pri1DataGridViewTextBoxColumn, Me.Pp1DataGridViewTextBoxColumn, Me.Rec1DataGridViewTextBoxColumn, Me.Seg1DataGridViewTextBoxColumn, Me.Ind1DataGridViewTextBoxColumn, Me.Aclasif1DataGridViewTextBoxColumn})
        Me.dgGrilla.DataSource = Me.AliProduccionBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgGrilla.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgGrilla.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgGrilla.EnableHeadersVisualStyles = False
        Me.dgGrilla.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgGrilla.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgGrilla.Location = New System.Drawing.Point(5, 343)
        Me.dgGrilla.MultiSelect = False
        Me.dgGrilla.Name = "dgGrilla"
        Me.dgGrilla.ReadOnly = True
        Me.dgGrilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgGrilla.RowHeadersVisible = False
        Me.dgGrilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGrilla.Size = New System.Drawing.Size(738, 154)
        Me.dgGrilla.Style = MetroFramework.MetroColorStyle.Silver
        Me.dgGrilla.TabIndex = 27
        Me.dgGrilla.UseCustomBackColor = True
        Me.dgGrilla.UseCustomForeColor = True
        '
        'AliProduccionBindingSource
        '
        Me.AliProduccionBindingSource.DataMember = "AliProduccion"
        Me.AliProduccionBindingSource.DataSource = Me.DSAlistamiento
        '
        'DSAlistamiento
        '
        Me.DSAlistamiento.DataSetName = "DSAlistamiento"
        Me.DSAlistamiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AliProduccionTableAdapter
        '
        Me.AliProduccionTableAdapter.ClearBeforeFill = True
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaquinaDataGridViewTextBoxColumn
        '
        Me.MaquinaDataGridViewTextBoxColumn.DataPropertyName = "maquina"
        Me.MaquinaDataGridViewTextBoxColumn.HeaderText = "Maquina"
        Me.MaquinaDataGridViewTextBoxColumn.Name = "MaquinaDataGridViewTextBoxColumn"
        Me.MaquinaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LineaDataGridViewTextBoxColumn
        '
        Me.LineaDataGridViewTextBoxColumn.DataPropertyName = "linea"
        Me.LineaDataGridViewTextBoxColumn.HeaderText = "Linea"
        Me.LineaDataGridViewTextBoxColumn.Name = "LineaDataGridViewTextBoxColumn"
        Me.LineaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TurnoDataGridViewTextBoxColumn
        '
        Me.TurnoDataGridViewTextBoxColumn.DataPropertyName = "turno"
        Me.TurnoDataGridViewTextBoxColumn.HeaderText = "Turno"
        Me.TurnoDataGridViewTextBoxColumn.Name = "TurnoDataGridViewTextBoxColumn"
        Me.TurnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GrupoDataGridViewTextBoxColumn
        '
        Me.GrupoDataGridViewTextBoxColumn.DataPropertyName = "grupo"
        Me.GrupoDataGridViewTextBoxColumn.HeaderText = "Grupo"
        Me.GrupoDataGridViewTextBoxColumn.Name = "GrupoDataGridViewTextBoxColumn"
        Me.GrupoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PiesDataGridViewTextBoxColumn
        '
        Me.PiesDataGridViewTextBoxColumn.DataPropertyName = "pies"
        Me.PiesDataGridViewTextBoxColumn.HeaderText = "Pies"
        Me.PiesDataGridViewTextBoxColumn.Name = "PiesDataGridViewTextBoxColumn"
        Me.PiesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlacasDataGridViewTextBoxColumn
        '
        Me.PlacasDataGridViewTextBoxColumn.DataPropertyName = "placas"
        Me.PlacasDataGridViewTextBoxColumn.HeaderText = "Placas"
        Me.PlacasDataGridViewTextBoxColumn.Name = "PlacasDataGridViewTextBoxColumn"
        Me.PlacasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Prod1DataGridViewTextBoxColumn
        '
        Me.Prod1DataGridViewTextBoxColumn.DataPropertyName = "prod1"
        Me.Prod1DataGridViewTextBoxColumn.HeaderText = "Cod Producto"
        Me.Prod1DataGridViewTextBoxColumn.Name = "Prod1DataGridViewTextBoxColumn"
        Me.Prod1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Producto1DataGridViewTextBoxColumn
        '
        Me.Producto1DataGridViewTextBoxColumn.DataPropertyName = "Producto 1"
        Me.Producto1DataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.Producto1DataGridViewTextBoxColumn.Name = "Producto1DataGridViewTextBoxColumn"
        Me.Producto1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Cc1DataGridViewTextBoxColumn
        '
        Me.Cc1DataGridViewTextBoxColumn.DataPropertyName = "cc1"
        Me.Cc1DataGridViewTextBoxColumn.HeaderText = "Total"
        Me.Cc1DataGridViewTextBoxColumn.Name = "Cc1DataGridViewTextBoxColumn"
        Me.Cc1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Pri1DataGridViewTextBoxColumn
        '
        Me.Pri1DataGridViewTextBoxColumn.DataPropertyName = "pri1"
        Me.Pri1DataGridViewTextBoxColumn.HeaderText = "Primera"
        Me.Pri1DataGridViewTextBoxColumn.Name = "Pri1DataGridViewTextBoxColumn"
        Me.Pri1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Pp1DataGridViewTextBoxColumn
        '
        Me.Pp1DataGridViewTextBoxColumn.DataPropertyName = "pp1"
        Me.Pp1DataGridViewTextBoxColumn.HeaderText = "P/Plus"
        Me.Pp1DataGridViewTextBoxColumn.Name = "Pp1DataGridViewTextBoxColumn"
        Me.Pp1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Rec1DataGridViewTextBoxColumn
        '
        Me.Rec1DataGridViewTextBoxColumn.DataPropertyName = "rec1"
        Me.Rec1DataGridViewTextBoxColumn.HeaderText = "Recortes"
        Me.Rec1DataGridViewTextBoxColumn.Name = "Rec1DataGridViewTextBoxColumn"
        Me.Rec1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Seg1DataGridViewTextBoxColumn
        '
        Me.Seg1DataGridViewTextBoxColumn.DataPropertyName = "seg1"
        Me.Seg1DataGridViewTextBoxColumn.HeaderText = "Segunda"
        Me.Seg1DataGridViewTextBoxColumn.Name = "Seg1DataGridViewTextBoxColumn"
        Me.Seg1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Ind1DataGridViewTextBoxColumn
        '
        Me.Ind1DataGridViewTextBoxColumn.DataPropertyName = "ind1"
        Me.Ind1DataGridViewTextBoxColumn.HeaderText = "Industrial"
        Me.Ind1DataGridViewTextBoxColumn.Name = "Ind1DataGridViewTextBoxColumn"
        Me.Ind1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Aclasif1DataGridViewTextBoxColumn
        '
        Me.Aclasif1DataGridViewTextBoxColumn.DataPropertyName = "aclasif1"
        Me.Aclasif1DataGridViewTextBoxColumn.HeaderText = "A Clasif"
        Me.Aclasif1DataGridViewTextBoxColumn.Name = "Aclasif1DataGridViewTextBoxColumn"
        Me.Aclasif1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdClasificadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 502)
        Me.Controls.Add(Me.dgGrilla)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dtBuscar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ProdClasificadora"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Style = MetroFramework.MetroColorStyle.Magenta
        Me.Text = "Producción Clasificadora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.tblClasif.ResumeLayout(False)
        Me.tblClasif.PerformLayout()
        CType(Me.dgGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AliProduccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAlistamiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents cbTurno As MetroComboBox
    Friend WithEvents cbGrupo As MetroComboBox
    Friend WithEvents Panel1 As MetroPanel
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents cbProd1 As MetroComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInd1 As MetroTextBox
    Friend WithEvents txtSeg1 As MetroTextBox
    Friend WithEvents txtEstand1 As MetroTextBox
    Friend WithEvents txtrec1 As MetroTextBox
    Friend WithEvents txtpp1 As MetroTextBox
    Friend WithEvents txtpri1 As MetroTextBox
    Friend WithEvents Label15 As MetroLabel
    Friend WithEvents Label14 As MetroLabel
    Friend WithEvents Label13 As MetroLabel
    Friend WithEvents Label12 As MetroLabel
    Friend WithEvents Label11 As MetroLabel
    Friend WithEvents Label10 As MetroLabel
    Friend WithEvents tblClasif As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label16 As MetroLabel
    Friend WithEvents txtResto As MetroTextBox
    Friend WithEvents Label17 As MetroLabel
    Friend WithEvents cbLinea As MetroComboBox
    Friend WithEvents cmdGuardar As MetroButton
    Friend WithEvents Label18 As MetroLabel
    Friend WithEvents dtBuscar As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancelar As MetroButton
    Friend WithEvents txtAClasificar As MetroTextBox
    Friend WithEvents txtDisponible As MetroTextBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents dgGrilla As MetroGrid
    Friend WithEvents AliProduccionBindingSource As BindingSource
    Friend WithEvents DSAlistamiento As DSAlistamiento
    Friend WithEvents AliProduccionTableAdapter As DSAlistamientoTableAdapters.AliProduccionTableAdapter
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaquinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LineaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TurnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrupoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlacasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Prod1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Producto1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cc1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Pri1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Pp1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Rec1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Seg1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ind1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Aclasif1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
