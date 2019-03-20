Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProdMohog
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
        Me.cbpie = New MetroFramework.Controls.MetroComboBox()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.txtPlacas = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New MetroFramework.Controls.MetroPanel()
        Me.Label17 = New MetroFramework.Controls.MetroLabel()
        Me.cbLinea = New MetroFramework.Controls.MetroComboBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.cbProd2 = New MetroFramework.Controls.MetroComboBox()
        Me.cbProd3 = New MetroFramework.Controls.MetroComboBox()
        Me.cbProd1 = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbMaterial = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tblClasif = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCla3 = New MetroFramework.Controls.MetroTextBox()
        Me.txtCla2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtCla1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtInd3 = New MetroFramework.Controls.MetroTextBox()
        Me.Label16 = New MetroFramework.Controls.MetroLabel()
        Me.txtSeg3 = New MetroFramework.Controls.MetroTextBox()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.txtEstand3 = New MetroFramework.Controls.MetroTextBox()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.txtRec3 = New MetroFramework.Controls.MetroTextBox()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.txtPP3 = New MetroFramework.Controls.MetroTextBox()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.txtPri3 = New MetroFramework.Controls.MetroTextBox()
        Me.Label13 = New MetroFramework.Controls.MetroLabel()
        Me.txtcc3 = New MetroFramework.Controls.MetroTextBox()
        Me.Label14 = New MetroFramework.Controls.MetroLabel()
        Me.txtInd2 = New MetroFramework.Controls.MetroTextBox()
        Me.Label15 = New MetroFramework.Controls.MetroLabel()
        Me.txtSeg2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtcc1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtEstand2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtpri1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtRec2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtpp1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtPP2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtrec1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtPri2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtEstand1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtcc2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtSeg1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtInd1 = New MetroFramework.Controls.MetroTextBox()
        Me.cmdGuardar = New MetroFramework.Controls.MetroButton()
        Me.dgGrilla = New System.Windows.Forms.DataGridView()
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
        Me.Prod2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cc2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pri2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pp2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rec2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seg2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ind2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aclasif2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prod3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cc3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pri3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pp3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rec3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seg3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ind3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aclasif3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AliProduccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSAlistamiento = New SPIF.DSAlistamiento()
        Me.Label18 = New MetroFramework.Controls.MetroLabel()
        Me.dtBuscar = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.AliProduccionTableAdapter = New SPIF.DSAlistamientoTableAdapters.AliProduccionTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbMaterial.SuspendLayout()
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
        Me.dtfecha.Location = New System.Drawing.Point(51, 13)
        Me.dtfecha.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(100, 23)
        Me.dtfecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
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
        Me.cbTurno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbTurno.FormattingEnabled = True
        Me.cbTurno.ItemHeight = 19
        Me.cbTurno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbTurno.Location = New System.Drawing.Point(220, 9)
        Me.cbTurno.Name = "cbTurno"
        Me.cbTurno.Size = New System.Drawing.Size(49, 25)
        Me.cbTurno.TabIndex = 2
        Me.cbTurno.UseSelectable = True
        '
        'cbGrupo
        '
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
        'cbpie
        '
        Me.cbpie.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbpie.FormattingEnabled = True
        Me.cbpie.ItemHeight = 19
        Me.cbpie.Location = New System.Drawing.Point(59, 20)
        Me.cbpie.Name = "cbpie"
        Me.cbpie.Size = New System.Drawing.Size(85, 25)
        Me.cbpie.TabIndex = 3
        Me.cbpie.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Pies"
        '
        'txtPlacas
        '
        '
        '
        '
        Me.txtPlacas.CustomButton.Image = Nothing
        Me.txtPlacas.CustomButton.Location = New System.Drawing.Point(67, 2)
        Me.txtPlacas.CustomButton.Name = ""
        Me.txtPlacas.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtPlacas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPlacas.CustomButton.TabIndex = 1
        Me.txtPlacas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPlacas.CustomButton.UseSelectable = True
        Me.txtPlacas.CustomButton.Visible = False
        Me.txtPlacas.Lines = New String(-1) {}
        Me.txtPlacas.Location = New System.Drawing.Point(59, 53)
        Me.txtPlacas.MaxLength = 32767
        Me.txtPlacas.Name = "txtPlacas"
        Me.txtPlacas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPlacas.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPlacas.SelectedText = ""
        Me.txtPlacas.SelectionLength = 0
        Me.txtPlacas.SelectionStart = 0
        Me.txtPlacas.ShortcutsEnabled = True
        Me.txtPlacas.Size = New System.Drawing.Size(85, 20)
        Me.txtPlacas.TabIndex = 0
        Me.txtPlacas.UseSelectable = True
        Me.txtPlacas.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPlacas.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Placas"
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
        Me.Panel1.Location = New System.Drawing.Point(172, 61)
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
        Me.Label17.Location = New System.Drawing.Point(3, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 19)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Línea"
        '
        'cbLinea
        '
        Me.cbLinea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbLinea.FormattingEnabled = True
        Me.cbLinea.ItemHeight = 19
        Me.cbLinea.Items.AddRange(New Object() {"1", "2"})
        Me.cbLinea.Location = New System.Drawing.Point(51, 43)
        Me.cbLinea.Name = "cbLinea"
        Me.cbLinea.Size = New System.Drawing.Size(44, 25)
        Me.cbLinea.TabIndex = 1
        Me.cbLinea.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Producto 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Producto 3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Producto 1"
        '
        'cbProd2
        '
        Me.cbProd2.DropDownWidth = 300
        Me.cbProd2.Enabled = False
        Me.cbProd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProd2.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbProd2.FormattingEnabled = True
        Me.cbProd2.ItemHeight = 19
        Me.cbProd2.Location = New System.Drawing.Point(13, 96)
        Me.cbProd2.Name = "cbProd2"
        Me.cbProd2.Size = New System.Drawing.Size(186, 25)
        Me.cbProd2.TabIndex = 1
        Me.cbProd2.UseSelectable = True
        '
        'cbProd3
        '
        Me.cbProd3.DropDownWidth = 300
        Me.cbProd3.Enabled = False
        Me.cbProd3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProd3.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbProd3.FormattingEnabled = True
        Me.cbProd3.ItemHeight = 19
        Me.cbProd3.Location = New System.Drawing.Point(13, 143)
        Me.cbProd3.Name = "cbProd3"
        Me.cbProd3.Size = New System.Drawing.Size(186, 25)
        Me.cbProd3.TabIndex = 2
        Me.cbProd3.UseSelectable = True
        '
        'cbProd1
        '
        Me.cbProd1.DropDownWidth = 300
        Me.cbProd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProd1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbProd1.FormattingEnabled = True
        Me.cbProd1.ItemHeight = 19
        Me.cbProd1.Location = New System.Drawing.Point(13, 50)
        Me.cbProd1.Name = "cbProd1"
        Me.cbProd1.Size = New System.Drawing.Size(186, 25)
        Me.cbProd1.TabIndex = 0
        Me.cbProd1.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbProd1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbProd3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbProd2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 189)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Material Cortado"
        '
        'gbMaterial
        '
        Me.gbMaterial.Controls.Add(Me.Label4)
        Me.gbMaterial.Controls.Add(Me.cbpie)
        Me.gbMaterial.Controls.Add(Me.txtPlacas)
        Me.gbMaterial.Controls.Add(Me.Label5)
        Me.gbMaterial.Location = New System.Drawing.Point(12, 57)
        Me.gbMaterial.Name = "gbMaterial"
        Me.gbMaterial.Size = New System.Drawing.Size(150, 77)
        Me.gbMaterial.TabIndex = 0
        Me.gbMaterial.TabStop = False
        Me.gbMaterial.Text = "Material Zorra"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tblClasif)
        Me.GroupBox3.Location = New System.Drawing.Point(235, 153)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(578, 189)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Clasificación Sierra"
        '
        'tblClasif
        '
        Me.tblClasif.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.tblClasif.ColumnCount = 8
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblClasif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblClasif.Controls.Add(Me.txtCla3, 7, 3)
        Me.tblClasif.Controls.Add(Me.txtCla2, 7, 2)
        Me.tblClasif.Controls.Add(Me.txtCla1, 7, 1)
        Me.tblClasif.Controls.Add(Me.txtInd3, 6, 3)
        Me.tblClasif.Controls.Add(Me.Label16, 7, 0)
        Me.tblClasif.Controls.Add(Me.txtSeg3, 5, 3)
        Me.tblClasif.Controls.Add(Me.Label9, 0, 0)
        Me.tblClasif.Controls.Add(Me.txtEstand3, 4, 3)
        Me.tblClasif.Controls.Add(Me.Label10, 1, 0)
        Me.tblClasif.Controls.Add(Me.txtRec3, 3, 3)
        Me.tblClasif.Controls.Add(Me.Label11, 2, 0)
        Me.tblClasif.Controls.Add(Me.txtPP3, 2, 3)
        Me.tblClasif.Controls.Add(Me.Label12, 3, 0)
        Me.tblClasif.Controls.Add(Me.txtPri3, 1, 3)
        Me.tblClasif.Controls.Add(Me.Label13, 4, 0)
        Me.tblClasif.Controls.Add(Me.txtcc3, 0, 3)
        Me.tblClasif.Controls.Add(Me.Label14, 5, 0)
        Me.tblClasif.Controls.Add(Me.txtInd2, 6, 2)
        Me.tblClasif.Controls.Add(Me.Label15, 6, 0)
        Me.tblClasif.Controls.Add(Me.txtSeg2, 5, 2)
        Me.tblClasif.Controls.Add(Me.txtcc1, 0, 1)
        Me.tblClasif.Controls.Add(Me.txtEstand2, 4, 2)
        Me.tblClasif.Controls.Add(Me.txtpri1, 1, 1)
        Me.tblClasif.Controls.Add(Me.txtRec2, 3, 2)
        Me.tblClasif.Controls.Add(Me.txtpp1, 2, 1)
        Me.tblClasif.Controls.Add(Me.txtPP2, 2, 2)
        Me.tblClasif.Controls.Add(Me.txtrec1, 3, 1)
        Me.tblClasif.Controls.Add(Me.txtPri2, 1, 2)
        Me.tblClasif.Controls.Add(Me.txtEstand1, 4, 1)
        Me.tblClasif.Controls.Add(Me.txtcc2, 0, 2)
        Me.tblClasif.Controls.Add(Me.txtSeg1, 5, 1)
        Me.tblClasif.Controls.Add(Me.txtInd1, 6, 1)
        Me.tblClasif.Location = New System.Drawing.Point(15, 19)
        Me.tblClasif.Name = "tblClasif"
        Me.tblClasif.RowCount = 4
        Me.tblClasif.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.tblClasif.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.0!))
        Me.tblClasif.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.0!))
        Me.tblClasif.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.0!))
        Me.tblClasif.Size = New System.Drawing.Size(533, 164)
        Me.tblClasif.TabIndex = 24
        '
        'txtCla3
        '
        Me.txtCla3.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtCla3.CustomButton.Image = Nothing
        Me.txtCla3.CustomButton.Location = New System.Drawing.Point(41, 2)
        Me.txtCla3.CustomButton.Name = ""
        Me.txtCla3.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtCla3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCla3.CustomButton.TabIndex = 1
        Me.txtCla3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCla3.CustomButton.UseSelectable = True
        Me.txtCla3.CustomButton.Visible = False
        Me.txtCla3.Enabled = False
        Me.txtCla3.Lines = New String() {"0"}
        Me.txtCla3.Location = New System.Drawing.Point(468, 129)
        Me.txtCla3.MaxLength = 32767
        Me.txtCla3.Name = "txtCla3"
        Me.txtCla3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCla3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCla3.SelectedText = ""
        Me.txtCla3.SelectionLength = 0
        Me.txtCla3.SelectionStart = 0
        Me.txtCla3.ShortcutsEnabled = True
        Me.txtCla3.Size = New System.Drawing.Size(59, 20)
        Me.txtCla3.TabIndex = 54
        Me.txtCla3.Text = "0"
        Me.txtCla3.UseSelectable = True
        Me.txtCla3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCla3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCla2
        '
        Me.txtCla2.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtCla2.CustomButton.Image = Nothing
        Me.txtCla2.CustomButton.Location = New System.Drawing.Point(41, 2)
        Me.txtCla2.CustomButton.Name = ""
        Me.txtCla2.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtCla2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCla2.CustomButton.TabIndex = 1
        Me.txtCla2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCla2.CustomButton.UseSelectable = True
        Me.txtCla2.CustomButton.Visible = False
        Me.txtCla2.Enabled = False
        Me.txtCla2.Lines = New String() {"0"}
        Me.txtCla2.Location = New System.Drawing.Point(468, 82)
        Me.txtCla2.MaxLength = 32767
        Me.txtCla2.Name = "txtCla2"
        Me.txtCla2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCla2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCla2.SelectedText = ""
        Me.txtCla2.SelectionLength = 0
        Me.txtCla2.SelectionStart = 0
        Me.txtCla2.ShortcutsEnabled = True
        Me.txtCla2.Size = New System.Drawing.Size(59, 20)
        Me.txtCla2.TabIndex = 53
        Me.txtCla2.Text = "0"
        Me.txtCla2.UseSelectable = True
        Me.txtCla2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCla2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCla1
        '
        Me.txtCla1.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtCla1.CustomButton.Image = Nothing
        Me.txtCla1.CustomButton.Location = New System.Drawing.Point(41, 2)
        Me.txtCla1.CustomButton.Name = ""
        Me.txtCla1.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtCla1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCla1.CustomButton.TabIndex = 1
        Me.txtCla1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCla1.CustomButton.UseSelectable = True
        Me.txtCla1.CustomButton.Visible = False
        Me.txtCla1.Enabled = False
        Me.txtCla1.Lines = New String() {"0"}
        Me.txtCla1.Location = New System.Drawing.Point(468, 36)
        Me.txtCla1.MaxLength = 32767
        Me.txtCla1.Name = "txtCla1"
        Me.txtCla1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCla1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCla1.SelectedText = ""
        Me.txtCla1.SelectionLength = 0
        Me.txtCla1.SelectionStart = 0
        Me.txtCla1.ShortcutsEnabled = True
        Me.txtCla1.Size = New System.Drawing.Size(59, 20)
        Me.txtCla1.TabIndex = 52
        Me.txtCla1.Text = "0"
        Me.txtCla1.UseSelectable = True
        Me.txtCla1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCla1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtInd3
        '
        Me.txtInd3.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtInd3.CustomButton.Image = Nothing
        Me.txtInd3.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtInd3.CustomButton.Name = ""
        Me.txtInd3.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtInd3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtInd3.CustomButton.TabIndex = 1
        Me.txtInd3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtInd3.CustomButton.UseSelectable = True
        Me.txtInd3.CustomButton.Visible = False
        Me.txtInd3.Lines = New String() {"0"}
        Me.txtInd3.Location = New System.Drawing.Point(402, 129)
        Me.txtInd3.MaxLength = 32767
        Me.txtInd3.Name = "txtInd3"
        Me.txtInd3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInd3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInd3.SelectedText = ""
        Me.txtInd3.SelectionLength = 0
        Me.txtInd3.SelectionStart = 0
        Me.txtInd3.ShortcutsEnabled = True
        Me.txtInd3.Size = New System.Drawing.Size(56, 20)
        Me.txtInd3.TabIndex = 20
        Me.txtInd3.Text = "0"
        Me.txtInd3.UseSelectable = True
        Me.txtInd3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtInd3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label16.Location = New System.Drawing.Point(474, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 15)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "A Clasif."
        '
        'txtSeg3
        '
        Me.txtSeg3.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtSeg3.CustomButton.Image = Nothing
        Me.txtSeg3.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtSeg3.CustomButton.Name = ""
        Me.txtSeg3.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtSeg3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSeg3.CustomButton.TabIndex = 1
        Me.txtSeg3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSeg3.CustomButton.UseSelectable = True
        Me.txtSeg3.CustomButton.Visible = False
        Me.txtSeg3.Lines = New String() {"0"}
        Me.txtSeg3.Location = New System.Drawing.Point(336, 129)
        Me.txtSeg3.MaxLength = 32767
        Me.txtSeg3.Name = "txtSeg3"
        Me.txtSeg3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSeg3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSeg3.SelectedText = ""
        Me.txtSeg3.SelectionLength = 0
        Me.txtSeg3.SelectionStart = 0
        Me.txtSeg3.ShortcutsEnabled = True
        Me.txtSeg3.Size = New System.Drawing.Size(56, 20)
        Me.txtSeg3.TabIndex = 19
        Me.txtSeg3.Text = "0"
        Me.txtSeg3.UseSelectable = True
        Me.txtSeg3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSeg3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label9.Location = New System.Drawing.Point(6, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 19)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Cant.Cort."
        Me.Label9.WrapToLine = True
        '
        'txtEstand3
        '
        Me.txtEstand3.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtEstand3.CustomButton.Image = Nothing
        Me.txtEstand3.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtEstand3.CustomButton.Name = ""
        Me.txtEstand3.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtEstand3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEstand3.CustomButton.TabIndex = 1
        Me.txtEstand3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEstand3.CustomButton.UseSelectable = True
        Me.txtEstand3.CustomButton.Visible = False
        Me.txtEstand3.Lines = New String() {"0"}
        Me.txtEstand3.Location = New System.Drawing.Point(270, 129)
        Me.txtEstand3.MaxLength = 32767
        Me.txtEstand3.Name = "txtEstand3"
        Me.txtEstand3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstand3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEstand3.SelectedText = ""
        Me.txtEstand3.SelectionLength = 0
        Me.txtEstand3.SelectionStart = 0
        Me.txtEstand3.ShortcutsEnabled = True
        Me.txtEstand3.Size = New System.Drawing.Size(56, 20)
        Me.txtEstand3.TabIndex = 18
        Me.txtEstand3.Text = "0"
        Me.txtEstand3.UseSelectable = True
        Me.txtEstand3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEstand3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label10.Location = New System.Drawing.Point(77, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Primera"
        '
        'txtRec3
        '
        Me.txtRec3.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtRec3.CustomButton.Image = Nothing
        Me.txtRec3.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtRec3.CustomButton.Name = ""
        Me.txtRec3.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtRec3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRec3.CustomButton.TabIndex = 1
        Me.txtRec3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRec3.CustomButton.UseSelectable = True
        Me.txtRec3.CustomButton.Visible = False
        Me.txtRec3.Lines = New String() {"0"}
        Me.txtRec3.Location = New System.Drawing.Point(204, 129)
        Me.txtRec3.MaxLength = 32767
        Me.txtRec3.Name = "txtRec3"
        Me.txtRec3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRec3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRec3.SelectedText = ""
        Me.txtRec3.SelectionLength = 0
        Me.txtRec3.SelectionStart = 0
        Me.txtRec3.ShortcutsEnabled = True
        Me.txtRec3.Size = New System.Drawing.Size(56, 20)
        Me.txtRec3.TabIndex = 17
        Me.txtRec3.Text = "0"
        Me.txtRec3.UseSelectable = True
        Me.txtRec3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRec3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label11.Location = New System.Drawing.Point(154, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 15)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "P/P"
        '
        'txtPP3
        '
        Me.txtPP3.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtPP3.CustomButton.Image = Nothing
        Me.txtPP3.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtPP3.CustomButton.Name = ""
        Me.txtPP3.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtPP3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPP3.CustomButton.TabIndex = 1
        Me.txtPP3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPP3.CustomButton.UseSelectable = True
        Me.txtPP3.CustomButton.Visible = False
        Me.txtPP3.Lines = New String() {"0"}
        Me.txtPP3.Location = New System.Drawing.Point(138, 129)
        Me.txtPP3.MaxLength = 32767
        Me.txtPP3.Name = "txtPP3"
        Me.txtPP3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPP3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPP3.SelectedText = ""
        Me.txtPP3.SelectionLength = 0
        Me.txtPP3.SelectionStart = 0
        Me.txtPP3.ShortcutsEnabled = True
        Me.txtPP3.Size = New System.Drawing.Size(56, 20)
        Me.txtPP3.TabIndex = 16
        Me.txtPP3.Text = "0"
        Me.txtPP3.UseSelectable = True
        Me.txtPP3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPP3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label12.Location = New System.Drawing.Point(207, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 15)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Recortes"
        '
        'txtPri3
        '
        Me.txtPri3.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtPri3.CustomButton.Image = Nothing
        Me.txtPri3.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtPri3.CustomButton.Name = ""
        Me.txtPri3.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtPri3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPri3.CustomButton.TabIndex = 1
        Me.txtPri3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPri3.CustomButton.UseSelectable = True
        Me.txtPri3.CustomButton.Visible = False
        Me.txtPri3.Lines = New String() {"0"}
        Me.txtPri3.Location = New System.Drawing.Point(72, 129)
        Me.txtPri3.MaxLength = 32767
        Me.txtPri3.Name = "txtPri3"
        Me.txtPri3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPri3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPri3.SelectedText = ""
        Me.txtPri3.SelectionLength = 0
        Me.txtPri3.SelectionStart = 0
        Me.txtPri3.ShortcutsEnabled = True
        Me.txtPri3.Size = New System.Drawing.Size(56, 20)
        Me.txtPri3.TabIndex = 15
        Me.txtPri3.Text = "0"
        Me.txtPri3.UseSelectable = True
        Me.txtPri3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPri3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label13.Location = New System.Drawing.Point(273, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 15)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Estándar"
        '
        'txtcc3
        '
        Me.txtcc3.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtcc3.CustomButton.Image = Nothing
        Me.txtcc3.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtcc3.CustomButton.Name = ""
        Me.txtcc3.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcc3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcc3.CustomButton.TabIndex = 1
        Me.txtcc3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcc3.CustomButton.UseSelectable = True
        Me.txtcc3.CustomButton.Visible = False
        Me.txtcc3.Lines = New String() {"0"}
        Me.txtcc3.Location = New System.Drawing.Point(6, 129)
        Me.txtcc3.MaxLength = 32767
        Me.txtcc3.Name = "txtcc3"
        Me.txtcc3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcc3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcc3.SelectedText = ""
        Me.txtcc3.SelectionLength = 0
        Me.txtcc3.SelectionStart = 0
        Me.txtcc3.ShortcutsEnabled = True
        Me.txtcc3.Size = New System.Drawing.Size(56, 20)
        Me.txtcc3.TabIndex = 14
        Me.txtcc3.Text = "0"
        Me.txtcc3.UseSelectable = True
        Me.txtcc3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcc3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label14.Location = New System.Drawing.Point(339, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 15)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Segunda"
        '
        'txtInd2
        '
        Me.txtInd2.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtInd2.CustomButton.Image = Nothing
        Me.txtInd2.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtInd2.CustomButton.Name = ""
        Me.txtInd2.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtInd2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtInd2.CustomButton.TabIndex = 1
        Me.txtInd2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtInd2.CustomButton.UseSelectable = True
        Me.txtInd2.CustomButton.Visible = False
        Me.txtInd2.Lines = New String() {"0"}
        Me.txtInd2.Location = New System.Drawing.Point(402, 82)
        Me.txtInd2.MaxLength = 32767
        Me.txtInd2.Name = "txtInd2"
        Me.txtInd2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInd2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInd2.SelectedText = ""
        Me.txtInd2.SelectionLength = 0
        Me.txtInd2.SelectionStart = 0
        Me.txtInd2.ShortcutsEnabled = True
        Me.txtInd2.Size = New System.Drawing.Size(56, 20)
        Me.txtInd2.TabIndex = 13
        Me.txtInd2.Text = "0"
        Me.txtInd2.UseSelectable = True
        Me.txtInd2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtInd2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label15.Location = New System.Drawing.Point(404, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 15)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Industrial"
        '
        'txtSeg2
        '
        Me.txtSeg2.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtSeg2.CustomButton.Image = Nothing
        Me.txtSeg2.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtSeg2.CustomButton.Name = ""
        Me.txtSeg2.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtSeg2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSeg2.CustomButton.TabIndex = 1
        Me.txtSeg2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSeg2.CustomButton.UseSelectable = True
        Me.txtSeg2.CustomButton.Visible = False
        Me.txtSeg2.Lines = New String() {"0"}
        Me.txtSeg2.Location = New System.Drawing.Point(336, 82)
        Me.txtSeg2.MaxLength = 32767
        Me.txtSeg2.Name = "txtSeg2"
        Me.txtSeg2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSeg2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSeg2.SelectedText = ""
        Me.txtSeg2.SelectionLength = 0
        Me.txtSeg2.SelectionStart = 0
        Me.txtSeg2.ShortcutsEnabled = True
        Me.txtSeg2.Size = New System.Drawing.Size(56, 20)
        Me.txtSeg2.TabIndex = 12
        Me.txtSeg2.Text = "0"
        Me.txtSeg2.UseSelectable = True
        Me.txtSeg2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSeg2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtcc1
        '
        Me.txtcc1.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtcc1.CustomButton.Image = Nothing
        Me.txtcc1.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtcc1.CustomButton.Name = ""
        Me.txtcc1.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcc1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcc1.CustomButton.TabIndex = 1
        Me.txtcc1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcc1.CustomButton.UseSelectable = True
        Me.txtcc1.CustomButton.Visible = False
        Me.txtcc1.Lines = New String() {"0"}
        Me.txtcc1.Location = New System.Drawing.Point(6, 36)
        Me.txtcc1.MaxLength = 32767
        Me.txtcc1.Name = "txtcc1"
        Me.txtcc1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcc1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcc1.SelectedText = ""
        Me.txtcc1.SelectionLength = 0
        Me.txtcc1.SelectionStart = 0
        Me.txtcc1.ShortcutsEnabled = True
        Me.txtcc1.Size = New System.Drawing.Size(56, 20)
        Me.txtcc1.TabIndex = 0
        Me.txtcc1.Text = "0"
        Me.txtcc1.UseSelectable = True
        Me.txtcc1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcc1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEstand2
        '
        Me.txtEstand2.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtEstand2.CustomButton.Image = Nothing
        Me.txtEstand2.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtEstand2.CustomButton.Name = ""
        Me.txtEstand2.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtEstand2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEstand2.CustomButton.TabIndex = 1
        Me.txtEstand2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEstand2.CustomButton.UseSelectable = True
        Me.txtEstand2.CustomButton.Visible = False
        Me.txtEstand2.Lines = New String() {"0"}
        Me.txtEstand2.Location = New System.Drawing.Point(270, 82)
        Me.txtEstand2.MaxLength = 32767
        Me.txtEstand2.Name = "txtEstand2"
        Me.txtEstand2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstand2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEstand2.SelectedText = ""
        Me.txtEstand2.SelectionLength = 0
        Me.txtEstand2.SelectionStart = 0
        Me.txtEstand2.ShortcutsEnabled = True
        Me.txtEstand2.Size = New System.Drawing.Size(56, 20)
        Me.txtEstand2.TabIndex = 11
        Me.txtEstand2.Text = "0"
        Me.txtEstand2.UseSelectable = True
        Me.txtEstand2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEstand2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtpri1.Location = New System.Drawing.Point(72, 36)
        Me.txtpri1.MaxLength = 32767
        Me.txtpri1.Name = "txtpri1"
        Me.txtpri1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpri1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpri1.SelectedText = ""
        Me.txtpri1.SelectionLength = 0
        Me.txtpri1.SelectionStart = 0
        Me.txtpri1.ShortcutsEnabled = True
        Me.txtpri1.Size = New System.Drawing.Size(56, 20)
        Me.txtpri1.TabIndex = 1
        Me.txtpri1.Text = "0"
        Me.txtpri1.UseSelectable = True
        Me.txtpri1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpri1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtRec2
        '
        Me.txtRec2.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtRec2.CustomButton.Image = Nothing
        Me.txtRec2.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtRec2.CustomButton.Name = ""
        Me.txtRec2.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtRec2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRec2.CustomButton.TabIndex = 1
        Me.txtRec2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRec2.CustomButton.UseSelectable = True
        Me.txtRec2.CustomButton.Visible = False
        Me.txtRec2.Lines = New String() {"0"}
        Me.txtRec2.Location = New System.Drawing.Point(204, 82)
        Me.txtRec2.MaxLength = 32767
        Me.txtRec2.Name = "txtRec2"
        Me.txtRec2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRec2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRec2.SelectedText = ""
        Me.txtRec2.SelectionLength = 0
        Me.txtRec2.SelectionStart = 0
        Me.txtRec2.ShortcutsEnabled = True
        Me.txtRec2.Size = New System.Drawing.Size(56, 20)
        Me.txtRec2.TabIndex = 10
        Me.txtRec2.Text = "0"
        Me.txtRec2.UseSelectable = True
        Me.txtRec2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRec2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtpp1.Location = New System.Drawing.Point(138, 36)
        Me.txtpp1.MaxLength = 32767
        Me.txtpp1.Name = "txtpp1"
        Me.txtpp1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpp1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpp1.SelectedText = ""
        Me.txtpp1.SelectionLength = 0
        Me.txtpp1.SelectionStart = 0
        Me.txtpp1.ShortcutsEnabled = True
        Me.txtpp1.Size = New System.Drawing.Size(56, 20)
        Me.txtpp1.TabIndex = 2
        Me.txtpp1.Text = "0"
        Me.txtpp1.UseSelectable = True
        Me.txtpp1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpp1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPP2
        '
        Me.txtPP2.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtPP2.CustomButton.Image = Nothing
        Me.txtPP2.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtPP2.CustomButton.Name = ""
        Me.txtPP2.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtPP2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPP2.CustomButton.TabIndex = 1
        Me.txtPP2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPP2.CustomButton.UseSelectable = True
        Me.txtPP2.CustomButton.Visible = False
        Me.txtPP2.Lines = New String() {"0"}
        Me.txtPP2.Location = New System.Drawing.Point(138, 82)
        Me.txtPP2.MaxLength = 32767
        Me.txtPP2.Name = "txtPP2"
        Me.txtPP2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPP2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPP2.SelectedText = ""
        Me.txtPP2.SelectionLength = 0
        Me.txtPP2.SelectionStart = 0
        Me.txtPP2.ShortcutsEnabled = True
        Me.txtPP2.Size = New System.Drawing.Size(56, 20)
        Me.txtPP2.TabIndex = 9
        Me.txtPP2.Text = "0"
        Me.txtPP2.UseSelectable = True
        Me.txtPP2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPP2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtrec1.Location = New System.Drawing.Point(204, 36)
        Me.txtrec1.MaxLength = 32767
        Me.txtrec1.Name = "txtrec1"
        Me.txtrec1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrec1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtrec1.SelectedText = ""
        Me.txtrec1.SelectionLength = 0
        Me.txtrec1.SelectionStart = 0
        Me.txtrec1.ShortcutsEnabled = True
        Me.txtrec1.Size = New System.Drawing.Size(56, 20)
        Me.txtrec1.TabIndex = 3
        Me.txtrec1.Text = "0"
        Me.txtrec1.UseSelectable = True
        Me.txtrec1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtrec1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPri2
        '
        Me.txtPri2.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtPri2.CustomButton.Image = Nothing
        Me.txtPri2.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtPri2.CustomButton.Name = ""
        Me.txtPri2.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtPri2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPri2.CustomButton.TabIndex = 1
        Me.txtPri2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPri2.CustomButton.UseSelectable = True
        Me.txtPri2.CustomButton.Visible = False
        Me.txtPri2.Lines = New String() {"0"}
        Me.txtPri2.Location = New System.Drawing.Point(72, 82)
        Me.txtPri2.MaxLength = 32767
        Me.txtPri2.Name = "txtPri2"
        Me.txtPri2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPri2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPri2.SelectedText = ""
        Me.txtPri2.SelectionLength = 0
        Me.txtPri2.SelectionStart = 0
        Me.txtPri2.ShortcutsEnabled = True
        Me.txtPri2.Size = New System.Drawing.Size(56, 20)
        Me.txtPri2.TabIndex = 8
        Me.txtPri2.Text = "0"
        Me.txtPri2.UseSelectable = True
        Me.txtPri2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPri2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtEstand1.Location = New System.Drawing.Point(270, 36)
        Me.txtEstand1.MaxLength = 32767
        Me.txtEstand1.Name = "txtEstand1"
        Me.txtEstand1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstand1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEstand1.SelectedText = ""
        Me.txtEstand1.SelectionLength = 0
        Me.txtEstand1.SelectionStart = 0
        Me.txtEstand1.ShortcutsEnabled = True
        Me.txtEstand1.Size = New System.Drawing.Size(56, 20)
        Me.txtEstand1.TabIndex = 4
        Me.txtEstand1.Text = "0"
        Me.txtEstand1.UseSelectable = True
        Me.txtEstand1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEstand1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtcc2
        '
        Me.txtcc2.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtcc2.CustomButton.Image = Nothing
        Me.txtcc2.CustomButton.Location = New System.Drawing.Point(38, 2)
        Me.txtcc2.CustomButton.Name = ""
        Me.txtcc2.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcc2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcc2.CustomButton.TabIndex = 1
        Me.txtcc2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcc2.CustomButton.UseSelectable = True
        Me.txtcc2.CustomButton.Visible = False
        Me.txtcc2.Lines = New String() {"0"}
        Me.txtcc2.Location = New System.Drawing.Point(6, 82)
        Me.txtcc2.MaxLength = 32767
        Me.txtcc2.Name = "txtcc2"
        Me.txtcc2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcc2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcc2.SelectedText = ""
        Me.txtcc2.SelectionLength = 0
        Me.txtcc2.SelectionStart = 0
        Me.txtcc2.ShortcutsEnabled = True
        Me.txtcc2.Size = New System.Drawing.Size(56, 20)
        Me.txtcc2.TabIndex = 7
        Me.txtcc2.Text = "0"
        Me.txtcc2.UseSelectable = True
        Me.txtcc2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcc2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtSeg1.Location = New System.Drawing.Point(336, 36)
        Me.txtSeg1.MaxLength = 32767
        Me.txtSeg1.Name = "txtSeg1"
        Me.txtSeg1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSeg1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSeg1.SelectedText = ""
        Me.txtSeg1.SelectionLength = 0
        Me.txtSeg1.SelectionStart = 0
        Me.txtSeg1.ShortcutsEnabled = True
        Me.txtSeg1.Size = New System.Drawing.Size(56, 20)
        Me.txtSeg1.TabIndex = 5
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
        Me.txtInd1.Location = New System.Drawing.Point(402, 36)
        Me.txtInd1.MaxLength = 32767
        Me.txtInd1.Name = "txtInd1"
        Me.txtInd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInd1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInd1.SelectedText = ""
        Me.txtInd1.SelectionLength = 0
        Me.txtInd1.SelectionStart = 0
        Me.txtInd1.ShortcutsEnabled = True
        Me.txtInd1.Size = New System.Drawing.Size(56, 20)
        Me.txtInd1.TabIndex = 6
        Me.txtInd1.Text = "0"
        Me.txtInd1.UseSelectable = True
        Me.txtInd1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtInd1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(652, 348)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 2
        Me.cmdGuardar.Text = "&Guardar"
        Me.cmdGuardar.UseSelectable = True
        '
        'dgGrilla
        '
        Me.dgGrilla.AllowUserToAddRows = False
        Me.dgGrilla.AllowUserToDeleteRows = False
        Me.dgGrilla.AutoGenerateColumns = False
        Me.dgGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.FechaDataGridViewTextBoxColumn, Me.MaquinaDataGridViewTextBoxColumn, Me.LineaDataGridViewTextBoxColumn, Me.TurnoDataGridViewTextBoxColumn, Me.GrupoDataGridViewTextBoxColumn, Me.PiesDataGridViewTextBoxColumn, Me.PlacasDataGridViewTextBoxColumn, Me.Prod1DataGridViewTextBoxColumn, Me.Producto1DataGridViewTextBoxColumn, Me.Cc1DataGridViewTextBoxColumn, Me.Pri1DataGridViewTextBoxColumn, Me.Pp1DataGridViewTextBoxColumn, Me.Rec1DataGridViewTextBoxColumn, Me.Seg1DataGridViewTextBoxColumn, Me.Ind1DataGridViewTextBoxColumn, Me.Aclasif1DataGridViewTextBoxColumn, Me.Prod2DataGridViewTextBoxColumn, Me.Producto2DataGridViewTextBoxColumn, Me.Cc2DataGridViewTextBoxColumn, Me.Pri2DataGridViewTextBoxColumn, Me.Pp2DataGridViewTextBoxColumn, Me.Rec2DataGridViewTextBoxColumn, Me.Seg2DataGridViewTextBoxColumn, Me.Ind2DataGridViewTextBoxColumn, Me.Aclasif2DataGridViewTextBoxColumn, Me.Prod3DataGridViewTextBoxColumn, Me.Producto3DataGridViewTextBoxColumn, Me.Cc3DataGridViewTextBoxColumn, Me.Pri3DataGridViewTextBoxColumn, Me.Pp3DataGridViewTextBoxColumn, Me.Rec3DataGridViewTextBoxColumn, Me.Seg3DataGridViewTextBoxColumn, Me.Ind3DataGridViewTextBoxColumn, Me.Aclasif3DataGridViewTextBoxColumn})
        Me.dgGrilla.DataSource = Me.AliProduccionBindingSource
        Me.dgGrilla.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgGrilla.Location = New System.Drawing.Point(5, 412)
        Me.dgGrilla.Name = "dgGrilla"
        Me.dgGrilla.ReadOnly = True
        Me.dgGrilla.RowHeadersVisible = False
        Me.dgGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGrilla.Size = New System.Drawing.Size(815, 198)
        Me.dgGrilla.TabIndex = 19
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        Me.codigo.Width = 45
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 59
        '
        'MaquinaDataGridViewTextBoxColumn
        '
        Me.MaquinaDataGridViewTextBoxColumn.DataPropertyName = "maquina"
        Me.MaquinaDataGridViewTextBoxColumn.HeaderText = "maquina"
        Me.MaquinaDataGridViewTextBoxColumn.Name = "MaquinaDataGridViewTextBoxColumn"
        Me.MaquinaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaquinaDataGridViewTextBoxColumn.Width = 72
        '
        'LineaDataGridViewTextBoxColumn
        '
        Me.LineaDataGridViewTextBoxColumn.DataPropertyName = "linea"
        Me.LineaDataGridViewTextBoxColumn.HeaderText = "linea"
        Me.LineaDataGridViewTextBoxColumn.Name = "LineaDataGridViewTextBoxColumn"
        Me.LineaDataGridViewTextBoxColumn.ReadOnly = True
        Me.LineaDataGridViewTextBoxColumn.Width = 54
        '
        'TurnoDataGridViewTextBoxColumn
        '
        Me.TurnoDataGridViewTextBoxColumn.DataPropertyName = "turno"
        Me.TurnoDataGridViewTextBoxColumn.HeaderText = "turno"
        Me.TurnoDataGridViewTextBoxColumn.Name = "TurnoDataGridViewTextBoxColumn"
        Me.TurnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TurnoDataGridViewTextBoxColumn.Width = 56
        '
        'GrupoDataGridViewTextBoxColumn
        '
        Me.GrupoDataGridViewTextBoxColumn.DataPropertyName = "grupo"
        Me.GrupoDataGridViewTextBoxColumn.HeaderText = "grupo"
        Me.GrupoDataGridViewTextBoxColumn.Name = "GrupoDataGridViewTextBoxColumn"
        Me.GrupoDataGridViewTextBoxColumn.ReadOnly = True
        Me.GrupoDataGridViewTextBoxColumn.Width = 59
        '
        'PiesDataGridViewTextBoxColumn
        '
        Me.PiesDataGridViewTextBoxColumn.DataPropertyName = "pies"
        Me.PiesDataGridViewTextBoxColumn.HeaderText = "pies"
        Me.PiesDataGridViewTextBoxColumn.Name = "PiesDataGridViewTextBoxColumn"
        Me.PiesDataGridViewTextBoxColumn.ReadOnly = True
        Me.PiesDataGridViewTextBoxColumn.Width = 51
        '
        'PlacasDataGridViewTextBoxColumn
        '
        Me.PlacasDataGridViewTextBoxColumn.DataPropertyName = "placas"
        Me.PlacasDataGridViewTextBoxColumn.HeaderText = "placas"
        Me.PlacasDataGridViewTextBoxColumn.Name = "PlacasDataGridViewTextBoxColumn"
        Me.PlacasDataGridViewTextBoxColumn.ReadOnly = True
        Me.PlacasDataGridViewTextBoxColumn.Width = 63
        '
        'Prod1DataGridViewTextBoxColumn
        '
        Me.Prod1DataGridViewTextBoxColumn.DataPropertyName = "prod1"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.Prod1DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.Prod1DataGridViewTextBoxColumn.HeaderText = "Codigo 1"
        Me.Prod1DataGridViewTextBoxColumn.Name = "Prod1DataGridViewTextBoxColumn"
        Me.Prod1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Prod1DataGridViewTextBoxColumn.Width = 74
        '
        'Producto1DataGridViewTextBoxColumn
        '
        Me.Producto1DataGridViewTextBoxColumn.DataPropertyName = "Producto 1"
        Me.Producto1DataGridViewTextBoxColumn.HeaderText = "Producto 1"
        Me.Producto1DataGridViewTextBoxColumn.Name = "Producto1DataGridViewTextBoxColumn"
        Me.Producto1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Producto1DataGridViewTextBoxColumn.Width = 84
        '
        'Cc1DataGridViewTextBoxColumn
        '
        Me.Cc1DataGridViewTextBoxColumn.DataPropertyName = "cc1"
        Me.Cc1DataGridViewTextBoxColumn.HeaderText = "Cant. Cort"
        Me.Cc1DataGridViewTextBoxColumn.Name = "Cc1DataGridViewTextBoxColumn"
        Me.Cc1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Cc1DataGridViewTextBoxColumn.Width = 79
        '
        'Pri1DataGridViewTextBoxColumn
        '
        Me.Pri1DataGridViewTextBoxColumn.DataPropertyName = "pri1"
        Me.Pri1DataGridViewTextBoxColumn.HeaderText = "Primera"
        Me.Pri1DataGridViewTextBoxColumn.Name = "Pri1DataGridViewTextBoxColumn"
        Me.Pri1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Pri1DataGridViewTextBoxColumn.Width = 67
        '
        'Pp1DataGridViewTextBoxColumn
        '
        Me.Pp1DataGridViewTextBoxColumn.DataPropertyName = "pp1"
        Me.Pp1DataGridViewTextBoxColumn.HeaderText = "P/Plus"
        Me.Pp1DataGridViewTextBoxColumn.Name = "Pp1DataGridViewTextBoxColumn"
        Me.Pp1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Pp1DataGridViewTextBoxColumn.Width = 64
        '
        'Rec1DataGridViewTextBoxColumn
        '
        Me.Rec1DataGridViewTextBoxColumn.DataPropertyName = "rec1"
        Me.Rec1DataGridViewTextBoxColumn.HeaderText = "Recortes"
        Me.Rec1DataGridViewTextBoxColumn.Name = "Rec1DataGridViewTextBoxColumn"
        Me.Rec1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Rec1DataGridViewTextBoxColumn.Width = 75
        '
        'Seg1DataGridViewTextBoxColumn
        '
        Me.Seg1DataGridViewTextBoxColumn.DataPropertyName = "seg1"
        Me.Seg1DataGridViewTextBoxColumn.HeaderText = "Segunda"
        Me.Seg1DataGridViewTextBoxColumn.Name = "Seg1DataGridViewTextBoxColumn"
        Me.Seg1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Seg1DataGridViewTextBoxColumn.Width = 75
        '
        'Ind1DataGridViewTextBoxColumn
        '
        Me.Ind1DataGridViewTextBoxColumn.DataPropertyName = "ind1"
        Me.Ind1DataGridViewTextBoxColumn.HeaderText = "Industrial"
        Me.Ind1DataGridViewTextBoxColumn.Name = "Ind1DataGridViewTextBoxColumn"
        Me.Ind1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Ind1DataGridViewTextBoxColumn.Width = 74
        '
        'Aclasif1DataGridViewTextBoxColumn
        '
        Me.Aclasif1DataGridViewTextBoxColumn.DataPropertyName = "aclasif1"
        Me.Aclasif1DataGridViewTextBoxColumn.HeaderText = "A Clasif"
        Me.Aclasif1DataGridViewTextBoxColumn.Name = "Aclasif1DataGridViewTextBoxColumn"
        Me.Aclasif1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Aclasif1DataGridViewTextBoxColumn.Width = 67
        '
        'Prod2DataGridViewTextBoxColumn
        '
        Me.Prod2DataGridViewTextBoxColumn.DataPropertyName = "prod2"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        Me.Prod2DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.Prod2DataGridViewTextBoxColumn.HeaderText = "Codigo 2"
        Me.Prod2DataGridViewTextBoxColumn.Name = "Prod2DataGridViewTextBoxColumn"
        Me.Prod2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Prod2DataGridViewTextBoxColumn.Width = 74
        '
        'Producto2DataGridViewTextBoxColumn
        '
        Me.Producto2DataGridViewTextBoxColumn.DataPropertyName = "Producto 2"
        Me.Producto2DataGridViewTextBoxColumn.HeaderText = "Producto 2"
        Me.Producto2DataGridViewTextBoxColumn.Name = "Producto2DataGridViewTextBoxColumn"
        Me.Producto2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Producto2DataGridViewTextBoxColumn.Width = 84
        '
        'Cc2DataGridViewTextBoxColumn
        '
        Me.Cc2DataGridViewTextBoxColumn.DataPropertyName = "cc2"
        Me.Cc2DataGridViewTextBoxColumn.HeaderText = "Cant. Cort"
        Me.Cc2DataGridViewTextBoxColumn.Name = "Cc2DataGridViewTextBoxColumn"
        Me.Cc2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Cc2DataGridViewTextBoxColumn.Width = 79
        '
        'Pri2DataGridViewTextBoxColumn
        '
        Me.Pri2DataGridViewTextBoxColumn.DataPropertyName = "pri2"
        Me.Pri2DataGridViewTextBoxColumn.HeaderText = "Primera"
        Me.Pri2DataGridViewTextBoxColumn.Name = "Pri2DataGridViewTextBoxColumn"
        Me.Pri2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Pri2DataGridViewTextBoxColumn.Width = 67
        '
        'Pp2DataGridViewTextBoxColumn
        '
        Me.Pp2DataGridViewTextBoxColumn.DataPropertyName = "pp2"
        Me.Pp2DataGridViewTextBoxColumn.HeaderText = "P/Plus"
        Me.Pp2DataGridViewTextBoxColumn.Name = "Pp2DataGridViewTextBoxColumn"
        Me.Pp2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Pp2DataGridViewTextBoxColumn.Width = 64
        '
        'Rec2DataGridViewTextBoxColumn
        '
        Me.Rec2DataGridViewTextBoxColumn.DataPropertyName = "rec2"
        Me.Rec2DataGridViewTextBoxColumn.HeaderText = "Recortes"
        Me.Rec2DataGridViewTextBoxColumn.Name = "Rec2DataGridViewTextBoxColumn"
        Me.Rec2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Rec2DataGridViewTextBoxColumn.Width = 75
        '
        'Seg2DataGridViewTextBoxColumn
        '
        Me.Seg2DataGridViewTextBoxColumn.DataPropertyName = "seg2"
        Me.Seg2DataGridViewTextBoxColumn.HeaderText = "Segunda"
        Me.Seg2DataGridViewTextBoxColumn.Name = "Seg2DataGridViewTextBoxColumn"
        Me.Seg2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Seg2DataGridViewTextBoxColumn.Width = 75
        '
        'Ind2DataGridViewTextBoxColumn
        '
        Me.Ind2DataGridViewTextBoxColumn.DataPropertyName = "ind2"
        Me.Ind2DataGridViewTextBoxColumn.HeaderText = "Industrial"
        Me.Ind2DataGridViewTextBoxColumn.Name = "Ind2DataGridViewTextBoxColumn"
        Me.Ind2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Ind2DataGridViewTextBoxColumn.Width = 74
        '
        'Aclasif2DataGridViewTextBoxColumn
        '
        Me.Aclasif2DataGridViewTextBoxColumn.DataPropertyName = "aclasif2"
        Me.Aclasif2DataGridViewTextBoxColumn.HeaderText = "A Clasif"
        Me.Aclasif2DataGridViewTextBoxColumn.Name = "Aclasif2DataGridViewTextBoxColumn"
        Me.Aclasif2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Aclasif2DataGridViewTextBoxColumn.Width = 67
        '
        'Prod3DataGridViewTextBoxColumn
        '
        Me.Prod3DataGridViewTextBoxColumn.DataPropertyName = "prod3"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        Me.Prod3DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.Prod3DataGridViewTextBoxColumn.HeaderText = "Codigo 3"
        Me.Prod3DataGridViewTextBoxColumn.Name = "Prod3DataGridViewTextBoxColumn"
        Me.Prod3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Prod3DataGridViewTextBoxColumn.Width = 74
        '
        'Producto3DataGridViewTextBoxColumn
        '
        Me.Producto3DataGridViewTextBoxColumn.DataPropertyName = "Producto 3"
        Me.Producto3DataGridViewTextBoxColumn.HeaderText = "Producto 3"
        Me.Producto3DataGridViewTextBoxColumn.Name = "Producto3DataGridViewTextBoxColumn"
        Me.Producto3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Producto3DataGridViewTextBoxColumn.Width = 84
        '
        'Cc3DataGridViewTextBoxColumn
        '
        Me.Cc3DataGridViewTextBoxColumn.DataPropertyName = "cc3"
        Me.Cc3DataGridViewTextBoxColumn.HeaderText = "Cant. Cort"
        Me.Cc3DataGridViewTextBoxColumn.Name = "Cc3DataGridViewTextBoxColumn"
        Me.Cc3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Cc3DataGridViewTextBoxColumn.Width = 79
        '
        'Pri3DataGridViewTextBoxColumn
        '
        Me.Pri3DataGridViewTextBoxColumn.DataPropertyName = "pri3"
        Me.Pri3DataGridViewTextBoxColumn.HeaderText = "Primera"
        Me.Pri3DataGridViewTextBoxColumn.Name = "Pri3DataGridViewTextBoxColumn"
        Me.Pri3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Pri3DataGridViewTextBoxColumn.Width = 67
        '
        'Pp3DataGridViewTextBoxColumn
        '
        Me.Pp3DataGridViewTextBoxColumn.DataPropertyName = "pp3"
        Me.Pp3DataGridViewTextBoxColumn.HeaderText = "P/Plus"
        Me.Pp3DataGridViewTextBoxColumn.Name = "Pp3DataGridViewTextBoxColumn"
        Me.Pp3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Pp3DataGridViewTextBoxColumn.Width = 64
        '
        'Rec3DataGridViewTextBoxColumn
        '
        Me.Rec3DataGridViewTextBoxColumn.DataPropertyName = "rec3"
        Me.Rec3DataGridViewTextBoxColumn.HeaderText = "Recortes"
        Me.Rec3DataGridViewTextBoxColumn.Name = "Rec3DataGridViewTextBoxColumn"
        Me.Rec3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Rec3DataGridViewTextBoxColumn.Width = 75
        '
        'Seg3DataGridViewTextBoxColumn
        '
        Me.Seg3DataGridViewTextBoxColumn.DataPropertyName = "seg3"
        Me.Seg3DataGridViewTextBoxColumn.HeaderText = "Segunda"
        Me.Seg3DataGridViewTextBoxColumn.Name = "Seg3DataGridViewTextBoxColumn"
        Me.Seg3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Seg3DataGridViewTextBoxColumn.Width = 75
        '
        'Ind3DataGridViewTextBoxColumn
        '
        Me.Ind3DataGridViewTextBoxColumn.DataPropertyName = "ind3"
        Me.Ind3DataGridViewTextBoxColumn.HeaderText = "Industrial"
        Me.Ind3DataGridViewTextBoxColumn.Name = "Ind3DataGridViewTextBoxColumn"
        Me.Ind3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Ind3DataGridViewTextBoxColumn.Width = 74
        '
        'Aclasif3DataGridViewTextBoxColumn
        '
        Me.Aclasif3DataGridViewTextBoxColumn.DataPropertyName = "aclasif3"
        Me.Aclasif3DataGridViewTextBoxColumn.HeaderText = "A Clasif"
        Me.Aclasif3DataGridViewTextBoxColumn.Name = "Aclasif3DataGridViewTextBoxColumn"
        Me.Aclasif3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Aclasif3DataGridViewTextBoxColumn.Width = 67
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
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 387)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 19)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Buscar:"
        '
        'dtBuscar
        '
        Me.dtBuscar.CustomFormat = ""
        Me.dtBuscar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBuscar.Location = New System.Drawing.Point(71, 386)
        Me.dtBuscar.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dtBuscar.Name = "dtBuscar"
        Me.dtBuscar.Size = New System.Drawing.Size(100, 20)
        Me.dtBuscar.TabIndex = 4
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(549, 348)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseSelectable = True
        '
        'AliProduccionTableAdapter
        '
        Me.AliProduccionTableAdapter.ClearBeforeFill = True
        '
        'ProdMohog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 615)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dtBuscar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dgGrilla)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbMaterial)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ProdMohog"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Style = MetroFramework.MetroColorStyle.Magenta
        Me.Text = "Producción Sierra Mohog"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbMaterial.ResumeLayout(False)
        Me.gbMaterial.PerformLayout()
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
    Friend WithEvents cbpie As MetroComboBox
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents txtPlacas As MetroTextBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents Panel1 As MetroPanel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents cbProd2 As MetroComboBox
    Friend WithEvents cbProd3 As MetroComboBox
    Friend WithEvents cbProd1 As MetroComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbMaterial As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInd3 As MetroTextBox
    Friend WithEvents txtSeg3 As MetroTextBox
    Friend WithEvents txtEstand3 As MetroTextBox
    Friend WithEvents txtRec3 As MetroTextBox
    Friend WithEvents txtPP3 As MetroTextBox
    Friend WithEvents txtPri3 As MetroTextBox
    Friend WithEvents txtcc3 As MetroTextBox
    Friend WithEvents txtInd2 As MetroTextBox
    Friend WithEvents txtSeg2 As MetroTextBox
    Friend WithEvents txtEstand2 As MetroTextBox
    Friend WithEvents txtRec2 As MetroTextBox
    Friend WithEvents txtPP2 As MetroTextBox
    Friend WithEvents txtPri2 As MetroTextBox
    Friend WithEvents txtcc2 As MetroTextBox
    Friend WithEvents txtInd1 As MetroTextBox
    Friend WithEvents txtSeg1 As MetroTextBox
    Friend WithEvents txtEstand1 As MetroTextBox
    Friend WithEvents txtrec1 As MetroTextBox
    Friend WithEvents txtpp1 As MetroTextBox
    Friend WithEvents txtpri1 As MetroTextBox
    Friend WithEvents txtcc1 As MetroTextBox
    Friend WithEvents Label15 As MetroLabel
    Friend WithEvents Label14 As MetroLabel
    Friend WithEvents Label13 As MetroLabel
    Friend WithEvents Label12 As MetroLabel
    Friend WithEvents Label11 As MetroLabel
    Friend WithEvents Label10 As MetroLabel
    Friend WithEvents tblClasif As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label16 As MetroLabel
    Friend WithEvents Label9 As MetroLabel
    Friend WithEvents txtCla3 As MetroTextBox
    Friend WithEvents txtCla2 As MetroTextBox
    Friend WithEvents txtCla1 As MetroTextBox
    Friend WithEvents Label17 As MetroLabel
    Friend WithEvents cbLinea As MetroComboBox
    Friend WithEvents cmdGuardar As MetroButton
    Friend WithEvents dgGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents DSAlistamiento As SPIF.DSAlistamiento
    Friend WithEvents AliProduccionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AliProduccionTableAdapter As SPIF.DSAlistamientoTableAdapters.AliProduccionTableAdapter
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaquinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TurnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrupoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PiesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlacasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prod1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cc1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pri1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pp1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rec1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Band1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seg1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ind1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aclasif1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prod2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cc2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pri2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pp2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rec2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Band2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seg2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ind2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aclasif2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prod3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cc3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pri3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pp3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rec3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Band3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seg3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ind3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aclasif3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label18 As MetroLabel
    Friend WithEvents dtBuscar As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancelar As MetroButton
End Class
