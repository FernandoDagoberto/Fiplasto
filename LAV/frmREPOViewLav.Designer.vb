<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmREPOViewLav
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
        Me.RepLavRepaViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FIPLANEWDataSetTotal = New SPIF.FIPLANEWDataSetTotal()
        Me.RepoView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LAVTDHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAVINOXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAVCCPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepLavGralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAVLIMPCUBABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAVSODABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAVCHTRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAVTDHTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.LAVTDHTableAdapter()
        Me.LAVCHTRTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.LAVCHTRTableAdapter()
        Me.LAVCCPTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.LAVCCPTableAdapter()
        Me.LAVDECOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAVDECOTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.LAVDECOTableAdapter()
        Me.LAVINOXTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.LAVINOXTableAdapter()
        Me.LAVSODATableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.LAVSODATableAdapter()
        Me.LAVLIMPCUBATableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.LAVLIMPCUBATableAdapter()
        Me.RepLavGralTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.RepLavGralTableAdapter()
        Me.CZCTRLDIMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CZCTRLDIMTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.CZCTRLDIMTableAdapter()
        Me.RepLavRepaViewTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.RepLavRepaViewTableAdapter()
        CType(Me.RepLavRepaViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FIPLANEWDataSetTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAVTDHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAVINOXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAVCCPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepLavGralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAVLIMPCUBABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAVSODABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAVCHTRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAVDECOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CZCTRLDIMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepLavRepaViewBindingSource
        '
        Me.RepLavRepaViewBindingSource.DataMember = "RepLavRepaView"
        Me.RepLavRepaViewBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'FIPLANEWDataSetTotal
        '
        Me.FIPLANEWDataSetTotal.DataSetName = "FIPLANEWDataSetTotal"
        Me.FIPLANEWDataSetTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepoView
        '
        Me.RepoView.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "FIPLANEWDataSetTotal_RepLavRepaView"
        ReportDataSource1.Value = Me.RepLavRepaViewBindingSource
        Me.RepoView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptLavReparac.rdlc"
        Me.RepoView.Location = New System.Drawing.Point(20, 60)
        Me.RepoView.Name = "RepoView"
        Me.RepoView.ShowDocumentMapButton = False
        Me.RepoView.Size = New System.Drawing.Size(784, 405)
        Me.RepoView.TabIndex = 0
        Me.RepoView.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'LAVTDHBindingSource
        '
        Me.LAVTDHBindingSource.DataMember = "LAVTDH"
        Me.LAVTDHBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'LAVINOXBindingSource
        '
        Me.LAVINOXBindingSource.DataMember = "LAVINOX"
        Me.LAVINOXBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'LAVCCPBindingSource
        '
        Me.LAVCCPBindingSource.DataMember = "LAVCCP"
        Me.LAVCCPBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'RepLavGralBindingSource
        '
        Me.RepLavGralBindingSource.DataMember = "RepLavGral"
        Me.RepLavGralBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'LAVLIMPCUBABindingSource
        '
        Me.LAVLIMPCUBABindingSource.DataMember = "LAVLIMPCUBA"
        Me.LAVLIMPCUBABindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'LAVSODABindingSource
        '
        Me.LAVSODABindingSource.DataMember = "LAVSODA"
        Me.LAVSODABindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'LAVCHTRBindingSource
        '
        Me.LAVCHTRBindingSource.DataMember = "LAVCHTR"
        Me.LAVCHTRBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'LAVTDHTableAdapter
        '
        Me.LAVTDHTableAdapter.ClearBeforeFill = True
        '
        'LAVCHTRTableAdapter
        '
        Me.LAVCHTRTableAdapter.ClearBeforeFill = True
        '
        'LAVCCPTableAdapter
        '
        Me.LAVCCPTableAdapter.ClearBeforeFill = True
        '
        'LAVDECOBindingSource
        '
        Me.LAVDECOBindingSource.DataMember = "LAVDECO"
        Me.LAVDECOBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'LAVDECOTableAdapter
        '
        Me.LAVDECOTableAdapter.ClearBeforeFill = True
        '
        'LAVINOXTableAdapter
        '
        Me.LAVINOXTableAdapter.ClearBeforeFill = True
        '
        'LAVSODATableAdapter
        '
        Me.LAVSODATableAdapter.ClearBeforeFill = True
        '
        'LAVLIMPCUBATableAdapter
        '
        Me.LAVLIMPCUBATableAdapter.ClearBeforeFill = True
        '
        'RepLavGralTableAdapter
        '
        Me.RepLavGralTableAdapter.ClearBeforeFill = True
        '
        'CZCTRLDIMBindingSource
        '
        Me.CZCTRLDIMBindingSource.DataMember = "CZCTRLDIM"
        Me.CZCTRLDIMBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'CZCTRLDIMTableAdapter
        '
        Me.CZCTRLDIMTableAdapter.ClearBeforeFill = True
        '
        'RepLavRepaViewTableAdapter
        '
        Me.RepLavRepaViewTableAdapter.ClearBeforeFill = True
        '
        'frmREPOViewLav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 485)
        Me.Controls.Add(Me.RepoView)
        Me.Name = "frmREPOViewLav"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepLavRepaViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FIPLANEWDataSetTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAVTDHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAVINOXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAVCCPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLavGralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAVLIMPCUBABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAVSODABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAVCHTRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAVDECOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CZCTRLDIMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepoView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LAVTDHBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FIPLANEWDataSetTotal As SPIF.FIPLANEWDataSetTotal
    Friend WithEvents LAVTDHTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.LAVTDHTableAdapter
    Friend WithEvents LAVCHTRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LAVCHTRTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.LAVCHTRTableAdapter
    Friend WithEvents LAVCCPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LAVCCPTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.LAVCCPTableAdapter
    Friend WithEvents LAVDECOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LAVDECOTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.LAVDECOTableAdapter
    Friend WithEvents LAVINOXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LAVINOXTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.LAVINOXTableAdapter
    Friend WithEvents LAVSODABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LAVSODATableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.LAVSODATableAdapter
    Friend WithEvents LAVLIMPCUBABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LAVLIMPCUBATableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.LAVLIMPCUBATableAdapter
    Friend WithEvents RepLavGralBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepLavGralTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.RepLavGralTableAdapter
    Friend WithEvents CZCTRLDIMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CZCTRLDIMTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.CZCTRLDIMTableAdapter
    Friend WithEvents RepLavRepaViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepLavRepaViewTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.RepLavRepaViewTableAdapter
End Class
