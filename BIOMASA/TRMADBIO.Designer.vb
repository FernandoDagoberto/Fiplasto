Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TRMADBIO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TRMADBIO))
        Me.btncargar = New MetroFramework.Controls.MetroButton()
        Me.cbde = New MetroFramework.Controls.MetroComboBox()
        Me.txtcant = New MetroFramework.Controls.MetroTextBox()
        Me.lblA = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.lblB = New MetroFramework.Controls.MetroLabel()
        Me.lbltna = New MetroFramework.Controls.MetroLabel()
        Me.lbltnd = New MetroFramework.Controls.MetroLabel()
        Me.cba = New MetroFramework.Controls.MetroComboBox()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncargar
        '
        Me.btncargar.Location = New System.Drawing.Point(335, 252)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(70, 23)
        Me.btncargar.TabIndex = 3
        Me.btncargar.Text = "&Transferir"
        Me.btncargar.UseSelectable = True
        '
        'cbde
        '
        Me.cbde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbde.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbde.FormattingEnabled = True
        Me.cbde.ItemHeight = 19
        Me.cbde.Location = New System.Drawing.Point(33, 156)
        Me.cbde.Name = "cbde"
        Me.cbde.Size = New System.Drawing.Size(69, 25)
        Me.cbde.Style = MetroFramework.MetroColorStyle.Red
        Me.cbde.TabIndex = 0
        Me.cbde.UseSelectable = True
        '
        'txtcant
        '
        '
        '
        '
        Me.txtcant.CustomButton.Image = Nothing
        Me.txtcant.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txtcant.CustomButton.Name = ""
        Me.txtcant.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcant.CustomButton.TabIndex = 1
        Me.txtcant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcant.CustomButton.UseSelectable = True
        Me.txtcant.CustomButton.Visible = False
        Me.txtcant.Lines = New String(-1) {}
        Me.txtcant.Location = New System.Drawing.Point(139, 156)
        Me.txtcant.MaxLength = 32767
        Me.txtcant.Name = "txtcant"
        Me.txtcant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcant.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcant.SelectedText = ""
        Me.txtcant.SelectionLength = 0
        Me.txtcant.SelectionStart = 0
        Me.txtcant.ShortcutsEnabled = True
        Me.txtcant.Size = New System.Drawing.Size(100, 20)
        Me.txtcant.Style = MetroFramework.MetroColorStyle.Red
        Me.txtcant.TabIndex = 1
        Me.txtcant.UseSelectable = True
        Me.txtcant.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcant.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblA.Location = New System.Drawing.Point(30, 129)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(53, 19)
        Me.lblA.TabIndex = 20
        Me.lblA.Text = "De pila:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(129, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Cant. TN a transferir"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblB.Location = New System.Drawing.Point(287, 129)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(46, 19)
        Me.lblB.TabIndex = 22
        Me.lblB.Text = "A pila:"
        '
        'lbltna
        '
        Me.lbltna.AutoSize = True
        Me.lbltna.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbltna.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltna.Location = New System.Drawing.Point(270, 192)
        Me.lbltna.Name = "lbltna"
        Me.lbltna.Size = New System.Drawing.Size(0, 0)
        Me.lbltna.TabIndex = 23
        '
        'lbltnd
        '
        Me.lbltnd.AutoSize = True
        Me.lbltnd.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbltnd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltnd.Location = New System.Drawing.Point(30, 192)
        Me.lbltnd.Name = "lbltnd"
        Me.lbltnd.Size = New System.Drawing.Size(39, 15)
        Me.lbltnd.TabIndex = 24
        Me.lbltnd.Text = "Label5"
        '
        'cba
        '
        Me.cba.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cba.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cba.FormattingEnabled = True
        Me.cba.ItemHeight = 19
        Me.cba.Location = New System.Drawing.Point(269, 155)
        Me.cba.Name = "cba"
        Me.cba.Size = New System.Drawing.Size(77, 25)
        Me.cba.Style = MetroFramework.MetroColorStyle.Red
        Me.cba.TabIndex = 2
        Me.cba.UseSelectable = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(245, 252)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(70, 23)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(121, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'TRMADBIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 298)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.cba)
        Me.Controls.Add(Me.lbltnd)
        Me.Controls.Add(Me.lbltna)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.txtcant)
        Me.Controls.Add(Me.cbde)
        Me.Controls.Add(Me.btncargar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "TRMADBIO"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Transferencia de madera - biomasa"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncargar As MetroButton
    Friend WithEvents cbde As MetroComboBox
    Friend WithEvents txtcant As MetroTextBox
    Friend WithEvents lblA As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents lblB As MetroLabel
    Friend WithEvents lbltna As MetroLabel
    Friend WithEvents lbltnd As MetroLabel
    Friend WithEvents cba As MetroComboBox
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
