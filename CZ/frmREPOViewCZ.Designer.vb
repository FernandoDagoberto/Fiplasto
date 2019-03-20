<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmREPOViewCZ
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.RepoView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RepoView
        '
        Me.RepoView.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        Me.RepoView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptCzPromEspesores2.rdlc"
        Me.RepoView.Location = New System.Drawing.Point(5, 60)
        Me.RepoView.Name = "RepoView"
        Me.RepoView.ShowDocumentMapButton = False
        Me.RepoView.Size = New System.Drawing.Size(814, 420)
        Me.RepoView.TabIndex = 0
        Me.RepoView.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'frmREPOViewCZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 485)
        Me.Controls.Add(Me.RepoView)
        Me.Name = "frmREPOViewCZ"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Style = MetroFramework.MetroColorStyle.Brown
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepoView As Microsoft.Reporting.WinForms.ReportViewer
End Class
