<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepoBasicos
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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ParadasBasicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCCIONDataSet = New SPIF.PRODUCCIONDataSet
        Me.RepoViewBas = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ParadasBasicosTableAdapter = New SPIF.PRODUCCIONDataSetTableAdapters.ParadasBasicosTableAdapter
        CType(Me.ParadasBasicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCCIONDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ParadasBasicosBindingSource
        '
        Me.ParadasBasicosBindingSource.DataMember = "ParadasBasicos"
        Me.ParadasBasicosBindingSource.DataSource = Me.PRODUCCIONDataSet
        '
        'PRODUCCIONDataSet
        '
        Me.PRODUCCIONDataSet.DataSetName = "PRODUCCIONDataSet"
        Me.PRODUCCIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepoViewBas
        '
        Me.RepoViewBas.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PRODUCCIONDataSet_InformeProduccion"
        Me.RepoViewBas.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RepoViewBas.LocalReport.ReportEmbeddedResource = "SPIF.rptProduccion.rdlc"
        Me.RepoViewBas.Location = New System.Drawing.Point(0, 0)
        Me.RepoViewBas.Name = "RepoViewBas"
        Me.RepoViewBas.Size = New System.Drawing.Size(858, 412)
        Me.RepoViewBas.TabIndex = 0
        '
        'ParadasBasicosTableAdapter
        '
        Me.ParadasBasicosTableAdapter.ClearBeforeFill = True
        '
        'frmRepoBasicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 412)
        Me.Controls.Add(Me.RepoViewBas)
        Me.Name = "frmRepoBasicos"
        Me.Text = "frmRepoAlist"
        CType(Me.ParadasBasicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCCIONDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepoViewBas As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ParadasBasicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRODUCCIONDataSet As SPIF.PRODUCCIONDataSet
    Friend WithEvents ParadasBasicosTableAdapter As SPIF.PRODUCCIONDataSetTableAdapters.ParadasBasicosTableAdapter

End Class
