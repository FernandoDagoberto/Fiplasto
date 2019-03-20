Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MetroFramework
Imports MetroFramework.Controls

Public Class IngresoRemito
    Inherits MetroFramework.Forms.MetroForm

    Dim sql, sql1, sql2, sql3, sql4, sql5 As String
    Dim da, da1, da5 As New SqlDataAdapter
    Dim cmd, cmd2, cmd3, cmd4, cmd5 As SqlCommand
    Dim dt As DataTable = New DataTable
    Dim dt1 As DataTable = New DataTable
    Dim dt5 As DataTable = New DataTable
    Dim TextCol1 As New DataGridTextBoxColumn
    Dim TextCol2 As New DataGridTextBoxColumn
    Dim sen, campos, variables, idl, dias As String
    Dim line, ms As Integer
    Friend WithEvents btnbusco As MetroButton
    Friend WithEvents txtticket As MetroTextBox
    Friend WithEvents Label1 As MetroLabel
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
    Friend WithEvents btnGuardar As MetroButton
    Friend WithEvents txtpbruto As MetroTextBox
    Friend WithEvents PBar As MetroProgressBar
    Friend WithEvents txthora As MetroTextBox
    Friend WithEvents Label10 As MetroLabel
    Friend WithEvents txtpatente As MetroTextBox
    Friend WithEvents Label8 As MetroLabel
    Friend WithEvents Label11 As MetroLabel
    Friend WithEvents txtrnombre As MetroTextBox
    Friend WithEvents Label12 As MetroLabel
    Friend WithEvents txtAviso As MetroTextBox
    Friend WithEvents lblrcod As MetroLabel
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents btnSalir As MetroTile
    Friend WithEvents btnEditar As MetroTile
    Friend WithEvents BtnNuevo As MetroTile
    Friend WithEvents MetroTile1 As MetroTile
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

    Friend WithEvents btncancel As MetroButton
    Friend WithEvents Label2 As MetroLabel
    Friend WithEvents txtremito As MetroTextBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresoRemito))
        Me.btncancel = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.txtremito = New MetroFramework.Controls.MetroTextBox()
        Me.btnbusco = New MetroFramework.Controls.MetroButton()
        Me.txtticket = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txtfecha = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.txttdesc = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.txttcod = New MetroFramework.Controls.MetroTextBox()
        Me.txtpcod = New MetroFramework.Controls.MetroTextBox()
        Me.txtpdesc = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.txtchofer = New MetroFramework.Controls.MetroTextBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.txtdni = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.txtpbruto = New MetroFramework.Controls.MetroTextBox()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.PBar = New MetroFramework.Controls.MetroProgressBar()
        Me.txthora = New MetroFramework.Controls.MetroTextBox()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.txtpatente = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.txtrnombre = New MetroFramework.Controls.MetroTextBox()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.txtAviso = New MetroFramework.Controls.MetroTextBox()
        Me.lblrcod = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.btnSalir = New MetroFramework.Controls.MetroTile()
        Me.btnEditar = New MetroFramework.Controls.MetroTile()
        Me.BtnNuevo = New MetroFramework.Controls.MetroTile()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncancel.Location = New System.Drawing.Point(316, 404)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 24)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseSelectable = True
        Me.btncancel.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(20, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Remito"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtremito
        '
        Me.txtremito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtremito.CustomButton.Image = Nothing
        Me.txtremito.CustomButton.Location = New System.Drawing.Point(70, 2)
        Me.txtremito.CustomButton.Name = ""
        Me.txtremito.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtremito.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtremito.CustomButton.TabIndex = 1
        Me.txtremito.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtremito.CustomButton.UseSelectable = True
        Me.txtremito.CustomButton.Visible = False
        Me.txtremito.Lines = New String(-1) {}
        Me.txtremito.Location = New System.Drawing.Point(20, 140)
        Me.txtremito.MaxLength = 6
        Me.txtremito.Name = "txtremito"
        Me.txtremito.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtremito.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtremito.SelectedText = ""
        Me.txtremito.SelectionLength = 0
        Me.txtremito.SelectionStart = 0
        Me.txtremito.ShortcutsEnabled = True
        Me.txtremito.Size = New System.Drawing.Size(88, 20)
        Me.txtremito.TabIndex = 0
        Me.txtremito.UseSelectable = True
        Me.txtremito.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtremito.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnbusco
        '
        Me.btnbusco.Location = New System.Drawing.Point(108, 140)
        Me.btnbusco.Name = "btnbusco"
        Me.btnbusco.Size = New System.Drawing.Size(32, 20)
        Me.btnbusco.TabIndex = 1
        Me.btnbusco.Text = "..."
        Me.btnbusco.UseSelectable = True
        '
        'txtticket
        '
        '
        '
        '
        Me.txtticket.CustomButton.Image = Nothing
        Me.txtticket.CustomButton.Location = New System.Drawing.Point(70, 2)
        Me.txtticket.CustomButton.Name = ""
        Me.txtticket.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtticket.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtticket.CustomButton.TabIndex = 1
        Me.txtticket.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtticket.CustomButton.UseSelectable = True
        Me.txtticket.CustomButton.Visible = False
        Me.txtticket.Lines = New String(-1) {}
        Me.txtticket.Location = New System.Drawing.Point(20, 188)
        Me.txtticket.MaxLength = 32767
        Me.txtticket.Name = "txtticket"
        Me.txtticket.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtticket.ReadOnly = True
        Me.txtticket.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtticket.SelectedText = ""
        Me.txtticket.SelectionLength = 0
        Me.txtticket.SelectionStart = 0
        Me.txtticket.ShortcutsEnabled = True
        Me.txtticket.Size = New System.Drawing.Size(88, 20)
        Me.txtticket.TabIndex = 21
        Me.txtticket.UseSelectable = True
        Me.txtticket.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtticket.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(20, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Ticket"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtfecha
        '
        '
        '
        '
        Me.txtfecha.CustomButton.Image = Nothing
        Me.txtfecha.CustomButton.Location = New System.Drawing.Point(70, 2)
        Me.txtfecha.CustomButton.Name = ""
        Me.txtfecha.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtfecha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtfecha.CustomButton.TabIndex = 1
        Me.txtfecha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtfecha.CustomButton.UseSelectable = True
        Me.txtfecha.CustomButton.Visible = False
        Me.txtfecha.Lines = New String(-1) {}
        Me.txtfecha.Location = New System.Drawing.Point(124, 188)
        Me.txtfecha.MaxLength = 32767
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfecha.ReadOnly = True
        Me.txtfecha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtfecha.SelectedText = ""
        Me.txtfecha.SelectionLength = 0
        Me.txtfecha.SelectionStart = 0
        Me.txtfecha.ShortcutsEnabled = True
        Me.txtfecha.Size = New System.Drawing.Size(88, 20)
        Me.txtfecha.TabIndex = 23
        Me.txtfecha.UseSelectable = True
        Me.txtfecha.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtfecha.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(116, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Fecha Ingreso"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttdesc
        '
        '
        '
        '
        Me.txttdesc.CustomButton.Image = Nothing
        Me.txttdesc.CustomButton.Location = New System.Drawing.Point(374, 2)
        Me.txttdesc.CustomButton.Name = ""
        Me.txttdesc.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txttdesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttdesc.CustomButton.TabIndex = 1
        Me.txttdesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttdesc.CustomButton.UseSelectable = True
        Me.txttdesc.CustomButton.Visible = False
        Me.txttdesc.Lines = New String(-1) {}
        Me.txttdesc.Location = New System.Drawing.Point(92, 236)
        Me.txttdesc.MaxLength = 32767
        Me.txttdesc.Name = "txttdesc"
        Me.txttdesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttdesc.ReadOnly = True
        Me.txttdesc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttdesc.SelectedText = ""
        Me.txttdesc.SelectionLength = 0
        Me.txttdesc.SelectionStart = 0
        Me.txttdesc.ShortcutsEnabled = True
        Me.txttdesc.Size = New System.Drawing.Size(392, 20)
        Me.txttdesc.TabIndex = 25
        Me.txttdesc.UseSelectable = True
        Me.txttdesc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttdesc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(18, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Transporte"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttcod
        '
        '
        '
        '
        Me.txttcod.CustomButton.Image = Nothing
        Me.txttcod.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txttcod.CustomButton.Name = ""
        Me.txttcod.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txttcod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txttcod.CustomButton.TabIndex = 1
        Me.txttcod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txttcod.CustomButton.UseSelectable = True
        Me.txttcod.CustomButton.Visible = False
        Me.txttcod.Lines = New String(-1) {}
        Me.txttcod.Location = New System.Drawing.Point(20, 236)
        Me.txttcod.MaxLength = 32767
        Me.txttcod.Name = "txttcod"
        Me.txttcod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttcod.ReadOnly = True
        Me.txttcod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txttcod.SelectedText = ""
        Me.txttcod.SelectionLength = 0
        Me.txttcod.SelectionStart = 0
        Me.txttcod.ShortcutsEnabled = True
        Me.txttcod.Size = New System.Drawing.Size(69, 20)
        Me.txttcod.TabIndex = 27
        Me.txttcod.UseSelectable = True
        Me.txttcod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txttcod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtpcod
        '
        '
        '
        '
        Me.txtpcod.CustomButton.Image = Nothing
        Me.txtpcod.CustomButton.Location = New System.Drawing.Point(51, 2)
        Me.txtpcod.CustomButton.Name = ""
        Me.txtpcod.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtpcod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpcod.CustomButton.TabIndex = 1
        Me.txtpcod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpcod.CustomButton.UseSelectable = True
        Me.txtpcod.CustomButton.Visible = False
        Me.txtpcod.Lines = New String(-1) {}
        Me.txtpcod.Location = New System.Drawing.Point(20, 332)
        Me.txtpcod.MaxLength = 32767
        Me.txtpcod.Name = "txtpcod"
        Me.txtpcod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpcod.ReadOnly = True
        Me.txtpcod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpcod.SelectedText = ""
        Me.txtpcod.SelectionLength = 0
        Me.txtpcod.SelectionStart = 0
        Me.txtpcod.ShortcutsEnabled = True
        Me.txtpcod.Size = New System.Drawing.Size(69, 20)
        Me.txtpcod.TabIndex = 30
        Me.txtpcod.UseSelectable = True
        Me.txtpcod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpcod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtpdesc
        '
        '
        '
        '
        Me.txtpdesc.CustomButton.Image = Nothing
        Me.txtpdesc.CustomButton.Location = New System.Drawing.Point(374, 2)
        Me.txtpdesc.CustomButton.Name = ""
        Me.txtpdesc.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtpdesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpdesc.CustomButton.TabIndex = 1
        Me.txtpdesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpdesc.CustomButton.UseSelectable = True
        Me.txtpdesc.CustomButton.Visible = False
        Me.txtpdesc.Lines = New String(-1) {}
        Me.txtpdesc.Location = New System.Drawing.Point(92, 332)
        Me.txtpdesc.MaxLength = 32767
        Me.txtpdesc.Name = "txtpdesc"
        Me.txtpdesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpdesc.ReadOnly = True
        Me.txtpdesc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpdesc.SelectedText = ""
        Me.txtpdesc.SelectionLength = 0
        Me.txtpdesc.SelectionStart = 0
        Me.txtpdesc.ShortcutsEnabled = True
        Me.txtpdesc.Size = New System.Drawing.Size(392, 20)
        Me.txtpdesc.TabIndex = 28
        Me.txtpdesc.UseSelectable = True
        Me.txtpdesc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpdesc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(20, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Producto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtchofer
        '
        '
        '
        '
        Me.txtchofer.CustomButton.Image = Nothing
        Me.txtchofer.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.txtchofer.CustomButton.Name = ""
        Me.txtchofer.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtchofer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtchofer.CustomButton.TabIndex = 1
        Me.txtchofer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtchofer.CustomButton.UseSelectable = True
        Me.txtchofer.CustomButton.Visible = False
        Me.txtchofer.Lines = New String(-1) {}
        Me.txtchofer.Location = New System.Drawing.Point(20, 284)
        Me.txtchofer.MaxLength = 32767
        Me.txtchofer.Name = "txtchofer"
        Me.txtchofer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtchofer.ReadOnly = True
        Me.txtchofer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtchofer.SelectedText = ""
        Me.txtchofer.SelectionLength = 0
        Me.txtchofer.SelectionStart = 0
        Me.txtchofer.ShortcutsEnabled = True
        Me.txtchofer.Size = New System.Drawing.Size(232, 20)
        Me.txtchofer.TabIndex = 31
        Me.txtchofer.UseSelectable = True
        Me.txtchofer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtchofer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(20, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Chofer"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdni
        '
        '
        '
        '
        Me.txtdni.CustomButton.Image = Nothing
        Me.txtdni.CustomButton.Location = New System.Drawing.Point(70, 2)
        Me.txtdni.CustomButton.Name = ""
        Me.txtdni.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtdni.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdni.CustomButton.TabIndex = 1
        Me.txtdni.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdni.CustomButton.UseSelectable = True
        Me.txtdni.CustomButton.Visible = False
        Me.txtdni.Lines = New String(-1) {}
        Me.txtdni.Location = New System.Drawing.Point(260, 284)
        Me.txtdni.MaxLength = 32767
        Me.txtdni.Name = "txtdni"
        Me.txtdni.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdni.ReadOnly = True
        Me.txtdni.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdni.SelectedText = ""
        Me.txtdni.SelectionLength = 0
        Me.txtdni.SelectionStart = 0
        Me.txtdni.ShortcutsEnabled = True
        Me.txtdni.Size = New System.Drawing.Size(88, 20)
        Me.txtdni.TabIndex = 33
        Me.txtdni.UseSelectable = True
        Me.txtdni.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtdni.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(260, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "DNI"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(396, 404)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(88, 24)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.Visible = False
        '
        'txtpbruto
        '
        '
        '
        '
        Me.txtpbruto.CustomButton.Image = Nothing
        Me.txtpbruto.CustomButton.Location = New System.Drawing.Point(70, 2)
        Me.txtpbruto.CustomButton.Name = ""
        Me.txtpbruto.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtpbruto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpbruto.CustomButton.TabIndex = 1
        Me.txtpbruto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpbruto.CustomButton.UseSelectable = True
        Me.txtpbruto.CustomButton.Visible = False
        Me.txtpbruto.Lines = New String(-1) {}
        Me.txtpbruto.Location = New System.Drawing.Point(20, 380)
        Me.txtpbruto.MaxLength = 32767
        Me.txtpbruto.Name = "txtpbruto"
        Me.txtpbruto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpbruto.ReadOnly = True
        Me.txtpbruto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpbruto.SelectedText = ""
        Me.txtpbruto.SelectionLength = 0
        Me.txtpbruto.SelectionStart = 0
        Me.txtpbruto.ShortcutsEnabled = True
        Me.txtpbruto.Size = New System.Drawing.Size(88, 20)
        Me.txtpbruto.TabIndex = 38
        Me.txtpbruto.UseSelectable = True
        Me.txtpbruto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpbruto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(20, 364)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Peso Bruto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PBar
        '
        Me.PBar.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PBar.Location = New System.Drawing.Point(20, 412)
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(280, 10)
        Me.PBar.TabIndex = 40
        Me.PBar.Visible = False
        '
        'txthora
        '
        '
        '
        '
        Me.txthora.CustomButton.Image = Nothing
        Me.txthora.CustomButton.Location = New System.Drawing.Point(70, 2)
        Me.txthora.CustomButton.Name = ""
        Me.txthora.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txthora.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txthora.CustomButton.TabIndex = 1
        Me.txthora.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txthora.CustomButton.UseSelectable = True
        Me.txthora.CustomButton.Visible = False
        Me.txthora.Lines = New String(-1) {}
        Me.txthora.Location = New System.Drawing.Point(220, 188)
        Me.txthora.MaxLength = 32767
        Me.txthora.Name = "txthora"
        Me.txthora.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txthora.ReadOnly = True
        Me.txthora.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txthora.SelectedText = ""
        Me.txthora.SelectionLength = 0
        Me.txthora.SelectionStart = 0
        Me.txthora.ShortcutsEnabled = True
        Me.txthora.Size = New System.Drawing.Size(88, 20)
        Me.txthora.TabIndex = 41
        Me.txthora.UseSelectable = True
        Me.txthora.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txthora.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(220, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Hora Ingreso"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpatente
        '
        '
        '
        '
        Me.txtpatente.CustomButton.Image = Nothing
        Me.txtpatente.CustomButton.Location = New System.Drawing.Point(70, 2)
        Me.txtpatente.CustomButton.Name = ""
        Me.txtpatente.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtpatente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpatente.CustomButton.TabIndex = 1
        Me.txtpatente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpatente.CustomButton.UseSelectable = True
        Me.txtpatente.CustomButton.Visible = False
        Me.txtpatente.Lines = New String(-1) {}
        Me.txtpatente.Location = New System.Drawing.Point(164, 140)
        Me.txtpatente.MaxLength = 32767
        Me.txtpatente.Name = "txtpatente"
        Me.txtpatente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpatente.ReadOnly = True
        Me.txtpatente.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpatente.SelectedText = ""
        Me.txtpatente.SelectionLength = 0
        Me.txtpatente.SelectionStart = 0
        Me.txtpatente.ShortcutsEnabled = True
        Me.txtpatente.Size = New System.Drawing.Size(88, 20)
        Me.txtpatente.TabIndex = 43
        Me.txtpatente.UseSelectable = True
        Me.txtpatente.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpatente.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(161, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Patente"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(322, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Proveedor"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtrnombre
        '
        '
        '
        '
        Me.txtrnombre.CustomButton.Image = Nothing
        Me.txtrnombre.CustomButton.Location = New System.Drawing.Point(144, 2)
        Me.txtrnombre.CustomButton.Name = ""
        Me.txtrnombre.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtrnombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtrnombre.CustomButton.TabIndex = 1
        Me.txtrnombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtrnombre.CustomButton.UseSelectable = True
        Me.txtrnombre.CustomButton.Visible = False
        Me.txtrnombre.Lines = New String(-1) {}
        Me.txtrnombre.Location = New System.Drawing.Point(322, 188)
        Me.txtrnombre.MaxLength = 32767
        Me.txtrnombre.Name = "txtrnombre"
        Me.txtrnombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrnombre.ReadOnly = True
        Me.txtrnombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtrnombre.SelectedText = ""
        Me.txtrnombre.SelectionLength = 0
        Me.txtrnombre.SelectionStart = 0
        Me.txtrnombre.ShortcutsEnabled = True
        Me.txtrnombre.Size = New System.Drawing.Size(162, 20)
        Me.txtrnombre.TabIndex = 46
        Me.txtrnombre.UseSelectable = True
        Me.txtrnombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtrnombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(336, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Aviso"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAviso
        '
        '
        '
        '
        Me.txtAviso.CustomButton.Image = Nothing
        Me.txtAviso.CustomButton.Location = New System.Drawing.Point(121, 2)
        Me.txtAviso.CustomButton.Name = ""
        Me.txtAviso.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtAviso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAviso.CustomButton.TabIndex = 1
        Me.txtAviso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAviso.CustomButton.UseSelectable = True
        Me.txtAviso.CustomButton.Visible = False
        Me.txtAviso.Lines = New String(-1) {}
        Me.txtAviso.Location = New System.Drawing.Point(293, 140)
        Me.txtAviso.MaxLength = 32767
        Me.txtAviso.Name = "txtAviso"
        Me.txtAviso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAviso.ReadOnly = True
        Me.txtAviso.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAviso.SelectedText = ""
        Me.txtAviso.SelectionLength = 0
        Me.txtAviso.SelectionStart = 0
        Me.txtAviso.ShortcutsEnabled = True
        Me.txtAviso.Size = New System.Drawing.Size(139, 20)
        Me.txtAviso.TabIndex = 47
        Me.txtAviso.UseSelectable = True
        Me.txtAviso.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAviso.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblrcod
        '
        Me.lblrcod.AutoSize = True
        Me.lblrcod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblrcod.Location = New System.Drawing.Point(429, 172)
        Me.lblrcod.Name = "lblrcod"
        Me.lblrcod.Size = New System.Drawing.Size(0, 0)
        Me.lblrcod.TabIndex = 49
        Me.lblrcod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanel1.Controls.Add(Me.MetroTile1)
        Me.MetroPanel1.Controls.Add(Me.btnSalir)
        Me.MetroPanel1.Controls.Add(Me.btnEditar)
        Me.MetroPanel1.Controls.Add(Me.BtnNuevo)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(466, 41)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroPanel1.TabIndex = 50
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroTile1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTile1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MetroTile1.Location = New System.Drawing.Point(267, 0)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(199, 41)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile1.TabIndex = 8
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'btnSalir
        '
        Me.btnSalir.ActiveControl = Nothing
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Location = New System.Drawing.Point(178, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 41)
        Me.btnSalir.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.TileImage = CType(resources.GetObject("btnSalir.TileImage"), System.Drawing.Image)
        Me.btnSalir.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnSalir.UseSelectable = True
        Me.btnSalir.UseTileImage = True
        '
        'btnEditar
        '
        Me.btnEditar.ActiveControl = Nothing
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEditar.Location = New System.Drawing.Point(89, 0)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(89, 41)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TileImage = CType(resources.GetObject("btnEditar.TileImage"), System.Drawing.Image)
        Me.btnEditar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnEditar.UseSelectable = True
        Me.btnEditar.UseTileImage = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.ActiveControl = Nothing
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnNuevo.Location = New System.Drawing.Point(0, 0)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(89, 41)
        Me.BtnNuevo.TabIndex = 2
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.TileImage = CType(resources.GetObject("BtnNuevo.TileImage"), System.Drawing.Image)
        Me.BtnNuevo.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.BtnNuevo.UseSelectable = True
        Me.BtnNuevo.UseTileImage = True
        '
        'IngresoRemito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(506, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.lblrcod)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtAviso)
        Me.Controls.Add(Me.txtrnombre)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpatente)
        Me.Controls.Add(Me.txthora)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PBar)
        Me.Controls.Add(Me.txtpbruto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnGuardar)
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
        Me.Controls.Add(Me.txtticket)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnbusco)
        Me.Controls.Add(Me.txtremito)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IngresoRemito"
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ingreso Remito"
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub IngresoRemito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call bloquea()
        BtnNuevo.Enabled = True
        btnEditar.Enabled = True


    End Sub

    Private Sub Opcion(sender As Object, e As EventArgs) Handles BtnNuevo.Click, btnSalir.Click, btnGuardar.Click, btnEditar.Click
        'Busco la opción por el nombre del botón
        Select Case sender.Name

            Case BtnNuevo.Name ' boton nuevo
                sen = "n"
                btncancel.Visible = True
                btnGuardar.Visible = True
                btnEditar.Enabled = False
                Call habilita()
                txtremito.Focus()

            Case btnEditar.Name 'boton editar
                sen = "m"
                btncancel.Visible = True
                btnGuardar.Visible = True
                BtnNuevo.Enabled = False
                Call habilita()
                Call modifica()

            Case btnGuardar.Name 'boton guardar
                If txtremito.Text = "" Then
                    MetroMessageBox.Show(Me, "Favor de ingresar número de remito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtremito.Focus()
                    txtremito.Select()
                Else
                    Call buscasiexiste()
                    If n = 0 Or sen = "m" Then
                        Call guardar()
                    Else
                        Call yaexiste()
                    End If
                End If
            Case btnSalir.Name ' boton salir
                Me.Close()
        End Select
    End Sub



    Private Sub guardar()

        Call guardanuevo()
        Call limpia()
        If BtnNuevo.Enabled = False Then BtnNuevo.Enabled = True
        If btnEditar.Enabled = False Then btnEditar.Enabled = False

        btncancel.Visible = False
        btnGuardar.Visible = False


    End Sub
    Private Sub modifica()
        txtremito.Focus()
    End Sub
    Private Sub habilita()
        txtremito.Enabled = True
        txtpatente.Enabled = True
    End Sub
    Private Sub deshabilita()
        txtremito.Enabled = False
        txtpatente.Enabled = False
    End Sub
    Private Sub limpia()
        txtremito.Text = ""
        txtpatente.Text = ""
        txtticket.Text = ""
        txtfecha.Text = ""
        txthora.Text = ""
        txtrnombre.Text = ""
        txttcod.Text = ""
        txttdesc.Text = ""
        txtchofer.Text = ""
        txtdni.Text = ""
        txtpcod.Text = ""
        txtpdesc.Text = ""
        txtpbruto.Text = ""
        txtAviso.Text = ""
    End Sub
    Private Sub buscadatos(ByVal remito)
        Dim i As Integer
        conex("tipmadera")
        sql1 = "select tipmad_codbalanza as tipo from tipmad"
        da = New SqlDataAdapter(sql1, cnn)
        dt = New DataTable
        da.Fill(dt)
        n = dt.Rows.Count
        If n > 0 Then
            var = ""
            For i = 0 To n - 1
                var1 = Trim(dt.Rows(i).Item("tipo"))
                If i < (n - 1) Then
                    var = var + var1 + ", "
                Else
                    var = var + var1
                End If
            Next
        Else
            MetroMessageBox.Show(Me, "No existen relacion entre codigo de tipo de madera y codigo de balanza", MsgBoxStyle.Critical)
        End If

        If sen = "n" Then
            conexA("camion")
            sql = "SELECT * From REPORTE WHERE aux3='" + RTrim(remito) + "' and p_codigo in (" + var + ") "
            daA = New OleDbDataAdapter(sql, cnnA)
            dt = New DataTable
            daA.Fill(dt)
            cnnA.Close()
            n = dt.Rows.Count
        Else
            conex("Camion")
            sql5 = "SELECT * From camion where camion_patente='" + RTrim(remito) + "' and camion_pesoneto is null"
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
        txtremito.Enabled = False
    End Sub


    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        sen = "m"
        btncancel.Visible = True
        BtnNuevo.Enabled = False
        btnEditar.Enabled = False
        btnGuardar.Visible = True
        Call habilita()
        Call modifica()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Call limpia()
        BtnNuevo.Enabled = True
        btnEditar.Enabled = True
        Call deshabilita()
        btncancel.Visible = False
        btnGuardar.Visible = False

    End Sub
    Private Sub guardanuevo()
        btncancel.Visible = False
        btnGuardar.Visible = False
        conex("Camion")
        sql5 = "SELECT * From camion where camion_nroremito='" + txtremito.Text + "' and camion_fechaing='" + Trim(txtfecha.Text) + "' and camion_horaing='" + FormatDateTime(Trim(txthora.Text), DateFormat.ShortTime) + "';"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        n = dt5.Rows.Count
        If n = 0 Or sen <> "n" Then
            If sen = "n" Then
                campos = "camion_patente, camion_ticket, camion_fechaing,camion_tcod, camion_tdesc,camion_horaing," &
                         "camion_chofer, camion_dni,camion_pcod, camion_pdesc,camion_nroremito, camion_pesobruto,camion_marca,camion_rcod,camion_rnombre,camion_aviso" ' 
                variables = "'" + Trim(txtpatente.Text) + "','" + Trim(txtticket.Text) + "', '" + Trim(txtfecha.Text) + "'," &
                            "'" + Trim(txttcod.Text) + "', '" + Trim(txttdesc.Text) + "','" + FormatDateTime(Trim(txthora.Text), DateFormat.ShortTime) + "'," &
                            "'" + Trim(txtchofer.Text) + "', '" + Trim(txtdni.Text) + "','" + Trim(txtpcod.Text) + "'," &
                            "'" + Trim(txtpdesc.Text) + "','" + Trim(txtremito.Text) + "','" + Trim(txtpbruto.Text) + "','M'," + lblrcod.Text + ",'" + Trim(txtrnombre.Text) + "','" + Trim(txtAviso.Text) + "'"
                sql3 = "INSERT INTO camion (" + campos + ") VALUES (" + variables + ")" '
                cmd3 = New SqlCommand(sql3, cnn)
                cmd3.Connection.Open()
                cmd3.ExecuteNonQuery()
                cmd3.Connection.Close()
            Else
                sql2 = "update camion set camion_nroremito='" + Trim(txtpatente.Text) + "'" &
                       " where camion_patente='" + txtremito.Text + "' and camion_ticket='" + Trim(txtticket.Text) + "' "
                cmd2 = New SqlCommand(sql2, cnn)
                cmd2.Connection.Open()
                cmd2.ExecuteNonQuery()
                cmd2.Connection.Close()
            End If
            Call bloquea()
            barra(PBar)
        Else
            txtremito.Focus()
            btncancel.Visible = True
            btnGuardar.Visible = True
        End If
    End Sub



    Private Sub btnbusco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbusco.Click
        Call busco()

    End Sub
    Private Sub busco()
        Call buscadatos(txtremito.Text)
        If n <> 0 And sen = "n" Then
            txtpatente.Text = dt.Rows(0).Item("patente")
            txtticket.Text = dt.Rows(0).Item("ticket")
            txtfecha.Text = dt.Rows(0).Item("fecha_1")
            txthora.Text = dt.Rows(0).Item("hora_1")
            lblrcod.Text = dt.Rows(0).Item("r_codigo")
            txtrnombre.Text = dt.Rows(0).Item("r_nombre")
            txttcod.Text = dt.Rows(0).Item("t_codigo")
            txttdesc.Text = dt.Rows(0).Item("t_nombre")
            txtchofer.Text = dt.Rows(0).Item("chofer")
            txtdni.Text = Format(dt.Rows(0).Item("dni"), "##.###.###")
            txtpcod.Text = dt.Rows(0).Item("p_codigo")
            txtpdesc.Text = dt.Rows(0).Item("p_nombre")
            txtpbruto.Text = Format(dt.Rows(0).Item("bruto"), "0#.##")

            Try

                If IsDBNull(dt.Rows(0).Item("aux4")) Or dt.Rows(0).Item("aux4") = "" Then
                    txtAviso.Text = FormatDateTime(txtfecha.Text & " " & txthora.Text)
                Else

                    camAviso = Format(txtfecha.Text & " " & dt.Rows(0).Item("aux4"))

                    If camAviso > FormatDateTime(txtfecha.Text & " " & txthora.Text) Then
                        txtAviso.Text = camAviso.AddDays(-1)
                    Else
                        txtAviso.Text = camAviso

                    End If
                End If

            Catch
                txtAviso.Text = FormatDateTime(txtfecha.Text & " " & txthora.Text)
            End Try

        ElseIf n <> 0 And sen = "m" Then
            txtticket.Text = dt5.Rows(0).Item("camion_ticket")
            txtfecha.Text = dt5.Rows(0).Item("camion_fechaing")
            txthora.Text = dt5.Rows(0).Item("camion_horaing")
            lblrcod.Text = dt5.Rows(0).Item("camion_rcod")
            txtrnombre.Text = dt.Rows(0).Item("camion_rnombre")
            txttcod.Text = dt5.Rows(0).Item("camion_tcod")
            txttdesc.Text = dt5.Rows(0).Item("camion_tdesc")
            txtchofer.Text = dt5.Rows(0).Item("camion_chofer")
            txtdni.Text = Format(CInt(dt5.Rows(0).Item("camion_dni")), "0#.###.###")
            txtpcod.Text = dt5.Rows(0).Item("camion_pcod")
            txtpdesc.Text = dt5.Rows(0).Item("camion_pdesc")
            txtpbruto.Text = Format(dt5.Rows(0).Item("camion_pesobruto"), "0#.##")
            txtpatente.Text = Trim(dt5.Rows(0).Item("camion_nroremito"))
        Else
            MetroMessageBox.Show(Me, "La patente no pertenece a un camión con madera", "Atención", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If String.IsNullOrEmpty(txtremito.Text) Then
            MetroMessageBox.Show(Me, "Favor de ingresar número de remito", "Atención", MessageBoxButtons.OK)
            txtremito.Focus()
            txtremito.Select()
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
        MetroMessageBox.Show(Me, "Ese camion ya tiene cargado el Remito", "Atención", MessageBoxButtons.OK)
        Call limpia()
        txtremito.Focus()
        n = 0
    End Sub
    Private Sub buscasiexiste()
        conex("Camion")
        sql5 = "SELECT * From camion where camion_nroremito='" + txtremito.Text + "' and camion_fechaing='" + Trim(txtfecha.Text) + "' and camion_horaing='" + FormatDateTime(Trim(txthora.Text), DateFormat.ShortTime) + "';"
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        n = dt5.Rows.Count
    End Sub




End Class
