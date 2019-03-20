Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TranfsMadVig
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
        Me.btncargar = New MetroFramework.Controls.MetroButton()
        Me.txtcant = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.lbltna = New MetroFramework.Controls.MetroLabel()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.cba = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.cbgrupo = New MetroFramework.Controls.MetroComboBox()
        Me.cbturno = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'btncargar
        '
        Me.btncargar.Location = New System.Drawing.Point(190, 169)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(70, 23)
        Me.btncargar.TabIndex = 4
        Me.btncargar.Text = "&Transferir"
        Me.btncargar.UseSelectable = True
        '
        'txtcant
        '
        '
        '
        '
        Me.txtcant.CustomButton.Image = Nothing
        Me.txtcant.CustomButton.Location = New System.Drawing.Point(44, 2)
        Me.txtcant.CustomButton.Name = ""
        Me.txtcant.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtcant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcant.CustomButton.TabIndex = 1
        Me.txtcant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcant.CustomButton.UseSelectable = True
        Me.txtcant.CustomButton.Visible = False
        Me.txtcant.Lines = New String(-1) {}
        Me.txtcant.Location = New System.Drawing.Point(58, 132)
        Me.txtcant.MaxLength = 32767
        Me.txtcant.Name = "txtcant"
        Me.txtcant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcant.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcant.SelectedText = ""
        Me.txtcant.SelectionLength = 0
        Me.txtcant.SelectionStart = 0
        Me.txtcant.ShortcutsEnabled = True
        Me.txtcant.Size = New System.Drawing.Size(62, 20)
        Me.txtcant.TabIndex = 2
        Me.txtcant.UseSelectable = True
        Me.txtcant.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcant.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(43, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "TN a transferir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(162, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "A pila:"
        '
        'lbltna
        '
        Me.lbltna.AutoSize = True
        Me.lbltna.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltna.Location = New System.Drawing.Point(297, 159)
        Me.lbltna.Name = "lbltna"
        Me.lbltna.Size = New System.Drawing.Size(0, 0)
        Me.lbltna.TabIndex = 23
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(112, 169)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(70, 23)
        Me.btncancelar.TabIndex = 5
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'cba
        '
        Me.cba.Enabled = False
        Me.cba.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cba.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cba.FormattingEnabled = True
        Me.cba.ItemHeight = 19
        Me.cba.Location = New System.Drawing.Point(151, 127)
        Me.cba.Name = "cba"
        Me.cba.Size = New System.Drawing.Size(62, 25)
        Me.cba.TabIndex = 3
        Me.cba.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(162, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Grupo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(67, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Turno"
        '
        'cbgrupo
        '
        Me.cbgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbgrupo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbgrupo.FormattingEnabled = True
        Me.cbgrupo.ItemHeight = 19
        Me.cbgrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbgrupo.Location = New System.Drawing.Point(151, 68)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(62, 25)
        Me.cbgrupo.TabIndex = 1
        Me.cbgrupo.UseSelectable = True
        '
        'cbturno
        '
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.ItemHeight = 19
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(58, 68)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(62, 25)
        Me.cbturno.TabIndex = 0
        Me.cbturno.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroLabel1.Location = New System.Drawing.Point(8, 23)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(252, 19)
        Me.MetroLabel1.TabIndex = 30
        Me.MetroLabel1.Text = "Tranferencia de consumo a pila de vigas"
        '
        'TranfsMadVig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 215)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.cbgrupo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cba)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.lbltna)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcant)
        Me.Controls.Add(Me.btncargar)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TranfsMadVig"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncargar As MetroButton
    Friend WithEvents txtcant As MetroTextBox
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents lbltna As MetroLabel
    Friend WithEvents btncancelar As MetroButton
    Friend WithEvents cba As MetroComboBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents cbgrupo As MetroComboBox
    Friend WithEvents cbturno As MetroComboBox
    Friend WithEvents MetroLabel1 As MetroLabel
End Class
