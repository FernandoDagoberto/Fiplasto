Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class password
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
        Me.lblusu = New MetroFramework.Controls.MetroLabel()
        Me.txtca = New System.Windows.Forms.MaskedTextBox()
        Me.txtnc = New System.Windows.Forms.MaskedTextBox()
        Me.txtrc = New System.Windows.Forms.MaskedTextBox()
        Me.btncambiar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(22, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(22, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contreña anterior:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(22, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nueva Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(22, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Repita Contraseña:"
        '
        'lblusu
        '
        Me.lblusu.AutoSize = True
        Me.lblusu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblusu.Location = New System.Drawing.Point(147, 72)
        Me.lblusu.Name = "lblusu"
        Me.lblusu.Size = New System.Drawing.Size(47, 19)
        Me.lblusu.TabIndex = 4
        Me.lblusu.Text = "Label5"
        '
        'txtca
        '
        Me.txtca.Location = New System.Drawing.Point(150, 99)
        Me.txtca.Name = "txtca"
        Me.txtca.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtca.Size = New System.Drawing.Size(100, 20)
        Me.txtca.TabIndex = 0
        '
        'txtnc
        '
        Me.txtnc.Location = New System.Drawing.Point(150, 127)
        Me.txtnc.Name = "txtnc"
        Me.txtnc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnc.Size = New System.Drawing.Size(100, 20)
        Me.txtnc.TabIndex = 1
        '
        'txtrc
        '
        Me.txtrc.Location = New System.Drawing.Point(150, 155)
        Me.txtrc.Name = "txtrc"
        Me.txtrc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrc.Size = New System.Drawing.Size(100, 20)
        Me.txtrc.TabIndex = 2
        '
        'btncambiar
        '
        Me.btncambiar.Location = New System.Drawing.Point(119, 191)
        Me.btncambiar.Name = "btncambiar"
        Me.btncambiar.Size = New System.Drawing.Size(75, 23)
        Me.btncambiar.TabIndex = 3
        Me.btncambiar.Text = "&Cambiar"
        Me.btncambiar.UseSelectable = True
        '
        'password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 237)
        Me.Controls.Add(Me.btncambiar)
        Me.Controls.Add(Me.txtrc)
        Me.Controls.Add(Me.txtnc)
        Me.Controls.Add(Me.txtca)
        Me.Controls.Add(Me.lblusu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "password"
        Me.Resizable = False
        Me.Text = "Cambio de Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents lblusu As MetroLabel
    Friend WithEvents txtca As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtnc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtrc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btncambiar As MetroButton
End Class
