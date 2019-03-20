Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class McTelas
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
        Me.cbtela = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.Label15 = New MetroFramework.Controls.MetroLabel()
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
        Me.cbrazon = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.txtprov = New MetroFramework.Controls.MetroTextBox()
        Me.txtndetela = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.dg = New MetroFramework.Controls.MetroGrid()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbmc
        '
        Me.cbmc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmc.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmc.FormattingEnabled = True
        Me.cbmc.ItemHeight = 19
        Me.cbmc.Items.AddRange(New Object() {"1", "2"})
        Me.cbmc.Location = New System.Drawing.Point(47, 82)
        Me.cbmc.Name = "cbmc"
        Me.cbmc.Size = New System.Drawing.Size(56, 25)
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
        Me.cbturno.Location = New System.Drawing.Point(136, 82)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(58, 25)
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
        Me.cbgrupo.Location = New System.Drawing.Point(240, 82)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(58, 25)
        Me.cbgrupo.TabIndex = 2
        Me.cbgrupo.UseSelectable = True
        '
        'cbtela
        '
        Me.cbtela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbtela.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbtela.FormattingEnabled = True
        Me.cbtela.ItemHeight = 19
        Me.cbtela.Location = New System.Drawing.Point(347, 82)
        Me.cbtela.Name = "cbtela"
        Me.cbtela.Size = New System.Drawing.Size(102, 25)
        Me.cbtela.TabIndex = 3
        Me.cbtela.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(61, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "MC:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(148, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(249, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(376, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Tela:"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(240, 173)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 8
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(321, 173)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 7
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(11, 231)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 19)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Fecha:"
        '
        'dtfecha
        '
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(61, 225)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(87, 25)
        Me.dtfecha.TabIndex = 9
        '
        'cbrazon
        '
        Me.cbrazon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbrazon.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbrazon.FormattingEnabled = True
        Me.cbrazon.ItemHeight = 19
        Me.cbrazon.Items.AddRange(New Object() {"Fin de vida útil", "Tapada", "Rotura", "Otro"})
        Me.cbrazon.Location = New System.Drawing.Point(46, 130)
        Me.cbrazon.Name = "cbrazon"
        Me.cbrazon.Size = New System.Drawing.Size(113, 25)
        Me.cbrazon.TabIndex = 4
        Me.cbrazon.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(78, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 19)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Razón:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(202, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 19)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Proveedor:"
        '
        'txtprov
        '
        '
        '
        '
        Me.txtprov.CustomButton.Image = Nothing
        Me.txtprov.CustomButton.Location = New System.Drawing.Point(110, 2)
        Me.txtprov.CustomButton.Name = ""
        Me.txtprov.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtprov.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtprov.CustomButton.TabIndex = 1
        Me.txtprov.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtprov.CustomButton.UseSelectable = True
        Me.txtprov.CustomButton.Visible = False
        Me.txtprov.Lines = New String(-1) {}
        Me.txtprov.Location = New System.Drawing.Point(176, 132)
        Me.txtprov.MaxLength = 32767
        Me.txtprov.Name = "txtprov"
        Me.txtprov.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprov.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtprov.SelectedText = ""
        Me.txtprov.SelectionLength = 0
        Me.txtprov.SelectionStart = 0
        Me.txtprov.ShortcutsEnabled = True
        Me.txtprov.Size = New System.Drawing.Size(128, 20)
        Me.txtprov.TabIndex = 5
        Me.txtprov.UseSelectable = True
        Me.txtprov.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtprov.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtndetela
        '
        '
        '
        '
        Me.txtndetela.CustomButton.Image = Nothing
        Me.txtndetela.CustomButton.Location = New System.Drawing.Point(110, 2)
        Me.txtndetela.CustomButton.Name = ""
        Me.txtndetela.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtndetela.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtndetela.CustomButton.TabIndex = 1
        Me.txtndetela.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtndetela.CustomButton.UseSelectable = True
        Me.txtndetela.CustomButton.Visible = False
        Me.txtndetela.Lines = New String(-1) {}
        Me.txtndetela.Location = New System.Drawing.Point(321, 132)
        Me.txtndetela.MaxLength = 32767
        Me.txtndetela.Name = "txtndetela"
        Me.txtndetela.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtndetela.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtndetela.SelectedText = ""
        Me.txtndetela.SelectionLength = 0
        Me.txtndetela.SelectionStart = 0
        Me.txtndetela.ShortcutsEnabled = True
        Me.txtndetela.Size = New System.Drawing.Size(128, 20)
        Me.txtndetela.TabIndex = 6
        Me.txtndetela.UseSelectable = True
        Me.txtndetela.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtndetela.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(348, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 19)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Nº de Tela:"
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
        Me.dg.Location = New System.Drawing.Point(5, 256)
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
        Me.dg.Size = New System.Drawing.Size(489, 143)
        Me.dg.Style = MetroFramework.MetroColorStyle.Teal
        Me.dg.TabIndex = 51
        Me.dg.UseCustomBackColor = True
        Me.dg.UseCustomForeColor = True
        Me.dg.UseStyleColors = True
        '
        'McTelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 404)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtndetela)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtprov)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbrazon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbtela)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.cbmc)
        Me.Name = "McTelas"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cambio de telas"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbmc As MetroComboBox
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents cbtela As MetroComboBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents Label15 As MetroLabel
    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents cbrazon As MetroComboBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents txtprov As MetroTextBox
    Friend WithEvents txtndetela As MetroTextBox
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents dg As MetroGrid
End Class
