Imports System.IO
Imports System.Drawing.Image
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class PIModiCarga

    Inherits System.Windows.Forms.Form
    Dim sql, sql1, sql2, sql3, sql4, sql5 As String
    Dim da, da1, da3, da5 As New SqlDataAdapter
    Dim cmd, cmd2, cmd3, cmd4, cmd5 As SqlCommand
    Dim dt As DataTable = New DataTable
    Dim dt1 As DataTable = New DataTable
    Dim dt3 As DataTable = New DataTable
    Dim dt5 As DataTable = New DataTable
    Dim TextCol1 As New DataGridTextBoxColumn
    Dim TextCol2 As New DataGridTextBoxColumn
    Dim sen, sen1, sen2, campos, variables, idl, dias As String
    Dim conforme, destino, rechazado As String
    Dim pendiente, reporte As String
    Dim line, ms As Integer
    Dim mensaje As String
    Dim alerta As String
    Dim cargamanual As String
    Friend WithEvents btnbusco As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbgrupo As System.Windows.Forms.ComboBox
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dthora As System.Windows.Forms.DateTimePicker
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents txthhegr As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbturno As System.Windows.Forms.ComboBox

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
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtremito As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PIModiCarga))
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btncancel = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtremito = New System.Windows.Forms.TextBox
        Me.btnbusco = New System.Windows.Forms.Button
        Me.btnguardar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbgrupo = New System.Windows.Forms.ComboBox
        Me.cbturno = New System.Windows.Forms.ComboBox
        Me.dtfecha = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dthora = New System.Windows.Forms.DateTimePicker
        Me.gb1 = New System.Windows.Forms.GroupBox
        Me.txthhegr = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3, Me.ToolBarButton5, Me.ToolBarButton4})
        Me.ToolBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(339, 29)
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
        Me.ToolBarButton2.Visible = False
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
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncancel.Location = New System.Drawing.Point(19, 224)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 24)
        Me.btncancel.TabIndex = 4
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseVisualStyleBackColor = False
        Me.btncancel.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(22, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Remito"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtremito
        '
        Me.txtremito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtremito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtremito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremito.Location = New System.Drawing.Point(11, 51)
        Me.txtremito.MaxLength = 6
        Me.txtremito.Name = "txtremito"
        Me.txtremito.Size = New System.Drawing.Size(88, 20)
        Me.txtremito.TabIndex = 1
        Me.txtremito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnbusco
        '
        Me.btnbusco.Location = New System.Drawing.Point(99, 51)
        Me.btnbusco.Name = "btnbusco"
        Me.btnbusco.Size = New System.Drawing.Size(32, 20)
        Me.btnbusco.TabIndex = 2
        Me.btnbusco.Text = "..."
        Me.btnbusco.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(99, 224)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(88, 24)
        Me.btnguardar.TabIndex = 5
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        Me.btnguardar.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(9, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Grupo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(8, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Turno"
        '
        'cbgrupo
        '
        Me.cbgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbgrupo.FormattingEnabled = True
        Me.cbgrupo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbgrupo.Location = New System.Drawing.Point(11, 103)
        Me.cbgrupo.Name = "cbgrupo"
        Me.cbgrupo.Size = New System.Drawing.Size(86, 21)
        Me.cbgrupo.TabIndex = 48
        '
        'cbturno
        '
        Me.cbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cbturno.Location = New System.Drawing.Point(11, 67)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(86, 21)
        Me.cbturno.TabIndex = 47
        '
        'dtfecha
        '
        Me.dtfecha.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(9, 30)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(88, 20)
        Me.dtfecha.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Fecha y hora"
        '
        'dthora
        '
        Me.dthora.CustomFormat = "HH:mm:ss"
        Me.dthora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dthora.Location = New System.Drawing.Point(103, 30)
        Me.dthora.Name = "dthora"
        Me.dthora.Size = New System.Drawing.Size(79, 20)
        Me.dthora.TabIndex = 53
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.dthora)
        Me.gb1.Controls.Add(Me.Label4)
        Me.gb1.Controls.Add(Me.Label1)
        Me.gb1.Controls.Add(Me.cbgrupo)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Controls.Add(Me.dtfecha)
        Me.gb1.Controls.Add(Me.cbturno)
        Me.gb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gb1.Location = New System.Drawing.Point(11, 78)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(200, 140)
        Me.gb1.TabIndex = 54
        Me.gb1.TabStop = False
        Me.gb1.Text = "Modificar datos"
        '
        'txthhegr
        '
        Me.txthhegr.Enabled = False
        Me.txthhegr.Location = New System.Drawing.Point(137, 52)
        Me.txthhegr.Name = "txthhegr"
        Me.txthhegr.Size = New System.Drawing.Size(186, 20)
        Me.txthhegr.TabIndex = 54
        Me.txthhegr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(138, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 14)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Fecha y hora de Egreso del Camión"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PIModiCarga
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(339, 277)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtremito)
        Me.Controls.Add(Me.btnbusco)
        Me.Controls.Add(Me.txthhegr)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.gb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PIModiCarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Modificación de carga Remito"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub PIModiCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call bloquea()
        ToolBar1.Buttons(3).Enabled = False
        ToolBar1.Buttons(1).Enabled = True
        ToolBar1.Buttons(2).Enabled = False
        sen1 = 0
        sen2 = 0

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
                txtremito.Focus()

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

                Call guardanuevo()


            Case 4 ' boton salir

                Me.Close()
        End Select
    End Sub

    Private Sub modifica()
        txtremito.Focus()
    End Sub
    Private Sub habilita()
        txtremito.Enabled = True
    End Sub

    Private Sub permiteCarga()
        txtremito.Enabled = False
        gb1.Enabled = True

    End Sub


    Private Sub bloquea()
        txtremito.Enabled = False
        gb1.Enabled = False

    End Sub
    Private Sub limpia()
        txtremito.Text = ""
        cbturno.Text = ""
        cbgrupo.Text = ""
        dtfecha.Value = Now
        dthora.Value = Now
        txthhegr.Text = ""

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
        Call bloquea()
        btncancel.Visible = False
        btnguardar.Visible = False
        ToolBar1.Focus()
    End Sub


    Private Sub guardanuevo()
        If cbturno.Text = "" Or cbgrupo.Text = "" Then
            mensaje = "Favor de completar los campos Turno y Grupo"
            MsgBox("" + mensaje + "", MsgBoxStyle.Exclamation)
            cbturno.Focus()
            sen1 = 99
            Exit Sub
        End If

        Dim fhcarga As DateTime
        fhcarga = dtfecha.Text & " " & dthora.Text

        sql3 = "UPDATE MARMV set marmv_fecha='" + fhcarga + "',marmv_turno='" + cbturno.Text + "', marmv_grupo='" + cbgrupo.Text + "' where marmv_nroremito='" + Trim(txtremito.Text) + "'"
        cmd3 = New SqlCommand(sql3, cnn)
        cmd3.Connection.Open()
        cmd3.ExecuteNonQuery()
        cmd3.Connection.Close()

        MsgBox("Datos actualizados")
        Call limpia()
        Call bloquea()


    End Sub



    Private Sub btnbusco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbusco.Click

        Call buscasiexisteremito()

        If n = 1 Then
            Call buscaHHEgreso()
            If n = 1 Then
                txthhegr.Text = FormatDateTime(dt2.Rows(0).Item("camion_fechaegr"), DateFormat.ShortDate) & " " & FormatDateTime(dt2.Rows(0).Item("camion_horaegr"), DateFormat.ShortTime)
            End If

            Call permiteCarga()
            Call cargadatos()
        Else

            MsgBox("No existe movimiento de ese número de remito")
            txtremito.Text = ""
            Call bloquea()

        End If


    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If txtremito.Text = "" Then
            MsgBox("El campo Nro remito es obligatorio", MsgBoxStyle.Critical)
            txtremito.Focus()
            txtremito.SelectAll()

        Else

            Call guardanuevo()
            If sen1 = 99 Then
                sen1 = 0
                Exit Sub
            End If

            Call limpia()
            Call bloquea()
            If ToolBar1.Buttons(0).Enabled = False Then ToolBar1.Buttons(0).Enabled = True
            If ToolBar1.Buttons(1).Enabled = False Then ToolBar1.Buttons(1).Enabled = False
            If ToolBar1.Buttons(2).Enabled = False Then ToolBar1.Buttons(2).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            btncancel.Visible = False
            btnguardar.Visible = False
        End If


    End Sub

    Private Sub buscaHHEgreso()
        conex("camion")
        sql2 = "SELECT camion_fechaegr,camion_horaegr From camion where camion_nroremito='" + txtremito.Text + "'"
        da2 = New SqlDataAdapter(sql2, cnn)
        dt2 = New DataTable
        da2.Fill(dt2)
        n = dt2.Rows.Count
    End Sub



    Private Sub txtremito_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtremito.KeyUp
        If e.KeyCode = Keys.Enter Then

            Call buscasiexisteremito()

            If n = 1 Then
                Call buscaHHEgreso()
                If n = 1 Then
                    txthhegr.Text = FormatDateTime(dt2.Rows(0).Item("camion_fechaegr"), DateFormat.ShortDate) & " " & FormatDateTime(dt2.Rows(0).Item("camion_horaegr"), DateFormat.ShortTime)
                End If

                Call permiteCarga()
                Call cargadatos()
            Else

                MsgBox("No existe movimiento de ese número de remito")
                txtremito.Text = ""
                Call bloquea()

            End If
        End If
    End Sub


    Private Sub cargadatos()
        dtfecha.Text = FormatDateTime(dt5.Rows(0).Item("marmv_fecha"), DateFormat.ShortDate)
        dthora.Text = FormatDateTime(dt5.Rows(0).Item("marmv_fecha"), DateFormat.ShortTime)
        cbturno.Text = dt5.Rows(0).Item("marmv_turno")
        cbgrupo.Text = dt5.Rows(0).Item("marmv_grupo")
    End Sub



    Private Sub buscasiexisteremito()
        conex("marmv")
        sql5 = "SELECT * From MARMV where marmv_nroremito='" + txtremito.Text + "'and marmv_ingegr='I' "
        da5 = New SqlDataAdapter(sql5, cnn)
        dt5 = New DataTable
        da5.Fill(dt5)
        Application.DoEvents()
        n = dt5.Rows.Count
    End Sub

 




End Class
