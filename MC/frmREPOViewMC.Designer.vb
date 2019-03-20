<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmREPOViewMC
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MCHIPOCLORITOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FIPLANEWDataSetTotal = New SPIF.FIPLANEWDataSetTotal()
        Me.MCCUCHILLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepoView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MCENSAYOTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.MCENSAYOTableAdapter()
        Me.MCENSAYOTQ3TableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.MCENSAYOTQ3TableAdapter()
        Me.CRTLSULFENSTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.CRTLSULFENSTableAdapter()
        Me.MCVARPROCTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.MCVARPROCTableAdapter()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MCCUCHILLATableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.MCCUCHILLATableAdapter()
        Me.MCHIPOCLORITOTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.MCHIPOCLORITOTableAdapter()
        Me.MCLIMPVACIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MCLIMPVACIOTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.MCLIMPVACIOTableAdapter()
        CType(Me.MCHIPOCLORITOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FIPLANEWDataSetTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCCUCHILLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCLIMPVACIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MCHIPOCLORITOBindingSource
        '
        Me.MCHIPOCLORITOBindingSource.DataMember = "MCHIPOCLORITO"
        Me.MCHIPOCLORITOBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'FIPLANEWDataSetTotal
        '
        Me.FIPLANEWDataSetTotal.DataSetName = "FIPLANEWDataSetTotal"
        Me.FIPLANEWDataSetTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MCCUCHILLABindingSource
        '
        Me.MCCUCHILLABindingSource.DataMember = "MCCUCHILLA"
        Me.MCCUCHILLABindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'RepoView
        '
        Me.RepoView.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MCLIMPVACIOBindingSource
        Me.RepoView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptMcLimpVac.rdlc"
        Me.RepoView.Location = New System.Drawing.Point(5, 60)
        Me.RepoView.Name = "RepoView"
        Me.RepoView.ShowDocumentMapButton = False
        Me.RepoView.Size = New System.Drawing.Size(814, 420)
        Me.RepoView.TabIndex = 0
        '
        'MCENSAYOTableAdapter
        '
        Me.MCENSAYOTableAdapter.ClearBeforeFill = True
        '
        'MCENSAYOTQ3TableAdapter
        '
        Me.MCENSAYOTQ3TableAdapter.ClearBeforeFill = True
        '
        'CRTLSULFENSTableAdapter
        '
        Me.CRTLSULFENSTableAdapter.ClearBeforeFill = True
        '
        'MCVARPROCTableAdapter
        '
        Me.MCVARPROCTableAdapter.ClearBeforeFill = True
        '
        'MCCUCHILLATableAdapter
        '
        Me.MCCUCHILLATableAdapter.ClearBeforeFill = True
        '
        'MCHIPOCLORITOTableAdapter
        '
        Me.MCHIPOCLORITOTableAdapter.ClearBeforeFill = True
        '
        'MCLIMPVACIOBindingSource
        '
        Me.MCLIMPVACIOBindingSource.DataMember = "MCLIMPVACIO"
        Me.MCLIMPVACIOBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'MCLIMPVACIOTableAdapter
        '
        Me.MCLIMPVACIOTableAdapter.ClearBeforeFill = True
        '
        'frmREPOViewMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 485)
        Me.Controls.Add(Me.RepoView)
        Me.Name = "frmREPOViewMC"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reportes"
        Me.WindowState = FormWindowState.Maximized
        CType(Me.MCHIPOCLORITOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FIPLANEWDataSetTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCCUCHILLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCLIMPVACIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepoView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MCENSAYOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FIPLANEWDataSetTotal As SPIF.FIPLANEWDataSetTotal
    Friend WithEvents MCENSAYOTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.MCENSAYOTableAdapter
    Friend WithEvents MCENSAYOTQ3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MCENSAYOTQ3TableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.MCENSAYOTQ3TableAdapter
    Friend WithEvents CRTLSULFENSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CRTLSULFENSTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.CRTLSULFENSTableAdapter
    Friend WithEvents MCVARPROCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MCVARPROCTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.MCVARPROCTableAdapter
    Friend WithEvents Descarga_CamionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents MCCUCHILLABindingSource As BindingSource
    Friend WithEvents MCCUCHILLATableAdapter As FIPLANEWDataSetTotalTableAdapters.MCCUCHILLATableAdapter
    Friend WithEvents MCHIPOCLORITOBindingSource As BindingSource
    Friend WithEvents MCHIPOCLORITOTableAdapter As FIPLANEWDataSetTotalTableAdapters.MCHIPOCLORITOTableAdapter
    Friend WithEvents MCLIMPVACIOBindingSource As BindingSource
    Friend WithEvents MCLIMPVACIOTableAdapter As FIPLANEWDataSetTotalTableAdapters.MCLIMPVACIOTableAdapter
End Class
