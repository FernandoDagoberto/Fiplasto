<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepoAlist
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
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.AliSierraMohogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSAlistamiento = New SPIF.DSAlistamiento
        Me.AliProduccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AliProduccionMensualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepoViewAlis = New Microsoft.Reporting.WinForms.ReportViewer
        Me.AliSierraMohogTableAdapter = New SPIF.DSAlistamientoTableAdapters.AliSierraMohogTableAdapter
        Me.AliProduccionTableAdapter = New SPIF.DSAlistamientoTableAdapters.AliProduccionTableAdapter
        Me.AliProduccionMensualTableAdapter = New SPIF.DSAlistamientoTableAdapters.AliProduccionMensualTableAdapter
        CType(Me.AliSierraMohogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAlistamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AliProduccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AliProduccionMensualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AliSierraMohogBindingSource
        '
        Me.AliSierraMohogBindingSource.DataMember = "AliSierraMohog"
        Me.AliSierraMohogBindingSource.DataSource = Me.DSAlistamiento
        '
        'DSAlistamiento
        '
        Me.DSAlistamiento.DataSetName = "DSAlistamiento"
        Me.DSAlistamiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AliProduccionBindingSource
        '
        Me.AliProduccionBindingSource.DataMember = "AliProduccion"
        Me.AliProduccionBindingSource.DataSource = Me.DSAlistamiento
        '
        'AliProduccionMensualBindingSource
        '
        Me.AliProduccionMensualBindingSource.DataMember = "AliProduccionMensual"
        Me.AliProduccionMensualBindingSource.DataSource = Me.DSAlistamiento
        '
        'RepoViewAlis
        '
        Me.RepoViewAlis.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "DSAlistamiento_AliSierraMohog"
        ReportDataSource5.Value = Me.AliSierraMohogBindingSource
        ReportDataSource6.Name = "DSAlistamiento_AliProduccion"
        ReportDataSource6.Value = Me.AliProduccionBindingSource
        ReportDataSource7.Name = "DSAlistamiento_AliProduccionMensual"
        ReportDataSource7.Value = Me.AliProduccionMensualBindingSource
        ReportDataSource8.Name = "DSAlistamiento_AliAcumMensual"
        ReportDataSource8.Value = Me.AliSierraMohogBindingSource
        Me.RepoViewAlis.LocalReport.DataSources.Add(ReportDataSource5)
        Me.RepoViewAlis.LocalReport.DataSources.Add(ReportDataSource6)
        Me.RepoViewAlis.LocalReport.DataSources.Add(ReportDataSource7)
        Me.RepoViewAlis.LocalReport.DataSources.Add(ReportDataSource8)
        Me.RepoViewAlis.LocalReport.ReportEmbeddedResource = "SPIF.rptAlistamiento.rdlc"
        Me.RepoViewAlis.Location = New System.Drawing.Point(0, 0)
        Me.RepoViewAlis.Name = "RepoViewAlis"
        Me.RepoViewAlis.Size = New System.Drawing.Size(858, 412)
        Me.RepoViewAlis.TabIndex = 0
        '
        'AliSierraMohogTableAdapter
        '
        Me.AliSierraMohogTableAdapter.ClearBeforeFill = True
        '
        'AliProduccionTableAdapter
        '
        Me.AliProduccionTableAdapter.ClearBeforeFill = True
        '
        'AliProduccionMensualTableAdapter
        '
        Me.AliProduccionMensualTableAdapter.ClearBeforeFill = True
        '
        'frmRepoAlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 412)
        Me.Controls.Add(Me.RepoViewAlis)
        Me.Name = "frmRepoAlist"
        Me.Text = "Reportes Alistamiento"
        CType(Me.AliSierraMohogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAlistamiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AliProduccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AliProduccionMensualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepoViewAlis As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AliSierraMohogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSAlistamiento As SPIF.DSAlistamiento
    Friend WithEvents AliProduccionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AliSierraMohogTableAdapter As SPIF.DSAlistamientoTableAdapters.AliSierraMohogTableAdapter
    Friend WithEvents AliProduccionTableAdapter As SPIF.DSAlistamientoTableAdapters.AliProduccionTableAdapter
    Friend WithEvents AliProduccionMensualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AliProduccionMensualTableAdapter As SPIF.DSAlistamientoTableAdapters.AliProduccionMensualTableAdapter

End Class
