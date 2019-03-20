Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mchipoclorito
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
        Me.txtlt = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cblinea = New MetroFramework.Controls.MetroComboBox()
        Me.dg = New MetroFramework.Controls.MetroGrid()
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
        Me.cbturno.Location = New System.Drawing.Point(145, 83)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(77, 25)
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
        Me.cbgrupo.Location = New System.Drawing.Point(258, 83)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(62, 25)
        Me.cbgrupo.TabIndex = 2
        Me.cbgrupo.UseSelectable = True
        '
        'txtlt
        '
        '
        '
        '
        Me.txtlt.CustomButton.Image = Nothing
        Me.txtlt.CustomButton.Location = New System.Drawing.Point(59, 2)
        Me.txtlt.CustomButton.Name = ""
        Me.txtlt.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtlt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtlt.CustomButton.TabIndex = 1
        Me.txtlt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtlt.CustomButton.UseSelectable = True
        Me.txtlt.CustomButton.Visible = False
        Me.txtlt.Lines = New String(-1) {}
        Me.txtlt.Location = New System.Drawing.Point(145, 133)
        Me.txtlt.MaxLength = 32767
        Me.txtlt.Name = "txtlt"
        Me.txtlt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtlt.SelectedText = ""
        Me.txtlt.SelectionLength = 0
        Me.txtlt.SelectionStart = 0
        Me.txtlt.ShortcutsEnabled = True
        Me.txtlt.Size = New System.Drawing.Size(77, 20)
        Me.txtlt.TabIndex = 3
        Me.txtlt.UseSelectable = True
        Me.txtlt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtlt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(142, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(256, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(103, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Cant. Agregada (lt):"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(179, 168)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 5
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(271, 168)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 4
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'dtfecha
        '
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(86, 201)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(90, 25)
        Me.dtfecha.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(17, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(39, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Línea:"
        '
        'cblinea
        '
        Me.cblinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cblinea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cblinea.FormattingEnabled = True
        Me.cblinea.ItemHeight = 19
        Me.cblinea.Items.AddRange(New Object() {"1", "2"})
        Me.cblinea.Location = New System.Drawing.Point(41, 83)
        Me.cblinea.Name = "cblinea"
        Me.cblinea.Size = New System.Drawing.Size(64, 25)
        Me.cblinea.TabIndex = 0
        Me.cblinea.UseSelectable = True
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
        Me.dg.EnableHeadersVisualStyles = False
        Me.dg.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dg.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.Location = New System.Drawing.Point(8, 232)
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
        Me.dg.Size = New System.Drawing.Size(338, 138)
        Me.dg.Style = MetroFramework.MetroColorStyle.Teal
        Me.dg.TabIndex = 42
        Me.dg.UseCustomBackColor = True
        Me.dg.UseCustomForeColor = True
        Me.dg.UseStyleColors = True
        '
        'Mchipoclorito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 387)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cblinea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtlt)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.cbturno)
        Me.Name = "Mchipoclorito"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Hipoclorito"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents txtlt As MetroTextBox
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents cblinea As MetroComboBox
    Friend WithEvents dg As MetroGrid
End Class
