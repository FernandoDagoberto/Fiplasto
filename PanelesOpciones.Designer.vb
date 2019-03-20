Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelesOpciones
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
        Me.chklb = New System.Windows.Forms.CheckedListBox()
        Me.Panel1 = New MetroFramework.Controls.MetroPanel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel2 = New MetroFramework.Controls.MetroPanel()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chklb
        '
        Me.chklb.CheckOnClick = True
        Me.chklb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chklb.FormattingEnabled = True
        Me.chklb.Location = New System.Drawing.Point(5, 124)
        Me.chklb.Name = "chklb"
        Me.chklb.Size = New System.Drawing.Size(377, 235)
        Me.chklb.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.HorizontalScrollbarBarColor = True
        Me.Panel1.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel1.HorizontalScrollbarSize = 10
        Me.Panel1.Location = New System.Drawing.Point(5, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 64)
        Me.Panel1.TabIndex = 2
        Me.Panel1.VerticalScrollbarBarColor = True
        Me.Panel1.VerticalScrollbarHighlightOnWheel = False
        Me.Panel1.VerticalScrollbarSize = 10
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 64)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione como máximo 4 reportes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.WrapToLine = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.HorizontalScrollbarBarColor = True
        Me.Panel2.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel2.HorizontalScrollbarSize = 10
        Me.Panel2.Location = New System.Drawing.Point(5, 359)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(377, 28)
        Me.Panel2.TabIndex = 3
        Me.Panel2.VerticalScrollbarBarColor = True
        Me.Panel2.VerticalScrollbarHighlightOnWheel = False
        Me.Panel2.VerticalScrollbarSize = 10
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(3, 2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(245, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'PanelesOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.chklb)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PanelesOpciones"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Resizable = False
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Opciones Panel"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chklb As System.Windows.Forms.CheckedListBox
    Friend WithEvents Panel1 As MetroPanel
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Panel2 As MetroPanel
    Friend WithEvents btnCancelar As MetroButton
    Friend WithEvents btnGuardar As MetroButton
End Class
