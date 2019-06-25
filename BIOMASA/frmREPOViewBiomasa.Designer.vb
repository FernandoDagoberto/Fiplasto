<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmREPOViewBiomasa
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
        Me.FIPLANEWDataSetTotal = New SPIF.FIPLANEWDataSetTotal()
        Me.BIODESCARTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BIODESCARTETableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.BIODESCARTETableAdapter()
        CType(Me.FIPLANEWDataSetTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIODESCARTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepoView
        '
        Me.RepoView.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BIODESCARTEBindingSource
        Me.RepoView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptDescarteBio.rdlc"
        Me.RepoView.Location = New System.Drawing.Point(20, 60)
        Me.RepoView.Name = "RepoView"
        Me.RepoView.ShowDocumentMapButton = False
        Me.RepoView.Size = New System.Drawing.Size(784, 405)
        Me.RepoView.TabIndex = 0
        Me.RepoView.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'FIPLANEWDataSetTotal
        '
        Me.FIPLANEWDataSetTotal.DataSetName = "FIPLANEWDataSetTotal"
        Me.FIPLANEWDataSetTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BIODESCARTEBindingSource
        '
        Me.BIODESCARTEBindingSource.DataMember = "BIODESCARTE"
        Me.BIODESCARTEBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'BIODESCARTETableAdapter
        '
        Me.BIODESCARTETableAdapter.ClearBeforeFill = True
        '
        'frmREPOViewBiomasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 485)
        Me.Controls.Add(Me.RepoView)
        Me.Name = "frmREPOViewBiomasa"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FIPLANEWDataSetTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIODESCARTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepoView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BIODESCARTEBindingSource As BindingSource
    Friend WithEvents FIPLANEWDataSetTotal As FIPLANEWDataSetTotal
    Friend WithEvents BIODESCARTETableAdapter As FIPLANEWDataSetTotalTableAdapters.BIODESCARTETableAdapter
End Class
