Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TareaResp
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
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.lbltareaid = New MetroFramework.Controls.MetroLabel()
        Me.lbltareafch = New MetroFramework.Controls.MetroLabel()
        Me.lbltareaarea = New MetroFramework.Controls.MetroLabel()
        Me.lbltareaturno = New MetroFramework.Controls.MetroLabel()
        Me.lbltareaasunto = New MetroFramework.Controls.MetroLabel()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.btnaceptar = New MetroFramework.Controls.MetroButton()
        Me.lbltareadesc = New MetroFramework.Controls.MetroLabel()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.rbsi = New MetroFramework.Controls.MetroRadioButton()
        Me.rbno = New MetroFramework.Controls.MetroRadioButton()
        Me.txtobs = New MetroFramework.Controls.MetroTextBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCerrar = New MetroFramework.Controls.MetroButton()
        Me.btnResponder = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Tarea"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(124, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(10, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Área"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(10, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Turno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(10, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Asunto"
        '
        'lbltareaid
        '
        Me.lbltareaid.AutoSize = True
        Me.lbltareaid.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltareaid.Location = New System.Drawing.Point(85, 23)
        Me.lbltareaid.Name = "lbltareaid"
        Me.lbltareaid.Size = New System.Drawing.Size(21, 19)
        Me.lbltareaid.TabIndex = 10
        Me.lbltareaid.Text = "ID"
        '
        'lbltareafch
        '
        Me.lbltareafch.AutoSize = True
        Me.lbltareafch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltareafch.Location = New System.Drawing.Point(172, 22)
        Me.lbltareafch.Name = "lbltareafch"
        Me.lbltareafch.Size = New System.Drawing.Size(43, 19)
        Me.lbltareafch.TabIndex = 11
        Me.lbltareafch.Text = "Fecha"
        '
        'lbltareaarea
        '
        Me.lbltareaarea.AutoSize = True
        Me.lbltareaarea.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltareaarea.Location = New System.Drawing.Point(85, 50)
        Me.lbltareaarea.Name = "lbltareaarea"
        Me.lbltareaarea.Size = New System.Drawing.Size(35, 19)
        Me.lbltareaarea.TabIndex = 12
        Me.lbltareaarea.Text = "area"
        '
        'lbltareaturno
        '
        Me.lbltareaturno.AutoSize = True
        Me.lbltareaturno.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltareaturno.Location = New System.Drawing.Point(85, 78)
        Me.lbltareaturno.Name = "lbltareaturno"
        Me.lbltareaturno.Size = New System.Drawing.Size(43, 19)
        Me.lbltareaturno.TabIndex = 13
        Me.lbltareaturno.Text = "Turno"
        '
        'lbltareaasunto
        '
        Me.lbltareaasunto.AutoSize = True
        Me.lbltareaasunto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltareaasunto.Location = New System.Drawing.Point(85, 106)
        Me.lbltareaasunto.Name = "lbltareaasunto"
        Me.lbltareaasunto.Size = New System.Drawing.Size(47, 19)
        Me.lbltareaasunto.TabIndex = 14
        Me.lbltareaasunto.Text = "asunto"
        '
        'btncancelar
        '
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(93, 375)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 15
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'btnaceptar
        '
        Me.btnaceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnaceptar.Location = New System.Drawing.Point(209, 375)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnaceptar.TabIndex = 16
        Me.btnaceptar.Text = "&Aceptar"
        Me.btnaceptar.UseSelectable = True
        '
        'lbltareadesc
        '
        Me.lbltareadesc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltareadesc.Location = New System.Drawing.Point(85, 138)
        Me.lbltareadesc.Name = "lbltareadesc"
        Me.lbltareadesc.Size = New System.Drawing.Size(198, 260)
        Me.lbltareadesc.TabIndex = 18
        Me.lbltareadesc.Text = "asunto"
        Me.lbltareadesc.WrapToLine = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(10, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 19)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Descripción"
        '
        'rbsi
        '
        Me.rbsi.AutoSize = True
        Me.rbsi.Checked = True
        Me.rbsi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbsi.Location = New System.Drawing.Point(85, 21)
        Me.rbsi.Name = "rbsi"
        Me.rbsi.Size = New System.Drawing.Size(73, 15)
        Me.rbsi.TabIndex = 5
        Me.rbsi.TabStop = True
        Me.rbsi.Text = "Realizado"
        Me.rbsi.UseSelectable = True
        '
        'rbno
        '
        Me.rbno.AutoSize = True
        Me.rbno.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbno.Location = New System.Drawing.Point(85, 44)
        Me.rbno.Name = "rbno"
        Me.rbno.Size = New System.Drawing.Size(89, 15)
        Me.rbno.TabIndex = 6
        Me.rbno.Text = "No realizado"
        Me.rbno.UseSelectable = True
        '
        'txtobs
        '
        '
        '
        '
        Me.txtobs.CustomButton.Image = Nothing
        Me.txtobs.CustomButton.Location = New System.Drawing.Point(-79, 2)
        Me.txtobs.CustomButton.Name = ""
        Me.txtobs.CustomButton.Size = New System.Drawing.Size(279, 279)
        Me.txtobs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtobs.CustomButton.TabIndex = 1
        Me.txtobs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtobs.CustomButton.UseSelectable = True
        Me.txtobs.CustomButton.Visible = False
        Me.txtobs.Lines = New String(-1) {}
        Me.txtobs.Location = New System.Drawing.Point(93, 85)
        Me.txtobs.MaxLength = 32767
        Me.txtobs.Multiline = True
        Me.txtobs.Name = "txtobs"
        Me.txtobs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtobs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtobs.SelectedText = ""
        Me.txtobs.SelectionLength = 0
        Me.txtobs.SelectionStart = 0
        Me.txtobs.ShortcutsEnabled = True
        Me.txtobs.Size = New System.Drawing.Size(203, 284)
        Me.txtobs.TabIndex = 7
        Me.txtobs.UseSelectable = True
        Me.txtobs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtobs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Estado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(5, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Observación"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtobs)
        Me.GroupBox1.Controls.Add(Me.rbno)
        Me.GroupBox1.Controls.Add(Me.rbsi)
        Me.GroupBox1.Controls.Add(Me.btnaceptar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.ForeColor = Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(408, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 404)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Respuesta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCerrar)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lbltareadesc)
        Me.GroupBox2.Controls.Add(Me.lbltareaasunto)
        Me.GroupBox2.Controls.Add(Me.lbltareaturno)
        Me.GroupBox2.Controls.Add(Me.lbltareaarea)
        Me.GroupBox2.Controls.Add(Me.lbltareafch)
        Me.GroupBox2.Controls.Add(Me.lbltareaid)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 404)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tarea"
        '
        'btnCerrar
        '
        Me.btnCerrar.ForeColor = Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(13, 375)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(66, 23)
        Me.btnCerrar.TabIndex = 21
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseSelectable = True
        '
        'btnResponder
        '
        Me.btnResponder.Location = New System.Drawing.Point(317, 188)
        Me.btnResponder.Name = "btnResponder"
        Me.btnResponder.Size = New System.Drawing.Size(85, 40)
        Me.btnResponder.TabIndex = 17
        Me.btnResponder.Text = "&Responder ->"
        Me.btnResponder.UseSelectable = True
        '
        'TareaResp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnResponder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "TareaResp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Respuesta tarea"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents Label5 As MetroLabel
    Public WithEvents Label1 As MetroLabel
    Friend WithEvents lbltareaid As MetroLabel
    Friend WithEvents lbltareafch As MetroLabel
    Friend WithEvents lbltareaarea As MetroLabel
    Friend WithEvents lbltareaturno As MetroLabel
    Friend WithEvents lbltareaasunto As MetroLabel
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents btnaceptar As MetroButton
    Friend WithEvents lbltareadesc As MetroLabel
    Friend WithEvents Label9 As MetroLabel
    Friend WithEvents rbsi As MetroRadioButton
    Friend WithEvents rbno As MetroRadioButton
    Friend WithEvents txtobs As MetroTextBox
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As MetroButton
    Friend WithEvents btnResponder As MetroButton
End Class
