Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelGraficos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelGraficos))
        Me.encabezado = New MetroFramework.Controls.MetroPanel()
        Me.Button2 = New MetroFramework.Controls.MetroButton()
        Me.lblOpciones = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.dtHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New MetroFramework.Controls.MetroPanel()
        Me.Panel2 = New MetroFramework.Controls.MetroPanel()
        Me.Panel1 = New MetroFramework.Controls.MetroPanel()
        Me.Panel0 = New MetroFramework.Controls.MetroPanel()
        Me.encabezado.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'encabezado
        '
        Me.encabezado.Controls.Add(Me.Button2)
        Me.encabezado.Controls.Add(Me.lblOpciones)
        Me.encabezado.Controls.Add(Me.Label2)
        Me.encabezado.Controls.Add(Me.Label1)
        Me.encabezado.Controls.Add(Me.dtHasta)
        Me.encabezado.Controls.Add(Me.dtDesde)
        Me.encabezado.Controls.Add(Me.Button1)
        Me.encabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.encabezado.HorizontalScrollbarBarColor = True
        Me.encabezado.HorizontalScrollbarHighlightOnWheel = False
        Me.encabezado.HorizontalScrollbarSize = 10
        Me.encabezado.Location = New System.Drawing.Point(20, 60)
        Me.encabezado.Name = "encabezado"
        Me.encabezado.Size = New System.Drawing.Size(1205, 44)
        Me.encabezado.TabIndex = 3
        Me.encabezado.VerticalScrollbarBarColor = True
        Me.encabezado.VerticalScrollbarHighlightOnWheel = False
        Me.encabezado.VerticalScrollbarSize = 10
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 38)
        Me.Button2.TabIndex = 5
        Me.Button2.Tag = "Imprimir"
        Me.Button2.UseSelectable = True
        '
        'lblOpciones
        '
        Me.lblOpciones.AutoSize = True
        Me.lblOpciones.ForeColor = System.Drawing.Color.Blue
        Me.lblOpciones.Location = New System.Drawing.Point(1050, 13)
        Me.lblOpciones.Name = "lblOpciones"
        Me.lblOpciones.Size = New System.Drawing.Size(128, 19)
        Me.lblOpciones.Style = MetroFramework.MetroColorStyle.Orange
        Me.lblOpciones.TabIndex = 4
        Me.lblOpciones.Text = "Seleccionar reportes"
        Me.lblOpciones.UseStyleColors = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(545, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(359, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde:"
        '
        'dtHasta
        '
        Me.dtHasta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtHasta.Location = New System.Drawing.Point(595, 11)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(102, 23)
        Me.dtHasta.TabIndex = 1
        '
        'dtDesde
        '
        Me.dtDesde.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDesde.Location = New System.Drawing.Point(413, 11)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(99, 23)
        Me.dtDesde.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(717, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Generar"
        Me.Button1.UseSelectable = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel0, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 104)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1205, 522)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.HorizontalScrollbarBarColor = True
        Me.Panel3.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel3.HorizontalScrollbarSize = 10
        Me.Panel3.Location = New System.Drawing.Point(605, 264)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(597, 255)
        Me.Panel3.TabIndex = 4
        Me.Panel3.VerticalScrollbarBarColor = True
        Me.Panel3.VerticalScrollbarHighlightOnWheel = False
        Me.Panel3.VerticalScrollbarSize = 10
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.HorizontalScrollbarBarColor = True
        Me.Panel2.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel2.HorizontalScrollbarSize = 10
        Me.Panel2.Location = New System.Drawing.Point(3, 264)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(596, 255)
        Me.Panel2.TabIndex = 3
        Me.Panel2.VerticalScrollbarBarColor = True
        Me.Panel2.VerticalScrollbarHighlightOnWheel = False
        Me.Panel2.VerticalScrollbarSize = 10
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.HorizontalScrollbarBarColor = True
        Me.Panel1.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel1.HorizontalScrollbarSize = 10
        Me.Panel1.Location = New System.Drawing.Point(605, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 255)
        Me.Panel1.TabIndex = 1
        Me.Panel1.VerticalScrollbarBarColor = True
        Me.Panel1.VerticalScrollbarHighlightOnWheel = False
        Me.Panel1.VerticalScrollbarSize = 10
        '
        'Panel0
        '
        Me.Panel0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel0.HorizontalScrollbarBarColor = True
        Me.Panel0.HorizontalScrollbarHighlightOnWheel = False
        Me.Panel0.HorizontalScrollbarSize = 10
        Me.Panel0.Location = New System.Drawing.Point(3, 3)
        Me.Panel0.Name = "Panel0"
        Me.Panel0.Size = New System.Drawing.Size(596, 255)
        Me.Panel0.TabIndex = 0
        Me.Panel0.VerticalScrollbarBarColor = True
        Me.Panel0.VerticalScrollbarHighlightOnWheel = False
        Me.Panel0.VerticalScrollbarSize = 10
        '
        'PanelGraficos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 646)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.encabezado)
        Me.Name = "PanelGraficos"
        Me.Text = "Panel de gráficos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.encabezado.ResumeLayout(False)
        Me.encabezado.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents encabezado As MetroPanel
    Friend WithEvents Button1 As MetroButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel0 As MetroPanel
    Friend WithEvents Panel1 As MetroPanel
    Friend WithEvents Panel3 As MetroPanel
    Friend WithEvents Panel2 As MetroPanel
    Friend WithEvents dtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents lblOpciones As MetroLabel
    Friend WithEvents Button2 As MetroButton
End Class
