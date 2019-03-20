<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DescripPicad
    Inherits System.Windows.Forms.Form

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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("9.1.1 Guinchero")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("9.1.3 Op. de Picadora")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("9.1.4 Op. de Desfribradores")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("9.1.5 Ay. de Desfibrador y MC")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("9.1.6 Op. de Máquina Continua")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("9.1.7 Op. de Prensa")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("9.1.8 Ay. de Prensa")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("9.1.9 Quinto de Prensa")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("9.1.10 Op. del Cargador de Zorras")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Instructivos Operativos de Básicos", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(247, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(799, 464)
        Me.WebBrowser1.TabIndex = 3
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(12, 12)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "tvGinchero"
        TreeNode1.Text = "9.1.1 Guinchero"
        TreeNode2.Name = "tvOpPica"
        TreeNode2.Text = "9.1.3 Op. de Picadora"
        TreeNode3.Name = "tvOpDes"
        TreeNode3.Text = "9.1.4 Op. de Desfribradores"
        TreeNode4.Name = "tvAyMC"
        TreeNode4.Text = "9.1.5 Ay. de Desfibrador y MC"
        TreeNode5.Name = "tvOpMC"
        TreeNode5.Text = "9.1.6 Op. de Máquina Continua"
        TreeNode6.Name = "tvOpPr"
        TreeNode6.Text = "9.1.7 Op. de Prensa"
        TreeNode7.Name = "tvAyPr"
        TreeNode7.Text = "9.1.8 Ay. de Prensa"
        TreeNode8.Name = "tvQuiPr"
        TreeNode8.Text = "9.1.9 Quinto de Prensa"
        TreeNode9.Name = "tvOpZo"
        TreeNode9.Text = "9.1.10 Op. del Cargador de Zorras"
        TreeNode10.Name = "Nodo0"
        TreeNode10.Text = "Instructivos Operativos de Básicos"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode10})
        Me.TreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TreeView1.Size = New System.Drawing.Size(229, 464)
        Me.TreeView1.TabIndex = 4
        '
        'DescripPicad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 488)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "DescripPicad"
        Me.Text = "Instructivos Operativos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
End Class
