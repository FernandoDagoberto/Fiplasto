Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class permisos
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
        Me.lbmenu = New System.Windows.Forms.CheckedListBox()
        Me.cbperfil = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.cmdactualizar = New MetroFramework.Controls.MetroButton()
        Me.lblperfil = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'lbmenu
        '
        Me.lbmenu.CheckOnClick = True
        Me.lbmenu.FormattingEnabled = True
        Me.lbmenu.Location = New System.Drawing.Point(23, 102)
        Me.lbmenu.Name = "lbmenu"
        Me.lbmenu.Size = New System.Drawing.Size(367, 364)
        Me.lbmenu.TabIndex = 3
        '
        'cbperfil
        '
        Me.cbperfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbperfil.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbperfil.FormattingEnabled = True
        Me.cbperfil.ItemHeight = 19
        Me.cbperfil.Location = New System.Drawing.Point(23, 63)
        Me.cbperfil.Name = "cbperfil"
        Me.cbperfil.Size = New System.Drawing.Size(142, 25)
        Me.cbperfil.TabIndex = 8
        Me.cbperfil.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(421, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 108)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Se deben seleccionar las opciones que desea que el sistema NO MUESTRE para el per" &
    "fil seleccionado"
        Me.Label1.UseCustomBackColor = True
        Me.Label1.UseMnemonic = False
        Me.Label1.UseStyleColors = True
        Me.Label1.UseWaitCursor = True
        Me.Label1.WrapToLine = True
        '
        'cmdactualizar
        '
        Me.cmdactualizar.Location = New System.Drawing.Point(156, 472)
        Me.cmdactualizar.Name = "cmdactualizar"
        Me.cmdactualizar.Size = New System.Drawing.Size(75, 23)
        Me.cmdactualizar.TabIndex = 10
        Me.cmdactualizar.Text = "Actualizar perfil"
        Me.cmdactualizar.UseSelectable = True
        '
        'lblperfil
        '
        Me.lblperfil.AutoSize = True
        Me.lblperfil.Location = New System.Drawing.Point(191, 19)
        Me.lblperfil.Name = "lblperfil"
        Me.lblperfil.Size = New System.Drawing.Size(0, 0)
        Me.lblperfil.TabIndex = 11
        '
        'permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 507)
        Me.Controls.Add(Me.lblperfil)
        Me.Controls.Add(Me.cmdactualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbperfil)
        Me.Controls.Add(Me.lbmenu)
        Me.Name = "permisos"
        Me.Resizable = False
        Me.Text = "Permisos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbmenu As System.Windows.Forms.CheckedListBox
    Friend WithEvents cbperfil As MetroComboBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents cmdactualizar As MetroButton
    Friend WithEvents lblperfil As MetroLabel
End Class
