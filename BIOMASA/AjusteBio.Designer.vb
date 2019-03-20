Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AjusteBio
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
        Me.btncargar = New MetroFramework.Controls.MetroButton()
        Me.cbde = New MetroFramework.Controls.MetroComboBox()
        Me.txtcant = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.lbltna = New MetroFramework.Controls.MetroLabel()
        Me.lbltnd = New MetroFramework.Controls.MetroLabel()
        Me.cba = New MetroFramework.Controls.MetroComboBox()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.chktodas = New MetroFramework.Controls.MetroCheckBox()
        Me.SuspendLayout()
        '
        'btncargar
        '
        Me.btncargar.Location = New System.Drawing.Point(201, 209)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(70, 23)
        Me.btncargar.Style = MetroFramework.MetroColorStyle.Red
        Me.btncargar.TabIndex = 4
        Me.btncargar.Text = "&Transferir"
        Me.btncargar.UseSelectable = True
        '
        'cbde
        '
        Me.cbde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbde.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbde.FormattingEnabled = True
        Me.cbde.ItemHeight = 19
        Me.cbde.Location = New System.Drawing.Point(31, 125)
        Me.cbde.Name = "cbde"
        Me.cbde.Size = New System.Drawing.Size(71, 25)
        Me.cbde.Style = MetroFramework.MetroColorStyle.Red
        Me.cbde.TabIndex = 1
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
        Me.txtcant.Location = New System.Drawing.Point(137, 125)
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
        Me.txtcant.TabIndex = 2
        Me.txtcant.UseSelectable = True
        Me.txtcant.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcant.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(28, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "De pila:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(127, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Cant. TN a transferir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(285, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "A pila:"
        '
        'lbltna
        '
        Me.lbltna.AutoSize = True
        Me.lbltna.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbltna.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltna.Location = New System.Drawing.Point(270, 156)
        Me.lbltna.Name = "lbltna"
        Me.lbltna.Size = New System.Drawing.Size(0, 0)
        Me.lbltna.TabIndex = 23
        '
        'lbltnd
        '
        Me.lbltnd.AutoSize = True
        Me.lbltnd.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbltnd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltnd.Location = New System.Drawing.Point(28, 153)
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
        Me.cba.Location = New System.Drawing.Point(267, 124)
        Me.cba.Name = "cba"
        Me.cba.Size = New System.Drawing.Size(77, 25)
        Me.cba.Style = MetroFramework.MetroColorStyle.Red
        Me.cba.TabIndex = 3
        Me.cba.UseSelectable = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(111, 209)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(70, 23)
        Me.btncancelar.Style = MetroFramework.MetroColorStyle.Red
        Me.btncancelar.TabIndex = 5
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'chktodas
        '
        Me.chktodas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chktodas.Location = New System.Drawing.Point(99, 63)
        Me.chktodas.Name = "chktodas"
        Me.chktodas.Size = New System.Drawing.Size(184, 22)
        Me.chktodas.TabIndex = 0
        Me.chktodas.Text = "No tener en cuenta variedad"
        Me.chktodas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chktodas.UseSelectable = True
        '
        'AjusteBio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 242)
        Me.Controls.Add(Me.chktodas)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.cba)
        Me.Controls.Add(Me.lbltnd)
        Me.Controls.Add(Me.lbltna)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcant)
        Me.Controls.Add(Me.cbde)
        Me.Controls.Add(Me.btncargar)
        Me.Name = "AjusteBio"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Ajuste de Inventario Biomasa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncargar As MetroButton
    Friend WithEvents cbde As MetroComboBox
    Friend WithEvents txtcant As MetroTextBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents lbltna As MetroLabel
    Friend WithEvents lbltnd As MetroLabel
    Friend WithEvents cba As MetroComboBox
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents chktodas As MetroCheckBox
End Class
