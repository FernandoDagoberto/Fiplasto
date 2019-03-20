Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class McVarProc
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
        Me.cbmc = New MetroFramework.Controls.MetroComboBox()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.cbmaterial = New MetroFramework.Controls.MetroComboBox()
        Me.txtvel = New MetroFramework.Controls.MetroTextBox()
        Me.txtantiesp = New MetroFramework.Controls.MetroTextBox()
        Me.txtlargohh = New MetroFramework.Controls.MetroTextBox()
        Me.txtanchohh = New MetroFramework.Controls.MetroTextBox()
        Me.txttempulpa = New MetroFramework.Controls.MetroTextBox()
        Me.txtcauefl = New MetroFramework.Controls.MetroTextBox()
        Me.txt1a2 = New MetroFramework.Controls.MetroTextBox()
        Me.txt2a3 = New MetroFramework.Controls.MetroTextBox()
        Me.txttqbl = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.Label13 = New MetroFramework.Controls.MetroLabel()
        Me.Label14 = New MetroFramework.Controls.MetroLabel()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.Label15 = New MetroFramework.Controls.MetroLabel()
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.dg = New MetroFramework.Controls.MetroGrid()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbmc
        '
        Me.cbmc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmc.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmc.FormattingEnabled = True
        Me.cbmc.ItemHeight = 19
        Me.cbmc.Items.AddRange(New Object() {"1", "2"})
        Me.cbmc.Location = New System.Drawing.Point(153, 71)
        Me.cbmc.Name = "cbmc"
        Me.cbmc.Size = New System.Drawing.Size(62, 25)
        Me.cbmc.TabIndex = 0
        Me.cbmc.UseSelectable = True
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(153, 102)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(62, 25)
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
        Me.cbgrupo.Location = New System.Drawing.Point(153, 133)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(62, 25)
        Me.cbgrupo.TabIndex = 2
        Me.cbgrupo.UseSelectable = True
        '
        'cbmaterial
        '
        Me.cbmaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmaterial.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmaterial.FormattingEnabled = True
        Me.cbmaterial.ItemHeight = 19
        Me.cbmaterial.Location = New System.Drawing.Point(153, 164)
        Me.cbmaterial.Name = "cbmaterial"
        Me.cbmaterial.Size = New System.Drawing.Size(62, 25)
        Me.cbmaterial.TabIndex = 3
        Me.cbmaterial.UseSelectable = True
        '
        'txtvel
        '
        '
        '
        '
        Me.txtvel.CustomButton.Image = Nothing
        Me.txtvel.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtvel.CustomButton.Name = ""
        Me.txtvel.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtvel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvel.CustomButton.TabIndex = 1
        Me.txtvel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvel.CustomButton.UseSelectable = True
        Me.txtvel.CustomButton.Visible = False
        Me.txtvel.Lines = New String(-1) {}
        Me.txtvel.Location = New System.Drawing.Point(153, 195)
        Me.txtvel.MaxLength = 32767
        Me.txtvel.Name = "txtvel"
        Me.txtvel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvel.SelectedText = ""
        Me.txtvel.SelectionLength = 0
        Me.txtvel.SelectionStart = 0
        Me.txtvel.ShortcutsEnabled = True
        Me.txtvel.Size = New System.Drawing.Size(100, 20)
        Me.txtvel.TabIndex = 4
        Me.txtvel.UseSelectable = True
        Me.txtvel.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvel.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtantiesp
        '
        '
        '
        '
        Me.txtantiesp.CustomButton.Image = Nothing
        Me.txtantiesp.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtantiesp.CustomButton.Name = ""
        Me.txtantiesp.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtantiesp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtantiesp.CustomButton.TabIndex = 1
        Me.txtantiesp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtantiesp.CustomButton.UseSelectable = True
        Me.txtantiesp.CustomButton.Visible = False
        Me.txtantiesp.Lines = New String(-1) {}
        Me.txtantiesp.Location = New System.Drawing.Point(153, 221)
        Me.txtantiesp.MaxLength = 32767
        Me.txtantiesp.Name = "txtantiesp"
        Me.txtantiesp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtantiesp.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtantiesp.SelectedText = ""
        Me.txtantiesp.SelectionLength = 0
        Me.txtantiesp.SelectionStart = 0
        Me.txtantiesp.ShortcutsEnabled = True
        Me.txtantiesp.Size = New System.Drawing.Size(100, 20)
        Me.txtantiesp.TabIndex = 5
        Me.txtantiesp.UseSelectable = True
        Me.txtantiesp.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtantiesp.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtlargohh
        '
        '
        '
        '
        Me.txtlargohh.CustomButton.Image = Nothing
        Me.txtlargohh.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtlargohh.CustomButton.Name = ""
        Me.txtlargohh.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtlargohh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtlargohh.CustomButton.TabIndex = 1
        Me.txtlargohh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtlargohh.CustomButton.UseSelectable = True
        Me.txtlargohh.CustomButton.Visible = False
        Me.txtlargohh.Lines = New String(-1) {}
        Me.txtlargohh.Location = New System.Drawing.Point(153, 247)
        Me.txtlargohh.MaxLength = 32767
        Me.txtlargohh.Name = "txtlargohh"
        Me.txtlargohh.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlargohh.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtlargohh.SelectedText = ""
        Me.txtlargohh.SelectionLength = 0
        Me.txtlargohh.SelectionStart = 0
        Me.txtlargohh.ShortcutsEnabled = True
        Me.txtlargohh.Size = New System.Drawing.Size(100, 20)
        Me.txtlargohh.TabIndex = 6
        Me.txtlargohh.UseSelectable = True
        Me.txtlargohh.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtlargohh.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtanchohh
        '
        '
        '
        '
        Me.txtanchohh.CustomButton.Image = Nothing
        Me.txtanchohh.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtanchohh.CustomButton.Name = ""
        Me.txtanchohh.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtanchohh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtanchohh.CustomButton.TabIndex = 1
        Me.txtanchohh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtanchohh.CustomButton.UseSelectable = True
        Me.txtanchohh.CustomButton.Visible = False
        Me.txtanchohh.Lines = New String(-1) {}
        Me.txtanchohh.Location = New System.Drawing.Point(153, 273)
        Me.txtanchohh.MaxLength = 32767
        Me.txtanchohh.Name = "txtanchohh"
        Me.txtanchohh.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtanchohh.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtanchohh.SelectedText = ""
        Me.txtanchohh.SelectionLength = 0
        Me.txtanchohh.SelectionStart = 0
        Me.txtanchohh.ShortcutsEnabled = True
        Me.txtanchohh.Size = New System.Drawing.Size(100, 20)
        Me.txtanchohh.TabIndex = 7
        Me.txtanchohh.UseSelectable = True
        Me.txtanchohh.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtanchohh.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txttempulpa
        '
        '
        '
        '
        Me.txttempulpa.CustomButton.Image = Nothing
        Me.txttempulpa.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txttempulpa.CustomButton.Name = ""
        Me.txttempulpa.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txttempulpa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttempulpa.CustomButton.TabIndex = 1
        Me.txttempulpa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttempulpa.CustomButton.UseSelectable = True
        Me.txttempulpa.CustomButton.Visible = False
        Me.txttempulpa.Lines = New String(-1) {}
        Me.txttempulpa.Location = New System.Drawing.Point(153, 299)
        Me.txttempulpa.MaxLength = 32767
        Me.txttempulpa.Name = "txttempulpa"
        Me.txttempulpa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttempulpa.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttempulpa.SelectedText = ""
        Me.txttempulpa.SelectionLength = 0
        Me.txttempulpa.SelectionStart = 0
        Me.txttempulpa.ShortcutsEnabled = True
        Me.txttempulpa.Size = New System.Drawing.Size(100, 20)
        Me.txttempulpa.TabIndex = 8
        Me.txttempulpa.UseSelectable = True
        Me.txttempulpa.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttempulpa.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtcauefl
        '
        '
        '
        '
        Me.txtcauefl.CustomButton.Image = Nothing
        Me.txtcauefl.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtcauefl.CustomButton.Name = ""
        Me.txtcauefl.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcauefl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcauefl.CustomButton.TabIndex = 1
        Me.txtcauefl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcauefl.CustomButton.UseSelectable = True
        Me.txtcauefl.CustomButton.Visible = False
        Me.txtcauefl.Lines = New String(-1) {}
        Me.txtcauefl.Location = New System.Drawing.Point(153, 325)
        Me.txtcauefl.MaxLength = 32767
        Me.txtcauefl.Name = "txtcauefl"
        Me.txtcauefl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcauefl.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcauefl.SelectedText = ""
        Me.txtcauefl.SelectionLength = 0
        Me.txtcauefl.SelectionStart = 0
        Me.txtcauefl.ShortcutsEnabled = True
        Me.txtcauefl.Size = New System.Drawing.Size(100, 20)
        Me.txtcauefl.TabIndex = 9
        Me.txtcauefl.UseSelectable = True
        Me.txtcauefl.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcauefl.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt1a2
        '
        '
        '
        '
        Me.txt1a2.CustomButton.Image = Nothing
        Me.txt1a2.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txt1a2.CustomButton.Name = ""
        Me.txt1a2.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txt1a2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt1a2.CustomButton.TabIndex = 1
        Me.txt1a2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt1a2.CustomButton.UseSelectable = True
        Me.txt1a2.CustomButton.Visible = False
        Me.txt1a2.Lines = New String(-1) {}
        Me.txt1a2.Location = New System.Drawing.Point(153, 364)
        Me.txt1a2.MaxLength = 32767
        Me.txt1a2.Name = "txt1a2"
        Me.txt1a2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt1a2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt1a2.SelectedText = ""
        Me.txt1a2.SelectionLength = 0
        Me.txt1a2.SelectionStart = 0
        Me.txt1a2.ShortcutsEnabled = True
        Me.txt1a2.Size = New System.Drawing.Size(100, 20)
        Me.txt1a2.TabIndex = 10
        Me.txt1a2.UseSelectable = True
        Me.txt1a2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt1a2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt2a3
        '
        '
        '
        '
        Me.txt2a3.CustomButton.Image = Nothing
        Me.txt2a3.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txt2a3.CustomButton.Name = ""
        Me.txt2a3.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txt2a3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt2a3.CustomButton.TabIndex = 1
        Me.txt2a3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt2a3.CustomButton.UseSelectable = True
        Me.txt2a3.CustomButton.Visible = False
        Me.txt2a3.Lines = New String(-1) {}
        Me.txt2a3.Location = New System.Drawing.Point(153, 390)
        Me.txt2a3.MaxLength = 32767
        Me.txt2a3.Name = "txt2a3"
        Me.txt2a3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt2a3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt2a3.SelectedText = ""
        Me.txt2a3.SelectionLength = 0
        Me.txt2a3.SelectionStart = 0
        Me.txt2a3.ShortcutsEnabled = True
        Me.txt2a3.Size = New System.Drawing.Size(100, 20)
        Me.txt2a3.TabIndex = 11
        Me.txt2a3.UseSelectable = True
        Me.txt2a3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt2a3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txttqbl
        '
        '
        '
        '
        Me.txttqbl.CustomButton.Image = Nothing
        Me.txttqbl.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txttqbl.CustomButton.Name = ""
        Me.txttqbl.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txttqbl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttqbl.CustomButton.TabIndex = 1
        Me.txttqbl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttqbl.CustomButton.UseSelectable = True
        Me.txttqbl.CustomButton.Visible = False
        Me.txttqbl.Lines = New String(-1) {}
        Me.txttqbl.Location = New System.Drawing.Point(153, 416)
        Me.txttqbl.MaxLength = 32767
        Me.txttqbl.Name = "txttqbl"
        Me.txttqbl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttqbl.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttqbl.SelectedText = ""
        Me.txttqbl.SelectionLength = 0
        Me.txttqbl.SelectionStart = 0
        Me.txttqbl.ShortcutsEnabled = True
        Me.txttqbl.Size = New System.Drawing.Size(100, 20)
        Me.txttqbl.TabIndex = 12
        Me.txttqbl.UseSelectable = True
        Me.txttqbl.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttqbl.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(19, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "MC:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(19, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(19, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(19, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Material:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(19, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Velocidad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(19, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Antiespumante:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(19, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Largo de HH:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(19, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 19)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Ancho de HH:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(19, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Temp. de Pulpa:"
        '
        'Label10
        '
        Me.Label10.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(34, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Caudal a efluente:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(22, 345)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 19)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Concentración:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(31, 364)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 19)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "De Tq 1 al Tq 2:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(31, 391)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 19)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "De Tq 2 al Tq 3:"
        '
        'Label14
        '
        Me.Label14.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(21, 416)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Temp. Tq. Agua Blanca:"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(119, 481)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(200, 481)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 13
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(6, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 19)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Fecha:"
        '
        'dtfecha
        '
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(58, 10)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(90, 25)
        Me.dtfecha.TabIndex = 0
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.dg)
        Me.MetroPanel1.Controls.Add(Me.MetroPanel2)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(316, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(511, 462)
        Me.MetroPanel1.TabIndex = 44
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToResizeColumns = False
        Me.dg.AllowUserToResizeRows = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.EnableHeadersVisualStyles = False
        Me.dg.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dg.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.Location = New System.Drawing.Point(0, 37)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg.RowHeadersVisible = False
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(509, 423)
        Me.dg.Style = MetroFramework.MetroColorStyle.Teal
        Me.dg.TabIndex = 46
        Me.dg.UseCustomBackColor = True
        Me.dg.UseCustomForeColor = True
        Me.dg.UseStyleColors = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.Label15)
        Me.MetroPanel2.Controls.Add(Me.dtfecha)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(509, 37)
        Me.MetroPanel2.TabIndex = 0
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'McVarProc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 527)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttqbl)
        Me.Controls.Add(Me.txt2a3)
        Me.Controls.Add(Me.txt1a2)
        Me.Controls.Add(Me.txtcauefl)
        Me.Controls.Add(Me.txttempulpa)
        Me.Controls.Add(Me.txtanchohh)
        Me.Controls.Add(Me.txtlargohh)
        Me.Controls.Add(Me.txtantiesp)
        Me.Controls.Add(Me.txtvel)
        Me.Controls.Add(Me.cbmaterial)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.cbmc)
        Me.Name = "McVarProc"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Variables del proceso"
        Me.MetroPanel1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbmc As MetroComboBox
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents cbmaterial As MetroComboBox
    Friend WithEvents txtvel As MetroTextBox
    Friend WithEvents txtantiesp As MetroTextBox
    Friend WithEvents txtlargohh As MetroTextBox
    Friend WithEvents txtanchohh As MetroTextBox
    Friend WithEvents txttempulpa As MetroTextBox
    Friend WithEvents txtcauefl As MetroTextBox
    Friend WithEvents txt1a2 As MetroTextBox
    Friend WithEvents txt2a3 As MetroTextBox
    Friend WithEvents txttqbl As MetroTextBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents Label9 As MetroLabel
    Friend WithEvents Label10 As MetroLabel
    Friend WithEvents Label11 As MetroLabel
    Friend WithEvents Label12 As MetroLabel
    Friend WithEvents Label13 As MetroLabel
    Friend WithEvents Label14 As MetroLabel
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents Label15 As MetroLabel
    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents dg As MetroGrid
End Class
