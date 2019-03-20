Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class McLimpCVVac
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
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.chk2 = New MetroFramework.Controls.MetroCheckBox()
        Me.chk3 = New MetroFramework.Controls.MetroCheckBox()
        Me.chk4 = New MetroFramework.Controls.MetroCheckBox()
        Me.chk5 = New MetroFramework.Controls.MetroCheckBox()
        Me.Panel1 = New MetroFramework.Controls.MetroPanel()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.txtmc = New MetroFramework.Controls.MetroTextBox()
        Me.dg = New MetroFramework.Controls.MetroGrid()
        Me.Panel1.SuspendLayout()
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
        Me.cbturno.Location = New System.Drawing.Point(232, 88)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(63, 25)
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
        Me.cbgrupo.Location = New System.Drawing.Point(232, 119)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(63, 25)
        Me.cbgrupo.TabIndex = 2
        Me.cbgrupo.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(180, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(180, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(166, 204)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(268, 204)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 3
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'dtfecha
        '
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(103, 249)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(91, 25)
        Me.dtfecha.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(37, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(180, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "MC:"
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chk2.Location = New System.Drawing.Point(79, 14)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(29, 15)
        Me.chk2.TabIndex = 0
        Me.chk2.Text = "2"
        Me.chk2.UseSelectable = True
        '
        'chk3
        '
        Me.chk3.AutoSize = True
        Me.chk3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chk3.Location = New System.Drawing.Point(114, 14)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(29, 15)
        Me.chk3.TabIndex = 1
        Me.chk3.Text = "3"
        Me.chk3.UseSelectable = True
        '
        'chk4
        '
        Me.chk4.AutoSize = True
        Me.chk4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chk4.Location = New System.Drawing.Point(149, 14)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New System.Drawing.Size(29, 15)
        Me.chk4.TabIndex = 2
        Me.chk4.Text = "4"
        Me.chk4.UseSelectable = True
        '
        'chk5
        '
        Me.chk5.AutoSize = True
        Me.chk5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chk5.Location = New System.Drawing.Point(184, 14)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New System.Drawing.Size(29, 15)
        Me.chk5.TabIndex = 3
        Me.chk5.Text = "5"
        Me.chk5.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.chk5)
        Me.Panel1.Controls.Add(Me.chk2)
        Me.Panel1.Controls.Add(Me.chk4)
        Me.Panel1.Controls.Add(Me.chk3)
        Me.Panel1.HorizontalScrollbarBarColor = True
        Me.Panel1.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel1.HorizontalScrollbarSize = 10
        Me.Panel1.Location = New System.Drawing.Point(115, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 40)
        Me.Panel1.TabIndex = 39
        Me.Panel1.VerticalScrollbarBarColor = True
        Me.Panel1.VerticalScrollbarHighlightOnWheel = False
        Me.Panel1.VerticalScrollbarSize = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(4, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 19)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Vacío:"
        '
        'txtmc
        '
        '
        '
        '
        Me.txtmc.CustomButton.Image = Nothing
        Me.txtmc.CustomButton.Location = New System.Drawing.Point(35, 2)
        Me.txtmc.CustomButton.Name = ""
        Me.txtmc.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtmc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtmc.CustomButton.TabIndex = 1
        Me.txtmc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtmc.CustomButton.UseSelectable = True
        Me.txtmc.CustomButton.Visible = False
        Me.txtmc.Lines = New String() {"2"}
        Me.txtmc.Location = New System.Drawing.Point(234, 62)
        Me.txtmc.MaxLength = 32767
        Me.txtmc.Name = "txtmc"
        Me.txtmc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmc.ReadOnly = True
        Me.txtmc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtmc.SelectedText = ""
        Me.txtmc.SelectionLength = 0
        Me.txtmc.SelectionStart = 0
        Me.txtmc.ShortcutsEnabled = True
        Me.txtmc.Size = New System.Drawing.Size(53, 20)
        Me.txtmc.TabIndex = 0
        Me.txtmc.Text = "2"
        Me.txtmc.UseSelectable = True
        Me.txtmc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtmc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.dg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dg.EnableHeadersVisualStyles = False
        Me.dg.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dg.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.Location = New System.Drawing.Point(5, 280)
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
        Me.dg.Size = New System.Drawing.Size(465, 152)
        Me.dg.Style = MetroFramework.MetroColorStyle.Teal
        Me.dg.TabIndex = 43
        Me.dg.UseCustomBackColor = True
        Me.dg.UseCustomForeColor = True
        Me.dg.UseStyleColors = True
        '
        'McLimpCVVac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 437)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtmc)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.cbturno)
        Me.Name = "McLimpCVVac"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Limpieza de Cañerias y válvulas de Vacíos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents chk2 As MetroCheckBox
    Friend WithEvents chk3 As MetroCheckBox
    Friend WithEvents chk4 As MetroCheckBox
    Friend WithEvents chk5 As MetroCheckBox
    Friend WithEvents Panel1 As MetroPanel
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents txtmc As MetroTextBox
    Friend WithEvents dg As MetroGrid
End Class
