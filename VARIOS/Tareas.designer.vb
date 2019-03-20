Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tareas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tareas))
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New MetroFramework.Controls.MetroPanel()
        Me.txtrepeticiones = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New MetroFramework.Controls.MetroPanel()
        Me.lbldd = New MetroFramework.Controls.MetroLabel()
        Me.txtdias = New MetroFramework.Controls.MetroTextBox()
        Me.rbdias = New MetroFramework.Controls.MetroRadioButton()
        Me.rbanual = New MetroFramework.Controls.MetroRadioButton()
        Me.rbmensual = New MetroFramework.Controls.MetroRadioButton()
        Me.rbsemanal = New MetroFramework.Controls.MetroRadioButton()
        Me.rbdiario = New MetroFramework.Controls.MetroRadioButton()
        Me.lbldia = New MetroFramework.Controls.MetroLabel()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.btncargar = New MetroFramework.Controls.MetroButton()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txtdesc = New MetroFramework.Controls.MetroTextBox()
        Me.txttarea = New MetroFramework.Controls.MetroTextBox()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.cbarea = New MetroFramework.Controls.MetroComboBox()
        Me.txtemi = New MetroFramework.Controls.MetroTextBox()
        Me.txtid = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(568, 104)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(112, 20)
        Me.dtp.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.rbanual)
        Me.GroupBox1.Controls.Add(Me.rbmensual)
        Me.GroupBox1.Controls.Add(Me.rbsemanal)
        Me.GroupBox1.Controls.Add(Me.rbdiario)
        Me.GroupBox1.ForeColor = Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(358, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 176)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Periodicidad"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtrepeticiones)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.HorizontalScrollbarBarColor = True
        Me.Panel2.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel2.HorizontalScrollbarSize = 10
        Me.Panel2.Location = New System.Drawing.Point(120, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(336, 32)
        Me.Panel2.TabIndex = 10
        Me.Panel2.VerticalScrollbarBarColor = True
        Me.Panel2.VerticalScrollbarHighlightOnWheel = False
        Me.Panel2.VerticalScrollbarSize = 10
        '
        'txtrepeticiones
        '
        '
        '
        '
        Me.txtrepeticiones.CustomButton.Image = Nothing
        Me.txtrepeticiones.CustomButton.Location = New System.Drawing.Point(22, 2)
        Me.txtrepeticiones.CustomButton.Name = ""
        Me.txtrepeticiones.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtrepeticiones.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtrepeticiones.CustomButton.TabIndex = 1
        Me.txtrepeticiones.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtrepeticiones.CustomButton.UseSelectable = True
        Me.txtrepeticiones.CustomButton.Visible = False
        Me.txtrepeticiones.Lines = New String() {"0"}
        Me.txtrepeticiones.Location = New System.Drawing.Point(177, 7)
        Me.txtrepeticiones.MaxLength = 32767
        Me.txtrepeticiones.Name = "txtrepeticiones"
        Me.txtrepeticiones.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrepeticiones.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtrepeticiones.SelectedText = ""
        Me.txtrepeticiones.SelectionLength = 0
        Me.txtrepeticiones.SelectionStart = 0
        Me.txtrepeticiones.ShortcutsEnabled = True
        Me.txtrepeticiones.Size = New System.Drawing.Size(40, 20)
        Me.txtrepeticiones.TabIndex = 0
        Me.txtrepeticiones.Text = "0"
        Me.txtrepeticiones.UseSelectable = True
        Me.txtrepeticiones.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtrepeticiones.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(13, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cantidad de Repeticiones"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbldd)
        Me.Panel1.Controls.Add(Me.txtdias)
        Me.Panel1.Controls.Add(Me.rbdias)
        Me.Panel1.ForeColor = Color.Black
        Me.Panel1.HorizontalScrollbarBarColor = True
        Me.Panel1.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel1.HorizontalScrollbarSize = 10
        Me.Panel1.Location = New System.Drawing.Point(120, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 112)
        Me.Panel1.TabIndex = 9
        Me.Panel1.VerticalScrollbarBarColor = True
        Me.Panel1.VerticalScrollbarHighlightOnWheel = False
        Me.Panel1.VerticalScrollbarSize = 10
        '
        'lbldd
        '
        Me.lbldd.AutoSize = True
        Me.lbldd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldd.Location = New System.Drawing.Point(126, 12)
        Me.lbldd.Name = "lbldd"
        Me.lbldd.Size = New System.Drawing.Size(32, 19)
        Me.lbldd.TabIndex = 2
        Me.lbldd.Text = "días"
        '
        'txtdias
        '
        '
        '
        '
        Me.txtdias.CustomButton.Image = Nothing
        Me.txtdias.CustomButton.Location = New System.Drawing.Point(22, 2)
        Me.txtdias.CustomButton.Name = ""
        Me.txtdias.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtdias.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdias.CustomButton.TabIndex = 1
        Me.txtdias.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdias.CustomButton.UseSelectable = True
        Me.txtdias.CustomButton.Visible = False
        Me.txtdias.Lines = New String() {"0"}
        Me.txtdias.Location = New System.Drawing.Point(80, 10)
        Me.txtdias.MaxLength = 32767
        Me.txtdias.Name = "txtdias"
        Me.txtdias.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdias.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdias.SelectedText = ""
        Me.txtdias.SelectionLength = 0
        Me.txtdias.SelectionStart = 0
        Me.txtdias.ShortcutsEnabled = True
        Me.txtdias.Size = New System.Drawing.Size(40, 20)
        Me.txtdias.TabIndex = 0
        Me.txtdias.Text = "0"
        Me.txtdias.UseSelectable = True
        Me.txtdias.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtdias.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'rbdias
        '
        Me.rbdias.AutoSize = True
        Me.rbdias.Checked = True
        Me.rbdias.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbdias.Location = New System.Drawing.Point(24, 16)
        Me.rbdias.Name = "rbdias"
        Me.rbdias.Size = New System.Drawing.Size(50, 15)
        Me.rbdias.TabIndex = 0
        Me.rbdias.TabStop = True
        Me.rbdias.Text = "Cada"
        Me.rbdias.UseSelectable = True
        '
        'rbanual
        '
        Me.rbanual.AutoSize = True
        Me.rbanual.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbanual.Location = New System.Drawing.Point(24, 128)
        Me.rbanual.Name = "rbanual"
        Me.rbanual.Size = New System.Drawing.Size(54, 15)
        Me.rbanual.TabIndex = 3
        Me.rbanual.Text = "Anual"
        Me.rbanual.UseSelectable = True
        '
        'rbmensual
        '
        Me.rbmensual.AutoSize = True
        Me.rbmensual.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbmensual.Location = New System.Drawing.Point(24, 96)
        Me.rbmensual.Name = "rbmensual"
        Me.rbmensual.Size = New System.Drawing.Size(68, 15)
        Me.rbmensual.TabIndex = 2
        Me.rbmensual.Text = "Mensual"
        Me.rbmensual.UseSelectable = True
        '
        'rbsemanal
        '
        Me.rbsemanal.AutoSize = True
        Me.rbsemanal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbsemanal.Location = New System.Drawing.Point(24, 64)
        Me.rbsemanal.Name = "rbsemanal"
        Me.rbsemanal.Size = New System.Drawing.Size(68, 15)
        Me.rbsemanal.TabIndex = 1
        Me.rbsemanal.Text = "Semanal"
        Me.rbsemanal.UseSelectable = True
        '
        'rbdiario
        '
        Me.rbdiario.AutoSize = True
        Me.rbdiario.Checked = True
        Me.rbdiario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbdiario.Location = New System.Drawing.Point(24, 32)
        Me.rbdiario.Name = "rbdiario"
        Me.rbdiario.Size = New System.Drawing.Size(54, 15)
        Me.rbdiario.TabIndex = 0
        Me.rbdiario.TabStop = True
        Me.rbdiario.Text = "Diario"
        Me.rbdiario.UseSelectable = True
        '
        'lbldia
        '
        Me.lbldia.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbldia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldia.Location = New System.Drawing.Point(565, 85)
        Me.lbldia.Name = "lbldia"
        Me.lbldia.Size = New System.Drawing.Size(100, 16)
        Me.lbldia.TabIndex = 8
        '
        'btncancelar
        '
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(633, 342)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 8
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btncargar
        '
        Me.btncargar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncargar.Location = New System.Drawing.Point(747, 342)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(75, 23)
        Me.btncargar.TabIndex = 7
        Me.btncargar.Text = "Cargar &tarea"
        Me.btncargar.UseSelectable = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(36, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 19)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Descripción"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(36, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 19)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Tarea"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(36, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 19)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Turno"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(36, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Area"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(36, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Emisor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(36, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ID Tarea"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdesc
        '
        '
        '
        '
        Me.txtdesc.CustomButton.Image = Nothing
        Me.txtdesc.CustomButton.Location = New System.Drawing.Point(108, 2)
        Me.txtdesc.CustomButton.Name = ""
        Me.txtdesc.CustomButton.Size = New System.Drawing.Size(89, 89)
        Me.txtdesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdesc.CustomButton.TabIndex = 1
        Me.txtdesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdesc.CustomButton.UseSelectable = True
        Me.txtdesc.CustomButton.Visible = False
        Me.txtdesc.Lines = New String(-1) {}
        Me.txtdesc.Location = New System.Drawing.Point(127, 212)
        Me.txtdesc.MaxLength = 32767
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdesc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdesc.SelectedText = ""
        Me.txtdesc.SelectionLength = 0
        Me.txtdesc.SelectionStart = 0
        Me.txtdesc.ShortcutsEnabled = True
        Me.txtdesc.Size = New System.Drawing.Size(200, 94)
        Me.txtdesc.TabIndex = 4
        Me.txtdesc.UseSelectable = True
        Me.txtdesc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtdesc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txttarea
        '
        '
        '
        '
        Me.txttarea.CustomButton.Image = Nothing
        Me.txttarea.CustomButton.Location = New System.Drawing.Point(182, 2)
        Me.txttarea.CustomButton.Name = ""
        Me.txttarea.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txttarea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttarea.CustomButton.TabIndex = 1
        Me.txttarea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttarea.CustomButton.UseSelectable = True
        Me.txttarea.CustomButton.Visible = False
        Me.txttarea.Lines = New String(-1) {}
        Me.txttarea.Location = New System.Drawing.Point(127, 186)
        Me.txttarea.MaxLength = 32767
        Me.txttarea.Name = "txttarea"
        Me.txttarea.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttarea.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttarea.SelectedText = ""
        Me.txttarea.SelectionLength = 0
        Me.txttarea.SelectionStart = 0
        Me.txttarea.ShortcutsEnabled = True
        Me.txttarea.Size = New System.Drawing.Size(200, 20)
        Me.txttarea.TabIndex = 3
        Me.txttarea.UseSelectable = True
        Me.txttarea.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttarea.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(127, 148)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(121, 25)
        Me.cbturno.TabIndex = 2
        Me.cbturno.UseSelectable = True
        '
        'cbarea
        '
        Me.cbarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbarea.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbarea.FormattingEnabled = True
        Me.cbarea.ItemHeight = 19
        Me.cbarea.Location = New System.Drawing.Point(127, 117)
        Me.cbarea.Name = "cbarea"
        Me.cbarea.Size = New System.Drawing.Size(121, 25)
        Me.cbarea.TabIndex = 1
        Me.cbarea.UseSelectable = True
        '
        'txtemi
        '
        '
        '
        '
        Me.txtemi.CustomButton.Image = Nothing
        Me.txtemi.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtemi.CustomButton.Name = ""
        Me.txtemi.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtemi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtemi.CustomButton.TabIndex = 1
        Me.txtemi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtemi.CustomButton.UseSelectable = True
        Me.txtemi.CustomButton.Visible = False
        Me.txtemi.Lines = New String(-1) {}
        Me.txtemi.Location = New System.Drawing.Point(127, 91)
        Me.txtemi.MaxLength = 32767
        Me.txtemi.Name = "txtemi"
        Me.txtemi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemi.ReadOnly = True
        Me.txtemi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtemi.SelectedText = ""
        Me.txtemi.SelectionLength = 0
        Me.txtemi.SelectionStart = 0
        Me.txtemi.ShortcutsEnabled = True
        Me.txtemi.Size = New System.Drawing.Size(100, 20)
        Me.txtemi.TabIndex = 0
        Me.txtemi.UseSelectable = True
        Me.txtemi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtemi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtid
        '
        '
        '
        '
        Me.txtid.CustomButton.Image = Nothing
        Me.txtid.CustomButton.Location = New System.Drawing.Point(48, 2)
        Me.txtid.CustomButton.Name = ""
        Me.txtid.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtid.CustomButton.TabIndex = 1
        Me.txtid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtid.CustomButton.UseSelectable = True
        Me.txtid.CustomButton.Visible = False
        Me.txtid.Lines = New String(-1) {}
        Me.txtid.Location = New System.Drawing.Point(127, 65)
        Me.txtid.MaxLength = 32767
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.ReadOnly = True
        Me.txtid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtid.SelectedText = ""
        Me.txtid.SelectionLength = 0
        Me.txtid.SelectionStart = 0
        Me.txtid.ShortcutsEnabled = True
        Me.txtid.Size = New System.Drawing.Size(66, 20)
        Me.txtid.TabIndex = 23
        Me.txtid.UseSelectable = True
        Me.txtid.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtid.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(469, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Fecha de Inicio"
        '
        'Tareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 388)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btncargar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.txttarea)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.cbarea)
        Me.Controls.Add(Me.txtemi)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lbldia)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tareas"
        Me.Resizable = False
        Me.Tag = ""
        Me.Text = "Tareas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As MetroPanel
    Friend WithEvents rbanual As MetroRadioButton
    Friend WithEvents rbmensual As MetroRadioButton
    Friend WithEvents rbsemanal As MetroRadioButton
    Friend WithEvents rbdiario As MetroRadioButton
    Friend WithEvents lbldd As MetroLabel
    Friend WithEvents txtdias As MetroTextBox
    Friend WithEvents rbdias As MetroRadioButton
    Friend WithEvents Panel2 As MetroPanel
    Friend WithEvents txtrepeticiones As MetroTextBox
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents lbldia As MetroLabel
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents btncargar As MetroButton
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents txtdesc As MetroTextBox
    Friend WithEvents txttarea As MetroTextBox
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents cbarea As MetroComboBox
    Friend WithEvents txtemi As MetroTextBox
    Friend WithEvents txtid As MetroTextBox
    Friend WithEvents Label4 As MetroLabel

End Class
