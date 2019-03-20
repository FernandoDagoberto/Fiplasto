<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepoViewMadera
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RepoView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RepoView
        '
        Me.RepoView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptInfServicios.rdlc"
        Me.RepoView.Location = New System.Drawing.Point(5, 60)
        Me.RepoView.Name = "RepoView"
        Me.RepoView.ShowDocumentMapButton = False
        Me.RepoView.Size = New System.Drawing.Size(730, 354)
        Me.RepoView.TabIndex = 1
        '
        'RepoViewMadera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 419)
        Me.Controls.Add(Me.RepoView)
        Me.Name = "RepoViewMadera"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Style = MetroFramework.MetroColorStyle.Black
        Me.Text = "Listado de Madera"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepoView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MaderaViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FIPLANEWDataSetTotal As SPIF.FIPLANEWDataSetTotal
    Friend WithEvents MaderaViewTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.MaderaViewTableAdapter
    Friend WithEvents MaderaViewServiciosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FIPLANEWCamion As SPIF.FIPLANEWCamion
    Friend WithEvents MaderaViewTableAdapterServicios As SPIF.FIPLANEWCamionTableAdapters.MaderaViewTableAdapterServicios
End Class
