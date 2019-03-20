Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LAVREPARACION
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.dg = New MetroFramework.Controls.MetroGrid()
        Me.TabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.dgInox = New MetroFramework.Controls.MetroGrid()
        Me.gbInox = New System.Windows.Forms.GroupBox()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.chkmot = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgInox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(5, 63)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 1
        Me.TabControl1.Size = New System.Drawing.Size(629, 328)
        Me.TabControl1.Style = MetroFramework.MetroColorStyle.Orange
        Me.TabControl1.TabIndex = 57
        Me.TabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.SkyBlue
        Me.TabPage1.Controls.Add(Me.dg)
        Me.TabPage1.HorizontalScrollbarBarColor = True
        Me.TabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage1.HorizontalScrollbarSize = 10
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(621, 286)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tejido Doble Hilado"
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
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
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
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg.RowHeadersVisible = False
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(615, 280)
        Me.dg.Style = MetroFramework.MetroColorStyle.Orange
        Me.dg.TabIndex = 73
        Me.dg.UseCustomBackColor = True
        Me.dg.UseCustomForeColor = True
        Me.dg.UseStyleColors = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.SkyBlue
        Me.TabPage2.Controls.Add(Me.dgInox)
        Me.TabPage2.Controls.Add(Me.gbInox)
        Me.TabPage2.HorizontalScrollbarBarColor = True
        Me.TabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage2.HorizontalScrollbarSize = 10
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(621, 286)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Chapa Inoxidable"
        Me.TabPage2.UseVisualStyleBackColor = True
        Me.TabPage2.VerticalScrollbarBarColor = True
        Me.TabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage2.VerticalScrollbarSize = 10
        '
        'dgInox
        '
        Me.dgInox.AllowUserToAddRows = False
        Me.dgInox.AllowUserToDeleteRows = False
        Me.dgInox.AllowUserToResizeColumns = False
        Me.dgInox.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender
        Me.dgInox.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgInox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgInox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgInox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgInox.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInox.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgInox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInox.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgInox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgInox.EnableHeadersVisualStyles = False
        Me.dgInox.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgInox.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInox.Location = New System.Drawing.Point(3, 3)
        Me.dgInox.MultiSelect = False
        Me.dgInox.Name = "dgInox"
        Me.dgInox.ReadOnly = True
        Me.dgInox.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInox.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgInox.RowHeadersVisible = False
        Me.dgInox.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgInox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInox.Size = New System.Drawing.Size(417, 280)
        Me.dgInox.Style = MetroFramework.MetroColorStyle.Orange
        Me.dgInox.TabIndex = 72
        Me.dgInox.UseCustomBackColor = True
        Me.dgInox.UseCustomForeColor = True
        Me.dgInox.UseStyleColors = True
        '
        'gbInox
        '
        Me.gbInox.BackColor = System.Drawing.Color.Gainsboro
        Me.gbInox.Controls.Add(Me.btnAceptar)
        Me.gbInox.Controls.Add(Me.chkmot)
        Me.gbInox.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbInox.ForeColor = Color.Black
        Me.gbInox.Location = New System.Drawing.Point(420, 3)
        Me.gbInox.Name = "gbInox"
        Me.gbInox.Size = New System.Drawing.Size(198, 280)
        Me.gbInox.TabIndex = 4
        Me.gbInox.TabStop = False
        Me.gbInox.Text = "Indicar Reparación"
        '
        'btnAceptar
        '
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceptar.Location = New System.Drawing.Point(15, 186)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(157, 36)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseSelectable = True
        '
        'chkmot
        '
        Me.chkmot.FormattingEnabled = True
        Me.chkmot.Location = New System.Drawing.Point(15, 26)
        Me.chkmot.Name = "chkmot"
        Me.chkmot.Size = New System.Drawing.Size(157, 154)
        Me.chkmot.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(237, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 25)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Hacer doble click para indicar reparación"
        '
        'LAVREPARACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 396)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "LAVREPARACION"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Reparaciones"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgInox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As MetroTabControl
    Friend WithEvents TabPage1 As MetroTabPage
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents TabPage2 As MetroTabPage
    Friend WithEvents chkmot As System.Windows.Forms.CheckedListBox
    Friend WithEvents gbInox As System.Windows.Forms.GroupBox
    Friend WithEvents btnAceptar As MetroButton
    Friend WithEvents dg As MetroGrid
    Friend WithEvents dgInox As MetroGrid
End Class
