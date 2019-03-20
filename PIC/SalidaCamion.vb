Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework.Controls
Imports MetroFramework

Public Class SalidaCamion
    Inherits MetroFramework.Forms.MetroForm
    Dim ingegr As String
    Dim pila, valor As Integer

    Dim sql, sql1, sql2, sql3, sql4, sql5 As String
    Dim da, da1, da3, da5 As New SqlDataAdapter
    Dim cmd, cmd2, cmd3, cmd4, cmd5 As SqlCommand
    Dim dt As DataTable = New DataTable
    Dim dt1 As DataTable = New DataTable
    Dim dt3 As DataTable = New DataTable
    Dim dt5 As DataTable = New DataTable
    Dim TextCol1 As New DataGridTextBoxColumn
    Dim TextCol2 As New DataGridTextBoxColumn
    Dim sen, campos, variables, idl, dias As String
    Dim line, ms As Integer
    Friend WithEvents btnbusco As MetroButton
    Friend WithEvents txtfecha As MetroTextBox
    Friend WithEvents Label3 As MetroLabel
    Friend WithEvents txttdesc As MetroTextBox
    Friend WithEvents Label4 As MetroLabel
    Friend WithEvents txttcod As MetroTextBox
    Friend WithEvents txtpcod As MetroTextBox
    Friend WithEvents txtpdesc As MetroTextBox
    Friend WithEvents Label5 As MetroLabel
    Friend WithEvents txtchofer As MetroTextBox
    Friend WithEvents Label6 As MetroLabel
    Friend WithEvents txtdni As MetroTextBox
    Friend WithEvents Label7 As MetroLabel
    Friend WithEvents btnguardar As MetroButton
    Friend WithEvents txtpbruto As MetroTextBox
    Friend WithEvents PBar As System.Windows.Forms.ProgressBar
    Friend WithEvents txthora As MetroTextBox
    Friend WithEvents Label10 As MetroLabel
    Friend WithEvents txtpatente As MetroTextBox
    Friend WithEvents Label1 As MetroLabel
    Friend WithEvents txttara As MetroTextBox
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents txtneto As MetroTextBox
    Friend WithEvents Label11 As MetroLabel
    Friend WithEvents Label9 As MetroLabel

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btncancel As MetroButton
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents txtticket As MetroTextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalidaCamion))
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btncancel = New MetroButton()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.txtticket = New MetroTextBox()
        Me.btnbusco = New MetroButton()
        Me.txtfecha = New MetroTextBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.txttdesc = New MetroTextBox()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.txttcod = New MetroTextBox()
        Me.txtpcod = New MetroTextBox()
        Me.txtpdesc = New MetroTextBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.txtchofer = New MetroTextBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.txtdni = New MetroTextBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.btnguardar = New MetroButton()
        Me.txtpbruto = New MetroTextBox()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.PBar = New System.Windows.Forms.ProgressBar()
        Me.txthora = New MetroTextBox()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.txtpatente = New MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txttara = New MetroTextBox()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.txtneto = New MetroTextBox()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3, Me.ToolBarButton5, Me.ToolBarButton4})
        Me.ToolBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(-2, -2)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(682, 29)
        Me.ToolBar1.TabIndex = 3
        Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 12
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "Nuevo"
        Me.ToolBarButton1.ToolTipText = "Nuevo"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 16
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Text = "Editar"
        Me.ToolBarButton2.ToolTipText = "Editar"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 11
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.Text = "Borrar"
        Me.ToolBarButton3.ToolTipText = "Borrar"
        Me.ToolBarButton3.Visible = False
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 22
        Me.ToolBarButton5.Name = "ToolBarButton5"
        Me.ToolBarButton5.Text = "Guardar"
        Me.ToolBarButton5.ToolTipText = "Guardar"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 15
        Me.ToolBarButton4.Name = "ToolBarButton4"
        Me.ToolBarButton4.Text = "Salir"
        Me.ToolBarButton4.ToolTipText = "Salir"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        Me.ImageList1.Images.SetKeyName(14, "")
        Me.ImageList1.Images.SetKeyName(15, "")
        Me.ImageList1.Images.SetKeyName(16, "")
        Me.ImageList1.Images.SetKeyName(17, "")
        Me.ImageList1.Images.SetKeyName(18, "")
        Me.ImageList1.Images.SetKeyName(19, "")
        Me.ImageList1.Images.SetKeyName(20, "")
        Me.ImageList1.Images.SetKeyName(21, "")
        Me.ImageList1.Images.SetKeyName(22, "")
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncancel.Location = New System.Drawing.Point(312, 312)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 24)
        Me.btncancel.TabIndex = 4
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(16, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nro. Ticket"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtticket
        '

        Me.txtticket.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtticket.Location = New System.Drawing.Point(16, 48)
        Me.txtticket.MaxLength = 6
        Me.txtticket.Name = "txtticket"
        Me.txtticket.Size = New System.Drawing.Size(88, 20)
        Me.txtticket.TabIndex = 1
        Me.txtticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnbusco
        '
        Me.btnbusco.Location = New System.Drawing.Point(104, 48)
        Me.btnbusco.Name = "btnbusco"
        Me.btnbusco.Size = New System.Drawing.Size(32, 20)
        Me.btnbusco.TabIndex = 2
        Me.btnbusco.Text = "..."
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(117, 95)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.ReadOnly = True
        Me.txtfecha.Size = New System.Drawing.Size(88, 20)
        Me.txtfecha.TabIndex = 23
        Me.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(109, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Fecha Egreso"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttdesc
        '
        Me.txttdesc.Location = New System.Drawing.Point(88, 144)
        Me.txttdesc.Name = "txttdesc"
        Me.txttdesc.ReadOnly = True
        Me.txttdesc.Size = New System.Drawing.Size(392, 20)
        Me.txttdesc.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(16, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Transporte"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttcod
        '
        Me.txttcod.Location = New System.Drawing.Point(16, 144)
        Me.txttcod.Name = "txttcod"
        Me.txttcod.ReadOnly = True
        Me.txttcod.Size = New System.Drawing.Size(69, 20)
        Me.txttcod.TabIndex = 27
        Me.txttcod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpcod
        '
        Me.txtpcod.Location = New System.Drawing.Point(16, 240)
        Me.txtpcod.Name = "txtpcod"
        Me.txtpcod.ReadOnly = True
        Me.txtpcod.Size = New System.Drawing.Size(69, 20)
        Me.txtpcod.TabIndex = 30
        Me.txtpcod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpdesc
        '
        Me.txtpdesc.Location = New System.Drawing.Point(88, 240)
        Me.txtpdesc.Name = "txtpdesc"
        Me.txtpdesc.ReadOnly = True
        Me.txtpdesc.Size = New System.Drawing.Size(392, 20)
        Me.txtpdesc.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(16, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Producto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtchofer
        '
        Me.txtchofer.Location = New System.Drawing.Point(16, 192)
        Me.txtchofer.Name = "txtchofer"
        Me.txtchofer.ReadOnly = True
        Me.txtchofer.Size = New System.Drawing.Size(232, 20)
        Me.txtchofer.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(16, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Chofer"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(256, 192)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.ReadOnly = True
        Me.txtdni.Size = New System.Drawing.Size(88, 20)
        Me.txtdni.TabIndex = 33
        Me.txtdni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(256, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "DNI"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(392, 312)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(88, 24)
        Me.btnguardar.TabIndex = 5
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.Visible = False
        '
        'txtpbruto
        '
        Me.txtpbruto.Location = New System.Drawing.Point(16, 288)
        Me.txtpbruto.Name = "txtpbruto"
        Me.txtpbruto.ReadOnly = True
        Me.txtpbruto.Size = New System.Drawing.Size(88, 20)
        Me.txtpbruto.TabIndex = 38
        Me.txtpbruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(16, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Peso Bruto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PBar
        '
        Me.PBar.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PBar.Location = New System.Drawing.Point(16, 320)
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(280, 10)
        Me.PBar.TabIndex = 40
        Me.PBar.Visible = False
        '
        'txthora
        '
        Me.txthora.Location = New System.Drawing.Point(216, 96)
        Me.txthora.Name = "txthora"
        Me.txthora.ReadOnly = True
        Me.txthora.Size = New System.Drawing.Size(88, 20)
        Me.txthora.TabIndex = 41
        Me.txthora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(216, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Hora Egreso"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpatente
        '
        Me.txtpatente.Location = New System.Drawing.Point(16, 95)
        Me.txtpatente.Name = "txtpatente"
        Me.txtpatente.ReadOnly = True
        Me.txtpatente.Size = New System.Drawing.Size(88, 20)
        Me.txtpatente.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(16, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Patente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txttara
        '
        Me.txttara.Location = New System.Drawing.Point(125, 288)
        Me.txttara.Name = "txttara"
        Me.txttara.ReadOnly = True
        Me.txttara.Size = New System.Drawing.Size(88, 20)
        Me.txttara.TabIndex = 45
        Me.txttara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(125, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Tara"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtneto
        '
        Me.txtneto.Location = New System.Drawing.Point(234, 288)
        Me.txtneto.Name = "txtneto"
        Me.txtneto.ReadOnly = True
        Me.txtneto.Size = New System.Drawing.Size(88, 20)
        Me.txtneto.TabIndex = 47
        Me.txtneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(234, 272)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Peso Neto"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SalidaCamion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(497, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtneto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txttara)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpatente)
        Me.Controls.Add(Me.txthora)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PBar)
        Me.Controls.Add(Me.txtpbruto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtchofer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpcod)
        Me.Controls.Add(Me.txtpdesc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttcod)
        Me.Controls.Add(Me.txttdesc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnbusco)
        Me.Controls.Add(Me.txtticket)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SalidaCamion"
        Me.StartPosition = FormStartPosition.Manual
        Me.Text = "Salida Camion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub salidacamion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call bloquea()
        ToolBar1.Buttons(3).Enabled = False
        ToolBar1.Buttons(1).Enabled = True
        ToolBar1.Buttons(2).Enabled = False

    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 ' boton nuevo
                sen = "n"
                btncancel.Visible = True
                btnguardar.Visible = True
                ToolBar1.Buttons(3).Enabled = True
                ToolBar1.Buttons(1).Enabled = False
                ToolBar1.Buttons(2).Enabled = False
                Call habilita()
                txtticket.Focus()

            Case 1 'boton editar
                sen = "m"
                btncancel.Visible = True
                btnguardar.Visible = True
                ToolBar1.Buttons(0).Enabled = False
                ToolBar1.Buttons(2).Enabled = False
                ToolBar1.Buttons(3).Enabled = True
                Call habilita()
                Call modifica()
            Case 2 ' boton borrar

            Case 3 'boton guardar
                If txtticket.Text = "" Then
                    MetroMessageBox.Show(Me, "Favor de ingresar número de ticket", MsgBoxStyle.Critical)
                    txtticket.Focus()
                    txtticket.Select()
                Else
                    Call buscasiexiste()
                    If n = 0 Or sen = "m" Then
                        Call guardar()
                    Else
                        Call yaexiste()
                    End If
                End If

            Case 4 ' boton salir
                Me.Close()
        End Select
    End Sub
    Private Sub guardar()
        If txtticket.Text = "" Then
            MetroMessageBox.Show(Me, "El campo Nro ticket es obligatorio", MsgBoxStyle.Critical)
            txtticket.Focus()
            txtticket.Select()

        Else
            Call guardanuevo()
            Call limpia()
            If ToolBar1.Buttons(0).Enabled = False Then ToolBar1.Buttons(0).Enabled = True
            If ToolBar1.Buttons(1).Enabled = False Then ToolBar1.Buttons(1).Enabled = False
            If ToolBar1.Buttons(2).Enabled = False Then ToolBar1.Buttons(2).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            btncancel.Visible = False
            btnguardar.Visible = False
        End If

    End Sub
    Private Sub modifica()
        txtticket.Focus()
    End Sub
    Private Sub habilita()
        txtticket.Enabled = True

    End Sub
    Private Sub deshabilita()
        txtticket.Enabled = False

    End Sub
    Private Sub limpia()
        txtticket.Text = ""
        txtpatente.Text = ""

        txtfecha.Text = ""
        txthora.Text = ""
        txttcod.Text = ""
        txttdesc.Text = ""
        txtchofer.Text = ""
        txtdni.Text = ""
        txtpcod.Text = ""
        txtpdesc.Text = ""
        txtpbruto.Text = ""
        txtneto.Text = ""
        txttara.Text = ""
    End Sub
    Private Sub buscadatos(ByVal ticket)

        If sen = "n" Then
            conexA("camion")
            sql = "SELECT * From REPORTE WHERE ticket=" + ticket + ""
            daA = New OleDbDataAdapter(sql, cnnA)
            dt = New DataTable
            daA.Fill(dt)
            n = dt.Rows.Count
        Else
            conex("Camion")
            sql5 = "SELECT * From camion where camion_ticket='" + RTrim(ticket) + "'"
            da5 = New SqlDataAdapter(sql5, cnn)
            dt5 = New DataTable
            da5.Fill(dt5)
            n = dt5.Rows.Count
        End If
    End Sub
    'Private Sub conexion()
    '    cnn = New SqlConnection("Database=ganado;user id=sa;password=;Data Source=(local);")
    'End Sub
    Private Sub bloquea()
        txtticket.Enabled = False
    End Sub


    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        sen = "m"
        btncancel.Visible = True
        ToolBar1.Buttons(0).Enabled = False
        ToolBar1.Buttons(2).Enabled = False
        ToolBar1.Buttons(3).Enabled = True
        Call habilita()
        Call modifica()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Call limpia()
        ToolBar1.Buttons(0).Enabled = True
        ToolBar1.Buttons(1).Enabled = True
        ToolBar1.Buttons(2).Enabled = True
        ToolBar1.Buttons(3).Enabled = False
        Call deshabilita()
        btncancel.Visible = False
        btnguardar.Visible = False
        ToolBar1.Focus()
    End Sub
    Private Sub guardanuevo()
        btncancel.Visible = False
        btnguardar.Visible = False
        conex("Camion")
        sql5 = "SELECT * From camion inner join marmv on camion.camion_nroremito=marmv.marmv_nroremito where camion_ticket='" + txtticket.Text + "'"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        n = dt5.Rows.Count

        If n = 0 Then
            MetroMessageBox.Show(Me, "No existe número de ticket")

        Else

            sql2 = "update camion set camion_pesotara='" + Trim(txttara.Text) + "',camion_pesoneto='" + Trim(txtneto.Text) + "', camion_fechaegr='" + Trim(txtfecha.Text) + "',camion_horaegr='" + FormatDateTime(Trim(txthora.Text), DateFormat.ShortTime) + "' " &
                   " where camion_ticket='" + Trim(txtticket.Text) + "' "
            cmd2 = New SqlCommand(sql2, cnn)
            cmd2.Connection.Open()
            cmd2.ExecuteNonQuery()
            cmd2.Connection.Close()


            sql3 = "update marmv set marmv_neto='" + txtneto.Text + "' where marmv_ingegr='I' and marmv_nroremito='" + Str(dt5.Rows(0).Item("camion_nroremito")) + "' "
            cmd3 = New SqlCommand(sql3, cnn)
            cmd3.Connection.Open()
            cmd3.ExecuteNonQuery()
            cmd3.Connection.Close()


            Call ActualizaStock()

            'Contrala sí la pila se llenó
            Call pilallena()




        End If
        Call bloquea()
        barra(PBar)


    End Sub



    Private Sub btnbusco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbusco.Click
        Call busco()

    End Sub
    Private Sub busco()
        Call buscadatos(txtticket.Text)
        If n <> 0 And sen = "n" Then
            txtpatente.Text = dt.Rows(0).Item("patente")
            txtfecha.Text = dt.Rows(0).Item("fecha_2")
            txthora.Text = dt.Rows(0).Item("hora_2")
            txttcod.Text = dt.Rows(0).Item("t_codigo")
            txttdesc.Text = dt.Rows(0).Item("t_nombre")
            txtchofer.Text = dt.Rows(0).Item("chofer")
            txtdni.Text = Format(dt.Rows(0).Item("dni"), "##.###.###")
            txtpcod.Text = dt.Rows(0).Item("p_codigo")
            txtpdesc.Text = dt.Rows(0).Item("p_nombre")
            txtpbruto.Text = Format(dt.Rows(0).Item("bruto"), "0#.##")
            txttara.Text = Format(dt.Rows(0).Item("tara"), "0#.##")
            txtneto.Text = Format(dt.Rows(0).Item("neto"), "0#.##")

        ElseIf n <> 0 And sen = "m" Then
            txtticket.Text = dt5.Rows(0).Item("camion_ticket")
            txtpatente.Text = dt5.Rows(0).Item("camion_patente")
            txtfecha.Text = dt5.Rows(0).Item("camion_fechaegr")
            txthora.Text = dt5.Rows(0).Item("camion_horaegr")
            txttcod.Text = dt5.Rows(0).Item("camion_tcod")
            txttdesc.Text = dt5.Rows(0).Item("camion_tdesc")
            txtchofer.Text = dt5.Rows(0).Item("camion_chofer")
            txtdni.Text = Format(CInt(dt5.Rows(0).Item("camion_dni")), "0#.###.###")
            txtpcod.Text = dt5.Rows(0).Item("camion_pcod")
            txtpdesc.Text = dt5.Rows(0).Item("camion_pdesc")
            txtpbruto.Text = Format(dt5.Rows(0).Item("camion_pesobruto"), "0#.##")
            txttara.Text = Format(dt5.Rows(0).Item("camion_pesotara"), "0#.##")
            txtneto.Text = Format(dt5.Rows(0).Item("camion_pesoneto"), "0#.##")
        Else
            MetroMessageBox.Show(Me, "Camión en planta", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If txtticket.Text = "" Then
            MetroMessageBox.Show(Me, "Favor de Ingresar número de ticket", MsgBoxStyle.Critical)
            txtticket.Focus()
            txtticket.Select()
        Else
            Call buscasiexiste()
            If n = 0 Or sen = "m" Then
                Call guardar()
            Else
                Call yaexiste()
            End If
        End If
    End Sub
    Private Sub yaexiste()
        MetroMessageBox.Show(Me, "Ese camion ya tiene actualizado el peso neto y la tara")
        Call limpia()
        txtticket.Focus()
        n = 0
    End Sub
    Private Sub buscasiexiste()
        conex("Camion")
        sql5 = "SELECT * From camion where camion_ticket='" + txtticket.Text + "' and (camion_pesotara > 0) AND (camion_pesoneto > 0)"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        n = dt5.Rows.Count
    End Sub

    Private Sub txtticket_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtticket.KeyUp
        If e.KeyCode = Keys.Enter Then
            Call busco()
            txtticket.Focus()
            txtticket.Select()
        End If
    End Sub

    Sub ActualizaStock()
        sql3 = "select * from stpila where stpila_pila='" + Trim(dt5.Rows(0).Item("marmv_pila")) + "'"
        da3 = New SqlDataAdapter(sql3, cnn)
        dt3 = New DataTable
        da3.Fill(dt3)
        n = dt3.Rows.Count
        If n = 0 Then
            Exit Sub
        Else

            pila = dt5.Rows(0).Item("marmv_pila")
            valor = txtneto.Text
            stock = dt3.Rows(0).Item("stpila_stock")
            stock = stock + valor

            sql2 = "update stpila set stpila_stock='" + Str(stock) + "' where stpila_pila='" + Str(pila) + "'"
            cmd2 = New SqlCommand(sql2, cnn)
            cmd2.Connection.Open()
            cmd2.ExecuteNonQuery()
            cmd2.Connection.Close()
            sql2 = ""
        End If



    End Sub


    Sub pilallena()
        sql = "SELECT (Pila.Pila_tn * 1000 - STPILA.stpila_stock) AS control FROM STPILA INNER JOIN Pila ON STPILA.stpila_pila = Pila.Pila_ID where pila.pila_id='" + Trim(pila) + "' "

        da = New SqlDataAdapter(sql, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count
        If n = 0 Then
            Exit Sub

        Else

            'Cantidad de stock que falta para llenar la pila
            alerta = dt.Rows(0).Item("control")

            'Busco el límite de pila
            limites("pilallena")
            limi = dt8.Rows(0).Item("param_valor")

            If alerta < limi Then
                sql2 = "update stpila set stpila_llena='S' where stpila_pila='" + Str(pila) + "'"
                cmd2 = New SqlCommand(sql2, cnn)
                cmd2.Connection.Open()
                cmd2.ExecuteNonQuery()
                cmd2.Connection.Close()
            End If

        End If
    End Sub

    Private Sub txtticket_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtticket.TextChanged

    End Sub
End Class
