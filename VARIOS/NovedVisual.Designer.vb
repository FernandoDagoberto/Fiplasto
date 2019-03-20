Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovedVisual
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
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.lblfch = New MetroFramework.Controls.MetroLabel()
        Me.lblarea = New MetroFramework.Controls.MetroLabel()
        Me.lblmotivo = New MetroFramework.Controls.MetroLabel()
        Me.lblusuario = New MetroFramework.Controls.MetroLabel()
        Me.btnvisto = New MetroFramework.Controls.MetroButton()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(10, 21)
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
        Me.Label4.Size = New System.Drawing.Size(50, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Motivo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(10, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Usuario"
        '
        'lblfch
        '
        Me.lblfch.AutoSize = True
        Me.lblfch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblfch.Location = New System.Drawing.Point(85, 23)
        Me.lblfch.Name = "lblfch"
        Me.lblfch.Size = New System.Drawing.Size(43, 19)
        Me.lblfch.TabIndex = 11
        Me.lblfch.Text = "Fecha"
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblarea.Location = New System.Drawing.Point(85, 50)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(35, 19)
        Me.lblarea.TabIndex = 12
        Me.lblarea.Text = "area"
        '
        'lblmotivo
        '
        Me.lblmotivo.AutoSize = True
        Me.lblmotivo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblmotivo.Location = New System.Drawing.Point(85, 78)
        Me.lblmotivo.Name = "lblmotivo"
        Me.lblmotivo.Size = New System.Drawing.Size(43, 19)
        Me.lblmotivo.TabIndex = 13
        Me.lblmotivo.Text = "Turno"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblusuario.Location = New System.Drawing.Point(85, 106)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(53, 19)
        Me.lblusuario.TabIndex = 14
        Me.lblusuario.Text = "Usuario"
        '
        'btnvisto
        '
        Me.btnvisto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnvisto.Location = New System.Drawing.Point(115, 372)
        Me.btnvisto.Name = "btnvisto"
        Me.btnvisto.Size = New System.Drawing.Size(75, 23)
        Me.btnvisto.TabIndex = 16
        Me.btnvisto.Text = "&Aceptar"
        Me.btnvisto.UseSelectable = True
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTexto)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblusuario)
        Me.GroupBox2.Controls.Add(Me.lblmotivo)
        Me.GroupBox2.Controls.Add(Me.lblarea)
        Me.GroupBox2.Controls.Add(Me.btnvisto)
        Me.GroupBox2.Controls.Add(Me.lblfch)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 404)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Novedad"
        '
        'lblTexto
        '
        Me.lblTexto.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.Location = New System.Drawing.Point(93, 138)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(190, 219)
        Me.lblTexto.TabIndex = 18
        Me.lblTexto.Text = "Label1"
        '
        'NovedVisual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "NovedVisual"
        Me.Text = "Novedad"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents lblfch As MetroLabel
    Friend WithEvents lblarea As MetroLabel
    Friend WithEvents lblmotivo As MetroLabel
    Friend WithEvents lblusuario As MetroLabel
    Friend WithEvents btnvisto As MetroButton
    Friend WithEvents Label9 As MetroLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTexto As Label
End Class
