Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMCZDEFDESC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMCZDEFDESC))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnitem = New MetroFramework.Controls.MetroButton()
        Me.txtgrupo = New MetroFramework.Controls.MetroTextBox()
        Me.txtitem = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.LBH = New System.Windows.Forms.ListBox()
        Me.LBItem = New System.Windows.Forms.ListBox()
        Me.btnsalir = New MetroFramework.Controls.MetroButton()
        Me.btnGrupo = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Arrow Up.ico")
        Me.ImageList1.Images.SetKeyName(1, "Arrow Up.png")
        '
        'btnitem
        '
        Me.btnitem.BackgroundImage = CType(resources.GetObject("btnitem.BackgroundImage"), System.Drawing.Image)
        Me.btnitem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnitem.Location = New System.Drawing.Point(457, 315)
        Me.btnitem.Name = "btnitem"
        Me.btnitem.Size = New System.Drawing.Size(43, 38)
        Me.btnitem.TabIndex = 3
        Me.btnitem.UseSelectable = True
        '
        'txtgrupo
        '
        '
        '
        '
        Me.txtgrupo.CustomButton.Image = Nothing
        Me.txtgrupo.CustomButton.Location = New System.Drawing.Point(238, 2)
        Me.txtgrupo.CustomButton.Name = ""
        Me.txtgrupo.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtgrupo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtgrupo.CustomButton.TabIndex = 1
        Me.txtgrupo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtgrupo.CustomButton.UseSelectable = True
        Me.txtgrupo.CustomButton.Visible = False
        Me.txtgrupo.Lines = New String(-1) {}
        Me.txtgrupo.Location = New System.Drawing.Point(35, 355)
        Me.txtgrupo.MaxLength = 32767
        Me.txtgrupo.Name = "txtgrupo"
        Me.txtgrupo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtgrupo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtgrupo.SelectedText = ""
        Me.txtgrupo.SelectionLength = 0
        Me.txtgrupo.SelectionStart = 0
        Me.txtgrupo.ShortcutsEnabled = True
        Me.txtgrupo.Size = New System.Drawing.Size(256, 20)
        Me.txtgrupo.TabIndex = 4
        Me.txtgrupo.UseSelectable = True
        Me.txtgrupo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtgrupo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtitem
        '
        '
        '
        '
        Me.txtitem.CustomButton.Image = Nothing
        Me.txtitem.CustomButton.Location = New System.Drawing.Point(230, 2)
        Me.txtitem.CustomButton.Name = ""
        Me.txtitem.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtitem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtitem.CustomButton.TabIndex = 1
        Me.txtitem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtitem.CustomButton.UseSelectable = True
        Me.txtitem.CustomButton.Visible = False
        Me.txtitem.Lines = New String(-1) {}
        Me.txtitem.Location = New System.Drawing.Point(354, 355)
        Me.txtitem.MaxLength = 32767
        Me.txtitem.Name = "txtitem"
        Me.txtitem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtitem.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtitem.SelectedText = ""
        Me.txtitem.SelectionLength = 0
        Me.txtitem.SelectionStart = 0
        Me.txtitem.ShortcutsEnabled = True
        Me.txtitem.Size = New System.Drawing.Size(248, 20)
        Me.txtitem.TabIndex = 5
        Me.txtitem.UseSelectable = True
        Me.txtitem.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtitem.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(123, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Origen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(440, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Razón"
        '
        'LBH
        '
        Me.LBH.FormattingEnabled = True
        Me.LBH.HorizontalScrollbar = True
        Me.LBH.Location = New System.Drawing.Point(35, 110)
        Me.LBH.Name = "LBH"
        Me.LBH.ScrollAlwaysVisible = True
        Me.LBH.Size = New System.Drawing.Size(256, 199)
        Me.LBH.TabIndex = 8
        '
        'LBItem
        '
        Me.LBItem.FormattingEnabled = True
        Me.LBItem.Location = New System.Drawing.Point(355, 110)
        Me.LBItem.Name = "LBItem"
        Me.LBItem.Size = New System.Drawing.Size(247, 199)
        Me.LBItem.TabIndex = 9
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(280, 400)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 10
        Me.btnsalir.Text = "&Cancelar"
        Me.btnsalir.UseSelectable = True
        '
        'btnGrupo
        '
        Me.btnGrupo.BackgroundImage = CType(resources.GetObject("btnGrupo.BackgroundImage"), System.Drawing.Image)
        Me.btnGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGrupo.Location = New System.Drawing.Point(123, 315)
        Me.btnGrupo.Name = "btnGrupo"
        Me.btnGrupo.Size = New System.Drawing.Size(43, 38)
        Me.btnGrupo.TabIndex = 11
        Me.btnGrupo.UseSelectable = True
        '
        'ABMCZDEFDESC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 446)
        Me.Controls.Add(Me.btnGrupo)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.LBItem)
        Me.Controls.Add(Me.LBH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtitem)
        Me.Controls.Add(Me.txtgrupo)
        Me.Controls.Add(Me.btnitem)
        Me.Name = "ABMCZDEFDESC"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Defectos descalificantes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnitem As MetroButton
    Friend WithEvents txtgrupo As MetroTextBox
    Friend WithEvents txtitem As MetroTextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents LBH As ListBox
    Friend WithEvents LBItem As ListBox
    Friend WithEvents btnsalir As MetroButton
    Friend WithEvents btnGrupo As MetroButton
End Class
