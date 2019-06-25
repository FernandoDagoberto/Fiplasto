<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepoViewM48
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
        Me.CRTLSULFENSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FIPLANEWDataSetTotal = New SPIF.FIPLANEWDataSetTotal()
        Me.RepoView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CRTLSULFALUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRTLSULFALUTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.CRTLSULFALUTableAdapter()
        Me.CRTLSULFENSTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.CRTLSULFENSTableAdapter()
        Me.CRTLVARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRTLVARTableAdapter = New SPIF.FIPLANEWDataSetTotalTableAdapters.CRTLVARTableAdapter()
        CType(Me.CRTLSULFENSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FIPLANEWDataSetTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRTLSULFALUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRTLVARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRTLSULFENSBindingSource
        '
        Me.CRTLSULFENSBindingSource.DataMember = "CRTLSULFENS"
        Me.CRTLSULFENSBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'FIPLANEWDataSetTotal
        '
        Me.FIPLANEWDataSetTotal.DataSetName = "FIPLANEWDataSetTotal"
        Me.FIPLANEWDataSetTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepoView
        '
        Me.RepoView.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "FIPLANEWDataSetTotal_CRTLVAR"
        ReportDataSource1.Value = Me.CRTLVARBindingSource
        Me.RepoView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RepoView.LocalReport.ReportEmbeddedResource = "SPIF.rptM48var.rdlc"
        Me.RepoView.Location = New System.Drawing.Point(5, 60)
        Me.RepoView.Name = "RepoView"
        Me.RepoView.Size = New System.Drawing.Size(899, 396)
        Me.RepoView.TabIndex = 0
        '
        'CRTLSULFALUBindingSource
        '
        Me.CRTLSULFALUBindingSource.DataMember = "CRTLSULFALU"
        Me.CRTLSULFALUBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'CRTLSULFALUTableAdapter
        '
        Me.CRTLSULFALUTableAdapter.ClearBeforeFill = True
        '
        'CRTLSULFENSTableAdapter
        '
        Me.CRTLSULFENSTableAdapter.ClearBeforeFill = True
        '
        'CRTLVARBindingSource
        '
        Me.CRTLVARBindingSource.DataMember = "CRTLVAR"
        Me.CRTLVARBindingSource.DataSource = Me.FIPLANEWDataSetTotal
        '
        'CRTLVARTableAdapter
        '
        Me.CRTLVARTableAdapter.ClearBeforeFill = True
        '
        'frmRepoViewM48
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 461)
        Me.Controls.Add(Me.RepoView)
        Me.Name = "frmRepoViewM48"
        Me.Padding = New System.Windows.Forms.Padding(5, 60, 5, 5)
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CRTLSULFENSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FIPLANEWDataSetTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRTLSULFALUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRTLVARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RepoView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CRTLSULFALUBindingSource As BindingSource
    Friend WithEvents FIPLANEWDataSetTotal As FIPLANEWDataSetTotal
    Friend WithEvents CRTLSULFALUTableAdapter As FIPLANEWDataSetTotalTableAdapters.CRTLSULFALUTableAdapter
    Friend WithEvents CRTLSULFENSBindingSource As BindingSource
    Friend WithEvents CRTLSULFENSTableAdapter As FIPLANEWDataSetTotalTableAdapters.CRTLSULFENSTableAdapter
    Friend WithEvents CRTLVARBindingSource As BindingSource
    Friend WithEvents CRTLVARTableAdapter As FIPLANEWDataSetTotalTableAdapters.CRTLVARTableAdapter
End Class
