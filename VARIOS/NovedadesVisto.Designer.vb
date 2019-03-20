Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovedadesVisto
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
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.btnver = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.cbmotivo = New MetroFramework.Controls.MetroComboBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.cbsector = New MetroFramework.Controls.MetroComboBox()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.chktodos = New MetroFramework.Controls.MetroCheckBox()
        Me.tpnov = New MetroFramework.Controls.MetroTabPage()
        Me.dg = New MetroFramework.Controls.MetroGrid()
        Me.tabcontrol = New MetroFramework.Controls.MetroTabControl()
        Me.tpnov.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabcontrol.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtfecha
        '
        Me.dtfecha.CalendarFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfecha.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(121, 136)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(91, 22)
        Me.dtfecha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(45, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desde"
        '
        'btnver
        '
        Me.btnver.Location = New System.Drawing.Point(121, 233)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(75, 23)
        Me.btnver.TabIndex = 5
        Me.btnver.Text = "Ver"
        Me.btnver.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(43, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Área"
        '
        'cbmotivo
        '
        Me.cbmotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmotivo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbmotivo.FormattingEnabled = True
        Me.cbmotivo.ItemHeight = 19
        Me.cbmotivo.Location = New System.Drawing.Point(121, 194)
        Me.cbmotivo.Name = "cbmotivo"
        Me.cbmotivo.Size = New System.Drawing.Size(117, 25)
        Me.cbmotivo.TabIndex = 4
        Me.cbmotivo.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(45, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Motivo"
        '
        'cbsector
        '
        Me.cbsector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbsector.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbsector.FormattingEnabled = True
        Me.cbsector.ItemHeight = 19
        Me.cbsector.Location = New System.Drawing.Point(121, 78)
        Me.cbsector.Name = "cbsector"
        Me.cbsector.Size = New System.Drawing.Size(121, 25)
        Me.cbsector.TabIndex = 0
        Me.cbsector.UseSelectable = True
        '
        'dthasta
        '
        Me.dthasta.CalendarFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dthasta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dthasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dthasta.Location = New System.Drawing.Point(121, 162)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(91, 22)
        Me.dthasta.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(45, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 19)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Hasta"
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chktodos.Location = New System.Drawing.Point(121, 109)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(102, 15)
        Me.chktodos.TabIndex = 1
        Me.chktodos.Text = "Todas las áreas"
        Me.chktodos.UseSelectable = True
        '
        'tpnov
        '
        Me.tpnov.Controls.Add(Me.dg)
        Me.tpnov.HorizontalScrollbarBarColor = True
        Me.tpnov.HorizontalScrollbarHighlightOnWheel = False
        Me.tpnov.HorizontalScrollbarSize = 10
        Me.tpnov.Location = New System.Drawing.Point(4, 38)
        Me.tpnov.Name = "tpnov"
        Me.tpnov.Padding = New System.Windows.Forms.Padding(3)
        Me.tpnov.Size = New System.Drawing.Size(842, 276)
        Me.tpnov.TabIndex = 0
        Me.tpnov.Text = "Novedades"
        Me.tpnov.VerticalScrollbarBarColor = True
        Me.tpnov.VerticalScrollbarHighlightOnWheel = False
        Me.tpnov.VerticalScrollbarSize = 10
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
        Me.dg.Size = New System.Drawing.Size(836, 270)
        Me.dg.TabIndex = 80
        Me.dg.UseCustomBackColor = True
        Me.dg.UseCustomForeColor = True
        Me.dg.UseStyleColors = True
        '
        'tabcontrol
        '
        Me.tabcontrol.Controls.Add(Me.tpnov)
        Me.tabcontrol.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabcontrol.Location = New System.Drawing.Point(5, 268)
        Me.tabcontrol.Name = "tabcontrol"
        Me.tabcontrol.SelectedIndex = 0
        Me.tabcontrol.Size = New System.Drawing.Size(850, 318)
        Me.tabcontrol.TabIndex = 34
        Me.tabcontrol.UseSelectable = True
        '
        'NovedadesVisto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 591)
        Me.Controls.Add(Me.chktodos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dthasta)
        Me.Controls.Add(Me.cbsector)
        Me.Controls.Add(Me.tabcontrol)
        Me.Controls.Add(Me.cbmotivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtfecha)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NovedadesVisto"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Text = "Visualización de novedades"
        Me.tpnov.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabcontrol.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents btnver As MetroButton
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents cbmotivo As MetroComboBox
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents cbsector As MetroComboBox
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents chktodos As MetroCheckBox
    Friend WithEvents tpnov As MetroTabPage
    Friend WithEvents tabcontrol As MetroTabControl
    Friend WithEvents dg As MetroGrid
End Class
