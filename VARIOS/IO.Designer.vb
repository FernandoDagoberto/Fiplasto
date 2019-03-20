<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO
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
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView1.Location = New System.Drawing.Point(5, 30)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TreeView1.Size = New System.Drawing.Size(229, 453)
        Me.TreeView1.TabIndex = 4
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(234, 30)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(819, 453)
        Me.WebBrowser1.TabIndex = 5
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'IO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 488)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.TreeView1)
        Me.DisplayHeader = False
        Me.Name = "IO"
        Me.Padding = New System.Windows.Forms.Padding(5, 30, 5, 5)
        Me.Text = "Instructivos Operativos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
