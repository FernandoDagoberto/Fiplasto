Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Paradas
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
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.dthi = New System.Windows.Forms.DateTimePicker()
        Me.dthf = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.txttotal = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.Sector = New MetroFramework.Controls.MetroLabel()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.cbcausa = New MetroFramework.Controls.MetroComboBox()
        Me.cbmotivo = New MetroFramework.Controls.MetroComboBox()
        Me.cbsec = New MetroFramework.Controls.MetroComboBox()
        Me.cbparada = New MetroFramework.Controls.MetroComboBox()
        Me.txtobs = New MetroFramework.Controls.MetroTextBox()
        Me.txtsec = New MetroFramework.Controls.MetroTextBox()
        Me.txtparada = New MetroFramework.Controls.MetroTextBox()
        Me.cbreparo = New MetroFramework.Controls.MetroComboBox()
        Me.btnagregar = New MetroFramework.Controls.MetroButton()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.txtarea = New MetroFramework.Controls.MetroTextBox()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.cblinea = New MetroFramework.Controls.MetroComboBox()
        Me.lbllinea = New MetroFramework.Controls.MetroLabel()
        Me.dg = New MetroFramework.Controls.MetroGrid()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtfecha
        '
        Me.dtfecha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(300, 88)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(88, 25)
        Me.dtfecha.TabIndex = 3
        '
        'dthi
        '
        Me.dthi.CustomFormat = "HH:mm"
        Me.dthi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dthi.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dthi.Location = New System.Drawing.Point(399, 88)
        Me.dthi.Name = "dthi"
        Me.dthi.ShowUpDown = True
        Me.dthi.Size = New System.Drawing.Size(88, 25)
        Me.dthi.TabIndex = 4
        '
        'dthf
        '
        Me.dthf.CustomFormat = "HH:mm"
        Me.dthf.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dthf.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dthf.Location = New System.Drawing.Point(499, 88)
        Me.dthf.Name = "dthf"
        Me.dthf.ShowUpDown = True
        Me.dthf.Size = New System.Drawing.Size(82, 25)
        Me.dthf.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(323, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(520, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(421, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Desde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(185, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Turno"
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(181, 88)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(50, 25)
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
        Me.cbgrupo.Location = New System.Drawing.Point(237, 88)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(57, 25)
        Me.cbgrupo.TabIndex = 2
        Me.cbgrupo.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(242, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Grupo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(608, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total"
        '
        'txttotal
        '
        '
        '
        '
        Me.txttotal.CustomButton.Image = Nothing
        Me.txttotal.CustomButton.Location = New System.Drawing.Point(39, 2)
        Me.txttotal.CustomButton.Name = ""
        Me.txttotal.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txttotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttotal.CustomButton.TabIndex = 1
        Me.txttotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttotal.CustomButton.UseSelectable = True
        Me.txttotal.CustomButton.Visible = False
        Me.txttotal.Lines = New String(-1) {}
        Me.txttotal.Location = New System.Drawing.Point(599, 88)
        Me.txttotal.MaxLength = 32767
        Me.txttotal.Name = "txttotal"
        Me.txttotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotal.ReadOnly = True
        Me.txttotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttotal.SelectedText = ""
        Me.txttotal.SelectionLength = 0
        Me.txttotal.SelectionStart = 0
        Me.txttotal.ShortcutsEnabled = True
        Me.txttotal.Size = New System.Drawing.Size(57, 20)
        Me.txttotal.TabIndex = 11
        Me.txttotal.UseSelectable = True
        Me.txttotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(54, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Causa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(181, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Motivo"
        '
        'Sector
        '
        Me.Sector.AutoSize = True
        Me.Sector.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Sector.Location = New System.Drawing.Point(304, 131)
        Me.Sector.Name = "Sector"
        Me.Sector.Size = New System.Drawing.Size(50, 19)
        Me.Sector.TabIndex = 14
        Me.Sector.Text = "Equipo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(460, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 19)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Parada"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(246, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 19)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Observación"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(241, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 19)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Reparado por"
        '
        'cbcausa
        '
        Me.cbcausa.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbcausa.FormattingEnabled = True
        Me.cbcausa.ItemHeight = 19
        Me.cbcausa.Location = New System.Drawing.Point(17, 156)
        Me.cbcausa.Name = "cbcausa"
        Me.cbcausa.Size = New System.Drawing.Size(117, 25)
        Me.cbcausa.TabIndex = 6
        Me.cbcausa.UseSelectable = True
        '
        'cbmotivo
        '
        Me.cbmotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmotivo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmotivo.FormattingEnabled = True
        Me.cbmotivo.ItemHeight = 19
        Me.cbmotivo.Location = New System.Drawing.Point(141, 156)
        Me.cbmotivo.Name = "cbmotivo"
        Me.cbmotivo.Size = New System.Drawing.Size(130, 25)
        Me.cbmotivo.TabIndex = 7
        Me.cbmotivo.UseSelectable = True
        '
        'cbsec
        '
        Me.cbsec.DropDownWidth = 200
        Me.cbsec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbsec.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbsec.FormattingEnabled = True
        Me.cbsec.ItemHeight = 19
        Me.cbsec.Location = New System.Drawing.Point(277, 156)
        Me.cbsec.Name = "cbsec"
        Me.cbsec.Size = New System.Drawing.Size(157, 25)
        Me.cbsec.TabIndex = 8
        Me.cbsec.UseSelectable = True
        '
        'cbparada
        '
        Me.cbparada.DropDownWidth = 200
        Me.cbparada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbparada.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbparada.FormattingEnabled = True
        Me.cbparada.ItemHeight = 19
        Me.cbparada.Location = New System.Drawing.Point(440, 156)
        Me.cbparada.Name = "cbparada"
        Me.cbparada.Size = New System.Drawing.Size(157, 25)
        Me.cbparada.TabIndex = 9
        Me.cbparada.UseSelectable = True
        '
        'txtobs
        '
        '
        '
        '
        Me.txtobs.CustomButton.Image = Nothing
        Me.txtobs.CustomButton.Location = New System.Drawing.Point(206, 2)
        Me.txtobs.CustomButton.Name = ""
        Me.txtobs.CustomButton.Size = New System.Drawing.Size(55, 55)
        Me.txtobs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtobs.CustomButton.TabIndex = 1
        Me.txtobs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtobs.CustomButton.UseSelectable = True
        Me.txtobs.CustomButton.Visible = False
        Me.txtobs.Lines = New String(-1) {}
        Me.txtobs.Location = New System.Drawing.Point(155, 222)
        Me.txtobs.MaxLength = 32767
        Me.txtobs.Multiline = True
        Me.txtobs.Name = "txtobs"
        Me.txtobs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtobs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtobs.SelectedText = ""
        Me.txtobs.SelectionLength = 0
        Me.txtobs.SelectionStart = 0
        Me.txtobs.ShortcutsEnabled = True
        Me.txtobs.Size = New System.Drawing.Size(264, 60)
        Me.txtobs.TabIndex = 10
        Me.txtobs.UseSelectable = True
        Me.txtobs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtobs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtsec
        '
        '
        '
        '
        Me.txtsec.CustomButton.Image = Nothing
        Me.txtsec.CustomButton.Location = New System.Drawing.Point(24, 2)
        Me.txtsec.CustomButton.Name = ""
        Me.txtsec.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsec.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsec.CustomButton.TabIndex = 1
        Me.txtsec.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsec.CustomButton.UseSelectable = True
        Me.txtsec.CustomButton.Visible = False
        Me.txtsec.Lines = New String(-1) {}
        Me.txtsec.Location = New System.Drawing.Point(360, 130)
        Me.txtsec.MaxLength = 32767
        Me.txtsec.Name = "txtsec"
        Me.txtsec.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsec.ReadOnly = True
        Me.txtsec.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsec.SelectedText = ""
        Me.txtsec.SelectionLength = 0
        Me.txtsec.SelectionStart = 0
        Me.txtsec.ShortcutsEnabled = True
        Me.txtsec.Size = New System.Drawing.Size(42, 20)
        Me.txtsec.TabIndex = 23
        Me.txtsec.UseSelectable = True
        Me.txtsec.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsec.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtparada
        '
        '
        '
        '
        Me.txtparada.CustomButton.Image = Nothing
        Me.txtparada.CustomButton.Location = New System.Drawing.Point(36, 2)
        Me.txtparada.CustomButton.Name = ""
        Me.txtparada.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtparada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtparada.CustomButton.TabIndex = 1
        Me.txtparada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtparada.CustomButton.UseSelectable = True
        Me.txtparada.CustomButton.Visible = False
        Me.txtparada.Lines = New String(-1) {}
        Me.txtparada.Location = New System.Drawing.Point(517, 130)
        Me.txtparada.MaxLength = 32767
        Me.txtparada.Name = "txtparada"
        Me.txtparada.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtparada.ReadOnly = True
        Me.txtparada.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtparada.SelectedText = ""
        Me.txtparada.SelectionLength = 0
        Me.txtparada.SelectionStart = 0
        Me.txtparada.ShortcutsEnabled = True
        Me.txtparada.Size = New System.Drawing.Size(54, 20)
        Me.txtparada.TabIndex = 24
        Me.txtparada.UseSelectable = True
        Me.txtparada.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtparada.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbreparo
        '
        Me.cbreparo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbreparo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbreparo.FormattingEnabled = True
        Me.cbreparo.ItemHeight = 19
        Me.cbreparo.Location = New System.Drawing.Point(220, 307)
        Me.cbreparo.Name = "cbreparo"
        Me.cbreparo.Size = New System.Drawing.Size(134, 25)
        Me.cbreparo.TabIndex = 11
        Me.cbreparo.UseSelectable = True
        '
        'btnagregar
        '
        Me.btnagregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnagregar.Location = New System.Drawing.Point(360, 363)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(87, 23)
        Me.btnagregar.TabIndex = 12
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseSelectable = True
        '
        'btncancelar
        '
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(246, 363)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(87, 23)
        Me.btncancelar.TabIndex = 13
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseSelectable = True
        Me.btncancelar.Visible = False
        '
        'txtarea
        '
        '
        '
        '
        Me.txtarea.CustomButton.Image = Nothing
        Me.txtarea.CustomButton.Location = New System.Drawing.Point(70, 2)
        Me.txtarea.CustomButton.Name = ""
        Me.txtarea.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtarea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtarea.CustomButton.TabIndex = 1
        Me.txtarea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtarea.CustomButton.UseSelectable = True
        Me.txtarea.CustomButton.Visible = False
        Me.txtarea.Lines = New String(-1) {}
        Me.txtarea.Location = New System.Drawing.Point(28, 88)
        Me.txtarea.MaxLength = 32767
        Me.txtarea.Name = "txtarea"
        Me.txtarea.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtarea.ReadOnly = True
        Me.txtarea.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtarea.SelectedText = ""
        Me.txtarea.SelectionLength = 0
        Me.txtarea.SelectionStart = 0
        Me.txtarea.ShortcutsEnabled = True
        Me.txtarea.Size = New System.Drawing.Size(88, 20)
        Me.txtarea.TabIndex = 0
        Me.txtarea.UseSelectable = True
        Me.txtarea.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtarea.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(54, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 19)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Área"
        '
        'cblinea
        '
        Me.cblinea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cblinea.FormattingEnabled = True
        Me.cblinea.ItemHeight = 19
        Me.cblinea.Items.AddRange(New Object() {"1", "2"})
        Me.cblinea.Location = New System.Drawing.Point(122, 88)
        Me.cblinea.Name = "cblinea"
        Me.cblinea.Size = New System.Drawing.Size(53, 25)
        Me.cblinea.TabIndex = 0
        Me.cblinea.UseSelectable = True
        Me.cblinea.Visible = False
        '
        'lbllinea
        '
        Me.lbllinea.AutoSize = True
        Me.lbllinea.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbllinea.Location = New System.Drawing.Point(129, 66)
        Me.lbllinea.Name = "lbllinea"
        Me.lbllinea.Size = New System.Drawing.Size(39, 19)
        Me.lbllinea.TabIndex = 32
        Me.lbllinea.Text = "Línea"
        Me.lbllinea.Visible = False
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToResizeColumns = False
        Me.dg.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg.BackgroundColor = System.Drawing.Color.Silver
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle3
        Me.dg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dg.EnableHeadersVisualStyles = False
        Me.dg.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dg.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.Location = New System.Drawing.Point(5, 411)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg.RowHeadersVisible = False
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(658, 145)
        Me.dg.TabIndex = 81
        Me.dg.UseCustomBackColor = True
        Me.dg.UseCustomForeColor = True
        Me.dg.UseStyleColors = True
        '
        'Paradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 561)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.lbllinea)
        Me.Controls.Add(Me.cblinea)
        Me.Controls.Add(Me.txtarea)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.cbreparo)
        Me.Controls.Add(Me.txtparada)
        Me.Controls.Add(Me.txtsec)
        Me.Controls.Add(Me.txtobs)
        Me.Controls.Add(Me.cbparada)
        Me.Controls.Add(Me.cbsec)
        Me.Controls.Add(Me.cbmotivo)
        Me.Controls.Add(Me.cbcausa)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Sector)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dthf)
        Me.Controls.Add(Me.dthi)
        Me.Controls.Add(Me.dtfecha)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "Paradas"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Text = "Paradas"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dthi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dthf As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents txttotal As MetroTextBox
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents Sector As MetroLabel
    Friend WithEvents Label10 As MetroLabel
    Friend WithEvents Label11 As MetroLabel
    Friend WithEvents Label12 As MetroLabel
    Friend WithEvents cbcausa As MetroComboBox
    Friend WithEvents cbmotivo As MetroComboBox
    Friend WithEvents cbsec As MetroComboBox
    Friend WithEvents cbparada As MetroComboBox
    Friend WithEvents txtobs As MetroTextBox
    Friend WithEvents txtsec As MetroTextBox
    Friend WithEvents txtparada As MetroTextBox
    Friend WithEvents cbreparo As MetroComboBox
    Friend WithEvents btnagregar As MetroButton
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents txtarea As MetroTextBox
    Friend WithEvents Label9 As MetroLabel
    Friend WithEvents cblinea As MetroComboBox
    Friend WithEvents lbllinea As MetroLabel
    Friend WithEvents dg As MetroGrid
End Class
