Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class McCuchillas
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbmc = New MetroFramework.Controls.MetroComboBox()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.lblrio = New MetroFramework.Controls.MetroLabel()
        Me.cbplaya = New MetroFramework.Controls.MetroComboBox()
        Me.chktransversal = New MetroFramework.Controls.MetroCheckBox()
        Me.chkplaya = New MetroFramework.Controls.MetroCheckBox()
        Me.chkrio = New MetroFramework.Controls.MetroCheckBox()
        Me.cbrio = New MetroFramework.Controls.MetroComboBox()
        Me.cbtrans = New MetroFramework.Controls.MetroComboBox()
        Me.lbltrans = New MetroFramework.Controls.MetroLabel()
        Me.lblplaya = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.dtfecha = New MetroFramework.Controls.MetroDateTime()
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
        Me.cbmc.Location = New System.Drawing.Point(128, 105)
        Me.cbmc.Name = "cbmc"
        Me.cbmc.Size = New System.Drawing.Size(77, 25)
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
        Me.cbturno.Location = New System.Drawing.Point(128, 131)
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
        Me.cbgrupo.Location = New System.Drawing.Point(128, 157)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(77, 25)
        Me.cbgrupo.TabIndex = 2
        Me.cbgrupo.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(73, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "MC:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(73, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(73, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Grupo:"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(76, 286)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 10
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(184, 286)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 9
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseSelectable = True
        '
        'lblrio
        '
        Me.lblrio.AutoSize = True
        Me.lblrio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblrio.Location = New System.Drawing.Point(141, 226)
        Me.lblrio.Name = "lblrio"
        Me.lblrio.Size = New System.Drawing.Size(53, 19)
        Me.lblrio.TabIndex = 30
        Me.lblrio.Text = "Motivo:"
        Me.lblrio.Visible = False
        '
        'cbplaya
        '
        Me.cbplaya.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbplaya.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbplaya.FormattingEnabled = True
        Me.cbplaya.ItemHeight = 19
        Me.cbplaya.Items.AddRange(New Object() {"Desgaste", "Deformada", "Golpe"})
        Me.cbplaya.Location = New System.Drawing.Point(28, 248)
        Me.cbplaya.Name = "cbplaya"
        Me.cbplaya.Size = New System.Drawing.Size(81, 25)
        Me.cbplaya.TabIndex = 4
        Me.cbplaya.UseSelectable = True
        Me.cbplaya.Visible = False
        '
        'chktransversal
        '
        Me.chktransversal.AutoSize = True
        Me.chktransversal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chktransversal.Location = New System.Drawing.Point(223, 201)
        Me.chktransversal.Name = "chktransversal"
        Me.chktransversal.Size = New System.Drawing.Size(82, 15)
        Me.chktransversal.TabIndex = 7
        Me.chktransversal.Text = "Transversal"
        Me.chktransversal.UseSelectable = True
        '
        'chkplaya
        '
        Me.chkplaya.AutoSize = True
        Me.chkplaya.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkplaya.Location = New System.Drawing.Point(28, 201)
        Me.chkplaya.Name = "chkplaya"
        Me.chkplaya.Size = New System.Drawing.Size(80, 15)
        Me.chkplaya.TabIndex = 3
        Me.chkplaya.Text = "Lado Playa"
        Me.chkplaya.UseSelectable = True
        '
        'chkrio
        '
        Me.chkrio.AutoSize = True
        Me.chkrio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkrio.Location = New System.Drawing.Point(124, 201)
        Me.chkrio.Name = "chkrio"
        Me.chkrio.Size = New System.Drawing.Size(69, 15)
        Me.chkrio.TabIndex = 5
        Me.chkrio.Text = "Lado Río"
        Me.chkrio.UseSelectable = True
        '
        'cbrio
        '
        Me.cbrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbrio.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbrio.FormattingEnabled = True
        Me.cbrio.ItemHeight = 19
        Me.cbrio.Items.AddRange(New Object() {"Desgaste", "Deformada", "Golpe"})
        Me.cbrio.Location = New System.Drawing.Point(124, 248)
        Me.cbrio.Name = "cbrio"
        Me.cbrio.Size = New System.Drawing.Size(81, 25)
        Me.cbrio.TabIndex = 6
        Me.cbrio.UseSelectable = True
        Me.cbrio.Visible = False
        '
        'cbtrans
        '
        Me.cbtrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbtrans.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbtrans.FormattingEnabled = True
        Me.cbtrans.ItemHeight = 19
        Me.cbtrans.Items.AddRange(New Object() {"Desgaste", "Deformada", "Golpe"})
        Me.cbtrans.Location = New System.Drawing.Point(223, 248)
        Me.cbtrans.Name = "cbtrans"
        Me.cbtrans.Size = New System.Drawing.Size(81, 25)
        Me.cbtrans.TabIndex = 8
        Me.cbtrans.UseSelectable = True
        Me.cbtrans.Visible = False
        '
        'lbltrans
        '
        Me.lbltrans.AutoSize = True
        Me.lbltrans.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltrans.Location = New System.Drawing.Point(241, 226)
        Me.lbltrans.Name = "lbltrans"
        Me.lbltrans.Size = New System.Drawing.Size(53, 19)
        Me.lbltrans.TabIndex = 36
        Me.lbltrans.Text = "Motivo:"
        Me.lbltrans.Visible = False
        '
        'lblplaya
        '
        Me.lblplaya.AutoSize = True
        Me.lblplaya.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblplaya.Location = New System.Drawing.Point(44, 226)
        Me.lblplaya.Name = "lblplaya"
        Me.lblplaya.Size = New System.Drawing.Size(53, 19)
        Me.lblplaya.TabIndex = 37
        Me.lblplaya.Text = "Motivo:"
        Me.lblplaya.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(347, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 19)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Fecha:"
        '
        'dtfecha
        '
        Me.dtfecha.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(399, 76)
        Me.dtfecha.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(107, 25)
        Me.dtfecha.TabIndex = 11
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
        Me.dg.Location = New System.Drawing.Point(347, 111)
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
        Me.dg.Size = New System.Drawing.Size(389, 162)
        Me.dg.Style = MetroFramework.MetroColorStyle.Teal
        Me.dg.TabIndex = 41
        Me.dg.UseCustomBackColor = True
        '
        'McCuchillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 330)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.lblplaya)
        Me.Controls.Add(Me.lbltrans)
        Me.Controls.Add(Me.cbtrans)
        Me.Controls.Add(Me.cbrio)
        Me.Controls.Add(Me.chkrio)
        Me.Controls.Add(Me.chkplaya)
        Me.Controls.Add(Me.chktransversal)
        Me.Controls.Add(Me.lblrio)
        Me.Controls.Add(Me.cbplaya)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.cbmc)
        Me.Name = "McCuchillas"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cambio de Cuchillas"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbmc As MetroComboBox
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents lblrio As MetroLabel
    Friend WithEvents cbplaya As MetroComboBox
    Friend WithEvents chktransversal As MetroCheckBox
    Friend WithEvents chkplaya As MetroCheckBox
    Friend WithEvents chkrio As MetroCheckBox
    Friend WithEvents cbrio As MetroComboBox
    Friend WithEvents cbtrans As MetroComboBox
    Friend WithEvents lbltrans As MetroLabel
    Friend WithEvents lblplaya As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents dtfecha As MetroDateTime
    Friend WithEvents dg As MetroGrid
End Class
