Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LAVLimpCubas
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
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tpLimp = New MetroFramework.Controls.MetroTabPage()
        Me.dgIng = New MetroFramework.Controls.MetroGrid()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.chk1 = New MetroFramework.Controls.MetroCheckBox()
        Me.chk2 = New MetroFramework.Controls.MetroCheckBox()
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
        Me.cbturno.Location = New System.Drawing.Point(168, 59)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(53, 25)
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
        Me.cbgrupo.Location = New System.Drawing.Point(168, 95)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(53, 25)
        Me.cbgrupo.Style = MetroFramework.MetroColorStyle.Orange
        Me.cbgrupo.TabIndex = 1
        Me.cbgrupo.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(92, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(92, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(104, 176)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 5
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(194, 176)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 4
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpLimp)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(5, 231)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(382, 147)
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
        Me.tpLimp.Size = New System.Drawing.Size(374, 105)
        Me.tpLimp.TabIndex = 0
        Me.tpLimp.Text = "Limpieza"
        Me.tpLimp.UseVisualStyleBackColor = True
        Me.tpLimp.VerticalScrollbarBarColor = True
        Me.tpLimp.VerticalScrollbarHighlightOnWheel = False
        Me.tpLimp.VerticalScrollbarSize = 10
        '
        'dgIng
        '
        Me.dgIng.AllowUserToAddRows = False
        Me.dgIng.AllowUserToDeleteRows = False
        Me.dgIng.AllowUserToResizeRows = False
        Me.dgIng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgIng.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgIng.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgIng.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgIng.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgIng.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgIng.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgIng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgIng.EnableHeadersVisualStyles = False
        Me.dgIng.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgIng.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgIng.Location = New System.Drawing.Point(3, 3)
        Me.dgIng.MultiSelect = False
        Me.dgIng.Name = "dgIng"
        Me.dgIng.ReadOnly = True
        Me.dgIng.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgIng.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgIng.RowHeadersVisible = False
        Me.dgIng.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgIng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgIng.Size = New System.Drawing.Size(368, 99)
        Me.dgIng.Style = MetroFramework.MetroColorStyle.Orange
        Me.dgIng.TabIndex = 4
        Me.dgIng.UseCustomBackColor = True
        Me.dgIng.UseCustomForeColor = True
        Me.dgIng.UseStyleColors = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(14, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 19)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Fecha para búsqueda:"
        '
        'dtfecha
        '
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(194, 208)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(80, 20)
        Me.dtfecha.TabIndex = 6
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk1.Location = New System.Drawing.Point(153, 130)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(60, 15)
        Me.chk1.Style = MetroFramework.MetroColorStyle.Orange
        Me.chk1.TabIndex = 2
        Me.chk1.Text = "Cuba 1"
        Me.chk1.UseSelectable = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chk2.Location = New System.Drawing.Point(153, 153)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(60, 15)
        Me.chk2.Style = MetroFramework.MetroColorStyle.Orange
        Me.chk2.TabIndex = 3
        Me.chk2.Text = "Cuba 2"
        Me.chk2.UseSelectable = True
        '
        'LAVLimpCubas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 383)
        Me.Controls.Add(Me.chk2)
        Me.Controls.Add(Me.chk1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LAVLimpCubas"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Limpieza de Cubas"
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
    Friend WithEvents chk1 As MetroCheckBox
    Friend WithEvents chk2 As MetroCheckBox
    Friend WithEvents dgIng As MetroGrid
End Class
