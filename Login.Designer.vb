<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtusua = New MetroFramework.Controls.MetroTextBox()
        Me.txtpass = New MetroFramework.Controls.MetroTextBox()
        Me.btnsi = New MetroFramework.Controls.MetroButton()
        Me.btnno = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.ForeColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.Location = New System.Drawing.Point(11, 109)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "Usuario"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.White
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.ForeColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.Location = New System.Drawing.Point(11, 136)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Contraseña"
        '
        'txtusua
        '
        '
        '
        '
        Me.txtusua.CustomButton.Image = Nothing
        Me.txtusua.CustomButton.Location = New System.Drawing.Point(130, 1)
        Me.txtusua.CustomButton.Name = ""
        Me.txtusua.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtusua.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtusua.CustomButton.TabIndex = 1
        Me.txtusua.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtusua.CustomButton.UseSelectable = True
        Me.txtusua.CustomButton.Visible = False
        Me.txtusua.Lines = New String(-1) {}
        Me.txtusua.Location = New System.Drawing.Point(96, 104)
        Me.txtusua.MaxLength = 32767
        Me.txtusua.Name = "txtusua"
        Me.txtusua.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusua.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtusua.SelectedText = ""
        Me.txtusua.SelectionLength = 0
        Me.txtusua.SelectionStart = 0
        Me.txtusua.ShortcutsEnabled = True
        Me.txtusua.Size = New System.Drawing.Size(152, 23)
        Me.txtusua.TabIndex = 8
        Me.txtusua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtusua.UseSelectable = True
        Me.txtusua.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtusua.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtpass
        '
        '
        '
        '
        Me.txtpass.CustomButton.Image = Nothing
        Me.txtpass.CustomButton.Location = New System.Drawing.Point(130, 1)
        Me.txtpass.CustomButton.Name = ""
        Me.txtpass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpass.CustomButton.TabIndex = 1
        Me.txtpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpass.CustomButton.UseSelectable = True
        Me.txtpass.CustomButton.Visible = False
        Me.txtpass.Lines = New String(-1) {}
        Me.txtpass.Location = New System.Drawing.Point(96, 132)
        Me.txtpass.MaxLength = 32767
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpass.SelectedText = ""
        Me.txtpass.SelectionLength = 0
        Me.txtpass.SelectionStart = 0
        Me.txtpass.ShortcutsEnabled = True
        Me.txtpass.Size = New System.Drawing.Size(152, 23)
        Me.txtpass.TabIndex = 9
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpass.UseSelectable = True
        Me.txtpass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnsi
        '
        Me.btnsi.Location = New System.Drawing.Point(288, 103)
        Me.btnsi.Name = "btnsi"
        Me.btnsi.Size = New System.Drawing.Size(75, 23)
        Me.btnsi.TabIndex = 10
        Me.btnsi.Text = "Aceptar"
        Me.btnsi.UseSelectable = True
        '
        'btnno
        '
        Me.btnno.Location = New System.Drawing.Point(288, 132)
        Me.btnno.Name = "btnno"
        Me.btnno.Size = New System.Drawing.Size(75, 23)
        Me.btnno.TabIndex = 11
        Me.btnno.Text = "Cancelar"
        Me.btnno.UseSelectable = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.ClientSize = New System.Drawing.Size(392, 194)
        Me.Controls.Add(Me.btnno)
        Me.Controls.Add(Me.btnsi)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusua)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Resizable = False
        Me.Text = "Bienvenido"
        Me.TransparencyKey = System.Drawing.Color.Yellow
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtusua As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtpass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnsi As MetroFramework.Controls.MetroButton
    Friend WithEvents btnno As MetroFramework.Controls.MetroButton
End Class
