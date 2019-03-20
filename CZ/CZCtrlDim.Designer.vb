Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CZCtrlDim
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
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cblinea = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.txtrect = New MetroFramework.Controls.MetroTextBox()
        Me.txtlargo = New MetroFramework.Controls.MetroTextBox()
        Me.txtancho = New MetroFramework.Controls.MetroTextBox()
        Me.txtescu = New MetroFramework.Controls.MetroTextBox()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.dg = New MetroFramework.Controls.MetroGrid()
        Me.chksolo = New MetroFramework.Controls.MetroCheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(208, 94)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(73, 25)
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
        Me.cbgrupo.Location = New System.Drawing.Point(359, 94)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(74, 25)
        Me.cbgrupo.TabIndex = 2
        Me.cbgrupo.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(221, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(372, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(172, 211)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 9
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(274, 211)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 8
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'dtfecha
        '
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(66, 240)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(86, 25)
        Me.dtfecha.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(14, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(74, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Línea:"
        '
        'cblinea
        '
        Me.cblinea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cblinea.FormattingEnabled = True
        Me.cblinea.ItemHeight = 19
        Me.cblinea.Items.AddRange(New Object() {"1", "2"})
        Me.cblinea.Location = New System.Drawing.Point(59, 94)
        Me.cblinea.Name = "cblinea"
        Me.cblinea.Size = New System.Drawing.Size(73, 25)
        Me.cblinea.TabIndex = 0
        Me.cblinea.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(14, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 19)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Rectitud del canto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(311, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 19)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Ancho:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(184, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 19)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Largo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(422, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 19)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Escuadría:"
        '
        'txtrect
        '
        '
        '
        '
        Me.txtrect.CustomButton.Image = Nothing
        Me.txtrect.CustomButton.Location = New System.Drawing.Point(55, 2)
        Me.txtrect.CustomButton.Name = ""
        Me.txtrect.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtrect.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtrect.CustomButton.TabIndex = 1
        Me.txtrect.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtrect.CustomButton.UseSelectable = True
        Me.txtrect.CustomButton.Visible = False
        Me.txtrect.Lines = New String(-1) {}
        Me.txtrect.Location = New System.Drawing.Point(36, 154)
        Me.txtrect.MaxLength = 32767
        Me.txtrect.Name = "txtrect"
        Me.txtrect.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrect.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtrect.SelectedText = ""
        Me.txtrect.SelectionLength = 0
        Me.txtrect.SelectionStart = 0
        Me.txtrect.ShortcutsEnabled = True
        Me.txtrect.Size = New System.Drawing.Size(73, 20)
        Me.txtrect.TabIndex = 3
        Me.txtrect.UseSelectable = True
        Me.txtrect.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtrect.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtlargo
        '
        '
        '
        '
        Me.txtlargo.CustomButton.Image = Nothing
        Me.txtlargo.CustomButton.Location = New System.Drawing.Point(55, 2)
        Me.txtlargo.CustomButton.Name = ""
        Me.txtlargo.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtlargo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtlargo.CustomButton.TabIndex = 1
        Me.txtlargo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtlargo.CustomButton.UseSelectable = True
        Me.txtlargo.CustomButton.Visible = False
        Me.txtlargo.Lines = New String(-1) {}
        Me.txtlargo.Location = New System.Drawing.Point(171, 154)
        Me.txtlargo.MaxLength = 32767
        Me.txtlargo.Name = "txtlargo"
        Me.txtlargo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlargo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtlargo.SelectedText = ""
        Me.txtlargo.SelectionLength = 0
        Me.txtlargo.SelectionStart = 0
        Me.txtlargo.ShortcutsEnabled = True
        Me.txtlargo.Size = New System.Drawing.Size(73, 20)
        Me.txtlargo.TabIndex = 4
        Me.txtlargo.UseSelectable = True
        Me.txtlargo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtlargo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtancho
        '
        '
        '
        '
        Me.txtancho.CustomButton.Image = Nothing
        Me.txtancho.CustomButton.Location = New System.Drawing.Point(55, 2)
        Me.txtancho.CustomButton.Name = ""
        Me.txtancho.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtancho.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtancho.CustomButton.TabIndex = 1
        Me.txtancho.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtancho.CustomButton.UseSelectable = True
        Me.txtancho.CustomButton.Visible = False
        Me.txtancho.Lines = New String(-1) {}
        Me.txtancho.Location = New System.Drawing.Point(298, 154)
        Me.txtancho.MaxLength = 32767
        Me.txtancho.Name = "txtancho"
        Me.txtancho.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtancho.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtancho.SelectedText = ""
        Me.txtancho.SelectionLength = 0
        Me.txtancho.SelectionStart = 0
        Me.txtancho.ShortcutsEnabled = True
        Me.txtancho.Size = New System.Drawing.Size(73, 20)
        Me.txtancho.TabIndex = 5
        Me.txtancho.UseSelectable = True
        Me.txtancho.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtancho.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtescu
        '
        '
        '
        '
        Me.txtescu.CustomButton.Image = Nothing
        Me.txtescu.CustomButton.Location = New System.Drawing.Point(55, 2)
        Me.txtescu.CustomButton.Name = ""
        Me.txtescu.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtescu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtescu.CustomButton.TabIndex = 1
        Me.txtescu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtescu.CustomButton.UseSelectable = True
        Me.txtescu.CustomButton.Visible = False
        Me.txtescu.Lines = New String(-1) {}
        Me.txtescu.Location = New System.Drawing.Point(422, 154)
        Me.txtescu.MaxLength = 32767
        Me.txtescu.Name = "txtescu"
        Me.txtescu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtescu.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtescu.SelectedText = ""
        Me.txtescu.SelectionLength = 0
        Me.txtescu.SelectionStart = 0
        Me.txtescu.ShortcutsEnabled = True
        Me.txtescu.Size = New System.Drawing.Size(73, 20)
        Me.txtescu.TabIndex = 6
        Me.txtescu.UseSelectable = True
        Me.txtescu.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtescu.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(5, 271)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(518, 198)
        Me.TabControl1.Style = MetroFramework.MetroColorStyle.Brown
        Me.TabControl1.TabIndex = 57
        Me.TabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.dg)
        Me.TabPage1.HorizontalScrollbarBarColor = True
        Me.TabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage1.HorizontalScrollbarSize = 10
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(510, 156)
        Me.TabPage1.Style = MetroFramework.MetroColorStyle.Brown
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Controles Dimensionales"
        Me.TabPage1.UseCustomBackColor = True
        Me.TabPage1.VerticalScrollbarBarColor = True
        Me.TabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage1.VerticalScrollbarSize = 10
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToResizeColumns = False
        Me.dg.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle3
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.EnableHeadersVisualStyles = False
        Me.dg.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dg.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.Location = New System.Drawing.Point(3, 3)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg.RowHeadersVisible = False
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(504, 150)
        Me.dg.Style = MetroFramework.MetroColorStyle.Brown
        Me.dg.TabIndex = 27
        Me.dg.UseCustomBackColor = True
        Me.dg.UseCustomForeColor = True
        Me.dg.UseStyleColors = True
        '
        'chksolo
        '
        Me.chksolo.AutoSize = True
        Me.chksolo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chksolo.Location = New System.Drawing.Point(184, 180)
        Me.chksolo.Name = "chksolo"
        Me.chksolo.Size = New System.Drawing.Size(163, 15)
        Me.chksolo.TabIndex = 7
        Me.chksolo.Text = "Cargar solo Largo y Ancho"
        Me.chksolo.UseSelectable = True
        '
        'CZCtrlDim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 474)
        Me.Controls.Add(Me.chksolo)
        Me.Controls.Add(Me.txtescu)
        Me.Controls.Add(Me.txtancho)
        Me.Controls.Add(Me.txtlargo)
        Me.Controls.Add(Me.txtrect)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cblinea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "CZCtrlDim"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Brown
        Me.Text = "Controles Dimensionales"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents cblinea As MetroComboBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents txtrect As MetroTextBox
    Friend WithEvents txtlargo As MetroTextBox
    Friend WithEvents txtancho As MetroTextBox
    Friend WithEvents txtescu As MetroTextBox
    Friend WithEvents TabControl1 As MetroTabControl
    Friend WithEvents TabPage1 As MetroTabPage
    Friend WithEvents chksolo As MetroCheckBox
    Friend WithEvents dg As MetroGrid
End Class
