Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LAVSoda
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
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tpLimp = New MetroFramework.Controls.MetroTabPage()
        Me.dgIng = New MetroFramework.Controls.MetroGrid()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.chksoda = New MetroFramework.Controls.MetroCheckBox()
        Me.chkconce = New MetroFramework.Controls.MetroCheckBox()
        Me.txtsoda = New MetroFramework.Controls.MetroTextBox()
        Me.txtconce = New MetroFramework.Controls.MetroTextBox()
        Me.txttemp = New MetroFramework.Controls.MetroTextBox()
        Me.chktemp = New MetroFramework.Controls.MetroCheckBox()
        Me.rbcuba1 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbcuba2 = New MetroFramework.Controls.MetroRadioButton()
        Me.TabControl1.SuspendLayout()
        Me.tpLimp.SuspendLayout()
        CType(Me.dgIng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(322, 63)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(73, 25)
        Me.cbturno.Style = MetroFramework.MetroColorStyle.Orange
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
        Me.cbgrupo.Location = New System.Drawing.Point(322, 90)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(73, 25)
        Me.cbgrupo.Style = MetroFramework.MetroColorStyle.Orange
        Me.cbgrupo.TabIndex = 1
        Me.cbgrupo.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(231, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(231, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(238, 263)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 8
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(328, 263)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 7
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpLimp)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(5, 350)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(615, 173)
        Me.TabControl1.Style = MetroFramework.MetroColorStyle.Orange
        Me.TabControl1.TabIndex = 71
        Me.TabControl1.UseSelectable = True
        '
        'tpLimp
        '
        Me.tpLimp.Controls.Add(Me.dgIng)
        Me.tpLimp.HorizontalScrollbarBarColor = True
        Me.tpLimp.HorizontalScrollbarHighlightOnWheel = False
        Me.tpLimp.HorizontalScrollbarSize = 10
        Me.tpLimp.Location = New System.Drawing.Point(4, 38)
        Me.tpLimp.Name = "tpLimp"
        Me.tpLimp.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLimp.Size = New System.Drawing.Size(607, 131)
        Me.tpLimp.TabIndex = 0
        Me.tpLimp.Text = "Preparación de soda cáustica"
        Me.tpLimp.UseVisualStyleBackColor = True
        Me.tpLimp.VerticalScrollbarBarColor = True
        Me.tpLimp.VerticalScrollbarHighlightOnWheel = False
        Me.tpLimp.VerticalScrollbarSize = 10
        '
        'dgIng
        '
        Me.dgIng.AllowUserToAddRows = False
        Me.dgIng.AllowUserToDeleteRows = False
        Me.dgIng.AllowUserToResizeColumns = False
        Me.dgIng.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dgIng.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgIng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgIng.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgIng.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgIng.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgIng.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgIng.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgIng.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgIng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgIng.EnableHeadersVisualStyles = False
        Me.dgIng.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgIng.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgIng.Location = New System.Drawing.Point(3, 3)
        Me.dgIng.MultiSelect = False
        Me.dgIng.Name = "dgIng"
        Me.dgIng.ReadOnly = True
        Me.dgIng.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgIng.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgIng.RowHeadersVisible = False
        Me.dgIng.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgIng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgIng.Size = New System.Drawing.Size(601, 125)
        Me.dgIng.Style = MetroFramework.MetroColorStyle.Orange
        Me.dgIng.TabIndex = 72
        Me.dgIng.UseCustomBackColor = True
        Me.dgIng.UseCustomForeColor = True
        Me.dgIng.UseStyleColors = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(20, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 19)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Fecha para búsqueda:"
        '
        'dtfecha
        '
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(197, 309)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(80, 20)
        Me.dtfecha.TabIndex = 9
        '
        'chksoda
        '
        Me.chksoda.AutoSize = True
        Me.chksoda.ForeColor = System.Drawing.Color.Black
        Me.chksoda.Location = New System.Drawing.Point(203, 184)
        Me.chksoda.Name = "chksoda"
        Me.chksoda.Size = New System.Drawing.Size(135, 15)
        Me.chksoda.Style = MetroFramework.MetroColorStyle.Orange
        Me.chksoda.TabIndex = 4
        Me.chksoda.Text = "Litros Soda Agregada"
        Me.chksoda.UseSelectable = True
        '
        'chkconce
        '
        Me.chkconce.AutoSize = True
        Me.chkconce.ForeColor = System.Drawing.Color.Black
        Me.chkconce.Location = New System.Drawing.Point(203, 210)
        Me.chkconce.Name = "chkconce"
        Me.chkconce.Size = New System.Drawing.Size(101, 15)
        Me.chkconce.Style = MetroFramework.MetroColorStyle.Orange
        Me.chkconce.TabIndex = 6
        Me.chkconce.Text = "Concentración"
        Me.chkconce.UseSelectable = True
        '
        'txtsoda
        '
        '
        '
        '
        Me.txtsoda.CustomButton.Image = Nothing
        Me.txtsoda.CustomButton.Location = New System.Drawing.Point(61, 2)
        Me.txtsoda.CustomButton.Name = ""
        Me.txtsoda.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtsoda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtsoda.CustomButton.TabIndex = 1
        Me.txtsoda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtsoda.CustomButton.UseSelectable = True
        Me.txtsoda.CustomButton.Visible = False
        Me.txtsoda.Enabled = False
        Me.txtsoda.Lines = New String(-1) {}
        Me.txtsoda.Location = New System.Drawing.Point(350, 179)
        Me.txtsoda.MaxLength = 32767
        Me.txtsoda.Name = "txtsoda"
        Me.txtsoda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsoda.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsoda.SelectedText = ""
        Me.txtsoda.SelectionLength = 0
        Me.txtsoda.SelectionStart = 0
        Me.txtsoda.ShortcutsEnabled = True
        Me.txtsoda.Size = New System.Drawing.Size(79, 20)
        Me.txtsoda.Style = MetroFramework.MetroColorStyle.Orange
        Me.txtsoda.TabIndex = 4
        Me.txtsoda.UseSelectable = True
        Me.txtsoda.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtsoda.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtconce
        '
        '
        '
        '
        Me.txtconce.CustomButton.Image = Nothing
        Me.txtconce.CustomButton.Location = New System.Drawing.Point(61, 2)
        Me.txtconce.CustomButton.Name = ""
        Me.txtconce.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtconce.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtconce.CustomButton.TabIndex = 1
        Me.txtconce.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtconce.CustomButton.UseSelectable = True
        Me.txtconce.CustomButton.Visible = False
        Me.txtconce.Enabled = False
        Me.txtconce.Lines = New String(-1) {}
        Me.txtconce.Location = New System.Drawing.Point(350, 205)
        Me.txtconce.MaxLength = 32767
        Me.txtconce.Name = "txtconce"
        Me.txtconce.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtconce.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtconce.SelectedText = ""
        Me.txtconce.SelectionLength = 0
        Me.txtconce.SelectionStart = 0
        Me.txtconce.ShortcutsEnabled = True
        Me.txtconce.Size = New System.Drawing.Size(79, 20)
        Me.txtconce.Style = MetroFramework.MetroColorStyle.Orange
        Me.txtconce.TabIndex = 5
        Me.txtconce.UseSelectable = True
        Me.txtconce.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtconce.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txttemp
        '
        '
        '
        '
        Me.txttemp.CustomButton.Image = Nothing
        Me.txttemp.CustomButton.Location = New System.Drawing.Point(61, 2)
        Me.txttemp.CustomButton.Name = ""
        Me.txttemp.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txttemp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttemp.CustomButton.TabIndex = 1
        Me.txttemp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttemp.CustomButton.UseSelectable = True
        Me.txttemp.CustomButton.Visible = False
        Me.txttemp.Enabled = False
        Me.txttemp.Lines = New String(-1) {}
        Me.txttemp.Location = New System.Drawing.Point(350, 231)
        Me.txttemp.MaxLength = 32767
        Me.txttemp.Name = "txttemp"
        Me.txttemp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttemp.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttemp.SelectedText = ""
        Me.txttemp.SelectionLength = 0
        Me.txttemp.SelectionStart = 0
        Me.txttemp.ShortcutsEnabled = True
        Me.txttemp.Size = New System.Drawing.Size(79, 20)
        Me.txttemp.Style = MetroFramework.MetroColorStyle.Orange
        Me.txttemp.TabIndex = 6
        Me.txttemp.UseSelectable = True
        Me.txttemp.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttemp.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chktemp
        '
        Me.chktemp.AutoSize = True
        Me.chktemp.ForeColor = System.Drawing.Color.Black
        Me.chktemp.Location = New System.Drawing.Point(203, 236)
        Me.chktemp.Name = "chktemp"
        Me.chktemp.Size = New System.Drawing.Size(91, 15)
        Me.chktemp.Style = MetroFramework.MetroColorStyle.Orange
        Me.chktemp.TabIndex = 8
        Me.chktemp.Text = "Temperatura"
        Me.chktemp.UseSelectable = True
        '
        'rbcuba1
        '
        Me.rbcuba1.AutoSize = True
        Me.rbcuba1.Checked = True
        Me.rbcuba1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbcuba1.Location = New System.Drawing.Point(234, 137)
        Me.rbcuba1.Name = "rbcuba1"
        Me.rbcuba1.Size = New System.Drawing.Size(60, 15)
        Me.rbcuba1.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbcuba1.TabIndex = 2
        Me.rbcuba1.TabStop = True
        Me.rbcuba1.Text = "Cuba 1"
        Me.rbcuba1.UseSelectable = True
        '
        'rbcuba2
        '
        Me.rbcuba2.AutoSize = True
        Me.rbcuba2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbcuba2.Location = New System.Drawing.Point(312, 137)
        Me.rbcuba2.Name = "rbcuba2"
        Me.rbcuba2.Size = New System.Drawing.Size(60, 15)
        Me.rbcuba2.Style = MetroFramework.MetroColorStyle.Orange
        Me.rbcuba2.TabIndex = 3
        Me.rbcuba2.Text = "Cuba 2"
        Me.rbcuba2.UseSelectable = True
        '
        'LAVSoda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 528)
        Me.Controls.Add(Me.rbcuba2)
        Me.Controls.Add(Me.rbcuba1)
        Me.Controls.Add(Me.txttemp)
        Me.Controls.Add(Me.chktemp)
        Me.Controls.Add(Me.txtconce)
        Me.Controls.Add(Me.txtsoda)
        Me.Controls.Add(Me.chkconce)
        Me.Controls.Add(Me.chksoda)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Name = "LAVSoda"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Preparación y Control de Soda Cáustica"
        Me.TabControl1.ResumeLayout(False)
        Me.tpLimp.ResumeLayout(False)
        CType(Me.dgIng, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabControl1 As MetroTabControl
    Friend WithEvents tpLimp As MetroTabPage
    Friend WithEvents chksoda As MetroCheckBox
    Friend WithEvents chkconce As MetroCheckBox
    Friend WithEvents txtsoda As MetroTextBox
    Friend WithEvents txtconce As MetroTextBox
    Friend WithEvents txttemp As MetroTextBox
    Friend WithEvents chktemp As MetroCheckBox
    Friend WithEvents rbcuba1 As MetroRadioButton
    Friend WithEvents rbcuba2 As MetroRadioButton
    Friend WithEvents dgIng As MetroGrid
End Class
