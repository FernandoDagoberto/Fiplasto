<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmREPOViewPic
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
        Me.MaderaPicadaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FIPLANEWDataSetTotal = New SPIF.FIPLANEWDataSetTotal()
        Me.NivelSiloViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MARMVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRAJINVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepoView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MADRAJBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescargaCamionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescargaCamionTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.DescargaCamionTableAdapter()
        Me.MADRAJTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.MADRAJTableAdapter()
        Me.TRAJINVTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.TRAJINVTableAdapter()
        Me.MARMVTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.MARMVTableAdapter()
        Me.MaderaPicadaTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.MaderaPicadaTableAdapter()
        Me.NivelSiloViewTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.NivelSiloViewTableAdapter()
        Me.StockPlayaTotalxVariedadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockPlayaTotalxVariedadTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.StockPlayaTotalxVariedadTableAdapter()
        CType(Me.MaderaPicadaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FIPLANEWDataSetTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NivelSiloViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MARMVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRAJINVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MADRAJBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescargaCamionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockPlayaTotalxVariedadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaderaPicadaBindingSource
        '
        Me.MaderaPicadaBindingSource.DataMember = "MaderaPicada"
        Me.MaderaPicadaBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'FIPLANEWDataSetTotal
        '
        Me.FIPLANEWDataSetTotal.DataSetName = "FIPLANEWDataSetTotal"
        Me.FIPLANEWDataSetTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NivelSiloViewBindingSource
        '
        Me.NivelSiloViewBindingSource.DataMember = "NivelSiloView"
        Me.NivelSiloViewBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'MARMVBindingSource
        '
        Me.MARMVBindingSource.DataMember = "MARMV"
        Me.MARMVBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'TRAJINVBindingSource
        '
        Me.TRAJINVBindingSource.DataMember = "TRAJINV"
        Me.TRAJINVBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'RepoView
        '
        Me.RepoView.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.StockPlayaTotalxVariedadBindingSource
        Me.RepoView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rtpStockPlayaXVariedad.rdlc"
        Me.RepoView.Location = New System.Drawing.Point(5, 60)
        Me.RepoView.Name = "RepoView"
        Me.RepoView.ShowDocumentMapButton = False
        Me.RepoView.Size = New System.Drawing.Size(814, 420)
        Me.RepoView.TabIndex = 0
        '
        'MADRAJBindingSource
        '
        Me.MADRAJBindingSource.DataMember = "MADRAJ"
        Me.MADRAJBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'DescargaCamionBindingSource
        '
        Me.DescargaCamionBindingSource.DataMember = "DescargaCamion"
        Me.DescargaCamionBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'DescargaCamionTableAdapter
        '
        Me.DescargaCamionTableAdapter.ClearBeforeFill = True
        '
        'MADRAJTableAdapter
        '
        Me.MADRAJTableAdapter.ClearBeforeFill = True
        '
        'TRAJINVTableAdapter
        '
        Me.TRAJINVTableAdapter.ClearBeforeFill = True
        '
        'MARMVTableAdapter
        '
        Me.MARMVTableAdapter.ClearBeforeFill = True
        '
        'MaderaPicadaTableAdapter
        '
        Me.MaderaPicadaTableAdapter.ClearBeforeFill = True
        '
        'NivelSiloViewTableAdapter
        '
        Me.NivelSiloViewTableAdapter.ClearBeforeFill = True
        '
        'StockPlayaTotalxVariedadBindingSource
        '
        Me.StockPlayaTotalxVariedadBindingSource.DataMember = "StockPlayaTotalxVariedad"
        Me.StockPlayaTotalxVariedadBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'StockPlayaTotalxVariedadTableAdapter
        '
        Me.StockPlayaTotalxVariedadTableAdapter.ClearBeforeFill = True
        '
        'frmREPOViewPic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 485)
        Me.Controls.Add(Me.RepoView)
        Me.Name = "frmREPOViewPic"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Text = "Reportes"
        Me.WindowState = FormWindowState.Maximized
        CType(Me.MaderaPicadaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FIPLANEWDataSetTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NivelSiloViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MARMVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRAJINVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MADRAJBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescargaCamionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockPlayaTotalxVariedadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepoView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MCENSAYOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MCENSAYOTQ3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CRTLSULFENSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MCVARPROCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Descarga_CamionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescargaCamionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FIPLANEWDataSetTotal As SPIF.FIPLANEWDataSetTotal
    Friend WithEvents DescargaCamionTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.DescargaCamionTableAdapter
    Friend WithEvents MADRAJBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MADRAJTableAdapter As SPIF.FIPLANEWDataSetTotalTableAdapters.MADRAJTableAdapter
    Friend WithEvents TRAJINVBindingSource As BindingSource
    Friend WithEvents TRAJINVTableAdapter As FIPLANEWDataSetTotalTableAdapters.TRAJINVTableAdapter
    Friend WithEvents MARMVBindingSource As BindingSource
    Friend WithEvents MARMVTableAdapter As FIPLANEWDataSetTotalTableAdapters.MARMVTableAdapter
    Friend WithEvents MaderaPicadaBindingSource As BindingSource
    Friend WithEvents MaderaPicadaTableAdapter As FIPLANEWDataSetTotalTableAdapters.MaderaPicadaTableAdapter
    Friend WithEvents NivelSiloViewBindingSource As BindingSource
    Friend WithEvents NivelSiloViewTableAdapter As FIPLANEWDataSetTotalTableAdapters.NivelSiloViewTableAdapter
    Friend WithEvents StockPlayaTotalxVariedadBindingSource As BindingSource
    Friend WithEvents StockPlayaTotalxVariedadTableAdapter As FIPLANEWDataSetTotalTableAdapters.StockPlayaTotalxVariedadTableAdapter
End Class
